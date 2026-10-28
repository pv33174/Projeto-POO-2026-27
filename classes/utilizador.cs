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