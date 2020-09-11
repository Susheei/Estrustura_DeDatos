using System;
class Program
{
    static void Main()
    {
        Caracter letra = new Caracter();
        char letra_user;
        Console.WriteLine("Escribe una letra: ");
        letra_user = Convert.ToChar(Console.ReadLine());
        letra.Calcula(letra_user);
        Console.ReadLine();
    }
}


class Caracter
{

    public void Calcula(char letra_user)
    {
        switch (letra_user)
        {
            case 'a':
                Console.WriteLine("la letra a es una vocal");
                break;
            case 'e':
                Console.WriteLine("La letra e es una vocal");
                break;
            case 'i':
                Console.WriteLine("La letra i es una vocal");
                break;
            case 'o':
                Console.WriteLine("La letra o es una vocal");
                break;
            case 'u':
                Console.WriteLine("La letra u es una vocal");
                break;
            default:
                Console.WriteLine("Error! es una consonante ");
                break;
        }
    }
}