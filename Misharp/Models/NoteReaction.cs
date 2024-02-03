using System.Collections.Generic;
using System.Text;
namespace Misharp.Model {
	public class NoteReaction {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public UserLite User { get; set; }
		public string Type { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NoteReaction: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			var sbuser = new StringBuilder();
			sbuser.Append("  user: {\n");
			if (this.User != null)
			{
				sbuser.Append(this.User);
				sbuser.Replace("\n", "\n    ");
				sbuser.Append("\n");
			}
			sbuser.Append("  }\n");
			sb.Append(sbuser);
			sb.Append($"  type: {this.Type}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}
