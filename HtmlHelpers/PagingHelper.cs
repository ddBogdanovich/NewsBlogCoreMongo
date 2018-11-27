using System;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewsBlogCoreMongo.Models;

namespace MongoBlog.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();


            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder li = new TagBuilder("li");

                TagBuilder tag = new TagBuilder("a");

                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();


                if (i == pagingInfo.CurrentPage)
                {
                    li.AddCssClass("active");

                }

                li.InnerHtml = tag.ToString();
                result.Append(li.ToString());
            }

            return MvcHtmlString.Create(result.ToString());
        }
}

