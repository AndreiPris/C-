using System;
using System.Diagnostics;

class Character
{
    static string name = "";
    int weight;
    byte age;
    //float money;
    //bool gender;


    //при работе с вектором обязательно выделить пямять. тип данных при выделении  памяти всегда соответствует типу в обыявлении этого вектора 
    //int[] z;

    string[] a = new string[12];

    Character()
    {
        name = "Шдшф";
        weight = 60;
        age = 19;
    }

    Character(string name, int weight, byte age)
    {
        Character.name = name;
        this.weight = weight;
        this.age = age;
    }
    void print()
    {
        Console.WriteLine("Cocktail: {0}, Price: {1}, Amount of Ingridients: {2}",
        name, weight, age);
    }
    void printCompare()
    {
        Console.WriteLine("{0}, {1}, {2}", name, weight, age);
    }

    void compareAge(Character A)
    {
        if (this.age > A.age)
        {
            //this.age = A.age;
            Console.WriteLine("{1} > {2}", this.age, A.age);
        }
        //else
        //{
        //    Console.WriteLine("{1} < {2}", this.age, A.age);
        //}
        
    }

    static void compareAge(Character A, Character B)
    {
        if (A.weight > B.weight)
        {
            A.weight = B.weight;
            Console.WriteLine("{1} > {2}",A.weight, B.weight);
        }
        else
        {
            Console.WriteLine("{1} <= {2}", A.weight, B.weight);
        }

    }
    //инициализация только статических поле классов
    //так как на момент вызова статик конструктора еще не существует не одного обыекта следовательно вызов обычных полей не возможен
    //сктатический класс не имеет обыекта. все элементы этого класса статические тоесть вызываются от имени класса
    //

    public static void Main()
    {
        string n = "Morisio";
        int w = 20;
        byte a = 90;

        Character Taras = new Character();
        Character Ilia = new Character(n, w, a); //в этом обыект я изменил начальное значение статик переменной name и тем самым оно изменилось и в обыекте на 79 строке 

        Taras.print();
        Ilia.print();

        //Taras.compareAge(Ilia);
        //Character.compareAge(Taras, Ilia); //static

        //Character[] VoxMachin = new Character[7];
        //for(int i = 0; i < VoxMachin.Length; i++)
        //{
        //    VoxMachin[i] = new Character();
        //    VoxMachin[i].print();
        //}
        //z = new int[2];
        //z[0] = 10;
    }




} 
    //в любой обычной функции всегда есть понятие this -
    //- это объект от имени которого будет вызвана эта функция 
    //в статических функция не существует понятия This так как вызов этой функции делается не от обыекта а от класса
    // static вызывается от имени класса, а не статик от обыекта
    // статическими функциями делаются те алгоритм которых  не привязон к характеристикам обыекта 