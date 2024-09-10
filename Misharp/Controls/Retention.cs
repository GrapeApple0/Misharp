using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class RetentionApi {
		private Misharp.App _app;
		public RetentionApi(Misharp.App app)
		{
			_app = app;
		}
		public class RetentionItemResponseObject {
			public DateTime CreatedAt { get; set; }
			public decimal Users { get; set; }
			public Dictionary<string, decimal> Data { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class RetentionItemResponseObject: {\n");
					sb.Append($"  createdAt: {this.CreatedAt}\n");
					sb.Append($"  users: {this.Users}\n");
					var sbData = new StringBuilder();
					sbData.Append("  data: [\n");
					if (this.Data != null)
					{
						sbData.Append(this.Data);
						sbData.Replace("\n", "\n    ");
						sbData.Append("\n");
					}
					sbData.Append("  ]\n");
					sb.Append(sbData);
					sb.Append("}");
					return sb.ToString();
				}
		}
		public async Task<Response<List<RetentionItemResponseObject>>> Retention()
		{
			var result = await _app.Request<List<RetentionItemResponseObject>>("retention", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}