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
			var result = await _app.Request<Model.EmptyResponse>("emoji", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}