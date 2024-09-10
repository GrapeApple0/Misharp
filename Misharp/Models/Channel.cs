using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Channel {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? LastNotedAt { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public string? UserId { get; set; }
		public string? BannerUrl { get; set; }
		public List<string> PinnedNoteIds { get; set; }
		public string Color { get; set; }
		public bool IsArchived { get; set; }
		public decimal UsersCount { get; set; }
		public decimal NotesCount { get; set; }
		public bool IsSensitive { get; set; }
		public bool AllowRenoteToExternal { get; set; }
		public bool IsFollowing { get; set; }
		public bool IsFavorited { get; set; }
		public List<Model.Note> PinnedNotes { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Channel: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  lastNotedAt: {this.LastNotedAt}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  description: {this.Description}\n");
			sb.Append($"  userId: {this.UserId}\n");
			sb.Append($"  bannerUrl: {this.BannerUrl}\n");
			sb.Append("  pinnedNoteIds: [\n");
			if (this.PinnedNoteIds != null && this.PinnedNoteIds.Count > 0)
			{
				var sbPinnedNoteIds = new StringBuilder();
				sbPinnedNoteIds.Append("    ");
				this.PinnedNoteIds.ForEach(item => sbPinnedNoteIds.Append(item).Append(",\n"));
				sbPinnedNoteIds.Replace("\n", "\n    ");
				sbPinnedNoteIds.Length -= 4;
				sb.Append(sbPinnedNoteIds);
			}
			sb.Append("  ]\n");
			sb.Append($"  color: {this.Color}\n");
			sb.Append($"  isArchived: {this.IsArchived}\n");
			sb.Append($"  usersCount: {this.UsersCount}\n");
			sb.Append($"  notesCount: {this.NotesCount}\n");
			sb.Append($"  isSensitive: {this.IsSensitive}\n");
			sb.Append($"  allowRenoteToExternal: {this.AllowRenoteToExternal}\n");
			sb.Append($"  isFollowing: {this.IsFollowing}\n");
			sb.Append($"  isFavorited: {this.IsFavorited}\n");
			sb.Append("  pinnedNotes: [\n");
			if (this.PinnedNotes != null && this.PinnedNotes.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.PinnedNotes.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.PinnedNotes.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  ]\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}
