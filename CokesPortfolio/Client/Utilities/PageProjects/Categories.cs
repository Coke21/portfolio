using MudBlazor;
using System.Reflection;

namespace CokesPortfolio.Client.Utilities.PageProjects
{
    public static class Categories
    {
        public static Category All => new("All", Icons.Material.Filled.Apps, 0);
        public static Category Web => new("Web", Icons.Material.Filled.Language, 1);
        public static Category Desktop => new("Desktop", Icons.Material.Filled.DesktopWindows, 2);
        public static Category Extensions => new("Extensions", Icons.Material.Filled.Extension, 3);
        public static Category ToolsBots => new("Tools & Bots", Icons.Material.Filled.SmartToy, 4);

        public static IReadOnlyList<Category> AllCategories =>
            typeof(Categories)
                .GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Where(p => p.PropertyType == typeof(Category))
                .Select(p => (Category)p.GetValue(null)!)
                .OrderBy(c => c.Order)
                .ToList();
    }
}
