namespace CokesPortfolio.Client.Utilities.PageProjects
{
    public interface ICategoryService
    {
        Category GetById(int idCategory);
        IReadOnlyList<Category> Categories { get; }
    }
}
