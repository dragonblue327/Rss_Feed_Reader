#pragma checksum "C:\Users\Nouri\Desktop\exercise2\Views\Home\Partials\_Feed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3d53de7d12af1ea7d50f05f9927bba16ca198ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Partials__Feed), @"mvc.1.0.view", @"/Views/Home/Partials/_Feed.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Nouri\Desktop\exercise2\Views\_ViewImports.cshtml"
using RssView;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3d53de7d12af1ea7d50f05f9927bba16ca198ae", @"/Views/Home/Partials/_Feed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccd9e554788cf4f3ce114c8db22a58365384eee", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Partials__Feed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RssView.Core.Post>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<link href=\"./css/FeedStyle.css\" rel=\"stylesheet\" type=\"text/css\" />\n\n<div style=\"border: 1px solid black; margin-top: 5px; width: 100%;\">\n    <div class=\"col-12\">\n        <label class=\"col-4\">");
#nullable restore
#line 8 "C:\Users\Nouri\Desktop\exercise2\Views\Home\Partials\_Feed.cshtml"
                        Write(Model.PubDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n    </div>\n    <div class=\"col-12\">\n        <a");
            BeginWriteAttribute("href", " href=\"", 289, "\"", 307, 1);
#nullable restore
#line 11 "C:\Users\Nouri\Desktop\exercise2\Views\Home\Partials\_Feed.cshtml"
WriteAttributeValue("", 296, Model.Link, 296, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-5\">");
#nullable restore
#line 11 "C:\Users\Nouri\Desktop\exercise2\Views\Home\Partials\_Feed.cshtml"
                                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n    </div>\n    <div id=\"description\" class=\"col-12\">\n        <div>");
#nullable restore
#line 14 "C:\Users\Nouri\Desktop\exercise2\Views\Home\Partials\_Feed.cshtml"
        Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n</div>\n\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RssView.Core.Post> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
