using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class ServerInfoApi {
		private Misharp.App _app;
		public ServerInfoApi(Misharp.App app)
		{
			_app = app;
		}
		public class ServerInfoResponse {
			public string Machine { get; set; }
		public class CpuProperty {
			public string Model { get; set; }
			public decimal Cores { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  model: {this.Model}\n");
				sb.Append($"  cores: {this.Cores}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
			public CpuProperty Cpu { get; set; }
		public class MemProperty {
			public decimal Total { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  total: {this.Total}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
			public MemProperty Mem { get; set; }
		public class FsProperty {
			public decimal Total { get; set; }
			public decimal Used { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  total: {this.Total}\n");
				sb.Append($"  used: {this.Used}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
			public FsProperty Fs { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  machine: {this.Machine}\n");
				var sbcpu = new StringBuilder();
				sbcpu.Append("  cpu: {\n");
				if (this.Cpu != null)
				{
					sbcpu.Append(this.Cpu);
					sbcpu.Replace("\n", "\n  ");
					sbcpu.Append("\n");
				}
				sbcpu.Append("  }\n");
				sb.Append(sbcpu);
				var sbmem = new StringBuilder();
				sbmem.Append("  mem: {\n");
				if (this.Mem != null)
				{
					sbmem.Append(this.Mem);
					sbmem.Replace("\n", "\n  ");
					sbmem.Append("\n");
				}
				sbmem.Append("  }\n");
				sb.Append(sbmem);
				var sbfs = new StringBuilder();
				sbfs.Append("  fs: {\n");
				if (this.Fs != null)
				{
					sbfs.Append(this.Fs);
					sbfs.Replace("\n", "\n  ");
					sbfs.Append("\n");
				}
				sbfs.Append("  }\n");
				sb.Append(sbfs);
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