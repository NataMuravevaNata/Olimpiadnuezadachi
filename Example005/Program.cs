// Солдат хочет купить w бананов в магазине. Ему надо заплатить k
// долларов за первый банан, 2k долларов — за второй и так далее
// (иными словами, за i-й банан надо заплатить i·k долларов).
// У него есть n долларов. Сколько долларов ему придется одолжить
// у однополчанина, чтобы купить w бананов?
Console.WriteLine("стоимость первого банана: ");
int k = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine ("изначальное количество долларов у солдата: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("количество бананов, которые он хочет купить:");
int w = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
for (int i = 1; i <= w; i++)
{
    sum += k*i;
}
    if (sum > n)
    {
        Console.WriteLine(sum - n);
    }
    else
    {
        Console.WriteLine();
    }

