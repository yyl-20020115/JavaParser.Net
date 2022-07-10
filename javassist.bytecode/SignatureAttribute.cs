using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.function;

namespace javassist.bytecode;

public class SignatureAttribute : AttributeInfo
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[IKVM.Attributes.EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	public class ArrayType : ObjectType
	{
		internal int dim;

		internal Type componentType;

		public virtual Type getComponentType()
		{
			return componentType;
		}

		public virtual int getDimension()
		{
			return dim;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 81, 104, 103, 103 })]
		public ArrayType(int d, Type comp)
		{
			dim = d;
			componentType = comp;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 103, 113, 107, 44, 166 })]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder(java.lang.Object.instancehelper_toString(componentType));
			for (int i = 0; i < dim; i++)
			{
				stringBuilder.append("[]");
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 112, 107, 41, 166, 110 })]
		internal override void encode(StringBuilder P_0)
		{
			for (int i = 0; i < dim; i++)
			{
				P_0.append('[');
			}
			componentType.encode(P_0);
		}
	}

	public class BaseType : Type
	{
		internal char descriptor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(760)]
		public override string toString()
		{
			string result = Descriptor.toClassName(Character.toString(descriptor));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(729)]
		internal BaseType(char P_0)
		{
			descriptor = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 111, 116 })]
		public BaseType(string typeName)
			: this(java.lang.String.instancehelper_charAt(Descriptor.of(typeName), 0))
		{
		}

		public virtual char getDescriptor()
		{
			return descriptor;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(752)]
		public virtual CtClass getCtlass()
		{
			CtClass result = Descriptor.toPrimitiveClass(descriptor);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 139, 109 })]
		internal override void encode(StringBuilder P_0)
		{
			P_0.append(descriptor);
		}
	}

	public class ClassSignature : java.lang.Object
	{
		internal TypeParameter[] @params;

		internal ClassType superClass;

		internal ClassType[] interfaces;

		public virtual ClassType getSuperClass()
		{
			return superClass;
		}

		public virtual ClassType[] getInterfaces()
		{
			return interfaces;
		}

		public virtual TypeParameter[] getParameters()
		{
			return @params;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 233, 134, 108, 119, 106, 108, 172 })]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			TypeParameter.toString(stringBuilder, @params);
			stringBuilder.append(" extends ").append(superClass);
			if ((nint)interfaces.LongLength > 0)
			{
				stringBuilder.append(" implements ");
				Type.toString(stringBuilder, interfaces);
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 192, 104, 114, 113, 114 })]
		public ClassSignature(TypeParameter[] @params, ClassType superClass, ClassType[] interfaces)
		{
			this.@params = ((@params != null) ? @params : new TypeParameter[0]);
			this.superClass = ((superClass != null) ? superClass : ClassType.OBJECT);
			this.interfaces = ((interfaces != null) ? interfaces : new ClassType[0]);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 204, 107 })]
		public ClassSignature(TypeParameter[] p)
			: this(p, null, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 249, 102, 106, 105, 108, 46, 166, 169, 108,
			108, 46, 166
		})]
		public virtual string encode()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if ((nint)@params.LongLength > 0)
			{
				stringBuilder.append('<');
				for (int i = 0; i < (nint)@params.LongLength; i++)
				{
					@params[i].encode(stringBuilder);
				}
				stringBuilder.append('>');
			}
			superClass.encode(stringBuilder);
			for (int i = 0; i < (nint)interfaces.LongLength; i++)
			{
				interfaces[i].encode(stringBuilder);
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}
	}

	public class ClassType : ObjectType
	{
		internal string name;

		internal TypeArgument[] arguments;

		public static ClassType OBJECT;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		public virtual TypeArgument[] getTypeArguments()
		{
			return arguments;
		}

		public virtual ClassType getDeclaringClass()
		{
			return null;
		}

		public virtual string getName()
		{
			return name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 167, 100, 108 })]
		internal static ClassType make(string P_0, int P_1, int P_2, TypeArgument[] P_3, ClassType P_4)
		{
			if (P_4 == null)
			{
				ClassType result = new ClassType(P_0, P_1, P_2, P_3);
				_ = null;
				return result;
			}
			NestedClassType result2 = new NestedClassType(P_0, P_1, P_2, P_3, P_4);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 18, 105, 103, 105 })]
		internal override void encode(StringBuilder P_0)
		{
			P_0.append('L');
			encode2(P_0);
			P_0.append(';');
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 172, 104, 119, 104 })]
		internal ClassType(string P_0, int P_1, int P_2, TypeArgument[] P_3)
		{
			name = java.lang.String.instancehelper_replace(java.lang.String.instancehelper_substring(P_0, P_1, P_2), '/', '.');
			arguments = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 189, 104, 103, 103 })]
		public ClassType(string className, TypeArgument[] args)
		{
			name = className;
			arguments = args;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 231, 102, 103, 99, 148 })]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			ClassType declaringClass = getDeclaringClass();
			if (declaringClass != null)
			{
				stringBuilder.append(declaringClass.toString()).append('.');
			}
			string result = toString2(stringBuilder);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 240, 109, 104, 105, 104, 102, 100, 140, 244,
			60, 230, 71, 169
		})]
		private string toString2(StringBuilder P_0)
		{
			P_0.append(name);
			if (arguments != null)
			{
				P_0.append('<');
				int num = arguments.Length;
				for (int i = 0; i < num; i++)
				{
					if (i > 0)
					{
						P_0.append(", ");
					}
					P_0.append(arguments[i].toString());
				}
				P_0.append('>');
			}
			string result = P_0.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 8, 102, 103, 99, 148 })]
		public override string jvmTypeName()
		{
			StringBuilder stringBuilder = new StringBuilder();
			ClassType declaringClass = getDeclaringClass();
			if (declaringClass != null)
			{
				stringBuilder.append(declaringClass.jvmTypeName()).append('$');
			}
			string result = toString2(stringBuilder);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 24, 103, 99, 103, 169, 118, 104, 110 })]
		internal virtual void encode2(StringBuilder P_0)
		{
			ClassType declaringClass = getDeclaringClass();
			if (declaringClass != null)
			{
				declaringClass.encode2(P_0);
				P_0.append('$');
			}
			P_0.append(java.lang.String.instancehelper_replace(name, '.', '/'));
			if (arguments != null)
			{
				TypeArgument.encode(P_0, arguments);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 201, 106 })]
		public ClassType(string className)
			: this(className, null)
		{
		}

		[LineNumberTable(806)]
		static ClassType()
		{
			OBJECT = new ClassType("java.lang.Object", null);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Cursor : java.lang.Object
	{
		internal int position;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(279)]
		internal Cursor(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 160, 169, 110, 100, 108, 105 })]
		internal virtual int indexOf(string P_0, int P_1)
		{
			int num = java.lang.String.instancehelper_indexOf(P_0, P_1, position);
			if (num < 0)
			{
				throw Throwable.___003Cunmap_003E(access_0024000(P_0));
			}
			position = num + 1;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 165, 104 })]
		private Cursor()
		{
			position = 0;
		}
	}

	public class MethodSignature : java.lang.Object
	{
		internal TypeParameter[] typeParams;

		internal Type[] @params;

		internal Type retType;

		internal ObjectType[] exceptions;

		public virtual Type getReturnType()
		{
			return retType;
		}

		public virtual Type[] getParameterTypes()
		{
			return @params;
		}

		public virtual TypeParameter[] getTypeParameters()
		{
			return typeParams;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 67, 134, 108, 108, 108, 108, 109, 106, 108,
			172
		})]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			TypeParameter.toString(stringBuilder, typeParams);
			stringBuilder.append(" (");
			Type.toString(stringBuilder, @params);
			stringBuilder.append(") ");
			stringBuilder.append(retType);
			if ((nint)exceptions.LongLength > 0)
			{
				stringBuilder.append(" throws ");
				Type.toString(stringBuilder, exceptions);
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 28, 104, 114, 114, 118, 116 })]
		public MethodSignature(TypeParameter[] tp, Type[] @params, Type ret, ObjectType[] ex)
		{
			typeParams = ((tp != null) ? tp : new TypeParameter[0]);
			this.@params = ((@params != null) ? @params : new Type[0]);
			retType = ((ret != null) ? ret : new BaseType("void"));
			exceptions = ((ex != null) ? ex : new ObjectType[0]);
		}

		public virtual ObjectType[] getExceptionTypes()
		{
			return exceptions;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 86, 102, 106, 105, 108, 46, 166, 169, 105,
			108, 46, 166, 105, 108, 106, 108, 105, 14, 230,
			69
		})]
		public virtual string encode()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if ((nint)typeParams.LongLength > 0)
			{
				stringBuilder.append('<');
				for (int i = 0; i < (nint)typeParams.LongLength; i++)
				{
					typeParams[i].encode(stringBuilder);
				}
				stringBuilder.append('>');
			}
			stringBuilder.append('(');
			for (int i = 0; i < (nint)@params.LongLength; i++)
			{
				@params[i].encode(stringBuilder);
			}
			stringBuilder.append(')');
			retType.encode(stringBuilder);
			if ((nint)exceptions.LongLength > 0)
			{
				for (int i = 0; i < (nint)exceptions.LongLength; i++)
				{
					stringBuilder.append('^');
					exceptions[i].encode(stringBuilder);
				}
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}
	}

	public class NestedClassType : ClassType
	{
		internal ClassType parent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 43, 109, 104 })]
		internal NestedClassType(string P_0, int P_1, int P_2, TypeArgument[] P_3, ClassType P_4)
			: base(P_0, P_1, P_2, P_3)
		{
			parent = P_4;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 56, 106, 103 })]
		public NestedClassType(ClassType parent, string className, TypeArgument[] args)
			: base(className, args)
		{
			this.parent = parent;
		}

		public override ClassType getDeclaringClass()
		{
			return parent;
		}

		[HideFromJava]
		static NestedClassType()
		{
			ClassType.___003Cclinit_003E();
		}
	}

	public abstract class ObjectType : Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(773)]
		public ObjectType()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 152, 102, 103 })]
		public virtual string encode()
		{
			StringBuilder stringBuilder = new StringBuilder();
			encode(stringBuilder);
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}
	}

	public abstract class Type : java.lang.Object
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(721)]
		public virtual string jvmTypeName()
		{
			string result = java.lang.Object.instancehelper_toString(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(705)]
		public Type()
		{
		}

		[Modifiers(Modifiers.Abstract)]
		internal virtual void encode(StringBuilder P_0)
		{
			throw new AbstractMethodError("javassist.bytecode.SignatureAttribute$Type.encode(Ljava.lang.StringBuilder;)V");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 82, 103, 100, 140, 234, 60, 230, 70 })]
		internal static void toString(StringBuilder P_0, Type[] P_1)
		{
			for (int i = 0; i < (nint)P_1.LongLength; i++)
			{
				if (i > 0)
				{
					P_0.append(", ");
				}
				P_0.append(P_1[i]);
			}
		}
	}

	public class TypeArgument : java.lang.Object
	{
		internal ObjectType arg;

		internal char wildcard;

		public virtual bool isWildcard()
		{
			return wildcard != ' ';
		}

		public virtual ObjectType getType()
		{
			return arg;
		}

		public virtual char getKind()
		{
			return wildcard;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 247, 66, 104, 103, 103 })]
		internal TypeArgument(ObjectType P_0, char P_1)
		{
			arg = P_0;
			wildcard = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 49, 106, 134, 108, 106, 98, 106, 157 })]
		public override string toString()
		{
			if (wildcard == '*')
			{
				return "?";
			}
			string text = java.lang.Object.instancehelper_toString(arg);
			if (wildcard == ' ')
			{
				return text;
			}
			if (wildcard == '+')
			{
				string result = new StringBuilder().append("? extends ").append(text).toString();
				_ = null;
				return result;
			}
			string result2 = new StringBuilder().append("? super ").append(text).toString();
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 62, 105, 103, 100, 104, 141, 104, 236, 58,
			230, 73, 105
		})]
		internal static void encode(StringBuilder P_0, TypeArgument[] P_1)
		{
			P_0.append('<');
			for (int i = 0; i < (nint)P_1.LongLength; i++)
			{
				TypeArgument typeArgument = P_1[i];
				if (typeArgument.isWildcard())
				{
					P_0.append(typeArgument.wildcard);
				}
				if (typeArgument.getType() != null)
				{
					typeArgument.getType().encode(P_0);
				}
			}
			P_0.append('>');
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 247, 107 })]
		public TypeArgument(ObjectType t)
			: this(t, ' ')
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 254, 107 })]
		public TypeArgument()
			: this(null, '*')
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(634)]
		public static TypeArgument subclassOf(ObjectType t)
		{
			TypeArgument result = new TypeArgument(t, '+');
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(644)]
		public static TypeArgument superOf(ObjectType t)
		{
			TypeArgument result = new TypeArgument(t, '-');
			_ = null;
			return result;
		}
	}

	public class TypeParameter : java.lang.Object
	{
		internal string name;

		internal ObjectType superClass;

		internal ObjectType[] superInterfaces;

		public virtual string getName()
		{
			return name;
		}

		public virtual ObjectType getClassBound()
		{
			return superClass;
		}

		public virtual ObjectType[] getInterfaceBound()
		{
			return superInterfaces;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 121, 104, 110, 104, 104 })]
		internal TypeParameter(string P_0, int P_1, int P_2, ObjectType P_3, ObjectType[] P_4)
		{
			name = java.lang.String.instancehelper_substring(P_0, P_1, P_2);
			superClass = P_3;
			superInterfaces = P_4;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 198, 105, 103, 100, 140, 234, 60, 230, 71,
			105
		})]
		internal static void toString(StringBuilder P_0, TypeParameter[] P_1)
		{
			P_0.append('<');
			for (int i = 0; i < (nint)P_1.LongLength; i++)
			{
				if (i > 0)
				{
					P_0.append(", ");
				}
				P_0.append(P_1[i]);
			}
			P_0.append('>');
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 210, 109, 104, 142, 105, 172, 108, 105, 14,
			198
		})]
		internal virtual void encode(StringBuilder P_0)
		{
			P_0.append(name);
			if (superClass == null)
			{
				P_0.append(":Ljava/lang/Object;");
			}
			else
			{
				P_0.append(':');
				superClass.encode(P_0);
			}
			for (int i = 0; i < (nint)superInterfaces.LongLength; i++)
			{
				P_0.append(':');
				superInterfaces[i].encode(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 135, 104, 103, 103, 99, 142, 103 })]
		public TypeParameter(string name, ObjectType superClass, ObjectType[] superInterfaces)
		{
			this.name = name;
			this.superClass = superClass;
			if (superInterfaces == null)
			{
				this.superInterfaces = new ObjectType[0];
			}
			else
			{
				this.superInterfaces = superInterfaces;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 151, 107 })]
		public TypeParameter(string name)
			: this(name, null, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 178, 108, 104, 156, 104, 100, 102, 108, 142,
			140, 244, 58, 230, 74
		})]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder(getName());
			if (superClass != null)
			{
				stringBuilder.append(" extends ").append(java.lang.Object.instancehelper_toString(superClass));
			}
			int num = superInterfaces.Length;
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					if (i > 0 || superClass != null)
					{
						stringBuilder.append(" & ");
					}
					else
					{
						stringBuilder.append(" extends ");
					}
					stringBuilder.append(java.lang.Object.instancehelper_toString(superInterfaces[i]));
				}
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}
	}

	public class TypeVariable : ObjectType
	{
		internal string name;

		public virtual string getName()
		{
			return name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 125, 104, 110 })]
		internal TypeVariable(string P_0, int P_1, int P_2)
		{
			name = java.lang.String.instancehelper_substring(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 134, 104, 103 })]
		public TypeVariable(string name)
		{
			this.name = name;
		}

		public override string toString()
		{
			return name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 155, 123 })]
		internal override void encode(StringBuilder P_0)
		{
			P_0.append('T').append(name).append(';');
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : IntPredicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(int P_0)
		{
			bool result = lambda_0024makeNewClassName_00240(P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public IntPredicate and(IntPredicate P_0)
		{
			return IntPredicate._003Cdefault_003Eand(this, P_0);
		}

		[SpecialName]
		public IntPredicate negate()
		{
			return IntPredicate._003Cdefault_003Enegate(this);
		}

		[SpecialName]
		public IntPredicate or(IntPredicate P_0)
		{
			return IntPredicate._003Cdefault_003Eor(this, P_0);
		}
	}

	public const string tag = "Signature";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 163, 192, 159, 0, 97 })]
	public static MethodSignature toMethodSignature(string sig)
	{
		//Discarded unreachable code: IL_0008
		try
		{
			return parseMethodSig(sig);
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<IndexOutOfBoundsException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
		throw Throwable.___003Cunmap_003E(error(sig));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 163, 228, 159, 6, 97 })]
	public static Type toTypeSignature(string sig)
	{
		//Discarded unreachable code: IL_000e
		try
		{
			return parseType(sig, new Cursor(null));
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<IndexOutOfBoundsException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
		throw Throwable.___003Cunmap_003E(error(sig));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 163, 172, 159, 0, 97 })]
	public static ClassSignature toClassSignature(string sig)
	{
		//Discarded unreachable code: IL_0008
		try
		{
			return parseSig(sig);
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<IndexOutOfBoundsException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
		throw Throwable.___003Cunmap_003E(error(sig));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(67)]
	public virtual string getSignature()
	{
		string utf8Info = getConstPool().getUtf8Info(ByteArray.readU16bit(get(), 0));
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 1, 110, 104, 103, 103, 101, 105 })]
	public SignatureAttribute(ConstPool cp, string signature)
		: base(cp, "Signature")
	{
		int num = cp.addUtf8Info(signature);
		set(new byte[2]
		{
			(byte)(sbyte)((uint)num >> 8),
			(byte)(sbyte)num
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 183, 107 })]
	internal SignatureAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 163, 211, 159, 7, 97 })]
	public static ObjectType toFieldSignature(string sig)
	{
		//Discarded unreachable code: IL_000f
		try
		{
			return parseObjectType(sig, new Cursor(null), false);
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<IndexOutOfBoundsException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
		throw Throwable.___003Cunmap_003E(error(sig));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 58, 102, 105 })]
	internal static string renameClass(string P_0, string P_1, string P_2)
	{
		HashMap hashMap = new HashMap();
		((Map)hashMap).put((object)P_1, (object)P_2);
		string result = renameClass(P_0, hashMap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljava/lang/String;")]
	[LineNumberTable(new byte[]
	{
		64, 107, 130, 102, 98, 130, 106, 100, 133, 103,
		103, 110, 100, 133, 127, 28, 111, 100, 148, 164,
		144, 98, 133, 99, 98, 103, 100, 143
	})]
	internal static string renameClass(string P_0, Map P_1)
	{
		if (P_1 == null || P_1.isEmpty())
		{
			return P_0;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int num2 = 0;
		CharSequence delimiter = default(CharSequence);
		int num3;
		while (true)
		{
			num3 = java.lang.String.instancehelper_indexOf(P_0, 76, num2);
			if (num3 < 0)
			{
				break;
			}
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			num2 = parseClassName(arrayList, arrayList2, P_0, num3) + 1;
			if (num2 < 0)
			{
				break;
			}
			object[] array = arrayList.toArray(new StringBuilder[0]);
			CharSequence.CastArray(array, 1);
			object[] elements = array;
			object obj = (delimiter.___003Cref_003E = "$");
			string text = java.lang.String.join(delimiter, elements);
			string text2 = (string)P_1.get(text);
			if (text2 != null)
			{
				if (makeNewClassName(P_0, P_1, text, text2, stringBuilder, num, num3, arrayList, arrayList2))
				{
					num = num2;
				}
			}
			else if (replaceTypeArguments(P_0, P_1, stringBuilder, num, num3, arrayList, arrayList2))
			{
				num = num2;
			}
		}
		if (num == 0)
		{
			return P_0;
		}
		num3 = java.lang.String.instancehelper_length(P_0);
		if (num < num3)
		{
			stringBuilder.append(java.lang.String.instancehelper_substring(P_0, num, num3));
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1285)]
	private static BadBytecode error(string P_0)
	{
		BadBytecode result = new BadBytecode(new StringBuilder().append("bad signature: ").append(P_0).toString());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 28, 109, 111 })]
	public virtual void setSignature(string sig)
	{
		int value = getConstPool().addUtf8Info(sig);
		ByteArray.write16bit(value, info, 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/ArrayList<Ljava/lang/StringBuilder;>;Ljava/util/ArrayList<Ljava/lang/StringBuilder;>;Ljava/lang/String;I)I")]
	[LineNumberTable(new byte[]
	{
		107,
		102,
		102,
		162,
		116,
		101,
		104,
		99,
		101,
		108,
		104,
		101,
		104,
		101,
		136,
		101,
		101,
		104,
		104,
		102,
		171,
		byte.MaxValue,
		1,
		69,
		2,
		97,
		163,
		104,
		104
	})]
	private static int parseClassName(ArrayList P_0, ArrayList P_1, string P_2, int P_3)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		int num = P_3;
		try
		{
			while (true)
			{
				num++;
				int num2;
				if ((num2 = java.lang.String.instancehelper_charAt(P_2, num)) == 59)
				{
					break;
				}
				switch (num2)
				{
				case 60:
				{
					stringBuilder2.append((char)num2);
					int num3 = 1;
					while (num3 > 0)
					{
						num++;
						num2 = java.lang.String.instancehelper_charAt(P_2, num);
						stringBuilder2.append((char)num2);
						switch (num2)
						{
						case 60:
							num3++;
							break;
						case 62:
							num3 += -1;
							break;
						}
					}
					break;
				}
				case 46:
					P_0.add(stringBuilder);
					P_1.add(stringBuilder2);
					stringBuilder = new StringBuilder();
					stringBuilder2 = new StringBuilder();
					break;
				default:
					stringBuilder.append((char)num2);
					break;
				}
			}
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<IndexOutOfBoundsException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_00ad;
		}
		P_0.add(stringBuilder);
		P_1.add(stringBuilder2);
		return num;
		IL_00ad:
		_ = null;
		return -2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;Ljava/lang/String;Ljava/lang/String;Ljava/lang/StringBuilder;IILjava/util/ArrayList<Ljava/lang/StringBuilder;>;Ljava/util/ArrayList<Ljava/lang/StringBuilder;>;)Z")]
	[LineNumberTable(new byte[]
	{
		160, 87, 108, 108, 105, 109, 115, 127, 13, 127,
		26, 101, 230, 60, 235, 71, 114, 106, 106, 100,
		138, 139, 111, 106, 159, 31, 137, 234, 52, 233,
		78, 106, 162
	})]
	private static bool makeNewClassName(string P_0, Map P_1, string P_2, string P_3, StringBuilder P_4, int P_5, int P_6, ArrayList P_7, ArrayList P_8)
	{
		string[] array = java.lang.String.instancehelper_split(P_2, "\\$");
		string[] array2 = java.lang.String.instancehelper_split(P_3, "\\$");
		if ((nint)array.LongLength == (nint)array2.LongLength)
		{
			string[] array3 = new string[P_7.size()];
			int num = 0;
			CharSequence delimiter = default(CharSequence);
			for (int i = 0; i < P_7.size(); i++)
			{
				int num2 = (int)((StringBuilder)P_7.get(i)).chars().filter(new ___003C_003EAnon0()).count() + 1;
				object[] array4 = Arrays.copyOfRange(array2, num, num + num2);
				CharSequence.CastArray(array4, 1);
				object[] elements = array4;
				object obj = (delimiter.___003Cref_003E = "$");
				string text = java.lang.String.join(delimiter, elements);
				num += num2;
				array3[i] = text;
			}
			P_4.append(java.lang.String.instancehelper_substring(P_0, P_5, P_6));
			P_4.append('L');
			for (num = 0; num < (nint)array3.LongLength; num++)
			{
				if (num > 0)
				{
					P_4.append('.');
				}
				P_4.append(array3[num]);
				StringBuilder stringBuilder = (StringBuilder)P_8.get(num);
				string str = ((stringBuilder.length() <= 0) ? stringBuilder.toString() : new StringBuilder().append("<").append(renameClass(stringBuilder.substring(1, stringBuilder.length() - 1), P_1)).append(">")
					.toString());
				P_4.append(str);
			}
			P_4.append(';');
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;Ljava/lang/StringBuilder;IILjava/util/ArrayList<Ljava/lang/StringBuilder;>;Ljava/util/ArrayList<Ljava/lang/StringBuilder;>;)Z")]
	[LineNumberTable(new byte[]
	{
		160, 128, 102, 98, 143, 110, 105, 127, 27, 185,
		136, 233, 54, 233, 77, 102, 112, 105, 108, 100,
		137, 127, 9, 243, 59, 230, 71, 105, 162
	})]
	private static bool replaceTypeArguments(string P_0, Map P_1, StringBuilder P_2, int P_3, int P_4, ArrayList P_5, ArrayList P_6)
	{
		ArrayList arrayList = new ArrayList();
		int num = 0;
		for (int i = 0; i < P_6.size(); i++)
		{
			StringBuilder stringBuilder = (StringBuilder)P_6.get(i);
			string text;
			if (stringBuilder.length() > 0)
			{
				text = new StringBuilder().append("<").append(renameClass(stringBuilder.substring(1, stringBuilder.length() - 1), P_1)).append(">")
					.toString();
				num = ((num != 0 || !java.lang.String.instancehelper_equals(stringBuilder.toString(), text)) ? 1 : 0);
			}
			else
			{
				text = stringBuilder.toString();
			}
			arrayList.add(text);
		}
		if (num != 0)
		{
			P_2.append(java.lang.String.instancehelper_substring(P_0, P_3, P_4));
			P_2.append('L');
			CharSequence s = default(CharSequence);
			for (int i = 0; i < P_6.size(); i++)
			{
				if (i > 0)
				{
					P_2.append('.');
				}
				object obj = P_5.get(i);
				CharSequence.Cast(obj);
				object obj2 = (s.___003Cref_003E = obj);
				P_2.append(s);
				P_2.append((string)arrayList.get(i));
			}
			P_2.append(';');
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode", "java.lang.IndexOutOfBoundsException" })]
	[LineNumberTable(new byte[]
	{
		163, 238, 103, 104, 104, 103, 103, 121, 145, 100,
		118
	})]
	private static ClassSignature parseSig(string P_0)
	{
		Cursor cursor = new Cursor(null);
		TypeParameter[] @params = parseTypeParams(P_0, cursor);
		ClassType superClass = parseClassType(P_0, cursor);
		int num = java.lang.String.instancehelper_length(P_0);
		ArrayList arrayList = new ArrayList();
		while (cursor.position < num && java.lang.String.instancehelper_charAt(P_0, cursor.position) == 'L')
		{
			((List)arrayList).add((object)parseClassType(P_0, cursor));
		}
		ClassType[] interfaces = (ClassType[])((List)arrayList).toArray((object[])new ClassType[((List)arrayList).size()]);
		ClassSignature result = new ClassSignature(@params, superClass, interfaces);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		163, 254, 103, 104, 125, 140, 103, 112, 105, 106,
		130, 110, 105, 104, 103, 122, 110, 106, 105, 140,
		106, 130, 122, 122
	})]
	private static MethodSignature parseMethodSig(string P_0)
	{
		Cursor cursor = new Cursor(null);
		TypeParameter[] tp = parseTypeParams(P_0, cursor);
		int position = cursor.position;
		Cursor cursor2 = cursor;
		cursor2.position = position + 1;
		if (java.lang.String.instancehelper_charAt(P_0, position) != '(')
		{
			throw Throwable.___003Cunmap_003E(error(P_0));
		}
		ArrayList arrayList = new ArrayList();
		Type e;
		while (java.lang.String.instancehelper_charAt(P_0, cursor.position) != ')')
		{
			e = parseType(P_0, cursor);
			((List)arrayList).add((object)e);
		}
		cursor.position++;
		e = parseType(P_0, cursor);
		int num = java.lang.String.instancehelper_length(P_0);
		ArrayList arrayList2 = new ArrayList();
		while (cursor.position < num && java.lang.String.instancehelper_charAt(P_0, cursor.position) == '^')
		{
			cursor.position++;
			ObjectType objectType = parseObjectType(P_0, cursor, false);
			if (objectType is ArrayType)
			{
				throw Throwable.___003Cunmap_003E(error(P_0));
			}
			((List)arrayList2).add((object)objectType);
		}
		Type[] @params = (Type[])((List)arrayList).toArray((object[])new Type[((List)arrayList).size()]);
		ObjectType[] ex = (ObjectType[])((List)arrayList2).toArray((object[])new ObjectType[((List)arrayList2).size()]);
		MethodSignature result = new MethodSignature(tp, @params, e, ex);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		158, 99, 98, 103, 159, 3, 139, 106, 141, 138,
		99, 98
	})]
	private static ObjectType parseObjectType(string P_0, Cursor P_1, bool P_2)
	{
		int position = P_1.position;
		switch (java.lang.String.instancehelper_charAt(P_0, position))
		{
		case 'L':
		{
			ClassType result2 = parseClassType2(P_0, P_1, null);
			_ = null;
			return result2;
		}
		case 'T':
		{
			int num = P_1.indexOf(P_0, 59);
			TypeVariable result = new TypeVariable(P_0, position + 1, num);
			_ = null;
			return result;
		}
		case '[':
		{
			ObjectType result3 = parseArray(P_0, P_1);
			_ = null;
			return result3;
		}
		default:
			if (P_2)
			{
				return null;
			}
			throw Throwable.___003Cunmap_003E(error(P_0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 164, 139, 105, 104, 159, 0 })]
	private static Type parseType(string P_0, Cursor P_1)
	{
		Type type = parseObjectType(P_0, P_1, true);
		if ((ObjectType)type == null)
		{
			int position = P_1.position;
			P_1.position = position + 1;
			type = new BaseType(java.lang.String.instancehelper_charAt(P_0, position));
		}
		return type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		164, 30, 102, 115, 110, 115, 103, 106, 105, 103,
		112, 110, 106, 106, 130, 104, 123, 105, 133, 174
	})]
	private static TypeParameter[] parseTypeParams(string P_0, Cursor P_1)
	{
		ArrayList arrayList = new ArrayList();
		if (java.lang.String.instancehelper_charAt(P_0, P_1.position) == '<')
		{
			P_1.position++;
			while (java.lang.String.instancehelper_charAt(P_0, P_1.position) != '>')
			{
				int position = P_1.position;
				int num = P_1.indexOf(P_0, 58);
				ObjectType objectType = parseObjectType(P_0, P_1, true);
				ArrayList arrayList2 = new ArrayList();
				while (java.lang.String.instancehelper_charAt(P_0, P_1.position) == ':')
				{
					P_1.position++;
					ObjectType e = parseObjectType(P_0, P_1, false);
					((List)arrayList2).add((object)e);
				}
				TypeParameter e2 = new TypeParameter(P_0, position, num, objectType, (ObjectType[])((List)arrayList2).toArray((object[])new ObjectType[((List)arrayList2).size()]));
				((List)arrayList).add((object)e2);
			}
			P_1.position++;
		}
		return (TypeParameter[])((List)arrayList).toArray((object[])new TypeParameter[((List)arrayList).size()]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 164, 78, 112, 107 })]
	private static ClassType parseClassType(string P_0, Cursor P_1)
	{
		if (java.lang.String.instancehelper_charAt(P_0, P_1.position) == 'L')
		{
			ClassType result = parseClassType2(P_0, P_1, null);
			_ = null;
			return result;
		}
		throw Throwable.___003Cunmap_003E(error(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		164, 86, 180, 122, 111, 138, 101, 105, 188, 131,
		110, 106, 110, 140
	})]
	private static ClassType parseClassType2(string P_0, Cursor P_1, ClassType P_2)
	{
		int num = P_1.position + 1;
		Cursor cursor = P_1;
		int num2 = num;
		cursor.position = num;
		int num3 = num2;
		int num4;
		do
		{
			num = P_1.position;
			cursor = P_1;
			int index = num;
			cursor.position = num + 1;
			num4 = java.lang.String.instancehelper_charAt(P_0, index);
		}
		while (num4 != 36 && num4 != 60 && num4 != 59);
		int num5 = P_1.position - 1;
		TypeArgument[] array;
		if (num4 == 60)
		{
			array = parseTypeArgs(P_0, P_1);
			num = P_1.position;
			cursor = P_1;
			int index2 = num;
			cursor.position = num + 1;
			num4 = java.lang.String.instancehelper_charAt(P_0, index2);
		}
		else
		{
			array = null;
		}
		ClassType classType = ClassType.make(P_0, num3, num5, array, P_2);
		if (num4 == 36 || num4 == 46)
		{
			P_1.position--;
			ClassType result = parseClassType2(P_0, P_1, classType);
			_ = null;
			return result;
		}
		return classType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 164, 131, 98, 125, 134 })]
	private static ObjectType parseArray(string P_0, Cursor P_1)
	{
		int num = 1;
		while (true)
		{
			int num2 = P_1.position + 1;
			P_1.position = num2;
			if (java.lang.String.instancehelper_charAt(P_0, num2) != '[')
			{
				break;
			}
			num++;
		}
		ArrayType result = new ArrayType(num, parseType(P_0, P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		164, 109, 134, 159, 0, 101, 140, 106, 99, 174,
		176, 105, 133
	})]
	private static TypeArgument[] parseTypeArgs(string P_0, Cursor P_1)
	{
		ArrayList arrayList = new ArrayList();
		while (true)
		{
			int position = P_1.position;
			P_1.position = position + 1;
			int num;
			if ((num = java.lang.String.instancehelper_charAt(P_0, position)) == 62)
			{
				break;
			}
			TypeArgument e;
			switch (num)
			{
			case 42:
				e = new TypeArgument(null, '*');
				goto IL_0061;
			default:
				num = 32;
				P_1.position--;
				break;
			case 43:
			case 45:
				break;
			}
			e = new TypeArgument(parseObjectType(P_0, P_1, false), (char)num);
			goto IL_0061;
			IL_0061:
			((List)arrayList).add((object)e);
		}
		return (TypeArgument[])((List)arrayList).toArray((object[])new TypeArgument[((List)arrayList).size()]);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	private static bool lambda_0024makeNewClassName_00240(int P_0)
	{
		return P_0 == 36;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(92)]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		SignatureAttribute result = new SignatureAttribute(newCp, getSignature());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 47, 110, 105 })]
	internal override void renameClass(string P_0, string P_1)
	{
		string signature = renameClass(getSignature(), P_0, P_1);
		setSignature(signature);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 53, 109, 105 })]
	internal override void renameClass(Map P_0)
	{
		string signature = renameClass(getSignature(), P_0);
		setSignature(signature);
	}

	private static bool isNamePart(int P_0)
	{
		return (P_0 != 59 && P_0 != 60) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(32)]
	internal static BadBytecode access_0024000(string P_0)
	{
		BadBytecode result = error(P_0);
		_ = null;
		return result;
	}
}
