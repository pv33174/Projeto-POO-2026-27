public class Sistema
{
 //Atributos
    public List<Utilizador> Utilizadores { get; set; } = new List<Utilizador>();
    public List<EspacoDesportivo> Espacos { get; set; } = new List<EspacoDesportivo>();
    public List<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
    public List<Reserva> Reserva { get; set; } = new List<Reserva>();


    //Metodos do Espaco
        public void CriarEspaco() {}
        public void EliminarEspaco() {}
        public void AlterarEspaco() {}

        //Metodos Equipamentos
        public void CriarEquipamento() {}
        public void EliminarEquipamento() {}
        public void AlterarEquipamento() {}
        
        //Metodos Admin-Utilizadores
        public void ConsultarUtilizadores() {}
        public void EliminarUtilizador() {}
}
