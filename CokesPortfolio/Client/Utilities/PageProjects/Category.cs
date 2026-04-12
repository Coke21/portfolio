using MudBlazor;

namespace CokesPortfolio.Client.Utilities.PageProjects
{
    public class Category
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public bool SelectedByDefault { get; set; }

        public string Icon { get; set; }
        public int Order { get; set; }

        public string HeaderName { get; set; }
        public string HeaderIcon { get; set; }
        public Color IconColor { get; set; }
        public Typo Typo { get; set; }
        public string Style { get; set; }
        public string Class { get; set; }
        public string ChildClass { get; set; }
    }
}
