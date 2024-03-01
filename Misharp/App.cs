using Misharp.Controls;
using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Misharp;

public class App
{
    public string Host { get; set; }
    public string Token { get; set; }
    private bool UseHttps { get; }

    //public AdminApi AdminApi { get; }
    public AnnouncementsApi AnnouncementsApi { get; }
    public AntennasApi AntennasApi { get; }
    public ApApi ApApi { get; }
    public AppApi AppApi { get; }
    public AuthApi AuthApi { get; }
    public BlockingApi BlockingApi { get; }
    public ChannelsApi ChannelsApi { get; }
    public ClipsApi ClipsApi { get; }
    public DriveApi DriveApi { get; }
    public EmailAddressApi EmailAddressApi { get; }
    public EndpointApi EndpointApi { get; }
    public EndpointsApi EndpointsApi { get; }
    public FederationApi FederationApi { get; }
    public FollowingApi FollowingApi { get; }
    public GalleryApi GalleryApi { get; }
    public GetOnlineUsersCountApi GetOnlineUsersCountApi { get; }
    public GetAvatarDecorationsApi GetAvatarDecorationsApi { get; }
    public HashtagsApi HashtagsApi { get; }
    public IApi IApi { get; }
    public InviteApi InviteApi { get; }
    public MetaApi MetaApi { get; }
    public EmojisApi EmojisApi { get; }
    public EmojiApi EmojiApi { get; }
    public MuteApi MuteApi { get; }
    public RenoteMuteApi RenoteMuteApi { get; }
    public MyApi MyApi { get; }
    public NotesApi NotesApi { get; }
    public NotificationsApi NotificationsApi { get; }
    //public PagesApi PagesApi { get; }
    public FlashApi FlashApi { get; }
    public PingApi PingApi { get; }
    public PinnedUsersApi PinnedUsersApi { get; }
    public PromoApi PromoApi { get; }
    public RolesApi RolesApi { get; }
    public RequestResetPasswordApi RequestResetPasswordApi { get; }
    public ResetDbApi ResetDbApi { get; }
    public ResetPasswordApi ResetPasswordApi { get; }
    public ServerInfoApi ServerInfoApi { get; }
    public StatsApi StatsApi { get; }
    public SwApi SwApi { get; }
    public UsernameApi UsernameApi { get; }
    public UsersApi UsersApi { get; }
    public FetchRssApi FetchRssApi { get; }
    public FetchExternalResourcesApi FetchExternalResourcesApi { get; }
    public RetentionApi RetentionApi { get; }
    public Streaming Streaming { get; }

    public App(string host, string token, bool useHttps = true)
    {
        this.Host = host;
        this.Token = token;
        this.UseHttps = useHttps;
        //this.AdminApi = new AdminApi(this);
        this.AnnouncementsApi = new AnnouncementsApi(this);
        this.AntennasApi = new AntennasApi(this);
        this.ApApi = new ApApi(this);
        this.AppApi = new AppApi(this);
        this.AuthApi = new AuthApi(this);
        this.BlockingApi = new BlockingApi(this);
        this.ChannelsApi = new ChannelsApi(this);
        this.ClipsApi = new ClipsApi(this);
        this.DriveApi = new DriveApi(this);
        this.EmailAddressApi = new EmailAddressApi(this);
        this.EndpointApi = new EndpointApi(this);
        this.EndpointsApi = new EndpointsApi(this);
        this.FederationApi = new FederationApi(this);
        this.FollowingApi = new FollowingApi(this);
        this.GalleryApi = new GalleryApi(this);
        this.GetOnlineUsersCountApi = new GetOnlineUsersCountApi(this);
        this.GetAvatarDecorationsApi = new GetAvatarDecorationsApi(this);
        this.HashtagsApi = new HashtagsApi(this);
        this.IApi = new IApi(this);
        this.InviteApi = new InviteApi(this);
        this.MetaApi = new MetaApi(this);
        this.EmojisApi = new EmojisApi(this);
        this.EmojiApi = new EmojiApi(this);
        this.MuteApi = new MuteApi(this);
        this.RenoteMuteApi = new RenoteMuteApi(this);
        this.MyApi = new MyApi(this);
        this.NotesApi = new NotesApi(this);
        this.NotificationsApi = new NotificationsApi(this);
        //this.PagesApi = new PagesApi(this);
        this.FlashApi = new FlashApi(this);
        this.PingApi = new PingApi(this);
        this.PinnedUsersApi = new PinnedUsersApi(this);
        this.PromoApi = new PromoApi(this);
        this.RolesApi = new RolesApi(this);
        this.RequestResetPasswordApi = new RequestResetPasswordApi(this);
        this.ResetDbApi = new ResetDbApi(this);
        this.ResetPasswordApi = new ResetPasswordApi(this);
        this.ServerInfoApi = new ServerInfoApi(this);
        this.StatsApi = new StatsApi(this);
        this.SwApi = new SwApi(this);
        this.UsernameApi = new UsernameApi(this);
        this.UsersApi = new UsersApi(this);
        this.FetchRssApi = new FetchRssApi(this);
        this.FetchExternalResourcesApi = new FetchExternalResourcesApi(this);
        this.RetentionApi = new RetentionApi(this);
        this.Streaming = new Streaming(this);
    }

    public async Task Request(string endpoint, Dictionary<string, object?> ps, bool useToken = false, HttpStatusCode successStatusCode = HttpStatusCode.NoContent)
    {
        using var client = new HttpClient();
        var param = (from kv in ps
                     where kv.Value != null
                     select kv).ToDictionary(kv => kv.Key, kv => kv.Value);

        foreach (var p in param)
            if (p.Value is Enum e)
                param[p.Key] = e.GetStringValue() ?? p.Value;

        if (useToken)
        {
            var i = new Dictionary<string, object>
            {
                { "i", this.Token }
            };
            param = param
                .Concat(i.Where(pair =>
                    !param.ContainsKey(pair.Key))
                ).ToDictionary(
                    pair => pair.Key,
                    pair => pair.Value
                );
        }

        var data = JsonSerializer.Serialize(param);
        var content = new StringContent(data, Encoding.UTF8, "application/json");
        var response = await client.PostAsync($"http{(UseHttps ? 's' : string.Empty)}://{this.Host}/api/{endpoint}", content);
        var resultContent = await response.Content.ReadAsStringAsync();

        JsonSerializerOptions options = new()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };
        if (response.StatusCode == successStatusCode)
        {
            return;
        }
        throw new Exception(resultContent);
    }

    public async Task<Model.Response<T>> Request<T>(string endpoint, Dictionary<string, object?> ps, bool useToken = false, HttpStatusCode successStatusCode = HttpStatusCode.OK) where T : class
    {
        using var client = new HttpClient();
        var param = (from kv in ps
                     where kv.Value != null
                     select kv).ToDictionary(kv => kv.Key, kv => kv.Value);

        foreach (var p in param)
            if (p.Value is Enum e)
                param[p.Key] = e.GetStringValue() ?? p.Value;

        if (useToken)
        {
            var i = new Dictionary<string, object>
            {
                { "i", this.Token }
            };
            param = param
                .Concat(i.Where(pair =>
                    !param.ContainsKey(pair.Key))
                ).ToDictionary(
                    pair => pair.Key,
                    pair => pair.Value
                );
        }

        var data = JsonSerializer.Serialize(param);
        var content = new StringContent(data, Encoding.UTF8, "application/json");
        var response = await client.PostAsync($"http{(UseHttps ? 's' : string.Empty)}://{this.Host}/api/{endpoint}", content);
        var resultContent = await response.Content.ReadAsStringAsync();

        JsonSerializerOptions options = new()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };
        if (response.StatusCode == successStatusCode)
        {
            if (response.StatusCode == HttpStatusCode.NoContent) return new Model.Response<T>(response.StatusCode);
            var result = JsonSerializer.Deserialize<T>(resultContent, options);
            if (result != null) return new Model.Response<T>(response.StatusCode, result);
        }
        throw new Exception(resultContent);
    }

    public async Task<Model.Response<T>> Request<T>(string endpoint, bool useToken = false, HttpStatusCode successStatusCode = HttpStatusCode.OK) where T : class
    {
        using var client = new HttpClient();
        var param = new Dictionary<string, object>();

        if (useToken)
        {
            var i = new Dictionary<string, object>
            {
                { "i", this.Token }
            };
            param = param
                .Concat(i.Where(pair =>
                    !param.ContainsKey(pair.Key))
                ).ToDictionary(
                    pair => pair.Key,
                    pair => pair.Value
                );
        }

        var data = JsonSerializer.Serialize(param);
        var content = new StringContent(data, Encoding.UTF8, "application/json");
        var response = await client.PostAsync($"http{(UseHttps ? 's' : String.Empty)}://{this.Host}/api/{endpoint}", content);
        var resultContent = await response.Content.ReadAsStringAsync();

        JsonSerializerOptions options = new()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };
        if (response.StatusCode == successStatusCode)
        {
            if (response.StatusCode == HttpStatusCode.NoContent) return new Model.Response<T>(response.StatusCode);
            var result = JsonSerializer.Deserialize<T>(resultContent, options);
            if (result != null) return new Model.Response<T>(response.StatusCode, result);
        }
        throw new Exception(resultContent);
    }

    private static byte[] ReadFully(Stream input)
    {
        byte[] buffer = new byte[16 * 1024];
        using var ms = new MemoryStream();
        int read;
        while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
        {
            ms.Write(buffer, 0, read);
        }
        return ms.ToArray();
    }

    public async Task<Model.Response<T>> RequestFormData<T>(string endpoint, Dictionary<string, object?> ps, bool useToken = false, HttpStatusCode successStatusCode = HttpStatusCode.OK) where T : class
    {
        using var client = new HttpClient();
        MultipartFormDataContent content = new MultipartFormDataContent();
        foreach (var param in ps)
        {
            if (param.Value is Stream stream)
            {
                if (stream is FileStream fs)
                {
                    var dataContent = new ByteArrayContent(ReadFully(fs));
                    dataContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
                    {
                        Name = "file",
                        FileName = fs.Name
                    };
                    content.Add(dataContent);
                }
            }
            else if (param.Value != null)
            {
                var c = new StringContent($"{param.Value}", new UTF8Encoding(false));
                if (param.Value is bool p) c = new StringContent($"{(p ? "true" : "false")}", new UTF8Encoding(false));
                if (param.Value is Enum e) c = new StringContent($"{e.GetStringValue() ?? param.Value}", new UTF8Encoding(false));
                c.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
                {
                    Name = param.Key
                };
                content.Add(c);
            }
        }
        if (useToken)
        {
            var i = new StringContent(this.Token, new UTF8Encoding(false));
            i.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
            {
                Name = "i"
            };
            content.Add(i);
        }
        HttpResponseMessage response = await client.PostAsync($"http{(UseHttps ? 's' : String.Empty)}://{this.Host}/api/{endpoint}", content);

        var resultContent = await response.Content.ReadAsStringAsync();

        JsonSerializerOptions options = new()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };
        if (response.StatusCode == successStatusCode)
        {
            if (response.StatusCode == HttpStatusCode.NoContent) return new Model.Response<T>(response.StatusCode);
            var result = JsonSerializer.Deserialize<T>(resultContent, options);
            if (result != null) return new Model.Response<T>(response.StatusCode, result);
        }
        throw new Exception(resultContent);
    }
}