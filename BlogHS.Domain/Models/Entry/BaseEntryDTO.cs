namespace BlogHS.Domain.Models.Entry
{
    public class BaseEntryDTO
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Thumbnail { get; set; }
        public DateTimeOffset? CreationDate { get; set; }
        public DateTimeOffset? ModificationDate { get; set; }
    }
}
