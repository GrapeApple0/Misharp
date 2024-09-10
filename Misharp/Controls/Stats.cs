using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class StatsApi {
		private Misharp.App _app;
		public StatsApi(Misharp.App app)
		{
			_app = app;
		}
		public class StatsResponse {
			public decimal NotesCount { get; set; }
			public decimal OriginalNotesCount { get; set; }
			public decimal UsersCount { get; set; }
			public decimal OriginalUsersCount { get; set; }
			public decimal Instances { get; set; }
			public decimal DriveUsageLocal { get; set; }
			public decimal DriveUsageRemote { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  notesCount: {this.NotesCount}\n");
				sb.Append($"  originalNotesCount: {this.OriginalNotesCount}\n");
				sb.Append($"  usersCount: {this.UsersCount}\n");
				sb.Append($"  originalUsersCount: {this.OriginalUsersCount}\n");
				sb.Append($"  instances: {this.Instances}\n");
				sb.Append($"  driveUsageLocal: {this.DriveUsageLocal}\n");
				sb.Append($"  driveUsageRemote: {this.DriveUsageRemote}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<StatsResponse>> Stats()
		{
			var result = await _app.Request<StatsResponse>("stats", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}