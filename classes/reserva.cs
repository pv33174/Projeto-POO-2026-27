public class Reserva
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public EspacoDesportivo Espaco { get; set; }
    public DateTime Dia { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFim { get; set; }
    public string Estado { get; set; }


//Construtor
    public Reserva(int id, string nomeCliente, string nomeEspaco, DateTime dia, TimeSpan horaInicio, TimeSpan horaFim, string estado)
    {
        Id = id;
        Cliente = nomeCliente;
        Espaco = nommeEspaco;
        DateTime = dia;
        TimeSpan = horaInicio;
        TimeSpan = horaFim;
        Estado = estado;
    }

 //Metodos
    public void ConfirmarReserva()
    {
        Estado = "Confirmada";
    }


    public void CancelarReserva()
    {
        Estado = "Cancelada";
    }

    public void AdicionarEquipamento()
    {
        
    }




}


  
