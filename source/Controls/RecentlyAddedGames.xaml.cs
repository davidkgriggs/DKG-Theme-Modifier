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
using DKGThemeModifier.Models;
using System.Collections.ObjectModel;

namespace DKGThemeModifier
{
    /// <summary>
    /// Interaction logic for StoreButton.xaml
    /// </summary>
    /// 
    public partial class RecentlyAddedGamesControl : PluginUserControl
    {
        IPlayniteAPI PlayniteApi; public DKGThemeModifierSettingsViewModel SettingsModel { get; set; }

        public RecentlyAddedGamesControl(IPlayniteAPI PlayniteApi, DKGThemeModifierSettingsViewModel settings)
        {
            InitializeComponent();
            this.PlayniteApi = PlayniteApi;
            SettingsModel = settings;
        }
    }
}
