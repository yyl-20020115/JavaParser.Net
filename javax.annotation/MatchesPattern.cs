using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using java.util.regex;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("javax.annotation.MatchesPatternAttribute")]
[Documented(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Documented;"
})]
[TypeQualifier(new object[]
{
	(byte)64,
	"Ljavax/annotation/meta/TypeQualifier;",
	"applicableTo",
	new object[]
	{
		(byte)99,
		"Ljava/lang/String, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
	}
})]
[Retention(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Retention;",
	"value",
	new object[]
	{
		(byte)101,
		"Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
		"RUNTIME"
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface MatchesPattern : Annotation
{
	[Signature("Ljava/lang/Object;Ljavax/annotation/meta/TypeQualifierValidator<Ljavax/annotation/MatchesPattern;>;")]
	public class Checker : Object, TypeQualifierValidator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 170, 114, 127, 4, 102 })]
		public virtual When forConstantValue(MatchesPattern annotation, object value)
		{
			Pattern pattern = Pattern.compile(annotation.value(), annotation.flags());
			CharSequence input = default(CharSequence);
			object obj = (input.___003Cref_003E = (string)value);
			if (pattern.matcher(input).matches())
			{
				return When.___003C_003EALWAYS;
			}
			return When.___003C_003ENEVER;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(26)]
		public Checker()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(26)]
		public virtual When forConstantValue(Annotation a, object obj)
		{
			When result = forConstantValue((MatchesPattern)a, obj);
			_ = null;
			return result;
		}
	}

	[RegEx(new object[]
	{
		(byte)64,
		"Ljavax/annotation/RegEx;"
	})]
	virtual string value();

	[AnnotationDefault(0)]
	virtual int flags();
}
