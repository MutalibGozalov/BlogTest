using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RNET102.UI.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "code.edu.az";
        public string MailTo { get; set; } = null!;
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            string adress = MailTo + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + adress);
            output.Content.SetContent(adress);
        }
    }
}
