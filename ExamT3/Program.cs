﻿using ExamT3;
public class Program
{
    private static Cita[] citas = new Cita[100];
    private static int contadorCitas = 0;

    public static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Crear Cita");
            Console.WriteLine("2. Listar Citas");
            Console.WriteLine("3. Modificar Universidades");
            Console.WriteLine("4. Fin");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción no válida, ingrese un número.");
                continue;
            }
        
    


