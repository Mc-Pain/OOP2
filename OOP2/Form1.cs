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
    public abstract class Lelement //абстрактный класс элемента контейнера - число либо строка
    {
        public abstract Lelement GetInst(); //возвращает экземпляр классов-потомков, метод будет перекрыт
    };

    public abstract class Lnumber : Lelement //число - абстрактный класс. Мы не знаем, что там будет: int или double
    {
        public override abstract Lelement GetInst(); //возвращает экземпляр классов-потомков, метод будет перекрыт
    }

    public class Lint : Lnumber
    {
        int number;

        public Lint() //нуль-конструктор
        {
            number = 0;
        }
        public Lint(int num) //конструктор общего вида
        {
            number = num;
        }
        public Lint(Lint Lint_old) //Конструктор копирования
        {
            number = Lint_old.number;
        }

        public void Set(int num) //Установка значения
        {
            number = num;
        }
        public int Get() //Получение значения
        {
            return number;
        }
        public override Lelement GetInst()
        {
            return this;
        }
    }

    public class Ldouble : Lnumber
    {
        double number;

        public Ldouble() //нуль-конструктор
        {
            number = 0;
        }
        public Ldouble(double num) //конструктор общего вида
        {
            number = num;
        }
        public Ldouble(Ldouble Ldouble_old) //Конструктор копирования
        {
            number = Ldouble_old.number;
        }

        public void Set(double num) //Установка значения
        {
            number = num;
        }
        public double Get() //Получение значения
        {
            return number;
        }
        public override Lelement GetInst()
        {
            return this;
        }
    }

    public class Lstring : Lelement
    {
        string text;

        public Lstring() //конструктор по умолчанию
        {
            text = "";
        }
        public Lstring(string customtext) //конструктор общего вида
        {
            text = customtext;
        }
        public Lstring(Lstring Lstring_old) //Конструктор копирования
        {
            text = Lstring_old.text;
        }

        public void Set(string customtext)
        {
            text = customtext;
        }
        public string Get()
        {
            return text;
        }
        public override Lelement GetInst()
        {
            return this;
        }
    }

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
}
