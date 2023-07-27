// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

int b1 = Promt("Введите первую координату первой точки: ");
int k1 = Promt("Введите вторую координату первой точки: ");
int b2 = Promt("Введите первую координату второй точки: ");
int k2 = Promt("Введите вторую координату второй точки: ");

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine())!;
    return number;
}

double pointX;
double pointY;

if (k1 == k2)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    pointX = (double) (b2-b1)/(k1-k2);
    pointY = (double) k1*(b2-b1)/(k1-k2) + b1;
    Console.WriteLine($"Координаты точки пересечения двух прямых: Х=> {pointX:0.00}, Y=> {pointY:0.00}" );// pointX:0.00 - точные значения после запятой
}