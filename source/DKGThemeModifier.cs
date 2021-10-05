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

            AddCustomElementSupport(new AddCustomElementSupportArgs
            {
                ElementList = new List<string> { "PS5ish_StoreButton" },
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

            if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PlayniteModernUI_b600472c-c10c-4136-86d0-82bf0e576200\theme.yaml"))
            {
                settings.Settings.IsThemeInstalled_PlayniteModernUI = true;
                settings.Settings.IsThemeInstalledHeader_PlayniteModernUI = "PlayniteModernUI";
            }
            if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PS5ish_676e10ec-adfe-48d8-a1bd-4d5771b5a2ca\theme.yaml"))
            {
                settings.Settings.IsThemeInstalled_PS5ish = true;
                settings.Settings.IsThemeInstalledHeader_PS5ish = "PS5ish";
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

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //PS5ish
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
            if (settings.Settings.IsThemeInstalled_PS5ish == true)
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Set Constants Location
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ConstantsLocationPS5ish = PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PS5ish_676e10ec-adfe-48d8-a1bd-4d5771b5a2ca\Constants.xaml";
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Turn Things On and Off
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
                string ReadConstatnts_PS5ish = System.IO.File.ReadAllText(ConstantsLocationPS5ish);

                //Single Row Mode
                ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "SingleRowMode", settings.Settings.SingleRowMode_PS5ish);

                //Left Icon On and Off PS5ish
                ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "LeftIconTrueFalse", settings.Settings.LeftLogo_PS5ish);

                //RightInfo On and Off PS5ish
                ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "RightInfoTrueFalse", settings.Settings.RightInfo_PS5ish);

                //PlaystationStore On and Off PS5ish
                ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "PlaystationStoreTrueFalse", settings.Settings.StoreLogo_PS5ish);
                ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "StoreButtonTrueFalse", settings.Settings.StoreButton_PS5ish);

                //Scale
                if (ReadConstatnts_PS5ish.Contains("ScaleSmall"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "ScaleSmall", settings.Settings.ScaleSmall_PS5ish);
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "ScaleMedium", settings.Settings.ScaleMedium_PS5ish);
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "ScaleLarge", settings.Settings.ScaleLarge_PS5ish);
                }

                //DisableGameBackgroundOnGrid
                if (ReadConstatnts_PS5ish.Contains("DisableGameBackgroundOnGridTrueFalse"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "DisableGameBackgroundOnGridTrueFalse", settings.Settings.DisableGameBackgroundOnGrid_PS5ish);
                }

                //PS5BackgroundOnGrid
                if (ReadConstatnts_PS5ish.Contains("DisableGameBackgroundOnGridTrueFalse"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "PS5BackgroundOnGridTrueFalse", settings.Settings.GridBackground_PS5ish);
                }

                //ThemeIntro
                if (ReadConstatnts_PS5ish.Contains("Intro"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "Intro", true);
                    string sIntroLength = settings.Settings.IntroLength_PS5ish.ToString();
                    ConstantsEdit.IntrroLength(ConstantsLocationPS5ish, sIntroLength);
                }

                //ThemeIntroVideo
                if (ReadConstatnts_PS5ish.Contains("IntroVideo"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "IntroVideo", settings.Settings.IntroVideo_PS5ish);
                    //TheneIntroVideoVolume
                    ConstantsEdit.IntroVideoVulme(ConstantsLocationPS5ish, "IntroVideoVolume", settings.Settings.IntroVideoVolume_PS5ish);
                }

                //Trailers
                if (ReadConstatnts_PS5ish.Contains("Trailers"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "Trailers", settings.Settings.Trailers_PS5ish);
                }
                ////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Changing Labels
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Labels
                string PS5ishReadPlayGameLabel = System.IO.File.ReadAllText(ConstantsLocationPS5ish);
                int PlayGameLabelstart = PS5ishReadPlayGameLabel.IndexOf("<!--PGL--><sys:String x:Key=\"PlayGameLabelString\">");
                int PlayGameLabelend = PS5ishReadPlayGameLabel.IndexOf("</sys:String><!--PGL-->");
                string PlayGameLabeltextBefore = PS5ishReadPlayGameLabel.Substring(0, PlayGameLabelstart);
                string PlayGameLabeltextAfter = PS5ishReadPlayGameLabel.Substring(PlayGameLabelend + 1);
                string PS5ishReadPlayGameLabelReplaced = PlayGameLabeltextBefore + "<!--PGL--><sys:String x:Key=\"PlayGameLabelString\">" + settings.Settings.PlayGameLabel_PS5ish + "<" + PlayGameLabeltextAfter;
                System.IO.File.WriteAllText(ConstantsLocationPS5ish, PS5ishReadPlayGameLabelReplaced);

                string PS5ishReadGameLabel = System.IO.File.ReadAllText(ConstantsLocationPS5ish);
                int GameLabelstart = PS5ishReadGameLabel.IndexOf("<!--GL--><sys:String x:Key=\"GameLabelString\">");
                int GameLabelend = PS5ishReadGameLabel.IndexOf("</sys:String><!--GL-->");
                string GameLabeltextBefore = PS5ishReadGameLabel.Substring(0, GameLabelstart);
                string GameLabeltextAfter = PS5ishReadGameLabel.Substring(GameLabelend + 1);
                string PS5ishReadGameLabelReplaced = GameLabeltextBefore + "<!--GL--><sys:String x:Key=\"GameLabelString\">" + settings.Settings.GameLabel_PS5ish + "<" + GameLabeltextAfter;
                System.IO.File.WriteAllText(ConstantsLocationPS5ish, PS5ishReadGameLabelReplaced);

                string PS5ishReadMediaLabel = System.IO.File.ReadAllText(ConstantsLocationPS5ish);
                int MediaLabelstart = PS5ishReadMediaLabel.IndexOf("<TextBlock x:Key=\"MediaLabel\" Text=\"");
                int MediaLabelend = PS5ishReadMediaLabel.IndexOf("\" Style=\"{DynamicResource TextBlockBaseStyle}\" FontSize=\"36\"></TextBlock>");
                string MediaLabeltextBefore = PS5ishReadMediaLabel.Substring(0, MediaLabelstart);
                string MediaLabeltextAfter = PS5ishReadMediaLabel.Substring(MediaLabelend + 1);
                string PS5ishReadMediaLabelReplaced = MediaLabeltextBefore + "<TextBlock x:Key=\"MediaLabel\" Text=\"" + settings.Settings.MediaLabel_PS5ish + "\"" + MediaLabeltextAfter;
                System.IO.File.WriteAllText(ConstantsLocationPS5ish, PS5ishReadMediaLabelReplaced);

                string PS5ishReadMediaLabelNEW = System.IO.File.ReadAllText(ConstantsLocationPS5ish);
                int MediaLabelstartNEW = PS5ishReadMediaLabelNEW.IndexOf("<TextBlock x:Key=\"MediaLabelNEW\" Text=\"");
                int MediaLabelendNEW = PS5ishReadMediaLabelNEW.IndexOf("\" Style=\"{DynamicResource TextBlockBaseStyle}\" FontSize=\"36\" Foreground=\"#99FFFFFF\"></TextBlock>");
                string MediaLabeltextBeforeNEW = PS5ishReadMediaLabelNEW.Substring(0, MediaLabelstartNEW);
                string MediaLabeltextAfterNEW = PS5ishReadMediaLabelNEW.Substring(MediaLabelendNEW + 1);
                string PS5ishReadMediaLabelReplacedNEW = MediaLabeltextBeforeNEW + "<TextBlock x:Key=\"MediaLabelNEW\" Text=\"" + settings.Settings.MediaLabel_PS5ish + "\"" + MediaLabeltextAfterNEW;
                System.IO.File.WriteAllText(ConstantsLocationPS5ish, PS5ishReadMediaLabelReplacedNEW);

                string PS5ishReadProgressLabel = System.IO.File.ReadAllText(ConstantsLocationPS5ish);
                int ProgressLabelstart = PS5ishReadProgressLabel.IndexOf("<!--PL--><Setter Property=\"Text\" Value=\"");
                int ProgressLabelend = PS5ishReadProgressLabel.IndexOf("\" /><!--PL-->");
                string ProgressLabeltextBefore = PS5ishReadProgressLabel.Substring(0, ProgressLabelstart);
                string ProgressLabeltextAfter = PS5ishReadProgressLabel.Substring(ProgressLabelend + 1);
                string PS5ishReadProgressLabelReplaced = ProgressLabeltextBefore + "<!--PL--><Setter Property=\"Text\" Value=\"" + settings.Settings.ProgressLabel_PS5ish + "\"" + ProgressLabeltextAfter;
                System.IO.File.WriteAllText(ConstantsLocationPS5ish, PS5ishReadProgressLabelReplaced);

                string PS5ishReadEarnedLabel = System.IO.File.ReadAllText(ConstantsLocationPS5ish);
                int EarnedLabelstart = PS5ishReadEarnedLabel.IndexOf("<!--EL--><Setter Property=\"Text\" Value=\"");
                int EarnedLabelend = PS5ishReadEarnedLabel.IndexOf("\" /><!--EL-->");
                string EarnedLabeltextBefore = PS5ishReadEarnedLabel.Substring(0, EarnedLabelstart);
                string EarnedLabeltextAfter = PS5ishReadEarnedLabel.Substring(EarnedLabelend + 1);
                string PS5ishReadEarnedLabelReplaced = EarnedLabeltextBefore + "<!--EL--><Setter Property=\"Text\" Value=\"" + settings.Settings.EarnedLabel_PS5ish + "\"" + EarnedLabeltextAfter;
                System.IO.File.WriteAllText(ConstantsLocationPS5ish, PS5ishReadEarnedLabelReplaced);
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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