using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class UsernameApi {
		private Misharp.App _app;
		public UsernameApi(Misharp.App app)
		{
			_app = app;
		}
		public class AvailableResponse {
			public bool Available { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  available: {this.Available}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<AvailableResponse>> Available(string username)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "username", username },
			};
			var result = await _app.Request<AvailableResponse>("username/available", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}