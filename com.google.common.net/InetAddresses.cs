using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.hash;
using com.google.common.io;
using com.google.common.primitives;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.math;
using java.net;
using java.nio;
using java.util;
using javax.annotation;

namespace com.google.common.net;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/net/ElementTypesAreNonnullByDefault;"
})]
public sealed class InetAddresses : Object
{
	public sealed class TeredoInfo : Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Inet4Address server;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Inet4Address client;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int port;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int flags;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 61, 104, 155, 254, 69, 118, 118, 103, 104 })]
		public TeredoInfo([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Inet4Address server, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Inet4Address client, int port, int flags)
		{
			Preconditions.checkArgument((port >= 0 && port <= 65535) ? true : false, "port '%s' is out of range (0 <= port <= 0xffff)", port);
			Preconditions.checkArgument((flags >= 0 && flags <= 65535) ? true : false, "flags '%s' is out of range (0 <= flags <= 0xffff)", flags);
			this.server = (Inet4Address)MoreObjects.firstNonNull(server, access_0024000());
			this.client = (Inet4Address)MoreObjects.firstNonNull(client, access_0024000());
			this.port = port;
			this.flags = flags;
		}

		public virtual Inet4Address getServer()
		{
			return server;
		}

		public virtual Inet4Address getClient()
		{
			return client;
		}

		public virtual int getPort()
		{
			return port;
		}

		public virtual int getFlags()
		{
			return flags;
		}
	}

	private const int IPV4_PART_COUNT = 4;

	private const int IPV6_PART_COUNT = 8;

	private const char IPV4_DELIMITER = '.';

	private const char IPV6_DELIMITER = ':';

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static CharMatcher IPV4_DELIMITER_MATCHER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static CharMatcher IPV6_DELIMITER_MATCHER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Inet4Address LOOPBACK4;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Inet4Address ANY4;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 98, 167, 99, 186 })]
	public static InetAddress forString(string ipString)
	{
		byte[] array = ipStringToBytes(ipString);
		if (array == null)
		{
			throw Throwable.___003Cunmap_003E(formatIllegalArgumentException("'%s' is not an IP string literal.", ipString));
		}
		InetAddress result = bytesToInetAddress(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 135, 104, 159, 32 })]
	public static string toUriString(InetAddress ip)
	{
		if (ip is Inet6Address)
		{
			string text = toAddrString(ip);
			int num = 2 + String.instancehelper_length(String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("[").append(text).append("]")
				.toString();
			_ = null;
			return result;
		}
		string result2 = toAddrString(ip);
		_ = null;
		return result2;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Inet4Address access_0024000()
	{
		return ANY4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 15, 124, 97 })]
	private static InetAddress bytesToInetAddress(byte[] P_0)
	{
		//Discarded unreachable code: IL_0008
		UnknownHostException ex;
		try
		{
			return InetAddress.getByAddress(P_0);
		}
		catch (UnknownHostException x)
		{
			ex = ByteCodeHelper.MapException<UnknownHostException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		UnknownHostException detailMessage = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError(detailMessage);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		127, 130, 98, 98, 98, 112, 106, 102, 100, 102,
		99, 130, 100, 102, 99, 98, 108, 226, 51, 235,
		82, 99, 99, 103, 99, 162, 100, 137, 105, 99,
		100, 130, 137
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static byte[] ipStringToBytes(string P_0)
	{
		string text = P_0;
		int num = 0;
		int num2 = 0;
		int num3 = -1;
		for (int i = 0; i < String.instancehelper_length(text); i++)
		{
			int num4 = String.instancehelper_charAt(text, i);
			switch (num4)
			{
			case 46:
				num2 = 1;
				continue;
			case 58:
				if (num2 != 0)
				{
					return null;
				}
				num = 1;
				continue;
			case 37:
				break;
			default:
				if (Character.digit((char)num4, 16) != -1)
				{
					continue;
				}
				return null;
			}
			num3 = i;
			break;
		}
		if (num != 0)
		{
			if (num2 != 0)
			{
				text = convertDottedQuadToHex(text);
				if (text == null)
				{
					return null;
				}
			}
			if (num3 != -1)
			{
				text = String.instancehelper_substring(text, 0, num3);
			}
			byte[] result = textToNumericFormatV6(text);
			_ = null;
			return result;
		}
		if (num2 != 0)
		{
			if (num3 != -1)
			{
				return null;
			}
			byte[] result2 = textToNumericFormatV4(text);
			_ = null;
			return result2;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1153)]
	private static IllegalArgumentException formatIllegalArgumentException(string P_0, params object[] P_1)
	{
		IllegalArgumentException result = new IllegalArgumentException(String.format(Locale.ROOT, P_0, P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 205, 105, 107, 106, 103, 99, 130, 112, 112 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static string convertDottedQuadToHex(string P_0)
	{
		int num = String.instancehelper_lastIndexOf(P_0, 58);
		string text = String.instancehelper_substring(P_0, 0, num + 1);
		string text2 = String.instancehelper_substring(P_0, num + 1);
		byte[] array = textToNumericFormatV4(text2);
		if (array == null)
		{
			return null;
		}
		string text3 = Integer.toHexString((array[0] << 8) | array[1]);
		string text4 = Integer.toHexString((array[2] << 8) | array[3]);
		int num2 = 1 + String.instancehelper_length(String.valueOf(text)) + String.instancehelper_length(String.valueOf(text3)) + String.instancehelper_length(String.valueOf(text4));
		num2 = num2;
		string result = new StringBuilder(num2).append(text).append(text3).append(":")
			.append(text4)
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 135, 124, 104, 130, 102, 163, 111, 122, 100,
		130, 99, 100, 100, 132, 108, 228, 53, 235, 79,
		118, 130, 116, 112, 130, 104, 130, 106, 162, 233,
		69, 99, 107, 131, 109, 108, 101, 136, 140, 104,
		41, 234, 69, 146, 102, 174, 2, 97, 130
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static byte[] textToNumericFormatV6(string P_0)
	{
		CharMatcher iPV6_DELIMITER_MATCHER = IPV6_DELIMITER_MATCHER;
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = P_0);
		int num = iPV6_DELIMITER_MATCHER.countIn(sequence);
		if (num < 2 || num > 8)
		{
			return null;
		}
		int num2 = 8 - (num + 1);
		int num3 = 0;
		for (int i = 0; i < String.instancehelper_length(P_0) - 1; i++)
		{
			if (String.instancehelper_charAt(P_0, i) == ':' && String.instancehelper_charAt(P_0, i + 1) == ':')
			{
				if (num3 != 0)
				{
					return null;
				}
				num3 = 1;
				num2++;
				if (i == 0)
				{
					num2++;
				}
				if (i == String.instancehelper_length(P_0) - 2)
				{
					num2++;
				}
			}
		}
		if (String.instancehelper_charAt(P_0, 0) == ':' && String.instancehelper_charAt(P_0, 1) != ':')
		{
			return null;
		}
		if (String.instancehelper_charAt(P_0, String.instancehelper_length(P_0) - 1) == ':' && String.instancehelper_charAt(P_0, String.instancehelper_length(P_0) - 2) != ':')
		{
			return null;
		}
		if (num3 != 0 && num2 <= 0)
		{
			return null;
		}
		if (num3 == 0 && num + 1 != 8)
		{
			return null;
		}
		ByteBuffer byteBuffer = ByteBuffer.allocate(16);
		try
		{
			int num4 = 0;
			if (String.instancehelper_charAt(P_0, 0) == ':')
			{
				num4 = 1;
			}
			while (num4 < String.instancehelper_length(P_0))
			{
				int num5 = String.instancehelper_indexOf(P_0, 58, num4);
				if (num5 == -1)
				{
					num5 = String.instancehelper_length(P_0);
				}
				if (String.instancehelper_charAt(P_0, num4) == ':')
				{
					for (int j = 0; j < num2; j++)
					{
						byteBuffer.putShort(0);
					}
				}
				else
				{
					byteBuffer.putShort(parseHextet(P_0, num4, num5));
				}
				num4 = num5 + 1;
			}
		}
		catch (NumberFormatException)
		{
			goto IL_0166;
		}
		return byteBuffer.array();
		IL_0166:
		_ = null;
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 108, 127, 1, 162, 103, 162, 104, 107, 101,
		168, 185, 2, 97, 130, 229, 54, 232, 77
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static byte[] textToNumericFormatV4(string P_0)
	{
		CharMatcher iPV4_DELIMITER_MATCHER = IPV4_DELIMITER_MATCHER;
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = P_0);
		if (iPV4_DELIMITER_MATCHER.countIn(sequence) + 1 != 4)
		{
			return null;
		}
		byte[] array = new byte[4];
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			int num2 = String.instancehelper_indexOf(P_0, 46, num);
			if (num2 == -1)
			{
				num2 = String.instancehelper_length(P_0);
			}
			try
			{
				array[i] = (byte)(sbyte)parseOctet(P_0, num, num2);
			}
			catch (NumberFormatException)
			{
				goto IL_0061;
			}
			num = num2 + 1;
			continue;
			IL_0061:
			_ = null;
			return null;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 220, 100, 104, 203, 111, 139, 98, 102, 101,
		111, 100, 139, 228, 58, 230, 72, 104, 139
	})]
	private static byte parseOctet(string P_0, int P_1, int P_2)
	{
		switch (P_2 - P_1)
		{
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NumberFormatException();
		case 2:
		case 3:
			if (String.instancehelper_charAt(P_0, P_1) == '0')
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NumberFormatException();
			}
			break;
		case 1:
			break;
		}
		int num = 0;
		for (int i = P_1; i < P_2; i++)
		{
			num *= 10;
			int num2 = Character.digit(String.instancehelper_charAt(P_0, i), 10);
			if (num2 < 0)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NumberFormatException();
			}
			num += num2;
		}
		if (num > 255)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NumberFormatException();
		}
		return (byte)(sbyte)num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 247, 100, 104, 139, 98, 102, 100, 17, 198 })]
	private static short parseHextet(string P_0, int P_1, int P_2)
	{
		int num = P_2 - P_1;
		if (num <= 0 || num > 4)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NumberFormatException();
		}
		int num2 = 0;
		for (int i = P_1; i < P_2; i++)
		{
			num2 <<= 4;
			num2 |= Character.digit(String.instancehelper_charAt(P_0, i), 16);
		}
		return (short)num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 61, 98, 98, 98, 105, 106, 100, 132, 100,
		101, 101, 98, 131, 226, 53, 230, 78, 100, 141
	})]
	private static void compressLongestRunOfZeroes(int[] P_0)
	{
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		for (int i = 0; i < (nint)P_0.LongLength + 1; i++)
		{
			if (i < (nint)P_0.LongLength && P_0[i] == 0)
			{
				if (num3 < 0)
				{
					num3 = i;
				}
			}
			else if (num3 >= 0)
			{
				int num4 = i - num3;
				if (num4 > num2)
				{
					num = num3;
					num2 = num4;
				}
				num3 = -1;
			}
		}
		if (num2 >= 2)
		{
			Arrays.fill(P_0, num, num + num2, -1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 96, 104, 98, 106, 106, 99, 99, 137, 145,
		102, 172, 226, 52, 233, 78
	})]
	private static string hextetsToIPv6String(int[] P_0)
	{
		StringBuilder stringBuilder = new StringBuilder(39);
		int num = 0;
		for (int i = 0; i < (nint)P_0.LongLength; i++)
		{
			int num2 = ((P_0[i] >= 0) ? 1 : 0);
			if (num2 != 0)
			{
				if (num != 0)
				{
					stringBuilder.append(':');
				}
				stringBuilder.append(Integer.toHexString(P_0[i]));
			}
			else if (i == 0 || num != 0)
			{
				stringBuilder.append("::");
			}
			num = num2;
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 37, 103, 136, 137, 110, 103, 103, 103, 54,
		166, 102
	})]
	public static string toAddrString(InetAddress ip)
	{
		Preconditions.checkNotNull(ip);
		if (ip is Inet4Address)
		{
			string hostAddress = ip.getHostAddress();
			_ = null;
			return hostAddress;
		}
		Preconditions.checkArgument(ip is Inet6Address);
		byte[] address = ip.getAddress();
		int[] array = new int[8];
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			array[i] = Ints.fromBytes(0, 0, address[2 * i], address[2 * i + 1]);
		}
		compressLongestRunOfZeroes(array);
		string result = hextetsToIPv6String(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 171, 231, 69, 122, 112, 133, 98, 194, 103,
		104, 162
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static InetAddress forUriStringNoThrow(string P_0)
	{
		Preconditions.checkNotNull(P_0);
		string text;
		int num;
		if (String.instancehelper_startsWith(P_0, "[") && String.instancehelper_endsWith(P_0, "]"))
		{
			text = String.instancehelper_substring(P_0, 1, String.instancehelper_length(P_0) - 1);
			num = 16;
		}
		else
		{
			text = P_0;
			num = 4;
		}
		byte[] array = ipStringToBytes(text);
		if (array == null || (nint)array.LongLength != num)
		{
			return null;
		}
		InetAddress result = bytesToInetAddress(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 228, 104, 162, 103, 223, 0, 162 })]
	public static bool isCompatIPv4Address(Inet6Address ip)
	{
		if (!ip.isIPv4CompatibleAddress())
		{
			return false;
		}
		byte[] address = ip.getAddress();
		if (address[12] == 0 && address[13] == 0 && address[14] == 0 && (address[15] == 0 || address[15] == 1))
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 70, 241, 70 })]
	private static Inet4Address getInet4Address(byte[] P_0)
	{
		Preconditions.checkArgument((nint)P_0.LongLength == 4, "Byte array has invalid length for an IPv4 address: %s != 4.", P_0.Length);
		return (Inet4Address)bytesToInetAddress(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 14, 103 })]
	public static bool is6to4Address(Inet6Address ip)
	{
		byte[] address = ip.getAddress();
		return (address[0] == 32 && address[1] == 2) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 101, 103 })]
	public static bool isTeredoAddress(Inet6Address ip)
	{
		byte[] address = ip.getAddress();
		return (address[0] == 32 && address[1] == 1 && address[2] == 0 && address[3] == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 153, 104, 162, 135, 200, 162 })]
	public static bool isIsatapAddress(Inet6Address ip)
	{
		if (isTeredoAddress(ip))
		{
			return false;
		}
		byte[] address = ip.getAddress();
		if ((address[8] | 3) != 3)
		{
			return false;
		}
		return (address[9] == 0 && address[10] == 94 && address[11] == -2) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 251, 97, 48, 165 })]
	public static Inet4Address getCompatIPv4Address(Inet6Address ip)
	{
		Preconditions.checkArgument(isCompatIPv4Address(ip), "Address '%s' is not IPv4-compatible.", toAddrString(ip));
		Inet4Address inet4Address = getInet4Address(Arrays.copyOfRange(ip.getAddress(), 12, 16));
		_ = null;
		return inet4Address;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 26, 150 })]
	public static Inet4Address get6to4IPv4Address(Inet6Address ip)
	{
		Preconditions.checkArgument(is6to4Address(ip), "Address '%s' is not a 6to4 address.", toAddrString(ip));
		Inet4Address inet4Address = getInet4Address(Arrays.copyOfRange(ip.getAddress(), 2, 6));
		_ = null;
		return inet4Address;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 116, 150, 103, 142, 179, 150, 108, 138, 13,
		200, 137
	})]
	public static TeredoInfo getTeredoInfo(Inet6Address ip)
	{
		Preconditions.checkArgument(isTeredoAddress(ip), "Address '%s' is not a Teredo address.", toAddrString(ip));
		byte[] address = ip.getAddress();
		Inet4Address inet4Address = getInet4Address(Arrays.copyOfRange(address, 4, 8));
		int flags = ByteStreams.newDataInput(address, 8).readShort() & 0xFFFF;
		int port = (ByteStreams.newDataInput(address, 10).readShort() ^ -1) & 0xFFFF;
		byte[] array = Arrays.copyOfRange(address, 12, 16);
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			array[i] = (byte)(sbyte)(array[i] ^ 0xFFFFFFFFu);
		}
		Inet4Address inet4Address2 = getInet4Address(array);
		TeredoInfo result = new TeredoInfo(inet4Address, inet4Address2, port, flags);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(821)]
	public static bool hasEmbeddedIPv4ClientAddress(Inet6Address ip)
	{
		return (isCompatIPv4Address(ip) || is6to4Address(ip) || isTeredoAddress(ip)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 211, 104, 169, 104, 169, 104, 174 })]
	public static Inet4Address getEmbeddedIPv4ClientAddress(Inet6Address ip)
	{
		if (isCompatIPv4Address(ip))
		{
			Inet4Address compatIPv4Address = getCompatIPv4Address(ip);
			_ = null;
			return compatIPv4Address;
		}
		if (is6to4Address(ip))
		{
			Inet4Address result = get6to4IPv4Address(ip);
			_ = null;
			return result;
		}
		if (isTeredoAddress(ip))
		{
			Inet4Address client = getTeredoInfo(ip).getClient();
			_ = null;
			return client;
		}
		throw Throwable.___003Cunmap_003E(formatIllegalArgumentException("'%s' has no embedded IPv4 address.", toAddrString(ip)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 34, 104, 199, 103, 98, 103, 101, 98, 226,
		61, 230, 70, 106, 102, 105, 166, 103, 99, 104,
		176, 212, 179, 202, 101, 164
	})]
	public static Inet4Address getCoercedIPv4Address(InetAddress ip)
	{
		if (ip is Inet4Address)
		{
			return (Inet4Address)ip;
		}
		byte[] address = ip.getAddress();
		int num = 1;
		for (int i = 0; i < 15; i++)
		{
			if (address[i] != 0)
			{
				num = 0;
				break;
			}
		}
		if (num != 0 && address[15] == 1)
		{
			return LOOPBACK4;
		}
		if (num != 0 && address[15] == 0)
		{
			return ANY4;
		}
		Inet6Address inet6Address = (Inet6Address)ip;
		_ = 0;
		long l = ((!hasEmbeddedIPv4ClientAddress(inet6Address)) ? ByteBuffer.wrap(inet6Address.getAddress(), 0, 8).getLong() : getEmbeddedIPv4ClientAddress(inet6Address).hashCode());
		int num2 = Hashing.murmur3_32_fixed().hashLong(l).asInt();
		num2 |= -536870912;
		if (num2 == -1)
		{
			num2 = -2;
		}
		Inet4Address inet4Address = getInet4Address(Ints.toByteArray(num2));
		_ = null;
		return inet4Address;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 139, 130, 150, 137, 103, 135, 108, 103, 166,
		105, 102, 174, 234, 61, 11, 232, 74, 173, 127,
		2, 98
	})]
	private static InetAddress fromBigInteger(BigInteger P_0, bool P_1)
	{
		//Discarded unreachable code: IL_0097
		Preconditions.checkArgument(P_0.signum() >= 0, (object)"BigInteger must be greater than or equal to 0");
		int num = ((!P_1) ? 4 : 16);
		byte[] array = P_0.toByteArray();
		byte[] array2 = new byte[num];
		int num2 = Math.max(0, (int)((nint)array.LongLength - num));
		int num3 = (int)((nint)array.LongLength - num2);
		int destStart = num - num3;
		for (int i = 0; i < num2; i++)
		{
			if (array[i] != 0)
			{
				throw Throwable.___003Cunmap_003E(formatIllegalArgumentException("BigInteger cannot be converted to InetAddress because it has more than %d bytes: %s", Integer.valueOf(num), P_0));
			}
		}
		ByteCodeHelper.arraycopy_primitive_1(array, num2, array2, destStart, num3);
		UnknownHostException ex;
		try
		{
			return InetAddress.getByAddress(array2);
		}
		catch (UnknownHostException x)
		{
			ex = ByteCodeHelper.MapException<UnknownHostException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		UnknownHostException detailMessage = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError(detailMessage);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(110)]
	private InetAddresses()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(171)]
	public static bool isInetAddress(string ipString)
	{
		return ipStringToBytes(ipString) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 161, 103, 99, 186 })]
	public static InetAddress forUriString(string hostAddr)
	{
		InetAddress inetAddress = forUriStringNoThrow(hostAddr);
		if (inetAddress == null)
		{
			throw Throwable.___003Cunmap_003E(formatIllegalArgumentException("Not a valid URI IP literal: '%s'", hostAddr));
		}
		return inetAddress;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(576)]
	public static bool isUriInetAddress(string ipString)
	{
		return forUriStringNoThrow(ipString) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 177, 150 })]
	public static Inet4Address getIsatapIPv4Address(Inet6Address ip)
	{
		Preconditions.checkArgument(isIsatapAddress(ip), "Address '%s' is not an ISATAP address.", toAddrString(ip));
		Inet4Address inet4Address = getInet4Address(Arrays.copyOfRange(ip.getAddress(), 12, 16));
		_ = null;
		return inet4Address;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 249, 103, 105, 103, 101, 2, 230, 69, 104,
		102, 2, 230, 69, 130
	})]
	public static bool isMappedIPv4Address(string ipString)
	{
		byte[] array = ipStringToBytes(ipString);
		if (array != null && (nint)array.LongLength == 16)
		{
			for (int i = 0; i < 10; i++)
			{
				if (array[i] != 0)
				{
					return false;
				}
			}
			for (int i = 10; i < 12; i++)
			{
				if (array[i] != -1)
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(978)]
	public static int coerceToInteger(InetAddress ip)
	{
		int result = ByteStreams.newDataInput(getCoercedIPv4Address(ip).getAddress()).readInt();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(991)]
	public static BigInteger toBigInteger(InetAddress address)
	{
		BigInteger.___003Cclinit_003E();
		BigInteger result = new BigInteger(1, address.getAddress());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1001)]
	public static Inet4Address fromInteger(int address)
	{
		Inet4Address inet4Address = getInet4Address(Ints.toByteArray(address));
		_ = null;
		return inet4Address;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1013)]
	public static Inet4Address fromIPv4BigInteger(BigInteger address)
	{
		return (Inet4Address)fromBigInteger(address, false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1024)]
	public static Inet6Address fromIPv6BigInteger(BigInteger address)
	{
		return (Inet6Address)fromBigInteger(address, true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.net.UnknownHostException" })]
	[LineNumberTable(new byte[] { 163, 198, 104, 103, 43, 166 })]
	public static InetAddress fromLittleEndianByteArray(byte[] addr)
	{
		byte[] array = new byte[(nint)addr.LongLength];
		for (int i = 0; i < (nint)addr.LongLength; i++)
		{
			array[i] = addr[(nint)addr.LongLength - i - 1];
		}
		InetAddress byAddress = InetAddress.getByAddress(array);
		_ = null;
		return byAddress;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 215, 103, 101, 105, 100, 166, 146, 109 })]
	public static InetAddress decrement(InetAddress address)
	{
		byte[] address2 = address.getAddress();
		int i;
		for (i = (int)((nint)address2.LongLength - 1); i >= 0 && address2[i] == 0; i += -1)
		{
			address2[i] = byte.MaxValue;
		}
		Preconditions.checkArgument(i >= 0, "Decrementing %s would wrap.", address);
		int num = i;
		byte[] array = address2;
		array[num] = (byte)(sbyte)(array[num] - 1);
		InetAddress result = bytesToInetAddress(address2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 238, 103, 101, 106, 100, 166, 146, 109 })]
	public static InetAddress increment(InetAddress address)
	{
		byte[] address2 = address.getAddress();
		int i;
		for (i = (int)((nint)address2.LongLength - 1); i >= 0 && address2[i] == -1; i += -1)
		{
			address2[i] = 0;
		}
		Preconditions.checkArgument(i >= 0, "Incrementing %s would wrap.", address);
		int num = i;
		byte[] array = address2;
		array[num] = (byte)(sbyte)(array[num] + 1);
		InetAddress result = bytesToInetAddress(address2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 4, 103, 112, 101, 2, 230, 69 })]
	public static bool isMaximum(InetAddress address)
	{
		byte[] address2 = address.getAddress();
		byte[] array = address2;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			int num2 = array[i];
			if (num2 != -1)
			{
				return false;
			}
		}
		return true;
	}

	[LineNumberTable(new byte[] { 55, 108, 108, 116 })]
	static InetAddresses()
	{
		IPV4_DELIMITER_MATCHER = CharMatcher.@is('.');
		IPV6_DELIMITER_MATCHER = CharMatcher.@is(':');
		LOOPBACK4 = (Inet4Address)forString("127.0.0.1");
		ANY4 = (Inet4Address)forString("0.0.0.0");
	}
}
