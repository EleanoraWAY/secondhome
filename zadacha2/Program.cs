// Задание 2
{
Console.WriteLine("Введите координаты точки (X и Y):"); 
Console.Write("Введите точку X: ");
    double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку Y: ");
    double y = Convert.ToDouble(Console.ReadLine());
        if (x == 0 || y == 0)
        {
Console.WriteLine("Ошибка: X и Y  не равны нулю.");
        }
        else
        {
           
int quadrant = DetermineQuadrant(x, y);

            
Console.WriteLine($"Точка находится в {quadrant} четверти.");
        }
    
}

static int DetermineQuadrant(double x, double y)
{   
 if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else
        {
            return 4;
        }
    }
