using mvc_eventRegister.Model;
using mvc_eventRegister.View;

namespace mvc_eventRegister.Controller
{
    public class EventoController
    {
        //instanciar objeto evento e EventoView
        Evento Evento = new Evento();
        EventoView eventoView = new EventoView();
        //método controlador para acessar o cadastro de Evento
        public void CadastrarEvento()
        {
            Console.Clear();
            Console.WriteLine($"Bem vindo ao programa de cadastro de eventos!");

            //chamada para a view que recebe cada objeto a ser inserido no csv
            Evento novoEvento = eventoView.Cadastrar();

            //chamada para a model para inserir esse objeto no csv
            Evento.Inserir(novoEvento);
        }

        //método controlador para acessar a listagem de eventos
        public void ListarEventos()
        {
            //lista de eventos chamada pela model
            List<Evento> eventos = Evento.Ler();

            //chamada do método de exibição (view) recebendo como argumento a lista
            eventoView.Listar(eventos);
        }

    }
}