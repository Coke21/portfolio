using CokesPortfolio.Client.Utilities.ProjectCategories;

namespace CokesPortfolio.Client.Utilities.ProjectItems
{
    public class ProjectItem
    {
        public List<IProjectItem> GetProjectItems() 
        {
            var items = new List<IProjectItem>()
            {
                new ProjectItemModel()
                {
                    Name = "Project 1",
                    Description = "Description for Project 1",
                    Categories = [ProjectCategoryEnum.ProjectCategory.Web, ProjectCategoryEnum.ProjectCategory.Desktop]
                },
                new ProjectItemModel()
                {
                    Name = "Project 2",
                    Description = "Description for Project 2",
                    Categories = [ProjectCategoryEnum.ProjectCategory.Extensions]
                },
                new ProjectItemModel()
                {
                    Name = "Project 3",
                    Description = "Description for Project 3",
                    Categories = [ProjectCategoryEnum.ProjectCategory.Desktop]
                },
            };

            return items;
        }

    }
}
