public class ejercicio11
{

    static void Main(string[] args)
    {

        /*11.	Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un número negativo, el programa debe 
         * finalizar y mostrar en consola la cantidad total de números 
         * positivos que ingresó hasta antes de ingresarse el número negativo.*/

        int contador = 0;
        int n, num;
        Console.Write("ingrese la cantidad de numeros que desea evaluar: ");
        n = Convert.ToInt32(Console.ReadLine());

        do
        {

            Console.WriteLine("ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                contador++;
            }
            else
            {
                break;
            }

        } while (contador < n);

        Console.WriteLine(string.Format("La cantidad de num positivos es: {0}", contador));





    }

}