Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int s1 = 1;


while(s1 <= n)
{
    Console.Write ( $"{Math.Pow (s1,3)}  ");
    s1 ++;
}