using System.ComponentModel.DataAnnotations;

namespace BlogHS.Domain.Base
{
    public abstract class BaseEntity { }

    public abstract class BaseEntity<TKey> : BaseEntity
    {
        [Key]
        public TKey Id { get; set; }
    }
}
