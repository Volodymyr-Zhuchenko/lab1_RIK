using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace credit_depozite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Calculate()
        {

            double amount = Convert.ToDouble(tbAmount.Text);
            double percent = Convert.ToDouble(tbPercent.Text) / 100.0;
            double months = Convert.ToDouble(tbMonths.Text);

            double result = amount + (amount * percent * (months / 12.0));

            if (rbCredit.Checked)
            {
                lblResult.Text = $"Вам потрібно сплати";
                lblResultNum.Text = $"{result:N2}";
            }
            else if (rbDeposit.Checked)
            {
                lblResult.Text = $"Ви отримаєте";
                lblResultNum.Text = $"{result:N2}";
            }
            else
            {
                MessageBox.Show("Оберіть тип: кредит чи депозит");
            }

        }

        public void Save()
        {
            string optionType = "кредиту";

            if (rbDeposit.Checked)
            {
                optionType = "депозиту";
            }
            string month = "місяць";
            if (Convert.ToDouble(tbMonths.Text) > 1)
            {
                month = "місяців";
            }
            string resaultText = $"При сумі {optionType} {Convert.ToDouble(tbAmount.Text):N2}₴ під {Convert.ToDouble(tbPercent.Text)}% річних, на термін {Convert.ToDouble(tbMonths.Text)} {month}, {lblResult.Text} {lblResultNum.Text:N2}₴";
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = $"credit_{date}.txt";
                if (rbDeposit.Checked)
                {
                    fileName = $"deposit_{date}.txt";
                }


                File.WriteAllText(fileName, resaultText);
                MessageBox.Show($"Збережено у файл {fileName}");
            }
            catch
            {
                MessageBox.Show("Помилка експортування даних у файл .txt");
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Calculate();
            Save();
        }
    }
}
