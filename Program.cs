/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        int x = 0;
        int y = 0;
       

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
      

        if (x>0 && y>0 )
        {
            Console.WriteLine("1");
        }
        else if (x<0 && y>0) 
        {
            Console.WriteLine("2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("3");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("4");
        }

    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        int minuts = 0;
        int hora = 0;
        int segons = 0;

        hora = int.Parse(Console.ReadLine());
        minuts = int.Parse(Console.ReadLine());
        segons = int.Parse(Console.ReadLine());

        if ((hora >= 0) && (minuts >= 0) && (segons >= 0))
        {
            if ((hora <= 23) && (minuts <= 59) && (segons <= 59))
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        const string MSG= "";
        string valor = "";
        valor =  Console.ReadLine();

        switch (valor)
        {
            case "Q":
                Console.WriteLine("Skill 1");
                break;
            case "W":
                Console.WriteLine("Skill 2");
                break;
            case "E":
                Console.WriteLine("Skill 3");
                break;
            case "R":
                Console.WriteLine("Ultimate");
                break;
            case "B":
                Console.WriteLine("Recall");
                break;
            case "F":
                Console.WriteLine("Bronzes never use summoners");
                break;
            case "D":
                Console.WriteLine("Bronzes never use summoners");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }

    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        const string Patata = "No ofendre al president patata";

        int userNumb = 0;
        int i = 0;

        userNumb = int.Parse(Console.ReadLine());

        if (i == userNumb-1)
        {
            Console.Write(" ");
            userNumb = int.Parse(Console.ReadLine());
            i = 0;
        }
        while (i < userNumb)
        {
            Console.WriteLine(Patata);
            i++;
            if (i == userNumb)
            {
                Console.WriteLine(" ");
                userNumb = int.Parse(Console.ReadLine());
                i = 0;
            }
        }
    }
}
*/
/*
using System;
using static System.Net.Mime.MediaTypeNames;
public class Program
{
    public static void Main(string[] args)
    {
        
        string howarts = "";
        string barret = "";

       howarts= Console.ReadLine();

        switch (howarts)
        {

            case "Coratge":

                barret = "Gryffindor";

                break;

            case "Coneixement":

                barret = "Ravenclaw";

                break;

            case "Ambicio":

                barret = "Slytherin";

                break;

            default:

                barret = "Hufflepuff";

                break;
        }
        Console.WriteLine(barret);
    }
}
*/
/*
using System;
using static System.Net.Mime.MediaTypeNames;
public class Program
{
    public static void Main(string[] args)
    {
        int k=0; int n=0; int i=0;

        k = int.Parse(Console.ReadLine());
        

        int[] arrayNums = new int[k];

       while (i< k)    
        {
            arrayNums[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{arrayNums[i]}"+" ");
            i++;
        }
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(arrayNums[n]);
     
    }
}
*/
/*
using System;
using static System.Net.Mime.MediaTypeNames;
public class Program
{
    public static void Main(string[] args)
    {
        int k = 0; int n = 0; 

        k = int.Parse(Console.ReadLine());

        int[] array = new int[k];

        for (int i = 0; i < k; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            
        }
        n = int.Parse(Console.ReadLine());

        Console.WriteLine(string.Join(" ",array));

        Console.WriteLine(array[n]);
    }
}
*/
/*
using System;
using static System.Net.Mime.MediaTypeNames;
    public class Program
{
    public static void Main()
    {
        int k = 0;
        int n = 0;

        k = int.Parse(Console.ReadLine());
        string userNumbersIn = Console.ReadLine();
        string[] s = userNumbersIn.Split(" ");
        n = int.Parse(Console.ReadLine());

       
        Console.WriteLine(string.Join(" ", s));
       
        Console.WriteLine($"{s[n]}");
    }

}
*/
using System;
using static System.Net.Mime.MediaTypeNames;
public class Program
{
    public static void Main(string[] args)
    {
        int k = 0;
        int n = 0;

        k = int.Parse(Console.ReadLine());
        string userNumbersSt = Console.ReadLine();
        string[] s = userNumbersSt.Split(" ");

        n = int.Parse(Console.ReadLine());

        Console.WriteLine(string.Join(" ", s));

        int[] userNumbin = new int[userNumbersSt.Length];
        for (int i = 0; i < userNumbersSt.Length; i++)
        {
            userNumbin[i] = int.Parse(Console.ReadLine());
            userNumbin[i] = userNumbin[i] + n;
        }

        Console.WriteLine(string.Join(" ", userNumbin));
    }
}
