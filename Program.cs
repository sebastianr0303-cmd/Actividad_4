Console.WriteLine("Inicio del Programa:");

//Variables
string Cc = "admin123", 
       Ci = "xyz";

    do
    {
        Console.WriteLine("Ingrese la contrasena:");
        Ci = Console.ReadLine();

        if (Ci != Cc)
        {
            Console.WriteLine("Contrasena incorrecta\n");
        }
    } while (Ci != Cc);

Console.WriteLine("Bienvenido al sistema");

Console.WriteLine("Fin del Programa");
