using System;

public delegate double CalcularSalario(double salarioBase);

public class Empleado
{
    public string Nombre { get; set; }
    public double SalarioBase { get; set; }

    public Empleado(string nombre, double salarioBase)
    {
        Nombre = nombre;
        SalarioBase = salarioBase;
    }

    public double CalcularSalarioTotal(CalcularSalario calcularSalario)
    {
        return calcularSalario(SalarioBase);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Empleado juanPerez = new Empleado("Juan Perez", 2000);
        Empleado mariaLopez = new Empleado("María López", 1500);
        Empleado carlaGomez = new Empleado("Carla Gomez", 1000);

        CalcularSalario tiempoCompleto = (salarioBase) => salarioBase + salarioBase * 0.10;
        CalcularSalario tiempoParcial = (salarioBase) => salarioBase;
        CalcularSalario temporal = (salarioBase) => salarioBase + salarioBase * 0.05;

        Console.WriteLine("Salario de " + juanPerez.Nombre + " (Tiempo completo): " + juanPerez.CalcularSalarioTotal(tiempoCompleto));
        Console.WriteLine("Salario de " + mariaLopez.Nombre + " (Tiempo Parcial): " + mariaLopez.CalcularSalarioTotal(tiempoParcial));
        Console.WriteLine("Salario de " + carlaGomez.Nombre + " (Temporal): " + carlaGomez.CalcularSalarioTotal(temporal));
    }
}
