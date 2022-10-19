public class Escuderia{
    public String Nombre{get;set;}
    public DateTime Fecha_fundacion{get;set}
    public int Numero_premios{get;set;}

    public ICollection<Persona> Fundadores{get;set;}
    public ICollection<Piloto> Pilotos{get;set;}
    public ICollection<Contrato> Contratos{get;set;} 
    
}