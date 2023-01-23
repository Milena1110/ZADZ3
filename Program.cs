//Задача 19 
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*Console.Write("Введите число: ");
string n = Console.ReadLine();

void Number(string n)
{
 if (n[0]==n[4] && n[1]==n[3])
 {
 Console.WriteLine($"Ваше число: {n} - палиндром.");
  }
 else 
 Console.WriteLine($"Ваше число: {n} - НЕ палиндром.");
}

if (n.Length == 5)
{
 Number(n);
}
else 
Console.WriteLine($"Введи правильное число");*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string Name)
{
    Console.Write($"Введите координату {coorName} точки {Name}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Vozvrat(double x1, double x2,double y1, double y2,double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2) +Math.Pow((z2-z1),2));
}

double Length = Math.Round(Vozvrat(x1, x2, y1, y2, z1, z2),2);

Console.WriteLine($"Длина отрезка {Length}");*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


void Sq(int n)
{
    for(int i=1; i<=n; i++)
    {
        Console.WriteLine(i*i*i);
    }
}
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Sq(n);