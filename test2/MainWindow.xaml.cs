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

namespace test2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Liquid liquid;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AboutPr_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил: Попов Константин Романович" + "\n" + "Практическая работа №5. Вариант №14." + 
                "\n" + "Создать класс Liquid (жидкость), имеющий поля названия, плотности и объема. Создать необходимые методы и свойства. Создать перегруженные методы SetParams, для установки параметров жидкости.");
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            bool f1, f2;

            f1 = int.TryParse(Plt.Text, out int p1);
            f2 = int.TryParse(Volume.Text, out int v1);

            if (f1 && f2)
            {
                liquid = new(Name.Text, p1, v1);
                tbResult.Text = liquid.GetInfo(); 
            }
            else MessageBox.Show("Неверный ввод");

            Name.Clear();
            Plt.Clear();
            Volume.Clear();
        }

        //Очистка
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Name.Clear();
            Plt.Clear();
            Volume.Clear();
            tbResult.Clear();
        }

        //Нахождение массы
        private void PlTen_Click(object sender, RoutedEventArgs e)
        {
            liquid.PlusTen();
            tbResult.Text = liquid.GetInfo();
        }
    }
}
