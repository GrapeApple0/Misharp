using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class GetAvatarDecorationsApi {
		private Misharp.App _app;
		public GetAvatarDecorationsApi(Misharp.App app)
		{
			_app = app;
		}
		public class GetAvatarDecorationsItemResponseObject {
			public string Id { get; set; }
			public string Name { get; set; }
			public string Description { get; set; }
			public string Url { get; set; }
			public List<string> RoleIdsThatCanBeUsedThisDecoration { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class GetAvatarDecorationsItemResponseObject: {\n");
					sb.Append($"  id: {this.Id}\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  description: {this.Description}\n");
					sb.Append($"  url: {this.Url}\n");
					sb.Append("  roleIdsThatCanBeUsedThisDecoration: [\n");
					if (this.RoleIdsThatCanBeUsedThisDecoration != null && this.RoleIdsThatCanBeUsedThisDecoration.Count > 0)
					{
						var sbRoleIdsThatCanBeUsedThisDecoration = new StringBuilder();
						sbRoleIdsThatCanBeUsedThisDecoration.Append("    ");
						this.RoleIdsThatCanBeUsedThisDecoration.ForEach(item => sbRoleIdsThatCanBeUsedThisDecoration.Append(item).Append(",\n"));
						sbRoleIdsThatCanBeUsedThisDecoration.Replace("\n", "\n    ");
						sbRoleIdsThatCanBeUsedThisDecoration.Length -= 4;
						sb.Append(sbRoleIdsThatCanBeUsedThisDecoration);
					}
					sb.Append("  ]\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public async Task<Response<List<GetAvatarDecorationsItemResponseObject>>> GetAvatarDecorations()
		{
			var result = await _app.Request<List<GetAvatarDecorationsItemResponseObject>>("get-avatar-decorations", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}