class Program
{
    static void Main(string[] args)
    {
        
    }

    public void MenuPrincipal()
    {
        string opcao;

        while (opcao != "0")
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Criar conta");
            Console.WriteLine("2 - Entrar");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            switch (Console.ReadLine())
            {
                case "1": MostrarFormularioRegisto(); break;
                case "2": MostrarFormularioLogin(); break;
                case "0": break;
                default: MostrarErro("Opção inválida."); break;
            }
        }
    }



}