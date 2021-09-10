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
        public bool Trailers_AudioON_PlayniteModernUI { get; set; } = true;

        //FilterPresets
        public double FilterFontSmall_PlayniteModernUI { get; set; } = 20;

        //SideBar
        public bool SideBarTransparent_PlayniteModernUI { get; set; } = true;
        public bool SideBar_PlayniteModernUI { get; set; } = true;
        public bool SideBarCenter_PlayniteModernUI { get; set; } = true;
        public bool SideBanners_PlayniteModernUI { get; set; } = false;

        //MainLogo
        public bool MainLogo_PlayniteModernUI { get; set; } = false;
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