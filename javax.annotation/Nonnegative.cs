using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("javax.annotation.NonnegativeAttribute")]
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
		"Ljava/lang/Number, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
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
public interface Nonnegative : Annotation
{
	[Signature("Ljava/lang/Object;Ljavax/annotation/meta/TypeQualifierValidator<Ljavax/annotation/Nonnegative;>;")]
	public class Checker : Object, TypeQualifierValidator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			159, 167, 104, 134, 103, 104, 109, 104, 112, 104,
			144, 138, 99, 134
		})]
		public virtual When forConstantValue(Nonnegative annotation, object v)
		{
			if (!(v is Number))
			{
				return When.___003C_003ENEVER;
			}
			Number number = (Number)v;
			if ((number is Long) ? (number.longValue() < 0) : ((number is Double) ? (number.doubleValue() < 0.0) : ((!(number is Float)) ? (number.intValue() < 0) : (number.floatValue() < 0f))))
			{
				return When.___003C_003ENEVER;
			}
			return When.___003C_003EALWAYS;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(22)]
		public Checker()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(22)]
		public virtual When forConstantValue(Annotation a, object obj)
		{
			When result = forConstantValue((Nonnegative)a, obj);
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
