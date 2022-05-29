int numberA = 5;
int numberB = 11;

Console.WriteLine (numberA + numberB);

// or

int numberC = 4;
int numberD = 3;
int result = numberC + numberD;

Console.WriteLine (result);

//or

int numberE = new Random().Next(1,10); // 1 2 3 ... 9
Console.Write ("Первое число: ");
Console.WriteLine (numberE);

int numberF = new Random().Next(1,10);
Console.Write ("Второе число: ");
Console.WriteLine (numberF);

Console.Write ("Сумма: ");
Console.WriteLine (numberE + numberF);
