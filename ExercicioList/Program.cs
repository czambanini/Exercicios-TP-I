namespace ExercicioList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lista dada
            var input = new List<string>{
              "Idiossincrasia",
              "Ambivalente",
              "Quimérica",
              "Perpendicular",
              "Efêmero",
              "Pletora",
              "Obnubilado",
              "Xilografia",
              "Quixote",
              "Inefável"
            };

            //imprimir lista filtrada
            var listaFiltrada = FiltrarLista(input);
            Console.WriteLine("ITENS COM 10 OU MAIS CARACTERES:");
            foreach (var item in listaFiltrada) { Console.WriteLine(item); };


            //método de filtragem
            List<string> FiltrarLista(List<string> lista)
            {
                List<string> listaFiltrada = new List<string>();
                foreach (var item in lista)
                {
                    if (item.Length >= 10)
                    {
                        listaFiltrada.Add(item);
                    }
                }
                return listaFiltrada;
            }
        }
    }
}
