using System;

class Empleado
{
    public string Name {get;set;}
    public int Salario {get;set;}

    public Empleado(string name,int salario)
    {
        Name = name;
        Salario=salario*12;
    }
    
    public void Mostrar()
    
    {
           Console.WriteLine($"{Name} gana {Salario} $ anualmente");
    }
}
class Program 
{
    static void Main()
    {
        Empleado empleado1= new Empleado("jose rodriguez",400);
        Empleado empleado2= new Empleado("Elian corrales",500);
        Empleado empleado3= new Empleado("enmanuel vazques",200);
        Empleado empleado4= new Empleado("maria spocito",250);
        Empleado empleado5= new Empleado("Manucho cuadra",569);



        Console.WriteLine("esto ganan los empleados anualmente");
        {
            Console.ReadKey();
            empleado1.Mostrar();
             Console.ReadKey();
            empleado2.Mostrar();
             Console.ReadKey();
            empleado3.Mostrar();
             Console.ReadKey();
            empleado4.Mostrar();
             Console.ReadKey();
            empleado5.Mostrar();
        }
    }
    
} 
