using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplicationMVCBatch3.TagHelpers
{

    [HtmlTargetElement("CustomeBtn")]
    public class myBtn : TagHelper
    {

        public string buttonText { get; set; } = "Save Changes";
        public string ButtonType { get; set; } = "submit";
        public string ButtonClass { get; set; } = "btn btn-primary";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // am creating button tag dynamically
            //button
            //input type = "button"
            output.TagName = "button";
            output.Attributes.SetAttribute("class", ButtonClass);
            output.Attributes.SetAttribute("type", ButtonType);
            output.Content.SetContent(buttonText);
        }
    }
}