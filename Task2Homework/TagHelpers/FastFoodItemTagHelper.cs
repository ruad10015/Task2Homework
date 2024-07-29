using Task2Homework.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Task2Homework.TagHelpers
{
    [HtmlTargetElement("fast-food")]
    public class FastFoodItemTagHelper : TagHelper
    {
        const string fastFood = "fastfood";

        [HtmlAttributeName(fastFood)]
        public FastFood FastFood { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "li";
            output.Attributes.SetAttribute("style", "padding:15px 20px;width:220px;height:480px;text-align:center;display:flex;flex-direction:column;gap:10px;justify-content:center;align-items:center;border-radius:10px;border:3px solid black;");
            var content = $@"
<h2 style='font-weight:bolder'>{FastFood.Name}</h2>
<p>Description : {FastFood.Description}</p>
<p>Price without discount : ${FastFood.Price}</p>
<p style='color:red'>Discount : {FastFood.Discount}%</p>
<a href='FastFood/Delete/{FastFood.Id}'>Delete</a>
<a href='FastFood/Edit/{FastFood.Id}'>Edit</a>
";
            output.Content.SetHtmlContent(content);
        }
    }
}
