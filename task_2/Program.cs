Console.Clear();

Console.WriteLine("Введите координаты первой точки ([x,y,z])");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ([x,y,z])");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double z2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2) ); 

Console.Write($"result={result:f2}");
 