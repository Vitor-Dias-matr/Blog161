using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog161.Models
{
    public class Comentario
    {
        public int ComentarioId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataComentario { get; set; }
        public string Autor { get; set; }


        public int MensagemId { get; set; }
        [DisplayName("MensagemId")]
        [ForeignKey("MensagemId")]
        public Mensagem Mensagem { get; set; }

    }
}
//-Chave primária -Chave estrangeira para referenciar a mensagem -Titulo -Descrição 
//    -Data do comentário -Autor(pode ser string mesmo)