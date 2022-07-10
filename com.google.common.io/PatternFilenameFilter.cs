using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util.regex;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class PatternFilenameFilter : Object, FilenameFilter
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Pattern pattern;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 4, 104, 113 })]
	public PatternFilenameFilter(Pattern pattern)
	{
		this.pattern = (Pattern)Preconditions.checkNotNull(pattern);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 110 })]
	public PatternFilenameFilter(string patternStr)
		: this(Pattern.compile(patternStr))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	public virtual bool accept(File dir, string fileName)
	{
		Pattern obj = pattern;
		CharSequence input = default(CharSequence);
		object obj2 = (input.___003Cref_003E = fileName);
		bool result = obj.matcher(input).matches();
		_ = null;
		return result;
	}
}
