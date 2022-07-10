using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.net;
using java.text;
using javax.annotation;

namespace com.google.common.net;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/net/ElementTypesAreNonnullByDefault;"
})]
public sealed class HostSpecifier : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string canonicalForm;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 0, 104, 103 })]
	private HostSpecifier(string P_0)
	{
		canonicalForm = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		23, 103, 113, 231, 70, 130, 178, 2, 193, 99,
		236, 70, 135, 104, 172
	})]
	public static HostSpecifier fromValid(string specifier)
	{
		HostAndPort hostAndPort = HostAndPort.fromString(specifier);
		Preconditions.checkArgument((!hostAndPort.hasPort()) ? true : false);
		string host = hostAndPort.getHost();
		InetAddress inetAddress = null;
		try
		{
			inetAddress = InetAddresses.forString(host);
		}
		catch (IllegalArgumentException)
		{
			goto IL_0030;
		}
		goto IL_0036;
		IL_0030:
		_ = null;
		goto IL_0036;
		IL_0036:
		if (inetAddress != null)
		{
			return new HostSpecifier(InetAddresses.toUriString(inetAddress));
		}
		InternetDomainName internetDomainName = InternetDomainName.from(host);
		if (internetDomainName.hasPublicSuffix())
		{
			return new HostSpecifier(internetDomainName.toString());
		}
		string text = String.valueOf(host);
		string s;
		if (String.instancehelper_length(text) != 0)
		{
			s = String.instancehelper_concat("Domain name does not have a recognized public suffix: ", text);
		}
		else
		{
			string text2 = "Domain name does not have a recognized public suffix: ";
			text2 = text2;
			s = String.newhelper(text2);
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.text.ParseException" })]
	[LineNumberTable(new byte[] { 65, 124, 225, 69, 127, 13, 105 })]
	public static HostSpecifier from(string specifier)
	{
		//Discarded unreachable code: IL_0008
		IllegalArgumentException ex;
		try
		{
			return fromValid(specifier);
		}
		catch (IllegalArgumentException x)
		{
			ex = ByteCodeHelper.MapException<IllegalArgumentException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IllegalArgumentException cause = ex;
		string text = String.valueOf(specifier);
		string s;
		if (String.instancehelper_length(text) != 0)
		{
			s = String.instancehelper_concat("Invalid host specifier: ", text);
		}
		else
		{
			string text2 = "Invalid host specifier: ";
			text2 = text2;
			s = String.newhelper(text2);
		}
		ParseException ex2 = new ParseException(s, 0);
		Throwable.instancehelper_initCause(ex2, cause);
		throw Throwable.___003Cunmap_003E(ex2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 83, 103, 112, 97 })]
	public static bool isValid(string specifier)
	{
		//Discarded unreachable code: IL_000a
		try
		{
			fromValid(specifier);
			return true;
		}
		catch (IllegalArgumentException)
		{
		}
		_ = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 92, 100, 162, 104, 103, 180 })]
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
		if (other is HostSpecifier)
		{
			HostSpecifier hostSpecifier = (HostSpecifier)other;
			bool result = String.instancehelper_equals(canonicalForm, hostSpecifier.canonicalForm);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(156)]
	public override int hashCode()
	{
		int result = String.instancehelper_hashCode(canonicalForm);
		_ = null;
		return result;
	}

	public override string toString()
	{
		return canonicalForm;
	}
}
