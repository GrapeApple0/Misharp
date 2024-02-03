using System.Collections.Generic;
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
			var sbnote = new StringBuilder();
			sbnote.Append("  note: {\n");
			if (this.Note != null)
			{
				sbnote.Append(this.Note);
				sbnote.Replace("\n", "\n    ");
				sbnote.Append("\n");
			}
			sbnote.Append("  }\n");
			sb.Append(sbnote);
			sb.Append($"  noteId: {this.NoteId}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}
