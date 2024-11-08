using System;
using System.Diagnostics.Eventing.Reader;

public class programfirst
{
    public static void Main(string[] args)
    {
        int idade = 15;

        if (idade >= 18)
        {
            Console.WriteLine("pode3 entra na beber uma ceveja!");
        }
        else if (idade < 18 && idade >= 15)
        {
            Console.WriteLine("pode entar mas sò bebe sumo");
        }
        else
        {
            Console.WriteLine("pode entar na discoteca");
        }
    }
}