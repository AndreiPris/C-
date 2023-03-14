//ООП - Обыектно Ориентированное програмирование 
//1) Инкопсуляция - принцып который рассматривает каждый клаас как "черный ящик" содержимое которого по кмолчанию не доступно некомку из вне класса 
//2) Наследование - при носледовании в класс наследник копируется все содержимое класса родителя. цель структурировать проэкт.(в с шарпе убрали множественное наследованние из за правила ромба)
//  2.1 UpCast -
//  2.2 Agregation/Segregation -
//3) Полиморфизм - 
using System;

//class oop
//{
//    public int i = 10;
//    public void printInt(int a)
//    {
//        Console.WriteLine("{0}", a);

//    }
//}

//class test : oop
//{

//    public static void Main()
//    {
//        int q = 5;
//        oop num = new oop();
//        num.printInt(q);
//        //num.i = q;
//    }
//}


class Human
{
    public string name = "";
    public int weight;
    public int age;
    public Human()
    {
        name = "Jora";
        age = 18;
        weight = 60;
    }

    public Human(string name, int weight, int age)
    {
        this.name = name;
        this.weight = weight;
        this.age = age;
    }

    public virtual void print()
    {
        Console.WriteLine("Name: {0}, Age: {1}, Weight: {2}", name, age, weight);
    }

    public void main()
    {
        Human human = new Human();
        human.print();
    }
}

class Man : Human
{
    public bool beard;
    public Man()
    {
        beard = true;
        name = "Aboba";
        age = 23;
        weight = 500;
    }

    //public Man(bool beard) : base(name, age)
    //{
    //}
    public override void print()
    {
        Console.WriteLine();
    }
    
    public static void Main()
    {
        Human human = new Human();
        Human human1 = new Man();
        human.print();
        human1.print();
    }
}

class start
{
    public static void main()
    {   
        Man aboba = new Man();
        aboba.print();
    }
}

//abstract class Person { 

//}


abstract class Entity : Human, Itest // Entity VOva = new Entity(); - not allowd
{
    //public static void Main()
    //{
    //    //Entity human = new Human();
    //}
    public abstract void forTest(); // не может быть приватной 
        // в обычном классе не могут находится абстрактные функции


    // обстарктные функции обязательно надо переопределять во всех наследованных, НЕобстрактных классах 

}
    // INTERFACE острактный класс отличия от интерфейсов: Отличия - 1) для интрефейсов есть множественное наследование 2) интерфейс не может содержать не острактные функции
    // Сходства - оба не могут иметь обыектов, оба могут содержать обстрактные функции.
    interface Itest 
{
    static int number;
    const float random = 0f;
    //abstract void m();
} // инетфесы не могут быть обыектами 
// во всех классах по умолчанию все члены по умолчанию Приватные, в интерфейсе все члены Публичные
