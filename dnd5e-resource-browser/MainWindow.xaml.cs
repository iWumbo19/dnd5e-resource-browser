using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Diagnostics;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] _spellLevels = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private delegate void Fetch();
        private bool DatabaseReady;
        public MainWindow()
        {

            InitializeComponent();
            InitializeData();
            WaitLabel.Content = "Waiting for fetch request";
            DatabaseReady = false;
            ToggleTabs();
        }



        private void InitializeData()
        {
            Data.mainWindow = this;


        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            //Fetch fetch = FetchDatabase;
            //Task.Run(() => fetch());
            FetchDatabase();                        
            DatabaseReady = true;
            SetupTabs();
            ToggleTabs();            
        }

        private void FetchDatabase()
        {
            this.Dispatcher.Invoke(() =>
            {
                WaitLabel.Content = "Fetching database... This could take several seconds";
            });
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Data.PullJSON();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            this.Dispatcher.Invoke(() =>
            {
                WaitLabel.Content = $"Fetched database in {ts.TotalSeconds}";
            });
        }

        private void ToggleTabs()
        {
            if(DatabaseReady)
            {
                SpellTab.IsEnabled = true;
                ClassesTab.IsEnabled = true;
                RacesTab.IsEnabled = true;
                MonstersTab.IsEnabled = true;
                EquipmentTab.IsEnabled = true;
                MagicItemTab.IsEnabled = true;
                GoButton.IsEnabled = false;
            }
            else
            {
                SpellTab.IsEnabled = false;
                ClassesTab.IsEnabled = false;
                RacesTab.IsEnabled = false;
                MonstersTab.IsEnabled = false;
                EquipmentTab.IsEnabled = false;
                MagicItemTab.IsEnabled = false;
                GoButton.IsEnabled = true;
            }
        }

        private void SetupTabs()
        {
            SetupSpellTab();
            SetupClassesTab();
            SetupRacesTab();
            SetupMonsterTab();
            SetupEquipmentTab();
            SetupMagicItemTab();
        }

        private void SetupSpellTab()
        {
            SpellListBox.Items.Clear();
            foreach (var item in Data.SpellNameList)
            {
                SpellListBox.Items.Add(item);
            }
            SpellListBox.Items.Refresh();
        }

        private void SpellListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SpellInfoText.Text = Data.SpellInfo(SpellListBox.SelectedIndex);
        }

        private void SetupClassesTab()
        {
            ClassListBox.Items.Clear();
            foreach (var item in Data.ClassNameList)
            {
                ClassListBox.Items.Add(item);
            }
            ClassListBox.Items.Refresh();
        }

        private void ClassListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClassInfoText.Text = Data.ClassInfo(ClassListBox.SelectedIndex);
        }

        private void SetupRacesTab()
        {
            RacesListBox.Items.Clear();
            foreach (var item in Data.RaceNameList)
            {
                RacesListBox.Items.Add(item);
            }
            RacesListBox.Items.Refresh();
        }

        private void RacesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RacesInfoText.Text = Data.RaceInfo(RacesListBox.SelectedIndex);
        }

        public void SetupMonsterTab()
        {
            MonsterListBox.Items.Clear();
            foreach (var item in Data.MonsterNameList)
            {
                MonsterListBox.Items.Add(item);
            }
            MonsterListBox.Items.Refresh();
        }

        private void MonsterListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MonsterInfoText.Text = Data.MonsterInfo(MonsterListBox.SelectedIndex);
        }

        public void SetupEquipmentTab()
        {
            EquipmentListBox.Items.Clear();
            foreach (var item in Data.EquipmentNameList)
            {
                EquipmentListBox.Items.Add(item);
            }
            EquipmentListBox.Items.Refresh();
        }

        private void EquipmentListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EquipmentInfoText.Text = Data.EquipmentInfo(EquipmentListBox.SelectedIndex);
        }

        private void SetupMagicItemTab()
        {
            MagicItemListBox.Items.Clear();
            foreach (var item in Data.MagicItemNameList)
            {
                MagicItemListBox.Items.Add(item);
            }
            MagicItemListBox.Items.Refresh();
        }

        private void MagicItemListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MagicItemInfoText.Text = Data.MagicItemInfo(MagicItemListBox.SelectedIndex);
        }
    }
}
