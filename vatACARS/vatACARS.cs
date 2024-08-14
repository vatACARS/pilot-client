using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using vatACARS;

namespace vatACARS
{
    public static class AppData
    {
        public static Version CurrentVersion { get; } = new Version(0, 0, 1);
    }

    internal static class Program
    {
        private static readonly string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "vatACARS");
        private static Logger logger = new Logger("vatACARS");

        public static string GetFilePath(string subdirectory, string fileName)
        {
            string subdirectoryPath = Path.Combine(appDataFolder, subdirectory);
            Directory.CreateDirectory(subdirectoryPath);
            return Path.Combine(subdirectoryPath, fileName);
        }

        [STAThread]
        private static async Task Main() // Runs the application
        {
            // Initialize logger first
            logger.Log("Starting application");

            // Create the application data directory
            Directory.CreateDirectory(appDataFolder);

            // Initialize application configuration
            ApplicationConfiguration.Initialize();

            // Run asynchronous startup operations
            await Start();

            // Run the main application form
            Application.Run(new MainForm());
        }

        private static async Task Start()
        {
            try
            {
                logger.Log("Running updater client...");
                HttpClientUtils.SetBaseUrl("https://api.vatacars.com");
                await UpdateClient.CheckDependencies();
                logger.Log("Starting version checker...");
                VersionChecker.StartListening();

                logger.Log("Started successfully.");
            }
            catch (Exception e)
            {
                logger.Log($"Error in Start: {e.Message}");
            }
        }
    }
}