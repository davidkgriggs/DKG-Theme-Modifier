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
            }

            PlayniteApi.Dialogs.ShowMessage("Changes Applied");
        }

        private void PlayniteModernUI_Defaults(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync(new Uri("https://github.com/davidkgriggs/PlayniteModernUI/raw/main/source/Constants.xaml"), PlayniteApi.Paths.ConfigurationPath + @"\Themes\Fullscreen\PlayniteModernUI_b600472c-c10c-4136-86d0-82bf0e576200\Constants.xaml");

                PlayniteApi.Dialogs.ShowMessage("Defaults Applied");
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

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Changing Labels
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Labels
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

    }
}