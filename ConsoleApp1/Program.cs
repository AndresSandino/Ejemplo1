using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Coche Ferrari = new Coche();
            Ferrari.nombre = "Ferrari";
            Ferrari.color = "Rojo";
            Ferrari.placa = "WFQ-481";
            Ferrari.km = 300;

            Coche Logan = new Coche();
            Logan.nombre = "logan";
            Logan.color = "Negro";
            Logan.placa = "MQI_926";
            Logan.km = 180;

            Logan.arrancar(50);
            Console.WriteLine("Velocidad actual: " + Logan.km);
            Logan.avanzar();
            Console.WriteLine("Velocidad actual: " + Logan.km);
            Logan.frenar();
            Console.WriteLine("Velocidad actual: " + Logan.km);
            Logan.avanzar();
            Console.WriteLine("Velocidad actual: " + Logan.km);
        }
    }
}