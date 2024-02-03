using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls
{
    public class IApi
    {
        private Misharp.App _app;
        public I._2faApi _2faApi;
        public I.GalleryApi GalleryApi;
        public I.RegistryApi RegistryApi;
        public I.WebhooksApi WebhooksApi;
        public IApi(Misharp.App app)
        {
            _app = app;
            _2faApi = new I._2faApi(_app);
            GalleryApi = new I.GalleryApi(_app);
            RegistryApi = new I.RegistryApi(_app);
            WebhooksApi = new I.WebhooksApi(_app);
        }
        public async Task<Models.Response<MeDetailed>> I()
        {
            var result = await _app.Request<MeDetailed>("i", useToken: true);
            return result;
        }
        public async Task<Models.Response<List<object>>> Apps(AppsSortEnum sort)
        {
            var param = new Dictionary<string, object?>
            {
                { "sort", sort },
            };
            var result = await _app.Request<List<object>>("i/apps", param, useToken: true);
            return result;
        }
        public enum AppsSortEnum
        {
            [StringValue("+createdAt")]
            PluscreatedAt,
            [StringValue("-createdAt")]
            MinuscreatedAt,
            [StringValue("+lastUsedAt")]
            PluslastUsedAt,
            [StringValue("-lastUsedAt")]
            MinuslastUsedAt,
        }
        public async Task<Models.Response<List<object>>> Authorizedapps(int limit = 10, int offset = 0, AuthorizedappsSortEnum sort = AuthorizedappsSortEnum.Desc)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "offset", offset },
                { "sort", sort },
            };
            var result = await _app.Request<List<object>>("i/authorized-apps", param, useToken: true);
            return result;
        }
        public enum AuthorizedappsSortEnum
        {
            [StringValue("desc")]
            Desc,
            [StringValue("asc")]
            Asc,
        }
        public async Task<Models.Response<Models.EmptyResponse>> Claimachievement(ClaimachievementNameEnum name)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/claim-achievement", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public enum ClaimachievementNameEnum
        {
            [StringValue("notes1")]
            Notes1,
            [StringValue("notes10")]
            Notes10,
            [StringValue("notes100")]
            Notes100,
            [StringValue("notes500")]
            Notes500,
            [StringValue("notes1000")]
            Notes1000,
            [StringValue("notes5000")]
            Notes5000,
            [StringValue("notes10000")]
            Notes10000,
            [StringValue("notes20000")]
            Notes20000,
            [StringValue("notes30000")]
            Notes30000,
            [StringValue("notes40000")]
            Notes40000,
            [StringValue("notes50000")]
            Notes50000,
            [StringValue("notes60000")]
            Notes60000,
            [StringValue("notes70000")]
            Notes70000,
            [StringValue("notes80000")]
            Notes80000,
            [StringValue("notes90000")]
            Notes90000,
            [StringValue("notes100000")]
            Notes100000,
            [StringValue("login3")]
            Login3,
            [StringValue("login7")]
            Login7,
            [StringValue("login15")]
            Login15,
            [StringValue("login30")]
            Login30,
            [StringValue("login60")]
            Login60,
            [StringValue("login100")]
            Login100,
            [StringValue("login200")]
            Login200,
            [StringValue("login300")]
            Login300,
            [StringValue("login400")]
            Login400,
            [StringValue("login500")]
            Login500,
            [StringValue("login600")]
            Login600,
            [StringValue("login700")]
            Login700,
            [StringValue("login800")]
            Login800,
            [StringValue("login900")]
            Login900,
            [StringValue("login1000")]
            Login1000,
            [StringValue("passedSinceAccountCreated1")]
            PassedSinceAccountCreated1,
            [StringValue("passedSinceAccountCreated2")]
            PassedSinceAccountCreated2,
            [StringValue("passedSinceAccountCreated3")]
            PassedSinceAccountCreated3,
            [StringValue("loggedInOnBirthday")]
            LoggedInOnBirthday,
            [StringValue("loggedInOnNewYearsDay")]
            LoggedInOnNewYearsDay,
            [StringValue("noteClipped1")]
            NoteClipped1,
            [StringValue("noteFavorited1")]
            NoteFavorited1,
            [StringValue("myNoteFavorited1")]
            MyNoteFavorited1,
            [StringValue("profileFilled")]
            ProfileFilled,
            [StringValue("markedAsCat")]
            MarkedAsCat,
            [StringValue("following1")]
            Following1,
            [StringValue("following10")]
            Following10,
            [StringValue("following50")]
            Following50,
            [StringValue("following100")]
            Following100,
            [StringValue("following300")]
            Following300,
            [StringValue("followers1")]
            Followers1,
            [StringValue("followers10")]
            Followers10,
            [StringValue("followers50")]
            Followers50,
            [StringValue("followers100")]
            Followers100,
            [StringValue("followers300")]
            Followers300,
            [StringValue("followers500")]
            Followers500,
            [StringValue("followers1000")]
            Followers1000,
            [StringValue("collectAchievements30")]
            CollectAchievements30,
            [StringValue("viewAchievements3min")]
            ViewAchievements3min,
            [StringValue("iLoveMisskey")]
            ILoveMisskey,
            [StringValue("foundTreasure")]
            FoundTreasure,
            [StringValue("client30min")]
            Client30min,
            [StringValue("client60min")]
            Client60min,
            [StringValue("noteDeletedWithin1min")]
            NoteDeletedWithin1min,
            [StringValue("postedAtLateNight")]
            PostedAtLateNight,
            [StringValue("postedAt0min0sec")]
            PostedAt0min0sec,
            [StringValue("selfQuote")]
            SelfQuote,
            [StringValue("htl20npm")]
            Htl20npm,
            [StringValue("viewInstanceChart")]
            ViewInstanceChart,
            [StringValue("outputHelloWorldOnScratchpad")]
            OutputHelloWorldOnScratchpad,
            [StringValue("open3windows")]
            Open3windows,
            [StringValue("driveFolderCircularReference")]
            DriveFolderCircularReference,
            [StringValue("reactWithoutRead")]
            ReactWithoutRead,
            [StringValue("clickedClickHere")]
            ClickedClickHere,
            [StringValue("justPlainLucky")]
            JustPlainLucky,
            [StringValue("setNameToSyuilo")]
            SetNameToSyuilo,
            [StringValue("cookieClicked")]
            CookieClicked,
            [StringValue("brainDiver")]
            BrainDiver,
            [StringValue("smashTestNotificationButton")]
            SmashTestNotificationButton,
            [StringValue("tutorialCompleted")]
            TutorialCompleted,
        }
        public async Task<Models.Response<Models.EmptyResponse>> Changepassword(string currentPassword, string newPassword, string? token = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "currentPassword", currentPassword },
                { "newPassword", newPassword },
                { "token", token },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/change-password", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Deleteaccount(string password, string? token = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "password", password },
                { "token", token },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/delete-account", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Exportblocking()
        {
            var result = await _app.Request<Models.EmptyResponse>("i/export-blocking", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Exportfollowing(bool excludeMuting = false, bool excludeInactive = false)
        {
            var param = new Dictionary<string, object?>
            {
                { "excludeMuting", excludeMuting },
                { "excludeInactive", excludeInactive },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/export-following", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Exportmute()
        {
            var result = await _app.Request<Models.EmptyResponse>("i/export-mute", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Exportnotes()
        {
            var result = await _app.Request<Models.EmptyResponse>("i/export-notes", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Exportclips()
        {
            var result = await _app.Request<Models.EmptyResponse>("i/export-clips", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Exportfavorites()
        {
            var result = await _app.Request<Models.EmptyResponse>("i/export-favorites", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Exportuserlists()
        {
            var result = await _app.Request<Models.EmptyResponse>("i/export-user-lists", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Exportantennas()
        {
            var result = await _app.Request<Models.EmptyResponse>("i/export-antennas", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<NoteFavorite>>> Favorites(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<NoteFavorite>>("i/favorites", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Importblocking(string fileId)
        {
            var param = new Dictionary<string, object?>
            {
                { "fileId", fileId },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/import-blocking", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Importfollowing(string fileId, bool withReplies)
        {
            var param = new Dictionary<string, object?>
            {
                { "fileId", fileId },
                { "withReplies", withReplies },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/import-following", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Importmuting(string fileId)
        {
            var param = new Dictionary<string, object?>
            {
                { "fileId", fileId },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/import-muting", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Importuserlists(string fileId)
        {
            var param = new Dictionary<string, object?>
            {
                { "fileId", fileId },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/import-user-lists", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Importantennas(string fileId)
        {
            var param = new Dictionary<string, object?>
            {
                { "fileId", fileId },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/import-antennas", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<Notification>>> Notifications(string sinceId, string untilId, int limit = 10, bool markAsRead = true, List<string>? includeTypes = null, List<string>? excludeTypes = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "markAsRead", markAsRead },
                { "includeTypes", includeTypes },
                { "excludeTypes", excludeTypes },
            };
            var result = await _app.Request<List<Notification>>("i/notifications", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<Notification>>> Notificationsgrouped(string sinceId, string untilId, int limit = 10, bool markAsRead = true, List<string>? includeTypes = null, List<string>? excludeTypes = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "markAsRead", markAsRead },
                { "includeTypes", includeTypes },
                { "excludeTypes", excludeTypes },
            };
            var result = await _app.Request<List<Notification>>("i/notifications-grouped", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<object>>> Pagelikes(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<object>>("i/page-likes", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<Page>>> Pages(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Page>>("i/pages", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<MeDetailed>> Pin(string noteId)
        {
            var param = new Dictionary<string, object?>
            {
                { "noteId", noteId },
            };
            var result = await _app.Request<MeDetailed>("i/pin", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Readallunreadnotes()
        {
            var result = await _app.Request<Models.EmptyResponse>("i/read-all-unread-notes", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Readannouncement(string announcementId)
        {
            var param = new Dictionary<string, object?>
            {
                { "announcementId", announcementId },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/read-announcement", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Regeneratetoken(string password)
        {
            var param = new Dictionary<string, object?>
            {
                { "password", password },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/regenerate-token", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Revoketoken(string tokenId, string? token = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "tokenId", tokenId },
                { "token", token },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/revoke-token", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<Signin>>> Signinhistory(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Signin>>("i/signin-history", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<MeDetailed>> Unpin(string noteId)
        {
            var param = new Dictionary<string, object?>
            {
                { "noteId", noteId },
            };
            var result = await _app.Request<MeDetailed>("i/unpin", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<UserDetailed>> Updateemail(string password, string? email = null, string? token = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "password", password },
                { "email", email },
                { "token", token },
            };
            var result = await _app.Request<UserDetailed>("i/update-email", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<MeDetailed>> Update(bool isLocked, bool isExplorable, bool hideOnlineStatus, bool publicReactions, bool carefulBot, bool autoAcceptFollowed, bool noCrawle, bool preventAiLearning, bool isBot, bool isCat, bool injectFeaturedNote, bool receiveAnnouncementEmail, bool alwaysMarkNsfw, bool autoSensitive, UpdateFollowingVisibilityEnum followingVisibility, UpdateFollowersVisibilityEnum followersVisibility, object notificationRecieveConfig, string? name = null, string? description = null, string? location = null, string? birthday = null, UpdateLangEnum? lang = null, string? avatarId = null, List<object>? avatarDecorations = null, string? bannerId = null, List<object>? fields = null, string? pinnedPageId = null, object? mutedWords = null, object? hardMutedWords = null, List<string>? mutedInstances = null, List<string>? emailNotificationTypes = null, List<string>? alsoKnownAs = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "description", description },
                { "location", location },
                { "birthday", birthday },
                { "lang", lang },
                { "avatarId", avatarId },
                { "avatarDecorations", avatarDecorations },
                { "bannerId", bannerId },
                { "fields", fields },
                { "isLocked", isLocked },
                { "isExplorable", isExplorable },
                { "hideOnlineStatus", hideOnlineStatus },
                { "publicReactions", publicReactions },
                { "carefulBot", carefulBot },
                { "autoAcceptFollowed", autoAcceptFollowed },
                { "noCrawle", noCrawle },
                { "preventAiLearning", preventAiLearning },
                { "isBot", isBot },
                { "isCat", isCat },
                { "injectFeaturedNote", injectFeaturedNote },
                { "receiveAnnouncementEmail", receiveAnnouncementEmail },
                { "alwaysMarkNsfw", alwaysMarkNsfw },
                { "autoSensitive", autoSensitive },
                { "followingVisibility", followingVisibility },
                { "followersVisibility", followersVisibility },
                { "pinnedPageId", pinnedPageId },
                { "mutedWords", mutedWords },
                { "hardMutedWords", hardMutedWords },
                { "mutedInstances", mutedInstances },
                { "notificationRecieveConfig", notificationRecieveConfig },
                { "emailNotificationTypes", emailNotificationTypes },
                { "alsoKnownAs", alsoKnownAs },
            };
            var result = await _app.Request<MeDetailed>("i/update", param, useToken: true);
            return result;
        }
        public enum UpdateFollowingVisibilityEnum
        {
            [StringValue("public")]
            Public,
            [StringValue("followers")]
            Followers,
            [StringValue("private")]
            Private,
        }
        public enum UpdateFollowersVisibilityEnum
        {
            [StringValue("public")]
            Public,
            [StringValue("followers")]
            Followers,
            [StringValue("private")]
            Private,
        }
        public enum UpdateLangEnum
        {
            [StringValue("ach")]
            Ach,
            [StringValue("ady")]
            Ady,
            [StringValue("af")]
            Af,
            [StringValue("af-NA")]
            AfNA,
            [StringValue("af-ZA")]
            AfZA,
            [StringValue("ak")]
            Ak,
            [StringValue("ar")]
            Ar,
            [StringValue("ar-AR")]
            ArAR,
            [StringValue("ar-MA")]
            ArMA,
            [StringValue("ar-SA")]
            ArSA,
            [StringValue("ay-BO")]
            AyBO,
            [StringValue("az")]
            Az,
            [StringValue("az-AZ")]
            AzAZ,
            [StringValue("be-BY")]
            BeBY,
            [StringValue("bg")]
            Bg,
            [StringValue("bg-BG")]
            BgBG,
            [StringValue("bn")]
            Bn,
            [StringValue("bn-IN")]
            BnIN,
            [StringValue("bn-BD")]
            BnBD,
            [StringValue("br")]
            Br,
            [StringValue("bs-BA")]
            BsBA,
            [StringValue("ca")]
            Ca,
            [StringValue("ca-ES")]
            CaES,
            [StringValue("cak")]
            Cak,
            [StringValue("ck-US")]
            CkUS,
            [StringValue("cs")]
            Cs,
            [StringValue("cs-CZ")]
            CsCZ,
            [StringValue("cy")]
            Cy,
            [StringValue("cy-GB")]
            CyGB,
            [StringValue("da")]
            Da,
            [StringValue("da-DK")]
            DaDK,
            [StringValue("de")]
            De,
            [StringValue("de-AT")]
            DeAT,
            [StringValue("de-DE")]
            DeDE,
            [StringValue("de-CH")]
            DeCH,
            [StringValue("dsb")]
            Dsb,
            [StringValue("el")]
            El,
            [StringValue("el-GR")]
            ElGR,
            [StringValue("en")]
            En,
            [StringValue("en-GB")]
            EnGB,
            [StringValue("en-AU")]
            EnAU,
            [StringValue("en-CA")]
            EnCA,
            [StringValue("en-IE")]
            EnIE,
            [StringValue("en-IN")]
            EnIN,
            [StringValue("en-PI")]
            EnPI,
            [StringValue("en-SG")]
            EnSG,
            [StringValue("en-UD")]
            EnUD,
            [StringValue("en-US")]
            EnUS,
            [StringValue("en-ZA")]
            EnZA,
            [StringValue("en@pirate")]
            EnAtPirate,
            [StringValue("eo")]
            Eo,
            [StringValue("eo-EO")]
            EoEO,
            [StringValue("es")]
            Es,
            [StringValue("es-AR")]
            EsAR,
            [StringValue("es-419")]
            Es419,
            [StringValue("es-CL")]
            EsCL,
            [StringValue("es-CO")]
            EsCO,
            [StringValue("es-EC")]
            EsEC,
            [StringValue("es-ES")]
            EsES,
            [StringValue("es-LA")]
            EsLA,
            [StringValue("es-NI")]
            EsNI,
            [StringValue("es-MX")]
            EsMX,
            [StringValue("es-US")]
            EsUS,
            [StringValue("es-VE")]
            EsVE,
            [StringValue("et")]
            Et,
            [StringValue("et-EE")]
            EtEE,
            [StringValue("eu")]
            Eu,
            [StringValue("eu-ES")]
            EuES,
            [StringValue("fa")]
            Fa,
            [StringValue("fa-IR")]
            FaIR,
            [StringValue("fb-LT")]
            FbLT,
            [StringValue("ff")]
            Ff,
            [StringValue("fi")]
            Fi,
            [StringValue("fi-FI")]
            FiFI,
            [StringValue("fo")]
            Fo,
            [StringValue("fo-FO")]
            FoFO,
            [StringValue("fr")]
            Fr,
            [StringValue("fr-CA")]
            FrCA,
            [StringValue("fr-FR")]
            FrFR,
            [StringValue("fr-BE")]
            FrBE,
            [StringValue("fr-CH")]
            FrCH,
            [StringValue("fy-NL")]
            FyNL,
            [StringValue("ga")]
            Ga,
            [StringValue("ga-IE")]
            GaIE,
            [StringValue("gd")]
            Gd,
            [StringValue("gl")]
            Gl,
            [StringValue("gl-ES")]
            GlES,
            [StringValue("gn-PY")]
            GnPY,
            [StringValue("gu-IN")]
            GuIN,
            [StringValue("gv")]
            Gv,
            [StringValue("gx-GR")]
            GxGR,
            [StringValue("he")]
            He,
            [StringValue("he-IL")]
            HeIL,
            [StringValue("hi")]
            Hi,
            [StringValue("hi-IN")]
            HiIN,
            [StringValue("hr")]
            Hr,
            [StringValue("hr-HR")]
            HrHR,
            [StringValue("hsb")]
            Hsb,
            [StringValue("ht")]
            Ht,
            [StringValue("hu")]
            Hu,
            [StringValue("hu-HU")]
            HuHU,
            [StringValue("hy")]
            Hy,
            [StringValue("hy-AM")]
            HyAM,
            [StringValue("id")]
            Id,
            [StringValue("id-ID")]
            IdID,
            [StringValue("is")]
            Is,
            [StringValue("is-IS")]
            IsIS,
            [StringValue("it")]
            It,
            [StringValue("it-IT")]
            ItIT,
            [StringValue("ja")]
            Ja,
            [StringValue("ja-JP")]
            JaJP,
            [StringValue("jv-ID")]
            JvID,
            [StringValue("ka-GE")]
            KaGE,
            [StringValue("kk-KZ")]
            KkKZ,
            [StringValue("km")]
            Km,
            [StringValue("kl")]
            Kl,
            [StringValue("km-KH")]
            KmKH,
            [StringValue("kab")]
            Kab,
            [StringValue("kn")]
            Kn,
            [StringValue("kn-IN")]
            KnIN,
            [StringValue("ko")]
            Ko,
            [StringValue("ko-KR")]
            KoKR,
            [StringValue("ku-TR")]
            KuTR,
            [StringValue("kw")]
            Kw,
            [StringValue("la")]
            La,
            [StringValue("la-VA")]
            LaVA,
            [StringValue("lb")]
            Lb,
            [StringValue("li-NL")]
            LiNL,
            [StringValue("lt")]
            Lt,
            [StringValue("lt-LT")]
            LtLT,
            [StringValue("lv")]
            Lv,
            [StringValue("lv-LV")]
            LvLV,
            [StringValue("mai")]
            Mai,
            [StringValue("mg-MG")]
            MgMG,
            [StringValue("mk")]
            Mk,
            [StringValue("mk-MK")]
            MkMK,
            [StringValue("ml")]
            Ml,
            [StringValue("ml-IN")]
            MlIN,
            [StringValue("mn-MN")]
            MnMN,
            [StringValue("mr")]
            Mr,
            [StringValue("mr-IN")]
            MrIN,
            [StringValue("ms")]
            Ms,
            [StringValue("ms-MY")]
            MsMY,
            [StringValue("mt")]
            Mt,
            [StringValue("mt-MT")]
            MtMT,
            [StringValue("my")]
            My,
            [StringValue("no")]
            No,
            [StringValue("nb")]
            Nb,
            [StringValue("nb-NO")]
            NbNO,
            [StringValue("ne")]
            Ne,
            [StringValue("ne-NP")]
            NeNP,
            [StringValue("nl")]
            Nl,
            [StringValue("nl-BE")]
            NlBE,
            [StringValue("nl-NL")]
            NlNL,
            [StringValue("nn-NO")]
            NnNO,
            [StringValue("oc")]
            Oc,
            [StringValue("or-IN")]
            OrIN,
            [StringValue("pa")]
            Pa,
            [StringValue("pa-IN")]
            PaIN,
            [StringValue("pl")]
            Pl,
            [StringValue("pl-PL")]
            PlPL,
            [StringValue("ps-AF")]
            PsAF,
            [StringValue("pt")]
            Pt,
            [StringValue("pt-BR")]
            PtBR,
            [StringValue("pt-PT")]
            PtPT,
            [StringValue("qu-PE")]
            QuPE,
            [StringValue("rm-CH")]
            RmCH,
            [StringValue("ro")]
            Ro,
            [StringValue("ro-RO")]
            RoRO,
            [StringValue("ru")]
            Ru,
            [StringValue("ru-RU")]
            RuRU,
            [StringValue("sa-IN")]
            SaIN,
            [StringValue("se-NO")]
            SeNO,
            [StringValue("sh")]
            Sh,
            [StringValue("si-LK")]
            SiLK,
            [StringValue("sk")]
            Sk,
            [StringValue("sk-SK")]
            SkSK,
            [StringValue("sl")]
            Sl,
            [StringValue("sl-SI")]
            SlSI,
            [StringValue("so-SO")]
            SoSO,
            [StringValue("sq")]
            Sq,
            [StringValue("sq-AL")]
            SqAL,
            [StringValue("sr")]
            Sr,
            [StringValue("sr-RS")]
            SrRS,
            [StringValue("su")]
            Su,
            [StringValue("sv")]
            Sv,
            [StringValue("sv-SE")]
            SvSE,
            [StringValue("sw")]
            Sw,
            [StringValue("sw-KE")]
            SwKE,
            [StringValue("ta")]
            Ta,
            [StringValue("ta-IN")]
            TaIN,
            [StringValue("te")]
            Te,
            [StringValue("te-IN")]
            TeIN,
            [StringValue("tg")]
            Tg,
            [StringValue("tg-TJ")]
            TgTJ,
            [StringValue("th")]
            Th,
            [StringValue("th-TH")]
            ThTH,
            [StringValue("fil")]
            Fil,
            [StringValue("tlh")]
            Tlh,
            [StringValue("tr")]
            Tr,
            [StringValue("tr-TR")]
            TrTR,
            [StringValue("tt-RU")]
            TtRU,
            [StringValue("uk")]
            Uk,
            [StringValue("uk-UA")]
            UkUA,
            [StringValue("ur")]
            Ur,
            [StringValue("ur-PK")]
            UrPK,
            [StringValue("uz")]
            Uz,
            [StringValue("uz-UZ")]
            UzUZ,
            [StringValue("vi")]
            Vi,
            [StringValue("vi-VN")]
            ViVN,
            [StringValue("xh-ZA")]
            XhZA,
            [StringValue("yi")]
            Yi,
            [StringValue("yi-DE")]
            YiDE,
            [StringValue("zh")]
            Zh,
            [StringValue("zh-Hans")]
            ZhHans,
            [StringValue("zh-Hant")]
            ZhHant,
            [StringValue("zh-CN")]
            ZhCN,
            [StringValue("zh-HK")]
            ZhHK,
            [StringValue("zh-SG")]
            ZhSG,
            [StringValue("zh-TW")]
            ZhTW,
            [StringValue("zu-ZA")]
            ZuZA,
        }
    }
}
namespace Misharp.Controls.I
{
    public class _2faApi
    {
        private Misharp.App _app;
        public _2faApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Done(string token)
        {
            var param = new Dictionary<string, object?>
            {
                { "token", token },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/_2fa/done", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public class I_2faKeydoneResponse
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  id: {this.Id}\n");
                sb.Append($"  name: {this.Name}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<Models.Response<I_2faKeydoneResponse>> Keydone(string password, string name, object credential, string? token = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "password", password },
                { "token", token },
                { "name", name },
                { "credential", credential },
            };
            var result = await _app.Request<I_2faKeydoneResponse>("i/_2fa/key-done", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Passwordless(bool value)
        {
            var param = new Dictionary<string, object?>
            {
                { "value", value },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/_2fa/password-less", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public class I_2faRegisterkeyResponse
        {
            public object Rp { get; set; }
            public object User { get; set; }
            public string Challenge { get; set; }
            public List<object> PubKeyCredParams { get; set; }
            public decimal? Timeout { get; set; }
            public List<object>? ExcludeCredentials { get; set; }
            public object? AuthenticatorSelection { get; set; }
            public string? Attestation { get; set; }
            public object? Extensions { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  rp: {this.Rp}\n");
                sb.Append($"  user: {this.User}\n");
                sb.Append($"  challenge: {this.Challenge}\n");
                sb.Append("  pubKeyCredParams: {\n");
                if (this.PubKeyCredParams != null && this.PubKeyCredParams.Count > 0) this.PubKeyCredParams.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  timeout: {this.Timeout}\n");
                sb.Append("  excludeCredentials: {\n");
                if (this.ExcludeCredentials != null && this.ExcludeCredentials.Count > 0) this.ExcludeCredentials.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  authenticatorSelection: {this.AuthenticatorSelection}\n");
                sb.Append($"  attestation: {this.Attestation}\n");
                sb.Append($"  extensions: {this.Extensions}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<Models.Response<I_2faRegisterkeyResponse>> Registerkey(string password, string? token = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "password", password },
                { "token", token },
            };
            var result = await _app.Request<I_2faRegisterkeyResponse>("i/_2fa/register-key", param, useToken: true);
            return result;
        }
        public class I_2faRegisterResponse
        {
            public string Qr { get; set; }
            public string Url { get; set; }
            public string Secret { get; set; }
            public string Label { get; set; }
            public string Issuer { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  qr: {this.Qr}\n");
                sb.Append($"  url: {this.Url}\n");
                sb.Append($"  secret: {this.Secret}\n");
                sb.Append($"  label: {this.Label}\n");
                sb.Append($"  issuer: {this.Issuer}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<Models.Response<I_2faRegisterResponse>> Register(string password, string? token = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "password", password },
                { "token", token },
            };
            var result = await _app.Request<I_2faRegisterResponse>("i/_2fa/register", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Updatekey(string name, string credentialId)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "credentialId", credentialId },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/_2fa/update-key", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Removekey(string password, string credentialId, string? token = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "password", password },
                { "token", token },
                { "credentialId", credentialId },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/_2fa/remove-key", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Unregister(string password, string? token = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "password", password },
                { "token", token },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/_2fa/unregister", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
    }
    public class GalleryApi
    {
        private Misharp.App _app;
        public GalleryApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<Models.Response<List<object>>> Likes(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<object>>("i/gallery/likes", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<GalleryPost>>> Posts(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<GalleryPost>>("i/gallery/posts", param, useToken: true);
            return result;
        }
    }
    public class RegistryApi
    {
        private Misharp.App _app;
        public RegistryApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Keys(List<string>? scope = null, string? domain = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "scope", scope },
                { "domain", domain },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/registry/keys", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Remove(string key, List<string>? scope = null, string? domain = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "key", key },
                { "scope", scope },
                { "domain", domain },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/registry/remove", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<object>>> Scopeswithdomain()
        {
            var result = await _app.Request<List<object>>("i/registry/scopes-with-domain", useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Set(string key, object value, List<string>? scope = null, string? domain = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "key", key },
                { "value", value },
                { "scope", scope },
                { "domain", domain },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/registry/set", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
    }
    public class WebhooksApi
    {
        private Misharp.App _app;
        public WebhooksApi(Misharp.App app)
        {
            _app = app;
        }
        public class IWebhooksCreateResponse
        {
            public string Id { get; set; }
            public string UserId { get; set; }
            public string Name { get; set; }
            public List<string> On { get; set; }
            public string Url { get; set; }
            public string Secret { get; set; }
            public bool Active { get; set; }
            public DateTime? LatestSentAt { get; set; }
            public int? LatestStatus { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  id: {this.Id}\n");
                sb.Append($"  userId: {this.UserId}\n");
                sb.Append($"  name: {this.Name}\n");
                sb.Append("  on: {\n");
                if (this.On != null && this.On.Count > 0) this.On.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  url: {this.Url}\n");
                sb.Append($"  secret: {this.Secret}\n");
                sb.Append($"  active: {this.Active}\n");
                sb.Append($"  latestSentAt: {this.LatestSentAt}\n");
                sb.Append($"  latestStatus: {this.LatestStatus}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<Models.Response<IWebhooksCreateResponse>> Create(string name, string url, string? secret = null, List<string>? on = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "url", url },
                { "secret", secret },
                { "on", on },
            };
            var result = await _app.Request<IWebhooksCreateResponse>("i/webhooks/create", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<object>>> List()
        {
            var result = await _app.Request<List<object>>("i/webhooks/list", useToken: true);
            return result;
        }
        public class IWebhooksShowResponse
        {
            public string Id { get; set; }
            public string UserId { get; set; }
            public string Name { get; set; }
            public List<string> On { get; set; }
            public string Url { get; set; }
            public string Secret { get; set; }
            public bool Active { get; set; }
            public DateTime? LatestSentAt { get; set; }
            public int? LatestStatus { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  id: {this.Id}\n");
                sb.Append($"  userId: {this.UserId}\n");
                sb.Append($"  name: {this.Name}\n");
                sb.Append("  on: {\n");
                if (this.On != null && this.On.Count > 0) this.On.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
                sb.Append("  }\n");
                sb.Append($"  url: {this.Url}\n");
                sb.Append($"  secret: {this.Secret}\n");
                sb.Append($"  active: {this.Active}\n");
                sb.Append($"  latestSentAt: {this.LatestSentAt}\n");
                sb.Append($"  latestStatus: {this.LatestStatus}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<Models.Response<IWebhooksShowResponse>> Show(string webhookId)
        {
            var param = new Dictionary<string, object?>
            {
                { "webhookId", webhookId },
            };
            var result = await _app.Request<IWebhooksShowResponse>("i/webhooks/show", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Update(string webhookId, string name, string url, bool active, string? secret = null, List<string>? on = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "webhookId", webhookId },
                { "name", name },
                { "url", url },
                { "secret", secret },
                { "on", on },
                { "active", active },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/webhooks/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Delete(string webhookId)
        {
            var param = new Dictionary<string, object?>
            {
                { "webhookId", webhookId },
            };
            var result = await _app.Request<Models.EmptyResponse>("i/webhooks/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
    }
}