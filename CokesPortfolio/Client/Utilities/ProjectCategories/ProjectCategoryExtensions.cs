using MudBlazor;

namespace CokesPortfolio.Client.Utilities.ProjectCategories
{
    public static class ProjectCategoryExtensions
    {
        public static string GetDescription(this ProjectCategoryEnum.ProjectCategory category)
        {
            return category switch
            {
                ProjectCategoryEnum.ProjectCategory.All => "All",
                ProjectCategoryEnum.ProjectCategory.Web => "Web",
                ProjectCategoryEnum.ProjectCategory.Desktop => "Desktop",
                ProjectCategoryEnum.ProjectCategory.Extensions => "Extensions",
                ProjectCategoryEnum.ProjectCategory.Tools_Bots => "Tools & Bots",
                _ => category.ToString()
            };
        }

        public static string GetIcon(this ProjectCategoryEnum.ProjectCategory category)
        {
            return category switch
            {
                ProjectCategoryEnum.ProjectCategory.All => Icons.Material.Filled.Apps,
                ProjectCategoryEnum.ProjectCategory.Web => Icons.Material.Filled.Language,
                ProjectCategoryEnum.ProjectCategory.Desktop => Icons.Material.Filled.DesktopWindows,
                ProjectCategoryEnum.ProjectCategory.Extensions => Icons.Material.Filled.Extension,
                ProjectCategoryEnum.ProjectCategory.Tools_Bots => Icons.Material.Filled.SmartToy,
                _ => Icons.Material.Filled.Help
            };
        }
    }
}
