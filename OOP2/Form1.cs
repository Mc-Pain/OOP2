using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Lelement> container = new List<Lelement>(); //наш контейнер

        int checktype(string a, string b)
        {
            if (a == "" && b == "")
                return 0;
            if (a == "" && b != "")
            {
                string c = b;
                b = a;
                a = c;
                return 1;
            }
            if (b == "")
            {
                string c = b;
                b = a;
                a = c;
                return 1;
            }
            return 2;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (checktype(First_textbox.Text, Second_textbox.Text) == 0)
                Statelabel.Text = "Оба поля пусты. Добавлять нечего";
            if (checktype(First_textbox.Text, Second_textbox.Text) == 1)
            {
                int temp_int;
                double temp_double;
                if (!int.TryParse(First_textbox.Text, out temp_int))
                { //это не int
                    if (!double.TryParse(First_textbox.Text, out temp_double))
                    { //это не double
                        container.Add(new Lstring(First_textbox.Text));
                        ElementsCombo.Items.Add(string.Format("\"{0}\"", First_textbox.Text));
                        Statelabel.Text = String.Format("Добавленные элементы:\nСтрока: \"{0}\"", First_textbox.Text);
                    }
                    else
                    { //это double
                        container.Add(new Ldouble(temp_double));
                        ElementsCombo.Items.Add(string.Format("{0}", temp_double));
                        Statelabel.Text = String.Format("Добавленные элементы:\nЧисло с плавающей запятой: {0}", temp_double);
                    }
                }
                else
                { //это int
                    container.Add(new Lint(temp_int));
                    ElementsCombo.Items.Add(string.Format("{0}", temp_int));
                    Statelabel.Text = String.Format("Добавленные элементы:\nЦелое число: {0}", temp_int);
                }
            }
            if (checktype(First_textbox.Text, Second_textbox.Text) == 2)
            {
                int temp_int, temp2_int;
                double temp_double, temp2_double;
                Lelement first, second;
                // Быдлокод тайм!

                if (!int.TryParse(First_textbox.Text, out temp_int))
                { //это не int
                    if (!double.TryParse(First_textbox.Text, out temp_double))
                    { //это не double
                        first = new Lstring(First_textbox.Text);
                        Statelabel.Text = String.Format("Добавленные элементы:\nСтрока: \"{0}\"", First_textbox.Text);
                    }
                    else
                    { //это double
                        first = new Ldouble(temp_double);
                        Statelabel.Text = String.Format("Добавленные элементы:\nЧисло с плавающей запятой: {0}", temp_double);
                    }
                }
                else
                { //это int
                    first = new Lint(temp_int);
                    Statelabel.Text = String.Format("Добавленные элементы:\nЦелое число: {0}", temp_int);
                }

                Statelabel.Text += "\n";

                if (!int.TryParse(Second_textbox.Text, out temp2_int))
                { //это не int
                    if (!double.TryParse(Second_textbox.Text, out temp2_double))
                    { //это не double
                        second = new Lstring(Second_textbox.Text);
                        Statelabel.Text += String.Format("Строка: \"{0}\"", Second_textbox.Text);
                    }
                    else
                    { //это double
                        second = new Ldouble(temp2_double);
                        Statelabel.Text += String.Format("Число с плавающей запятой: {0}", temp2_double);
                    }
                }
                else
                { //это int
                    second = new Lint(temp_int);
                    Statelabel.Text += String.Format("Целое число: {0}", temp2_int);
                }
                container.Add(new Lstruct2(first, second));
                ElementsCombo.Items.Add(string.Format("{0}, {1}", First_textbox.Text, Second_textbox.Text));
            }
        }

        /* TODO:
         * Организовать извлечение элементов из контейнера
         * */
    }

    public abstract class Lelement //абстрактный класс элемента контейнера - число либо строка
    {
        public abstract string Get(); //возвращает значение
        //public abstract void Set(); //Задает значение
    }

    public abstract class Lnumber : Lelement //число - абстрактный класс. Мы не знаем, что там будет: int или double
    {

    }

    public class Lint : Lnumber
    {
        int number;

        public Lint() //нуль-конструктор
        {
            this.number = 0;
        }
        public Lint(int num) //конструктор общего вида
        {
            this.number = num;
        }
        public Lint(Lint Lint_old) //Конструктор копирования
        {
            this.number = Lint_old.number;
        }

        public void Set(int num) //Установка значения
        {
            this.number = num;
        }
        public override string Get() //Получение значения
        {
            return Convert.ToString(this.number);
        }
    }

    public class Ldouble : Lnumber
    {
        double number;

        public Ldouble() //нуль-конструктор
        {
            this.number = 0;
        }
        public Ldouble(double num) //конструктор общего вида
        {
            this.number = num;
        }
        public Ldouble(Ldouble Ldouble_old) //Конструктор копирования
        {
            this.number = Ldouble_old.number;
        }

        public void Set(double num) //Установка значения
        {
            this.number = num;
        }
        public override string Get() //Получение значения
        {
            return Convert.ToString(this.number);
        }
    }

    public class Lstring : Lelement
    {
        string text;

        public Lstring() //конструктор по умолчанию
        {
            this.text = "";
        }
        public Lstring(string customtext) //конструктор общего вида
        {
            this.text = customtext;
        }
        public Lstring(Lstring Lstring_old) //Конструктор копирования
        {
            this.text = Lstring_old.text;
        }

        public void Set(string customtext)
        {
            this.text = customtext;
        }
        public override string Get()
        {
            return this.text;
        }
    }

    public class Lstruct2 : Lelement
    {
        Lelement first;
        Lelement second;

        public Lstruct2(Lelement first, Lelement second)
        {
            this.first = first;
            this.second = second;
        }

        //что-то тлен

        /*public override string Get()
        {
            return first.Get();
        }

        public string Get(bool t)
        {
            return second.Get();
        }*/
    }
}
