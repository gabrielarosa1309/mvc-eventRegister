using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_eventRegister.Model
{
    public class Evento
    {
        //propriedades
        public string Nome { get; set; }
        public string Data { get; set; }
        public string Descricao { get; set; }

        //caminho da pasta e do arquivo
        private const string PATH = "Database/Evento.csv";

        //construtor
        public Evento()
        {
            //caminho da pasta
            string pasta = PATH.Split("/")[0]; //"Database"

            //se não existir uma pasta "Database", então cria-se uma
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //se não existir um arquivo csv no caminho, então cria-se um
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Evento> Ler()
        {
            //instanciar uma lista de eventos
            List<Evento> eventos = new List<Evento>();

            //array de string que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                //array que recebe os itens da linha separado por ";"
                string[] atributos = item.Split(";");

                //instância do objeto evento
                Evento e = new Evento();

                //atribuição dos dados dentro de um objeto
                e.Nome = atributos[0];
                e.Data = atributos[1];
                e.Descricao = atributos[2];

                //adiciona os objetos dentro da lista
                eventos.Add(e);
            }

            //retorna a lista de eventos
            return eventos;
        }

        //método para preparar a linha do csv
        public string PrepararLinhasCSV(Evento e)
        {
            return $"{e.Nome};{e.Data};{e.Descricao}";
        }

        //método para inserir um evento no arquivo csv
        public void Inserir(Evento e)
        {
            //array que vai armazenar as linhas (cada "objeto")
            string[] linhas = {PrepararLinhasCSV(e)};

            //vai até o arquivo e insere todas as linhas
            File.AppendAllLines(PATH, linhas);
        }
    }
}