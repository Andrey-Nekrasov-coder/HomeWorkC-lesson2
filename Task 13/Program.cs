Console.Write("Введи число: ");
int findNumber = Convert.ToInt32(Console.ReadLine());
string thirdNumer = Convert.ToString(findNumber);
    if (thirdNumer.Length>2)
        Console.WriteLine(thirdNumer + " -> " + thirdNumer[2]);
    
    else    
         Console.WriteLine(findNumber + "->  Третьей цифры нет");
     


