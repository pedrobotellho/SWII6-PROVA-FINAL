﻿namespace SWII6_Prova2_WebSite.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public bool Status { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public int IdUsuarioUpdate { get; set; }
    }
}
