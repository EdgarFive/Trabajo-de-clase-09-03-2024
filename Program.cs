

//AREA DE ESTRUCTURAS ================================================================

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;


//Ejer 1: Número mayor y menor ================================================
static void fvalnum()
{
    int enumm = 0;
    int emay = 0;
    int emen = int.MaxValue;

    for (int ii = 1; ii != 0;)
    {
        Console.WriteLine("Ingrese un número positivo.");
        enumm = int.Parse(Console.ReadLine());
        if (enumm == 0)
        {
            ii = 0;
        }
        else if (enumm > 0)
        {
            if (enumm > emay)
            {
                emay = enumm;
            }
            else if (enumm < emen)
            {
                emen = enumm;
            }
        }
        else if (enumm < 0)
        {
            Console.WriteLine("El número que ingrese debe ser mayor a \"0\"");
            Console.ReadKey();
        }
    }
    Console.WriteLine($"El número con mayor valor ingresado es: {emay}\nEl número con menor valor ingresado es: {emen}");
    Console.ReadKey();
}


//Ejer 2: Adivina el numero que está pensado ============================================
static void fadinum()
{
    Console.WriteLine("Ingrese un número entero: ");
    int enumm = int.Parse(Console.ReadLine());
    int emulti = enumm * 2;
    emulti = emulti + 8;
    emulti = emulti * 5;
    string eresul = Convert.ToString(emulti);
    int evari1 = eresul.Length;
    string eresul2 = eresul.Substring(0, evari1 - 1);
    int eresultado = Convert.ToInt32(eresul2);
    eresultado = eresultado - 4;
    Console.WriteLine("El número en el que pensó es el: "+ eresultado);
    Console.ReadKey();
}


//Ejer 3: Contador de palabras ==================================================
static void fconfrase()
{
    Console.WriteLine("Ingrese la frase que prefiera:");
    string efrase = Console.ReadLine() + " ";
    int eespacio = efrase.IndexOf(' ');
    int einicio = 0;
    string efrase2;
    int contador = 0;
    while (eespacio != -1)
    {
        contador++;
        efrase2 = efrase.Substring(einicio, eespacio - einicio);
        Console.WriteLine($"{contador} {efrase2}\n");
        einicio = eespacio+1;
        eespacio = efrase.IndexOf(' ', einicio);
    }
    Console.WriteLine($"\n{contador} palabras.");
    string efrase3 = efrase.ToLower();
    int jj = 0;
    foreach (char ee in efrase3)
    {
        if ("aeiou".Contains(ee))
        {
            jj++;
        }
    }
    Console.WriteLine($"\nLa cantidad de bocales encontradas es de: {jj}");
    Console.ReadKey();
}


//Ejer 4: Palíndromos =======================================================
static void fpalindromos()
{
    Console.WriteLine($"Ingrese una palabra: ");
    string epalabra = Console.ReadLine();
    string epalabra2 = "";
    int enumpalabra = epalabra.Length;
    for (int ii = enumpalabra-1; ii >= 0; ii--)
    {
        epalabra2 += epalabra[ii];
    }
    if (epalabra.ToLower() == epalabra2.ToLower())
    {
        Console.WriteLine($"La palabra SÍ es un Palíndromo:\n\n\tPalabra original: {epalabra}\t\tPalabra invertida: {epalabra2}");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine($"La palabra NO es un Palíndromo:\n\n\tPalabra original: {epalabra}\t\tPalabra invertida: {epalabra2}");
        Console.ReadKey();
    }
}


//=========================================================================================
//AREA DEL PROGRAMA =======================================================================
//=========================================================================================


fvalnum();

fadinum();

fconfrase();

fpalindromos();















