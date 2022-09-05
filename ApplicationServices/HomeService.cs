using System.Collections.Generic;
using RssView.Core;
using RssView.DomainServices;
using RssView.GeneralServices;

namespace RssView.ApplicationServices
{
    public class HomeService
    {
        private readonly SettingsService _settingsService;
        private readonly PostService _postService;
        public HomeService(SettingsService settingsService, PostService postService)
        {
            _settingsService = settingsService;
            _postService = postService;
        }

        public IEnumerable<Post> GetAllPostsFromRss()
        {
            return _postService.GetAllPosts(_settingsService.Urls);
        }
    }
}
