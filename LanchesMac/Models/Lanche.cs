﻿namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public  string Nome { get; set; }
        public string DecricaoCurta { get; set;}
        public string DecricaoDetalhada { get; set;}
        public decimal Preco { get; set;}
        public string ImagemUrl { get; set;}
        public string ImagemThumbnailUrl { get; set;}
        public bool IsLanchePreferido { get; set;}
        public bool EmEstoque { get; set;}

        public int CategoriaId { get; set; }
            public virtual Categoria Categoria { get; set; }
    }
}