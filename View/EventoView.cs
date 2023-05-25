using mvc_eventRegister.Model;

namespace mvc_eventRegister.View
{
    public class EventoView
    {
        //método para exibir os dados da lista de eventos
        public void Listar(List<Evento> eventos)
        {
            Console.Clear();
            Console.WriteLine($"Lista de eventos cadastrados:");
            

            //foreach para ler a lista passada como parâmetro do método
            foreach (var item in eventos)
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                Console.WriteLine($"Data: {item.Data}");
                Console.WriteLine($"Descrição: {item.Descricao}");
            }
        }

        //método para cadastrar eventos
        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.Write($"Informe o nome:");
            novoEvento.Nome = Console.ReadLine();
            Console.Write($"Informe a data:");
            novoEvento.Data = Console.ReadLine();
            Console.Write($"Adicione uma descrição:");
            novoEvento.Descricao = Console.ReadLine();

            return novoEvento;
        }
    }
}