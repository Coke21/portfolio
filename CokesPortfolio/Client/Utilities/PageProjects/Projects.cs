
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
                    Description = "Service to check bans and provide quick lookup for players.",
                    Categories = [Categories.FeaturedDefinition.Category, Categories.WebDefinition.Category],
                    Card = new Card(
                        "Coke's Ban Checker",
                        "Online tool for verifying ArmA 3 and Steam ban status. " +
                        "Supports Steam OpenID login and provides fast player lookup along with additional moderation services. " +
                        "Available as a PWA with optional desktop installation. " +
                        "\nFor security reasons, the source code is not available. " +
                        "\nThis is my most ambitious project to date, with over 450 users registered since 2021.",
                        new CardMedia("icons/gavel.png", "background-size: contain;"),
                        [
                            new CardChip(".NET 10"),
                            new CardChip("Blazor WebAssembly"),
                            new CardChip("Blazor Server"), 
                            new CardChip("PWA"),
                            new CardChip("MudBlazor UI"),
                            new CardChip("Postgresql"),
                            new CardChip("EntityFrameworkCore"),
                            new CardChip("Steam OpenID Auth"),
                            new CardChip("User Roles"),
                            new CardChip("WebAPI with JWT Auth")
                        ],
                        true,
                        "https://cokesbanchecker.herokuapp.com/",
                        false,
                        false,
                        string.Empty
                    ),
                    Order = 1
                },

                new Project()
                {
                    Name = "Coke's Portfolio",
                    Description = "A portfolio website built with Blazor WebAssembly, showcasing my projects and skills.",
                    Categories = [Categories.FeaturedDefinition.Category, Categories.WebDefinition.Category],
                    Card = new Card(
                        "Coke's Portfolio",
                        "A portfolio website built with Blazor WebAssembly, showcasing my projects and skills.",
                        new CardMedia("icons/portfolio_image.png", "background-size: contain; background-position: center;"),
                        [
                            new CardChip(".NET 10"),
                            new CardChip("Blazor WebAssembly"), 
                            new CardChip("PWA"), 
                            new CardChip("MudBlazor UI")],
                        true,
                        "https://coke21.github.io/portfolio/",
                        false,
                        true,
                        "https://github.com/Coke21/portfolio"
                    ),
                    Order = 2
                },

                new Project()
                {
                    Name = "GTA Mission Downloader",
                    Description = "Desktop utility to download and install ArmA 3 .pbo missions.",
                    Categories = [Categories.DesktopDefinition.Category],
                    Card = new Card(
                        "GTA Mission Downloader",
                        "WPF desktop application for downloading and managing ArmA 3 mission files. " +
                        "It automates mission file retrieval and placement into the correct game directories, improving setup speed and usability compared to in-game downloads. " +
                        "The tool also includes basic management of ArmA 3 and TeamSpeak 3 server entries. Built using MVVM architecture for maintainability and separation of concerns.",
                        new CardMedia("icons/gtaicon.png", "background-size: contain; background-position: center;"),
                        [
                            new CardChip(".NET Core 3.1"),
                            new CardChip("WPF"), 
                            new CardChip("MVVM (Caliburn.Micro library)"),
                            new CardChip("MahApps.Metro UI"),
                        ],
                        false,
                        string.Empty,
                        false,
                        true,
                        "https://github.com/Coke21/GTA-Mission-Downloader"
                    ),
                    Order = 1
                },

                new Project()
                {
                    Name = "Inline Skates Manager",
                    Description = "A desktop app to manage inline skates inventory and rentals.",
                    Categories = [Categories.DesktopDefinition.Category],
                    Card = new Card(
                        "Inline Skates Manager",
                        "Inventory and rental management for inline skates.",
                        new CardMedia("icons/ismicon.png", "background-size: contain;"),
                        [
                            new CardChip(".NET Framework 4.7.2"),
                            new CardChip("WinForms"), 
                            new CardChip("Syncfusion UI"),
                            new CardChip("Microsoft SQL Server")
                        ],
                        false,
                        string.Empty,
                        false,
                        true,
                        "https://github.com/Coke21/InlineSkatesManager"
                    ),
                    Order = 2
                },

                new Project()
                {
                    Name = "Variable Patcher",
                    Description = "A small utility for patching variables in configuration files.",
                    Categories = [Categories.DesktopDefinition.Category],
                    Card = new Card(
                        "Variable Patcher",
                        "Variable Patcher is a utility that updates variables in .sqf files using values from .txt files. " +
                        "It automates the process of replacing configuration values, eliminating the need for manual editing and reducing repetitive work. " +
                        "The application was created for a friend to streamline their workflow.",
                        new CardMedia("icons/variablepatcher1.png", "background-size: contain; background-position: center;"),
                        [
                            new CardChip(".NET 6"),
                            new CardChip("WPF"),
                            new CardChip("MVVM (Stylet library)"),
                            new CardChip("MaterialDesignInXAML UI")
                        ],
                        false,
                        string.Empty,
                        false,
                        true,
                        "https://github.com/Coke21/VariablePatcherAppNet6"
                    ),
                    Order = 3
                },

                new Project()
                {
                    Name = "E-Mail Sender",
                    Description = "A simple application to send emails programmatically.",
                    Categories = new List<Category> { Categories.DesktopDefinition.Category },
                    Card = new Card(
                        "E-Mail Sender",
                        "Utility to send emails via SMTP programmatically.",
                        new CardMedia("icons/google.png", "background-size: contain;"),
                        new List<CardChip> { new CardChip("SMTP"), new CardChip(".NET") },
                        false,
                        string.Empty,
                        false,
                        false,
                        string.Empty
                    ),
                    Order = 4
                },

                new Project()
                {
                    Name = "GTA Discord Bot",
                    Description = "A Discord bot used for GTA related server automation and commands.",
                    Categories = new List<Category> { Categories.ToolsBotsDefinition.Category },
                    Card = new Card(
                        "GTA Discord Bot",
                        "Discord bot for GTA communities with automated commands and notifications.",
                        new CardMedia("icons/discordbot.png", "background-size: contain;"),
                        new List<CardChip> { new CardChip("Discord.NET"), new CardChip("Bot") },
                        false,
                        string.Empty,
                        false,
                        false,
                        string.Empty
                    )
                },

                new Project()
                {
                    Name = "Buffy's Discord Bot",
                    Description = "A custom Discord bot created for server moderation and fun features.",
                    Categories = new List<Category> { Categories.ToolsBotsDefinition.Category },
                    Card = new Card(
                        "Buffy's Discord Bot",
                        "Moderation and utility bot for Discord.",
                        new CardMedia("icons/discordbot.png", "background-size: contain;"),
                        new List<CardChip> { new CardChip("Discord.NET"), new CardChip("Bot") },
                        false,
                        string.Empty,
                        false,
                        false,
                        string.Empty
                    )
                },

                new Project()
                {
                    Name = "Discord Bot API",
                    Description = "An API project to support Discord bots with shared functionality.",
                    Categories = new List<Category> { Categories.WebDefinition.Category, Categories.ToolsBotsDefinition.Category },
                    Card = new Card(
                        "Discord Bot API",
                        "Common API layer used by multiple Discord bots for shared features.",
                        new CardMedia("icons/api.png", "background-size: contain;"),
                        new List<CardChip> { new CardChip("ASP.NET Core"), new CardChip("API") },
                        false,
                        string.Empty,
                        false,
                        false,
                        string.Empty
                    )
                },

                new Project()
                {
                    Name = "Application Uploader",
                    Description = "A tool to upload and manage application packages.",
                    Categories = new List<Category> { Categories.WebDefinition.Category },
                    Card = new Card(
                        "Application Uploader",
                        "Web tool for uploading and managing application packages.",
                        new CardMedia("icons/upload.png", "background-size: contain;"),
                        new List<CardChip> { new CardChip("Web"), new CardChip("Uploader") },
                        false,
                        string.Empty,
                        false,
                        false,
                        string.Empty
                    )
                },

                new Project()
                {
                    Name = "BattleMetrics Notifier",
                    Description = "Notifier for BattleMetrics events and server changes.",
                    Categories = new List<Category> { Categories.ToolsBotsDefinition.Category },
                    Card = new Card(
                        "BattleMetrics Notifier",
                        "Notifier integration for BattleMetrics to alert users about server events.",
                        new CardMedia("icons/bm.png", "background-size: contain;"),
                        new List<CardChip> { new CardChip("Notifier"), new CardChip("Integration") },
                        false,
                        string.Empty,
                        false,
                        false,
                        string.Empty
                    )
                },

                new Project()
                {
                    Name = "GameCP-Shortcut",
                    Description = "A TypeScript shortcut for GameCP to speed up common tasks.",
                    Categories = new List<Category> { Categories.WebDefinition.Category },
                    Card = new Card(
                        "GameCP-Shortcut",
                        "TypeScript shortcut to speed up common GameCP tasks.",
                        new CardMedia("icons/gtaicon.png", "background-size: contain;"),
                        new List<CardChip> { new CardChip("TypeScript"), new CardChip("Web") },
                        false,
                        string.Empty,
                        false,
                        false,
                        string.Empty
                    )
                },

                new Project()
                {
                    Name = "Coke's Ban Checker Extension",
                    Description = "Browser extension to quickly check bans from the toolbar.",
                    Categories = new List<Category> { Categories.ExtensionsDefinition.Category },
                    Card = new Card(
                        "Coke's Ban Checker Extension",
                        "Browser extension for quick ban lookups.",
                        new CardMedia("icons/gavel.png", "background-size: contain;"),
                        new List<CardChip> { new CardChip("Extension"), new CardChip("TypeScript") },
                        false,
                        string.Empty,
                        false,
                        false,
                        string.Empty
                    )
                }
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
