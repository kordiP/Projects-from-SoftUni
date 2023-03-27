using MusicSite.Data;
using MusicSite.Data.Models;
using MusicSite.Services.Contracts;

namespace MusicSite.Services
{
    public class CategoriesService : ICategoriesService
    {
        private MusicSiteDbContext context;

        public CategoriesService(MusicSiteDbContext context)
        {
            this.context = context;
        }
        public int CreateCategory(string name)
        {
            var category = new Category() { Name = name };

            context.Categories.Add(category);
            context.SaveChanges();

            return category.Id;
        }
    }
}