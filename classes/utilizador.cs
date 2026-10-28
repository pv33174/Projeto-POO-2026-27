 public class Utilizador
    {
        public int Id { get; set; }

        public string NomeUtilizador { get; set; }
        public string Email { get; set; }
        public string PalavraPasse { get; set; }
        public string NumeroTelefone { get; set; }

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
            NumeroTelefone = numeroTelefone;
        }
    }
 


/*
    Id: int
    NomeUtilizador: string
    email: string
    palavraPasse: string
    numeroTelefone: string <-------------- sugiro eliminar, não é requisito do projeto

    Métodos:
    registarUtilizador
    efeturarLogin
    atualizarPerfil
*/