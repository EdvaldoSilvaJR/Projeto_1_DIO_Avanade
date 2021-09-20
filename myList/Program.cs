using System;
using myList.classes;

namespace myList
{
    class Program
    {

        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string option = getOption();

            while(option.ToUpper() != "X")
            {
                switch(option)
                {
                    case "1":
                        listarSerie();
                        break;
                    case "2":
                        inserirSerie();
                        break;
                    case "3":
                        updateSerie();
                        break;
                    case "4":
                        deleteSerie();
                        break;
                    case "5":
                        viewSerie();
                        break;
                    case "X":
                        Console.WriteLine("See you Next Time ;)");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                option = getOption();
            }
        }

        private static void listarSerie()
        {
            Console.WriteLine("Listar series");
            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach(var serie in lista)
            {
                var excluido = serie.isDeleted();
                if(excluido==false)
                {
                    Console.WriteLine("#ID {0}: - {1}",serie.getId(), serie.getTitulo(),(excluido ? "*Excluido *":""));
                }
            }
        }

        private static void inserirSerie()
        {
            Console.WriteLine("Inserir uma nova série");
            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genero),i));
            }
            Console.Write("Digite o gênero das opções acima:");
            int generoInserido = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string tituloInserido = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int anoInserido = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string descricaoInserido = Console.ReadLine();

            Serie auxSerie = new Serie(id:repositorio.nextId(),
                                genero:(Genero)generoInserido,
                                titulo:tituloInserido,
                                ano:anoInserido,
                                descricao:descricaoInserido);

            repositorio.insert(auxSerie);

        }

        private static void updateSerie()
        {
            listarSerie();
            Console.Write("Digite o ID da série acima que será atualizada");
            int idUpdate = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genero),i));
            }
            Console.Write("Digite o gênero das opções acima:");
            int generoInserido = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string tituloInserido = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int anoInserido = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string descricaoInserido = Console.ReadLine();

            Serie auxSerie = new Serie(id:idUpdate,
                                genero:(Genero)generoInserido,
                                titulo:tituloInserido,
                                ano:anoInserido,
                                descricao:descricaoInserido);

            repositorio.update(idUpdate,auxSerie);
        }
         private static void deleteSerie()
        {
            listarSerie();
            Console.Write("Digite o ID da série que será excluida");
            int idUpdate = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genero),i));
            }
            repositorio.delete(idUpdate);
        }

        private static void viewSerie()
        {
            Console.WriteLine("Digite o ID da série para visualização: ");
            int idUpdate = int.Parse(Console.ReadLine());

            var serie = repositorio.retornaPorId(idUpdate);
            Console.WriteLine(serie);
        }
        private static string getOption()
        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao MyList");
            Console.WriteLine("Informe a Função Desejada");
            Console.WriteLine("1 - Listar Séries");
            Console.WriteLine("2 - Inserir Série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("C - Limpar a Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string option = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return option;
            
        }
    }
}
