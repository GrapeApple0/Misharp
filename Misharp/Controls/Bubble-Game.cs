using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class BubbleGameApi {
		private Misharp.App _app;
		public BubbleGameApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<List<object>>> Ranking(string gameMode)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "gameMode", gameMode },
			};
			var result = await _app.Request<List<object>>("bubble-game/ranking", param, useToken: false);
			return result;
		}
	}
}