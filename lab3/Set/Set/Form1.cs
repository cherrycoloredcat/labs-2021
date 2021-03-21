using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Set
{
    public partial class Form1 : Form
    {
        private Set _inputSet, _primeSet, _compositeSet;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSeparate_Click(object sender, EventArgs e)
        {
            _inputSet = new Set();
            _primeSet = new Set();
            _compositeSet = new Set();

            string input = textBoxInput.Text;
            int[] values;

            try
            {
                // Конвертация в int
                values = (from string a in input.Split('\n', '\r', ' ') where !string.IsNullOrEmpty(a) select Convert.ToInt32(a)).ToArray<int>();
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода", "Ошибка");
                return;
            }

            foreach(int v in values)
            {
                if(!_inputSet.Add(v))
                {
                    MessageBox.Show("Числа в множестве не должны повторяться", "Ошибка");
                    return;
                }
            }

            foreach(int v in _inputSet)
            {
                if (IsPrime(v))
                {
                    if (!_primeSet.Add(v))
                    {
                        MessageBox.Show("Числа в множестве не должны повторяться", "Ошибка");
                        return;
                    }
                }
                else
                    if (!_compositeSet.Add(v))
                {
                    MessageBox.Show("Числа в множестве не должны повторяться", "Ошибка");
                    return;
                }
            }

            textBoxPrime.Text = _primeSet.Print();
            textBoxComposite.Text = _compositeSet.Print();

        }

        private bool IsPrime(int a)
        {
            for(int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
    }

    public class Set: IEnumerable<int>
    {
        private readonly List<int> _values = new List<int>();

        public bool Add(int n)
        {
            if (Contain(n) != 0)
                return false;

            _values.Add(n);

            return true;
        }

        public int Contain(int num)
        {
            return _values.Find(x => x == num);
        }

        public string Print()
        {
            string st = "";

            foreach(int v in _values)
                st += v + Environment.NewLine;

            return st;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)_values).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_values).GetEnumerator();
        }
    }
}
