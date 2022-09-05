Console.Write("Введи трёхзначное число:  ");
int findNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(findNumber);
Console.WriteLine(findNumber +"  ->   " +stringNumber[1]);