﻿int a = 2;
int b = 4;
int c = 23;
int d = 90;
int e = 1;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);