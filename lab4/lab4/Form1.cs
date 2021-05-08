using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        private HashTable _hashTable;

        public Form1()
        {
            InitializeComponent();
        }


        // Задание 1. Ввод
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _hashTable = new HashTable(30);

            string input = textBoxInput1.Text.Trim();

            foreach (char c in input)
            {
                if (c == ' ' || c == '\n' || c == '\r')
                    continue;

                _hashTable.Add(c.ToString());
            }

            textBoxOutput.Text = _hashTable.Print();
        }

        // Задание 1. Поиск
        private void buttonFind_Click(object sender, EventArgs e)
        {
            Find(textBoxLetter.Text);
        }

        private void Find(string text)
        {
            Node n = _hashTable.Find(text);

            if (n == null)
                textBoxOutput.Text = "Данного элемента нет в таблице";
            else
            {
                textBoxOutput.Text = "[Количество сравнений при поиске] = " + _hashTable.CompareCount 
                    + Environment.NewLine + "[Элемент] = " + n.Value + Environment.NewLine + "[Код] = "
                    + _hashTable.GetHash(text) + Environment.NewLine + "[Повторения] = " + n.RepsCount;
            }
        }


        // Задание 2. Ввод
        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            int size;

            try
            {
                size = Convert.ToInt32(textBoxTableSize.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }

            _hashTable = new HashTable(size);

            string row;

            try
            {
                StreamReader sr = new StreamReader("textexample.txt");
                row = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }

            string[] input = row.Trim().Split(' ', '\r', '\n', '.', ',', ';', '—', ':', '(', ')');

            foreach (string s in input)
            {
                if (!string.IsNullOrWhiteSpace(s) && (s[0] >= 'а' && s[0] <= 'я' || s[0] >= 'a' && s[0] <= 'z'))
                {
                    _hashTable.Add(s.ToLowerInvariant(), _hashTable.GetHash(s[0].ToString()));
                }
            }

            textBoxOutput.Text = "[Количество сравнений при хешировании] = " + _hashTable.CompareCount + Environment.NewLine + _hashTable.Print();
        }

        // Задание 2. Удаление
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string input = textBoxLetter2.Text;

            Node n = _hashTable.Find(_hashTable.GetHash(input[0].ToString()));

            while (n != null)
            {
                if (n.Value[0] == input[0])
                {
                    _hashTable.Remove(n.Value, _hashTable.GetHash(n.Value[0].ToString()), true);
                }
                n = n.Next;
            }


            textBoxOutput.Text = _hashTable.Print();
        }

        // Задание 2. Поиск
        private void buttonFind2_Click(object sender, EventArgs e)
        {
            string text = textBoxLetter3.Text;

            Node n = _hashTable.Find(_hashTable.GetHash(text[0].ToString()), text);

            if (n == null)
                textBoxOutput.Text = "Данного элемента нет в таблице";
            else
            {
                textBoxOutput.Text = "[Количество сравнений при поиске] = " + _hashTable.CompareCount + Environment.NewLine 
                    + "[Элемент] = " + n.Value + Environment.NewLine + "[Код] = "
                    + _hashTable.GetHash(text[0].ToString()) + Environment.NewLine + "[Повторения] = " + n.RepsCount;
            }
        }


        // Задание 3. Ввод (50 элементов)
        private void   buttonAddN1_Click(object sender, EventArgs e)
        {
            AddNums("nums_1.txt");
        }

        // Задание 3. Ввод (200 элементов)
        private void buttonAddN2_Click(object sender, EventArgs e)
        {
            AddNums("nums_2.txt");
        }

        // Задание 3. Ввод (1000 элементов)
        private void buttonAddN3_Click(object sender, EventArgs e)
        {
            AddNums("nums_3.txt");
        }

        private void AddNums(string filename)
        {
            _hashTable = new HashTable(50);

            string row;

            try
            {
                StreamReader sr = new StreamReader(filename);
                row = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }

            string[] input = row.Trim().Split(' ', '\r', '\n');

            foreach (string s in input)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    _hashTable.Add(s);
                }
            }

            textBoxOutput.Text = "[Количество сравнений при хешировании] = " + _hashTable.CompareCount + Environment.NewLine + _hashTable.Print();
        }
        
        // Задание 3. Поиск
        private void buttonFind3_Click(object sender, EventArgs e)
        {
            Find(textBoxFind3.Text);
        }
    }


    public class HashTable
    {
        private Dictionary<int, Node> _table;
        public int TableSize { get; private set; }

        public int CompareCount { get; private set; } = 0;

        public HashTable(int size)
        {
            TableSize = size;

            _table = new Dictionary<int, Node>();
        }

        public int GetHash(string el)
        {
            return Math.Abs(el.GetHashCode() % TableSize);
        }

        public void Add(string el, int hash)
        {
            Node tableEl = null;
            _table.TryGetValue(hash, out tableEl);

            if (tableEl == null)
            {
                _table[hash] = new Node(el);
                return;
            }

            // Проход по цепочке, поиск и вставка нового элемента
            while (tableEl.Next != null)
            {
                CompareCount++;
                if (tableEl.Value == el)
                {

                    tableEl.RepsCount++;
                    return;
                }

                tableEl = tableEl.Next;
            }

            CompareCount++;
            if (tableEl.Value == el)
            {
                tableEl.RepsCount++;
            }
            else
            {
                tableEl.Next = new Node(el);
            }
        }
        public void Add(string el)
        {
            int hash = GetHash(el);

            Add(el, hash);
        }
        
        public Node Find(string el)
        {
            Node found = null;
            CompareCount = 0;


            _table.TryGetValue(GetHash(el), out found);

            while (found != null && found.Value != el)
            {
                CompareCount++;
                found = found.Next;
            }

            return found;
        }
        public Node Find(int hash, string el = "")
        {
            Node found = null;
            CompareCount = 0;

            _table.TryGetValue(hash, out found);

            if(el != "")
            {
                while(found != null && found.Value != el)
                {
                    CompareCount++;
                    found = found.Next;
                }
            }

            return found;
        }

        public void Remove(string el, int hash, bool all)
        {
            Node found = null;
            _table.TryGetValue(hash, out found);

            if (found == null)
                return;

            if (found.Value == el)
                _table[hash] = found.Next;

            while(found.Next != null)
            {
                if (found.Next.Value == el)
                {

                    // Удаляет 1 вхождение, либо весь Node
                    if (all)
                        found.Next = found.Next.Next;
                    else
                    {
                        found.Next.RepsCount--;

                        if (found.Next.RepsCount == 0)
                            found.Next = found.Next.Next;
                    }
                    return;
                }

                found = found.Next;
            }

        }

        public string Print ()
        {
            string output = "";
            Node el = null;

            for (int i = 0; i < TableSize; i++)
            {
                _table.TryGetValue(i, out el);
                if (el == null)
                {
                    continue;
                }
                else
                    output += "[Ключ] = " + i + " [Значения] = " + el.Value;

                Node n = _table[i].Next;

                while (n != null)
                {
                    output += ", " + n.Value;
                    n = n.Next;
                }

                output += ";" + Environment.NewLine;
            }

            return output;
        }
    }

    public class Node
    {
        public Node Next { get; set; } = null;
        public string Value { get; private set; }
        public int RepsCount { get; set; } = 1;

        public Node(string value)
        {
            Value = value;
        }

    }

}
