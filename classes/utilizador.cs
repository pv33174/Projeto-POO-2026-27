using System.ComponentModel.DataAnnotations;

public class Utilizador
    {
        public int Id { get; set; }

        public string NomeUtilizador { get; set; }
        public string Email { get; set; }
        public string PalavraPasse { get; set; }

        //Metodos Utilizador
        public void EfetuarLogin() {}
        public void AtualizarPerfil() {}

        // Construtor 
        public Utilizador(int id, string nomeUtilizador, string email, string palavraPasse)
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

            novoUtilizador.ID = AtribuirID();
            novoUtilizador.nome = PedirNome();
            novoUtilizador.email = PedirEmail();
            novoUtilizador.palavraPasse = PedirPalavraPasse();

            Utilizadores.Add(novoUtilizador);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Utilizador registado com Sucesso!");
            Console.ResetColor();


        static string PedirNome()
        {
            string nome;
            Console.WriteLine("Insira o seu Nome: ");
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

        static string PedirEmail()
        {
            string email;
            Console.WriteLine("Insira o seu Email: ");
            email = Console.ReadLine();
            email = ValidarEmail(email);

            return email;
        }

        // Email válido: não vazio e com @
        static string ValidarEmail(string email)
        {
            while (email.Trim() == "" || !email.Contains("@"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Email Inválido");
                Console.ResetColor();
                Console.WriteLine("Insira o seu Email novamente: ");

                nome = Console.ReadLine();
            }
        }

        static string PedirPalavraPasse()
        {
            Console.WriteLine("Insira a Palavra-passe: ");
            string pass = Console.ReadLine();

                while (pass.Trim() == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Palavra-passe inválida.");
                    Console.ResetColor();
                    Console.WriteLine("Insira a Palavra-passe novamente: ");
                    pass = Console.ReadLine();
                }

            return pass;
        }

       static int AtribuirId()
        {
            int maior = 0;

            foreach (Utilizador u in Utilizadores)
            {
                if (u.Id > maior)
                {
                    maior = u.Id;
                }
            }

            return maior + 1;
        }

        static void ListarUtilizadores()
        {
            foreach (Utilizador u in Utilizadores)
            {
                Console.WriteLine("ID: " + u.Id + " | Nome: " + u.NomeUtilizador + " | Email: " + u.Email);
            }
        }
    

    }




}
 


