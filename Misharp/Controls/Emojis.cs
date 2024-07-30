using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class EmojisApi {
		private Misharp.App _app;
		public EmojisApi(Misharp.App app)
		{
			_app = app;
		}
		public class EmojisResponse {
			public List<Model.EmojiSimple> Emojis { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append("  emojis: {\n");
				if (this.Emojis != null && this.Emojis.Count > 0)
				{
					var sb2 = new StringBuilder();
					sb2.Append("    ");
					this.Emojis.ForEach(item =>
					{
						sb2.Append(item).Append(",");
						if (item != this.Emojis.Last()) sb2.Append("\n");
					});
					sb2.Replace("\n", "\n    ");
					sb2.Append("\n");
					sb.Append(sb2);
				}
				sb.Append("  }\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<EmojisResponse>> Emojis()
		{
			Response<EmojisResponse> result = await _app.Request<EmojisResponse>("emojis", useToken: false);
			return result;
		}
	}
}