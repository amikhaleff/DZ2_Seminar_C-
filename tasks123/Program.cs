Console.Write("Введите номер порядковый номер задачи ");
int Task = int.Parse(Console.ReadLine() ?? "0");

if (Task == 1) ZADACHA1();
else if (Task == 2) ZADACHA2();
else if (Task == 3) ZADACHA3();
else System.Console.WriteLine("Такой задачи нет в списке");

void ZADACHA1()
{
    Console.Write("Введите трехзначное число ");
    int num = int.Parse(Console.ReadLine() ?? "0");
    if (num >= -999 && num <= -100)
    {
        num = -num;
        int des = num / 10 % 10;
    }
    if (num >= 100 && num <= 999)
    {
        int des = num / 10 % 10;
        System.Console.WriteLine("Вторая цифра в числе" + " " + des);
    }

    else System.Console.WriteLine("uncorrect");




}

void ZADACHA2()
{
    Console.Write("Введите число ");
    int num = int.Parse(Console.ReadLine() ?? "0");
    if (num > -100 && num < 100) System.Console.Write("Третьей цифры нет");
    else if (num < 0) num = num * -1;
    string strnum = num.ToString();

    System.Console.WriteLine("Третья цифра в числе " + " " + strnum[2]);
}










void ZADACHA3()
{
    Console.Write("Введите порядковый номер дня недели: ");
    int weeknumber = int.Parse(Console.ReadLine() ?? "0");

    if (weeknumber == 6 && weeknumber == 7) System.Console.WriteLine(weeknumber + "День недели - выходной");
    else if (weeknumber>=1&&weeknumber<=5) System.Console.WriteLine(weeknumber + "День недели - рабочий");
    else
        System.Console.WriteLine("Не является днем недели");

}

    System.Console.WriteLine();