namespace CokesPortfolio.Client.Utilities.ProjectCategories
{
    public class ProjectCategory
    {
        public List<ProjectCategoryModel> GetProjectCategoryModels()
        {
            var categories = new List<ProjectCategoryModel>();

            var aaa = Enum.GetValues<ProjectCategoryEnum.ProjectCategory>()
                                 .OfType<ProjectCategoryEnum.ProjectCategory>()
                                 .ToList();

            foreach (ProjectCategoryEnum.ProjectCategory category in aaa)
            {
                var enumName = category.GetDescription();
                var icon = category.GetIcon();

                categories.Add(new ProjectCategoryModel
                {
                    EnumName = enumName,
                    Icon = icon
                });
            }

            return categories;
        }
    }
}
