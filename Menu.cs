

using Bener.Enuns;

namespace Bener
{
    public class Menu
    {
        private int numUm;
        private int numDois;
        public void listarMenu(Network network) {

            int opcaoMenu;
            Console.WriteLine("Selecione a opção:");
            Console.WriteLine("1. Conectar");
            Console.WriteLine("2. Consultar");
            Console.WriteLine("0. sair");

            opcaoMenu = Convert.ToInt32(Console.ReadLine());


            switch ((EnumMenu)opcaoMenu)
            {
                case EnumMenu.Conectar:
                    Console.WriteLine("Opção Conectar selecionada");
                    menuConectar(network);
                    break;
                case EnumMenu.Consultar:
                    Console.WriteLine("Opção Consultar selecionada");
                    menuConsultar(network);
                    break;
                case EnumMenu.sair:
                    Console.WriteLine("Sair da Operação");
                    // Lógica para a opção Consultar
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        public void menuConectar(Network network)
        {
            Console.WriteLine("Digite o valor 1");
            numUm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor 2");
            numDois = Convert.ToInt32(Console.ReadLine());
            network.Connect(numUm, numDois);
            Console.WriteLine("Conexão criada com Sucesso");
            listarMenu(network);

        }
        public void menuConsultar(Network network)
        {
            Console.WriteLine("Digite o valor 1");
            numUm = Convert.ToInt32(Console.ReadLine());     
            
            Console.WriteLine("Digite o valor 2");
            numDois = Convert.ToInt32(Console.ReadLine());
            bool conexaoExiste = network.Query(numUm, numDois);
            Console.WriteLine(conexaoExiste ? "Conexão existente" : "Não há conexão");
            listarMenu(network);

        }
    }
}
