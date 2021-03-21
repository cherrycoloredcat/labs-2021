using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linked_list
{

    public partial class Form1 : Form
    {
        private readonly LinkedList _linkedList = new LinkedList();

        public Form1()
        {
            InitializeComponent();

            _linkedList.PrintList(textBoxList, Convert.ToInt32(textBoxMaxWeight.Text));
        }

        // Добавление в конец списка нового элемента
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxNum.Text.Trim()) 
                || string.IsNullOrEmpty(textBoxPlace.Text.Trim()) 
                || string.IsNullOrEmpty(textBoxSecondName.Text.Trim()) 
                || string.IsNullOrEmpty(textBoxAmount.Text.Trim())
                || string.IsNullOrEmpty(textBoxWeight.Text.Trim()))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка");
                return;
            }
            try
            {
                _linkedList.AddNode(new Node(
                    Convert.ToInt32(textBoxNum.Text),
                    dateTimePicker1.Value,
                    textBoxPlace.Text,
                    textBoxSecondName.Text,
                    Convert.ToInt32(textBoxAmount.Text),
                    Convert.ToInt32(textBoxWeight.Text)));

                _linkedList.PrintList(textBoxList, Convert.ToInt32(textBoxMaxWeight.Text));
            }
            catch
            {
                MessageBox.Show("Поля содержат неверный формат", "Ошибка");
                return;
            }
            
        }

        // Сортировка по дате
        private void buttonSortDate_Click(object sender, EventArgs e)
        {
            _linkedList.Sort(LinkedList.SortType.Date);
            _linkedList.PrintList(textBoxList, Convert.ToInt32(textBoxMaxWeight.Text));
        }

        // Сортировка по пункту назначения
        private void buttonSortPlace_Click(object sender, EventArgs e)
        {
            _linkedList.Sort(LinkedList.SortType.Place);
            _linkedList.PrintList(textBoxList, Convert.ToInt32(textBoxMaxWeight.Text));
        }

        // Поиск по дате
        private void buttonFindDate_Click(object sender, EventArgs e)
        {
            _linkedList.PrintList(textBoxList, Convert.ToInt32(textBoxMaxWeight.Text), dateTimePicker2.Value.Date);
        }

        // Поиск по пункту назначения
        private void buttonFindPlace_Click(object sender, EventArgs e)
        {
            _linkedList.PrintList(textBoxList, Convert.ToInt32(textBoxMaxWeight.Text), null, textBoxSearchPlace.Text);
        }

        // Показать все записи
        private void buttonReset_Click(object sender, EventArgs e)
        {
            _linkedList.PrintList(textBoxList, Convert.ToInt32(textBoxMaxWeight.Text));
        }
    }

    public class LinkedList
    {
        public Node first;

        public void AddNode(Node node)
        {
            if (first == null)
            {
                first = node;
            }
            else
            {
                Node current = first;
                while (current.Next != null)
                    current = current.Next;

                current.SetNext(node);
            }
        }

        public void PrintList(TextBox tb, int maxWeight, DateTime? date = null, string place = null)
        {
            Node current = first;
            tb.Text = "";

            while(current != null)
            {
                if ((!date.HasValue || date.Value.Date == current.DateTime.Date) && (place == null || place == current.Place))
                {
                    tb.Text += current.ToString();
                    if (maxWeight < current.LuggageWeight)
                        tb.Text += " (максимальный вес превышен)";
                    tb.Text += Environment.NewLine;
                }
                current = current.Next;
            }
        }

        public enum SortType
        {
            Date,
            Place
        }

        public void Sort(SortType type)
        {
            bool unsorted = true;

            Node tmp = null, iPrevious = null, i, j;

            while(unsorted) {
                if (first == null)
                    return;

                unsorted = false;
                i = first;
                j = first.Next;
                iPrevious = null;

                while (j != null)
                {

                    Console.WriteLine("a");

                    if (type == SortType.Date && i.DateTime > j.DateTime
                        || type == SortType.Place && i.Place.CompareTo(j.Place) > 0)
                    {
                        if (iPrevious == null)
                            first = j;
                        else
                            iPrevious.SetNext(j);

                        i.SetNext(j.Next);
                        j.SetNext(i);

                        tmp = i;
                        i = j;
                        j = tmp;

                        unsorted = true;
                    }

                    iPrevious = i;
                    i = i.Next;
                    j = j.Next;

                }
            }
        }

    }
    public class Node
    {
        public int FlightNumber { get; }
        public DateTime DateTime { get; }
        public string Place { get; }
        public string SecondName { get; }
        public int LuggageAmount { get; }
        public int LuggageWeight { get; }
        public Node Next { get; private set; }

        public Node(int flightNumber, DateTime dateTime, string place, string secondName, int luggageAmount, int luggageWeight)
        {
            FlightNumber = flightNumber;
            DateTime = dateTime;
            Place = place;
            SecondName = secondName;
            LuggageAmount = luggageAmount;
            LuggageWeight = luggageWeight;
        }

        public void SetNext(Node node)
        {
            Next = node;
        }

        public override string ToString()
        {
            return FlightNumber + " || " + DateTime.ToString() + " || " + Place + " || " + SecondName + " || " + LuggageAmount + " || " + LuggageWeight;
        }

    }

}
