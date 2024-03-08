namespace Ejercicio07.Repaso.C
{

    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("INTRODUCE UNA FRASE: ");
            string fraseUsuario = Console.ReadLine();

            string[] fraseDividad = fraseUsuario.Split(' ');
            Console.WriteLine("LA FRASE TIENE UN TAMANIO: " + fraseDividad.Length);

        }
    }

}