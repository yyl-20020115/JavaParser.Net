using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using javassist.bytecode.annotation;

namespace javassist.bytecode;

public class TypeAnnotationsAttribute : AttributeInfo
{
	internal class Copier : AnnotationsAttribute.Copier
	{
		internal SubCopier sub;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("([BLjavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
		[LineNumberTable(new byte[] { 160, 156, 110, 109, 103, 113 })]
		internal Copier(byte[] P_0, ConstPool P_1, ConstPool P_2, Map P_3)
			: base(P_0, P_1, P_2, P_3, false)
		{
			sub = new SubCopier(P_0, P_1, P_2, P_3, (TypeAnnotationsWriter)(writer = new TypeAnnotationsWriter(output, P_2)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[]
		{
			160, 164, 108, 102, 105, 113, 110, 233, 60, 230,
			71
		})]
		internal override int annotationArray(int P_0, int P_1)
		{
			writer.numAnnotations(P_1);
			for (int i = 0; i < P_1; i++)
			{
				int num = info[P_0];
				P_0 = sub.targetInfo(P_0 + 1, num);
				P_0 = sub.typePath(P_0);
				P_0 = annotation(P_0);
			}
			return P_0;
		}
	}

	internal class Renamer : AnnotationsAttribute.Renamer
	{
		internal SubWalker sub;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("([BLjavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
		[LineNumberTable(new byte[] { 160, 135, 107, 108 })]
		internal Renamer(byte[] P_0, ConstPool P_1, Map P_2)
			: base(P_0, P_1, P_2)
		{
			sub = new SubWalker(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 141, 102, 105, 113, 110, 233, 60, 230, 71 })]
		internal override int annotationArray(int P_0, int P_1)
		{
			for (int i = 0; i < P_1; i++)
			{
				int num = info[P_0];
				P_0 = sub.targetInfo(P_0 + 1, num);
				P_0 = sub.typePath(P_0);
				P_0 = annotation(P_0);
			}
			return P_0;
		}
	}

	internal class SubCopier : SubWalker
	{
		internal ConstPool srcPool;

		internal ConstPool destPool;

		[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
		internal Map classnames;

		internal TypeAnnotationsWriter writer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("([BLjavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;Ljavassist/bytecode/annotation/TypeAnnotationsWriter;)V")]
		[LineNumberTable(new byte[] { 160, 184, 105, 103, 103, 104, 104 })]
		internal SubCopier(byte[] P_0, ConstPool P_1, ConstPool P_2, Map P_3, TypeAnnotationsWriter P_4)
			: base(P_0)
		{
			srcPool = P_1;
			destPool = P_2;
			classnames = P_3;
			writer = P_4;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 195, 111 })]
		internal override void typeParameterTarget(int P_0, int P_1, int P_2)
		{
			writer.typeParameterTarget(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 200, 110 })]
		internal override void supertypeTarget(int P_0, int P_1)
		{
			writer.supertypeTarget(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 208, 113 })]
		internal override void typeParameterBoundTarget(int P_0, int P_1, int P_2, int P_3)
		{
			writer.typeParameterBoundTarget(P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 213, 110 })]
		internal override void emptyTarget(int P_0, int P_1)
		{
			writer.emptyTarget(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 218, 110 })]
		internal override void formalParameterTarget(int P_0, int P_1)
		{
			writer.formalParameterTarget(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 223, 110 })]
		internal override void throwsTarget(int P_0, int P_1)
		{
			writer.throwsTarget(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 228, 109 })]
		internal override int localvarTarget(int P_0, int P_1, int P_2)
		{
			writer.localVarTarget(P_1, P_2);
			int result = base.localvarTarget(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 236, 114 })]
		internal override void localvarTarget(int P_0, int P_1, int P_2, int P_3, int P_4)
		{
			writer.localVarTargetTable(P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 241, 110 })]
		internal override void catchTarget(int P_0, int P_1)
		{
			writer.catchTarget(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 246, 111 })]
		internal override void offsetTarget(int P_0, int P_1, int P_2)
		{
			writer.offsetTarget(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 253, 113 })]
		internal override void typeArgumentTarget(int P_0, int P_1, int P_2, int P_3)
		{
			writer.typeArgumentTarget(P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 2, 108 })]
		internal override int typePath(int P_0, int P_1)
		{
			writer.typePath(P_1);
			int result = base.typePath(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 8, 111 })]
		internal override void typePath(int P_0, int P_1, int P_2)
		{
			writer.typePathPath(P_1, P_2);
		}
	}

	internal class SubWalker : java.lang.Object
	{
		internal byte[] info;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[]
		{
			82, 191, 160, 220, 105, 105, 132, 109, 104, 164,
			105, 107, 106, 196, 104, 130, 105, 104, 132, 109,
			104, 164, 109, 142, 109, 104, 228, 69, 109, 105,
			228, 70, 109, 107, 106, 132
		})]
		internal int targetInfo(int P_0, int P_1)
		{
			switch (P_1)
			{
			case 0:
			case 1:
			{
				int num = info[P_0];
				typeParameterTarget(P_0, P_1, num);
				return P_0 + 1;
			}
			case 16:
			{
				int num = ByteArray.readU16bit(info, P_0);
				supertypeTarget(P_0, num);
				return P_0 + 2;
			}
			case 17:
			case 18:
			{
				int num = info[P_0];
				int num2 = info[P_0 + 1];
				typeParameterBoundTarget(P_0, P_1, num, num2);
				return P_0 + 2;
			}
			case 19:
			case 20:
			case 21:
				emptyTarget(P_0, P_1);
				return P_0;
			case 22:
			{
				int num = info[P_0];
				formalParameterTarget(P_0, num);
				return P_0 + 1;
			}
			case 23:
			{
				int num = ByteArray.readU16bit(info, P_0);
				throwsTarget(P_0, num);
				return P_0 + 2;
			}
			case 64:
			case 65:
			{
				int num = ByteArray.readU16bit(info, P_0);
				int result = localvarTarget(P_0 + 2, P_1, num);
				_ = null;
				return result;
			}
			case 66:
			{
				int num = ByteArray.readU16bit(info, P_0);
				catchTarget(P_0, num);
				return P_0 + 2;
			}
			case 67:
			case 68:
			case 69:
			case 70:
			{
				int num = ByteArray.readU16bit(info, P_0);
				offsetTarget(P_0, P_1, num);
				return P_0 + 2;
			}
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			{
				int num = ByteArray.readU16bit(info, P_0);
				int num2 = info[P_0 + 2];
				typeArgumentTarget(P_0, P_1, num, num2);
				return P_0 + 3;
			}
			default:
			{
				string message = new StringBuilder().append("invalid target type: ").append(P_1).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException(message);
			}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 113, 110 })]
		internal int typePath(int P_0)
		{
			byte[] array = info;
			int num = P_0;
			P_0++;
			int num2 = array[num];
			int result = typePath(P_0, num2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 77, 104, 103 })]
		internal SubWalker(byte[] P_0)
		{
			info = P_0;
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void typeParameterTarget(int P_0, int P_1, int P_2)
		{
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void supertypeTarget(int P_0, int P_1)
		{
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void typeParameterBoundTarget(int P_0, int P_1, int P_2, int P_3)
		{
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void emptyTarget(int P_0, int P_1)
		{
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void formalParameterTarget(int P_0, int P_1)
		{
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void throwsTarget(int P_0, int P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[]
		{
			160, 91, 102, 109, 111, 111, 107, 229, 59, 230,
			72
		})]
		internal virtual int localvarTarget(int P_0, int P_1, int P_2)
		{
			for (int i = 0; i < P_2; i++)
			{
				int num = ByteArray.readU16bit(info, P_0);
				int num2 = ByteArray.readU16bit(info, P_0 + 2);
				int num3 = ByteArray.readU16bit(info, P_0 + 4);
				localvarTarget(P_0, P_1, num, num2, num3);
				P_0 += 6;
			}
			return P_0;
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void catchTarget(int P_0, int P_1)
		{
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void offsetTarget(int P_0, int P_1, int P_2)
		{
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void typeArgumentTarget(int P_0, int P_1, int P_2, int P_3)
		{
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void localvarTarget(int P_0, int P_1, int P_2, int P_3, int P_4)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 118, 102, 105, 107, 105, 229, 60, 230, 71 })]
		internal virtual int typePath(int P_0, int P_1)
		{
			for (int i = 0; i < P_1; i++)
			{
				int num = info[P_0];
				int num2 = info[P_0 + 1];
				typePath(P_0, num, num2);
				P_0 += 2;
			}
			return P_0;
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void typePath(int P_0, int P_1, int P_2)
		{
		}
	}

	internal class TAWalker : AnnotationsAttribute.Walker
	{
		internal SubWalker subWalker;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 57, 105, 108 })]
		internal TAWalker(byte[] P_0)
			: base(P_0)
		{
			subWalker = new SubWalker(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 63, 102, 105, 113, 110, 233, 60, 230, 71 })]
		internal override int annotationArray(int P_0, int P_1)
		{
			for (int i = 0; i < P_1; i++)
			{
				int num = info[P_0];
				P_0 = subWalker.targetInfo(P_0 + 1, num);
				P_0 = subWalker.typePath(P_0);
				P_0 = annotation(P_0);
			}
			return P_0;
		}
	}

	public const string visibleTag = "RuntimeVisibleTypeAnnotations";

	public const string invisibleTag = "RuntimeInvisibleTypeAnnotations";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 190, 107 })]
	internal TypeAnnotationsAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 181, 107 })]
	public TypeAnnotationsAttribute(ConstPool cp, string attrname, byte[] info)
		: base(cp, attrname, info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 36, 147, 189, 2, 97, 140 })]
	internal override void renameClass(Map P_0)
	{
		Renamer renamer = new Renamer(info, getConstPool(), P_0);
		java.lang.Exception ex2;
		try
		{
			renamer.annotationArray();
			return;
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		java.lang.Exception cause = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	public virtual int numAnnotations()
	{
		int result = ByteArray.readU16bit(info, 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 13, 148, 102, 159, 14, 97 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		//Discarded unreachable code: IL_002e
		Copier copier = new Copier(info, constPool, newCp, classnames);
		java.lang.Exception ex2;
		try
		{
			copier.annotationArray();
			return new TypeAnnotationsAttribute(newCp, getName(), copier.close());
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		java.lang.Exception cause = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 29, 102, 105, 105 })]
	internal override void renameClass(string P_0, string P_1)
	{
		HashMap hashMap = new HashMap();
		((Map)hashMap).put((object)P_0, (object)P_1);
		renameClass(hashMap);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(95)]
	internal override void getRefClasses(Map P_0)
	{
		renameClass(P_0);
	}
}
