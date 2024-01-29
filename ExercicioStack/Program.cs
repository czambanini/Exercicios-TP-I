namespace ExercicioStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva uma expressão matemática:");
            string expressao = Console.ReadLine();
            // AnaliseDaExpressao(expressao);
            AnaliseDaExpressao2(expressao);

            //método de criação da pilha
            // Na implementação anterior havia um pequeno bug que marcava como válida expressões com múltiplos caracteres de fechamento
            void AnaliseDaExpressao(string expressao)
            {
                Stack<char> aberturas = new Stack<char>();
                foreach (char item in expressao)
                {
                    if (item == '(' ||  item == '{' || item == '[')
                    {
                        aberturas.Push(item);
                    }
                    if (item == ')')
                    {
                        if (!EstaVazia(aberturas))
                        {
                            if (aberturas.Peek() == '(') aberturas.Pop(); else ExpressaoInvalida();
                        }
                        else ExpressaoInvalida();
                    }
                    if (item == '}')
                    {
                        if (!EstaVazia(aberturas))
                        {
                            if( aberturas.Peek() == '{') aberturas.Pop(); else ExpressaoInvalida();
                        }
                        else ExpressaoInvalida();
                    }
                    if (item == ']')
                    {
                        if (!EstaVazia(aberturas))
                        {
                            if (aberturas.Peek() == '[') aberturas.Pop(); else ExpressaoInvalida();
                        }
                        else ExpressaoInvalida();
                    }
                }

                bool estaVazia = EstaVazia(aberturas);
                if (estaVazia == true) Console.WriteLine("Expressão válida");
                else Console.WriteLine("Expressão inválida");
            }

            //método de conferencia se a pilha está vazia
            bool EstaVazia (Stack<char> pilha)
            {
                if (pilha.Count == 0) return true;
                return false;
            }

            //método para encerrar o processamento de uma expressão inválida
            void ExpressaoInvalida()
            {
                Console.WriteLine("Expressão inválida");
                Environment.Exit(-1);
            }

            // Implementação alternativa com menos ifs, mais fácil de ler
            // Usa também a estrutura de dicionário
            void AnaliseDaExpressao2(string expressao)
            {
                Console.WriteLine("IMPLEMENTAÇÃO ALTERNATIVA");

                Dictionary<char, char> caracteres = new() 
                {
                    { '(',')' },
                    { '{','}' },
                    { '[',']' }
                };
                Stack<char> aberturas = new Stack<char>();

                for (int i = 0; i < expressao.Length; i++)
                {
                    var caractere = expressao[i];

                    if (caracteres.ContainsKey(caractere))
                        aberturas.Push(caractere);

                    if (caracteres.ContainsValue(caractere))
                        if (EstaVazia(aberturas) || aberturas.Pop() != caractere)
                            ExpressaoInvalida();

                }

                Console.WriteLine("Expressão válida");
            }
        }
    }
}
