using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplicationMVCBatch3.TagHelpers
{

    [HtmlTargetElement("CustomeHeading")]
    public class Heading : TagHelper
    {
        //process --> helps define our tags in MVC


        public string Name { get; set; } = "To Login !";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // am creating Heding tag dynamically

            //H1 - h6

            // name from database

            output.TagName = "h3";

            output.Content.SetContent($"Welcome {Name}!");

        }
    }
}