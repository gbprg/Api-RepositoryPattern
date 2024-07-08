using Api_RepositoryPattern.Dto.Livro.Vinculo;
using Api_RepositoryPattern.Model;

namespace Api_RepositoryPattern.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
