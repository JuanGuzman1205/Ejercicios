public class ejercicio8
{
    static void Main(string[] args)
    {
        //Construir un programa que pida un número y luego diga si este número es par o no.

        int num;

        Console.Write("Ingrese su numero:");
        num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0) 
        {
            Console.Write($"el numero {num} es par");
        }
        else 
        { Console.Write($"El numero {num} es impar"); }
        


    }


}
