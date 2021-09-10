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

namespace DKGThemeModifier
{
    public partial class DKGThemeModifierSettingsView : UserControl
    {
        public DKGThemeModifierSettingsView()
        {
            InitializeComponent();
        }

        private void OpenBackground(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string Location = button.Tag.ToString();
            string Theme = button.CommandParameter.ToString();
            Process.Start("explorer.exe", Location + Theme);
        }
        private void OpenSounds(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string Location = button.Tag.ToString();
            string Theme = button.CommandParameter.ToString();
            Process.Start("explorer.exe", Location + Theme);
        }
        void Copy(string sourceDir, string targetDir)
        {
            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), true);
            MessageBox.Show("Files copied successfully.", "Copy Files");
        }
        private void CopyFiles(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string Location = button.Tag.ToString();
            string Theme = button.CommandParameter.ToString();
            Copy(Location + Theme, Location);
        }
    }
}