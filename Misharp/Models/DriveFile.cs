using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class DriveFile {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public string Md5 { get; set; }
		public decimal Size { get; set; }
		public bool IsSensitive { get; set; }
		public string? Blurhash { get; set; }
		public class DriveFilePropertiesObject {
			public decimal Width { get; set; }
			public decimal Height { get; set; }
			public decimal Orientation { get; set; }
			public string AvgColor { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class DriveFilePropertiesObject: {\n");
				sb.Append($"  width: {this.Width}\n");
				sb.Append($"  height: {this.Height}\n");
				sb.Append($"  orientation: {this.Orientation}\n");
				sb.Append($"  avgColor: {this.AvgColor}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public DriveFilePropertiesObject Properties { get; set; }
		public string Url { get; set; }
		public string? ThumbnailUrl { get; set; }
		public string? Comment { get; set; }
		public string? FolderId { get; set; }
		public DriveFolder? Folder { get; set; }
		public string? UserId { get; set; }
		public UserLite? User { get; set; }
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
			var sbProperties = new StringBuilder();
			sbProperties.Append("  properties: [\n");
			if (this.Properties != null)
			{
				sbProperties.Append(this.Properties);
				sbProperties.Replace("\n", "\n    ");
				sbProperties.Append("\n");
			}
			sbProperties.Append("  ]\n");
			sb.Append(sbProperties);
			sb.Append($"  url: {this.Url}\n");
			sb.Append($"  thumbnailUrl: {this.ThumbnailUrl}\n");
			sb.Append($"  comment: {this.Comment}\n");
			sb.Append($"  folderId: {this.FolderId}\n");
			var sbFolder = new StringBuilder();
			sbFolder.Append("  folder: [\n");
			if (this.Folder != null)
			{
				sbFolder.Append(this.Folder);
				sbFolder.Replace("\n", "\n    ");
				sbFolder.Append("\n");
			}
			sbFolder.Append("  ]\n");
			sb.Append(sbFolder);
			sb.Append($"  userId: {this.UserId}\n");
			var sbUser = new StringBuilder();
			sbUser.Append("  user: [\n");
			if (this.User != null)
			{
				sbUser.Append(this.User);
				sbUser.Replace("\n", "\n    ");
				sbUser.Append("\n");
			}
			sbUser.Append("  ]\n");
			sb.Append(sbUser);
			sb.Append("}");
			return sb.ToString();
		}
	}
}
