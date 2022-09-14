using Playnite.SDK;
using Playnite.SDK.Controls;
using System.Diagnostics;
using System.Windows;

namespace DKGThemeModifier.Controls
{
    /// <summary>
    /// Interaction logic for XInputToKeyboard.xaml
    /// </summary>
    /// 

    public partial class XInputToKeyboard : PluginUserControl
    {
        IPlayniteAPI PlayniteApi; public DKGThemeModifierSettingsViewModel SettingsModel { get; set; }

        public XInputToKeyboard(IPlayniteAPI PlayniteApi, DKGThemeModifierSettingsViewModel settings)
        {
            InitializeComponent();
            this.PlayniteApi = PlayniteApi;
            SettingsModel = settings;
            DataContext = this;
        }

        private void Container_GotFocus(object sender, RoutedEventArgs e)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(PlayniteApi.Paths.ConfigurationPath + @"\Extensions\DKGThemeModifier_ee4ed2de-7e02-4447-8441-685d320b0520\Utilities\XboxControllerAsKeyboard\XboxControllerAsKeyboard_DKGThemeModifier.exe");
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
        }

        private void Container_LostFocus(object sender, RoutedEventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("XboxControllerAsKeyboard_DKGThemeModifier"))
            {
                process.Kill();
            }
        }

        private void Container_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.ActualHeight == 1)
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(PlayniteApi.Paths.ConfigurationPath + @"\Extensions\DKGThemeModifier_ee4ed2de-7e02-4447-8441-685d320b0520\Utilities\XboxControllerAsKeyboard\XboxControllerAsKeyboard_DKGThemeModifier.exe");
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.Start();
            }
            if (this.ActualHeight == 0)
            {
                foreach (var process in Process.GetProcessesByName("XboxControllerAsKeyboard_DKGThemeModifier"))
                {
                    process.Kill();
                }
            }
        }
    }
}
