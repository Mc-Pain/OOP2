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
            }
        }

        /* TODO:
         * Организовать добавление/извлечение элементов из контейнера
         * */
    }

    public abstract class Lelement //абстрактный класс элемента контейнера - число либо строка
    {
        //public abstract void Get(); //возвращает значение
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
        public int Get() //Получение значения
        {
            return this.number;
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
        public double Get() //Получение значения
        {
            return this.number;
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
        public string Get()
        {
            return this.text;
        }
    }

    public class Lstruct2 : Lelement
    {
        Lelement first;
        Lelement second;

        //щас будет быдлокод
        public Lstruct2(int first, int second)
        {
            this.first = new Lint(first);
            this.second = new Lint(second);
        }
        public Lstruct2(int first, double second)
        {
            this.first = new Lint(first);
            this.second = new Ldouble(second);
        }
        public Lstruct2(int first, string second)
        {
            this.first = new Lint(first);
            this.second = new Lstring(second);
        }

        public Lstruct2(double first, int second)
        {
            this.first = new Ldouble(first);
            this.second = new Lint(second);
        }
        public Lstruct2(double first, double second)
        {
            this.first = new Ldouble(first);
            this.second = new Ldouble(second);
        }
        public Lstruct2(double first, string second)
        {
            this.first = new Ldouble(first);
            this.second = new Lstring(second);
        }

        public Lstruct2(string first, int second)
        {
            this.first = new Lstring(first);
            this.second = new Lint(second);
        }
        public Lstruct2(string first, double second)
        {
            this.first = new Lstring(first);
            this.second = new Ldouble(second);
        }
        public Lstruct2(string first, string second)
        {
            this.first = new Lstring(first);
            this.second = new Lstring(second);
        }
    }
}
