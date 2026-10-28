class EspacoDesportivo
{
    public int IdEspaco{get; set; }
    public string NomeEspaco{get; set; }
    public string TipoEspaco{get; set; }
    public string Localizacao{get; set; }
    public int CapacidadeMax{get; set; }
    public string EstadoEspaco{get; set; }
    public List<Equipamento> Equipamentos = new List<Equipamento>();
    public bool VerificarDisponibilidade()
    {
        if (EstadoEspaco=="Disponível")
        {
            return true;
        }
        if(EstadoEspaco=="Ocupado")
        {
            return false;
        }
    }
}

/*
    Id: int
    Nome: string
    Tipo: string
    Localizacao: string  <----------------- sugiro adicionar, é requisito do projeto
    CapacidadeMaxima: int <---------------- sugiro adicionar, é requisito do projeto
    Estado: string (disponivel ou indisponivel)
    Equipamentos: List<Equipamento>

    Métodos:
    verificarDisponibilidade
*/