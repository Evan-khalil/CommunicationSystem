using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CommunicationApp.Models;
using CommunicationApp.Models.AjaxModels;
using CommunicationApp.Repository;
using Microsoft.AspNetCore.Authorization;

namespace CommunicationApp.Controllers
{
    [Route("api/comments/{Action}")]
    [ApiController]
    [AllowAnonymous]
    public class CommentsApiController : ControllerBase
    {
        private readonly IPersonRepository _person;
        private readonly IBlogPostRepository _blogPost;
        private readonly ICommentRepository _comment;

        public CommentsApiController(IPersonRepository personRepository, IBlogPostRepository blogPostRepository, ICommentRepository commentRepository)
        {
            _person = personRepository;
            _blogPost = blogPostRepository;
            _comment = commentRepository;
        }

        [HttpPost, IgnoreAntiforgeryToken]
        public async Task<AjaxCommentReturn> Create([FromBody] AjaxComment obj)
        {
            var comment = new Comment
            {
                Text = obj.Text,
                Author = await _person.GetByUserName(obj.Author),
                Date = DateTime.Now,
                BlogPost = await _blogPost.GetById(obj.BlogPost)
            };

            await _comment.Add(comment);
            await _comment.Save();

            var returnComment = new AjaxCommentReturn()
            {
                Text = comment.Text,
                Author = comment.Author.Name,
                Date = comment.Date.ToString("yyyy-MM-dd HH:MM"),
                Email = comment.Author.Email,
                CommentId = comment.Id
            };
            return returnComment;
        }
        
        [HttpPost, IgnoreAntiforgeryToken]
        public async Task Delete([FromBody] Guid id)
        {
            var entity = await _comment.GetById(id);
            _comment.Remove(entity);
            await _comment.Save();
        }
    }
}