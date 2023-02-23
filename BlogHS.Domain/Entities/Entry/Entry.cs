using BlogHS.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace BlogHS.Domain.Entities.Entry
{
    public partial class Entry : BaseEntity<int>
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        [Required]
        public string? ThumbnailUrl { get; set; }
        [Required]
        public string? ThumbnailContent { get; set; }
        [Required]
        public DateTimeOffset? CreationDate { get; set; }
        public DateTimeOffset? ModificationDate { get; set; }
    }
}