﻿// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

public class Program
{
    public static void Main()
    {
        Participante Juan = new Participante("Juan");
        Participante Pedro = new Participante("Pedro");

        Enfrentamiento competencia = new Enfrentamiento(Juan, Pedro);
        Console.WriteLine($"El ganador es {competencia.iniciar()}");
    }
}




public class Participante
{
    public string Nombre { get; set; }

    public int rondasGanadas
    {
        get;
        set;
    }

    public Participante(string n)
    {
        Nombre = n;
        rondasGanadas = 0;
    }

    public string escoger()
    {
        string[] opciones = new[] { "piedra", "papel", "tijera" };
        Random i = new Random();
        
        return opciones[i.Next(0, 3)];
    }

}

public class Enfrentamiento
{
    public string Ganador { get; set; }
    public Participante Participante1 { get; set; }
    public Participante Participante2 { get; set; }

    public Enfrentamiento(Participante p1, Participante p2)
    {
        Participante1 = p1;
        Participante2 = p2;
    }

    public string iniciar()
    {
        string part1 = Participante1.escoger();
        string part2 = Participante2.escoger();
        Console.WriteLine($"{Participante1.Nombre} escogio {part1}");
        Console.WriteLine($"{Participante2.Nombre} escogio {part2}");
        if (part1 == part2)
        {
            Console.WriteLine("Empate");
        }

        if ((part1 == "piedra" && part2 == "tijeras") || (part1 == "papel" && part2 == "piedra") || (part1 == "piedra" && part2 == "tijeras"))
        {
            Console.WriteLine($"Gano {Participante1.Nombre}");
            Ganador = Participante1.Nombre;
        }
        else
        {
            Console.WriteLine($"Gano {Participante2.Nombre}");
            Ganador = Participante2.Nombre;
        }
        
        return Ganador;
    }
        
        
        
}

