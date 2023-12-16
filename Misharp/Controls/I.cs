using Misharp.Model;
namespace Misharp.Controls
{
    public class IApi
    {
        private Misharp.App _app;
        public I.GalleryApi GalleryApi;
        public I.RegistryApi RegistryApi;
        public I.WebhooksApi WebhooksApi;
        public IApi(Misharp.App app)
        {
            _app = app;
            GalleryApi = new I.GalleryApi(_app);
            RegistryApi = new I.RegistryApi(_app);
            WebhooksApi = new I.WebhooksApi(_app);
        }
        public async Task<MeDetailed> I()
        {
            var result = await _app.Request<MeDetailed>("i", true);
            return result;
        }
        public async Task<List<NoteFavorite>> Favorites(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<NoteFavorite>>("i/favorites", param, true);
            return result;
        }
        public async Task<List<Notification>> Notifications(string sinceId, string untilId, int limit = 10, bool markAsRead = true, List<string>? includeTypes = null, List<string>? excludeTypes = null)
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
            var result = await _app.Request<List<Notification>>("i/notifications", param, true);
            return result;
        }
        public async Task<List<Notification>> Notificationsgrouped(string sinceId, string untilId, int limit = 10, bool markAsRead = true, List<string>? includeTypes = null, List<string>? excludeTypes = null)
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
            var result = await _app.Request<List<Notification>>("i/notifications-grouped", param, true);
            return result;
        }
        public async Task<List<object>> Pagelikes(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<object>>("i/page-likes", param, true);
            return result;
        }
        public async Task<List<Page>> Pages(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Page>>("i/pages", param, true);
            return result;
        }
        public async Task<MeDetailed> Pin(string noteId)
        {
            var param = new Dictionary<string, object?>
            {
                { "noteId", noteId },
            };
            var result = await _app.Request<MeDetailed>("i/pin", param, true);
            return result;
        }
        public async Task<MeDetailed> Unpin(string noteId)
        {
            var param = new Dictionary<string, object?>
            {
                { "noteId", noteId },
            };
            var result = await _app.Request<MeDetailed>("i/unpin", param, true);
            return result;
        }
        public async Task<MeDetailed> Update(bool isLocked, bool isExplorable, bool hideOnlineStatus, bool publicReactions, bool carefulBot, bool autoAcceptFollowed, bool noCrawle, bool preventAiLearning, bool isBot, bool isCat, bool injectFeaturedNote, bool receiveAnnouncementEmail, bool alwaysMarkNsfw, bool autoSensitive, FfVisibilityEnum ffVisibility, object notificationRecieveConfig, string? name = null, string? description = null, string? location = null, string? birthday = null, LangEnum? lang = null, string? avatarId = null, List<object>? avatarDecorations = null, string? bannerId = null, List<object>? fields = null, string? pinnedPageId = null, List<string>? mutedWords = null, List<string>? hardMutedWords = null, List<string>? mutedInstances = null, List<string>? emailNotificationTypes = null, List<string>? alsoKnownAs = null)
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
                { "ffVisibility", ffVisibility },
                { "pinnedPageId", pinnedPageId },
                { "mutedWords", mutedWords },
                { "hardMutedWords", hardMutedWords },
                { "mutedInstances", mutedInstances },
                { "notificationRecieveConfig", notificationRecieveConfig },
                { "emailNotificationTypes", emailNotificationTypes },
                { "alsoKnownAs", alsoKnownAs },
            };
            var result = await _app.Request<MeDetailed>("i/update", param, true);
            return result;
        }
        public enum FfVisibilityEnum
        {
            [StringValue("public")]
            Public,
            [StringValue("followers")]
            Followers,
            [StringValue("private")]
            Private,
        }
        public enum LangEnum
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
    public class GalleryApi
    {
        private Misharp.App _app;
        public GalleryApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<object>> Likes(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<object>>("i/gallery/likes", param, true);
            return result;
        }
        public async Task<List<GalleryPost>> Posts(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<GalleryPost>>("i/gallery/posts", param, true);
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
    }
    public class WebhooksApi
    {
        private Misharp.App _app;
        public WebhooksApi(Misharp.App app)
        {
            _app = app;
        }
    }
}