namespace BlazorDbzPersonagem.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Planeta OriginPlanet { get; set; }
        public List<Transformacao> Transformations { get; set; } = new List<Transformacao>();
    }

    public class Planeta
    {
        public string Name { get; set; }
    }

    public class Transformacao
    {
        public string Name { get; set; }
    }
}