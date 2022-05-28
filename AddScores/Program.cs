
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var num = new int[] { 3, 4, 8, 5, };
Console.WriteLine(Addarray(num));

static int Addarray(int[] num)
{

    int score = 0;
    foreach (var item in num)
    {
        if (item == 8)
        {
            score += 5;
        }
        else if (item % 2 == 0)
        {
            score += 1;
        }
        else if (item % 2 != 1)
        {
            score += 3;
        }


    }
    return score;
}