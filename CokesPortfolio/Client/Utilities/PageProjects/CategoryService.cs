using MudBlazor;

namespace CokesPortfolio.Client.Utilities.PageProjects
{
    public class CategoryService : ICategoryService
    {
        public IReadOnlyList<Category> Categories { get; }

        public Category GetById(int idCategory) => Categories.First(c => c.Id == idCategory);

        public CategoryService()
        {
            Categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    DisplayName = "All",
                    SelectedByDefault = true,
                    Icon = Icons.Material.Filled.Apps,
                    Order = 0,

                    HeaderName = "",
                    HeaderIcon = Icons.Material.Filled.Apps
                },

                new Category
                {
                    Id = 2,
                    DisplayName = "Featured",
                    Icon = Icons.Material.Filled.Star,
                    Order = 1,

                    HeaderName = "Featured Projects",
                    HeaderIcon = Icons.Material.Filled.Star,
                    IconColor = Color.Warning,
                    Typo = Typo.h5,
                    Style = "font-weight: bold",
                    Class = "d-flex align-center mt-6"
                },

                new Category
                {
                    Id = 3,
                    DisplayName = "Web",
                    Icon = Icons.Material.Filled.Language,
                    Order = 2,

                    HeaderName = "Web Applications",
                    HeaderIcon = Icons.Material.Filled.Language,
                    IconColor = Color.Info,
                    Class = "d-flex align-center mt-6"
                },

                new Category
                {
                    Id = 4,
                    DisplayName = "Desktop",
                    Icon = Icons.Material.Filled.DesktopWindows,
                    Order = 3,

                    HeaderName = "Desktop Applications",
                    HeaderIcon = Icons.Material.Filled.DesktopWindows,
                    Class = "d-flex align-center mt-6"
                },

                new Category
                {
                    Id = 5,
                    DisplayName = "Tools & Bots",
                    Icon = Icons.Material.Filled.SmartToy,
                    Order = 4,

                    HeaderName = "Tools & Bots",
                    HeaderIcon = Icons.Material.Filled.SmartToy,
                    IconColor = Color.Tertiary,
                    Class = "d-flex align-center mt-6"
                },

                new Category
                {
                    Id = 6,
                    DisplayName = "Extensions",
                    Icon = Icons.Material.Filled.Extension,
                    Order = 5,

                    HeaderName = "Browser Extensions",
                    HeaderIcon = Icons.Material.Filled.Extension,
                    IconColor = Color.Dark,
                    Class = "d-flex align-center mt-6"
                },
            };
        }
    }
}
