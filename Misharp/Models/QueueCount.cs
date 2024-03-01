using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class QueueCount {
		public decimal Waiting { get; set; }
		public decimal Active { get; set; }
		public decimal Completed { get; set; }
		public decimal Failed { get; set; }
		public decimal Delayed { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class QueueCount: {\n");
			sb.Append($"  waiting: {this.Waiting}\n");
			sb.Append($"  active: {this.Active}\n");
			sb.Append($"  completed: {this.Completed}\n");
			sb.Append($"  failed: {this.Failed}\n");
			sb.Append($"  delayed: {this.Delayed}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}
