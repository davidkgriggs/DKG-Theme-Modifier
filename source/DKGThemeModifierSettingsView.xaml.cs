using Playnite.SDK;
using Playnite.SDK.Controls;
using Playnite.SDK.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Path = System.IO.Path;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Text.RegularExpressions;
using System.IO.Compression;

namespace DKGThemeModifier
{
    public partial class DKGThemeModifierSettingsView : UserControl
    {
        IPlayniteAPI PlayniteApi; public DKGThemeModifierSettingsViewModel SettingsModel { get; set; }

        public DKGThemeModifierSettingsView(IPlayniteAPI PlayniteApi, DKGThemeModifierSettingsViewModel settings)
        {
            InitializeComponent();
            this.PlayniteApi = PlayniteApi;
            SettingsModel = settings;
        }

        private void OpenFilterIcons(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string Location = PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\Icons";
            Process.Start("explorer.exe", Location);
        }

        private void OpenPlatformBackgrounds(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string Location = PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformBackgrounds";
            Process.Start("explorer.exe", Location);
        }

        private void OpenPlatformColours(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string Location = PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformColours";
            Process.Start("explorer.exe", Location);
        }

        private void OpenPlatformImages(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string Location = PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformImages";
            Process.Start("explorer.exe", Location);
        }

        private void OpenPlatformLogos(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string Location = PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformLogos";
            Process.Start("explorer.exe", Location);
        }

        private void OpenPlatformScreenshots(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string Location = PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformScreenshots";
            Process.Start("explorer.exe", Location);
        }

        private void OpenPlatformTrailers(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string Location = PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformTrailers";
            Process.Start("explorer.exe", Location);
        }

        private void PlayniteModernUI_Commit(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //PlayniteModernUI
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
            if (SettingsModel.Settings.IsThemeInstalled_PlayniteModernUI == true)
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Set Constants Location
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ConstantsLocation_PlayniteModernUI = PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PlayniteModernUI_b600472c-c10c-4136-86d0-82bf0e576200\Constants.xaml";
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ReadConstatnts_PlayniteModernUI = File.ReadAllText(ConstantsLocation_PlayniteModernUI);

                //COLOUR PICKER
                if (SettingsModel.Settings.Colour1_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "54A81B"); }
                if (SettingsModel.Settings.Colour2_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "107C10"); }
                if (SettingsModel.Settings.Colour3_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "108272"); }
                if (SettingsModel.Settings.Colour4_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "148282"); }
                if (SettingsModel.Settings.Colour5_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "1081CA"); }
                if (SettingsModel.Settings.Colour6_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "1073D6"); }
                if (SettingsModel.Settings.Colour7_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "193E91"); }
                if (SettingsModel.Settings.Colour8_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "744DA9"); }
                if (SettingsModel.Settings.Colour9_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "B144C0"); }
                if (SettingsModel.Settings.Colour10_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "ED5588"); }
                if (SettingsModel.Settings.Colour11_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "BF1077"); }
                if (SettingsModel.Settings.Colour12_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "A21025"); }
                if (SettingsModel.Settings.Colour13_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "E31123"); }
                if (SettingsModel.Settings.Colour14_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "EB4910"); }
                if (SettingsModel.Settings.Colour15_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "EB8C10"); }
                if (SettingsModel.Settings.Colour16_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "724F2F"); }
                if (SettingsModel.Settings.Colour17_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "7E715C"); }
                if (SettingsModel.Settings.Colour18_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "547A72"); }
                if (SettingsModel.Settings.Colour19_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "677488"); }
                if (SettingsModel.Settings.Colour20_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "737373"); }
                if (SettingsModel.Settings.Colour21_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "4C4A4B"); }
                if (SettingsModel.Settings.Colour22_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "00BAAF"); }

                //ThemeIntro
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "Intro", SettingsModel.Settings.ThemeIntro_PlayniteModernUI);
                if (SettingsModel.Settings.ThemeIntro_PlayniteModernUI == true)
                {
                    string sIntroLength = SettingsModel.Settings.IntroLength_PlayniteModernUI.ToString();
                    ConstantsEdit.IntroLength(ConstantsLocation_PlayniteModernUI, sIntroLength);
                }

                //ThemeIntroVideo
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "IntroVideo", SettingsModel.Settings.IntroVideo_PlayniteModernUI);
                //TheneIntroVideoVolume
                ConstantsEdit.IntroVideoVolume(ConstantsLocation_PlayniteModernUI, "IntroVideoVolume", SettingsModel.Settings.IntroVideoVolume_PlayniteModernUI);

                //Banners
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "Banners", SettingsModel.Settings.Banners_PlayniteModernUI);

                //VideoCovers
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "VideoCovers", SettingsModel.Settings.VideoCovers_PlayniteModernUI);

                //VideoBackgrounds
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "VideoBackgrounds", SettingsModel.Settings.VideoBackgrounds_PlayniteModernUI);

                //Trailers
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "Trailers", SettingsModel.Settings.Trailers_PlayniteModernUI);

                //SideBar
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "SideBanners", SettingsModel.Settings.SideBanners_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "SideBar", SettingsModel.Settings.SideBar_PlayniteModernUI);

                //MainScreenLogo
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "MainScreenLogo", SettingsModel.Settings.MainLogo_PlayniteModernUI);

                //RoundedCorners
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "RoundedCorners", SettingsModel.Settings.RoundedCorners_PlayniteModernUI);
                if (SettingsModel.Settings.RoundedCorners_PlayniteModernUI == true)
                {
                    string sRoundedCorners = SettingsModel.Settings.RoundedCornersAmount_PlayniteModernUI.ToString();
                    ConstantsEdit.RoundedCorners(ConstantsLocation_PlayniteModernUI, sRoundedCorners);
                }

                //DescriptionOnOff
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "DescriptionOnOff", SettingsModel.Settings.DescriptionOnOff_PlayniteModernUI);

                //FilterPresetsVertical
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "FilterPresetVertical", SettingsModel.Settings.FilterPresetsVertical_PlayniteModernUI);
                
                //DropShadows
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "DropShadows", SettingsModel.Settings.DropShadows_PlayniteModernUI);

                string sListGamesHeight = SettingsModel.Settings.ListGamesHeight_PlayniteModernUI.ToString();
                ConstantsEdit.ListGameHeight(ConstantsLocation_PlayniteModernUI, sListGamesHeight);
            }

            PlayniteApi.Dialogs.ShowMessage("Changes Applied");
        }

        //APPLY DEFAULTS
        private void PlayniteModernUI_Defaults(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync(new Uri("https://github.com/davidkgriggs/PlayniteModernUI/raw/main/source/Constants.xaml"), PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PlayniteModernUI_b600472c-c10c-4136-86d0-82bf0e576200\Constants.xaml");

                PlayniteApi.Dialogs.ShowMessage("Defaults Applied");
            }
        }

        //DOWNLOAD ICONS FROM GITHUB
        private void PlayniteModernUI_DownloadIcons(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(new Uri("https://github.com/davidkgriggs/DKG-Theme-Modifier/raw/main/DKGThemeModifier/FilterPresets/Icons/Icons.zip"), PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\Icons\Icons.zip");
                
                if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\Icons\Icons.zip"))
                {
                    ZipArchive OpenRead(string filename)
                    {
                        return new ZipArchive(File.OpenRead(filename), ZipArchiveMode.Read);
                    }
                    ZipArchive zipArchive =  OpenRead(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\Icons\Icons.zip");
                    foreach (ZipArchiveEntry entry in zipArchive.Entries)
                    {
                        entry.ExtractToFile(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\Icons\" + entry.Name, true);
                    }
                    zipArchive.Dispose();

                    //ZipFile.ExtractToDirectory(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\Icons\Icons.zip", PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\Icons\");
                    File.Delete(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\Icons\Icons.zip");
                    PlayniteApi.Dialogs.ShowMessage("Icons Downloaded");
                }
            }
        }

        private void PS5ish_Commit(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //PS5ish
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
            if (SettingsModel.Settings.IsThemeInstalled_PS5ish == true)
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
                ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "SingleRowMode", SettingsModel.Settings.SingleRowMode_PS5ish);

                //Left Icon On and Off PS5ish
                ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "LeftIconTrueFalse", SettingsModel.Settings.LeftLogo_PS5ish);

                //RightInfo On and Off PS5ish
                ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "RightInfoTrueFalse", SettingsModel.Settings.RightInfo_PS5ish);

                //PlaystationStore On and Off PS5ish
                ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "PlaystationStoreTrueFalse", SettingsModel.Settings.StoreLogo_PS5ish);
                ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "StoreButtonTrueFalse", SettingsModel.Settings.StoreButton_PS5ish);

                //Scale
                if (ReadConstatnts_PS5ish.Contains("ScaleSmall"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "ScaleSmall", SettingsModel.Settings.ScaleSmall_PS5ish);
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "ScaleMedium", SettingsModel.Settings.ScaleMedium_PS5ish);
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "ScaleLarge", SettingsModel.Settings.ScaleLarge_PS5ish);
                }

                //DisableGameBackgroundOnGrid
                if (ReadConstatnts_PS5ish.Contains("DisableGameBackgroundOnGridTrueFalse"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "DisableGameBackgroundOnGridTrueFalse", SettingsModel.Settings.DisableGameBackgroundOnGrid_PS5ish);
                }

                //PS5BackgroundOnGrid
                if (ReadConstatnts_PS5ish.Contains("DisableGameBackgroundOnGridTrueFalse"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "PS5BackgroundOnGridTrueFalse", SettingsModel.Settings.GridBackground_PS5ish);
                }

                //ThemeIntro
                if (ReadConstatnts_PS5ish.Contains("Intro"))
                {
                    string sIntroLength = SettingsModel.Settings.IntroLength_PS5ish.ToString();
                    ConstantsEdit.IntroLength(ConstantsLocationPS5ish, sIntroLength);
                }

                //ThemeIntroVideo
                if (ReadConstatnts_PS5ish.Contains("IntroVideo"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "IntroVideo", SettingsModel.Settings.IntroVideo_PS5ish);
                    //TheneIntroVideoVolume
                    ConstantsEdit.IntroVideoVolume(ConstantsLocationPS5ish, "IntroVideoVolume", SettingsModel.Settings.IntroVideoVolume_PS5ish);
                }

                //Trailers
                if (ReadConstatnts_PS5ish.Contains("Trailers"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "Trailers", SettingsModel.Settings.Trailers_PS5ish);
                }

                //Micro Video backgrounds
                if (ReadConstatnts_PS5ish.Contains("MicroVideoBackgrounds"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "MicroVideoBackgrounds", SettingsModel.Settings.MicroVideoBackgrounds_PS5ish);
                }

                //Full Video Backgrounds
                if (ReadConstatnts_PS5ish.Contains("TrailerVideoBackgrounds"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPS5ish, "TrailerVideoBackgrounds", SettingsModel.Settings.FullVideoBackgrounds_PS5ish);
                }

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Changing Labels
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Defaults
                if (SettingsModel.Settings.LabelDefaults_PS5ish == true)
                {
                    SettingsModel.Settings.PlayLabel_PS5ish = "{DynamicResource LOCPlayGame}";
                    SettingsModel.Settings.PlayGameLabel_PS5ish = "Game";
                    SettingsModel.Settings.ProgressLabel_PS5ish = "{DynamicResource LOCSuccessStoryProgress}";
                    SettingsModel.Settings.EarnedLabel_PS5ish = "{DynamicResource LOCSuccessStoryEarned}";
                }
                
                //Labels
                string PS5ishReadPlayLabel = System.IO.File.ReadAllText(ConstantsLocationPS5ish);
                int PlayLabelstart = PS5ishReadPlayLabel.IndexOf("<!--PYL--><Setter Property=\"Text\" Value=\"");
                int PlayLabelend = PS5ishReadPlayLabel.IndexOf("\" /><!--PYL-->");
                string PlayLabeltextBefore = PS5ishReadPlayLabel.Substring(0, PlayLabelstart);
                string PlayLabeltextAfter = PS5ishReadPlayLabel.Substring(PlayLabelend + 1);
                string PS5ishReadPlayLabelReplaced = PlayLabeltextBefore + "<!--PYL--><Setter Property=\"Text\" Value=\"" + SettingsModel.Settings.PlayLabel_PS5ish + "\"" + PlayLabeltextAfter;
                System.IO.File.WriteAllText(ConstantsLocationPS5ish, PS5ishReadPlayLabelReplaced);

                string PS5ishReadPlayGameLabel = System.IO.File.ReadAllText(ConstantsLocationPS5ish);
                int PlayGameLabelstart = PS5ishReadPlayGameLabel.IndexOf("<!--PGL--><sys:String x:Key=\"PlayGameLabelString\">");
                int PlayGameLabelend = PS5ishReadPlayGameLabel.IndexOf("</sys:String><!--PGL-->");
                string PlayGameLabeltextBefore = PS5ishReadPlayGameLabel.Substring(0, PlayGameLabelstart);
                string PlayGameLabeltextAfter = PS5ishReadPlayGameLabel.Substring(PlayGameLabelend + 1);
                string PS5ishReadPlayGameLabelReplaced = PlayGameLabeltextBefore + "<!--PGL--><sys:String x:Key=\"PlayGameLabelString\">" + SettingsModel.Settings.PlayGameLabel_PS5ish + "<" + PlayGameLabeltextAfter;
                System.IO.File.WriteAllText(ConstantsLocationPS5ish, PS5ishReadPlayGameLabelReplaced);

                string PS5ishReadProgressLabel = System.IO.File.ReadAllText(ConstantsLocationPS5ish);
                int ProgressLabelstart = PS5ishReadProgressLabel.IndexOf("<!--PL--><Setter Property=\"Text\" Value=\"");
                int ProgressLabelend = PS5ishReadProgressLabel.IndexOf("\" /><!--PL-->");
                string ProgressLabeltextBefore = PS5ishReadProgressLabel.Substring(0, ProgressLabelstart);
                string ProgressLabeltextAfter = PS5ishReadProgressLabel.Substring(ProgressLabelend + 1);
                string PS5ishReadProgressLabelReplaced = ProgressLabeltextBefore + "<!--PL--><Setter Property=\"Text\" Value=\"" + SettingsModel.Settings.ProgressLabel_PS5ish + "\"" + ProgressLabeltextAfter;
                System.IO.File.WriteAllText(ConstantsLocationPS5ish, PS5ishReadProgressLabelReplaced);

                string PS5ishReadEarnedLabel = System.IO.File.ReadAllText(ConstantsLocationPS5ish);
                int EarnedLabelstart = PS5ishReadEarnedLabel.IndexOf("<!--EL--><Setter Property=\"Text\" Value=\"");
                int EarnedLabelend = PS5ishReadEarnedLabel.IndexOf("\" /><!--EL-->");
                string EarnedLabeltextBefore = PS5ishReadEarnedLabel.Substring(0, EarnedLabelstart);
                string EarnedLabeltextAfter = PS5ishReadEarnedLabel.Substring(EarnedLabelend + 1);
                string PS5ishReadEarnedLabelReplaced = EarnedLabeltextBefore + "<!--EL--><Setter Property=\"Text\" Value=\"" + SettingsModel.Settings.EarnedLabel_PS5ish + "\"" + EarnedLabeltextAfter;
                System.IO.File.WriteAllText(ConstantsLocationPS5ish, PS5ishReadEarnedLabelReplaced);
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }

            PlayniteApi.Dialogs.ShowMessage("Changes Applied");
        }

        private void PS5ish_Defaults(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync(new Uri("https://github.com/davidkgriggs/PS5ish/raw/main/source/Constants.xaml"), PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PS5ish_676e10ec-adfe-48d8-a1bd-4d5771b5a2ca\Constants.xaml");

                PlayniteApi.Dialogs.ShowMessage("Defaults Applied");
            }
        }

        private void PalyniteDeck_Commit(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //PlayniteDeck
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
            if (SettingsModel.Settings.IsThemeInstalled_PlayniteDeck == true)
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Set Constants Location
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ConstantsLocationPlayniteDeck = PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\Playnite Deck_905f24da-b02b-40df-9f6b-14c41fcdb05d\Constants.xaml";
                string ReadConstatnts_PlayniteDeck = System.IO.File.ReadAllText(ConstantsLocationPlayniteDeck);
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //Trailers
                if (ReadConstatnts_PlayniteDeck.Contains("Trailers"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPlayniteDeck, "Trailers", SettingsModel.Settings.Trailers_PlayniteDeck);
                }

                //Steam backgrounds
                if (ReadConstatnts_PlayniteDeck.Contains("SteamBackground"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPlayniteDeck, "SteamBackground", SettingsModel.Settings.SteamBackgrounds_PlayniteDeck);
                }

                //New To Library
                if (ReadConstatnts_PlayniteDeck.Contains("NewToLibrary"))
                {
                    ConstantsEdit.TrueFalse(ConstantsLocationPlayniteDeck, "NewToLibraryBool", SettingsModel.Settings.NewToLibraryBool_PlayniteDeck);
                }

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Changing Labels
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //Labels
                string PlayniteDeck_ReadNewToLibrary = System.IO.File.ReadAllText(ConstantsLocationPlayniteDeck);
                int PDNTLstart = PlayniteDeck_ReadNewToLibrary.IndexOf("<!--NTL--><sys:String x:Key=\"NewToLibrary\">");
                int PDNTLend = PlayniteDeck_ReadNewToLibrary.IndexOf("</sys:String><!--NTL-->");
                string PDNTLtextBefore = PlayniteDeck_ReadNewToLibrary.Substring(0, PDNTLstart);
                string PDNTLtextAfter = PlayniteDeck_ReadNewToLibrary.Substring(PDNTLend + 1);
                string PlayniteDeck_NewToLibraryReplaced = PDNTLtextBefore + "<!--NTL--><sys:String x:Key=\"NewToLibrary\">" + SettingsModel.Settings.NewToLibrary_PlayniteDeck + "<" + PDNTLtextAfter;
                System.IO.File.WriteAllText(ConstantsLocationPlayniteDeck, PlayniteDeck_NewToLibraryReplaced);
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }

            PlayniteApi.Dialogs.ShowMessage("Changes Applied");
        }

        private void PlayniteDeck_Defaults(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync(new Uri("https://github.com/davidkgriggs/Playnite-Deck/raw/main/source/Constants.xaml"), PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\Playnite Deck_905f24da-b02b-40df-9f6b-14c41fcdb05d\Constants.xaml");

                PlayniteApi.Dialogs.ShowMessage("Defaults Applied");
            }
        }

        private void Platforms_Commit(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Platforms
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
            if (SettingsModel.Settings.IsThemeInstalled_Platforms == true)
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Set Constants Location
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ConstantsLocation_Platforms = PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\Platforms_4fa3f095-357d-49d5-828e-dcf6894deae3\Constants.xaml";
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ReadConstatnts_Platforms = File.ReadAllText(ConstantsLocation_Platforms);

                //COLOUR PICKER
                if (SettingsModel.Settings.Colour1_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "54A81B"); }
                if (SettingsModel.Settings.Colour2_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "107C10"); }
                if (SettingsModel.Settings.Colour3_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "108272"); }
                if (SettingsModel.Settings.Colour4_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "148282"); }
                if (SettingsModel.Settings.Colour5_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "1081CA"); }
                if (SettingsModel.Settings.Colour6_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "1073D6"); }
                if (SettingsModel.Settings.Colour7_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "193E91"); }
                if (SettingsModel.Settings.Colour8_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "744DA9"); }
                if (SettingsModel.Settings.Colour9_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "B144C0"); }
                if (SettingsModel.Settings.Colour10_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "ED5588"); }
                if (SettingsModel.Settings.Colour11_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "BF1077"); }
                if (SettingsModel.Settings.Colour12_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "A21025"); }
                if (SettingsModel.Settings.Colour13_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "E31123"); }
                if (SettingsModel.Settings.Colour14_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "EB4910"); }
                if (SettingsModel.Settings.Colour15_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "EB8C10"); }
                if (SettingsModel.Settings.Colour16_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "724F2F"); }
                if (SettingsModel.Settings.Colour17_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "7E715C"); }
                if (SettingsModel.Settings.Colour18_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "547A72"); }
                if (SettingsModel.Settings.Colour19_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "677488"); }
                if (SettingsModel.Settings.Colour20_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "737373"); }
                if (SettingsModel.Settings.Colour21_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "4C4A4B"); }
                if (SettingsModel.Settings.Colour22_Platforms == true) { ConstantsEdit.ColourPicker(ConstantsLocation_Platforms, "00BAAF"); }

                //ThemeIntro
                ConstantsEdit.TrueFalse(ConstantsLocation_Platforms, "Intro", SettingsModel.Settings.ThemeIntro_Platforms);
                if (SettingsModel.Settings.ThemeIntro_Platforms == true)
                {
                    string sIntroLength = SettingsModel.Settings.IntroLength_Platforms.ToString();
                    ConstantsEdit.IntroLength(ConstantsLocation_Platforms, sIntroLength);
                }

                //ThemeIntroVideo
                ConstantsEdit.TrueFalse(ConstantsLocation_Platforms, "IntroVideo", SettingsModel.Settings.IntroVideo_Platforms);
                //TheneIntroVideoVolume
                ConstantsEdit.IntroVideoVolume(ConstantsLocation_Platforms, "IntroVideoVolume", SettingsModel.Settings.IntroVideoVolume_Platforms);

                //Banners
                ConstantsEdit.TrueFalse(ConstantsLocation_Platforms, "Banners", SettingsModel.Settings.Banners_Platforms);

                //VideoCovers
                ConstantsEdit.TrueFalse(ConstantsLocation_Platforms, "VideoCovers", SettingsModel.Settings.VideoCovers_Platforms);

                //VideoBackgrounds
                ConstantsEdit.TrueFalse(ConstantsLocation_Platforms, "VideoBackgrounds", SettingsModel.Settings.VideoBackgrounds_Platforms);

                //SideBar
                ConstantsEdit.TrueFalse(ConstantsLocation_Platforms, "SideBar", SettingsModel.Settings.SideBar_Platforms);

                //PlaatformBackgrounds
                ConstantsEdit.TrueFalse(ConstantsLocation_Platforms, "PlatformImageBackgrounds", SettingsModel.Settings.PlatformBackgrounds_Platforms);

                //Trailers
                ConstantsEdit.TrueFalse(ConstantsLocation_Platforms, "Trailers", SettingsModel.Settings.Trailers_Platforms);

                //RoundedCorners
                ConstantsEdit.TrueFalse(ConstantsLocation_Platforms, "RoundedCorners", SettingsModel.Settings.RoundedCorners_Platforms);
                if (SettingsModel.Settings.RoundedCorners_Platforms == true)
                {
                    string sRoundedCorners = SettingsModel.Settings.RoundedCornersAmount_Platforms.ToString();
                    ConstantsEdit.RoundedCorners(ConstantsLocation_Platforms, sRoundedCorners);
                }

                string sListGamesHeight = SettingsModel.Settings.ListGamesHeight_Platforms.ToString();
                ConstantsEdit.ListGameHeight(ConstantsLocation_Platforms, sListGamesHeight);

                ConstantsEdit.FilterPresetWidth(ConstantsLocation_Platforms,  SettingsModel.Settings.FilterPresetWidth_Platforms);
            }

            PlayniteApi.Dialogs.ShowMessage("Changes Applied");
        }

        //APPLY DEFAULTS
        private void Platforms_Defaults(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync(new Uri("https://github.com/davidkgriggs/Platforms/raw/main/source/Constants.xaml"), PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\Platforms_4fa3f095-357d-49d5-828e-dcf6894deae3\Constants.xaml");

                PlayniteApi.Dialogs.ShowMessage("Defaults Applied");
            }
        }

        //DOWNLOAD PLATFORMBACKGROUNDS FROM GITHUB
        private void DownloadPlatformBackgrounds(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(new Uri("https://github.com/davidkgriggs/DKG-Theme-Modifier/raw/main/DKGThemeModifier/FilterPresets/PlatformBackgrounds/Backgrounds.zip"), PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformBackgrounds\Backgrounds.zip");

                if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformBackgrounds\Backgrounds.zip"))
                {
                    ZipArchive OpenRead(string filename)
                    {
                        return new ZipArchive(File.OpenRead(filename), ZipArchiveMode.Read);
                    }
                    ZipArchive zipArchive = OpenRead(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformBackgrounds\Backgrounds.zip");
                    foreach (ZipArchiveEntry entry in zipArchive.Entries)
                    {
                        entry.ExtractToFile(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformBackgrounds\" + entry.Name, true);
                    }
                    zipArchive.Dispose();

                    File.Delete(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformBackgrounds\Backgrounds.zip");
                    PlayniteApi.Dialogs.ShowMessage("Backgrounds Downloaded");
                }
            }
        }
        //DOWNLOAD PLATFORMColours FROM GITHUB
        private void DownloadPlatformColours(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(new Uri("https://github.com/davidkgriggs/DKG-Theme-Modifier/raw/main/DKGThemeModifier/FilterPresets/PlatformColours/Colours.zip"), PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformColours\Colours.zip");

                if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformColours\Colours.zip"))
                {
                    ZipArchive OpenRead(string filename)
                    {
                        return new ZipArchive(File.OpenRead(filename), ZipArchiveMode.Read);
                    }
                    ZipArchive zipArchive = OpenRead(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformColours\Colours.zip");
                    foreach (ZipArchiveEntry entry in zipArchive.Entries)
                    {
                        entry.ExtractToFile(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformColours\" + entry.Name, true);
                    }
                    zipArchive.Dispose();

                    File.Delete(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformColours\Colours.zip");
                    PlayniteApi.Dialogs.ShowMessage("Colours Downloaded");
                }
            }
        }
        //DOWNLOAD PLATFORMImages FROM GITHUB
        private void DownloadPlatformImages(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(new Uri("https://github.com/davidkgriggs/DKG-Theme-Modifier/raw/main/DKGThemeModifier/FilterPresets/PlatformImages/Images.zip"), PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformImages\Images.zip");

                if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformImages\Images.zip"))
                {
                    ZipArchive OpenRead(string filename)
                    {
                        return new ZipArchive(File.OpenRead(filename), ZipArchiveMode.Read);
                    }
                    ZipArchive zipArchive = OpenRead(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformImages\Images.zip");
                    foreach (ZipArchiveEntry entry in zipArchive.Entries)
                    {
                        entry.ExtractToFile(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformImages\" + entry.Name, true);
                    }
                    zipArchive.Dispose();

                    File.Delete(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformImages\Images.zip");
                    PlayniteApi.Dialogs.ShowMessage("Images Downloaded");
                }
            }
        }
        //DOWNLOAD PLATFORMLogos FROM GITHUB
        private void DownloadPlatformLogos(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(new Uri("https://github.com/davidkgriggs/DKG-Theme-Modifier/raw/main/DKGThemeModifier/FilterPresets/PlatformLogos/Logos.zip"), PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformLogos\Logos.zip");

                if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformLogos\Logos.zip"))
                {
                    ZipArchive OpenRead(string filename)
                    {
                        return new ZipArchive(File.OpenRead(filename), ZipArchiveMode.Read);
                    }
                    ZipArchive zipArchive = OpenRead(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformLogos\Logos.zip");
                    foreach (ZipArchiveEntry entry in zipArchive.Entries)
                    {
                        entry.ExtractToFile(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformLogos\" + entry.Name, true);
                    }
                    zipArchive.Dispose();

                    File.Delete(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformLogos\Logos.zip");
                    PlayniteApi.Dialogs.ShowMessage("Logos Downloaded");
                }
            }
        }
        //DOWNLOAD PLATFORMScreenshots FROM GITHUB
        private void DownloadPlatformScreenshots(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(new Uri("https://github.com/davidkgriggs/DKG-Theme-Modifier/raw/main/DKGThemeModifier/FilterPresets/PlatformScreenshots/Screenshots.zip"), PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformScreenshots\Screenshots.zip");

                if (File.Exists(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformScreenshots\Screenshots.zip"))
                {
                    ZipArchive OpenRead(string filename)
                    {
                        return new ZipArchive(File.OpenRead(filename), ZipArchiveMode.Read);
                    }
                    ZipArchive zipArchive = OpenRead(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformScreenshots\Screenshots.zip");
                    foreach (ZipArchiveEntry entry in zipArchive.Entries)
                    {
                        entry.ExtractToFile(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformScreenshots\" + entry.Name, true);
                    }
                    zipArchive.Dispose();

                    File.Delete(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\PlatformScreenshots\Screenshots.zip");
                    PlayniteApi.Dialogs.ShowMessage("Screenshots Downloaded");
                }
            }
        }


        private void XBOXSERIESish_Commit(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //XBOXSERIESish
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
            if (SettingsModel.Settings.IsThemeInstalled_XBOXSERIESish == true)
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Set Constants Location
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ConstantsLocation_XBOXSERIESish = PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\XBOXSERIESish_74735df9-3351-4669-a1ff-50f18f39b63b\Constants.xaml";
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ReadConstatnts_XBOXSERIESish = File.ReadAllText(ConstantsLocation_XBOXSERIESish);

                ConstantsEdit.ProfileName(ConstantsLocation_XBOXSERIESish, SettingsModel.Settings.ProfileName_XBOXSERIESish);

                //DARKLIGHTMODE
                if (SettingsModel.Settings.DarkMode_XBOXSERIESish == true) { ConstantsEdit.DarkMode(ConstantsLocation_XBOXSERIESish); }
                if (SettingsModel.Settings.LightMode_XBOXSERIESish == true) { ConstantsEdit.LightMode(ConstantsLocation_XBOXSERIESish); }

                //COLOUR PICKER
                if (SettingsModel.Settings.Colour1_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "54A81B"); }
                if (SettingsModel.Settings.Colour2_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "107C10"); }
                if (SettingsModel.Settings.Colour3_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "108272"); }
                if (SettingsModel.Settings.Colour4_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "148282"); }
                if (SettingsModel.Settings.Colour5_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "1081CA"); }
                if (SettingsModel.Settings.Colour6_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "1073D6"); }
                if (SettingsModel.Settings.Colour7_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "193E91"); }
                if (SettingsModel.Settings.Colour8_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "744DA9"); }
                if (SettingsModel.Settings.Colour9_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "B144C0"); }
                if (SettingsModel.Settings.Colour10_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "ED5588"); }
                if (SettingsModel.Settings.Colour11_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "BF1077"); }
                if (SettingsModel.Settings.Colour12_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "A21025"); }
                if (SettingsModel.Settings.Colour13_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "E31123"); }
                if (SettingsModel.Settings.Colour14_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "EB4910"); }
                if (SettingsModel.Settings.Colour15_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "EB8C10"); }
                if (SettingsModel.Settings.Colour16_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "724F2F"); }
                if (SettingsModel.Settings.Colour17_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "7E715C"); }
                if (SettingsModel.Settings.Colour18_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "547A72"); }
                if (SettingsModel.Settings.Colour19_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "677488"); }
                if (SettingsModel.Settings.Colour20_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "737373"); }
                if (SettingsModel.Settings.Colour21_XBOXSERIESish == true) { ConstantsEdit.ColourPicker(ConstantsLocation_XBOXSERIESish, "4C4A4B"); }

                //DynamicBackground
                ConstantsEdit.TrueFalse(ConstantsLocation_XBOXSERIESish, "DynamicBackground", SettingsModel.Settings.DynamicBackground_XBOXSERIESish);
                ConstantsEdit.TrueFalse(ConstantsLocation_XBOXSERIESish, "DynamicBackground_Columns", SettingsModel.Settings.DynamicBackgroundColumns_XBOXSERIESish);
                ConstantsEdit.TrueFalse(ConstantsLocation_XBOXSERIESish, "DynamicBackground_Wave", SettingsModel.Settings.DynamicBackgroundWave_XBOXSERIESish);

                //ThemeIntro
                ConstantsEdit.TrueFalse(ConstantsLocation_XBOXSERIESish, "Intro", SettingsModel.Settings.ThemeIntro_XBOXSERIESish);
                if (SettingsModel.Settings.ThemeIntro_XBOXSERIESish == true)
                {
                    string sIntroLength = SettingsModel.Settings.IntroLength_XBOXSERIESish.ToString();
                    ConstantsEdit.IntroLength(ConstantsLocation_XBOXSERIESish, sIntroLength);
                }

                //ThemeIntroVideo
                ConstantsEdit.TrueFalse(ConstantsLocation_XBOXSERIESish, "IntroVideo", SettingsModel.Settings.IntroVideo_XBOXSERIESish);
                //TheneIntroVideoVolume
                ConstantsEdit.IntroVideoVolume(ConstantsLocation_XBOXSERIESish, "IntroVideoVolume", SettingsModel.Settings.IntroVideoVolume_XBOXSERIESish);

                //Trailers
                ConstantsEdit.TrueFalse(ConstantsLocation_XBOXSERIESish, "Trailers", SettingsModel.Settings.Trailers_XBOXSERIESish);

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Changing Labels
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Labels
                string ReadProgressLabel = System.IO.File.ReadAllText(ConstantsLocation_XBOXSERIESish);
                int ProgressLabelstart = ReadProgressLabel.IndexOf("<!--PL--><Setter Property=\"Text\" Value=\"");
                int ProgressLabelend = ReadProgressLabel.IndexOf("\" /><!--PL-->");
                string ProgressLabeltextBefore = ReadProgressLabel.Substring(0, ProgressLabelstart);
                string ProgressLabeltextAfter = ReadProgressLabel.Substring(ProgressLabelend + 1);
                string ReadProgressLabelReplaced = ProgressLabeltextBefore + "<!--PL--><Setter Property=\"Text\" Value=\"" + SettingsModel.Settings.ProgressLabel_XBOXSERIESish + "\"" + ProgressLabeltextAfter;
                System.IO.File.WriteAllText(ConstantsLocation_XBOXSERIESish, ReadProgressLabelReplaced);

                string ReadEarnedLabel = System.IO.File.ReadAllText(ConstantsLocation_XBOXSERIESish);
                int EarnedLabelstart = ReadEarnedLabel.IndexOf("<!--EL--><Setter Property=\"Text\" Value=\"");
                int EarnedLabelend = ReadEarnedLabel.IndexOf("\" /><!--EL-->");
                string EarnedLabeltextBefore = ReadEarnedLabel.Substring(0, EarnedLabelstart);
                string EarnedLabeltextAfter = ReadEarnedLabel.Substring(EarnedLabelend + 1);
                string ReadEarnedLabelReplaced = EarnedLabeltextBefore + "<!--EL--><Setter Property=\"Text\" Value=\"" + SettingsModel.Settings.EarnedLabel_XBOXSERIESish + "\"" + EarnedLabeltextAfter;
                System.IO.File.WriteAllText(ConstantsLocation_XBOXSERIESish, ReadEarnedLabelReplaced);
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }

            PlayniteApi.Dialogs.ShowMessage("Changes Applied");
        }

        //APPLY DEFAULTS
        private void XBOXSERIESish_Defaults(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync(new Uri("https://github.com/davidkgriggs/XBOXSERIESish/raw/main/source/Constants.xaml"), PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\XBOXSERIESish_74735df9-3351-4669-a1ff-50f18f39b63b\Constants.xaml");

                PlayniteApi.Dialogs.ShowMessage("Defaults Applied");
            }
        }
    }
}