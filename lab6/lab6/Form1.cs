using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        private BinarySearchTree _bst;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(textBoxSize.Text);
            int key = Convert.ToInt32(textBoxKey.Text);

            int[] input = Generate(size);

            int [] data = LinearSearch(input, key);

            string output = "Найдено " + data.Length + " симоволов " + key + " на позициях ";

            for(int i = 0; i < data.Length; i++)
            {
                output += data[i] + " ";
            }

            output += Environment.NewLine + Environment.NewLine;

            foreach(int i in input)
            {
                output += i + " ";
            }

            textBoxOutput.Text = output;

        }

        private int[] Generate(int size)
        {
            int[] arr = new int[size];

            Random rnd = new Random();

            for(int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }

            return arr;
        }

        private int[] LinearSearch(int[] input, int key)
        {
            List<int> res = new List<int>();

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == key)
                    res.Add(i);
            }

            return res.ToArray();
        }

        private void buttonTree_Click(object sender, EventArgs e)
        {
            _bst = new BinarySearchTree();

            int[] input = Generate(100);

            foreach(int i in input)
            {
                _bst.Add(i);
            }

            textBoxOutput.Text = _bst.Print();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxRemove.Text);

            _bst.Remove(value);

            textBoxOutput.Text = _bst.Print();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string text;

            using(StreamReader sr = new StreamReader("text.txt"))
            {
                text = sr.ReadToEnd();
            }

            int ind = KMP(text, textBoxWord.Text);

            textBoxOutput.Text = ind.ToString();

        }

        private int KMP(string text, string word)
        {
            int[] indexes = new int[word.Length];

            bool same;

            for(int i = 1; i < word.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    same = true;

                    for (int k = 0; k <= j; k++)
                    {
                        if (word[k] != word[i - j + k])
                        {
                            same = false;
                            break;
                        }
                    }

                    if (same)
                        indexes[i] = j + 1;
                }
            }

            int word_ind = 0;

            for(int i = 0; i < text.Length; i++)
            {

                if (word_ind == word.Length)
                    return i - word_ind;

                if (text[i] == word[word_ind])
                {
                    word_ind++;

                }
                else
                {
                    if(word_ind != 0)
                    {
                        word_ind = indexes[word_ind - 1];
                        i--;
                    }
                }
            }

            if (word_ind == word.Length)
                return text.Length - word_ind;
            else
                return -1;

        }
    }

    public class BinarySearchTree
    {
        public Node Head { get; private set; }

        public void Add(int value)
        {
            Node n = new Node(value);

            if (Head == null)
            {
                Head = n;
                return;
            }

            Node closest;

            SearchForTheClosest(value, out closest);

            if (closest.Key == value)
                return;

            if (closest.Key < value)
                closest.Right = n;
            else
                closest.Left = n;
        }

        public void Remove(int value)
        {
            Node target, upper;

            SearchForTheClosest(value, out target, out upper);

            if (target.Key != value)
                return;

            if(target.Right == null)
            {
                if (upper.Left == target)
                    upper.Left = null;
                else
                    upper.Right = null;
            }
            else
            {
                Node pr_swap = target;
                Node swap = target.Right;

                while (swap.Left != null)
                {
                    pr_swap = swap;
                    swap = swap.Left;
                }

                target.Key = swap.Key;

                pr_swap.Left = swap.Right;

            }


        }

        private void SearchForTheClosest(int key, out Node target, out Node upper )
        {
            target = null;
            upper = null;

            if (Head == null)
            {
                return;
            }

            target = Head;

            while(target.Key < key && target.Right != null || target.Key > key && target.Left != null)
            {
                if (target.Key == key)
                    break;

                upper = target;

                if (target.Key > key)
                    target = target.Left;

                else
                    target = target.Right;

            }
        }

        private void SearchForTheClosest(int key, out Node target)
        {
            Node upper = null;

            target = null;

            SearchForTheClosest(key, out target, out upper);
        }

        public string Print()
        {
            return PrintStep(Head, "");
        }

        private string PrintStep(Node cur, string str)
        {
            str += cur.Key + " ";

            string output = "", t;

            if (cur.Left != null)
                output += PrintStep(cur.Left, str);

            if (cur.Right != null)
                output += PrintStep(cur.Right, str);

            if (cur.Left == null && cur.Right == null)
                return str + Environment.NewLine;
            else
                return output;

        }

    }


    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Key { get; set; }

        public Node(int key)
        {
            Key = key;
        }
    }
}
