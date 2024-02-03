using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class ServerInfoApi {
		private Misharp.App _app;
		public ServerInfoApi(Misharp.App app)
		{
			_app = app;
		}
		public class ServerinfoResponse {
			public string Machine { get; set; }
			public object Cpu { get; set; }
			public object Mem { get; set; }
			public object Fs { get; set; }
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
		public async Task<Models.Response<ServerinfoResponse>> Serverinfo()
		{
			var result = await _app.Request<ServerinfoResponse>("server-info", useToken: false);
			return result;
		}
	}
}