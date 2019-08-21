using Blog161.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog161.Models
{
    public class Mensagem
    {
        public int MensagemId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataMensagem { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categorias { get; set; }
        public int CategoriaId { get; set; }

        public ICollection<Comentario> Comentario { get; set; } 

        //[InverseProperty("Mensagems")]
        //public virtual User User { get; set; }

    }
}

//-Chave primária -Título -Descrição -Data da mensagem -Categoria