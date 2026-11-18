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

     // ---------- Registo ----------
    private void MostrarFormularioRegisto()
    {
        Utilizador novo = utilizador.CriarConta();

        MostrarSucesso("Conta criada com sucesso! ID atribuído: " + novo.Id);
        MostrarPerfil(novo);   // entra logo na conta
    }

    // ---------- Login ----------
    private void MostrarFormularioLogin()
    {
        Console.WriteLine("\n--- Entrar ---");

        Console.Write("Email: ");
        string email = Console.ReadLine().Trim();
        Console.Write("Palavra-passe: ");
        string palavraPasse = Console.ReadLine();

        Utilizador u = sistema.Autenticar(email, palavraPasse);

        if (u == null)
        {
            MostrarErro("Email ou palavra-passe incorretos.");
            return;
        }

        MostrarSucesso("Login efetuado.");
        MostrarPerfil(u);
    }




}