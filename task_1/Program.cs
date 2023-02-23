Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());
int x = n/1000;
int y = n%100;
int z = n/100;
int[] array = {x/10, x%10, z%10, y/10, y%10};

if(array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}
