using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography;
using Lib_11;

namespace Практическая5_Цай
{
    public partial class MainWindow : Window
    {
        Pair pairf = new Pair();
        Pair pairs = new Pair();
        bool trynum=false;
        bool chetn=false;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void fill_Click(object sender, RoutedEventArgs e)
        {
            tb1_1pair.Text = pairf.pairv[0].ToString();
            tb2_1pair.Text = pairf.pairv[1].ToString();

            tb1_2pair.Text = pairs.pairv[0].ToString();
            tb2_2pair.Text = pairs.pairv[1].ToString();
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tb1_1pair.Text, out int e11) && int.TryParse(tb2_1pair.Text, out int e21) && int.TryParse(tb1_2pair.Text, out int e12) && int.TryParse(tb2_2pair.Text, out int e22))
            {
                trynum = true;
                pairf.pairv = [e11, e21];
                pairs.pairv = [e12, e22];
                if (e11 % 2 != 0 || e21 % 2 != 0 || e12 % 2 != 0 || e22 % 2 != 0)
                    chetn = true;
                else chetn = false;
            }
            else trynum = false;
            if (trynum)
            {
                Pair pair = pairf * pairs;
                tb1res.Text = pair.pairv[0].ToString();
                tb2res.Text = pair.pairv[1].ToString();

                if (chetn)
                {
                    tb1_1pair.Text = pairf.pairv[0].ToString();
                    tb2_1pair.Text = pairf.pairv[1].ToString();
                    tb1_2pair.Text = pairs.pairv[0].ToString();
                    tb2_2pair.Text = pairs.pairv[1].ToString();
                }
            }
            else MessageBox.Show("Введите корректные значения", "ЗАЩИТА ОТ ТУПОГО ЮЗЕРА", MessageBoxButton.OK,MessageBoxImage.Error);
        }
        /// <summary>
        /// Удвоить 1 пару
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doublefirst_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tb1_1pair.Text, out int ep11) && int.TryParse(tb2_1pair.Text, out int ep21))
            {
                trynum = true;
                pairf.pairv = [ep11, ep21];
                if (ep11 % 2 != 0 || ep21 % 2 != 0)
                    chetn = true;
                else chetn = false;
            }
            else trynum = false;
            if (trynum && chetn == false)
            {
                pairf++;
                tb1_1pair.Text = pairf.pairv[0].ToString();
                tb2_1pair.Text = pairf.pairv[1].ToString();
            }
            else MessageBox.Show("Введите корректные значения", "ЗАЩИТА ОТ ТУПОГО ЮЗЕРА", MessageBoxButton.OK,MessageBoxImage.Error);
        }
        /// <summary>
        /// Удвоить 2 пару
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doublesecond_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tb1_2pair.Text, out int ep12) && int.TryParse(tb2_2pair.Text, out int ep22))
            {
                trynum = true;
                pairs.pairv = [ep12, ep22];
                if (ep12 % 2 != 0 || ep22 % 2 != 0)
                    chetn = true;
                else chetn = false;
            }
            else trynum = false;
            if (trynum && chetn == false)
            {
                pairs++;
                tb1_2pair.Text = pairs.pairv[0].ToString();
                tb2_2pair.Text = pairs.pairv[1].ToString();
            }
            else MessageBox.Show("Введите корректные значения", "ЗАЩИТА ОТ ТУПОГО ЮЗЕРА", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void inf_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Цай Владислав, Практическая 5,6,7; Вариант - 11;\r\n5практ - Создать класс Pair (пара четных чисел).\r\nСоздать необходимые методы и свойства.\r\nОпределить метод перемножения пар (а, b) * (с, d) = (а * c, b * d).\r\nСоздать перегруженный метод для удвоения пары чисел." +
                "\r\n6практ - Использовать класс Pair (пара четных чисел). Разработать операцию перемножения пар (а, b) * (с, d) = (а * c, b * d).\r\nРазработать операцию инкремента для удвоения пары чисел.\r\n7 практ- Использовать класс Pair (пара четных чисел). Определить производный класс треугольник RightAngled с полями-катетами.\r\nОпределить методы вычисления гипотенузы и площади треугольника.", "О программе");
        }
        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Очистка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            tb1_1pair.Clear();
            tb1_2pair.Clear();
            tb2_1pair.Clear();
            tb2_2pair.Clear();
            tb1res.Clear();
            tb2res.Clear();
        }
        /// <summary>
        /// Расчет гипотенузы и площади
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>1
        private void HypArea_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tb1_1pair.Text, out int ep11) && int.TryParse(tb2_1pair.Text, out int ep21))
            {
                trynum = true;
                pairf.pairv = [ep11, ep21];
                if (ep11 % 2 != 0 || ep21 % 2 != 0)
                    chetn = true;
                else chetn = false;
            }
            else trynum = false;
            if (trynum)
            {
                RightAngled right = new RightAngled(Convert.ToInt32(tb1_1pair.Text), Convert.ToInt32(tb2_1pair.Text));
                try
                {
                    tb1res.Text = "Гипотенуза: " + right.CalcHyp().ToString();
                    tb2res.Text = "Площадь: " + right.CalcArea().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введите корректные значения", "ЗАЩИТА ОТ ТУПОГО ЮЗЕРА", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else MessageBox.Show("Введите корректные значения", "ЗАЩИТА ОТ ТУПОГО ЮЗЕРА", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}