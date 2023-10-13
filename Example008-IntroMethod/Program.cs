/*
Определить максимальное из девти чисел.
*/
int a1 = 10;
int b1 = 40;
int c1 = 35;
int a2 = 50;
int b2 = 21;
int c2 = 43;
int a3 = 11;
int b3 = 32;
int c3 = 92;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);