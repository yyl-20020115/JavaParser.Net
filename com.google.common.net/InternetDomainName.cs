using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.errorprone.annotations;
using com.google.thirdparty.publicsuffix;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.net;

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
public sealed class InternetDomainName : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static CharMatcher DOTS_MATCHER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Splitter DOT_SPLITTER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Joiner DOT_JOINER;

	private const int NO_SUFFIX_FOUND = -1;

	private const int MAX_PARTS = 127;

	private const int MAX_LENGTH = 253;

	private const int MAX_DOMAIN_PART_LENGTH = 63;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string name;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<Ljava/lang/String;>;")]
	private ImmutableList m_parts;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int publicSuffixIndex;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int registrySuffixIndex;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static CharMatcher DASH_MATCHER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static CharMatcher DIGIT_MATCHER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static CharMatcher LETTER_MATCHER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static CharMatcher PART_CHAR_MATCHER;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(210)]
	public static InternetDomainName from(string domain)
	{
		InternetDomainName result = new InternetDomainName((string)Preconditions.checkNotNull(domain));
		_ = null;
		return result;
	}

	public virtual bool hasPublicSuffix()
	{
		return publicSuffixIndex != -1;
	}

	public override string toString()
	{
		return name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/List<Ljava/lang/String;>;)Z")]
	[LineNumberTable(new byte[]
	{
		160, 106, 201, 116, 162, 102, 109, 105, 226, 61,
		230, 71
	})]
	private static bool validateSyntax(List P_0)
	{
		int num = P_0.size() - 1;
		if (!validatePart((string)P_0.get(num), true))
		{
			return false;
		}
		for (int i = 0; i < num; i++)
		{
			string text = (string)P_0.get(i);
			if (!validatePart(text, false))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Optional<Lcom/google/thirdparty/publicsuffix/PublicSuffixType;>;)I")]
	[LineNumberTable(new byte[]
	{
		115, 140, 105, 152, 103, 47, 135, 226, 70, 109,
		164, 105, 226, 48, 233, 84
	})]
	private int findSuffixOfType(com.google.common.@base.Optional P_0)
	{
		int num = this.m_parts.size();
		for (int i = 0; i < num; i++)
		{
			string text = DOT_JOINER.join(this.m_parts.subList(i, num));
			if (matchesType(P_0, com.google.common.@base.Optional.fromNullable((PublicSuffixType)PublicSuffixPatterns.___003C_003EEXACT.get(text))))
			{
				return i;
			}
			if (PublicSuffixPatterns.___003C_003EEXCLUDED.containsKey(text))
			{
				return i + 1;
			}
			if (matchesWildcardSuffixType(P_0, text))
			{
				return i;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Optional<Lcom/google/thirdparty/publicsuffix/PublicSuffixType;>;Lcom/google/common/base/Optional<Lcom/google/thirdparty/publicsuffix/PublicSuffixType;>;)Z")]
	[LineNumberTable(612)]
	private static bool matchesType(com.google.common.@base.Optional P_0, com.google.common.@base.Optional P_1)
	{
		bool result = ((!P_0.isPresent()) ? P_1.isPresent() : P_0.equals(P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Optional<Lcom/google/thirdparty/publicsuffix/PublicSuffixType;>;Ljava/lang/String;)Z")]
	[LineNumberTable(new byte[] { 161, 230, 127, 3, 145, 52, 43 })]
	private static bool matchesWildcardSuffixType(com.google.common.@base.Optional P_0, string P_1)
	{
		Splitter splitter = DOT_SPLITTER.limit(2);
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = P_1);
		List list = splitter.splitToList(sequence);
		return (list.size() == 2 && matchesType(P_0, com.google.common.@base.Optional.fromNullable((PublicSuffixType)PublicSuffixPatterns.___003C_003EUNDER.get(list.get(1))))) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		82, 232, 70, 159, 7, 109, 177, 123, 135, 127,
		7, 125, 150, 113, 118
	})]
	internal InternetDomainName(string P_0)
	{
		CharMatcher dOTS_MATCHER = DOTS_MATCHER;
		string __003Cref_003E = P_0;
		char replacement = '.';
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = __003Cref_003E);
		P_0 = Ascii.toLowerCase(dOTS_MATCHER.replaceFrom(sequence, replacement));
		if (String.instancehelper_endsWith(P_0, "."))
		{
			P_0 = String.instancehelper_substring(P_0, 0, String.instancehelper_length(P_0) - 1);
		}
		Preconditions.checkArgument(String.instancehelper_length(P_0) <= 253, "Domain name too long: '%s':", P_0);
		name = P_0;
		Splitter dOT_SPLITTER = DOT_SPLITTER;
		obj = (sequence.___003Cref_003E = P_0);
		this.m_parts = ImmutableList.copyOf(dOT_SPLITTER.split(sequence));
		Preconditions.checkArgument(this.m_parts.size() <= 127, "Domain has too many parts: '%s'", P_0);
		Preconditions.checkArgument(validateSyntax(this.m_parts), "Not a valid domain name: '%s'", P_0);
		publicSuffixIndex = findSuffixOfType(com.google.common.@base.Optional.absent());
		registrySuffixIndex = findSuffixOfType(com.google.common.@base.Optional.of(PublicSuffixType.___003C_003EREGISTRY));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 77, 98, 115, 226, 77, 156, 125, 226, 69,
		122, 115, 226, 74, 118, 162
	})]
	private static bool validatePart(string P_0, bool P_1)
	{
		if (String.instancehelper_length(P_0) < 1 || String.instancehelper_length(P_0) > 63)
		{
			return false;
		}
		CharMatcher charMatcher = CharMatcher.ascii();
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = P_0);
		string __003Cref_003E = charMatcher.retainFrom(sequence);
		CharMatcher pART_CHAR_MATCHER = PART_CHAR_MATCHER;
		obj = (sequence.___003Cref_003E = __003Cref_003E);
		if (!pART_CHAR_MATCHER.matchesAllOf(sequence))
		{
			return false;
		}
		if (DASH_MATCHER.matches(String.instancehelper_charAt(P_0, 0)) || DASH_MATCHER.matches(String.instancehelper_charAt(P_0, String.instancehelper_length(P_0) - 1)))
		{
			return false;
		}
		if (P_1 && DIGIT_MATCHER.matches(String.instancehelper_charAt(P_0, 0)))
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(546)]
	private InternetDomainName ancestor(int P_0)
	{
		InternetDomainName result = from(DOT_JOINER.join(this.m_parts.subList(P_0, this.m_parts.size())));
		_ = null;
		return result;
	}

	public virtual bool isTopPrivateDomain()
	{
		return publicSuffixIndex == 1;
	}

	public virtual bool isUnderPublicSuffix()
	{
		return publicSuffixIndex > 0;
	}

	public virtual bool hasRegistrySuffix()
	{
		return registrySuffixIndex != -1;
	}

	public virtual bool isTopDomainUnderRegistrySuffix()
	{
		return registrySuffixIndex == 1;
	}

	public virtual bool isUnderRegistrySuffix()
	{
		return registrySuffixIndex > 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(523)]
	public virtual bool hasParent()
	{
		return this.m_parts.size() > 1;
	}

	[Signature("()Lcom/google/common/collect/ImmutableList<Ljava/lang/String;>;")]
	public virtual ImmutableList parts()
	{
		return this.m_parts;
	}

	public virtual bool isPublicSuffix()
	{
		return (publicSuffixIndex == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(359)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual InternetDomainName publicSuffix()
	{
		return (!hasPublicSuffix()) ? null : ancestor(publicSuffixIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 41, 104, 130, 118 })]
	public virtual InternetDomainName topPrivateDomain()
	{
		if (isTopPrivateDomain())
		{
			return this;
		}
		Preconditions.checkState(isUnderPublicSuffix(), "Not under a public suffix: %s", name);
		InternetDomainName result = ancestor(publicSuffixIndex - 1);
		_ = null;
		return result;
	}

	public virtual bool isRegistrySuffix()
	{
		return (registrySuffixIndex == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(468)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual InternetDomainName registrySuffix()
	{
		return (!hasRegistrySuffix()) ? null : ancestor(registrySuffixIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 144, 104, 130, 118 })]
	public virtual InternetDomainName topDomainUnderRegistrySuffix()
	{
		if (isTopDomainUnderRegistrySuffix())
		{
			return this;
		}
		Preconditions.checkState(isUnderRegistrySuffix(), "Not under a registry suffix: %s", name);
		InternetDomainName result = ancestor(registrySuffixIndex - 1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 164, 118 })]
	public virtual InternetDomainName parent()
	{
		Preconditions.checkState(hasParent(), "Domain '%s' has no parent", name);
		InternetDomainName result = ancestor(1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(559)]
	public virtual InternetDomainName child(string leftParts)
	{
		string text = (string)Preconditions.checkNotNull(leftParts);
		string text2 = name;
		int num = 1 + String.instancehelper_length(String.valueOf(text)) + String.instancehelper_length(String.valueOf(text2));
		num = num;
		InternetDomainName result = from(new StringBuilder(num).append(text).append(".").append(text2)
			.toString());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 217, 103, 112, 97 })]
	public static bool isValid(string name)
	{
		//Discarded unreachable code: IL_000a
		try
		{
			from(name);
			return true;
		}
		catch (IllegalArgumentException)
		{
		}
		_ = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 2, 100, 162, 104, 103, 180 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		if (@object == this)
		{
			return true;
		}
		if (@object is InternetDomainName)
		{
			InternetDomainName internetDomainName = (InternetDomainName)@object;
			bool result = String.instancehelper_equals(name, internetDomainName.name);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(642)]
	public override int hashCode()
	{
		int result = String.instancehelper_hashCode(name);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		29, 127, 0, 108, 236, 160, 157, 159, 0, 142,
		100, 152, 106, 52
	})]
	static InternetDomainName()
	{
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = ".。．｡");
		DOTS_MATCHER = CharMatcher.anyOf(sequence);
		DOT_SPLITTER = Splitter.on('.');
		DOT_JOINER = Joiner.on('.');
		obj = (sequence.___003Cref_003E = "-_");
		DASH_MATCHER = CharMatcher.anyOf(sequence);
		DIGIT_MATCHER = CharMatcher.inRange('0', '9');
		LETTER_MATCHER = CharMatcher.inRange('a', 'z').or(CharMatcher.inRange('A', 'Z'));
		PART_CHAR_MATCHER = DIGIT_MATCHER.or(LETTER_MATCHER).or(DASH_MATCHER);
	}
}
