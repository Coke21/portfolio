using CokesPortfolio.Client.Utilities.ProjectCategories;
using static CokesPortfolio.Client.Utilities.ProjectCategories.ProjectCategoryEnum;

namespace CokesPortfolio.Client.Utilities.ProjectItems
{
    public class ProjectItemModel : IProjectItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ProjectCategoryEnum.ProjectCategory> Categories { get; set; }
    }
}
