namespace contrario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numrandom = new int[7];
            Random rnd = new Random();

            //Creazione
            for( int i = 0 ;i < numrandom.Length;i++)
            { 
                numrandom[i] = rnd.Next(0, 7);
               
            }

            //Stampa
            for (int i = 0; i < numrandom.Length; i++)
            {
                Console.Write("[" + numrandom[i] + "]");

            }

            Console.WriteLine();

            //Stampa contrario
            for (int i = numrandom.Length - 1; i >= 0; i--)
            {
                Console.Write("["+numrandom[i]+"]");
            }
        }
    }
}
