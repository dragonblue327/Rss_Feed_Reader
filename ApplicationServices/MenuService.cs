using RssView.GeneralServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RssView.DomainServices;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RssView.ApplicationServices
{
    public class MenuService
    {
        private readonly SettingsService _settingsService;
        public MenuService(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public IEnumerable<string> GetUrls()
        {
            return _settingsService.Urls;
        }

        public int GetFrequencyRefreshInSerconds()
        {
            return _settingsService.FrequencyRefreshInSeconds;
        }

        public bool DeleteUrl(string url)
        {
            return _settingsService.Urls.Remove(url);
        }

        public bool CheckUrl(string url)
        {
            var posts = PostService.GetPosts(url);
            bool isUnique = !_settingsService.Urls.Contains(url);
            return posts != null && isUnique;
        }

        public void AddUrl(string url)
        {
            _settingsService.Urls.Add(url);
            
        }

        public void ChangeFrequency(string frequency)
        {
            _settingsService.FrequencyRefreshInSeconds = Int32.Parse(frequency)*60;
        }
    }
}
