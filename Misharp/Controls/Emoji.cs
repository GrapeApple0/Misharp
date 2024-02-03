using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class EmojiApi {
		private Misharp.App _app;
		public EmojiApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<EmojiDetailed>> Emoji(string name)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
			};
			var result = await _app.Request<EmojiDetailed>("emoji", param, useToken: false);
			return result;
		}
	}
}