﻿// Петя любит счастливые числа. Всем известно, что счастливыми являются положительные
// целые числа, в десятичной записи которых содержатся только счастливые цифры 4 и 7.
// Например, числа 47, 744, 4 являются счастливыми, а 5, 17, 467 — не являются.
// К сожалению, не все числа счастливые. Петя называет число почти счастливым, если 
// количество счастливых цифр в нем — счастливое число. Ему интересно, является ли 
// число n почти счастливым.

Console.WriteLine("Введите число");
string n = Console.ReadLine();
int c = 0;
for(int i = 0; i <n.Length; i++)
{
    if (n[i] =='7' || n[i] =='4') c++;
}
if (c == 7 || c==4) 
{
    Console.WriteLine("YES");
}    
else 
{
    Console.WriteLine("NO");
}


