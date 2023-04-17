using System.ComponentModel.DataAnnotations;

namespace APIEstatisticasStacks.Repository.Entitys
{
    public abstract class Entity
    {
        [Key]
        public int id { get; set; }
    }
}