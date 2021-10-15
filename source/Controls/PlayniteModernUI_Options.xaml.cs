using Playnite.SDK;
using Playnite.SDK.Controls;
using Playnite.SDK.Models;
using System;
using System.Collections.Generic;
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
using System.Diagnostics;

namespace DKGThemeModifier
{
    /// <summary>
    /// Interaction logic for PlayniteModernUI_Options.xaml
    /// </summary>
    public partial class PlayniteModernUI_Options : PluginUserControl
    {
        IPlayniteAPI PlayniteApi; public DKGThemeModifierSettingsViewModel SettingsModel { get; set; }

        public PlayniteModernUI_Options(IPlayniteAPI PlayniteApi, DKGThemeModifierSettingsViewModel settings)
        {
            InitializeComponent();
            this.PlayniteApi = PlayniteApi;
            SettingsModel = settings;
            DataContext = this;
        }
    }
}
