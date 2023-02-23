using BlogHS.Domain.Base;

namespace BlogHS.Domain.Entities.Entry
{
    public partial class Entry : IAggregateRoot
    {
        public Entry(string? title, string? content, string? thumbnailUrl, string? thumbnailContent, DateTimeOffset? creationDate, DateTimeOffset? modificationDate)
        {
            Title = title;
            Content = content;
            ThumbnailUrl = thumbnailUrl;
            ThumbnailContent = thumbnailContent;
            CreationDate = creationDate;
            ModificationDate = modificationDate;
        }

        public Entry(string? title, string? content, string? thumbnailUrl, string? thumbnailContent, DateTimeOffset? creationDate)
        {
            Title = title;
            Content = content;
            ThumbnailUrl = thumbnailUrl;
            ThumbnailContent = thumbnailContent;
            CreationDate = creationDate;
        }

        public void Update(string? title, string? content, string? thumbnailUrl, string? thumbnailContent, DateTimeOffset? creationDate, DateTimeOffset? modificationDate)
        {
            Title = title;
            Content = content;
            ThumbnailUrl = thumbnailUrl;
            ThumbnailContent = thumbnailContent;
            CreationDate = creationDate;
            ModificationDate = modificationDate;
        }
    }
}
