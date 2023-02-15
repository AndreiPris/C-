using System;
using System.Runtime.InteropServices;

class Program
{
    string name = "";
    float price;
    byte ingredients;
    ushort degree;
    double volume;

    Program()
    {
        name = "SexOnTheBeach";
        price = 10f;
        ingredients = 4;
        degree = 40;
        volume = 0.2;
    }
    Program(float price, double volume)
    {
        name = "BlodyMary";
        this.price = price;
        ingredients = 5;
        degree = 60;
        this.volume = volume;
    }
    Program(Program clon)
    {
        name = clon.name;
        price = clon.price;
        ingredients = clon.ingredients;
        degree = clon.degree;
        volume = clon.volume;
    }

    void print()
    {
        Console.WriteLine("Cocktail: {0}, Price: {1}, Amount of Ingridients: {2}, Degree: {3}, Volume: {4}",
        name, price, ingredients, degree, volume);
    }

    void randomize()
    {
        //name = ;\
        Random R = new Random();
        price = R.Next(5, 21);
        ingredients = (byte)R.Next(1, 6);
        degree = (ushort)R.Next(20, 81);
        volume = (double)R.Next(10) / 10;

    }

    void input()
    {
        Console.WriteLine("Enter name of the coctale");
        name = Console.ReadLine();
        Console.WriteLine("Enter price");
        price = (float)Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number of ingredients");
        ingredients = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter cocktail degree");
        degree = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine("Enter cocktail volume");
        volume = Convert.ToDouble(Console.ReadLine());
    }

    public static void Main()
    {
        Program S = new Program();
        Program B = new Program(15f, 0.5d);
        Program clon = new Program(S);

        S.print();
        B.print();
        clon.print();

        S.randomize();
        S.print();

        S.input();
        S.print();

    }
    // Описать нвый класс, Коктель с полями стринг , float цена коктеля, byte количество ингридиентов, UnsignShort градус, duble обыем коктеля.
    // Для него создаем конструктор и 3 разных конструктора с пораметрами и конструктр копирования.
    // описываем функцию принт коктеля, Функцию войд  инпут коктль которая считывает с клавиатуры,
    // Функция коктель randomize случайны значения во все поля коктеля
    // Клиент которая принемает параметры значения float количество денег клиента функция длолжна посчитать сможет ли клиен выаить коктель.
    // ть функцию main  создаем 5 обыектов разными конструкторами каждый коктель вывести на экран,  

}