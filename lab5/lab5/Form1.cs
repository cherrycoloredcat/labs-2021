using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private int[] array;
        private int size = 20000;
        private int max = 1000;

        public Form1()
        {
            InitializeComponent();
            array = new int[size];
        }

        private void Generate(int sorted)
        {
            Random rnd = new Random();

            for(int i = 0; i < sorted; i++)
            {
                array[i] = rnd.Next(1, max);
            }

            if (sorted > 0)
                Array.Sort<int>(array, 0, sorted);

            for (int i = sorted; i < size; i++)
            {
                array[i] = rnd.Next(1, max);
            }
        }

        public string Print(int[] arr)
        {
            string str = "";

            for (int i = 0; i < size; i++)
            {
                if (arr[i] / 100 == 0)
                    str += "  ";

                if (arr[i] / 10 == 0)
                    str += "  ";

                str += arr[i] + " ";
            }

            return str;
        }

        private void buttonSelectionSort_Click(object sender, EventArgs e)
        {

            int[] arr = new int[size];

            array.CopyTo(arr, 0);

            DateTime dold = DateTime.Now;
            arr = SelectionSort(arr);
            TimeSpan span = DateTime.Now - dold;

            label1.Text = "Время выполнения (с)" + Environment.NewLine + span.TotalSeconds.ToString();

            textBox2.Text = Print(arr);
        }
        
        // Сортировка прямым выбором
        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min_j = i, min_val = arr[i] / 10 % 10, t;

                for (int j = i; j < arr.Length; j++)
                {

                    if(min_val > arr[j] / 10 % 10)
                    {
                        min_j = j;
                        min_val = arr[j] / 10 % 10;
                    }
                }

                if(min_j != i)
                {
                    t = arr[i];
                    arr[i] = arr[min_j];
                    arr[min_j] = t;
                }


            }


            return arr;
        }

        private void buttonBinInsertSort_Click(object sender, EventArgs e)
        {
            int[] arr = new int[size];

            array.CopyTo(arr, 0);

            DateTime dold = DateTime.Now;
            BinInsertSort(arr);
            TimeSpan span = DateTime.Now - dold;

            label2.Text = "Время выполнения (с)" + Environment.NewLine + span.TotalSeconds.ToString();

            textBox2.Text = Print(arr);
        }

        // Сортировка вставками + двоичный поиск
        public static int[] BinInsertSort(int[] arr)
        {
            int value, pos;

            for (int i = 1; i < arr.Length; i++)
            {
                value = arr[i];
                pos = BinarySearchByDecimals(arr, value / 10 % 10, 0, i - 1);

                for(int j = i; j > pos; j--)
                {
                    arr[j] = arr[j - 1];
                }

                arr[pos] = value;
            } 


            return arr;
        }

        public static int BinarySearchByDecimals(int[] arr, int value, int l, int r)
        {
            int m = (l + r) / 2;

            if (r < l)
            {
                return m;
            }

            if (arr[m] / 10 % 10 > value)
                return BinarySearchByDecimals(arr, value, l, m - 1);
            else
                return BinarySearchByDecimals(arr, value, m + 1, r);
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Generate(0);
            textBox1.Text = Print(array);
        }

        private void buttonHalfSorted_Click(object sender, EventArgs e)
        {
            Generate(size / 2);
            textBox1.Text = Print(array);
        }

        private void buttonInverted_Click(object sender, EventArgs e)
        {
            Generate(size);

            int t;

            for(int i = 0; i < size / 2; i++)
            {
                t = array[i];
                array[i] = array[size - i - 1];
                array[size - i - 1] = t;
            }

            textBox1.Text = Print(array);
        }
    }
}
