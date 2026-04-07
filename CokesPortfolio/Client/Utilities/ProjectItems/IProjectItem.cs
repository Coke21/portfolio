using static CokesPortfolio.Client.Utilities.ProjectCategories.ProjectCategoryEnum;

namespace CokesPortfolio.Client.Utilities.ProjectItems
{
    public interface IProjectItem
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ProjectCategory> Categories { get; set; }
    }
}
