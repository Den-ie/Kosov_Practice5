using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.ExceptionServices;
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

namespace Kosov_Practice5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        private void Make_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(FValue.Text, out int First) & !int.TryParse(SValue.Text, out int Second))
            {
                MessageBox.Show("Введите пару чисел", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Pair Para = new Pair(First, Second);

            Answer.Text = Convert.ToString(Para.FirstValue) + ", " + Convert.ToString(Para.SecondValue);

        }

        private void Make2_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(FValue.Text, out int First) & !int.TryParse(SValue.Text, out int Second))
            {
                MessageBox.Show("Введите пару чисел", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Pair Para2 = new Pair(First, Second);

            Answer.Text = Convert.ToString(Para2.FirstValue) + ", " + Convert.ToString(Para2.SecondValue);

            Para2.PairCompare(Para2, Para2);
        }

        private void Compare(object sender, RoutedEventArgs e)
        {
            //
        }
    }
}
