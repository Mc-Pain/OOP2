using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Lall> container_ = new List<Lall>(); //наш контейнер

        int checktype(string a, string b)
        { //проверка на число аргументов
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

        void Extract(Lall current)
        { //извлечение элементов
            Statelabel.Text = "Извлеченные элементы:\n";
            if (current.Get_Count() == 1)
            {
                Statelabel.Text += String.Format("{0}: {1}\n", current.Get_Type(), current.Get());
            }
            if (current.Get_Count() == 2)
            {
                Statelabel.Text += String.Format("{0}: {1}\n", current.Get_Type(0), current.Get(0));
                Statelabel.Text += String.Format("{0}: {1}\n", current.Get_Type(1), current.Get(1));
            }
        }

        Lelement Parse(string string_)
        {
            int temp_int;
            double temp_double;
            if (!int.TryParse(string_, out temp_int))
            { //это не int
                if (!double.TryParse(string_, out temp_double))
                { //это не double
                    Statelabel.Text += String.Format("Строка: {0}\n", string_);
                    return new Lstring(string_);
                }
                else
                { //это double
                    Statelabel.Text += String.Format("Число с плавающей запятой: {0}\n", temp_double);
                    return new Ldouble(temp_double);
                }
            }
            else
            { //это int
                Statelabel.Text += String.Format("Целое число: {0}\n", temp_int);
                return new Lint(temp_int);
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Statelabel.Text = "";
            if (checktype(First_textbox.Text, Second_textbox.Text) == 0)
                Statelabel.Text = "Оба поля пусты. Добавлять нечего";
            if (checktype(First_textbox.Text, Second_textbox.Text) == 1)
            { //только один аргумент
                Statelabel.Text += String.Format("Добавленные элементы:\n");
                Lall element = Parse(First_textbox.Text);
                container_.Add(element);
                ElementsCombo.Items.Add(string.Format("{0}", element.Get()));
            }
            if (checktype(First_textbox.Text, Second_textbox.Text) == 2)
            { //два аргумента
                Lelement first, second;

                Statelabel.Text += String.Format("Добавленные элементы:\n");
                first = Parse(First_textbox.Text);
                second = Parse(Second_textbox.Text);

                Lall element = new Lstruct2(first, second);
                container_.Add(element);
                ElementsCombo.Items.Add(string.Format("{0}, {1}", element.Get(0), element.Get(1)));
            }
        }

        private void Extractbtn_Click(object sender, EventArgs e)
        {
            if (ElementsCombo.SelectedIndex == -1)
            {
                Statelabel.Text = String.Format("Ничего не выбрано");
            }
            else
            {
                Extract(container_.ElementAt<Lall>(ElementsCombo.SelectedIndex));
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            Statelabel.Text = "";
            if (checktype(First_textbox.Text, Second_textbox.Text) == 0)
                Statelabel.Text = "Оба поля пусты. Искать нечего";
            if (checktype(First_textbox.Text, Second_textbox.Text) == 1)
            { //проверяем поиск: один аргумент
                Statelabel.Text += String.Format("Цель поиска:\n");
                Lelement search = Parse(First_textbox.Text);
                foreach (Lall element in container_)
                {
                    if (element.Get_Count() == 1 && search == (Lelement)element)
                    {
                        count++;
                    }
                }
                Statelabel.Text += String.Format("Объектов найдено: {0}", count);
            }
            if (checktype(First_textbox.Text, Second_textbox.Text) == 2)
            { //проверяем поиск: два аргумента
                Lelement first, second;

                Statelabel.Text += String.Format("Цель поиска:\n");
                first = Parse(First_textbox.Text);
                second = Parse(Second_textbox.Text);

                Lstruct2 search = new Lstruct2(first, second);
                foreach (Lall element in container_)
                {
                    if (element.Get_Count() == 2 && search == (Lstruct2)element)
                    {
                        count++;
                    }
                }
                Statelabel.Text += String.Format("Объектов найдено: {0}", count);
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            if (ElementsCombo.SelectedIndex == -1)
            { //пользователь ничего не выбрал
                Statelabel.Text = String.Format("Ничего не выбрано");
            }
            else
            { //пользователь что-то выбрал
                if (ElementsCombo.SelectedIndex > 0)
                { //листаем влево
                    ElementsCombo.SelectedIndex--;
                    Extract(container_.ElementAt<Lall>(ElementsCombo.SelectedIndex));
                }
                else
                { //не листаем - выгли на границу контейнера
                    if (ElementsCombo.SelectedIndex == 0)
                    {
                        Extract(container_.ElementAt<Lall>(ElementsCombo.SelectedIndex));
                        Statelabel.Text += String.Format("Выход за границы массива");
                    }
                }
            }
        }

        private void Fwdbtn_Click(object sender, EventArgs e)
        {
            if (ElementsCombo.SelectedIndex == -1)
            { //ничего не выбрано
                Statelabel.Text = String.Format("Ничего не выбрано");
            }
            else
            { //что-то выбрано
                if (ElementsCombo.SelectedIndex < container_.Count() - 1)
                { //листаем вперед
                    ElementsCombo.SelectedIndex++;
                    Extract(container_.ElementAt<Lall>(ElementsCombo.SelectedIndex));
                }
                else
                { //не листаем, ибо граница
                    Extract(container_.ElementAt<Lall>(ElementsCombo.SelectedIndex));
                    Statelabel.Text += String.Format("Выход за границы массива");
                }
            }
        }

        private void descbtn_Click(object sender, EventArgs e)
        {
            int swaps = 0;
            int Nelements = container_.Count();
            Lstruct2 cmp_first, cmp_second;
            do
            {
                swaps = 0;
                for (int i = 0; i < Nelements - 1; i++)
                {
                    if (container_.ElementAt(i).Get_Count() == 1)
                    { //приводим к типу "структура" для сравнения
                        cmp_first = new Lstruct2((Lelement)container_.ElementAt(i), new Lstring());
                    }
                    else
                    { //это и так структура, так что кастуем и присваиваем
                        cmp_first = (Lstruct2)container_.ElementAt(i);
                    }
                    for (int j = i + 1; j < Nelements; j++)
                    {
                        if (container_.ElementAt(j).Get_Count() == 1)
                        { //приводим к типу "структура" для сравнения
                            cmp_second = new Lstruct2((Lelement)container_.ElementAt(j), new Lstring());
                        }
                        else
                        {//это и так структура, так что кастуем и присваиваем
                            cmp_second = (Lstruct2)container_.ElementAt(j);
                        }
                        //а теперь сравнение
                        if (cmp_first < cmp_second)
                        {
                            container_.Insert(i, container_.ElementAt(j));
                            ElementsCombo.Items.Insert(i, ElementsCombo.Items[j]);
                            container_.RemoveAt(j + 1);
                            ElementsCombo.Items.RemoveAt(j + 1);
                            swaps++;
                        }
                    }
                }
            } while (swaps != 0);
            Statelabel.Text = "Контейнер отсортирован по убыванию";
        }

        private void ascbtn_Click(object sender, EventArgs e)
        {
            int swaps = 0;
            int Nelements = container_.Count();
            Lstruct2 cmp_first, cmp_second;
            do
            {
                swaps = 0;
                for (int i = 0; i < Nelements; i++)
                {
                    if (container_.ElementAt(i).Get_Count() == 1)
                    { //не структура
                        cmp_first = new Lstruct2((Lelement)container_.ElementAt(i), new Lstring());
                    }
                    else
                    { //это и так структура, так что кастуем и присваиваем
                        cmp_first = (Lstruct2)container_.ElementAt(i);
                    }
                    for (int j = i + 1; j < Nelements; j++)
                    {
                        if (container_.ElementAt(j).Get_Count() == 1)
                        { //не структура
                            cmp_second = new Lstruct2((Lelement)container_.ElementAt(j), new Lstring());
                        }
                        else
                        { //это и так структура, так что кастуем и присваиваем
                            cmp_second = (Lstruct2)container_.ElementAt(j);
                        } 
                        //а теперь сравнение
                        if (cmp_first > cmp_second)
                        {
                            container_.Insert(i, container_.ElementAt(j));
                            ElementsCombo.Items.Insert(i, ElementsCombo.Items[j]);
                            container_.RemoveAt(j + 1);
                            ElementsCombo.Items.RemoveAt(j + 1);
                            swaps++;
                        }
                    }
                }
            } while (swaps != 0);
            Statelabel.Text = "Контейнер отсортирован по возрастанию";
        }

        private void deldblbtn_Click(object sender, EventArgs e)
        {
            int dels = 0;
            int Nelements = container_.Count();
            Lstruct2 cmp_first, cmp_second;
            do
            {
                dels = 0;
                for (int i = 0; i < Nelements; i++)
                {
                    if (container_.ElementAt(i).Get_Count() == 1)
                    { //не структура
                        cmp_first = new Lstruct2((Lelement)container_.ElementAt(i), new Lstring());
                    }
                    else
                    { //это и так структура, так что кастуем и присваиваем
                        cmp_first = (Lstruct2)container_.ElementAt(i);
                    }
                    for (int j = i + 1; j < Nelements; j++)
                    {
                        if (container_.ElementAt(j).Get_Count() == 1)
                        { //не структура
                            cmp_second = new Lstruct2((Lelement)container_.ElementAt(j), new Lstring());
                        }
                        else
                        { //это и так структура, так что кастуем и присваиваем
                            cmp_second = (Lstruct2)container_.ElementAt(j);
                        }
                        //а теперь сравнение
                        if (cmp_first == cmp_second)
                        {
                            container_.RemoveAt(j);
                            ElementsCombo.Items.RemoveAt(j);
                            Nelements--;
                            dels++;
                        }
                    }
                }
            } while (dels != 0);

        }

        private void countbtn_Click(object sender, EventArgs e)
        {
            Statelabel.Text = string.Format("Количество элементов: {0}", container_.Count());
        }

        private void dumpbtn_Click(object sender, EventArgs e)
        {
            string path = "data.txt";
            try
            {
                StreamWriter file = File.CreateText(path);
                foreach (Lall element in container_)
                { //пишем ВСЁ
                    if (element.Get_Count() == 1)
                    {
                        file.WriteLine("{0}", element.Get());
                    }
                    if (element.Get_Count() == 2)
                    {
                        file.WriteLine("{0}\t{1}", element.Get(0), element.Get(1));
                    }
                }
                file.Close();
            }
            catch (System.IO.IOException)
            {
                Statelabel.Text = "Ошибка ввода-вывода";
            }
            Statelabel.Text = "Список успешно сохранён";
        }

        private void restorebtn_Click(object sender, EventArgs e)
        {
            string path = "data.txt";
            string[] a;
            try
            {
                StreamReader file = new StreamReader(path);
                container_.Clear();
                while (!file.EndOfStream)
                { //читаем до конца файла
                    a = file.ReadLine().Split('\t');
                    if (a.Count() == 1)
                    { //табов нет
                        Lall element = Parse(a[0]);
                        container_.Add(element);
                        ElementsCombo.Items.Add(string.Format("{0}", element.Get()));
                    }
                    else
                    {
                        if (a.Count() == 2)
                        { //опа, табы
                            Lelement first, second;

                            first = Parse(a[0]);
                            second = Parse(a[1]);

                            Lall element = new Lstruct2(first, second);
                            container_.Add(element);
                            ElementsCombo.Items.Add(string.Format("{0}, {1}", element.Get(0), element.Get(1)));
                        }
                        else //кто-то ручками влез в файл
                        {
                            throw new Exception("corruption");
                        }
                    }
                }
                Statelabel.Text = "Список успешно восстановлен";
                file.Close();
            }
            //что-то пошло не так, не паникуем
            catch (System.IO.FileNotFoundException)
            {
                Statelabel.Text = "Файл не найден";
            }
            catch (System.IO.IOException)
            {
                Statelabel.Text = "Ошибка ввода/вывода";
            }
            catch (Exception)
            {

            }
        }
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
        //перегрузка операторов: сравнение отдельных элементов
        public static bool operator >(Lelement element1, Lelement element2)
        {
            if (string.Compare(Convert.ToString(element1.Get()), Convert.ToString(element2.Get())) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Lelement element1, Lelement element2)
        {
            if (string.Compare(Convert.ToString(element1.Get()), Convert.ToString(element2.Get())) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Lelement element1, Lelement element2)
        {
            if (string.Compare(Convert.ToString(element1.Get()), Convert.ToString(element2.Get())) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Lelement element1, Lelement element2)
        {
            if (string.Compare(Convert.ToString(element1.Get()), Convert.ToString(element2.Get())) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
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
            return null; //заглушка
        }
        public override string Get(int i) //Получение значения
        {
            return null; //заглушка
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

        public override string Get() //Получение значения
        {
            return Convert.ToString(number);
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
            return null; //заглушка
        }
        public override string Get(int i) //Получение значения
        {
            return null; //заглушка
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

        public override string Get() //Получение значения
        {
            return Convert.ToString(this.number);
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
            return null; //заглушка
        }
        public override string Get(int i) //Получение значения
        {
            return null; //заглушка
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

        public override string Get()
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
            return null; //заглушка
        }
        public override string Get() //Получение значения
        {
            return null; //заглушка
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

        public Lelement Get_(int i)
        {
            if (i == 0)
            {
                return first;
            }
            else if (i == 1)
            {
                return second;
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

        //сравнение структур
        public static bool operator >(Lstruct2 element1, Lstruct2 element2)
        {
            if (element1.Get_(0) > element2.Get_(0))
            {
                return true;
            }
            else if (element1.Get_(0) == element2.Get_(0) && element1.Get_(1) > element2.Get_(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Lstruct2 element1, Lstruct2 element2)
        {
            if (element1.Get_(0) < element2.Get_(0))
            {
                return true;
            }
            else if (element1.Get_(0) == element2.Get_(0) && element1.Get_(1) < element2.Get_(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Lstruct2 element1, Lstruct2 element2)
        {
            if (!(element1 < element2 || element1 > element2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Lstruct2 element1, Lstruct2 element2)
        {
            if (element1 < element2 || element1 > element2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
