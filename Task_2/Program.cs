/*Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.
*/

int ReadInt()
{
    string input = Console.ReadLine();

    return Convert.ToInt32(input);
}

int[] ReadCoords()
{
    int[] coords = new int[3];

    Console.WriteLine("Введите x: ");
    coords[0] = ReadInt();
    Console.WriteLine("Введите y: ");
    coords[1] = ReadInt();
    Console.WriteLine("Введите z: ");
    coords[2] = ReadInt();

    return coords;
}

double CalcDistanse(int[] a, int[] b)
{
    int sum = 0;

    for (int i = 0; i < 3; i++)
    {
        sum = sum + (b[i] - a[i]) * (b[i] - a[i]);
    }

    return Math.Sqrt(sum);
}

Console.WriteLine("Координаты точки 1");
int[] point1 = ReadCoords();
Console.WriteLine("Координаты точки 2");
int[] point2 = ReadCoords();

double distanse = CalcDistanse(point1, point2);

Console.WriteLine($"Расстояние между точками равно {distanse}");