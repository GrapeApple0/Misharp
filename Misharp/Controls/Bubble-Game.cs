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
		public async Task<Model.Response<List<object>>> Ranking(string gameMode)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "gameMode", gameMode },
			};
			Model.Response<List<object>> result = await _app.Request<List<object>>("bubble-game/ranking", param, useToken: false);
			return result;
		}
	}
}