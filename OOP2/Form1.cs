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
    public class Lelement //абстрактный класс элемента контейнера - число либо строка
    {
        public abstract void* GetPtr(); //возвращает указатель на экземпляр классов-потомков, метод будет перекрыт
    };

    public class Lnumber : Lelement //число - абстрактный класс. Мы не знаем, что там будет: int или double
    {
        //Тут ничего нет... Пока что
    }

    public class Lint : Lnumber
    {
        int number;

        public Lint(); //нуль-конструктор
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
        public Lint GetPtr()
        {
            return this;
        }
    }

    public class Ldouble : Lnumber
    {
        double number;

        public Ldouble(); //нуль-конструктор
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
        public Ldouble GetPtr()
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
