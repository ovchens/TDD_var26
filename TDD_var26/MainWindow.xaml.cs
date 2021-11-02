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

namespace TDD_var26
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            r.ItemsSource = list;
            e.Content = " У кого сегодня день рождения: ";
            list.Where(p => var26.birthday_Check(p.Value)).ToList().ForEach(p => e.Content += $"\n{p.Key}");
        }

        private Dictionary<string, DateTime> list = new Dictionary<string, DateTime>
        {
            {"Lock", new DateTime(1999, 02, 12) }, {"Tor", new DateTime(1989, 11, 02) }
        };

        
    }
}
