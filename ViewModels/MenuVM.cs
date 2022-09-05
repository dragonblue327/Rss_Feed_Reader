using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RssView.ViewModels
{
    public class MenuVM
    {
        [Range(1, int.MaxValue, ErrorMessage = "Number must be positive")]
        [Display(Name = "Update frequency:")]
        public int FrequencyRefreshInMinutes { get; set; }
        [Url(ErrorMessage = "Please enter a valid Url")]
        [Display(Name="Rss-ленты:")]
        public IEnumerable<SelectListItem> Urls { get; set; }

    }
}
