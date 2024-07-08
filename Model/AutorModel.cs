using System.Text.Json.Serialization;

namespace Api_RepositoryPattern.Model
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SobreNome { get; set; }
        [JsonIgnore]

        public ICollection<LivroModel> Livros { get; set; }
    }
}
