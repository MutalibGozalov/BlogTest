using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RNET102.UI.TagHelpers;

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

public class CustomActionTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        string actionMenu = """
         <div class='dropdown'>
             <button class='btn btn-secondary dropdown-toggle' type='button' id='dropdownMenuButton' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>
              Dropdown button
             </button>
            <div class='dropdown-menu' aria-labelledby='dropdownMenuButton'>
              <a class='dropdown-item' href="#">Action</a>
              <a class='dropdown-item' href="#">Another action</a>
              <a class='dropdown-item' href="#">Something else here</a>
            </div>
         </div>
         """;

        output.Content.SetHtmlContent(actionMenu);
        base.Process(context, output);
    }
}
