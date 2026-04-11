using MudBlazor;
using System.Reflection;

namespace CokesPortfolio.Client.Utilities.PageProjects
{
    public static class Categories
    {
        public static readonly CategoryDefinition AllDefinition = new()
        {
            Category = new Category(
                "All",
                Icons.Material.Filled.Apps,
                0),

            Header = new CategoryHeader(
                Icons.Material.Filled.Apps,
                Color.Default,
                "",
                Typo.h6,
                "",
                "",
                "")
        };

        public static readonly CategoryDefinition FeaturedDefinition = new()
        {
            Category = new Category(
                "Featured",
                Icons.Material.Filled.Star,
                1),

            Header = new CategoryHeader(
                Icons.Material.Filled.Star,
                Color.Warning,
                "Featured Projects",
                Typo.h5,
                "font-weight: bold",
                "d-flex align-center mt-6 mb-2",
                "mb-8")
        };

        public static readonly CategoryDefinition WebDefinition = new()
        {
            Category = new Category(
                "Web",
                Icons.Material.Filled.Language,
                2),

            Header = new CategoryHeader(
                Icons.Material.Filled.Language,
                Color.Info,
                "Web Applications",
                Typo.h6,
                "",
                "d-flex align-center mt-6",
                "")
        };

        public static readonly CategoryDefinition DesktopDefinition = new()
        {
            Category = new Category(
                "Desktop",
                Icons.Material.Filled.DesktopWindows,
                3),

            Header = new CategoryHeader(
                Icons.Material.Filled.DesktopWindows,
                Color.Default,
                "Desktop Applications",
                Typo.h6,
                "",
                "d-flex align-center mt-6",
                "")
        };

        public static readonly CategoryDefinition ExtensionsDefinition = new()
        {
            Category = new Category(
                "Extensions",
                Icons.Material.Filled.Extension,
                4),

            Header = new CategoryHeader(
                Icons.Material.Filled.Extension,
                Color.Dark,
                "Browser Extensions",
                Typo.h6,
                "",
                "d-flex align-center mt-6",
                "")
        };

        public static readonly CategoryDefinition ToolsBotsDefinition = new()
        {
            Category = new Category(
                "Tools & Bots",
                Icons.Material.Filled.SmartToy,
                5),

            Header = new CategoryHeader(
                Icons.Material.Filled.SmartToy,
                Color.Tertiary,
                "Tools & Bots",
                Typo.h6,
                "",
                "d-flex align-center mt-6",
                "")
        };


        public static IReadOnlyList<CategoryDefinition> AllCategoryDefinitions =>
            typeof(Categories)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.FieldType == typeof(CategoryDefinition))
                .Select(f => (CategoryDefinition)f.GetValue(null)!)
                .OrderBy(c => c.Category.Order)
                .ToList();

        public static IReadOnlyCollection<CategoryDefinition> SelectedCategories = new List<CategoryDefinition>() { Categories.AllDefinition };
    }
}
