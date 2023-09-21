public class ejercicio7 
{

    static void Main(string[] args)
    {
        //Escribir un algoritmo que dados 2 valores de entrada imprima siempre la división del mayor entre el menor.

        int num1, num2;
        double cociente;

        Console.Write("Ingrese su primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese su segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());


        if (num1 == 0)
        {
            cociente = num1 / num2;

        }
        else if (num2 == 0)
        {
            cociente=num2 / num1;
        }
 
        if (num1 > num2)
        {
            cociente = num1 / num2;
        }
        else { cociente = num2 / num1;}

        if (num2 == 0 & num1 == 0)
        {
            Console.Write("Indeterminado");
        }

        Console.Write($"El cociente es {0}", cociente);


    }




}

