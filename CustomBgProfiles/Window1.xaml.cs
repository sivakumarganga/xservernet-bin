﻿using Ptv.XServer.Controls.Map;
using Ptv.XServer.Controls.Map.Layers.Tiled;
using Ptv.XServer.Controls.Map.Layers.Untiled;
using Ptv.XServer.Controls.Map.TileProviders;
using System.Windows;
using System.Windows.Controls;

namespace CustomBgProfiles
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            SetProfile(Map1, "sandbox");
            SetProfile(Map2, "silkysand");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            switch ((sender as RadioButton).Content.ToString())
            {
                case "Standard":
                    SetProfile(Map0, null);
                    break;
                case "Greenzones":
                    SetProfile(Map0, "sandbox");
                    break;
                default:
                    SetProfile(Map0, "silkysand");
                    break;
            }
        }

        private void SetProfile(Map map, string mapProfile)
        {
            if (map.Layers["Background"] != null)
            {
                ((map.Layers["Background"] as TiledLayer).TiledProvider as XMapTiledProvider).CustomProfile =
                    string.IsNullOrEmpty(mapProfile) ? null : mapProfile + "-bg";
                (map.Layers["Background"] as TiledLayer).Refresh();
            }
            if (map.Layers["Labels"] != null)
            {
                ((map.Layers["Labels"] as UntiledLayer).UntiledProvider as XMapTiledProvider).CustomProfile =
                    string.IsNullOrEmpty(mapProfile) ? null : mapProfile + "-fg";
                (map.Layers["Labels"] as UntiledLayer).Refresh();
            }
        }
    }
}
