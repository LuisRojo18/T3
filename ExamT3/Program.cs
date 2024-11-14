string opcion;

void MostrarSeleccion()
{

    Console.WriteLine("a)++++Crear++++\n");
    Console.WriteLine("b)++++Listar++++\n");
    Console.WriteLine("+++Modificar Masivo+++\n);");
    Console.WriteLine("d)++++Fin++++\n");
    Console.WriteLine("Seleccione una opcion: ");
}
bool ContinuarPrograma=true;
while (ContinuarPrograma)
{
MostrarSeleccion();
    opcion=Console.ReadLine();
    switch (opcion)
    {
        case "a":
            Console.WriteLine("Ingrese su numero: ");
    }
}