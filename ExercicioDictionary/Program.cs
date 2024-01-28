namespace ExercicioDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva uma frase: ");
            string frase = Console.ReadLine();
            ContadorDePalavras(frase);



            void ContadorDePalavras(string frase)
            {
                frase = frase.Replace(",", "").Replace(".", "").ToUpper();
                string[] palavras = frase.Split(' ');
                string[] palavrasSemRepeticao = palavras.Distinct().ToArray();

                Dictionary<string, int> contadorDePalavras = new Dictionary<string, int>();

                foreach (string palavra in palavrasSemRepeticao)
                {
                    contadorDePalavras.Add(palavra, 0);
                }

                foreach (string palavra in palavras)
                {
                    contadorDePalavras[palavra]++;
                }

                Console.WriteLine(" ");
                foreach (KeyValuePair<string, int> kvp in contadorDePalavras)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value} vezes.");
                }
            }
            

        }
    }
}
