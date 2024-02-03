using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class EmojisApi {
		private Misharp.App _app;
		public EmojisApi(Misharp.App app)
		{
			_app = app;
		}
		public class EmojisResponse {
			public List<EmojiSimple> Emojis { get; set; }
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
		public async Task<Models.Response<EmojisResponse>> Emojis()
		{
			var result = await _app.Request<EmojisResponse>("emojis", useToken: false);
			return result;
		}
	}
}