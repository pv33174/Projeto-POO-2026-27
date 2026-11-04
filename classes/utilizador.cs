 public class Utilizador
    {
        public int Id { get; set; }

        public string NomeUtilizador { get; set; }
        public string Email { get; set; }
        public string PalavraPasse { get; set; }

        //Metodos Utilizador
        public void RegistarUtilizador() {}
        public void EfetuarLogin() {}
        public void AtualizarPerfil() {}

        // Construtor com todos os atributos
        public Utilizador(int id, string nomeUtilizador, string email, string palavraPasse, string numeroTelefone)
        {
            Id = id;
            NomeUtilizador = nomeUtilizador;
            Email = email;
            PalavraPasse = palavraPasse;
        }

        public void RegistarUtilizador(List<Utilizador> utilizador)
        {
            Utilizador novoUtilizador = new Utilizador();
            bool existencia;
            do
            {
                Console.WriteLine("Insira o ID: ");
                id = Console.ReadLine();

                existencia = false;

                foreach (Utilizador utilizador in Utilizadores)
                {
                    if (utilizador.ID == id)
                    {
                        existencia = true;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Esse ID já existe escolha outro");
                        Console.ResetColor();

                        break;
                    }
                }

            } while (existencia); bool existencia;

            novoUtilizador.ID = id;
            novoUtilizador.nome = PedirNome();
            novoUtilizador.idade = PedirIdade();

            Utilizadores.Add(novoUtilizador);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Utilizador registado com Sucesso!");
            Console.ResetColor();


        static string PedirNome()
        {
            string nome;
            Console.WriteLine("Insira o Nome: ");
            nome = Console.ReadLine();
            nome = ValidarNome(nome);

            return nome;
        }

        static string ValidarNome(string nome)
        {
            while (nome.Trim() == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nome Inválido");
                Console.ResetColor();
                Console.WriteLine("Insira o Nome novamente: ");

                nome = Console.ReadLine();
            }

        return nome;
        }
    

    }




}
 


