using Microsoft.AspNetCore.Mvc;
using Posts.Api.Models.RequestModels;
using Posts.Api.Models.ResponseModels;

namespace Posts.Api.Controllers
{
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        [HttpPost]
        public PostCreationResponse CreatePost(PostCreationRequest postCreationRequest)
        {
            return new PostCreationResponse(
                postCreationRequest.Id,
                postCreationRequest.Title,
                postCreationRequest.Content);
        }

        [HttpGet]
        [Route("{Id}")]
        public PostCreationResponse GetPostById(Guid Id)
        {
            return new PostCreationResponse(Id, "Post Title", "Post Content");
        }

        [HttpGet]
        public List<PostCreationResponse> GetAllPosts()
        {
            return new List<PostCreationResponse>
            {
                new PostCreationResponse(Guid.NewGuid(), "Post Title 1", "Post Content 1"),
                new PostCreationResponse(Guid.NewGuid(), "Post Title 2", "Post Content 2"),
                new PostCreationResponse(Guid.NewGuid(), "Post Title 3", "Post Content 3"),
            };
        }
    }
}
