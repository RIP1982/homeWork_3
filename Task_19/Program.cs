// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является 
// ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();

int number = Input("Введите пятизначное число: ");
int i = 1;
int n = 5;
double numberN = 0;

 
if(number < 10000 || number > 100000)
{
     Console.WriteLine($"Число {number} не соответствует условию!");
	 return;
}
 
while(i <= 5 && n >= 0)
{
    double pow1 = Math.Pow(10, n);
    double pow2 = Math.Pow(10, i);
	double div = number % pow2 / pow2;
	double rounding = Math.Round(div, 1);
    double result = numberN + rounding * pow1;
	numberN = result;
    i = i + 1;
	n = n - 1;
}
 
if(number == numberN)
{
    Console.WriteLine($"Число {number} является палиндромом!"); }
 
else
{
    Console.WriteLine($"Число {number} не является палиндромом!"); }

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}