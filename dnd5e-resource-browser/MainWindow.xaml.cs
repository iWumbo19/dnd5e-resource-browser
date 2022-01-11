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
        private int[] _spellLevels = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public MainWindow()
        {
            InitializeComponent();
            InitializeData();            
        }



        private void InitializeData()
        {
            string spellJSON = new WebClient().DownloadString("https://www.dnd5eapi.co/api/spells/");
            Data.UpdateSpells(JsonConvert.DeserializeObject<SpellsReference>(spellJSON));
            SpellListCombo.DataContext = Data.SpellList;
            SpellLevelCombo.ItemsSource = _spellLevels;

        }

        private void SpellListCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayWindow.Text = Data.GetSpell(SpellListCombo.SelectedIndex);
        }

        private void SpellLevelCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((int)SpellLevelCombo.SelectedItem == 0)
            {
                string spellJSON = new WebClient().DownloadString("https://www.dnd5eapi.co/api/spells/");
                Data.UpdateSpells(JsonConvert.DeserializeObject<SpellsReference>(spellJSON)); 
            }
            else
            {
                string spellJSON = new WebClient().DownloadString($"https://www.dnd5eapi.co/api/spells?level={SpellLevelCombo.SelectedItem}");
                Data.UpdateSpells(JsonConvert.DeserializeObject<SpellsReference>(spellJSON));
            }
        }
    }
}
