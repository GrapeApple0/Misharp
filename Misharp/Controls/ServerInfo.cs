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
		public class CpuObject {
			public string Model { get; set; }
			public decimal Cores { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class CpuObject: {\n");
					sb.Append($"  model: {this.Model}\n");
					sb.Append($"  cores: {this.Cores}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
			public CpuObject Cpu { get; set; }
		public class MemObject {
			public decimal Total { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class MemObject: {\n");
					sb.Append($"  total: {this.Total}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
			public MemObject Mem { get; set; }
		public class FsObject {
			public decimal Total { get; set; }
			public decimal Used { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class FsObject: {\n");
					sb.Append($"  total: {this.Total}\n");
					sb.Append($"  used: {this.Used}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
			public FsObject Fs { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  machine: {this.Machine}\n");
				var sbCpu = new StringBuilder();
				sbCpu.Append("  cpu: [\n");
				if (this.Cpu != null)
				{
					sbCpu.Append(this.Cpu);
					sbCpu.Replace("\n", "\n    ");
					sbCpu.Append("\n");
				}
				sbCpu.Append("  ]\n");
				sb.Append(sbCpu);
				var sbMem = new StringBuilder();
				sbMem.Append("  mem: [\n");
				if (this.Mem != null)
				{
					sbMem.Append(this.Mem);
					sbMem.Replace("\n", "\n    ");
					sbMem.Append("\n");
				}
				sbMem.Append("  ]\n");
				sb.Append(sbMem);
				var sbFs = new StringBuilder();
				sbFs.Append("  fs: [\n");
				if (this.Fs != null)
				{
					sbFs.Append(this.Fs);
					sbFs.Replace("\n", "\n    ");
					sbFs.Append("\n");
				}
				sbFs.Append("  ]\n");
				sb.Append(sbFs);
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<ServerInfoResponse>> ServerInfo()
		{
			var result = await _app.Request<ServerInfoResponse>("server-info", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}