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
        public MainWindow()
        {

            InitializeComponent();
            InitializeData();
            WaitLabel.Content = "Waiting for retch request";
        }



        private void InitializeData()
        {
            Data.mainWindow = this;


        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            Fetch fetch = FetchDatabase;            
            Task.Run(() => fetch());            
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

    }
}
