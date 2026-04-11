
namespace CokesPortfolio.Client.Utilities.PageProjects
{
    public interface IProject
    {
        public string Name { get; set; }
        public List<Category> Categories { get; set; }
        Card Card { get; set; }
        public int Order { get; set; }
    }
}
