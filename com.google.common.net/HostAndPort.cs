using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using javax.annotation;

namespace com.google.common.net;

[Serializable]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/net/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public sealed class HostAndPort : java.lang.Object, Serializable.__Interface, ISerializable
{
	private const int NO_PORT = -1;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string host;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int port;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool hasBracketlessColons;

	private const long serialVersionUID = 0L;

	public virtual bool hasPort()
	{
		return port >= 0;
	}

	private static bool isValidPort(int P_0)
	{
		return (P_0 >= 0 && P_0 <= 65535) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		118, 135, 98, 130, 109, 103, 100, 100, 98, 106,
		148, 106, 173, 98, 201, 99, 171, 102, 63, 17,
		229, 69, 179, 2, 97, 159, 20, 178
	})]
	public static HostAndPort fromString(string hostPortString)
	{
		Preconditions.checkNotNull(hostPortString);
		string text = null;
		int num = 0;
		string text2;
		int num2;
		if (java.lang.String.instancehelper_startsWith(hostPortString, "["))
		{
			string[] hostAndPortFromBracketedHost = getHostAndPortFromBracketedHost(hostPortString);
			text2 = hostAndPortFromBracketedHost[0];
			text = hostAndPortFromBracketedHost[1];
		}
		else
		{
			num2 = java.lang.String.instancehelper_indexOf(hostPortString, 58);
			if (num2 >= 0 && java.lang.String.instancehelper_indexOf(hostPortString, 58, num2 + 1) == -1)
			{
				text2 = java.lang.String.instancehelper_substring(hostPortString, 0, num2);
				text = java.lang.String.instancehelper_substring(hostPortString, num2 + 1);
			}
			else
			{
				text2 = hostPortString;
				num = ((num2 >= 0) ? 1 : 0);
			}
		}
		num2 = -1;
		int b;
		if (!Strings.isNullOrEmpty(text))
		{
			if (!java.lang.String.instancehelper_startsWith(text, "+"))
			{
				CharMatcher charMatcher = CharMatcher.ascii();
				CharSequence sequence = default(CharSequence);
				object obj = (sequence.___003Cref_003E = text);
				if (charMatcher.matchesAllOf(sequence))
				{
					b = 1;
					goto IL_00a7;
				}
			}
			b = 0;
			goto IL_00a7;
		}
		goto IL_010d;
		IL_00a7:
		Preconditions.checkArgument((byte)b != 0, "Unparseable port number: %s", hostPortString);
		try
		{
			num2 = Integer.parseInt(text);
		}
		catch (NumberFormatException)
		{
			goto IL_00c2;
		}
		Preconditions.checkArgument(isValidPort(num2), "Port number out of range: %s", hostPortString);
		goto IL_010d;
		IL_010d:
		return new HostAndPort(text2, num2, (byte)num != 0);
		IL_00c2:
		_ = null;
		string text3 = java.lang.String.valueOf(hostPortString);
		string s;
		if (java.lang.String.instancehelper_length(text3) != 0)
		{
			s = java.lang.String.instancehelper_concat("Unparseable port number: ", text3);
		}
		else
		{
			string text4 = "Unparseable port number: ";
			text4 = text4;
			s = java.lang.String.newhelper(text4);
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 123, 162, 104, 103, 103, 103 })]
	private HostAndPort(string P_0, int P_1, bool P_2)
	{
		host = P_0;
		port = P_1;
		hasBracketlessColons = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 103, 98, 47, 197, 105, 105, 247, 69, 105,
		107, 147, 100, 47, 197, 109, 98, 48, 37, 230,
		70
	})]
	private static string[] getHostAndPortFromBracketedHost(string P_0)
	{
		Preconditions.checkArgument(java.lang.String.instancehelper_charAt(P_0, 0) == '[', "Bracketed host-port string must start with a bracket: %s", P_0);
		int num = java.lang.String.instancehelper_indexOf(P_0, 58);
		int num2 = java.lang.String.instancehelper_lastIndexOf(P_0, 93);
		Preconditions.checkArgument((num > -1 && num2 > num) ? true : false, "Invalid bracketed host/port: %s", P_0);
		string text = java.lang.String.instancehelper_substring(P_0, 1, num2);
		if (num2 + 1 != java.lang.String.instancehelper_length(P_0))
		{
			Preconditions.checkArgument(java.lang.String.instancehelper_charAt(P_0, num2 + 1) == ':', "Only a colon may follow a close bracket: %s", P_0);
			for (int i = num2 + 2; i < java.lang.String.instancehelper_length(P_0); i++)
			{
				Preconditions.checkArgument(Character.isDigit(java.lang.String.instancehelper_charAt(P_0, i)), "Port must be numeric: %s", P_0);
			}
			return new string[2]
			{
				text,
				java.lang.String.instancehelper_substring(P_0, num2 + 2)
			};
		}
		return new string[2] { text, "" };
	}

	public virtual string getHost()
	{
		return host;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 61, 107 })]
	public virtual int getPort()
	{
		Preconditions.checkState(hasPort());
		return port;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(117)]
	public virtual int getPortOrDefault(int defaultPort)
	{
		return (!hasPort()) ? defaultPort : port;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 83, 113, 103, 119 })]
	public static HostAndPort fromParts(string host, int port)
	{
		Preconditions.checkArgument(isValidPort(port), "Port out of range: %s", port);
		HostAndPort hostAndPort = fromString(host);
		Preconditions.checkArgument((!hostAndPort.hasPort()) ? true : false, "Host has a port: %s", host);
		HostAndPort result = new HostAndPort(hostAndPort.host, port, hostAndPort.hasBracketlessColons);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 101, 103, 119 })]
	public static HostAndPort fromHost(string host)
	{
		HostAndPort hostAndPort = fromString(host);
		Preconditions.checkArgument((!hostAndPort.hasPort()) ? true : false, "Host has a port: %s", host);
		return hostAndPort;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 142, 107, 104, 130 })]
	public virtual HostAndPort withDefaultPort(int defaultPort)
	{
		Preconditions.checkArgument(isValidPort(defaultPort));
		if (hasPort())
		{
			return this;
		}
		HostAndPort result = new HostAndPort(host, defaultPort, hasBracketlessColons);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 165, 124 })]
	public virtual HostAndPort requireBracketsForIPv6()
	{
		Preconditions.checkArgument((!hasBracketlessColons) ? true : false, "Possible bracketless IPv6 literal: %s", host);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 171, 100, 130, 104, 103, 159, 7 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object other)
	{
		if (this == other)
		{
			return true;
		}
		if (other is HostAndPort)
		{
			HostAndPort hostAndPort = (HostAndPort)other;
			return (Objects.equal(host, hostAndPort.host) && port == hostAndPort.port) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(297)]
	public override int hashCode()
	{
		int result = Objects.hashCode(host, Integer.valueOf(port));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 190, 115, 112, 157, 141, 104, 148 })]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder(java.lang.String.instancehelper_length(host) + 8);
		if (java.lang.String.instancehelper_indexOf(host, 58) >= 0)
		{
			stringBuilder.append('[').append(host).append(']');
		}
		else
		{
			stringBuilder.append(host);
		}
		if (hasPort())
		{
			stringBuilder.append(':').append(port);
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(HostAndPort P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected HostAndPort(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
