using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Mvc.TagHelpers;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.Framework.WebEncoders;

namespace hiro.TagHelpers
{
    [TargetElement("asp-example")]
    public class PrettifyTagHelper : TagHelper
    {
        [Activate]
        protected internal ViewContext Context { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {

            var code = new TagBuilder("code");

            code.AddCssClass("language-html");
            code.MergeAttribute("data-lang", "html");
            var childContent = await context.GetChildContentAsync();
            code.InnerHtml = HtmlEncoder.Default.HtmlEncode(childContent.GetContent());
            output.TagName = "";
            output.Content.Append($"<div class=\"bs-example\" data-example-id=\"btn-tags\">{childContent.GetContent()}</div>");
            output.Content.Append("<div class=\"zero-clipboard\"><span class=\"btn-clipboard\">Copy</span></div>");
            output.Content.Append($"<div class=\"highlight\"><pre>{code}</pre></div>");

        }
    }
}