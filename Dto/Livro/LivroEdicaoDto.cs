﻿using Api_RepositoryPattern.Dto.Livro.Vinculo;

namespace Api_RepositoryPattern.Dto.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
