namespace ExercicioStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva uma expressão matemática:");
            string expressao = Console.ReadLine();
            AnaliseDaExpressao(expressao);


            //método de criação da pilha
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
                        if (aberturas.Peek() == '(') aberturas.Pop();
                    }
                    if (item == '}')
                    {
                        if (aberturas.Peek() == '{') aberturas.Pop();
                    }
                    if (item == ']')
                    {
                        if (aberturas.Peek() == '[') aberturas.Pop();
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

        }
    }
}
