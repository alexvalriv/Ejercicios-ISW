public class Piloto : Persona{
    public DateTime Fecha_nacimiento{get;set;}
    public String Nacionalidad{get;set;}

    public Contrato Contrato{get;set;}
    public ICollection<Mecanico> Mecanicos{get;set;}
    public Escuderia Escuderia{get;set;}
}