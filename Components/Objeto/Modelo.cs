
public class Detencion{
    public int Id { get; set; }
    public string Nombre { get; set; } ="";
    public string Apellido { get; set; } ="";
    public string Pasaporte { get; set; } ="";
    public DateTime FechaDetencion { get; set; } = DateTime.Now;
    public DateOnly FechaNacomiento { get; set; }
    public double Latitud { get; set; }
    public double Longitud { get; set; }   

    public string Coordenadas  ()
    {
      return  $"{Latitud}, {Longitud}";
    }
}