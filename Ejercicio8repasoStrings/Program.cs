namespace Ejercicio6repasoStrings { 
    class program {
        public static void Main(String[] args)
        {
            Console.WriteLine("Escribe una cadena de texto");
            string cadena = Console.ReadLine();
            Console.WriteLine("¿Que caracter desea cambiar?");
            string caracterACambiar = Console.ReadLine();
            Console.WriteLine("¿Por cual lo desea cambiar?");
            string caracterSutituidor = Console.ReadLine();
            Console.WriteLine(cadena.Replace(caracterACambiar, caracterSutituidor));

        }
    } 
}
