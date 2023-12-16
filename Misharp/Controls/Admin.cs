using Misharp.Model;
using System.Text;
namespace Misharp.Controls
{
    public class AdminApi
    {
        private Misharp.App _app;
        public Admin.AccountsApi AccountsApi;
        public Admin.AdApi AdApi;
        public Admin.AnnouncementsApi AnnouncementsApi;
        public Admin.AvatarDecorationsApi AvatarDecorationsApi;
        public Admin.DriveApi DriveApi;
        public Admin.EmojiApi EmojiApi;
        public Admin.FederationApi FederationApi;
        public Admin.InviteApi InviteApi;
        public Admin.PromoApi PromoApi;
        public Admin.QueueApi QueueApi;
        public Admin.RelaysApi RelaysApi;
        public Admin.RolesApi RolesApi;
        public AdminApi(Misharp.App app)
        {
            _app = app;
            AccountsApi = new Admin.AccountsApi(_app);
            AdApi = new Admin.AdApi(_app);
            AnnouncementsApi = new Admin.AnnouncementsApi(_app);
            AvatarDecorationsApi = new Admin.AvatarDecorationsApi(_app);
            DriveApi = new Admin.DriveApi(_app);
            EmojiApi = new Admin.EmojiApi(_app);
            FederationApi = new Admin.FederationApi(_app);
            InviteApi = new Admin.InviteApi(_app);
            PromoApi = new Admin.PromoApi(_app);
            QueueApi = new Admin.QueueApi(_app);
            RelaysApi = new Admin.RelaysApi(_app);
            RolesApi = new Admin.RolesApi(_app);
        }
        public class AdminMetaResponse
        {
            public bool CacheRemoteFiles { get; set; }
            public bool CacheRemoteSensitiveFiles { get; set; }
            public bool EmailRequiredForSignup { get; set; }
            public bool EnableHcaptcha { get; set; }
            public string? HcaptchaSiteKey { get; set; }
            public bool EnableRecaptcha { get; set; }
            public string? RecaptchaSiteKey { get; set; }
            public bool EnableTurnstile { get; set; }
            public string? TurnstileSiteKey { get; set; }
            public string? SwPublickey { get; set; }
            public string? MascotImageUrl { get; set; }
            public string? BannerUrl { get; set; }
            public string? ServerErrorImageUrl { get; set; }
            public string? InfoImageUrl { get; set; }
            public string? NotFoundImageUrl { get; set; }
            public string? IconUrl { get; set; }
            public string? App192IconUrl { get; set; }
            public string? App512IconUrl { get; set; }
            public bool EnableEmail { get; set; }
            public bool EnableServiceWorker { get; set; }
            public bool TranslatorAvailable { get; set; }
            public List<string> SilencedHosts { get; set; }
            public List<string> PinnedUsers { get; set; }
            public List<string> HiddenTags { get; set; }
            public List<string> BlockedHosts { get; set; }
            public List<string> SensitiveWords { get; set; }
            public List<string> DisposableEmailDomains { get; set; }
            public List<string> PreservedUsernames { get; set; }
            public string? HcaptchaSecretKey { get; set; }
            public string? RecaptchaSecretKey { get; set; }
            public string? TurnstileSecretKey { get; set; }
            public string SensitiveMediaDetection { get; set; }
            public string SensitiveMediaDetectionSensitivity { get; set; }
            public bool SetSensitiveFlagAutomatically { get; set; }
            public bool EnableSensitiveMediaDetectionForVideos { get; set; }
            public string? ProxyAccountId { get; set; }
            public string? Email { get; set; }
            public bool SmtpSecure { get; set; }
            public string? SmtpHost { get; set; }
            public decimal? SmtpPort { get; set; }
            public string? SmtpUser { get; set; }
            public string? SmtpPass { get; set; }
            public string? SwPrivateKey { get; set; }
            public bool UseObjectStorage { get; set; }
            public string? ObjectStorageBaseUrl { get; set; }
            public string? ObjectStorageBucket { get; set; }
            public string? ObjectStoragePrefix { get; set; }
            public string? ObjectStorageEndpoint { get; set; }
            public string? ObjectStorageRegion { get; set; }
            public decimal? ObjectStoragePort { get; set; }
            public string? ObjectStorageAccessKey { get; set; }
            public string? ObjectStorageSecretKey { get; set; }
            public bool ObjectStorageUseSSL { get; set; }
            public bool ObjectStorageUseProxy { get; set; }
            public bool ObjectStorageSetPublicRead { get; set; }
            public bool EnableIpLogging { get; set; }
            public bool EnableActiveEmailValidation { get; set; }
            public bool EnableVerifymailApi { get; set; }
            public string? VerifymailAuthKey { get; set; }
            public bool EnableChartsForRemoteUser { get; set; }
            public bool EnableChartsForFederatedInstances { get; set; }
            public bool EnableServerMachineStats { get; set; }
            public bool EnableIdenticonGeneration { get; set; }
            public string ManifestJsonOverride { get; set; }
            public object Policies { get; set; }
            public bool EnableFanoutTimeline { get; set; }
            public bool EnableFanoutTimelineDbFallback { get; set; }
            public decimal PerLocalUserUserTimelineCacheMax { get; set; }
            public decimal PerRemoteUserUserTimelineCacheMax { get; set; }
            public decimal PerUserHomeTimelineCacheMax { get; set; }
            public decimal PerUserListTimelineCacheMax { get; set; }
            public decimal NotesPerOneAd { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  cacheRemoteFiles: {this.CacheRemoteFiles}\n");
                sb.Append($"  cacheRemoteSensitiveFiles: {this.CacheRemoteSensitiveFiles}\n");
                sb.Append($"  emailRequiredForSignup: {this.EmailRequiredForSignup}\n");
                sb.Append($"  enableHcaptcha: {this.EnableHcaptcha}\n");
                sb.Append($"  hcaptchaSiteKey: {this.HcaptchaSiteKey}\n");
                sb.Append($"  enableRecaptcha: {this.EnableRecaptcha}\n");
                sb.Append($"  recaptchaSiteKey: {this.RecaptchaSiteKey}\n");
                sb.Append($"  enableTurnstile: {this.EnableTurnstile}\n");
                sb.Append($"  turnstileSiteKey: {this.TurnstileSiteKey}\n");
                sb.Append($"  swPublickey: {this.SwPublickey}\n");
                sb.Append($"  mascotImageUrl: {this.MascotImageUrl}\n");
                sb.Append($"  bannerUrl: {this.BannerUrl}\n");
                sb.Append($"  serverErrorImageUrl: {this.ServerErrorImageUrl}\n");
                sb.Append($"  infoImageUrl: {this.InfoImageUrl}\n");
                sb.Append($"  notFoundImageUrl: {this.NotFoundImageUrl}\n");
                sb.Append($"  iconUrl: {this.IconUrl}\n");
                sb.Append($"  app192IconUrl: {this.App192IconUrl}\n");
                sb.Append($"  app512IconUrl: {this.App512IconUrl}\n");
                sb.Append($"  enableEmail: {this.EnableEmail}\n");
                sb.Append($"  enableServiceWorker: {this.EnableServiceWorker}\n");
                sb.Append($"  translatorAvailable: {this.TranslatorAvailable}\n");
                sb.Append("  silencedHosts: {\n");
                if (this.SilencedHosts != null && this.SilencedHosts.Count > 0) this.SilencedHosts.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append("  pinnedUsers: {\n");
                if (this.PinnedUsers != null && this.PinnedUsers.Count > 0) this.PinnedUsers.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append("  hiddenTags: {\n");
                if (this.HiddenTags != null && this.HiddenTags.Count > 0) this.HiddenTags.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append("  blockedHosts: {\n");
                if (this.BlockedHosts != null && this.BlockedHosts.Count > 0) this.BlockedHosts.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append("  sensitiveWords: {\n");
                if (this.SensitiveWords != null && this.SensitiveWords.Count > 0) this.SensitiveWords.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append("  disposableEmailDomains: {\n");
                if (this.DisposableEmailDomains != null && this.DisposableEmailDomains.Count > 0) this.DisposableEmailDomains.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append("  preservedUsernames: {\n");
                if (this.PreservedUsernames != null && this.PreservedUsernames.Count > 0) this.PreservedUsernames.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  hcaptchaSecretKey: {this.HcaptchaSecretKey}\n");
                sb.Append($"  recaptchaSecretKey: {this.RecaptchaSecretKey}\n");
                sb.Append($"  turnstileSecretKey: {this.TurnstileSecretKey}\n");
                sb.Append($"  sensitiveMediaDetection: {this.SensitiveMediaDetection}\n");
                sb.Append($"  sensitiveMediaDetectionSensitivity: {this.SensitiveMediaDetectionSensitivity}\n");
                sb.Append($"  setSensitiveFlagAutomatically: {this.SetSensitiveFlagAutomatically}\n");
                sb.Append($"  enableSensitiveMediaDetectionForVideos: {this.EnableSensitiveMediaDetectionForVideos}\n");
                sb.Append($"  proxyAccountId: {this.ProxyAccountId}\n");
                sb.Append($"  email: {this.Email}\n");
                sb.Append($"  smtpSecure: {this.SmtpSecure}\n");
                sb.Append($"  smtpHost: {this.SmtpHost}\n");
                sb.Append($"  smtpPort: {this.SmtpPort}\n");
                sb.Append($"  smtpUser: {this.SmtpUser}\n");
                sb.Append($"  smtpPass: {this.SmtpPass}\n");
                sb.Append($"  swPrivateKey: {this.SwPrivateKey}\n");
                sb.Append($"  useObjectStorage: {this.UseObjectStorage}\n");
                sb.Append($"  objectStorageBaseUrl: {this.ObjectStorageBaseUrl}\n");
                sb.Append($"  objectStorageBucket: {this.ObjectStorageBucket}\n");
                sb.Append($"  objectStoragePrefix: {this.ObjectStoragePrefix}\n");
                sb.Append($"  objectStorageEndpoint: {this.ObjectStorageEndpoint}\n");
                sb.Append($"  objectStorageRegion: {this.ObjectStorageRegion}\n");
                sb.Append($"  objectStoragePort: {this.ObjectStoragePort}\n");
                sb.Append($"  objectStorageAccessKey: {this.ObjectStorageAccessKey}\n");
                sb.Append($"  objectStorageSecretKey: {this.ObjectStorageSecretKey}\n");
                sb.Append($"  objectStorageUseSSL: {this.ObjectStorageUseSSL}\n");
                sb.Append($"  objectStorageUseProxy: {this.ObjectStorageUseProxy}\n");
                sb.Append($"  objectStorageSetPublicRead: {this.ObjectStorageSetPublicRead}\n");
                sb.Append($"  enableIpLogging: {this.EnableIpLogging}\n");
                sb.Append($"  enableActiveEmailValidation: {this.EnableActiveEmailValidation}\n");
                sb.Append($"  enableVerifymailApi: {this.EnableVerifymailApi}\n");
                sb.Append($"  verifymailAuthKey: {this.VerifymailAuthKey}\n");
                sb.Append($"  enableChartsForRemoteUser: {this.EnableChartsForRemoteUser}\n");
                sb.Append($"  enableChartsForFederatedInstances: {this.EnableChartsForFederatedInstances}\n");
                sb.Append($"  enableServerMachineStats: {this.EnableServerMachineStats}\n");
                sb.Append($"  enableIdenticonGeneration: {this.EnableIdenticonGeneration}\n");
                sb.Append($"  manifestJsonOverride: {this.ManifestJsonOverride}\n");
                sb.Append($"  policies: {this.Policies}\n");
                sb.Append($"  enableFanoutTimeline: {this.EnableFanoutTimeline}\n");
                sb.Append($"  enableFanoutTimelineDbFallback: {this.EnableFanoutTimelineDbFallback}\n");
                sb.Append($"  perLocalUserUserTimelineCacheMax: {this.PerLocalUserUserTimelineCacheMax}\n");
                sb.Append($"  perRemoteUserUserTimelineCacheMax: {this.PerRemoteUserUserTimelineCacheMax}\n");
                sb.Append($"  perUserHomeTimelineCacheMax: {this.PerUserHomeTimelineCacheMax}\n");
                sb.Append($"  perUserListTimelineCacheMax: {this.PerUserListTimelineCacheMax}\n");
                sb.Append($"  notesPerOneAd: {this.NotesPerOneAd}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<AdminMetaResponse> Meta()
        {
            var result = await _app.Request<AdminMetaResponse>("admin/meta", true);
            return result;
        }
        public async Task<List<object>> Abuseuserreports(string sinceId, string untilId, int limit = 10, string? state = null, ReporterOriginEnum reporterOrigin = ReporterOriginEnum.Combined, TargetUserOriginEnum targetUserOrigin = TargetUserOriginEnum.Combined, bool forwarded = false)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "state", state },
                { "reporterOrigin", reporterOrigin },
                { "targetUserOrigin", targetUserOrigin },
                { "forwarded", forwarded },
            };
            var result = await _app.Request<List<object>>("admin/abuse-user-reports", param, true);
            return result;
        }
        public enum ReporterOriginEnum
        {
            [StringValue("combined")]
            Combined,
            [StringValue("local")]
            Local,
            [StringValue("remote")]
            Remote,
        }
        public enum TargetUserOriginEnum
        {
            [StringValue("combined")]
            Combined,
            [StringValue("local")]
            Local,
            [StringValue("remote")]
            Remote,
        }
        public class AdminResetpasswordResponse
        {
            public string Password { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  password: {this.Password}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<AdminResetpasswordResponse> Resetpassword(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
            };
            var result = await _app.Request<AdminResetpasswordResponse>("admin/reset-password", param, true);
            return result;
        }
        public class AdminServerinfoResponse
        {
            public string Machine { get; set; }
            public string Os { get; set; }
            public string Node { get; set; }
            public string Psql { get; set; }
            public object Cpu { get; set; }
            public object Mem { get; set; }
            public object Fs { get; set; }
            public object Net { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  machine: {this.Machine}\n");
                sb.Append($"  os: {this.Os}\n");
                sb.Append($"  node: {this.Node}\n");
                sb.Append($"  psql: {this.Psql}\n");
                sb.Append($"  cpu: {this.Cpu}\n");
                sb.Append($"  mem: {this.Mem}\n");
                sb.Append($"  fs: {this.Fs}\n");
                sb.Append($"  net: {this.Net}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<AdminServerinfoResponse> Serverinfo()
        {
            var result = await _app.Request<AdminServerinfoResponse>("admin/server-info", true);
            return result;
        }
        public async Task<List<object>> Showmoderationlogs(string sinceId, string untilId, int limit = 10, string? type = null, string? userId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "type", type },
                { "userId", userId },
            };
            var result = await _app.Request<List<object>>("admin/show-moderation-logs", param, true);
            return result;
        }
        public async Task<List<UserDetailed>> Showusers(SortEnum sort, int limit = 10, int offset = 0, StateEnum state = StateEnum.All, OriginEnum origin = OriginEnum.Combined, string? username = null, string? hostname = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "offset", offset },
                { "sort", sort },
                { "state", state },
                { "origin", origin },
                { "username", username },
                { "hostname", hostname },
            };
            var result = await _app.Request<List<UserDetailed>>("admin/show-users", param, true);
            return result;
        }
        public enum SortEnum
        {
            [StringValue("+follower")]
            Plusfollower,
            [StringValue("-follower")]
            Minusfollower,
            [StringValue("+createdAt")]
            PluscreatedAt,
            [StringValue("-createdAt")]
            MinuscreatedAt,
            [StringValue("+updatedAt")]
            PlusupdatedAt,
            [StringValue("-updatedAt")]
            MinusupdatedAt,
            [StringValue("+lastActiveDate")]
            PluslastActiveDate,
            [StringValue("-lastActiveDate")]
            MinuslastActiveDate,
        }
        public enum StateEnum
        {
            [StringValue("all")]
            All,
            [StringValue("alive")]
            Alive,
            [StringValue("available")]
            Available,
            [StringValue("admin")]
            Admin,
            [StringValue("moderator")]
            Moderator,
            [StringValue("adminOrModerator")]
            AdminOrModerator,
            [StringValue("suspended")]
            Suspended,
        }
        public enum OriginEnum
        {
            [StringValue("combined")]
            Combined,
            [StringValue("local")]
            Local,
            [StringValue("remote")]
            Remote,
        }
    }
}
namespace Misharp.Controls.Admin
{
    public class AccountsApi
    {
        private Misharp.App _app;
        public AccountsApi(Misharp.App app)
        {
            _app = app;
        }
        public class AdminAccountsCreateResponse
        {
            public string Id { get; set; }
            public string? Name { get; set; }
            public string Username { get; set; }
            public string? Host { get; set; }
            public string? AvatarUrl { get; set; }
            public string? AvatarBlurhash { get; set; }
            public List<object> AvatarDecorations { get; set; }
            public bool IsBot { get; set; }
            public bool IsCat { get; set; }
            public object Instance { get; set; }
            public object Emojis { get; set; }
            public string OnlineStatus { get; set; }
            public List<object> BadgeRoles { get; set; }
            public string? Url { get; set; }
            public string? Uri { get; set; }
            public string? MovedTo { get; set; }
            public List<string>? AlsoKnownAs { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public DateTime? LastFetchedAt { get; set; }
            public string? BannerUrl { get; set; }
            public string? BannerBlurhash { get; set; }
            public bool IsLocked { get; set; }
            public bool IsSilenced { get; set; }
            public bool IsSuspended { get; set; }
            public string? Description { get; set; }
            public string? Location { get; set; }
            public string? Birthday { get; set; }
            public string? Lang { get; set; }
            public List<object> Fields { get; set; }
            public List<string> VerifiedLinks { get; set; }
            public decimal FollowersCount { get; set; }
            public decimal FollowingCount { get; set; }
            public decimal NotesCount { get; set; }
            public List<string> PinnedNoteIds { get; set; }
            public List<Note> PinnedNotes { get; set; }
            public string? PinnedPageId { get; set; }
            public object? PinnedPage { get; set; }
            public bool PublicReactions { get; set; }
            public string FfVisibility { get; set; }
            public bool TwoFactorEnabled { get; set; }
            public bool UsePasswordLessLogin { get; set; }
            public bool SecurityKeys { get; set; }
            public List<object> Roles { get; set; }
            public string? Memo { get; set; }
            public string ModerationNote { get; set; }
            public bool IsFollowing { get; set; }
            public bool IsFollowed { get; set; }
            public bool HasPendingFollowRequestFromYou { get; set; }
            public bool HasPendingFollowRequestToYou { get; set; }
            public bool IsBlocking { get; set; }
            public bool IsBlocked { get; set; }
            public bool IsMuted { get; set; }
            public bool IsRenoteMuted { get; set; }
            public string Notify { get; set; }
            public bool WithReplies { get; set; }
            public string? AvatarId { get; set; }
            public string? BannerId { get; set; }
            public bool? IsModerator { get; set; }
            public bool? IsAdmin { get; set; }
            public bool InjectFeaturedNote { get; set; }
            public bool ReceiveAnnouncementEmail { get; set; }
            public bool AlwaysMarkNsfw { get; set; }
            public bool AutoSensitive { get; set; }
            public bool CarefulBot { get; set; }
            public bool AutoAcceptFollowed { get; set; }
            public bool NoCrawle { get; set; }
            public bool PreventAiLearning { get; set; }
            public bool IsExplorable { get; set; }
            public bool IsDeleted { get; set; }
            public string TwoFactorBackupCodesStock { get; set; }
            public bool HideOnlineStatus { get; set; }
            public bool HasUnreadSpecifiedNotes { get; set; }
            public bool HasUnreadMentions { get; set; }
            public bool HasUnreadAnnouncement { get; set; }
            public List<Announcement> UnreadAnnouncements { get; set; }
            public bool HasUnreadAntenna { get; set; }
            public bool HasUnreadChannel { get; set; }
            public bool HasUnreadNotification { get; set; }
            public bool HasPendingReceivedFollowRequest { get; set; }
            public decimal UnreadNotificationsCount { get; set; }
            public List<string> MutedWords { get; set; }
            public List<string> HardMutedWords { get; set; }
            public List<string>? MutedInstances { get; set; }
            public object NotificationRecieveConfig { get; set; }
            public List<string> EmailNotificationTypes { get; set; }
            public List<object> Achievements { get; set; }
            public decimal LoggedInDays { get; set; }
            public object Policies { get; set; }
            public string? Email { get; set; }
            public bool? EmailVerified { get; set; }
            public List<object> SecurityKeysList { get; set; }
            public string Token { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("class User: {\n");
                sb.Append($"  id: {this.Id}\n");
                sb.Append($"  name: {this.Name}\n");
                sb.Append($"  username: {this.Username}\n");
                sb.Append($"  host: {this.Host}\n");
                sb.Append($"  avatarUrl: {this.AvatarUrl}\n");
                sb.Append($"  avatarBlurhash: {this.AvatarBlurhash}\n");
                sb.Append("  avatarDecorations: {\n");
                if (this.AvatarDecorations != null && this.AvatarDecorations.Count > 0) this.AvatarDecorations.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  isBot: {this.IsBot}\n");
                sb.Append($"  isCat: {this.IsCat}\n");
                sb.Append($"  instance: {this.Instance}\n");
                sb.Append($"  emojis: {this.Emojis}\n");
                sb.Append($"  onlineStatus: {this.OnlineStatus}\n");
                sb.Append("  badgeRoles: {\n");
                if (this.BadgeRoles != null && this.BadgeRoles.Count > 0) this.BadgeRoles.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  url: {this.Url}\n");
                sb.Append($"  uri: {this.Uri}\n");
                sb.Append($"  movedTo: {this.MovedTo}\n");
                sb.Append("  alsoKnownAs: {\n");
                if (this.AlsoKnownAs != null && this.AlsoKnownAs.Count > 0) this.AlsoKnownAs.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  createdAt: {this.CreatedAt}\n");
                sb.Append($"  updatedAt: {this.UpdatedAt}\n");
                sb.Append($"  lastFetchedAt: {this.LastFetchedAt}\n");
                sb.Append($"  bannerUrl: {this.BannerUrl}\n");
                sb.Append($"  bannerBlurhash: {this.BannerBlurhash}\n");
                sb.Append($"  isLocked: {this.IsLocked}\n");
                sb.Append($"  isSilenced: {this.IsSilenced}\n");
                sb.Append($"  isSuspended: {this.IsSuspended}\n");
                sb.Append($"  description: {this.Description}\n");
                sb.Append($"  location: {this.Location}\n");
                sb.Append($"  birthday: {this.Birthday}\n");
                sb.Append($"  lang: {this.Lang}\n");
                sb.Append("  fields: {\n");
                if (this.Fields != null && this.Fields.Count > 0) this.Fields.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append("  verifiedLinks: {\n");
                if (this.VerifiedLinks != null && this.VerifiedLinks.Count > 0) this.VerifiedLinks.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  followersCount: {this.FollowersCount}\n");
                sb.Append($"  followingCount: {this.FollowingCount}\n");
                sb.Append($"  notesCount: {this.NotesCount}\n");
                sb.Append("  pinnedNoteIds: {\n");
                if (this.PinnedNoteIds != null && this.PinnedNoteIds.Count > 0) this.PinnedNoteIds.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append("  pinnedNotes: {\n");
                if (this.PinnedNotes != null && this.PinnedNotes.Count > 0)
                {
                    var sb2 = new StringBuilder();
                    sb2.Append("    ");
                    this.PinnedNotes.ForEach(item =>
                    {
                        sb2.Append(item).Append(",");
                        if (item != this.PinnedNotes.Last()) sb2.Append("\n");
                    });
                    sb2.Replace("\n", "\n    ");
                    sb2.Append("\n");
                    sb.Append(sb2);
                }
                sb.Append("  }\n");
                sb.Append($"  pinnedPageId: {this.PinnedPageId}\n");
                sb.Append($"  pinnedPage: {this.PinnedPage}\n");
                sb.Append($"  publicReactions: {this.PublicReactions}\n");
                sb.Append($"  ffVisibility: {this.FfVisibility}\n");
                sb.Append($"  twoFactorEnabled: {this.TwoFactorEnabled}\n");
                sb.Append($"  usePasswordLessLogin: {this.UsePasswordLessLogin}\n");
                sb.Append($"  securityKeys: {this.SecurityKeys}\n");
                sb.Append("  roles: {\n");
                if (this.Roles != null && this.Roles.Count > 0) this.Roles.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  memo: {this.Memo}\n");
                sb.Append($"  moderationNote: {this.ModerationNote}\n");
                sb.Append($"  isFollowing: {this.IsFollowing}\n");
                sb.Append($"  isFollowed: {this.IsFollowed}\n");
                sb.Append($"  hasPendingFollowRequestFromYou: {this.HasPendingFollowRequestFromYou}\n");
                sb.Append($"  hasPendingFollowRequestToYou: {this.HasPendingFollowRequestToYou}\n");
                sb.Append($"  isBlocking: {this.IsBlocking}\n");
                sb.Append($"  isBlocked: {this.IsBlocked}\n");
                sb.Append($"  isMuted: {this.IsMuted}\n");
                sb.Append($"  isRenoteMuted: {this.IsRenoteMuted}\n");
                sb.Append($"  notify: {this.Notify}\n");
                sb.Append($"  withReplies: {this.WithReplies}\n");
                sb.Append($"  avatarId: {this.AvatarId}\n");
                sb.Append($"  bannerId: {this.BannerId}\n");
                sb.Append($"  isModerator: {this.IsModerator}\n");
                sb.Append($"  isAdmin: {this.IsAdmin}\n");
                sb.Append($"  injectFeaturedNote: {this.InjectFeaturedNote}\n");
                sb.Append($"  receiveAnnouncementEmail: {this.ReceiveAnnouncementEmail}\n");
                sb.Append($"  alwaysMarkNsfw: {this.AlwaysMarkNsfw}\n");
                sb.Append($"  autoSensitive: {this.AutoSensitive}\n");
                sb.Append($"  carefulBot: {this.CarefulBot}\n");
                sb.Append($"  autoAcceptFollowed: {this.AutoAcceptFollowed}\n");
                sb.Append($"  noCrawle: {this.NoCrawle}\n");
                sb.Append($"  preventAiLearning: {this.PreventAiLearning}\n");
                sb.Append($"  isExplorable: {this.IsExplorable}\n");
                sb.Append($"  isDeleted: {this.IsDeleted}\n");
                sb.Append($"  twoFactorBackupCodesStock: {this.TwoFactorBackupCodesStock}\n");
                sb.Append($"  hideOnlineStatus: {this.HideOnlineStatus}\n");
                sb.Append($"  hasUnreadSpecifiedNotes: {this.HasUnreadSpecifiedNotes}\n");
                sb.Append($"  hasUnreadMentions: {this.HasUnreadMentions}\n");
                sb.Append($"  hasUnreadAnnouncement: {this.HasUnreadAnnouncement}\n");
                sb.Append("  unreadAnnouncements: {\n");
                if (this.UnreadAnnouncements != null && this.UnreadAnnouncements.Count > 0)
                {
                    var sb2 = new StringBuilder();
                    sb2.Append("    ");
                    this.UnreadAnnouncements.ForEach(item =>
                    {
                        sb2.Append(item).Append(",");
                        if (item != this.UnreadAnnouncements.Last()) sb2.Append("\n");
                    });
                    sb2.Replace("\n", "\n    ");
                    sb2.Append("\n");
                    sb.Append(sb2);
                }
                sb.Append("  }\n");
                sb.Append($"  hasUnreadAntenna: {this.HasUnreadAntenna}\n");
                sb.Append($"  hasUnreadChannel: {this.HasUnreadChannel}\n");
                sb.Append($"  hasUnreadNotification: {this.HasUnreadNotification}\n");
                sb.Append($"  hasPendingReceivedFollowRequest: {this.HasPendingReceivedFollowRequest}\n");
                sb.Append($"  unreadNotificationsCount: {this.UnreadNotificationsCount}\n");
                sb.Append("  mutedWords: {\n");
                if (this.MutedWords != null && this.MutedWords.Count > 0) this.MutedWords.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append("  hardMutedWords: {\n");
                if (this.HardMutedWords != null && this.HardMutedWords.Count > 0) this.HardMutedWords.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append("  mutedInstances: {\n");
                if (this.MutedInstances != null && this.MutedInstances.Count > 0) this.MutedInstances.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  notificationRecieveConfig: {this.NotificationRecieveConfig}\n");
                sb.Append("  emailNotificationTypes: {\n");
                if (this.EmailNotificationTypes != null && this.EmailNotificationTypes.Count > 0) this.EmailNotificationTypes.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append("  achievements: {\n");
                if (this.Achievements != null && this.Achievements.Count > 0) this.Achievements.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  loggedInDays: {this.LoggedInDays}\n");
                sb.Append($"  policies: {this.Policies}\n");
                sb.Append($"  email: {this.Email}\n");
                sb.Append($"  emailVerified: {this.EmailVerified}\n");
                sb.Append("  securityKeysList: {\n");
                if (this.SecurityKeysList != null && this.SecurityKeysList.Count > 0) this.SecurityKeysList.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  token: {this.Token}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }

        public async Task<AdminAccountsCreateResponse> Create(string username, string password)
        {
            var param = new Dictionary<string, object?>
            {
                { "username", username },
                { "password", password },
            };
            var result = await _app.Request<AdminAccountsCreateResponse>("admin/accounts/create", param, false);
            return result;
        }
    }
    public class AdApi
    {
        private Misharp.App _app;
        public AdApi(Misharp.App app)
        {
            _app = app;
        }
    }
    public class AnnouncementsApi
    {
        private Misharp.App _app;
        public AnnouncementsApi(Misharp.App app)
        {
            _app = app;
        }
        public class AdminAnnouncementsCreateResponse
        {
            public string Id { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public string Title { get; set; }
            public string Text { get; set; }
            public string? ImageUrl { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  id: {this.Id}\n");
                sb.Append($"  createdAt: {this.CreatedAt}\n");
                sb.Append($"  updatedAt: {this.UpdatedAt}\n");
                sb.Append($"  title: {this.Title}\n");
                sb.Append($"  text: {this.Text}\n");
                sb.Append($"  imageUrl: {this.ImageUrl}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<AdminAnnouncementsCreateResponse> Create(string title, string text, string? imageUrl = null, IconEnum icon = IconEnum.Info, DisplayEnum display = DisplayEnum.Normal, bool forExistingUsers = false, bool silence = false, bool needConfirmationToRead = false, string? userId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "title", title },
                { "text", text },
                { "imageUrl", imageUrl },
                { "icon", icon },
                { "display", display },
                { "forExistingUsers", forExistingUsers },
                { "silence", silence },
                { "needConfirmationToRead", needConfirmationToRead },
                { "userId", userId },
            };
            var result = await _app.Request<AdminAnnouncementsCreateResponse>("admin/announcements/create", param, true);
            return result;
        }
        public async Task<List<object>> List(string sinceId, string untilId, int limit = 10, string? userId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "userId", userId },
            };
            var result = await _app.Request<List<object>>("admin/announcements/list", param, true);
            return result;
        }
    }
    public class AvatarDecorationsApi
    {
        private Misharp.App _app;
        public AvatarDecorationsApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<object>> List(string sinceId, string untilId, int limit = 10, string? userId = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "userId", userId },
            };
            var result = await _app.Request<List<object>>("admin/avatar-decorations/list", param, true);
            return result;
        }
    }
    public class DriveApi
    {
        private Misharp.App _app;
        public DriveApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<DriveFile>> Files(string sinceId, string untilId, int limit = 10, string? userId = null, string? type = null, OriginEnum origin = OriginEnum.Local, string? hostname = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "userId", userId },
                { "type", type },
                { "origin", origin },
                { "hostname", hostname },
            };
            var result = await _app.Request<List<DriveFile>>("admin/drive/files", param, true);
            return result;
        }
        public class AdminDriveShowfileResponse
        {
            public string Id { get; set; }
            public DateTime CreatedAt { get; set; }
            public string? UserId { get; set; }
            public string? UserHost { get; set; }
            public string Md5 { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public decimal Size { get; set; }
            public string? Comment { get; set; }
            public string? Blurhash { get; set; }
            public object Properties { get; set; }
            public bool? StoredInternal { get; set; }
            public string? Url { get; set; }
            public string? ThumbnailUrl { get; set; }
            public string? WebpublicUrl { get; set; }
            public string? AccessKey { get; set; }
            public string? ThumbnailAccessKey { get; set; }
            public string? WebpublicAccessKey { get; set; }
            public string? Uri { get; set; }
            public string? Src { get; set; }
            public string? FolderId { get; set; }
            public bool IsSensitive { get; set; }
            public bool IsLink { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  id: {this.Id}\n");
                sb.Append($"  createdAt: {this.CreatedAt}\n");
                sb.Append($"  userId: {this.UserId}\n");
                sb.Append($"  userHost: {this.UserHost}\n");
                sb.Append($"  md5: {this.Md5}\n");
                sb.Append($"  name: {this.Name}\n");
                sb.Append($"  type: {this.Type}\n");
                sb.Append($"  size: {this.Size}\n");
                sb.Append($"  comment: {this.Comment}\n");
                sb.Append($"  blurhash: {this.Blurhash}\n");
                sb.Append($"  properties: {this.Properties}\n");
                sb.Append($"  storedInternal: {this.StoredInternal}\n");
                sb.Append($"  url: {this.Url}\n");
                sb.Append($"  thumbnailUrl: {this.ThumbnailUrl}\n");
                sb.Append($"  webpublicUrl: {this.WebpublicUrl}\n");
                sb.Append($"  accessKey: {this.AccessKey}\n");
                sb.Append($"  thumbnailAccessKey: {this.ThumbnailAccessKey}\n");
                sb.Append($"  webpublicAccessKey: {this.WebpublicAccessKey}\n");
                sb.Append($"  uri: {this.Uri}\n");
                sb.Append($"  src: {this.Src}\n");
                sb.Append($"  folderId: {this.FolderId}\n");
                sb.Append($"  isSensitive: {this.IsSensitive}\n");
                sb.Append($"  isLink: {this.IsLink}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<AdminDriveShowfileResponse> Showfile(string fileId, string url)
        {
            var param = new Dictionary<string, object?>
            {
                { "fileId", fileId },
                { "url", url },
            };
            var result = await _app.Request<AdminDriveShowfileResponse>("admin/drive/show-file", param, true);
            return result;
        }
    }
    public class EmojiApi
    {
        private Misharp.App _app;
        public EmojiApi(Misharp.App app)
        {
            _app = app;
        }
        public class AdminEmojiCopyResponse
        {
            public string Id { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  id: {this.Id}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<AdminEmojiCopyResponse> Copy(string emojiId)
        {
            var param = new Dictionary<string, object?>
            {
                { "emojiId", emojiId },
            };
            var result = await _app.Request<AdminEmojiCopyResponse>("admin/emoji/copy", param, true);
            return result;
        }
        public async Task<List<object>> Listremote(string sinceId, string untilId, string? query = null, string? host = null, int limit = 10, bool exactMode = false)
        {
            var param = new Dictionary<string, object?>
            {
                { "query", query },
                { "host", host },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "exactMode", exactMode },
            };
            var result = await _app.Request<List<object>>("admin/emoji/list-remote", param, true);
            return result;
        }
        public async Task<List<object>> List(string sinceId, string untilId, string? query = null, int limit = 10, bool exactMode = false)
        {
            var param = new Dictionary<string, object?>
            {
                { "query", query },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "exactMode", exactMode },
            };
            var result = await _app.Request<List<object>>("admin/emoji/list", param, true);
            return result;
        }
    }
    public class FederationApi
    {
        private Misharp.App _app;
        public FederationApi(Misharp.App app)
        {
            _app = app;
        }
    }
    public class InviteApi
    {
        private Misharp.App _app;
        public InviteApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<object>> Create(int count = 1, string? expiresAt = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "count", count },
                { "expiresAt", expiresAt },
            };
            var result = await _app.Request<List<object>>("admin/invite/create", param, true);
            return result;
        }
        public async Task<List<object>> List(SortEnum sort, int limit = 30, int offset = 0, TypeEnum type = TypeEnum.All)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "offset", offset },
                { "type", type },
                { "sort", sort },
            };
            var result = await _app.Request<List<object>>("admin/invite/list", param, true);
            return result;
        }
    }
    public class PromoApi
    {
        private Misharp.App _app;
        public PromoApi(Misharp.App app)
        {
            _app = app;
        }
    }
    public class QueueApi
    {
        private Misharp.App _app;
        public QueueApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<object>> Deliverdelayed()
        {
            var result = await _app.Request<List<object>>("admin/queue/deliver-delayed", true);
            return result;
        }
        public async Task<List<object>> Inboxdelayed()
        {
            var result = await _app.Request<List<object>>("admin/queue/inbox-delayed", true);
            return result;
        }
        public class AdminQueueStatsResponse
        {
            public QueueCount Deliver { get; set; }
            public QueueCount Inbox { get; set; }
            public QueueCount Db { get; set; }
            public QueueCount ObjectStorage { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                var sbdeliver = new StringBuilder();
                sbdeliver.Append("  deliver: {\n");
                if (this.Deliver != null)
                {
                    sbdeliver.Append(this.Deliver);
                    sbdeliver.Replace("\n", "\n    ");
                    sbdeliver.Append("\n");
                }
                sbdeliver.Append("  }\n");
                sb.Append(sbdeliver);
                var sbinbox = new StringBuilder();
                sbinbox.Append("  inbox: {\n");
                if (this.Inbox != null)
                {
                    sbinbox.Append(this.Inbox);
                    sbinbox.Replace("\n", "\n    ");
                    sbinbox.Append("\n");
                }
                sbinbox.Append("  }\n");
                sb.Append(sbinbox);
                var sbdb = new StringBuilder();
                sbdb.Append("  db: {\n");
                if (this.Db != null)
                {
                    sbdb.Append(this.Db);
                    sbdb.Replace("\n", "\n    ");
                    sbdb.Append("\n");
                }
                sbdb.Append("  }\n");
                sb.Append(sbdb);
                var sbobjectStorage = new StringBuilder();
                sbobjectStorage.Append("  objectStorage: {\n");
                if (this.ObjectStorage != null)
                {
                    sbobjectStorage.Append(this.ObjectStorage);
                    sbobjectStorage.Replace("\n", "\n    ");
                    sbobjectStorage.Append("\n");
                }
                sbobjectStorage.Append("  }\n");
                sb.Append(sbobjectStorage);
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<AdminQueueStatsResponse> Stats()
        {
            var result = await _app.Request<AdminQueueStatsResponse>("admin/queue/stats", true);
            return result;
        }
    }
    public class RelaysApi
    {
        private Misharp.App _app;
        public RelaysApi(Misharp.App app)
        {
            _app = app;
        }
        public class AdminRelaysAddResponse
        {
            public string Id { get; set; }
            public string Inbox { get; set; }
            public string Status { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  id: {this.Id}\n");
                sb.Append($"  inbox: {this.Inbox}\n");
                sb.Append($"  status: {this.Status}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<AdminRelaysAddResponse> Add(string inbox)
        {
            var param = new Dictionary<string, object?>
            {
                { "inbox", inbox },
            };
            var result = await _app.Request<AdminRelaysAddResponse>("admin/relays/add", param, true);
            return result;
        }
        public async Task<List<object>> List()
        {
            var result = await _app.Request<List<object>>("admin/relays/list", true);
            return result;
        }
    }
    public class RolesApi
    {
        private Misharp.App _app;
        public RolesApi(Misharp.App app)
        {
            _app = app;
        }
    }
    public enum IconEnum
    {
        [StringValue("info")]
        Info,
        [StringValue("warning")]
        Warning,
        [StringValue("error")]
        Error,
        [StringValue("success")]
        Success,
    }
    public enum DisplayEnum
    {
        [StringValue("normal")]
        Normal,
        [StringValue("banner")]
        Banner,
        [StringValue("dialog")]
        Dialog,
    }
    public enum OriginEnum
    {
        [StringValue("combined")]
        Combined,
        [StringValue("local")]
        Local,
        [StringValue("remote")]
        Remote,
    }
    public enum SortEnum
    {
        [StringValue("+createdAt")]
        PluscreatedAt,
        [StringValue("-createdAt")]
        MinuscreatedAt,
        [StringValue("+usedAt")]
        PlususedAt,
        [StringValue("-usedAt")]
        MinususedAt,
    }
    public enum TypeEnum
    {
        [StringValue("unused")]
        Unused,
        [StringValue("used")]
        Used,
        [StringValue("expired")]
        Expired,
        [StringValue("all")]
        All,
    }
}