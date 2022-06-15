//Задача 21: Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int xA = Input("Введите координату xA: ");

int yA = Input("Введите координату yA: ");

int zA = Input("Введите координату zA: ");

int xB = Input("Введите координату xB: ");

int yB = Input("Введите координату yB: ");

int zB = Input("Введите координату zB: ");

int x = xB - xA;
int y = yB - yA;
int z = zB -zA;
double AB = Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)), 2);

Console.WriteLine($"Длина отрезка AB = {AB}");


int Input(string output)
{
   Console.Write(output);
   return Convert.ToInt32(Console.ReadLine());
}

