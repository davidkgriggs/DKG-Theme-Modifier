using Playnite.SDK;
using Playnite.SDK.Events;
using Playnite.SDK.Models;
using Playnite.SDK.Plugins;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.Win32;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Net;
using System.Text.RegularExpressions;

namespace DKGThemeModifier
{
    public class DKGThemeModifier : GenericPlugin
    {
        private static readonly ILogger logger = LogManager.GetLogger();

        private DKGThemeModifierSettingsViewModel settings { get; set; }

        public override Guid Id { get; } = Guid.Parse("ee4ed2de-7e02-4447-8441-685d320b0520");

        public DKGThemeModifier(IPlayniteAPI api) : base(api)
        {
            settings = new DKGThemeModifierSettingsViewModel(this);
            Properties = new GenericPluginProperties
            {
                HasSettings = true
            };

            AddCustomElementSupport(new AddCustomElementSupportArgs
            {
                ElementList = new List<string> { "PS5ish_StoreButton", "PlayniteModernUI_Options", "PlatformDescriptions" },
                SourceName = "DKGThemeModifier",
            });

            AddSettingsSupport(new AddSettingsSupportArgs
            {
                SourceName = "DKGThemeModifier",
                SettingsRoot = $"{nameof(settings)}.{nameof(settings.Settings)}"
            });
        }

        public override Control GetGameViewControl(GetGameViewControlArgs args)
        {
            if (args.Name == "PS5ish_StoreButton")
            {
                return new PS5ish_StoreButton(PlayniteApi, settings);
            }
            if (args.Name == "PlayniteModernUI_Options")
            {
                return new PlayniteModernUI_Options(PlayniteApi, settings);
            }
            if (args.Name == "PlatformDescriptions")
            {
                return new PlatformDescriptions(PlayniteApi, settings);
            }

            return null;
        }

        public override void OnGameInstalled(OnGameInstalledEventArgs args)
        {
            // Add code to be executed when game is finished installing.
        }

        public override void OnGameStarted(OnGameStartedEventArgs args)
        {
            // Add code to be executed when game is started running.            
        }

        public override void OnGameStarting(OnGameStartingEventArgs args)
        {
            // Add code to be executed when game is preparing to be started.
        }

        public override void OnGameStopped(OnGameStoppedEventArgs args)
        {
            // Add code to be executed when game is preparing to be started.
        }

        public override void OnGameUninstalled(OnGameUninstalledEventArgs args)
        {
            // Add code to be executed when game is uninstalled.
        }

        public override void OnApplicationStarted(OnApplicationStartedEventArgs args)
        {
            // Add code to be executed when Playnite is initialized.

            //Create FilterPreset Directorys
            Directory.CreateDirectory(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\Icons");
            Directory.CreateDirectory(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformColours");
            Directory.CreateDirectory(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformImages");
            Directory.CreateDirectory(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformTrailers");


            



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
            string extensionyamlLocation1 = PlayniteApi.Paths.ConfigurationPath + @"\Extensions\DKGThemeModifier_ee4ed2de-7e02-4447-8441-685d320b0520\extension.yaml";
            string extensionyamlLocationRead1 = File.ReadAllText(extensionyamlLocation1);
            int extensionyamlversionstartIndex1 = 116;
            int extensionyamlversionlength1 = 5;
            string extensionyamlversion1 = extensionyamlLocationRead1.Substring(extensionyamlversionstartIndex1, extensionyamlversionlength1);
            settings.Settings.DKGThemeModifierCurrentVersion = extensionyamlversion1;
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Is Theme Installed
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            settings.Settings.IsThemeInstalled_PlayniteModernUI = false;
            settings.Settings.IsThemeInstalledHeader_PlayniteModernUI = "";

            settings.Settings.IsThemeInstalled_PS5ish = false;
            settings.Settings.IsThemeInstalledHeader_PS5ish = "";

            settings.Settings.IsThemeInstalled_PlayniteDeck = false;
            settings.Settings.IsThemeInstalledHeader_PlayniteDeck = "";

            if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PlayniteModernUI_b600472c-c10c-4136-86d0-82bf0e576200\theme.yaml"))
            {
                settings.Settings.IsThemeInstalled_PlayniteModernUI = true;
                settings.Settings.IsThemeInstalledHeader_PlayniteModernUI = "PlayniteModernUI";
                string ConstantsLocation_PlayniteModernUI = PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PlayniteModernUI_b600472c-c10c-4136-86d0-82bf0e576200\Constants.xaml";
                ConstantsEdit.DKGThemeModifierDirectory(ConstantsLocation_PlayniteModernUI, PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier");
            }
            if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PS5ish_676e10ec-adfe-48d8-a1bd-4d5771b5a2ca\theme.yaml"))
            {
                settings.Settings.IsThemeInstalled_PS5ish = true;
                settings.Settings.IsThemeInstalledHeader_PS5ish = "PS5ish";
            }
            if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\Playnite Deck_905f24da-b02b-40df-9f6b-14c41fcdb05d\theme.yaml"))
            {
                settings.Settings.IsThemeInstalled_PlayniteDeck = true;
                settings.Settings.IsThemeInstalledHeader_PlayniteDeck = "Playnite Deck";
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        }

        public override void OnApplicationStopped(OnApplicationStoppedEventArgs args)
        {
            // Add code to be executed when Playnite is shutting down.
           
        }

        public override void OnLibraryUpdated(OnLibraryUpdatedEventArgs args)
        {
            // Add code to be executed when library is updated.
        }

        public override ISettings GetSettings(bool firstRunSettings)
        {
            return settings;
        }        

        public override UserControl GetSettingsView(bool firstRunSettings)
        {
            return new DKGThemeModifierSettingsView(PlayniteApi, settings);
        }
    }
}