using Misharp.Model;
using System.Text;
namespace Misharp.Controls
{
    public class DriveApi
    {
        private Misharp.App _app;
        public Drive.FilesApi FilesApi;
        public Drive.FoldersApi FoldersApi;
        public DriveApi(Misharp.App app)
        {
            _app = app;
            FilesApi = new Drive.FilesApi(_app);
            FoldersApi = new Drive.FoldersApi(_app);
        }
        public class DriveResponse
        {
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
        public async Task<DriveResponse> Drive()
        {
            var result = await _app.Request<DriveResponse>("drive", true);
            return result;
        }
        public async Task<List<DriveFile>> Files(string sinceId, string untilId, int limit = 10, string? folderId = null, string? type = null, SortEnum? sort = null)
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
            var result = await _app.Request<List<DriveFile>>("drive/files", param, true);
            return result;
        }
        public enum SortEnum
        {
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
        public async Task<List<DriveFolder>> Folders(string sinceId, string untilId, int limit = 10, string? folderId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "folderId", folderId },
            };
            var result = await _app.Request<List<DriveFolder>>("drive/folders", param, true);
            return result;
        }
        public async Task<List<DriveFile>> Stream(string sinceId, string untilId, string type, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "type", type },
            };
            var result = await _app.Request<List<DriveFile>>("drive/stream", param, true);
            return result;
        }
    }
}
namespace Misharp.Controls.Drive
{
    public class FilesApi
    {
        private Misharp.App _app;
        public FilesApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<Note>> Attachednotes(string sinceId, string untilId, string fileId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "limit", limit },
                { "fileId", fileId },
            };
            var result = await _app.Request<List<Note>>("drive/files/attached-notes", param, true);
            return result;
        }
        public async Task<DriveFile> Create(Stream file, string? folderId = null, string? name = null, string? comment = null, bool isSensitive = false, bool force = false)
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
            var result = await _app.RequestFormData<DriveFile>("drive/files/create", param, true);
            return result;
        }
        public async Task<List<DriveFile>> Findbyhash(string md5)
        {
            var param = new Dictionary<string, object?>
            {
                { "md5", md5 },
            };
            var result = await _app.Request<List<DriveFile>>("drive/files/find-by-hash", param, true);
            return result;
        }
        public async Task<List<DriveFile>> Find(string name, string? folderId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "folderId", folderId },
            };
            var result = await _app.Request<List<DriveFile>>("drive/files/find", param, true);
            return result;
        }
        public async Task<DriveFile> Show(string fileId, string url)
        {
            var param = new Dictionary<string, object?>
            {
                { "fileId", fileId },
                { "url", url },
            };
            var result = await _app.Request<DriveFile>("drive/files/show", param, true);
            return result;
        }
        public async Task<DriveFile> Update(string fileId, string name, bool isSensitive, string? folderId = null, string? comment = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "fileId", fileId },
                { "folderId", folderId },
                { "name", name },
                { "isSensitive", isSensitive },
                { "comment", comment },
            };
            var result = await _app.Request<DriveFile>("drive/files/update", param, true);
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
        public async Task<DriveFolder> Create(string name = "Untitled", string? parentId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "parentId", parentId },
            };
            var result = await _app.Request<DriveFolder>("drive/folders/create", param, true);
            return result;
        }
        public async Task<List<DriveFolder>> Find(string name, string? parentId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "parentId", parentId },
            };
            var result = await _app.Request<List<DriveFolder>>("drive/folders/find", param, true);
            return result;
        }
        public async Task<DriveFolder> Show(string folderId)
        {
            var param = new Dictionary<string, object?>
            {
                { "folderId", folderId },
            };
            var result = await _app.Request<DriveFolder>("drive/folders/show", param, true);
            return result;
        }
        public async Task<DriveFolder> Update(string folderId, string name, string? parentId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "folderId", folderId },
                { "name", name },
                { "parentId", parentId },
            };
            var result = await _app.Request<DriveFolder>("drive/folders/update", param, true);
            return result;
        }
    }
}