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
using System.IO;

namespace WPF_credit_depozite1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ThemeToggle_Click(object sender, RoutedEventArgs e)
        {
            if (themeToggle.IsChecked == true)
            {
                // --- ТЕМНА ТЕМА ---
                this.Resources["WindowBg"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
                this.Resources["MainText"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E0E0E0")); // Світло-сірий
                this.Resources["SecondaryText"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#888888"));
                this.Resources["ControlBg"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E1E1E"));
                this.Resources["AccentColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3F51B5")); // Indigo
            }
            else
            {
                // --- СВІТЛА ТЕМА ---
                this.Resources["WindowBg"] = new SolidColorBrush(Colors.White);
                this.Resources["MainText"] = new SolidColorBrush(Colors.Black); // ЧОРНИЙ КОЛІР ДЛЯ НАДПИСІВ
                this.Resources["SecondaryText"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#424242")); // Темно-сірий
                this.Resources["ControlBg"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F5F5F5"));
                this.Resources["AccentColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1A237E")); // Глибокий синій
            }
        }

        private void NumberValidationTextBox(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            // Дозволяє вводити лише цифри та кому/крапку
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[^0-9,.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBox_FormatN2(object sender, RoutedEventArgs e)
        {
            // Отримуємо TextBox, який викликав подію
            TextBox tb = sender as TextBox;

            if (tb != null && double.TryParse(tb.Text, out double value))
            {
                // Форматуємо число і записуємо назад у TextBox
                tb.Text = value.ToString("N2");
            }
        }

        public bool Calculate()
        {
            bool isAmountValid = double.TryParse(tbAmount.Text, out double amount);
            bool isPercentValid = double.TryParse(tbPercent.Text, out double percent);
            bool isMonthsValid = double.TryParse(tbMonths.Text, out double months);

            if (!isAmountValid || !isPercentValid || !isMonthsValid)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення в усі поля.");
                return false;
            }

            if (amount < 1 || amount > 50000000)
            {
                MessageBox.Show("Сума повинна бути в діапазоні від 1 до 50 000 000 грн.");
                return false;
            }

            if (percent < 0 || percent > 100)
            {
                MessageBox.Show("Відсоток повинен бути в діапазоні від 0 до 100%.");
                return false;
            }

            if (months <= 0 || months > 100)
            {
                MessageBox.Show("Термін повинен бути більше в діапазоні від 1 до 100 місяців.");
                return false;
            }

            double result = amount + (amount * (percent / 100.0) * (months / 12.0));

            if (rbCredit.IsChecked == true)
            {
                lblResult.Content = "Вам потрібно сплатити";
            }
            else
            {
                lblResult.Content = "Ви отримаєте";
            }

            lblResultNum.Content = $"{result:N2}₴";
            return true;
        }

        public void Save()
        {
            string optionType = rbDeposit.IsChecked == true ? "депозиту" : "кредиту";
            string monthWord = Convert.ToDouble(tbMonths.Text) > 1 ? "місяців" : "місяць";

            string resultText = $"При сумі {optionType} {Convert.ToDouble(tbAmount.Text):N2}₴ під {Convert.ToDouble(tbPercent.Text)}% річних, " +
                               $"на термін {tbMonths.Text} {monthWord}, {lblResult.Content} {lblResultNum.Content}";

            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = rbDeposit.IsChecked == true ? $"deposit_{date}.txt" : $"credit_{date}.txt";

                File.WriteAllText(fileName, resultText);
                MessageBox.Show($"Збережено у файл: {fileName}");
            }
            catch
            {
                MessageBox.Show("Помилка експортування даних у файл .txt");
            }
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (Calculate()) // Спочатку рахуємо, якщо успішно — зберігаємо
            {
                Save();
            }
        }
    }
}
