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

        /* TODO:
         * Запилить класс "Элемент контейнера"
         * Запилить производные классы "число", "строка", "структура {элемент, элемент}" - инсепшон!
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

}
