using System.Runtime.CompilerServices;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;

namespace com.google.common.reflect;

[ConstantPool(new object[]
{
	(byte)51,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class TypeVisitor : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Set<Ljava/lang/reflect/Type;>;")]
	private Set visited;

	[Signature("(Ljava/lang/reflect/TypeVariable<*>;)V")]
	internal virtual void visitTypeVariable(TypeVariable P_0)
	{
	}

	internal virtual void visitWildcardType(WildcardType P_0)
	{
	}

	internal virtual void visitParameterizedType(ParameterizedType P_0)
	{
	}

	[Signature("(Ljava/lang/Class<*>;)V")]
	internal virtual void visitClass(Class P_0)
	{
	}

	internal virtual void visitGenericArrayType(GenericArrayType P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 8, 136 })]
	internal TypeVisitor()
	{
		visited = Sets.newHashSet();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 51, 0,
		0
	})]
	[LineNumberTable(new byte[]
	{
		17, 114, 148, 133, 131, 104, 113, 104, 113, 104,
		113, 104, 110, 104, 142, 159, 38, 135, 100, 141,
		227, 61, 100, 239, 41, 233, 91
	})]
	public void visit(params Type[] P_0)
	{
		int num = P_0.Length;
		for (int i = 0; i < num; i++)
		{
			Type type = P_0[i];
			if (type == null || !visited.add(type))
			{
				continue;
			}
			int num2 = 0;
			try
			{
				if (type is TypeVariable)
				{
					visitTypeVariable((TypeVariable)type);
				}
				else if (type is WildcardType)
				{
					visitWildcardType((WildcardType)type);
				}
				else if (type is ParameterizedType)
				{
					visitParameterizedType((ParameterizedType)type);
				}
				else if (type is Class)
				{
					visitClass((Class)type);
				}
				else
				{
					if (!(type is GenericArrayType))
					{
						string text = String.valueOf(type);
						int num3 = 14 + String.instancehelper_length(String.valueOf(text));
						num3 = num3;
						string detailMessage = new StringBuilder(num3).append("Unknown type: ").append(text).toString();
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new AssertionError(detailMessage);
					}
					visitGenericArrayType((GenericArrayType)type);
				}
				num2 = 1;
			}
			catch
			{
				//try-fault
				if (num2 == 0)
				{
					visited.remove(type);
				}
				throw;
			}
			if (num2 == 0)
			{
				visited.remove(type);
			}
		}
	}
}
