using System;

namespace HW_Task1
{
    class Program
    {
        //Создайте структуру Point.В теле структуры создайте два интовых поля – x и y.
        //Создайте структуру Vektor.В теле структуры создайте два поля типа Point с именами start и finish.
        //В теле Vektor выполните перегрузку оператора + таким образом, чтобы в результате сложения двух экземпляров типа Vektor получался новый объект Vektor с значениями координат Point 
        //в соответствии с правилами сложения векторов:
        //Выполните такое задание и для разности двух векторов.Выполните перегрузку оператора * для получения скалярного произведения векторов.

        static void Main(string[] args)
        {
            var vektor1 = new Vektor(new Point(1,-3), new Point(4,5));
            var vektor2 = new Vektor(new Point(-2, -1), new Point(3, 0));

            var vektorAddRezult = vektor1 + vektor2;
            var vektorSubRezult = vektor1 - vektor2;

            var vektorScalarMulRezult = vektor1 * vektor2;

            Console.WriteLine($"Вектор 1:A({vektor1.start.x};{vektor1.start.y}) B({vektor1.finish.x};{vektor1.finish.y})");
            Console.WriteLine($"Вектор 2:C({vektor2.start.x};{vektor2.start.y}) D({vektor2.finish.x};{vektor2.finish.y})");

            Console.WriteLine("Сложение векторов");
            Console.WriteLine($"A({vektorAddRezult.start.x};{vektorAddRezult.start.y}) D({vektorAddRezult.finish.x};{vektorAddRezult.finish.y})");

            Console.WriteLine("Вычитание векторов");
            Console.WriteLine($"A({vektorSubRezult.start.x};{vektorSubRezult.start.y}) D({vektorSubRezult.finish.x};{vektorSubRezult.finish.y})");

            Console.WriteLine("Скалярное произведение векторов");
            Console.WriteLine(vektorScalarMulRezult);
            Console.ReadKey();
        }
    }
}
