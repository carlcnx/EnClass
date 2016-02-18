using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using log4net;
using log4net.Config;
using EnClass.Translations;
using EnClass.Core;


namespace EnClass.Common
{
    public class App
    {
        // Log config file
        private const string DefaultCfgLogFile = "EnClass_log_cfg";
        private string config_log_file = string.Empty;

        // Logger for the EnClass program
        private static readonly ILog Logger = LogManager.GetLogger(typeof(App));

        public LanguageManager LngMg;

        public App()
        {
            LanguageManager LngMg = new LanguageManager();
        }

        public bool ArgumentLog(int i, int length, string nextArg)
        {
            if (String.IsNullOrWhiteSpace(FileExist(i, length, nextArg, "-log_cfg")) == true)
                return false;
            config_log_file = nextArg;

            if (string.IsNullOrWhiteSpace(config_log_file) == true)
                config_log_file = App.DefaultCfgLogFile;

            return true;
        }

        public void Start()
        {
            // Get log4net config 
            var configFile = Directory.GetCurrentDirectory() + config_log_file;

            // Load the log4net config file
            XmlConfigurator.Configure(new FileInfo(configFile));

            Logger.Info("Start EnClass Application.");


            Logger.Info("End EnClass Application.");
        }

        public static string FileExist(int currentIndex, int length, string value, string arg)
        {
            if (currentIndex + 1 >= length)
            {
                string errMsg = String.Format(Strings.MissingArgument, arg);
                Logger.Error(errMsg);
                return errMsg;
            }

            // Check if the folder exists
            if (File.Exists(value) == false)
            {
                string errMsg = String.Format(Strings.FileDoesntExist, value);
                Logger.Error(errMsg);
                return errMsg;
            }

            return string.Empty;
        }
    }
}
