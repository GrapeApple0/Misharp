using System.Text;
namespace Misharp.Model
{
    public class DriveFile
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Md5 { get; set; }
        public decimal Size { get; set; }
        public bool IsSensitive { get; set; }
        public string? Blurhash { get; set; }
        public object Properties { get; set; }
        public string Url { get; set; }
        public string? ThumbnailUrl { get; set; }
        public string? Comment { get; set; }
        public string? FolderId { get; set; }
        public object? Folder { get; set; }
        public string? UserId { get; set; }
        public object? User { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DriveFile: {\n");
            sb.Append($"  id: {this.Id}\n");
            sb.Append($"  createdAt: {this.CreatedAt}\n");
            sb.Append($"  name: {this.Name}\n");
            sb.Append($"  type: {this.Type}\n");
            sb.Append($"  md5: {this.Md5}\n");
            sb.Append($"  size: {this.Size}\n");
            sb.Append($"  isSensitive: {this.IsSensitive}\n");
            sb.Append($"  blurhash: {this.Blurhash}\n");
            sb.Append($"  properties: {this.Properties}\n");
            sb.Append($"  url: {this.Url}\n");
            sb.Append($"  thumbnailUrl: {this.ThumbnailUrl}\n");
            sb.Append($"  comment: {this.Comment}\n");
            sb.Append($"  folderId: {this.FolderId}\n");
            sb.Append($"  folder: {this.Folder}\n");
            sb.Append($"  userId: {this.UserId}\n");
            sb.Append($"  user: {this.User}\n");
            sb.Append("}");
            return sb.ToString();
        }
    }
}
