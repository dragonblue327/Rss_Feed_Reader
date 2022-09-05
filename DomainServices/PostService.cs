using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Xml;
using RssView.Core;
using RssView.GeneralServices;
using Microsoft.Extensions.Caching.Memory;

namespace RssView.DomainServices
{
    public class PostService
    {
        private int FrequencyRefreshInSeconds { get; set; }
        private readonly IMemoryCache _memoryCache;
        private readonly SettingsService _settingsService;

        public PostService(IMemoryCache memoryCache, SettingsService settingsService)
        {
            _memoryCache = memoryCache;
            _settingsService = settingsService;
            FrequencyRefreshInSeconds = _settingsService.FrequencyRefreshInSeconds;
        }
        public static List<Post> GetPosts(string url)
        {
            List<Post> posts = new List<Post>();
            try
            {
               
                string feedString;
                using (var webClient = new WebClient())
                {
                    feedString = webClient.DownloadString(url);
                }
                var stringReader = new StringReader(feedString);
                XmlReader reader = XmlReader.Create(stringReader);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                foreach (SyndicationItem item in feed.Items)
                {
                    Post post = new Post();
                    post.Description = item.Summary.Text;
                    post.Link = item.Links.First().Uri.ToString();
                    post.PubDate = item.PublishDate.ToString().Split()[0];
                    post.Title = item.Title.Text;
                    posts.Add(post);

                }
                return posts;
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Post> GetAllPosts(IEnumerable<string> urls)
        {
            var postsFromCache = _memoryCache.Get<IEnumerable<Post>>("posts");
            if (postsFromCache != null && FrequencyRefreshInSeconds == _settingsService.FrequencyRefreshInSeconds)
            {
                return postsFromCache;
            }
            else
            {
                FrequencyRefreshInSeconds = _settingsService.FrequencyRefreshInSeconds;
                List<Post> allPosts = new List<Post>();
                foreach (var url in urls)
                {
                    var posts = GetPosts(url);
                    if (posts != null) allPosts.AddRange(posts);
                }
                if (allPosts.Any())
                {
                    _memoryCache.Set("posts", allPosts,
                        new MemoryCacheEntryOptions().SetAbsoluteExpiration(
                            TimeSpan.FromSeconds(_settingsService.FrequencyRefreshInSeconds)));
                }
                return allPosts;
            }
        }
    }
}

