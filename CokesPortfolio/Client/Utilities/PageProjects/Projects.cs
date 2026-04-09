
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
                    //Name = "Project 1 FEATURED",
                    //Description = "Description for Project 1",
                    Categories = [Categories.WebDefinition.Category, Categories.DesktopDefinition.Category, Categories.FeaturedDefinition.Category],
                    Card = new Card
                    (
                        "Coke's Portfolio",
                        "A portfolio website built with Blazor WebAssembly, showcasing my projects and skills.",
                        new CardMedia
                        (
                            "icons/portfolio_image.png",
                            "background-size: contain; background-position: center;"
                        ),
                        new List<CardChip>()
                        {
                            new CardChip("Blazor"),
                            new CardChip("PWA"),
                            new CardChip("MudBlazor")
                        },
                        true
                    ),
                }//,
                //new Project()
                //{
                //    Name = "Project 2",
                //    Description = "Description for Project 2",
                //    Categories = [Categories.ExtensionsDefinition.Category],
                //},
                //new Project()
                //{
                //    Name = "Project 3",
                //    Description = "Description for Project 11",
                //    Categories = [Categories.DesktopDefinition.Category],
                //},
                //new Project()
                //{
                //    Name = "Project 4",
                //    Description = "Description for Project 3",
                //    Categories = [Categories.ToolsBotsDefinition.Category],
                //},
                //new Project()
                //{
                //    Name = "Project 5",
                //    Description = "Description for Project 111",
                //    Categories = [Categories.DesktopDefinition.Category],
                //},
            };

            return items;
        }

        public List<IGrouping<Category, IProject>> AllProjectsGroupByCategory()
        {
            var items = AllProjects();

            // Flatten so each project appears under each category it belongs to
            var flattened = items.SelectMany(p => p.Categories.Select(c => new { Category = c, Project = p }));

            // Group by category
            var grouped = flattened.GroupBy(x => x.Category, x => x.Project).ToList();

            return grouped;
        }
    }
}
