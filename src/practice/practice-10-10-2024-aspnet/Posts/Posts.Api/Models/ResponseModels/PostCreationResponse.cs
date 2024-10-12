namespace Posts.Api.Models.ResponseModels
{
    public class PostCreationResponse
    {
        public PostCreationResponse(Guid id, string title, string content)
        {
            Id = id;
            Title = title;
            Content = content;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}