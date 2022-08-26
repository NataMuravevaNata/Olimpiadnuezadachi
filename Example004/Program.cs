// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число для проверки: ");
int n = int.Parse(Console.ReadLine() ?? "0");
bool k = false; 
for(int i=0; i < Digitsnumber(n); i++)
{    
    if((Digitindex(n,i+1) == 4 || Digitindex(n,i+1) == 7)
        &&(Digitsnumber(n) == 4 || Digitsnumber(n) == 7))
        k = true;
}
if(k == true)
{
    Console.WriteLine("Да, введенное Вами число является счастливым.");
}
else
{
    Console.WriteLine("Нет, введенное Вами число не является счастливым.");
}
;
