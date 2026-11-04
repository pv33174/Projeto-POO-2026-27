class Reserva
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public EspacoDesportivo Espaco { get; set; }
    public DateTime Dia { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFim { get; set; }
    public string Estado { get; set; }

    public void ConfirmarReserva()
    {
        Estado = "Confirmada";
    }

    public void CancelarReserva()
    {
        Estado = "Cancelada";
    }
}




/*
    Id: int
    Cliente: Cliente (a classe)
    Espaço: EspacoDesportivo (a classe)
    Dia: DateTime
    HoraInicio: TimseSpan
    HoraFim: TimeSpan
    Estado: string
    valorTotal: double <------------------------sugiro eliminar


    Métodos:
    adicionarEquipamento <------sugiro eliminar pq o equipamento está relacionado com o espaço e nao com a reserva
    cancelarReserva
    confirmarReserva
    calcularValorTotal <------------------------sugiro eliminar
*/