﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FatherDriver.WPF.UI.Views;

namespace FatherDriver.WPF.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new MainWindow().Show(); 
            base.OnStartup(e);
        }
    }
}
