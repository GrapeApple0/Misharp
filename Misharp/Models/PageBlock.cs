using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class PageBlock {
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PageBlock: {\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}
