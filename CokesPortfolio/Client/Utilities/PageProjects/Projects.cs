
namespace CokesPortfolio.Client.Utilities.PageProjects
{
    public class Projects
    {
        public List<IProject> AllProjects() 
        {
            var items = new List<IProject>()
            {
                new Project()
                {
                    Name = "Project 1 FEATURED",
                    Description = "Description for Project 1",
                    Categories = [Categories.Web, Categories.Desktop],
                    IsFeatured = true,
                },
                new Project()
                {
                    Name = "Project 2",
                    Description = "Description for Project 2",
                    Categories = [Categories.Extensions],
                    IsFeatured = false
                },
                new Project()
                {
                    Name = "Project 3",
                    Description = "Description for Project 3",
                    Categories = [Categories.Desktop],
                    IsFeatured = false
                },
            };

            return items;
        }
    }
}
