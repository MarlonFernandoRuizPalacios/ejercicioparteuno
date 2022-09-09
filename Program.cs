namespace ejercicio5
{
    public class program
    {
        public static void Main()
        {

            int limite;
            double potencia;
            int numero = 2;
            int cotador;
            cotador = 0;
            limite = 10;
            for (cotador = 0; cotador <= limite; cotador++)
            {
                potencia = Math.Pow(numero, cotador);
                Console.WriteLine($"El resultado del número 2 elevado a la potencia de {cotador} es : {potencia}");
            }

        }
    }
}