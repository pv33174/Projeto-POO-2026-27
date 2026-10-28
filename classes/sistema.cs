class Sistema
{
 //Listas
    public List<Utilizador> Utilizadores { get; set; } = new List<Utilizador>();
    public List<EspacoDesportivo> Espacos { get; set; } = new List<EspacoDesportivo>();
    public List<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
    public List<Reserva> Reserva { get; set; } = new List<Reserva>();
}

/*
    Métodos:
    Reservas: List<Reserva>  <----------------sugestão para depois para as estatisticas
    EspacosDesportivos: List<EspacoDesportivo> 
    Equipamentos: List<Equipamento>
    utilizadores: List<Utilizador> 
*/