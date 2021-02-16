using System;
using System.Windows.Forms;

namespace lab1_strings
{
    public partial class FormStringReplace : Form
    {
        private char[] _firstAlphabet, _secondAlphabet;

        private string _modifiedString;
        public FormStringReplace()
        {
            InitializeComponent();
        }

        // Вызывается событием нажатия кнопки "Заменить"
        // и преобразует строку
        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (!ParseAlphabets())
                return;

            // Преобразование строки

            char[] inputSting = textBoxInput.Text.ToCharArray();

            for(int i = 0; i < inputSting.Length; i++)
            {
                for(int j = 0; j < _firstAlphabet.Length; j++)
                {
                    if(inputSting[i] == _firstAlphabet[j])
                    {
                        inputSting[i] = _secondAlphabet[j];
                        break;
                    }
                        
                }
            }

            _modifiedString = new string(inputSting);

            textBoxOutput.Text = _modifiedString;

            MessageBox.Show("Строка преобразована успешно\n", "Успех");
        }


        // Преобразует строки, введенные в первые 2 поля в алфавиты
        // Возвращает true при успешном преобразовании и false при ошибке
        private bool ParseAlphabets()
        {
            string[] firstAlphabetUnparsed, secondAlphabetUnparsed;

            firstAlphabetUnparsed = textBoxFirstAlphabet.Text.Trim().Split(' ');
            secondAlphabetUnparsed = textBoxSecondAlphabet.Text.Trim().Split(' ');

            if(string.IsNullOrWhiteSpace(textBoxFirstAlphabet.Text))
            {
                MessageBox.Show("Введен пустой алфавит", "Ошибка");
                return false;
            }

            if (firstAlphabetUnparsed.Length != secondAlphabetUnparsed.Length)
            {
                MessageBox.Show("Введены алфавиты разной длины,\nлибо введен двойной символ пробела", "Ошибка");
                return false;
            }

            _firstAlphabet = new char[firstAlphabetUnparsed.Length];
            _secondAlphabet = new char[secondAlphabetUnparsed.Length];

            for (int i = 0; i < firstAlphabetUnparsed.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(firstAlphabetUnparsed[i]) || string.IsNullOrWhiteSpace(secondAlphabetUnparsed[i]))
                {
                    MessageBox.Show("Введен двойной символ пробела", "Ошибка");
                    return false;
                }

                if (firstAlphabetUnparsed[i].Length > 1 || secondAlphabetUnparsed[i].Length > 1)
                {
                    MessageBox.Show("Элемент алфавита содержит больше одного символа", "Ошибка");
                    return false;
                }

                _firstAlphabet[i] = firstAlphabetUnparsed[i][0];
                for(int j = 0; j < i; j++)
                {
                    if(_firstAlphabet[j] == _firstAlphabet[i])
                    {
                        MessageBox.Show("Обнаружен повторяющийся символ в первом алфавите", "Ошибка");
                        return false;
                    }

                }

                _secondAlphabet[i] = secondAlphabetUnparsed[i][0];
            }

            return true;
        }
    }
}
