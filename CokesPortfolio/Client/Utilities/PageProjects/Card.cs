namespace CokesPortfolio.Client.Utilities.PageProjects
{
    public record Card(
        string Title,
        string Description,
        CardMedia CardMedia,
        List<CardChip> CardChip,
        bool IsLiveAppAvailable,
        string LiveAppHref,
        bool DetailsAvailable,
        bool IsSourceCodeAvailable,
        string SourceCodeHref);
}
