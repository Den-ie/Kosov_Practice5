using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
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

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Косов Даниил ИСП-34 \nПрактическая №5 \nCоздать класс Pair (пара чисел). Создать необходимые методы и свойства. \r\nОпределить метод сравнения пар: пара p1 больше пары р2, если (first.pl > first.р2) \r\nили (first.pl = first.р2) и (second.pl > second.р2). Создать перегруженные методы \r\nSetParams, для установки параметров объекта.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        Pair _para2 = new Pair(0, 0);
        Pair _para = new Pair(0, 0);

        private void Make_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(FValue.Text, out int First) & !int.TryParse(SValue.Text, out int Second))
            {
                MessageBox.Show("Введите пару чисел", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            _para = new Pair(First, Second);

            Answer.Text = Convert.ToString(_para.FirstValue) + ", " + Convert.ToString(_para.SecondValue);
        }

        private void Make2_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(FValue.Text, out int First) & !int.TryParse(SValue.Text, out int Second))
            {
                MessageBox.Show("Введите пару чисел", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            _para2 = new Pair(First, Second);

            Answer2.Text = Convert.ToString(_para2.FirstValue) + ", " + Convert.ToString(_para2.SecondValue);
        }

        private void Compare_Click(object sender, RoutedEventArgs e)
        {
            if (Answer.Text == "" || Answer2.Text == "")
                MessageBox.Show("Создайте пары для сравнения");
            else
            {
                if (Pair.PairCompare(_para, _para2))
                    MessageBox.Show("Первая пара больше");
                else
                    MessageBox.Show("Первая пара не больше");
            }
        }

        private void CangeFPar(object sender, RoutedEventArgs e)
        {
            if (ChangeExtra.Text == "")
            {
                if (!int.TryParse(Change.Text, out int x))
                {
                    MessageBox.Show("Введите корректные значения");
                    return;
                }
                _para.SetParams(Convert.ToInt32(x));
                Answer.Text = Convert.ToString(_para.FirstValue) + ", " + Convert.ToString(_para.SecondValue);
            }
            else
            {
                _para.SetParams(Convert.ToInt32(Change.Text), Convert.ToInt32(ChangeExtra.Text));
                Answer.Text = Convert.ToString(_para.FirstValue) + ", " + Convert.ToString(_para.SecondValue);
            }
        }
    }
}