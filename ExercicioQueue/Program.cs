namespace ExercicioQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome dos participantes separados por ';':");
            string entrada = Console.ReadLine();
            string[] participantesArray = entrada.Split(';');

            Queue<string> participantes = new Queue<string>();
            foreach (string participante in participantesArray)
            {
                participantes.Enqueue(participante);
            }

            JogarBatataQuente(participantes);


            //método jogar batata quente
            void JogarBatataQuente(Queue<string> participantes)
            {
                Random random = new Random();

                //para teste:
                //Console.WriteLine(explosao);
                while (participantes.Count > 1)
                {
                    int explosao = random.Next(1, 51);
                    Console.WriteLine($"BATATA...");
                    for (int i = 0; i < (explosao - 1); i++)
                    {
                        Console.WriteLine($"({participantes.Peek()}) quente...");
                        participantes.Enqueue(participantes.Peek());
                        participantes.Dequeue();
                    }
                    Console.WriteLine($"{participantes.Peek()} QUEIMOU!");
                    participantes.Dequeue();
                }

                Console.WriteLine($"{participantes.Peek()} venceu!");

            }

        }
    }
}
