﻿using System;
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
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace dnd5e_resource_browser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            string json = new WebClient().DownloadString("https://www.dnd5eapi.co/api/spells/");

            SpellsReference items = JsonConvert.DeserializeObject<SpellsReference>(json);

            string output = "";
            foreach (APIReference item in items.results)
            {
                output += $"{item.name}\n"; 
            }

            DisplayWindow.Text = $"{output}";
        }
    }
}
