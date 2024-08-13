using FirstWebAPI.Dtos.Comment;
using FirstWebAPI.Models;

namespace FirstWebAPI.Mappers
{
    public static class CommentMappers
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId
            };
        }

        public static Comment ToCommentFromCreateRequest(this CreateCommentRequestDto commentModel, int stockId)
        {
            return new Comment
            {
                Title = commentModel.Title,
                Content = commentModel.Content,
                StockId = stockId
            };
        }

        public static Comment ToCommentFromUpdateRequest(this UpdateCommentRequestDto commentModel)
        {
            return new Comment
            {
                Title = commentModel.Title,
                Content = commentModel.Content,
            };
        }
    }
}
