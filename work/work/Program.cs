int a = 3;
int b = 3;
int c = 13;


if (a > b)
{
    if (a > c)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(c);
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(c);
    }
}







int yekun_qiymeti = 66;
if (yekun_qiymeti < 65)
{
    Console.WriteLine("Telebe kesilib");
}
else
{
    if (yekun_qiymeti >= 65 && yekun_qiymeti <= 84)
    {
        Console.WriteLine("Telebe adi diplom alib");
    }
    if (yekun_qiymeti > 84 && yekun_qiymeti <= 94)
    {
        Console.WriteLine("Telebe seref diplomu alib");
    }
    if (yekun_qiymeti > 94 && yekun_qiymeti <= 100)
    {
        Console.WriteLine("Telebe yuksek seref diplomu alib");
    }
}





int eded = 36;
int onluq = eded / 10;
int teklik = eded % 10;

int cem = onluq + teklik;
Console.WriteLine($"Cem: {cem}");














