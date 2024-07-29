using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class ServerInfoApi {
		private Misharp.App _app;
		public ServerInfoApi(Misharp.App app)
		{
			_app = app;
		}
		public class ServerInfoResponse {
			public string Machine { get; set; }
			public JsonNode Cpu { get; set; }
			public JsonNode Mem { get; set; }
			public JsonNode Fs { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  machine: {this.Machine}\n");
				sb.Append($"  cpu: {this.Cpu}\n");
				sb.Append($"  mem: {this.Mem}\n");
				sb.Append($"  fs: {this.Fs}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<ServerInfoResponse>> ServerInfo()
		{
			Response<ServerInfoResponse> result = await _app.Request<ServerInfoResponse>("server-info", useToken: false);
			return result;
		}
	}
}