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

namespace DKGThemeModifier
{
    public class DKGThemeModifier : GenericPlugin
    {
        private static readonly ILogger logger = LogManager.GetLogger();

        //private DKGThemeModifierSettingsViewModel settings { get; set; }
        private DKGThemeModifierSettingsViewModel settings { get; set; }

        public override Guid Id { get; } = Guid.Parse("ee4ed2de-7e02-4447-8441-685d320b0520");

        public DKGThemeModifier(IPlayniteAPI api) : base(api)
        {
            //settings = new DKGThemeModifierSettingsViewModel(this);
            settings = new DKGThemeModifierSettingsViewModel(this);
            Properties = new GenericPluginProperties
            {
                HasSettings = true
            };
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
            //PlayniteModernUI
            if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PlayniteModernUI_b600472c-c10c-4136-86d0-82bf0e576200\theme.yaml"))
            {
                settings.Settings.IsThemeInstalled_PlayniteModernUI = true;
                settings.Settings.IsThemeInstalledHeader_PlayniteModernUI = "PlayniteModernUI";
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }

        public override void OnApplicationStopped(OnApplicationStoppedEventArgs args)
        {
            // Add code to be executed when Playnite is shutting down.

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //PlayniteModernUI
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
            if (settings.Settings.IsThemeInstalled_PlayniteModernUI == true)
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Set Constants Location
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ConstantsLocation_PlayniteModernUI = PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PlayniteModernUI_b600472c-c10c-4136-86d0-82bf0e576200\Constants.xaml";
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Set Backgrounds + Sounds Locations
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string SoundDestination = PlayniteApi.Paths.ConfigurationPath + @"\ExtensionsData\9c960604-b8bc-4407-a4e4-e291c6097c7d\Sound Files\PlayniteModernUI";
                string BackgroundDestination = PlayniteApi.Paths.ConfigurationPath + @"\ExtraMetadata\Themes\Fullscreen\PlayniteModernUI";
                Directory.CreateDirectory(SoundDestination);
                Directory.CreateDirectory(BackgroundDestination);
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                string ReadConstatnts_PlayniteModernUI = File.ReadAllText(ConstantsLocation_PlayniteModernUI);

                //COLOUR PICKER
                if (settings.Settings.Colour1_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "54A81B"); }
                if (settings.Settings.Colour2_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "107C10"); }
                if (settings.Settings.Colour3_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "108272"); }
                if (settings.Settings.Colour4_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "148282"); }
                if (settings.Settings.Colour5_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "1081CA"); }
                if (settings.Settings.Colour6_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "1073D6"); }
                if (settings.Settings.Colour7_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "193E91"); }
                if (settings.Settings.Colour8_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "744DA9"); }
                if (settings.Settings.Colour9_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "B144C0"); }
                if (settings.Settings.Colour10_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "ED5588"); }
                if (settings.Settings.Colour11_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "BF1077"); }
                if (settings.Settings.Colour12_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "A21025"); }
                if (settings.Settings.Colour13_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "E31123"); }
                if (settings.Settings.Colour14_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "EB4910"); }
                if (settings.Settings.Colour15_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "EB8C10"); }
                if (settings.Settings.Colour16_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "724F2F"); }
                if (settings.Settings.Colour17_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "7E715C"); }
                if (settings.Settings.Colour18_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "547A72"); }
                if (settings.Settings.Colour19_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "677488"); }
                if (settings.Settings.Colour20_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "737373"); }
                if (settings.Settings.Colour21_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "4C4A4B"); }
                if (settings.Settings.Colour22_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "00BAAF"); }

                //ThemeIntro
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "Intro", settings.Settings.ThemeIntro_PlayniteModernUI);
                string sIntroLength = settings.Settings.IntroLength_PlayniteModernUI.ToString();
                ConstantsEdit.IntrroLength(ConstantsLocation_PlayniteModernUI, sIntroLength);

                //ThemeIntroVideo
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "IntroVideo", settings.Settings.IntroVideo_PlayniteModernUI);
                //TheneIntroVideoVolume
                ConstantsEdit.IntroVideoVulme(ConstantsLocation_PlayniteModernUI, "IntroVideoVolume", settings.Settings.IntroVideoVolume_PlayniteModernUI);

                //Banners
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "Banners", settings.Settings.Banners_PlayniteModernUI);

                //VideoCovers
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "VideoCovers", settings.Settings.VideoCovers_PlayniteModernUI);

                //VideoBackgrounds
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "VideoBackgrounds", settings.Settings.VideoBackgrounds_PlayniteModernUI);

                //Trailers
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "Trailers", settings.Settings.Trailers_PlayniteModernUI);

                //FilterPresets
                string sFilterShoulderSize = (settings.Settings.FilterFontSmall_PlayniteModernUI * 1.7).ToString("F0", CultureInfo.InvariantCulture);
                string sFilterFontLarge = (settings.Settings.FilterFontSmall_PlayniteModernUI * 1.1).ToString("F0", CultureInfo.InvariantCulture);
                ConstantsEdit.FilterPresetSize(ConstantsLocation_PlayniteModernUI, settings.Settings.FilterFontSmall_PlayniteModernUI.ToString(), sFilterFontLarge, sFilterShoulderSize);

                //SideBar
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "SideBanners", settings.Settings.SideBanners_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "SideBar", settings.Settings.SideBar_PlayniteModernUI);

                //MainScreenLogo
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "MainScreenLogo", settings.Settings.MainLogo_PlayniteModernUI);

                //RoundedCorners
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "RoundedCorners", settings.Settings.RoundedCorners_PlayniteModernUI);
                string sRoundedCorners = settings.Settings.RoundedCornersAmount_PlayniteModernUI.ToString();
                ConstantsEdit.RoundedCorners(ConstantsLocation_PlayniteModernUI, sRoundedCorners);
            }
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
            return new DKGThemeModifierSettingsView();
        }
    }
}