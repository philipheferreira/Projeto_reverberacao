



namespace reverberacao{
    class Program{

        static void Main(string[] args){

            int menu;

            do
            {
                Console.WriteLine("Menu de operações:\n1 - Materias Cadastrados.\n2 - Adicionar material.\n3 - Deletar material.\n0 - Sair");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu){
                    case 0:
                        Console.WriteLine("Saindo do programa, obrigado por utilizar");
                        break;
                    case 1:
                        Console.WriteLine("Materias cadastrados");
                        break;

                    case 2:
                        Console.WriteLine("adicionar material");
                        break;

                    case 3:
                        Console.WriteLine("Deletar material");
                        break;

                    default:
                        Console.WriteLine("Operação não registrada");
                        break;

                }

            } while ( menu != 0);

        }
    }
}
