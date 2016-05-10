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

        List<Lall> container = new List<Lall>(); //наш контейнер

        int checktype(string a, string b)
        {
            if (a == "" && b == "")
                return 0;
            if (a == "" && b != "")
            {
                string c = First_textbox.Text;
                First_textbox.Text = Second_textbox.Text;
                Second_textbox.Text = c;
                return 1;
            }
            if (b == "")
            {
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
                        Statelabel.Text = String.Format("Добавленные элементы:\nСтрока: {0}", First_textbox.Text);
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
                // Быдлокод тайм! TODO: оформить в функцию

                if (!int.TryParse(First_textbox.Text, out temp_int))
                { //это не int
                    if (!double.TryParse(First_textbox.Text, out temp_double))
                    { //это не double
                        first = new Lstring(First_textbox.Text);
                        Statelabel.Text = String.Format("Добавленные элементы:\nСтрока: {0}", First_textbox.Text);
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
                        Statelabel.Text += String.Format("Строка: {0}", Second_textbox.Text);
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

        private void Extractbtn_Click(object sender, EventArgs e)
        {
            Lall current = container.ElementAt<Lall>(ElementsCombo.SelectedIndex);
            Statelabel.Text = "Извлеченные элементы:\n";
            if (current.Get_Count() == 1)
            {
                Statelabel.Text += String.Format("{0}: {1}\n", current.Get_Type(), current.Get());
            }
            if (current.Get_Count() == 2)
            {
                Statelabel.Text += String.Format("{0}: {1}\n", current.Get_Type(0), current.Get(0));
                Statelabel.Text += String.Format("{0}: {1}", current.Get_Type(1), current.Get(1));
            }
        }

        /* TODO:
         * Организовать извлечение элементов из контейнера
         * */
    }

    public abstract class Lall //абстрактный класс элементов и структур элементов
    {
        public abstract int Get_Count();
        public abstract string Get(); //возвращает значение
        public abstract string Get_Type();
        public abstract string Get(int i); //возвращает значение
        public abstract string Get_Type(int i);
    }

    public abstract class Lelement : Lall //абстрактный класс элемента контейнера - число либо строка
    {

    }

    public abstract class Lnumber : Lelement //число - абстрактный класс. Мы не знаем, что там будет: int или double
    {

    }

    public class Lint : Lnumber
    {
        int number;
        int elements = 1;
        string type = "Целое число";

        public override int Get_Count()
        {
            return elements;
        }

        public override string Get_Type()
        {
            return type;
        }

        public override string Get_Type(int i)
        {
            return null;
        }
        public override string Get(int i) //Получение значения
        {
            return null;
        }

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
        public int GetVal()
        {
            return this.number;
        }
    }

    public class Ldouble : Lnumber
    {
        double number;
        int elements = 1;
        string type = "Число с плавающей запятой";

        public override int Get_Count()
        {
            return elements;
        }

        public override string Get_Type()
        {
            return type;
        }

        public override string Get_Type(int i)
        {
            return null;
        }
        public override string Get(int i) //Получение значения
        {
            return null;
        }

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
        public double GetVal()
        {
            return this.number;
        }
    }

    public class Lstring : Lelement
    {
        string text;
        int elements = 1;
        string type = "Строка";

        public override int Get_Count()
        {
            return elements;
        }

        public override string Get_Type()
        {
            return type;
        }

        public override string Get_Type(int i)
        {
            return null;
        }
        public override string Get(int i) //Получение значения
        {
            return null;
        }

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
        public string GetVal()
        {
            return this.text;
        }
    }

    public class Lstruct2 : Lall
    {
        Lelement first;
        Lelement second;
        int elements = 2;

        public override int Get_Count()
        {
            return elements;
        }

        public Lstruct2(Lelement first, Lelement second)
        {
            this.first = first;
            this.second = second;
        }

        public override string Get_Type()
        {
            return null;
        }
        public override string Get() //Получение значения
        {
            return null;
        }

        public override string Get(int i)
        {
            if (i == 0)
            {
                return first.Get();
            }
            else if (i == 1)
            {
                return second.Get();
            }
            return null;
        }

        public override string Get_Type(int i)
        {
            if (i == 0)
            {
                return first.Get_Type();
            }
            else if (i == 1)
            {
                return second.Get_Type();
            }
            return null;
        }
    }
}
