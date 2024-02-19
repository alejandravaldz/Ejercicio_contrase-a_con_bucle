// See https://aka.ms/new-console-template for more information
Console.WriteLine("Contraseña");
Console.WriteLine();

{

    string contraseñaCorrecta = "Alejandra";


    int intentos = 3;

    while (intentos > 0)
    {

        Console.WriteLine("Ingrese la contraseña:");
        string contraseñaIngresada = Console.ReadLine();

        if (contraseñaIngresada == contraseñaCorrecta)
        {
            Console.WriteLine("Contraseña correcta.");
            break;
        }
        else
        {
            intentos--;
            if (intentos > 0)
            {
                Console.WriteLine("La contraseña esta incorrecta. Le quedan " + intentos + " intentos.");
            }
            else
            {
                Console.WriteLine("se han agotado los numeros de intentos.");
            }
        }
    }
}
