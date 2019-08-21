using System.Collections.Generic;

namespace Blog161.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        public List<Mensagem> Mensagens { get; set; }
    }
}
//-Chave primária -Descrição