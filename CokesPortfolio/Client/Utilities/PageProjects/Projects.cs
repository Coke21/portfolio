
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
                    Name = "Coke's Ban Checker",
                    Categories = new List<Category> { Categories.FeaturedDefinition.Category, Categories.WebDefinition.Category },
                    Card = new Card(
                        Title: "Coke's Ban Checker",
                        Description: "Online tool for verifying ArmA 3 and Steam ban status. " +
                                     "Supports Steam OpenID login and provides fast player lookup along with additional moderation services. " +
                                     "Available as a PWA with optional desktop installation. " +
                                     "\nFor security reasons, the source code is not available. " +
                                     "\nThis is my most ambitious project to date, with over 450 users registered since 2021.",
                        CardMedia: new CardMedia("icons/gavel.png", "background-size: contain; background-position: center;"),
                        CardChip: new List<CardChip> {
                            new CardChip(".NET 10"),
                            new CardChip("Blazor WebAssembly"),
                            new CardChip("Blazor Server"), 
                            new CardChip("PWA"),
                            new CardChip("MudBlazor UI"),
                            new CardChip("PostgreSQL"),
                            new CardChip("EntityFrameworkCore"),
                            new CardChip("Steam OpenID Auth"),
                            new CardChip("User Roles"),
                            new CardChip("WebAPI with JWT Auth")
                        },
                        IsLiveAppAvailable: true,
                        LiveAppHref: "https://cokesbanchecker.herokuapp.com/",
                        DetailsAvailable: false,
                        IsSourceCodeAvailable: false,
                        SourceCodeHref: string.Empty
                    ),
                    Order = 1
                },

                new Project()
                {
                    Name = "Coke's Portfolio",
                    Categories = new List<Category> { Categories.WebDefinition.Category },
                    Card = new Card(
                        Title: "Coke's Portfolio",
                        Description: "A portfolio website built with Blazor WebAssembly, showcasing my projects and skills.",
                        CardMedia: new CardMedia("icons/portfolio_image.png", "background-size: contain; background-position: center;"),
                        CardChip: new List<CardChip> {
                            new CardChip(".NET 10"),
                            new CardChip("Blazor WebAssembly"), 
                            new CardChip("PWA"), 
                            new CardChip("MudBlazor UI")
                        },
                        IsLiveAppAvailable: true,
                        LiveAppHref: "https://coke21.github.io/portfolio/",
                        DetailsAvailable: false,
                        IsSourceCodeAvailable: true,
                        SourceCodeHref: "https://github.com/Coke21/portfolio"
                    ),
                    Order = 2
                },

                new Project()
                {
                    Name = "GTA Mission Downloader",
                    Categories = new List<Category> { Categories.DesktopDefinition.Category },
                    Card = new Card(
                        Title: "GTA Mission Downloader",
                        Description: "WPF desktop application for downloading and managing ArmA 3 mission files. " +
                                    "It automates mission file retrieval and placement into the correct game directories, improving setup speed and usability compared to in-game downloads. " +
                                    "The tool also includes basic management of ArmA 3 and TeamSpeak 3 server entries (joining servers). Built using MVVM architecture for maintainability and separation of concerns.",
                        CardMedia: new CardMedia("icons/gtaicon.png", "background-size: contain; background-position: center;"),
                        CardChip: new List<CardChip> {
                            new CardChip(".NET Core 3.1"),
                            new CardChip("WPF"), 
                            new CardChip("MVVM (Caliburn.Micro library)"),
                            new CardChip("MahApps.Metro UI")
                        },
                        IsLiveAppAvailable: false,
                        LiveAppHref: string.Empty,
                        DetailsAvailable: false,
                        IsSourceCodeAvailable: true,
                        SourceCodeHref: "https://github.com/Coke21/GTA-Mission-Downloader"
                    ),
                    Order = 1
                },

                new Project()
                {
                    Name = "Inline Skates Manager",
                    Categories = new List<Category> { Categories.DesktopDefinition.Category },
                    Card = new Card(
                        Title: "Inline Skates Manager",
                        Description: "Inventory and rental management for inline skates with Microsoft SQL Server as database.",
                        CardMedia: new CardMedia("icons/ismicon.png", "background-size: contain; background-position: center;"),
                        CardChip: new List<CardChip> {
                            new CardChip(".NET Framework 4.7.2"),
                            new CardChip("WinForms"), 
                            new CardChip("Syncfusion UI"),
                            new CardChip("Microsoft SQL Server")
                        },
                        IsLiveAppAvailable: false,
                        LiveAppHref: string.Empty,
                        DetailsAvailable: false,
                        IsSourceCodeAvailable: true,
                        SourceCodeHref: "https://github.com/Coke21/InlineSkatesManager"
                    ),
                    Order = 2
                },

                new Project()
                {
                    Name = "Variable Patcher",
                    Categories = new List<Category> { Categories.DesktopDefinition.Category },
                    Card = new Card(
                        Title: "Variable Patcher",
                        Description: "Variable Patcher is a utility that updates variables in .sqf files using values from .txt files. " +
                                     "It automates the process of replacing configuration values, eliminating the need for manual editing and reducing repetitive work. " +
                                     "The application was created for a friend to streamline their workflow.",
                        CardMedia: new CardMedia("icons/variablepatcher.png", "background-size: contain; background-position: center;"),
                        CardChip: new List<CardChip> {
                            new CardChip(".NET 6"),
                            new CardChip("WPF"),
                            new CardChip("MVVM (Stylet library)"),
                            new CardChip("MaterialDesignInXAML UI")
                        },
                        IsLiveAppAvailable: false,
                        LiveAppHref: string.Empty,
                        DetailsAvailable: false,
                        IsSourceCodeAvailable: true,
                        SourceCodeHref: "https://github.com/Coke21/VariablePatcherAppNet6"
                    ),
                    Order = 3
                },

                new Project()
                {
                    Name = "E-Mail Sender",
                    Categories = new List<Category> { Categories.DesktopDefinition.Category },
                    Card = new Card(
                        Title: "E-Mail Sender",
                        Description: "WPF (MVVM) app using Google Drive & Gmail APIs to upload files, make them public, and send e-mails with shareable links. " +
                        "\nCreated to help solve a real Stack Overflow question.",
                        CardMedia: new CardMedia("icons/google.png", "background-size: contain; background-position: center;"),
                        CardChip: new List<CardChip> {
                            new CardChip(".NET Core 3.1"),
                            new CardChip("WPF"),
                            new CardChip("MVVM (Caliburn.Micro library)"),
                            new CardChip("Google API"),
                            new CardChip("ModernWpfUI")
                        },
                        IsLiveAppAvailable: false,
                        LiveAppHref: string.Empty,
                        DetailsAvailable: false,
                        IsSourceCodeAvailable: true,
                        SourceCodeHref: "https://github.com/Coke21/E-Mail-Sender"
                    ),
                    Order = 4
                },

                new Project()
                {
                    Name = "Forum Application Uploader",
                    Categories = new List<Category> { Categories.DesktopDefinition.Category },
                    Card = new Card(
                        Title: "Forum Application Uploader",
                        Description: "WPF (MVVM) tool that reads forum applications, extracts data, and uploads it to Google Sheets. Reduced manual processing time from ~30 minutes to ~1 minute.",
                        CardMedia: new CardMedia("icons/au.png", "background-size: contain; background-position: center;"),
                        CardChip: new List<CardChip>
                        {
                            new CardChip(".NET Core 3.1"),
                            new CardChip("WPF"),
                            new CardChip("MVVM (Caliburn.Micro library)"),
                            new CardChip("Automation"),
                            new CardChip("Google API"),
                        },
                        IsLiveAppAvailable: false,
                        LiveAppHref: string.Empty,
                        DetailsAvailable: false,
                        IsSourceCodeAvailable: false,
                        SourceCodeHref: string.Empty
                    ),
                    Order = 5
                },

                new Project()
                {
                    Name = "GTA Discord Bot",
                    Categories = new List<Category> { Categories.ToolsBotsDefinition.Category },
                    Card = new Card(
                        Title: "GTA Discord Bot",
                        Description: "Console Discord bot (Discord.NET) formerly used in GTA Discord servers (ArmA 3 game) to quickly check player status (ban checks) across multiple services." +
                        " It used Coke's Ban Checker API (Featured App: Coke's Ban Checker).",
                        CardMedia: new CardMedia("icons/discordbot.png", "background-size: contain; background-position: center;"),
                        CardChip: new List<CardChip>
                        {
                            new CardChip(".NET 9"),
                            new CardChip("Console App")
                        },
                        IsLiveAppAvailable: false,
                        LiveAppHref: string.Empty,
                        DetailsAvailable: false,
                        IsSourceCodeAvailable: false,
                        SourceCodeHref: string.Empty
                    ),
                    Order = 1
                },

                new Project()
                {
                    Name = "Buffy's Discord Bot",
                    Categories = new List<Category> { Categories.ToolsBotsDefinition.Category },
                    Card = new Card(
                        Title: "Buffy's Discord Bot",
                        Description: "Console Discord bot (Discord.NET) formerly hosted on Heroku that listened to embed messages, extracted data, and synced it to Google Sheets. Used PostgreSQL with EF Core for configuration and command management.",
                        CardMedia: new CardMedia("icons/discordbot.png", "background-size: contain; background-position: center;"),
                        CardChip: new List<CardChip>
                        {
                            new CardChip(".NET 5"),
                            new CardChip("Console App"),
                            new CardChip("PostgreSQL"),
                            new CardChip("EntityFrameworkCore"),
                        },
                        IsLiveAppAvailable: false,
                        LiveAppHref: string.Empty,
                        DetailsAvailable: false,
                        IsSourceCodeAvailable: false,
                        SourceCodeHref: string.Empty
                    ),
                    Order = 2
                },

                new Project()
                {
                    Name = "Coke's Ban Checker Extension",
                    Categories = new List<Category> { Categories.ExtensionsDefinition.Category },
                    Card = new Card(
                        Title: "Coke's Ban Checker Extension",
                        Description: "Chrome extension (TypeScript) that enhances supported websites with additional UI and allows quick BattlEye Global ban checks via Coke's Ban Checker API (Featured App: Coke's Ban Checker). Used by over 30 users.",
                        CardMedia: new CardMedia("icons/gavel.png", "background-size: contain; background-position: center;"),
                        CardChip: new List<CardChip>
                        {
                            new CardChip("TypeScript"),
                            new CardChip("Chrome Extension"),
                            new CardChip("React")
                        },
                        IsLiveAppAvailable: true,
                        LiveAppHref: "https://chromewebstore.google.com/detail/cokes-ban-checker-extensi/hmmcfkdejhgadhiojdfomeglbpmogfpm",
                        DetailsAvailable: false,
                        IsSourceCodeAvailable: true,
                        SourceCodeHref: "https://github.com/Coke21/CokesBanCheckerExtension"
                    ),
                    Order = 1
                }
            };

            return items;
        }

        public IEnumerable<IProject> FilteredProjects =>
            Categories.SelectedCategories.Contains(Categories.AllDefinition)
                ? AllProjects()
                : AllProjects()
                    .Where(p => p.Categories.Any(c => Categories.SelectedCategories.Contains(Categories.AllCategoryDefinitions.First(x => x.Category == c))));

        public IEnumerable<IGrouping<CategoryDefinition, IProject>> FilteredProjectsGrouped =>
            FilteredProjects
                .SelectMany(project =>
                    project.Categories.Select(category =>
                        new
                        {
                            CategoryDefinition = Categories.AllCategoryDefinitions
                                .First(x => x.Category == category),

                            Project = project
                        }))
                .OrderBy(x => x.Project.Order)
                .GroupBy(x => x.CategoryDefinition, x => x.Project)
                .OrderBy(g => g.Key.Category.Order);
    }
}
