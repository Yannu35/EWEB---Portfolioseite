using Microsoft.AspNetCore.Razor.TagHelpers;

namespace EWEB___Portfolioseite.Models
{
    public class KontaktViewModel
    {
        [HtmlAttributeName("KontaktName")]
        public string Name { get; set; } 
        public string Text { get; set; }
        public string KontaktformularText { get; set; }
    }
}
