using BlogHS.Domain.Base;

namespace BlogHS.Domain.Entities.Entry
{
    public partial class Entry : IAggregateRoot
    {
        public Entry(string? title, string? content, string? thumbnail, DateTimeOffset? creationDate, DateTimeOffset? modificationDate)
        {
            Title = title;
            Content = content;
            Thumbnail = thumbnail;
            CreationDate = creationDate;
            ModificationDate = modificationDate;
        }

        public Entry(string? title, string? content, string? thumbnail, DateTimeOffset? creationDate)
        {
            Title = title;
            Content = content;
            Thumbnail = thumbnail;
            CreationDate = creationDate;
        }

        public void Update(string? title, string? content, string? thumbnail, DateTimeOffset? creationDate, DateTimeOffset? modificationDate)
        {
            Title = title;
            Content = content;
            Thumbnail = thumbnail;
            CreationDate = creationDate;
            ModificationDate = modificationDate;
        }
    }
}
