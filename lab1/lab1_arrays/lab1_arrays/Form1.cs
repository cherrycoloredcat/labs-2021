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
            // Формирование массива чисел из textBox и конвертация в int

            string[] rawNums = textBox.Text.Trim().Split(new char[] { ' ', '\r', '\n' });          

            try
            {
                _numsToCalculate = (from num in rawNums where !string.IsNullOrWhiteSpace(num) select Convert.ToInt32(num)).ToArray();    
            }
            catch
            {
                MessageBox.Show("Недопустимый ввод", "Ошибка");
                return;
            }

            // Вычисление среднего гармонического и подсчет результата

            float harmonicMean = calculateHarmonicMean();

            int amount = 0;

            foreach (int num in _numsToCalculate)
                if (num < harmonicMean)
                    amount++;

            MessageBox.Show("Среднее гармоническое: " + harmonicMean +
                "\n\nКоличество элементов, удовлетворяющих условию: " + amount, "Результат");
        }


        // Расчет среднего гармонического  
        private float calculateHarmonicMean()          
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
