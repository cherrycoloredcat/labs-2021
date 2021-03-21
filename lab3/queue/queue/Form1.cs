using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Queue _queue;

        public Form()
        {
            InitializeComponent();
        }

        // Генерация очереди
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            _queue = new Queue();

            int size;
            try
            {
                size = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Недопустимый формат", "Ошибка");
                return;
            }
            _queue.Generate(size);

            textBox1.Text = _queue.Print(); _queue.Print();
        }

        // Меняет местами макс и мин элементы
        private void buttonSwich_Click(object sender, EventArgs e)
        {
            if(_queue == null || _queue.Head == null)
            {
                MessageBox.Show("Очередь не существует", "Ошибка");
                return;
            }

            Node max = _queue.Head, min = _queue.Head;

            Node current = _queue.Head.Next;

            while(current != null)
            {
                if(current.Num > max.Num)
                {
                    max = current;
                }

                if (current.Num < min.Num)
                {
                    min = current;
                }

                current = current.Next;
            }

            Node prev = null, tmp = null;
            current = _queue.Head;

            int minQuantity = 0, maxQuantity = 0;

            for(; current != null; prev = current, current = current.Next)
            {
                if(current.Num == min.Num)
                {
                    tmp = (Node)max.Clone();
                    tmp.Next = current.Next;

                    if (current == _queue.Head)    // если заменяется головной элемент
                    {
                        _queue.Head = tmp;
                    }
                    else
                    {
                        prev.Next = tmp;
                    }

                    if (current == _queue.Tail)
                        _queue.Tail = tmp;

                    current = tmp;
                    minQuantity++;
                    
                    continue;
                }


                if (current.Num == max.Num)
                {
                    tmp = (Node)min.Clone();
                    tmp.Next = current.Next;

                    if (current == _queue.Head)    // если заменяется головной элемент
                    {
                        _queue.Head = tmp;
                    }
                    else
                    {
                        prev.Next = tmp;
                    }
                    if (current == _queue.Tail)
                        _queue.Tail = tmp;

                    current = tmp;
                    maxQuantity++;
                }
            }
            textBox1.Text = _queue.Print();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            if (_queue == null || _queue.Head == null)
            {
                MessageBox.Show("Очередь не существует", "Ошибка");
                return;
            }

            Random rnd = new Random();
            _queue.Push(new Node((float)rnd.NextDouble() * 200 - 100));
            textBox1.Text = _queue.Print();
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            if(_queue == null || _queue.Head == null)
            {
                MessageBox.Show("Очередь не существует", "Ошибка");
                return;
            }
                

            _queue.Pop();
            textBox1.Text = _queue.Print();
        }
    }

    public class Queue
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void Push(Node n)
        {
            Tail.Next = n;
            Tail = n;
        }
        public Node Pop()
        {
            Node h = Head;
            Head = Head.Next;
            return h;
        }

        public void Generate(int size)
        {
            Head = null;
            Tail = null;

            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                Node newElement = new Node((float)rnd.NextDouble() * 200 - 100);

                if(Head == null)
                {
                    Head = newElement;
                    Tail = Head;
                    continue;
                }

                Tail.Next = newElement;
                Tail = newElement;
            }
        }

        public string Print()
        {
            if (Head == null)
            {
                MessageBox.Show("Очередь не существует", "Ошибка");
                return null;
            }

            string str = "";
            Node current = Head;

            while(current != null)
            {
                str += current.Num;

                if(current == Head)
                    str += " <- Head";

                if (current == Tail)
                    str += " <- Tail";

                str += Environment.NewLine;

                current = current.Next;
            }
            return str;
        }

    }

    public class Node: ICloneable
    {
        public float Num { get; }
        public Node Next { get; set; }

        public Node (float num)
        {
            Num = num;
        }
        public object Clone()
        {
            Node n = new Node(Num);
            n.Next = Next;
            return n;
        }
    }
}
