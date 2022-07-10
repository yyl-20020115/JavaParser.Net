using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using java.util.regex;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("javax.annotation.RegExAttribute")]
[Documented(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Documented;"
})]
[Syntax(new object[]
{
	(byte)64,
	"Ljavax/annotation/Syntax;",
	"value",
	"RegEx"
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
public interface RegEx : Annotation
{
	[Signature("Ljava/lang/Object;Ljavax/annotation/meta/TypeQualifierValidator<Ljavax/annotation/RegEx;>;")]
	public class Checker : Object, TypeQualifierValidator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 171, 104, 166, 183, 2, 97, 134 })]
		public virtual When forConstantValue(RegEx annotation, object value)
		{
			if (!(value is string))
			{
				return When.___003C_003ENEVER;
			}
			try
			{
				Pattern.compile((string)value);
			}
			catch (PatternSyntaxException)
			{
				goto IL_0022;
			}
			return When.___003C_003EALWAYS;
			IL_0022:
			_ = null;
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
			When result = forConstantValue((RegEx)a, obj);
			_ = null;
			return result;
		}
	}

	[AnnotationDefault(new object[]
	{
		(byte)101,
		"Ljavax/annotation/meta/When;",
		"ALWAYS"
	})]
	virtual When when();
}
