namespace MongoBlog.HtmlHelpers
{
    using System.Collections.Generic;
    using System.Text.Encodings.Web;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using NewsBlogCoreMongo.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Routing;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }

        
        [ViewContext] 
        [HtmlAttributeNotBound] 
        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }

        public string PageAction { get; set; }

        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; } = new Dictionary<string, object>();


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            output.TagName = "div";

            output.AddClass("page_numbers", HtmlEncoder.Default);

            TagBuilder tagUl = new TagBuilder("ul");


            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder item = new TagBuilder("li");
                TagBuilder link = new TagBuilder("a");
                PageUrlValues["page"] = i;
                link.Attributes["href"] = urlHelper.Action(PageAction, PageUrlValues);


                if (i == PageModel.CurrentPage)
                {
                    item.AddCssClass("active");
                }

                link.InnerHtml.Append(i.ToString());
                item.InnerHtml.AppendHtml(link);
                tagUl.InnerHtml.AppendHtml(item);
            }

            output.Content.AppendHtml(tagUl);
        }
    }
}