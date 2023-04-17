using System.ComponentModel.DataAnnotations.Schema;

namespace APIEstatisticasStacks.Repository.Entitys
{
    [Table("ESTATISTICAS_STACK_VAGAS")]
    public class EstatisticasStackVagas : Entity
    {
        public string? tecnologia { get; set; }
        public string? item_stack { get; set; }
        public int pontos { get; set; }
    }
}