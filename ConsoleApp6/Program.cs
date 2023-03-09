Console.WriteLine("Введите количество часов:");
int h = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество минут:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(Seconds(h, m));
Console.WriteLine(Lask(h, m));
int Seconds(int h, int m)
{
    return h * 3600 + m * 60;
}

int Lask(int h, int m)
{
    if (h < 0 || m < 0) throw new Exception("Часы или минуты отрицательными быть не могут");
    return h * 3600 + m * 60;
}
class LaskOut
{

}