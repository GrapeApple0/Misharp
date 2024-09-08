using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class NoteFavorite {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public Note Note { get; set; }
		public string NoteId { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NoteFavorite: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			var sbNote = new StringBuilder();
			sbNote.Append("  note: [\n");
			if (this.Note != null)
			{
				sbNote.Append(this.Note);
				sbNote.Replace("\n", "\n    ");
				sbNote.Append("\n");
			}
			sbNote.Append("  ]\n");
			sb.Append(sbNote);
			sb.Append($"  noteId: {this.NoteId}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}
