using mvc_eventRegister.Model;
using mvc_eventRegister.Controller;

//instância do objeto produto
Evento e = new Evento();

//instância do objeto EventoController
EventoController controller = new EventoController();

//chamada do método controlador de cadastro
controller.CadastrarEvento();

//chamada do método controlador de listagem
controller.ListarEventos();