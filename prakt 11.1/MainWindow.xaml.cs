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
using System.Text.RegularExpressions;

namespace prakt_11._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateFirst(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            string line = "aa aba abba abbba abbbba abbbbba";
            outLine1.Text = line;
            Regex regex = new Regex("a(b{4,})a");
            MatchCollection match = regex.Matches(line);
            for (int i = 0; i < match.Count; i++)
            {
                listBox1.Items.Add(match[i]);
            }
        }
        private void CalculateSecond(object sender, RoutedEventArgs e)
        {
            listBox2.Items.Clear();
            string line = "avb a1b a2b a3b a4b a5b abb acb";
            outLine2.Text = line;
            Regex regex = new Regex("a[^0-9]b");
            MatchCollection match = regex.Matches(line);
            object[] array = new object[match.Count];
            match.CopyTo(array, 0);
            for (int i = 0; i < match.Count; i++)
            {
                listBox2.Items.Add(match[i]);
            }
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Савельев Дмитрий Александрович В13\nПрактическая работа №11\nДана строка 'aa aba abba abbba abbbba abbbbba'. Напишите регулярное выражение, которое найдет строки вида aba, в которых 'b' встречается более 4-х раз (включительно).\nДана строка 'avb a1b a2b a3b a4b a5b abb acb'. Напишите регулярное выражение, которое найдет строки следующего вида: по краям стоят буквы 'a' и 'b', а между ними - не число.", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
