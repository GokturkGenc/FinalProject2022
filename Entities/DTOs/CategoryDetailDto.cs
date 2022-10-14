using Core.Entities;

namespace Entities.DTOs
{
    public class CategoryDetailDto : IDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
