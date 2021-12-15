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
using System.Windows.Threading;

namespace Practos_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }
        const double PI = 3.14;

        private void Task1CountButton(object sender, RoutedEventArgs e)
        {

            int.TryParse(firstSideBox.Text,  out int valueR1);
            int.TryParse(secondSideBox.Text,  out int valueR2);
            if (valueR1 > valueR2)
            {
                ploshadBox1.Text = Convert.ToString((valueR1*valueR1) * PI);
                ploshadBox2.Text = Convert.ToString((valueR2*valueR2) * PI);
                ploshadBox3.Text = Convert.ToString(((valueR1 * valueR1) * PI) - ((valueR2 * valueR2) * PI));
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Task2CountButton(object sender, RoutedEventArgs e)
        {
            int.TryParse(inputNumber.Text, out int year);
            int result = 0;
            if (year % 100 > 0)
            {
                result++;
                result += year / 100 % 100;
                centuriesBox.Text = Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("HH:mm");
            date.Text = d.ToString("dd.MM.yyyy");
        }
    }
}
