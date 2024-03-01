using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class RoleCondFormulaValueNot {
		public string Id { get; set; }
		public string Type { get; set; }
		public RoleCondFormulaValue Value { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RoleCondFormulaValueNot: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  type: {this.Type}\n");
			var sbvalue = new StringBuilder();
			sbvalue.Append("  value: {\n");
			if (this.Value != null)
			{
				sbvalue.Append(this.Value);
				sbvalue.Replace("\n", "\n    ");
				sbvalue.Append("\n");
			}
			sbvalue.Append("  }\n");
			sb.Append(sbvalue);
			sb.Append("}");
			return sb.ToString();
		}
	}
}
