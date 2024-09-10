using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class DriveApi {
		private Misharp.App _app;
		public Drive.FilesApi FilesApi;
		public Drive.FoldersApi FoldersApi;
		public DriveApi(Misharp.App app)
		{
			_app = app;
			FilesApi = new Drive.FilesApi(_app);
			FoldersApi = new Drive.FoldersApi(_app);
		}
		public class DriveResponse {
			public decimal Capacity { get; set; }
			public decimal Usage { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  capacity: {this.Capacity}\n");
				sb.Append($"  usage: {this.Usage}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<DriveResponse>> Drive()
		{
			var result = await _app.Request<DriveResponse>("drive", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.DriveFile>>> Files(int limit = 10,string? sinceId = null,string? untilId = null,string? folderId = null,string? type = null,FilesSortEnum? sort = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "folderId", folderId },
				{ "type", type },
				{ "sort", sort },
			};
			var result = await _app.Request<List<Model.DriveFile>>("drive/files", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public enum FilesSortEnum {
			[StringValue("+createdAt")]
			PluscreatedAt,
			[StringValue("-createdAt")]
			MinuscreatedAt,
			[StringValue("+name")]
			Plusname,
			[StringValue("-name")]
			Minusname,
			[StringValue("+size")]
			Plussize,
			[StringValue("-size")]
			Minussize,
		}
		public async Task<Response<List<Model.DriveFolder>>> Folders(int limit = 10,string? sinceId = null,string? untilId = null,string? folderId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "folderId", folderId },
			};
			var result = await _app.Request<List<Model.DriveFolder>>("drive/folders", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.DriveFile>>> Stream(string type,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "type", type },
			};
			var result = await _app.Request<List<Model.DriveFile>>("drive/stream", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
namespace Misharp.Controls.Drive {
	public class FilesApi
	{
		private Misharp.App _app;
		public FilesApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<Model.Note>>> AttachedNotes(string fileId,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
				{ "fileId", fileId },
			};
			var result = await _app.Request<List<Model.Note>>("drive/files/attached-notes", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.DriveFile>> Create(Stream file,string? folderId = null,string? name = null,string? comment = null,bool isSensitive = false,bool force = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "folderId", folderId },
				{ "name", name },
				{ "comment", comment },
				{ "isSensitive", isSensitive },
				{ "force", force },
				{ "file", file },
			};
			var result = await _app.RequestFormData<Model.DriveFile>("drive/files/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string fileId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "fileId", fileId },
			};
			var result = await _app.Request<Model.EmptyResponse>("drive/files/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.DriveFile>>> FindByHash(string md5)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "md5", md5 },
			};
			var result = await _app.Request<List<Model.DriveFile>>("drive/files/find-by-hash", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.DriveFile>>> Find(string name,string? folderId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
				{ "folderId", folderId },
			};
			var result = await _app.Request<List<Model.DriveFile>>("drive/files/find", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.DriveFile>> Show(string fileId,string url)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "fileId", fileId },
				{ "url", url },
			};
			var result = await _app.Request<Model.DriveFile>("drive/files/show", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.DriveFile>> Update(string fileId,string name,bool isSensitive,string? folderId = null,string? comment = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "fileId", fileId },
				{ "folderId", folderId },
				{ "name", name },
				{ "isSensitive", isSensitive },
				{ "comment", comment },
			};
			var result = await _app.Request<Model.DriveFile>("drive/files/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> UploadFromUrl(string url,string? folderId = null,bool isSensitive = false,string? comment = null,string? marker = null,bool force = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "url", url },
				{ "folderId", folderId },
				{ "isSensitive", isSensitive },
				{ "comment", comment },
				{ "marker", marker },
				{ "force", force },
			};
			var result = await _app.Request<Model.EmptyResponse>("drive/files/upload-from-url", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
	public class FoldersApi
	{
		private Misharp.App _app;
		public FoldersApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.DriveFolder>> Create(string name = "Untitled",string? parentId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
				{ "parentId", parentId },
			};
			var result = await _app.Request<Model.DriveFolder>("drive/folders/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string folderId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "folderId", folderId },
			};
			var result = await _app.Request<Model.EmptyResponse>("drive/folders/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.DriveFolder>>> Find(string name,string? parentId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
				{ "parentId", parentId },
			};
			var result = await _app.Request<List<Model.DriveFolder>>("drive/folders/find", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.DriveFolder>> Show(string folderId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "folderId", folderId },
			};
			var result = await _app.Request<Model.DriveFolder>("drive/folders/show", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.DriveFolder>> Update(string folderId,string name,string? parentId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "folderId", folderId },
				{ "name", name },
				{ "parentId", parentId },
			};
			var result = await _app.Request<Model.DriveFolder>("drive/folders/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}