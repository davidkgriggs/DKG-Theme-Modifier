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
                string ConstantsLocation_PlayniteModernUI = SettingsModel.Settings.ConstantsLocation_PlayniteModernUI;
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ReadConstatnts_PlayniteModernUI = File.ReadAllText(ConstantsLocation_PlayniteModernUI);

                //COLOUR PICKER


                if (SettingsModel.Settings.Colour1_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "54A81B", "488E19", "54A81B", "6CD327", "305D12"); }
                if (SettingsModel.Settings.Colour2_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "107C10", "0C5F0C", "107C10", "199819", "083808"); }
                if (SettingsModel.Settings.Colour3_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "108272", "0C6357", "108272", "17B29C", "084139"); }
                if (SettingsModel.Settings.Colour4_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "148282", "0F5F5F", "148282", "1FAEAE", "0A3E3E"); }
                if (SettingsModel.Settings.Colour5_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "1081CA", "0C6198", "1081CA", "139BF1", "083F62"); }
                if (SettingsModel.Settings.Colour6_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "1073D6", "0C5CAD", "1073D6", "3695F5", "083D72"); }
                if (SettingsModel.Settings.Colour7_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "193E91", "163479", "193E91", "4479EF", "102554"); }
                if (SettingsModel.Settings.Colour8_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "744DA9", "5A3B83", "744DA9", "9E6FDF", "372550"); }
                if (SettingsModel.Settings.Colour9_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "B144C0", "943AA0", "B144C0", "DD71EC", "6B2B74"); }
                if (SettingsModel.Settings.Colour10_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "ED5588", "C64772", "ED5588", "F2749E", "8D3351"); }
                if (SettingsModel.Settings.Colour11_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "BF1077", "980E5F", "BF1077", "EA49A7", "630A3E"); }
                if (SettingsModel.Settings.Colour12_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "A21025", "7E0E1E", "A21025", "CC394E", "620D19"); }
                if (SettingsModel.Settings.Colour13_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "E31123", "BD0F1E", "E31123", "D73644", "7C0A14"); }
                if (SettingsModel.Settings.Colour14_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "EB4910", "C33E10", "EB4910", "F3774C", "8D2E0D"); }
                if (SettingsModel.Settings.Colour15_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "EB8C10", "C4750F", "EB8C10", "DE9940", "94590D"); }
                if (SettingsModel.Settings.Colour16_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "724F2F", "523A23", "724F2F", "997756", "362718"); }
                if (SettingsModel.Settings.Colour17_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "7E715C", "5E5545", "7E715C", "9D8E76", "3F392F"); }
                if (SettingsModel.Settings.Colour18_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "547A72", "415D57", "547A72", "719C93", "2C3E3A"); }
                if (SettingsModel.Settings.Colour19_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "677488", "4D5664", "677488", "8896AD", "353B44"); }
                if (SettingsModel.Settings.Colour20_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "737373", "525151", "737373", "898989", "333333"); }
                if (SettingsModel.Settings.Colour21_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "4C4A4B", "3F3E3F", "4C4A4B", "6C6B6C", "2A292A"); }
                if (SettingsModel.Settings.Colour22_PlayniteModernUI == true) { ConstantsEdit.PlayniteModernUIColours(ConstantsLocation_PlayniteModernUI, "00BAAF", "2795AE", "00BAAF", "83F9F2", "298984"); }

                /*if (SettingsModel.Settings.Colour1_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "54A81B"); }
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
                if (SettingsModel.Settings.Colour22_PlayniteModernUI == true) { ConstantsEdit.ColourPicker(ConstantsLocation_PlayniteModernUI, "00BAAF"); }*/

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

                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "BackgroundStretchNew", SettingsModel.Settings.BackgroundStretchNew_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "BackgroundBlur", SettingsModel.Settings.BackgroundBlur_PlayniteModernUI);

                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Platform", SettingsModel.Settings.GameDetails_Platform_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Genres", SettingsModel.Settings.GameDetails_Genres_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Developers", SettingsModel.Settings.GameDetails_Developers_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Publishers", SettingsModel.Settings.GameDetails_Publishers_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Categories", SettingsModel.Settings.GameDetails_Categories_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Features", SettingsModel.Settings.GameDetails_Features_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Tags", SettingsModel.Settings.GameDetails_Tags_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Series", SettingsModel.Settings.GameDetails_Series_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_AgeRatings", SettingsModel.Settings.GameDetails_AgeRatings_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Regions", SettingsModel.Settings.GameDetails_Regions_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Source", SettingsModel.Settings.GameDetails_Source_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Version", SettingsModel.Settings.GameDetails_Version_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_UserScore", SettingsModel.Settings.GameDetails_UserScore_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_CommunityScore", SettingsModel.Settings.GameDetails_CommunityScore_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_PlayCount", SettingsModel.Settings.GameDetails_PlayCount_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Added", SettingsModel.Settings.GameDetails_Added_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Modified", SettingsModel.Settings.GameDetails_Modified_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Notes", SettingsModel.Settings.GameDetails_Notes_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_GameID", SettingsModel.Settings.GameDetails_GameID_PlayniteModernUI);
                ConstantsEdit.TrueFalse(ConstantsLocation_PlayniteModernUI, "GameDetails_Favourite", SettingsModel.Settings.GameDetails_Favourite_PlayniteModernUI);
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

            ConstantsEdit.RestoreDefaults(PlayniteApi.Paths.ConfigurationPath + @"\ExtensionsData\ee4ed2de-7e02-4447-8441-685d320b0520\config.json", "\"IsThemeInstalledHeader_PlayniteModernUI\": \"PlayniteModernUI\",", "\"IsThemeInstalled_PS5ish\"");
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

            ConstantsEdit.RestoreDefaults(PlayniteApi.Paths.ConfigurationPath + @"\ExtensionsData\ee4ed2de-7e02-4447-8441-685d320b0520\config.json", "\"IsThemeInstalledHeader_PS5ish\": \"PS5ish\",", "\"IsThemeInstalled_XBOXSERIESish\"");
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

            ConstantsEdit.RestoreDefaults(PlayniteApi.Paths.ConfigurationPath + @"\ExtensionsData\ee4ed2de-7e02-4447-8441-685d320b0520\config.json", "\"IsThemeInstalledHeader_PlayniteDeck\": \"Playnite Deck\",", "\"IsThemeInstalled_Platforms\"");
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

            ConstantsEdit.RestoreDefaults(PlayniteApi.Paths.ConfigurationPath + @"\ExtensionsData\ee4ed2de-7e02-4447-8441-685d320b0520\config.json", "\"IsThemeInstalledHeader_Platforms\": \"Platforms\",", "\"IsThemeInstalled_SWITCH\"");
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

            ConstantsEdit.RestoreDefaults(PlayniteApi.Paths.ConfigurationPath + @"\ExtensionsData\ee4ed2de-7e02-4447-8441-685d320b0520\config.json", "\"IsThemeInstalledHeader_XBOXSERIESish\": \"XBOXSERIESish\",", "\"IsThemeInstalled_PlayniteDeck\"");
        }

        private void NintendoSwitchish_Commit(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Nintendo Switch-ish
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
            if (SettingsModel.Settings.IsThemeInstalled_SWITCH == true)
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Set Constants Location
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ConstantsLocation_SWITCH = PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\Nintendo Switch-ish_0d020ed5-0f3c-4c1a-bf9a-c983ef7d74b7\Constants.xaml";
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ReadConstatnts_PlayniteModernUI = File.ReadAllText(ConstantsLocation_SWITCH);

                ConstantsEdit.TrueFalse(ConstantsLocation_SWITCH, "Intro", SettingsModel.Settings.ThemeIntro_SWITCH);

                ConstantsEdit.TrueFalse(ConstantsLocation_SWITCH, "Trailers", SettingsModel.Settings.Trailers_SWITCH);
            }

            PlayniteApi.Dialogs.ShowMessage("Changes Applied");
        }

        //APPLY DEFAULTS
        private void NintendoSwitchish_Defaults(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync(new Uri("https://github.com/davidkgriggs/Nintendo-Switch-ish/raw/main/source/Constants.xaml"), PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\Nintendo Switch-ish_0d020ed5-0f3c-4c1a-bf9a-c983ef7d74b7\Constants.xaml");

                PlayniteApi.Dialogs.ShowMessage("Defaults Applied");
            }

            ConstantsEdit.RestoreDefaults(PlayniteApi.Paths.ConfigurationPath + @"\ExtensionsData\ee4ed2de-7e02-4447-8441-685d320b0520\config.json", "\"IsThemeInstalledHeader_SWITCH\": \"Nintendo Switch-ish\",", "\"IsThemeInstalled_EleganceFS\"");
        }

        //DOWNLOAD ICONS FROM GITHUB
        private void NintendoSwitchish_DownloadIcons(object sender, EventArgs e)
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
                    ZipArchive zipArchive = OpenRead(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\Icons\Icons.zip");
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

        private void EleganceFS_Commit(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Elegance Fullscreen
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
            if (SettingsModel.Settings.IsThemeInstalled_EleganceFS == true)
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Set Constants Location
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ConstantsLocation_EleganceFS = PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\Elegance_9ca210b3-db1c-4fdc-a555-96474a4fba49\Constants.xaml";
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ReadConstatnts_PlayniteModernUI = File.ReadAllText(ConstantsLocation_EleganceFS);

                //COLOUR PICKER
                if (SettingsModel.Settings.Colour1_EleganceFS == true) { ConstantsEdit.EleganceColours(ConstantsLocation_EleganceFS, "34ACBC", "065464", "34ACBC", "85C3CF", "11373C"); }
                if (SettingsModel.Settings.Colour2_EleganceFS == true) { ConstantsEdit.EleganceColours(ConstantsLocation_EleganceFS, "FF0000", "A40000", "FF0000", "EA6363", "4A1515"); }
                if (SettingsModel.Settings.Colour3_EleganceFS == true) { ConstantsEdit.EleganceColours(ConstantsLocation_EleganceFS, "FFA500", "D18700", "FFA500", "CFAF85", "927030"); }
                if (SettingsModel.Settings.Colour4_EleganceFS == true) { ConstantsEdit.EleganceColours(ConstantsLocation_EleganceFS, "ECE201", "DED639", "ECE201", "FFF97C", "949035"); }
                if (SettingsModel.Settings.Colour5_EleganceFS == true) { ConstantsEdit.EleganceColours(ConstantsLocation_EleganceFS, "83E200", "60A400", "83E200", "AFFF3F", "598120"); }
                if (SettingsModel.Settings.Colour6_EleganceFS == true) { ConstantsEdit.EleganceColours(ConstantsLocation_EleganceFS, "0E7A0D", "0A5409", "0E7A0D", "68E468", "0F420F"); }
                if (SettingsModel.Settings.Colour7_EleganceFS == true) { ConstantsEdit.EleganceColours(ConstantsLocation_EleganceFS, "7AD7F0", "457E8D", "7AD7F0", "ACECFC", "164A58"); }
                if (SettingsModel.Settings.Colour8_EleganceFS == true) { ConstantsEdit.EleganceColours(ConstantsLocation_EleganceFS, "006FCD", "004C8D", "006FCD", "67B9FF", "012F57"); }
                if (SettingsModel.Settings.Colour9_EleganceFS == true) { ConstantsEdit.EleganceColours(ConstantsLocation_EleganceFS, "00BAAF", "2795AE", "00BAAF", "83F9F2", "0B514D"); }
                if (SettingsModel.Settings.Colour10_EleganceFS == true) { ConstantsEdit.EleganceColours(ConstantsLocation_EleganceFS, "9D16FF", "540091", "9D16FF", "BD61FF", "411263"); }
                if (SettingsModel.Settings.Colour11_EleganceFS == true) { ConstantsEdit.EleganceColours(ConstantsLocation_EleganceFS, "C600AC", "982BAD", "C600AC", "ED8FFF", "601256"); }

                ConstantsEdit.TrueFalse(ConstantsLocation_EleganceFS, "Trailers", SettingsModel.Settings.Trailers_EleganceFS);
            }

            PlayniteApi.Dialogs.ShowMessage("Changes Applied");
        }

        //APPLY DEFAULTS
        private void EleganceFS_Defaults(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync(new Uri("https://github.com/davidkgriggs/Elegance_Fullscreen/raw/main/source/Constants.xaml"), PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\Elegance_9ca210b3-db1c-4fdc-a555-96474a4fba49\Constants.xaml");

                PlayniteApi.Dialogs.ShowMessage("Defaults Applied");
            }

            ConstantsEdit.RestoreDefaults(PlayniteApi.Paths.ConfigurationPath + @"\ExtensionsData\ee4ed2de-7e02-4447-8441-685d320b0520\config.json", "\"IsThemeInstalledHeader_EleganceFS\": \"Elegance\",", "\"IsThemeInstalled_EleganceDT\"");
        }

        //DOWNLOAD ICONS FROM GITHUB
        private void EleganceFS_DownloadIcons(object sender, EventArgs e)
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
                    ZipArchive zipArchive = OpenRead(PlayniteApi.Paths.ConfigurationPath + @"\DKGThemeModifier\FilterPresets\Icons\Icons.zip");
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

        private void EleganceDT_Commit(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Elegance Fullscreen
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
            if (SettingsModel.Settings.IsThemeInstalled_EleganceDT == true)
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Set Constants Location
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ConstantsLocation_EleganceDT = PlayniteApi.Paths.ConfigurationPath + @"\Themes\Desktop\Elegance_37b0c944-eb21-462f-8df7-0b3acd6d1e68\Constants.xaml";
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string ReadConstatnts_PlayniteModernUI = File.ReadAllText(ConstantsLocation_EleganceDT);

                //COLOUR PICKER
                if (SettingsModel.Settings.Colour1_EleganceDT == true) { ConstantsEdit.EleganceDTColours(ConstantsLocation_EleganceDT, "34ACBC", "065464", "28818D", "34ACBC", "34ACBC", "8834ACBC", "28818D", "065464"); }
                if (SettingsModel.Settings.Colour2_EleganceDT == true) { ConstantsEdit.EleganceDTColours(ConstantsLocation_EleganceDT, "FF0000", "A40000", "AA2F2F", "FF0000", "FF0000", "88FF0000", "AA2F2F", "A40000"); }
                if (SettingsModel.Settings.Colour3_EleganceDT == true) { ConstantsEdit.EleganceDTColours(ConstantsLocation_EleganceDT, "FFA500", "D18700", "CE9630", "FFA500", "FFA500", "88FFA500", "CE9630", "D18700"); }
                if (SettingsModel.Settings.Colour4_EleganceDT == true) { ConstantsEdit.EleganceDTColours(ConstantsLocation_EleganceDT, "ECE201", "DED639", "C1BA28", "ECE201", "ECE201", "88ECE201", "C1BA28", "DED639"); }
                if (SettingsModel.Settings.Colour5_EleganceDT == true) { ConstantsEdit.EleganceDTColours(ConstantsLocation_EleganceDT, "83E200", "60A400", "7DBC27", "83E200", "83E200", "8883E200", "7DBC27", "60A400"); }
                if (SettingsModel.Settings.Colour6_EleganceDT == true) { ConstantsEdit.EleganceDTColours(ConstantsLocation_EleganceDT, "0E7A0D", "0A5409", "2B5A2B", "0E7A0D", "0E7A0D", "880E7A0D", "2B5A2B", "0A5409"); }
                if (SettingsModel.Settings.Colour7_EleganceDT == true) { ConstantsEdit.EleganceDTColours(ConstantsLocation_EleganceDT, "7AD7F0", "457E8D", "327A8D", "7AD7F0", "7AD7F0", "887AD7F0", "327A8D", "327A8D"); }
                if (SettingsModel.Settings.Colour8_EleganceDT == true) { ConstantsEdit.EleganceDTColours(ConstantsLocation_EleganceDT, "006FCD", "004C8D", "295E8B", "006FCD", "006FCD", "88006FCD", "295E8B", "004C8D"); }
                if (SettingsModel.Settings.Colour9_EleganceDT == true) { ConstantsEdit.EleganceDTColours(ConstantsLocation_EleganceDT, "00BAAF", "2795AE", "298984", "00BAAF", "00BAAF", "8800BAAF", "298984", "2795AE"); }
                if (SettingsModel.Settings.Colour10_EleganceDT == true) { ConstantsEdit.EleganceDTColours(ConstantsLocation_EleganceDT, "9D16FF", "540091", "67328E", "9D16FF", "9D16FF", "889D16FF", "67328E", "540091"); }
                if (SettingsModel.Settings.Colour11_EleganceDT == true) { ConstantsEdit.EleganceDTColours(ConstantsLocation_EleganceDT, "C600AC", "982BAD", "8B247D", "C600AC", "C600AC", "88C600AC", "8B247D", "982BAD"); }

                //ConstantsEdit.TrueFalse(ConstantsLocation_EleganceDT, "Trailers", SettingsModel.Settings.Trailers_EleganceDT);
            }

            PlayniteApi.Dialogs.ShowMessage("Changes Applied");
        }

        //APPLY DEFAULTS
        private void EleganceDT_Defaults(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync(new Uri("https://github.com/davidkgriggs/Elegance_Desktop/raw/main/source/Constants.xaml"), PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\Elegance_37b0c944-eb21-462f-8df7-0b3acd6d1e68\Constants.xaml");

                PlayniteApi.Dialogs.ShowMessage("Defaults Applied");
            }

            ConstantsEdit.RestoreDefaults(PlayniteApi.Paths.ConfigurationPath + @"\ExtensionsData\ee4ed2de-7e02-4447-8441-685d320b0520\config.json", "\"IsThemeInstalledHeader_EleganceDT\": \"Elegance\",", "\"NumberOfGames\"");
        }

    }
}