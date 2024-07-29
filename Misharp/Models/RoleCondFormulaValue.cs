using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class RoleCondFormulaValue {
		public string Id { get; set; }
		public string Type { get; set; }
		public List<RoleCondFormulaValue> Values { get; set; }
		public decimal Value { get; set; }
		public string RoleId { get; set; }
		public decimal Sec { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RoleCondFormulaValue: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  type: {this.Type}\n");
			sb.Append("  values: {\n");
			if (this.Values != null && this.Values.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.Values.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.Values.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  }\n");
			sb.Append($"  value: {this.Value}\n");
			sb.Append($"  roleId: {this.RoleId}\n");
			sb.Append($"  sec: {this.Sec}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}
