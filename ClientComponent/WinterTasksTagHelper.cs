using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Winter.Component
{
    public class WinterTasksTagHelper : TagHelper
    {

        public string Message { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;
            output.Content.AppendHtml($"<h4>{Message}</h4>");
        }
    }
}

