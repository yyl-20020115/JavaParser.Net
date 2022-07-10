using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.net;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/net/ElementTypesAreNonnullByDefault;"
})]
public sealed class HttpHeaders : java.lang.Object
{
	public sealed class ReferrerPolicyValues : java.lang.Object
	{
		public const string NO_REFERRER = "no-referrer";

		public const string NO_REFFERER_WHEN_DOWNGRADE = "no-referrer-when-downgrade";

		public const string SAME_ORIGIN = "same-origin";

		public const string ORIGIN = "origin";

		public const string STRICT_ORIGIN = "strict-origin";

		public const string ORIGIN_WHEN_CROSS_ORIGIN = "origin-when-cross-origin";

		public const string STRICT_ORIGIN_WHEN_CROSS_ORIGIN = "strict-origin-when-cross-origin";

		public const string UNSAFE_URL = "unsafe-url";

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(158)]
		private ReferrerPolicyValues()
		{
		}
	}

	public const string CACHE_CONTROL = "Cache-Control";

	public const string CONTENT_LENGTH = "Content-Length";

	public const string CONTENT_TYPE = "Content-Type";

	public const string DATE = "Date";

	public const string PRAGMA = "Pragma";

	public const string VIA = "Via";

	public const string WARNING = "Warning";

	public const string ACCEPT = "Accept";

	public const string ACCEPT_CHARSET = "Accept-Charset";

	public const string ACCEPT_ENCODING = "Accept-Encoding";

	public const string ACCEPT_LANGUAGE = "Accept-Language";

	public const string ACCESS_CONTROL_REQUEST_HEADERS = "Access-Control-Request-Headers";

	public const string ACCESS_CONTROL_REQUEST_METHOD = "Access-Control-Request-Method";

	public const string AUTHORIZATION = "Authorization";

	public const string CONNECTION = "Connection";

	public const string COOKIE = "Cookie";

	public const string CROSS_ORIGIN_RESOURCE_POLICY = "Cross-Origin-Resource-Policy";

	public const string EARLY_DATA = "Early-Data";

	public const string EXPECT = "Expect";

	public const string FROM = "From";

	public const string FORWARDED = "Forwarded";

	public const string FOLLOW_ONLY_WHEN_PRERENDER_SHOWN = "Follow-Only-When-Prerender-Shown";

	public const string HOST = "Host";

	public const string HTTP2_SETTINGS = "HTTP2-Settings";

	public const string IF_MATCH = "If-Match";

	public const string IF_MODIFIED_SINCE = "If-Modified-Since";

	public const string IF_NONE_MATCH = "If-None-Match";

	public const string IF_RANGE = "If-Range";

	public const string IF_UNMODIFIED_SINCE = "If-Unmodified-Since";

	public const string LAST_EVENT_ID = "Last-Event-ID";

	public const string MAX_FORWARDS = "Max-Forwards";

	public const string ORIGIN = "Origin";

	public const string ORIGIN_ISOLATION = "Origin-Isolation";

	public const string PROXY_AUTHORIZATION = "Proxy-Authorization";

	public const string RANGE = "Range";

	public const string REFERER = "Referer";

	public const string REFERRER_POLICY = "Referrer-Policy";

	public const string SERVICE_WORKER = "Service-Worker";

	public const string TE = "TE";

	public const string UPGRADE = "Upgrade";

	public const string UPGRADE_INSECURE_REQUESTS = "Upgrade-Insecure-Requests";

	public const string USER_AGENT = "User-Agent";

	public const string ACCEPT_RANGES = "Accept-Ranges";

	public const string ACCESS_CONTROL_ALLOW_HEADERS = "Access-Control-Allow-Headers";

	public const string ACCESS_CONTROL_ALLOW_METHODS = "Access-Control-Allow-Methods";

	public const string ACCESS_CONTROL_ALLOW_ORIGIN = "Access-Control-Allow-Origin";

	public const string ACCESS_CONTROL_ALLOW_PRIVATE_NETWORK = "Access-Control-Allow-Private-Network";

	public const string ACCESS_CONTROL_ALLOW_CREDENTIALS = "Access-Control-Allow-Credentials";

	public const string ACCESS_CONTROL_EXPOSE_HEADERS = "Access-Control-Expose-Headers";

	public const string ACCESS_CONTROL_MAX_AGE = "Access-Control-Max-Age";

	public const string AGE = "Age";

	public const string ALLOW = "Allow";

	public const string CONTENT_DISPOSITION = "Content-Disposition";

	public const string CONTENT_ENCODING = "Content-Encoding";

	public const string CONTENT_LANGUAGE = "Content-Language";

	public const string CONTENT_LOCATION = "Content-Location";

	public const string CONTENT_MD5 = "Content-MD5";

	public const string CONTENT_RANGE = "Content-Range";

	public const string CONTENT_SECURITY_POLICY = "Content-Security-Policy";

	public const string CONTENT_SECURITY_POLICY_REPORT_ONLY = "Content-Security-Policy-Report-Only";

	public const string X_CONTENT_SECURITY_POLICY = "X-Content-Security-Policy";

	public const string X_CONTENT_SECURITY_POLICY_REPORT_ONLY = "X-Content-Security-Policy-Report-Only";

	public const string X_WEBKIT_CSP = "X-WebKit-CSP";

	public const string X_WEBKIT_CSP_REPORT_ONLY = "X-WebKit-CSP-Report-Only";

	public const string CROSS_ORIGIN_EMBEDDER_POLICY = "Cross-Origin-Embedder-Policy";

	public const string CROSS_ORIGIN_EMBEDDER_POLICY_REPORT_ONLY = "Cross-Origin-Embedder-Policy-Report-Only";

	public const string CROSS_ORIGIN_OPENER_POLICY = "Cross-Origin-Opener-Policy";

	public const string ETAG = "ETag";

	public const string EXPIRES = "Expires";

	public const string LAST_MODIFIED = "Last-Modified";

	public const string LINK = "Link";

	public const string LOCATION = "Location";

	public const string KEEP_ALIVE = "Keep-Alive";

	public const string ORIGIN_TRIAL = "Origin-Trial";

	public const string P3P = "P3P";

	public const string PROXY_AUTHENTICATE = "Proxy-Authenticate";

	public const string REFRESH = "Refresh";

	public const string REPORT_TO = "Report-To";

	public const string RETRY_AFTER = "Retry-After";

	public const string SERVER = "Server";

	public const string SERVER_TIMING = "Server-Timing";

	public const string SERVICE_WORKER_ALLOWED = "Service-Worker-Allowed";

	public const string SET_COOKIE = "Set-Cookie";

	public const string SET_COOKIE2 = "Set-Cookie2";

	public const string SOURCE_MAP = "SourceMap";

	public const string STRICT_TRANSPORT_SECURITY = "Strict-Transport-Security";

	public const string TIMING_ALLOW_ORIGIN = "Timing-Allow-Origin";

	public const string TRAILER = "Trailer";

	public const string TRANSFER_ENCODING = "Transfer-Encoding";

	public const string VARY = "Vary";

	public const string WWW_AUTHENTICATE = "WWW-Authenticate";

	public const string DNT = "DNT";

	public const string X_CONTENT_TYPE_OPTIONS = "X-Content-Type-Options";

	public const string X_DEVICE_IP = "X-Device-IP";

	public const string X_DEVICE_REFERER = "X-Device-Referer";

	public const string X_DEVICE_ACCEPT_LANGUAGE = "X-Device-Accept-Language";

	public const string X_DEVICE_REQUESTED_WITH = "X-Device-Requested-With";

	public const string X_DO_NOT_TRACK = "X-Do-Not-Track";

	public const string X_FORWARDED_FOR = "X-Forwarded-For";

	public const string X_FORWARDED_PROTO = "X-Forwarded-Proto";

	public const string X_FORWARDED_HOST = "X-Forwarded-Host";

	public const string X_FORWARDED_PORT = "X-Forwarded-Port";

	public const string X_FRAME_OPTIONS = "X-Frame-Options";

	public const string X_POWERED_BY = "X-Powered-By";

	public const string PUBLIC_KEY_PINS = "Public-Key-Pins";

	public const string PUBLIC_KEY_PINS_REPORT_ONLY = "Public-Key-Pins-Report-Only";

	public const string X_REQUEST_ID = "X-Request-ID";

	public const string X_REQUESTED_WITH = "X-Requested-With";

	public const string X_USER_IP = "X-User-IP";

	public const string X_DOWNLOAD_OPTIONS = "X-Download-Options";

	public const string X_XSS_PROTECTION = "X-XSS-Protection";

	public const string X_DNS_PREFETCH_CONTROL = "X-DNS-Prefetch-Control";

	public const string PING_FROM = "Ping-From";

	public const string PING_TO = "Ping-To";

	public const string PURPOSE = "Purpose";

	public const string X_PURPOSE = "X-Purpose";

	public const string X_MOZ = "X-Moz";

	public const string DEVICE_MEMORY = "Device-Memory";

	public const string DOWNLINK = "Downlink";

	public const string ECT = "ECT";

	public const string RTT = "RTT";

	public const string SAVE_DATA = "Save-Data";

	public const string VIEWPORT_WIDTH = "Viewport-Width";

	public const string WIDTH = "Width";

	public const string PERMISSIONS_POLICY = "Permissions-Policy";

	public const string SEC_CH_PREFERS_COLOR_SCHEME = "Sec-CH-Prefers-Color-Scheme";

	public const string ACCEPT_CH = "Accept-CH";

	public const string CRITICAL_CH = "Critical-CH";

	public const string SEC_CH_UA = "Sec-CH-UA";

	public const string SEC_CH_UA_ARCH = "Sec-CH-UA-Arch";

	public const string SEC_CH_UA_MODEL = "Sec-CH-UA-Model";

	public const string SEC_CH_UA_PLATFORM = "Sec-CH-UA-Platform";

	public const string SEC_CH_UA_PLATFORM_VERSION = "Sec-CH-UA-Platform-Version";

	[Obsolete]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public const string SEC_CH_UA_FULL_VERSION = "Sec-CH-UA-Full-Version";

	public const string SEC_CH_UA_FULL_VERSION_LIST = "Sec-CH-UA-Full-Version-List";

	public const string SEC_CH_UA_MOBILE = "Sec-CH-UA-Mobile";

	public const string SEC_CH_UA_BITNESS = "Sec-CH-UA-Bitness";

	public const string SEC_FETCH_DEST = "Sec-Fetch-Dest";

	public const string SEC_FETCH_MODE = "Sec-Fetch-Mode";

	public const string SEC_FETCH_SITE = "Sec-Fetch-Site";

	public const string SEC_FETCH_USER = "Sec-Fetch-User";

	public const string SEC_METADATA = "Sec-Metadata";

	public const string SEC_TOKEN_BINDING = "Sec-Token-Binding";

	public const string SEC_PROVIDED_TOKEN_BINDING_ID = "Sec-Provided-Token-Binding-ID";

	public const string SEC_REFERRED_TOKEN_BINDING_ID = "Sec-Referred-Token-Binding-ID";

	public const string SEC_WEBSOCKET_ACCEPT = "Sec-WebSocket-Accept";

	public const string SEC_WEBSOCKET_EXTENSIONS = "Sec-WebSocket-Extensions";

	public const string SEC_WEBSOCKET_KEY = "Sec-WebSocket-Key";

	public const string SEC_WEBSOCKET_PROTOCOL = "Sec-WebSocket-Protocol";

	public const string SEC_WEBSOCKET_VERSION = "Sec-WebSocket-Version";

	public const string CDN_LOOP = "CDN-Loop";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	private HttpHeaders()
	{
	}
}
