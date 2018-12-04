using Microsoft.AspNetCore.Mvc;

namespace M101DotNet.WebApp.Models.Home
{
    public class CommentLikeModel
    {
        [HiddenInput(DisplayValue = false)]
        public string PostId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Index { get; set; }
    }
}