namespace BlogHS.Domain.Models.Entry
{
    public class BaseEntryDTO
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? ThumbnailUrl { get; set; }
        public string? ThumbnailContent { get; set; }
        public DateTimeOffset? CreationDate { get; set; }
        public DateTimeOffset? ModificationDate { get; set; }
    }
}
