using System.Timers;

public class natillera
{
    static void Main(string[] args)
    {
        // declaracion de variables

        DateTime fechaActual = DateTime.Now;
        decimal rendimientoMes, bonoMes = 0, ahorroMes, rendimientoAño = 0, ahorroAño = 0, bonoAño = 0, ahorroTtal = 0;
        int r, contador = -1;
        double interesMes;
        Random tasaMes = new Random();
        bool continuar = true;
        const double TASA_MAX = 1.5; //(decimal) = 1.5M;

        Console.WriteLine($"------------NATILLERA NAVIDEÑA {fechaActual.Year}------------");
        while (continuar)
        {
            
            contador++;
            for (int mes = 1; mes <= 12; mes++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Ingrese la cantidad que desea ahorrar en el presente mes: ");
                ahorroMes = Convert.ToDecimal(Console.ReadLine());


                interesMes = tasaMes.Next(11, 501) / 100.0;
                rendimientoMes = ((decimal)interesMes * ahorroMes) / 100;

                if (interesMes < TASA_MAX)
                {
                    bonoMes = (ahorroMes * 2) / 5;
                    bonoAño += bonoMes;
                }

                ahorroAño += ahorroMes;
                rendimientoAño += rendimientoMes;


                ahorroTtal = ahorroAño + rendimientoAño + bonoAño;

                Console.WriteLine($"Tasa de interes mes {mes}: {interesMes}% ");
                Console.WriteLine($"El rendimiento del mes {mes} es : {rendimientoMes:C2}");
                if (bonoMes > 0) Console.WriteLine($"El bono del mes {mes} es : {bonoMes:C2} ");
                Console.WriteLine($"El total ahorrado hasta el mes {mes}: {ahorroAño:C2} ");
                Console.WriteLine($"El total de utilidades hasta el mes {mes} es: {rendimientoAño:C2} ");
                Console.WriteLine($"La suma total neta de sus ahorros hasta el mes {mes} es de: {ahorroTtal:C2} ");
            }
            Console.WriteLine("Resumen total Natillera del año {0}", (fechaActual.Year));
            Console.WriteLine($"El ahorro total en el año es: {ahorroAño:C2} COP");
            Console.WriteLine($"El total de rendimientos en el año es de : {rendimientoAño:C2} COP");
            if (bonoAño > 0) Console.WriteLine($"Los bonos totales son de: {bonoAño:C2} COP");
            Console.WriteLine($"EL AHORRO TOTAL DEL AÑO ES DE: {ahorroTtal:C2} COP");

            Console.WriteLine("\n");
            Console.WriteLine(string.Format("Desea continuar en la natillera {0}? si = 1, no = 0", (fechaActual.Year + 1)));
            r = Convert.ToInt32( Console.ReadLine() );
            if (r == 1)
            {
                continuar = true;
            }
        }
    }

}