﻿using ClassRecordSystem.SystemParameters.View;
using DevExpress.Xpf.WindowsUI;
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

namespace ClassRecordSystem.Shared
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
        #region Logout
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            var frame = DevExpress.Xpf.Core.Native.LayoutHelper.FindParentObject<NavigationFrame>(this);
            LoginPage page = new LoginPage();
            frame.Navigate(page);
        }
        #endregion

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsPage page = new SettingsPage();
            mainFrame.Navigate(page);
        }
    }
}
