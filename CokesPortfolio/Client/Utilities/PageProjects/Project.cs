
namespace CokesPortfolio.Client.Utilities.PageProjects
{
    public class Project : IProject
    {
        public string Name { get; set; }
        public List<Category> Categories { get; set; }
        public Card Card { get; set; }
        public int Order { get; set; }
    }
}
