﻿int a = 5;
int b = 3;
int c = 11;
int d = 1;
int e = 7;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write ("Максимальное число: ");
Console.WriteLine (max);