using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack
{
    public partial class Form1 : Form
    {
        private Stack _stack;

        public Form1()
        {
            InitializeComponent();
        }

        // Генерация стека
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxN.Text))
            {
                MessageBox.Show("Число N не введено", "Ошибка");
                return;
            }

            Generate(Convert.ToInt32(textBoxN.Text));
            _stack.PrintStack(textBoxStack);
        }

        public void Generate(int num)
        {
            _stack = new Stack();
            Random rnd = new Random();

            for (int i = 0; i < num; i++)
            {
                _stack.Add(new Node(rnd.Next(-10000, 10000)));
            }
        }

        // Поиск коилчества чисел больше заданного
        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxK.Text))
            {
                MessageBox.Show("Число K не введено", "Ошибка");
                return;
            }

            if (_stack == null)
            {
                MessageBox.Show("Стек пуст", "Ошибка");
                return;
            }

            MessageBox.Show("Количество цисел больше заданного = " + _stack.FindQuantity(Convert.ToInt32(textBoxK.Text)), "Результат");
        }
    }

    public class Stack
    {
        public Node Head { get; private set; }

        public void Add(Node n)
        {
            if (Head == null)
                Head = n;
            else
            {
                n.Next = Head;
                Head = n;
            }
        }

        public int FindQuantity(int num)
        {
            Node current = Head;

            int q = 0;
            while (current != null)
            {
                if (current.Num > num)
                    q++;
                current = current.Next;
            }
            return q;
        }
        public void PrintStack(TextBox tb)
        {
            Node current = Head;
            tb.Text = "";

            while (current != null)
            {
                tb.Text += current.Num + " ";
                current = current.Next;
            }
        }
    }

    public class Node
    {
        public int Num { get; }
        public Node Next { get; set; }

        public Node (int num)
        {
            Num = num;
        }
    }
}
