using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class ReversiApi {
		private Misharp.App _app;
		public ReversiApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<List<ReversiGameLite>>> Games(string sinceId,string untilId,int limit = 10,bool my = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "my", my },
			};
			var result = await _app.Request<List<ReversiGameLite>>("reversi/games", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<UserLite>>> Invitations()
		{
			var result = await _app.Request<List<UserLite>>("reversi/invitations", useToken: true);
			return result;
		}
		public async Task<Models.Response<ReversiGameDetailed>> Showgame(string gameId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "gameId", gameId },
			};
			var result = await _app.Request<ReversiGameDetailed>("reversi/show-game", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Surrender(string gameId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "gameId", gameId },
			};
			var result = await _app.Request<Models.EmptyResponse>("reversi/surrender", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class ReversiVerifyResponse {
			public bool Desynced { get; set; }
			public object? Game { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  desynced: {this.Desynced}\n");
				sb.Append($"  game: {this.Game}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Models.Response<ReversiVerifyResponse>> Verify(string gameId,string crc32)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "gameId", gameId },
				{ "crc32", crc32 },
			};
			var result = await _app.Request<ReversiVerifyResponse>("reversi/verify", param, useToken: false);
			return result;
		}
	}
}