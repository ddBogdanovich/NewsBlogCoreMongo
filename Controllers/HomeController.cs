using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using M101DotNet.WebApp.Models;
using M101DotNet.WebApp.Models.Home;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using MongoBlog.Repository;

namespace M101DotNet.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogRepository _blogRepository;

        public HomeController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        
        
        public async Task<ActionResult> Index()
        {

            var recentPosts = await _blogRepository.GetPostsAsync();
            var tags = await _blogRepository.GetTagsAsync();

            var model = new IndexModel
            {
                RecentPosts = recentPosts,
                Tags = tags
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult NewPost()
        {
            return View(new NewPostModel());
        }

        [HttpPost]
        public async Task<ActionResult> NewPost(NewPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var post = new Post
            {
                Author = User.Identity.Name,
                Title = model.Title,
                Content = model.Content,
                Tags = model.Tags.Split(' ', ',', ';'),
                CreatedAtUtc = DateTime.UtcNow,
                Comments = new List<Comment>()
            };

            await _blogRepository.InsertPostAsync(post);

            return RedirectToAction("Post", new { id = post.Id });
        }

        [HttpGet]
        public async Task<ActionResult> Post(string id)
        {

            var post = await _blogRepository.GetPostByIdAsync(id);

            if (post == null)
            {
                return RedirectToAction("Index");
            }

            var model = new PostModel
            {
                Post = post,
                NewComment = new NewCommentModel
                {
                    PostId = id
                }
            };

            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> Posts(string tag = null)
        {

            Expression<Func<Post, bool>> filter = x => true;

            if (tag != null)
            {
                filter = x => x.Tags.Contains(tag);
            }

            var posts = await _blogRepository.GetPostsFilteredAsync(filter);

            return View(posts);
        }

        [HttpPost]
        public async Task<ActionResult> NewComment(NewCommentModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Post", new { id = model.PostId });
            }

            /*var comment = new Comment
            {
                Author = User.Identity.Name,
                Content = model.Content,
                CreatedAtUtc = DateTime.UtcNow
            };

            var blogContext = new BlogContext();

            await blogContext.Posts.UpdateOneAsync(
                x => x.Id == model.PostId,
                Builders<Post>.Update.Push(x => x.Comments, comment));*/


            return RedirectToAction("Post", new { id = model.PostId });
        }

        [HttpPost]
        public async Task<ActionResult> CommentLike(CommentLikeModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Post", new { id = model.PostId });
            }

            /*
            var blogContext = new BlogContext();

          //  if (model != null)
          //  {
                var index = model.Index;
                var postId = model.PostId;
*/


            // var posts = await blogContext.Posts.Find(new BsonDocument()).ToListAsync();

            //var comments = posts.Where(x => x.Id == postId).Select(x => x.Comments).ToList();

            //var comment = comments.ElementAt(index).FirstOrDefault();

            //comment.Likes += 1;

            //await blogContext.

            //CommentBYME
            /*await blogContext.Posts.UpdateOneAsync(
                x => x.Id == model.PostId,
                Builders<Post>.Update.Inc("Comments." + index.ToString()+ ".Likes", 1));*/


            //var result = await blogContext.Posts.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("id", postId),
            //                                                    Builders<BsonDocument>.Update.Inc("Comments.0.Likes", 1));


            // }

            // XXX WORK HERE
            // Increment the Likes field for the comment at {model.Index}
            // inside the post {model.PostId}.
            //
            // NOTE: The 2.0.0 driver has a bug in the expression parser and 
            // might throw an exception depending on how you solve this problem. 
            // This is documented here along with a workaround:
            // https://jira.mongodb.org/browse/CSHARP-1246

            return RedirectToAction("Post", new { id = model.PostId });
        }
    }
}