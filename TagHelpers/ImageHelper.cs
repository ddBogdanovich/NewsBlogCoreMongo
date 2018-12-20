using Microsoft.EntityFrameworkCore.Internal;
using NewsBlogCoreMongo.ViewModels;

namespace NewsBlogCoreMongo.TagHelpers
{
    using System.IO;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.Routing;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class ImageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;


        public ImageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }

        public NewsItemViewModel model { get; set; }

        public string StyleAttribute { get; set; }

        public string WrapTag { get; set; }

        [ViewContext] [HtmlAttributeNotBound] public ViewContext ViewContext { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (model.newsItem.Images == null || !model.newsItem.Images.Any())
            {
                output.SuppressOutput();
                return;
            }

            var urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            if (WrapTag == "ul")
            {
                GenerateUlWrappedContent(output, urlHelper);
            }
            else
            {
                GenerateDivWrappedContent(output, urlHelper);
            }
        }


        private void GenerateDivWrappedContent(TagHelperOutput output, IUrlHelper urlHelper)
        {
            output.TagName = "div";
            foreach (var image in model.newsItem.Images)
            {
                var imagePath = Path.Combine(model.uploadsFolder, image.FileId + image.Extension);
                var fullImagePath = Path.Combine(model.wwwRootPath, imagePath);

                if (File.Exists(fullImagePath))
                {
                    var img = new TagBuilder("img");
                    img.Attributes["alt"] = "picture";
                    img.Attributes["src"] = "/" + imagePath;

                    if (!string.IsNullOrWhiteSpace(StyleAttribute))
                    {
                        img.Attributes["style"] = StyleAttribute;
                    }

                    output.Content.AppendHtml(img);
                }
            }
        }


        private void GenerateUlWrappedContent(TagHelperOutput output, IUrlHelper urlHelper)
        {
            output.TagName = "ul";
            foreach (var image in model.newsItem.Images)
            {
                var imagePath = Path.Combine(model.uploadsFolder, image.FileId + image.Extension);
                var fullImagePath = Path.Combine(model.wwwRootPath, imagePath);

                if (File.Exists(fullImagePath))
                {
                    var li = new TagBuilder("li");
                    var img = new TagBuilder("img");
                    img.Attributes["alt"] = "picture";
                    img.Attributes["src"] = urlHelper.Content(imagePath);

                    if (!string.IsNullOrWhiteSpace(StyleAttribute))
                    {
                        img.Attributes["style"] = StyleAttribute;
                    }

                    li.InnerHtml.AppendHtml(img);
                    output.Content.AppendHtml(li);
                }
            }
        }
    }
}