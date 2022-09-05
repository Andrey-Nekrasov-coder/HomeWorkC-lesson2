Console.Write("Eter the day of the week ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

void weekendSearch(int dayOfTheWeek)
{
    if(dayOfTheWeek == 6 || dayOfTheWeek == 7){
        Console.WriteLine(dayOfTheWeek + "->  This is WEEKEND !!!");
    }
    else if (dayOfTheWeek < 1 || dayOfTheWeek > 7){
        Console.WriteLine("There are only 7 days in a week.");
    }
    else 
    Console.WriteLine("It's a work day.");
}
weekendSearch(dayOfTheWeek);