﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;

namespace SymbolsAndLabels
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            if (true)
                RenderOptions.ProcessRenderMode = RenderMode.SoftwareOnly;

            var x = RenderCapability.Tier;
        }
    }
}
