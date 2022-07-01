using ElevenNoteWebApp.Server.Data;
using ElevenNoteWebApp.Shared.Models.Category;

namespace ElevenNoteWebApp.Server.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCategoryAsync(CategoryCreate model)
        {
            if (model == null)
                return false;
            var categoryEntity = new ElevenNoteWebApp.Server.Models.Category
            {
                Name = model.Name
            };
            _context.Categories.Add(categoryEntity);
            return await _context.SaveChangesAsync() == 1;
        }

        public Task<bool> DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryListItem>> GetAllCategoriesAsync()
        {
            var categoryQuery = _context.Categories.Select(
                entity => new CategoryListItem
                {
                    Id = entity.Id,
                    Name = entity.Name
                });
            return categoryQuery.ToList();
        }

        public Task<CategoryDetail> GetCategoryByIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(CategoryEdit model)
        {
            throw new NotImplementedException();
        }
    }
}
