using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class PingApi {
		private Misharp.App _app;
		public PingApi(Misharp.App app)
		{
			_app = app;
		}
		public class PingResponse {
			public decimal Pong { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  pong: {this.Pong}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<PingResponse>> Ping()
		{
			Response<PingResponse> result = await _app.Request<PingResponse>("ping", useToken: false);
			return result;
		}
	}
}