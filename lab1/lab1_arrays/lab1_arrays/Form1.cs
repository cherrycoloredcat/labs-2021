using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace lab1_arrays
{
    public partial class Form1 : Form
    {
        private int[] _numsToCalculate;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string[] rawNums = textBox.Text.Trim().Split(new char[] { ' ', '\r', '\n' });          // Формирование массива чисел из textBox

            try
            {
                _numsToCalculate = (from num in rawNums where !string.IsNullOrWhiteSpace(num) select Convert.ToInt32(num)).ToArray();    // Конвертация в int
            }
            catch
            {
                MessageBox.Show("Недопустимый ввод", "Ошибка");
                return;
            }

            float harmonicMean = calculateHarmonicMean();

            int amount = 0;

            foreach (int num in _numsToCalculate)                       // Подсчет и вывод
                if (num < harmonicMean)
                    amount++;

            MessageBox.Show("Среднее гармоническое - " + harmonicMean +
                "\n\nКоличество элементов, удовлетворяющих условию - " + amount, "Результат");
        }

        private float calculateHarmonicMean()           // Расчет среднего гармонического
        {
            float sum = 0;

            foreach(int num in _numsToCalculate)
            {
                sum += 1.0f / num;
            }

            return _numsToCalculate.Length / sum;
        }
    }
}
