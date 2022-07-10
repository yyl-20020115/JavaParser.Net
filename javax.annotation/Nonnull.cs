using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("javax.annotation.NonnullAttribute")]
[Documented(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Documented;"
})]
[TypeQualifier(new object[]
{
	(byte)64,
	"Ljavax/annotation/meta/TypeQualifier;"
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
public interface Nonnull : Annotation
{
	[Signature("Ljava/lang/Object;Ljavax/annotation/meta/TypeQualifierValidator<Ljavax/annotation/Nonnull;>;")]
	public class Checker : Object, TypeQualifierValidator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 169, 99, 102 })]
		public virtual When forConstantValue(Nonnull qualifierArgument, object value)
		{
			if (value == null)
			{
				return When.___003C_003ENEVER;
			}
			return When.___003C_003EALWAYS;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(24)]
		public Checker()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(24)]
		public virtual When forConstantValue(Annotation a, object obj)
		{
			When result = forConstantValue((Nonnull)a, obj);
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
