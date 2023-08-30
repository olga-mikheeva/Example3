// Различные методы и способы их вызвать
// ВИД ПЕРВЫЙ
// 1. Метод ничего не принимает в качестве аргументов и ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор ...");
}

// ВИД ВТОРОЙ
//Method1();
// 2. Метод принимает аргументы но ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2("Текст сообщения");
//3. Метод с именованными аргументами
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

////Method21("Текст", 4);
//Method21(msg:"Текст", count: 4);
//Method21(count: 4, msg:"Новый текст");

//ВИД ТРЕТИЙ
//Методы которые что-то возвращают но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);

// ВИД ЧЕТВЕРТЫЙ
//Методы которые принимают что-то в качестве аргументов и что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = "";
    // либо: string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

//string res = Method4(10, "asdf");
//Console.WriteLine(res);
// ЦИКЛ for
string Method41(int count, string text)
{
    string result = "";
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

//string res = Method4(10, "s");
//Console.WriteLine(res);

// ЦИКЛ В ЦИКЛЕ (на примере вывода таблицы умножения)
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j}  = {i * j}");
    }
    Console.WriteLine();
}