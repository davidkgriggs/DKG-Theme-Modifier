using Playnite.SDK;
using Playnite.SDK.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKGThemeModifier
{
    public class DKGThemeModifierSettings
    {
        public string DKGThemeModifierCurrentVersion { get; set; } = "";

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //PlayniteModernUI
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool IsThemeInstalled_PlayniteModernUI { get; set; } = false;
        public string IsThemeInstalledHeader_PlayniteModernUI { get; set; } = "";
        public string ConstantsLocation_PlayniteModernUI { get; set; } = "";

        //ProfileName
        public string ProfileName_PlayniteModernUI { get; set; } = "PlayniteModernUI";

        //DarkLightMode
        public bool DarkMode_PlayniteModernUI { get; set; } = true;
        public bool LightMode_PlayniteModernUI { get; set; } = false;

        //ColourPicker
        public bool Colour1_PlayniteModernUI { get; set; } = false;
        public bool Colour2_PlayniteModernUI { get; set; } = false;
        public bool Colour3_PlayniteModernUI { get; set; } = false;
        public bool Colour4_PlayniteModernUI { get; set; } = false;
        public bool Colour5_PlayniteModernUI { get; set; } = false;
        public bool Colour6_PlayniteModernUI { get; set; } = false;
        public bool Colour7_PlayniteModernUI { get; set; } = false;
        public bool Colour8_PlayniteModernUI { get; set; } = false;
        public bool Colour9_PlayniteModernUI { get; set; } = false;
        public bool Colour10_PlayniteModernUI { get; set; } = false;
        public bool Colour11_PlayniteModernUI { get; set; } = false;
        public bool Colour12_PlayniteModernUI { get; set; } = false;
        public bool Colour13_PlayniteModernUI { get; set; } = false;
        public bool Colour14_PlayniteModernUI { get; set; } = false;
        public bool Colour15_PlayniteModernUI { get; set; } = false;
        public bool Colour16_PlayniteModernUI { get; set; } = false;
        public bool Colour17_PlayniteModernUI { get; set; } = false;
        public bool Colour18_PlayniteModernUI { get; set; } = false;
        public bool Colour19_PlayniteModernUI { get; set; } = false;
        public bool Colour20_PlayniteModernUI { get; set; } = false;
        public bool Colour21_PlayniteModernUI { get; set; } = false;
        public bool Colour22_PlayniteModernUI { get; set; } = true;

        //DynamicBackground
        public bool DynamicBackground_PlayniteModernUI { get; set; } = true;

        //TurnOnAndOff
        public bool BottomText_PlayniteModernUI { get; set; } = true;
        public bool RightInfo_PlayniteModernUI { get; set; } = true;

        //ThemeIntro
        public bool ThemeIntro_PlayniteModernUI { get; set; } = false;
        public int IntroLength_PlayniteModernUI { get; set; } = 3;
        public bool IntroVideo_PlayniteModernUI { get; set; } = false;
        public bool IntroVideoVolume_PlayniteModernUI { get; set; } = true;

        //Banners
        public bool Banners_PlayniteModernUI { get; set; } = false;

        //RoundedCorners
        public bool RoundedCorners_PlayniteModernUI { get; set; } = false;
        public int RoundedCornersAmount_PlayniteModernUI { get; set; } = 15;

        //GlassEffect
        public bool GlassEffect_PlayniteModernUI { get; set; } = false;

        //VideoCovers
        public bool VideoCovers_PlayniteModernUI { get; set; } = false;

        //VideoBackgrounds
        public bool VideoBackgrounds_PlayniteModernUI { get; set; } = false;

        //Trailers
        public bool Trailers_PlayniteModernUI { get; set; } = true;

        //FilterPresets
        public double FilterFontSmall_PlayniteModernUI { get; set; } = 20;

        //SideBar
        public bool SideBarTransparent_PlayniteModernUI { get; set; } = true;
        public bool SideBar_PlayniteModernUI { get; set; } = true;
        public bool SideBarCenter_PlayniteModernUI { get; set; } = true;
        public bool SideBanners_PlayniteModernUI { get; set; } = false;

        //MainLogo
        public bool MainLogo_PlayniteModernUI { get; set; } = false;

        //DescriptionOnOff
        public bool DescriptionOnOff_PlayniteModernUI { get; set; } = true;

        //FilterPresetsVertical
        public bool FilterPresetsVertical_PlayniteModernUI { get; set; } = true;

        //DropShadows
        public bool DropShadows_PlayniteModernUI { get; set; } = false;

        public int ListGamesHeight_PlayniteModernUI { get; set; } = 630;

        public bool BackgroundStretchNew_PlayniteModernUI { get; set; } = true;
        public bool BackgroundBlur_PlayniteModernUI { get; set; } = false;

        public bool GameDetails_Platform_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Genres_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Developers_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Publishers_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Categories_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Features_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Tags_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Series_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_AgeRatings_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Regions_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Source_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Version_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_UserScore_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_CommunityScore_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_PlayCount_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Added_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Modified_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Notes_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_GameID_PlayniteModernUI { get; set; } = true;
        public bool GameDetails_Favourite_PlayniteModernUI { get; set; } = true;
        //###############################################################################################################
        //###############################################################################################################

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //PS5ish
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool IsThemeInstalled_PS5ish { get; set; } = false;
        public string IsThemeInstalledHeader_PS5ish { get; set; } = "";

        //SingleRowMode
        public bool SingleRowMode_PS5ish { get; set; } = false;

        //TurnOnAndOff
        public bool LeftLogo_PS5ish { get; set; } = true;
        public bool RightInfo_PS5ish { get; set; } = true;
        public bool StoreLogo_PS5ish { get; set; } = true;
        public bool DisableGameBackgroundOnGrid_PS5ish { get; set; } = true;
        public bool GridBackground_PS5ish { get; set; } = true;


        //StoreButton
        public bool StoreButton_PS5ish { get; set; } = true;
        public string PS5ish_StoreWebsite { get; set; } = "https://store.playstation.com/en-gb/";

        //ThemeIntro
        public bool ThemeIntro_PS5ish { get; set; } = false;
        public int IntroLength_PS5ish { get; set; } = 1;
        public bool IntroVideo_PS5ish { get; set; } = false;
        public bool IntroVideoVolume_PS5ish { get; set; } = true;

        //Labels
        public bool LabelDefaults_PS5ish { get; set; } = true;
        public string PlayLabel_PS5ish { get; set; } = "{DynamicResource LOCPlayGame}";
        public string PlayGameLabel_PS5ish { get; set; } = "Game";
        public string GameLabel_PS5ish { get; set; } = "Games";
        public string MediaLabel_PS5ish { get; set; } = "{DynamicResource LOCMediaLabel}";
        public string ProgressLabel_PS5ish { get; set; } = "{DynamicResource LOCSuccessStoryProgress}";
        public string EarnedLabel_PS5ish { get; set; } = "{DynamicResource LOCSuccessStoryEarned}";

        //Scale
        public bool ScaleSmall_PS5ish { get; set; } = true;
        public bool ScaleMedium_PS5ish { get; set; } = false;
        public bool ScaleLarge_PS5ish { get; set; } = false;

        //Trailers
        public bool Trailers_PS5ish { get; set; } = true;

        //MicroVideoBackgrounds
        public bool MicroVideoBackgrounds_PS5ish { get; set; } = false;

        //FullVideoBackgrounds
        public bool FullVideoBackgrounds_PS5ish { get; set; } = false;

        //###############################################################################################################
        //###############################################################################################################

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //XBOXSERIESish
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool IsThemeInstalled_XBOXSERIESish { get; set; } = false;
        public string IsThemeInstalledHeader_XBOXSERIESish { get; set; } = "";

        //ProfileName
        public string ProfileName_XBOXSERIESish { get; set; } = "XBOXSERIESish";

        //DarkLightMode
        public bool DarkMode_XBOXSERIESish { get; set; } = true;
        public bool LightMode_XBOXSERIESish { get; set; } = false;

        //ColourPicker
        public bool Colour1_XBOXSERIESish { get; set; } = true;
        public bool Colour2_XBOXSERIESish { get; set; } = false;
        public bool Colour3_XBOXSERIESish { get; set; } = false;
        public bool Colour4_XBOXSERIESish { get; set; } = false;
        public bool Colour5_XBOXSERIESish { get; set; } = false;
        public bool Colour6_XBOXSERIESish { get; set; } = false;
        public bool Colour7_XBOXSERIESish { get; set; } = false;
        public bool Colour8_XBOXSERIESish { get; set; } = false;
        public bool Colour9_XBOXSERIESish { get; set; } = false;
        public bool Colour10_XBOXSERIESish { get; set; } = false;
        public bool Colour11_XBOXSERIESish { get; set; } = false;
        public bool Colour12_XBOXSERIESish { get; set; } = false;
        public bool Colour13_XBOXSERIESish { get; set; } = false;
        public bool Colour14_XBOXSERIESish { get; set; } = false;
        public bool Colour15_XBOXSERIESish { get; set; } = false;
        public bool Colour16_XBOXSERIESish { get; set; } = false;
        public bool Colour17_XBOXSERIESish { get; set; } = false;
        public bool Colour18_XBOXSERIESish { get; set; } = false;
        public bool Colour19_XBOXSERIESish { get; set; } = false;
        public bool Colour20_XBOXSERIESish { get; set; } = false;
        public bool Colour21_XBOXSERIESish { get; set; } = false;

        //DynamicBackground
        public bool DynamicBackground_XBOXSERIESish { get; set; } = false;
        public bool DynamicBackgroundColumns_XBOXSERIESish { get; set; } = true;
        public bool DynamicBackgroundWave_XBOXSERIESish { get; set; } = false;

        //ThemeIntro
        public bool ThemeIntro_XBOXSERIESish { get; set; } = false;
        public int IntroLength_XBOXSERIESish { get; set; } = 3;
        public bool IntroVideo_XBOXSERIESish { get; set; } = false;
        public bool IntroVideoVolume_XBOXSERIESish { get; set; } = true;

        //Banners
        public bool Banners_XBOXSERIESish { get; set; } = false;

        //VideoCovers
        public bool VideoCovers_XBOXSERIESish { get; set; } = false;

        //VideoBackgrounds
        public bool VideoBackgrounds_XBOXSERIESish { get; set; } = false;

        //Trailers
        public bool Trailers_XBOXSERIESish { get; set; } = true;

        //Labels
        public string ProgressLabel_XBOXSERIESish { get; set; } = "{DynamicResource LOCSuccessStoryProgress}";
        public string EarnedLabel_XBOXSERIESish { get; set; } = "{DynamicResource LOCSuccessStoryEarned}";
        //###############################################################################################################
        //###############################################################################################################

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //PlayniteDeck
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool IsThemeInstalled_PlayniteDeck { get; set; } = false;
        public string IsThemeInstalledHeader_PlayniteDeck { get; set; } = "";

        //Trailers
        public bool Trailers_PlayniteDeck { get; set; } = true;

        //SteamBackgrounds
        public bool SteamBackgrounds_PlayniteDeck { get; set; } = true;

        //NewToLibrary
        public bool NewToLibraryBool_PlayniteDeck { get; set; } = true;

        //Labels
        public string NewToLibrary_PlayniteDeck { get; set; } = "NEW TO LIBRARY";

        //###############################################################################################################
        //###############################################################################################################

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Platforms
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool IsThemeInstalled_Platforms { get; set; } = false;
        public string IsThemeInstalledHeader_Platforms { get; set; } = "";
        public bool AutoDownloadMedia_Platforms { get; set; } = false;

        //DarkLightMode
        public bool DarkMode_Platforms { get; set; } = true;
        public bool LightMode_Platforms { get; set; } = false;

        //ColourPicker
        public bool Colour1_Platforms { get; set; } = false;
        public bool Colour2_Platforms { get; set; } = false;
        public bool Colour3_Platforms { get; set; } = false;
        public bool Colour4_Platforms { get; set; } = false;
        public bool Colour5_Platforms { get; set; } = false;
        public bool Colour6_Platforms { get; set; } = false;
        public bool Colour7_Platforms { get; set; } = false;
        public bool Colour8_Platforms { get; set; } = false;
        public bool Colour9_Platforms { get; set; } = false;
        public bool Colour10_Platforms { get; set; } = false;
        public bool Colour11_Platforms { get; set; } = false;
        public bool Colour12_Platforms { get; set; } = false;
        public bool Colour13_Platforms { get; set; } = false;
        public bool Colour14_Platforms { get; set; } = false;
        public bool Colour15_Platforms { get; set; } = false;
        public bool Colour16_Platforms { get; set; } = false;
        public bool Colour17_Platforms { get; set; } = false;
        public bool Colour18_Platforms { get; set; } = false;
        public bool Colour19_Platforms { get; set; } = false;
        public bool Colour20_Platforms { get; set; } = false;
        public bool Colour21_Platforms { get; set; } = false;
        public bool Colour22_Platforms { get; set; } = true;

        //ThemeIntro
        public bool ThemeIntro_Platforms { get; set; } = false;
        public int IntroLength_Platforms { get; set; } = 3;
        public bool IntroVideo_Platforms { get; set; } = false;
        public bool IntroVideoVolume_Platforms { get; set; } = true;

        //Banners
        public bool Banners_Platforms { get; set; } = false;

        //RoundedCorners
        public bool RoundedCorners_Platforms { get; set; } = false;
        public int RoundedCornersAmount_Platforms { get; set; } = 15;

        //VideoCovers
        public bool VideoCovers_Platforms { get; set; } = true;

        //VideoBackgrounds
        public bool VideoBackgrounds_Platforms { get; set; } = false;

        //Trailers
        public bool Trailers_Platforms { get; set; } = true;

        //SideBar
        public bool SideBar_Platforms { get; set; } = true;

        public int ListGamesHeight_Platforms { get; set; } = 600;

        public bool FilterPresetWidth_Platforms { get; set; } = false;

        public bool PlatformBackgrounds_Platforms { get; set; } = false;
        //###############################################################################################################
        //###############################################################################################################

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Nintendo Switch-ish
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool IsThemeInstalled_SWITCH { get; set; } = false;
        public string IsThemeInstalledHeader_SWITCH { get; set; } = "";

        public bool ThemeIntro_SWITCH { get; set; } = false;

        public bool Trailers_SWITCH { get; set; } = true;
        //###############################################################################################################
        //###############################################################################################################

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //EleganceFS
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool IsThemeInstalled_EleganceFS { get; set; } = false;
        public string IsThemeInstalledHeader_EleganceFS { get; set; } = "";
        public bool AutoDownloadMedia_EleganceFS { get; set; } = false;

        //ColourPicker
        public bool Colour1_EleganceFS { get; set; } = true;
        public bool Colour2_EleganceFS { get; set; } = false;
        public bool Colour3_EleganceFS { get; set; } = false;
        public bool Colour4_EleganceFS { get; set; } = false;
        public bool Colour5_EleganceFS { get; set; } = false;
        public bool Colour6_EleganceFS { get; set; } = false;
        public bool Colour7_EleganceFS { get; set; } = false;
        public bool Colour8_EleganceFS { get; set; } = false;
        public bool Colour9_EleganceFS { get; set; } = false;
        public bool Colour10_EleganceFS { get; set; } = false;
        public bool Colour11_EleganceFS { get; set; } = false;

        //VideoCovers
        public bool VideoCovers_EleganceFS { get; set; } = true;

        //VideoBackgrounds
        public bool VideoBackgrounds_EleganceFS { get; set; } = false;

        //Trailers
        public bool Trailers_EleganceFS { get; set; } = true;
        //###############################################################################################################
        //###############################################################################################################

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //EleganceDT
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool IsThemeInstalled_EleganceDT { get; set; } = false;
        public string IsThemeInstalledHeader_EleganceDT { get; set; } = "";

        //ColourPicker
        public bool Colour1_EleganceDT { get; set; } = true;
        public bool Colour2_EleganceDT { get; set; } = false;
        public bool Colour3_EleganceDT { get; set; } = false;
        public bool Colour4_EleganceDT { get; set; } = false;
        public bool Colour5_EleganceDT { get; set; } = false;
        public bool Colour6_EleganceDT { get; set; } = false;
        public bool Colour7_EleganceDT { get; set; } = false;
        public bool Colour8_EleganceDT { get; set; } = false;
        public bool Colour9_EleganceDT { get; set; } = false;
        public bool Colour10_EleganceDT { get; set; } = false;
        public bool Colour11_EleganceDT { get; set; } = false;

        //VideoCovers
        public bool VideoCovers_EleganceDT { get; set; } = true;

        //VideoBackgrounds
        public bool VideoBackgrounds_EleganceDT { get; set; } = false;

        //Trailers
        public bool Trailers_EleganceDT { get; set; } = true;
        //###############################################################################################################
        //###############################################################################################################


        //FOR SHOWCASE
        private int numberOfGames = 10;
        public int NumberOfGames { get; set; } = 0;
        //###############################################################################################################
        //###############################################################################################################

        // Playnite serializes settings object to a JSON object and saves it as text file.
        // If you want to exclude some property from being saved then use `JsonDontSerialize` ignore attribute.
        [DontSerialize]
        public bool OptionThatWontBeSaved { get; set; } = false;
    }

    public class DKGThemeModifierSettingsViewModel : ObservableObject, ISettings
    {
        private readonly DKGThemeModifier plugin;
        private DKGThemeModifierSettings editingClone { get; set; }

        private DKGThemeModifierSettings settings;
        public DKGThemeModifierSettings Settings
        {
            get => settings;
            set
            {
                settings = value;
                OnPropertyChanged();
            }
        }

        public DKGThemeModifierSettingsViewModel(DKGThemeModifier plugin)
        {
            // Injecting your plugin instance is required for Save/Load method because Playnite saves data to a location based on what plugin requested the operation.
            this.plugin = plugin;

            // Load saved settings.
            var savedSettings = plugin.LoadPluginSettings<DKGThemeModifierSettings>();

            // LoadPluginSettings returns null if not saved data is available.
            if (savedSettings != null)
            {
                Settings = savedSettings;
            }
            else
            {
                Settings = new DKGThemeModifierSettings();
            }
        }

        public void BeginEdit()
        {
            // Code executed when settings view is opened and user starts editing values.
            editingClone = Serialization.GetClone(Settings);
        }

        public void CancelEdit()
        {
            // Code executed when user decides to cancel any changes made since BeginEdit was called.
            // This method should revert any changes made to Option1 and Option2.
            Settings = editingClone;
        }

        public void EndEdit()
        {
            // Code executed when user decides to confirm changes made since BeginEdit was called.
            // This method should save settings made to Option1 and Option2.
            plugin.SavePluginSettings(Settings);
        }

        public bool VerifySettings(out List<string> errors)
        {
            // Code execute when user decides to confirm changes made since BeginEdit was called.
            // Executed before EndEdit is called and EndEdit is not called if false is returned.
            // List of errors is presented to user if verification fails.
            errors = new List<string>();
            return true;
        }
    }
}