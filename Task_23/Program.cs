// Задача 23: Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int number = Input("Введите число N: ");
double i = 2;
//for(i <= number; Math.Pow(i, 3); i++)

while(i <= number)
{
    double pow = Math.Pow(i, 3);
    Console.WriteLine($"{i} x {i} x {i} = {pow}");
    Console.WriteLine();
    i = i + 1;
}
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
