namespace TarefaMVC.Models
{
    public class Animal
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Tipo { get; set; }

        public string? Raca { get; set; }

    public Animal(){
        
    }

    public Animal(
        int id,
         string name,
         string tipo,
         string raca
         )
    {
      Id = id;
      Name = name;
      Tipo = tipo;
      Raca = raca;
    }
  }
}