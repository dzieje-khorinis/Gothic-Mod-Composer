﻿using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;
using GothicModComposer.UI.Models;
using GothicModComposer.UI.ViewModels;
using Microsoft.Win32;

namespace GothicModComposer.UI.Views
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GmcSettings
    {
        private const string WindowsStartupRegistryPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        public GmcSettings(GmcSettingsVM gmcSettingsVM)
        {
            InitializeComponent();

            DataContext = gmcSettingsVM;

            var collectionView = new ListCollectionView(gmcSettingsVM.GmcConfiguration.IniOverrides);
            collectionView.GroupDescriptions.Add(new PropertyGroupDescription(nameof(IniOverride.Section)));
            gmcSettingsVM.IsLogDirectoryAvailable = Directory.Exists(gmcSettingsVM.LogsDirectoryPath) &&
                                                    new DirectoryInfo(gmcSettingsVM.LogsDirectoryPath).GetFiles().Any();
            OverridesIniTable.ItemsSource = collectionView;
            
            modBuildBtn.IsEnabled =
                Directory.Exists(Path.Combine(gmcSettingsVM.GmcConfiguration?.Gothic2RootPath ?? string.Empty, ".gmc",
                    "build"));
        }

        private void WindowsStartup_Checked(object sender, RoutedEventArgs e)
        {
            var exePath = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("dll", "exe");

            try
            {
                var registryKey = Registry.CurrentUser.OpenSubKey(WindowsStartupRegistryPath, true);
                registryKey?.SetValue("GMC_2_UI", exePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Error during adding application to Windows startup.");
            }
        }

        private void WindowsStartup_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                var registryKey = Registry.CurrentUser.OpenSubKey(WindowsStartupRegistryPath, true);
                registryKey?.DeleteValue("GMC_2_UI", false);
            }
            catch (Exception)
            {
                MessageBox.Show("Error during removing application from Windows startup");
            }
        }

        private void TimedVisibility(BaloonPopup control,string text)
        {
            Clipboard.SetText(gothicRoot.Text);
            control.Visibility = Visibility.Visible;
            DispatcherTimer time = new DispatcherTimer();
            time.Interval = TimeSpan.FromSeconds(1);
            time.Start();
            time.Tick += delegate
            {
                control.Visibility = Visibility.Hidden;
                time.Stop();
            };
        }
        private void Popupex_Opened(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TimedVisibility(Pop, gothicRoot.Text);
        }

        private void Popupex2_Opened(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TimedVisibility(Pop2, gothicModRoot.Text);
        }
    }
}