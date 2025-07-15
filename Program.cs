using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
        Nada();
        List<string> Users = new List<string>();
        Users.Add("Ribamar_Vascao");
        Users.Add("Ribamar_Vascao");
        Users.Add("Ribamar_Vascao");

        foreach (string User in Users)
        {
            Console.WriteLine(User);
        }

    }
    public static void Nada()
    {
        Console.WriteLine("teste");
    }
}