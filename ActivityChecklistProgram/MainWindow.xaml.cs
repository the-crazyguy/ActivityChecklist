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

namespace ActivityChecklistProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int ActivitiesCount { get; set; } = 4;
        public List<string> activities = new List<string> { "Draw", "Go for a walk", "Read up on something", "Talk to a friend" };

        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            SetActivities();
        }

        private void SetActivities()
        {
            for (int i = 1; i <= ActivitiesCount; i++)
            {
                Label currentActivity = (Label)FindName($"Activity{i}");
                currentActivity.Content = activities[i - 1];
            }
        }
    }
}
