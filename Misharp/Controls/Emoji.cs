using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class EmojiApi {
		private Misharp.App _app;
		public EmojiApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmojiDetailed>> Emoji(string name)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
			};
			Response<Model.EmojiDetailed> result = await _app.Request<Model.EmojiDetailed>("emoji", param, useToken: false);
			return result;
		}
	}
}