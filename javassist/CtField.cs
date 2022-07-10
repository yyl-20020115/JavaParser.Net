using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using javassist.bytecode;
using javassist.compiler;
using javassist.compiler.ast;

namespace javassist;

public class CtField : CtMember
{
	internal class ArrayInitializer : Initializer
	{
		internal CtClass type;

		internal int size;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1402)]
		internal ArrayInitializer(CtClass P_0, int P_1)
		{
			type = P_0;
			size = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 11, 109, 190, 116 })]
		private void addNewarray(Bytecode P_0)
		{
			if (type.isPrimitive())
			{
				P_0.addNewarray(((CtPrimitiveType)type).getArrayType(), size);
			}
			else
			{
				P_0.addAnewarray(type, size);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 165, 23, 103, 103, 114 })]
		internal override int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			P_2.addAload(0);
			addNewarray(P_2);
			P_2.addPutfield(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 165, 33, 103, 114 })]
		internal override int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			addNewarray(P_2);
			P_2.addPutstatic(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 1;
		}
	}

	internal class CodeInitializer : CodeInitializer0
	{
		private string expression;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(936)]
		internal CodeInitializer(string P_0)
		{
			expression = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 163, 58, 110 })]
		internal override void compileExpr(Javac P_0)
		{
			P_0.compileExpr(expression);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 64, 113, 152, 97 })]
		internal override int getConstantValue(ConstPool P_0, CtClass P_1)
		{
			//Discarded unreachable code: IL_001c
			try
			{
				ASTree aSTree = Javac.parseExpr(expression, new SymbolTable());
				return getConstantValue2(P_0, P_1, aSTree);
			}
			catch (CompileError)
			{
			}
			_ = null;
			return 0;
		}
	}

	internal abstract class CodeInitializer0 : Initializer
	{
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		internal abstract void compileExpr(Javac P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(871)]
		internal CodeInitializer0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 162, 254, 103, 104, 114, 156, 97 })]
		internal override int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			//Discarded unreachable code: IL_0029
			CompileError compileError;
			try
			{
				P_2.addAload(0);
				compileExpr(P_4);
				P_2.addPutfield(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
				return P_2.getMaxStack();
			}
			catch (CompileError x)
			{
				compileError = ByteCodeHelper.MapException<CompileError>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			CompileError e = compileError;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(e);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 163, 13, 104, 114, 156, 97 })]
		internal override int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			//Discarded unreachable code: IL_0022
			CompileError compileError;
			try
			{
				compileExpr(P_3);
				P_2.addPutstatic(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
				return P_2.getMaxStack();
			}
			catch (CompileError x)
			{
				compileError = ByteCodeHelper.MapException<CompileError>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			CompileError e = compileError;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(e);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163, 23, 107, 104, 108, 104, 107, 104, 107, 104,
			106, 104, 107, 101, 104, 109, 104, 107, 104, 106,
			130, 105, 113, 148
		})]
		internal virtual int getConstantValue2(ConstPool P_0, CtClass P_1, ASTree P_2)
		{
			if (P_1.isPrimitive())
			{
				if (P_2 is IntConst)
				{
					long num = ((IntConst)P_2).get();
					if (P_1 == CtClass.doubleType)
					{
						int result = P_0.addDoubleInfo(num);
						_ = null;
						return result;
					}
					if (P_1 == CtClass.floatType)
					{
						int result2 = P_0.addFloatInfo(num);
						_ = null;
						return result2;
					}
					if (P_1 == CtClass.longType)
					{
						int result3 = P_0.addLongInfo(num);
						_ = null;
						return result3;
					}
					if (P_1 != CtClass.voidType)
					{
						int result4 = P_0.addIntegerInfo((int)num);
						_ = null;
						return result4;
					}
				}
				else if (P_2 is DoubleConst)
				{
					double num2 = ((DoubleConst)P_2).get();
					if (P_1 == CtClass.floatType)
					{
						int result5 = P_0.addFloatInfo((float)num2);
						_ = null;
						return result5;
					}
					if (P_1 == CtClass.doubleType)
					{
						int result6 = P_0.addDoubleInfo(num2);
						_ = null;
						return result6;
					}
				}
			}
			else if (P_2 is StringL && String.instancehelper_equals(P_1.getName(), "java.lang.String"))
			{
				int result7 = P_0.addStringInfo(((StringL)P_2).get());
				_ = null;
				return result7;
			}
			return 0;
		}
	}

	internal class DoubleInitializer : Initializer
	{
		internal double value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1329)]
		internal DoubleInitializer(double P_0)
		{
			value = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 195, 109, 112 })]
		internal override void check(string P_0)
		{
			if (!String.instancehelper_equals(P_0, "D"))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CannotCompileException("type mismatch");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 204, 103, 108, 114 })]
		internal override int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			P_2.addAload(0);
			P_2.addLdc2w(value);
			P_2.addPutfield(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 214, 108, 114 })]
		internal override int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			P_2.addLdc2w(value);
			P_2.addPutstatic(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 221, 104, 111 })]
		internal override int getConstantValue(ConstPool P_0, CtClass P_1)
		{
			if (P_1 == CtClass.doubleType)
			{
				int result = P_0.addDoubleInfo(value);
				_ = null;
				return result;
			}
			return 0;
		}
	}

	internal class FloatInitializer : Initializer
	{
		internal float value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1290)]
		internal FloatInitializer(float P_0)
		{
			value = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 156, 109, 112 })]
		internal override void check(string P_0)
		{
			if (!String.instancehelper_equals(P_0, "F"))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CannotCompileException("type mismatch");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 165, 103, 108, 114 })]
		internal override int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			P_2.addAload(0);
			P_2.addFconst(value);
			P_2.addPutfield(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 175, 108, 114 })]
		internal override int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			P_2.addFconst(value);
			P_2.addPutstatic(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 182, 104, 111 })]
		internal override int getConstantValue(ConstPool P_0, CtClass P_1)
		{
			if (P_1 == CtClass.floatType)
			{
				int result = P_0.addFloatInfo(value);
				_ = null;
				return result;
			}
			return 0;
		}
	}

	public abstract class Initializer : Object
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 220, 102, 103, 103, 103 })]
		public static Initializer byNew(CtClass objectType)
		{
			NewInitializer newInitializer = new NewInitializer();
			newInitializer.objectType = objectType;
			newInitializer.stringParams = null;
			newInitializer.withConstructorParams = false;
			return newInitializer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(846)]
		public static Initializer byExpr(string source)
		{
			CodeInitializer result = new CodeInitializer(source);
			_ = null;
			return result;
		}

		[Throws(new string[] { "javassist.CannotCompileException" })]
		internal virtual void check(string P_0)
		{
		}

		internal virtual int getConstantValue(ConstPool P_0, CtClass P_1)
		{
			return 0;
		}

		[Throws(new string[] { "javassist.CannotCompileException" })]
		[Modifiers(Modifiers.Abstract)]
		internal virtual int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			throw new AbstractMethodError("javassist.CtField$Initializer.compileIfStatic(Ljavassist.CtClass;Ljava.lang.String;Ljavassist.bytecode.Bytecode;Ljavassist.compiler.Javac;)I");
		}

		[Throws(new string[] { "javassist.CannotCompileException" })]
		[Modifiers(Modifiers.Abstract)]
		internal virtual int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			throw new AbstractMethodError("javassist.CtField$Initializer.compile(Ljavassist.CtClass;Ljava.lang.String;Ljavassist.bytecode.Bytecode;[Ljavassist.CtClass;Ljavassist.compiler.Javac;)I");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(506)]
		public Initializer()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(512)]
		public static Initializer constant(int i)
		{
			IntInitializer result = new IntInitializer(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(520)]
		public static Initializer constant(bool b)
		{
			IntInitializer result = new IntInitializer(b ? 1 : 0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(528)]
		public static Initializer constant(long l)
		{
			LongInitializer result = new LongInitializer(l);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(536)]
		public static Initializer constant(float l)
		{
			FloatInitializer result = new FloatInitializer(l);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(544)]
		public static Initializer constant(double d)
		{
			DoubleInitializer result = new DoubleInitializer(d);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(552)]
		public static Initializer constant(string s)
		{
			StringInitializer result = new StringInitializer(s);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 200, 102, 103 })]
		public static Initializer byParameter(int nth)
		{
			ParamInitializer paramInitializer = new ParamInitializer();
			paramInitializer.nthParam = nth;
			return paramInitializer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 247, 102, 103, 103, 103 })]
		public static Initializer byNew(CtClass objectType, string[] stringParams)
		{
			NewInitializer newInitializer = new NewInitializer();
			newInitializer.objectType = objectType;
			newInitializer.stringParams = stringParams;
			newInitializer.withConstructorParams = false;
			return newInitializer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 19, 102, 103, 103, 103 })]
		public static Initializer byNewWithParams(CtClass objectType)
		{
			NewInitializer newInitializer = new NewInitializer();
			newInitializer.objectType = objectType;
			newInitializer.stringParams = null;
			newInitializer.withConstructorParams = true;
			return newInitializer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 49, 102, 103, 103, 103 })]
		public static Initializer byNewWithParams(CtClass objectType, string[] stringParams)
		{
			NewInitializer newInitializer = new NewInitializer();
			newInitializer.objectType = objectType;
			newInitializer.stringParams = stringParams;
			newInitializer.withConstructorParams = true;
			return newInitializer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 77, 102, 103, 103, 103, 103 })]
		public static Initializer byCall(CtClass methodClass, string methodName)
		{
			MethodInitializer methodInitializer = new MethodInitializer();
			methodInitializer.objectType = methodClass;
			methodInitializer.methodName = methodName;
			methodInitializer.stringParams = null;
			methodInitializer.withConstructorParams = false;
			return methodInitializer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 111, 102, 103, 103, 103, 103 })]
		public static Initializer byCall(CtClass methodClass, string methodName, string[] stringParams)
		{
			MethodInitializer methodInitializer = new MethodInitializer();
			methodInitializer.objectType = methodClass;
			methodInitializer.methodName = methodName;
			methodInitializer.stringParams = stringParams;
			methodInitializer.withConstructorParams = false;
			return methodInitializer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 143, 102, 103, 103, 103, 103 })]
		public static Initializer byCallWithParams(CtClass methodClass, string methodName)
		{
			MethodInitializer methodInitializer = new MethodInitializer();
			methodInitializer.objectType = methodClass;
			methodInitializer.methodName = methodName;
			methodInitializer.stringParams = null;
			methodInitializer.withConstructorParams = true;
			return methodInitializer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 179, 102, 103, 103, 103, 103 })]
		public static Initializer byCallWithParams(CtClass methodClass, string methodName, string[] stringParams)
		{
			MethodInitializer methodInitializer = new MethodInitializer();
			methodInitializer.objectType = methodClass;
			methodInitializer.methodName = methodName;
			methodInitializer.stringParams = stringParams;
			methodInitializer.withConstructorParams = true;
			return methodInitializer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[LineNumberTable(824)]
		public static Initializer byNewArray(CtClass type, int size)
		{
			ArrayInitializer result = new ArrayInitializer(type.getComponentType(), size);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(837)]
		public static Initializer byNewArray(CtClass type, int[] sizes)
		{
			MultiArrayInitializer result = new MultiArrayInitializer(type, sizes);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(850)]
		internal static Initializer byExpr(ASTree P_0)
		{
			PtreeInitializer result = new PtreeInitializer(P_0);
			_ = null;
			return result;
		}
	}

	internal class IntInitializer : Initializer
	{
		internal int value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1213)]
		internal IntInitializer(int P_0)
		{
			value = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 79, 104, 121, 112 })]
		internal override void check(string P_0)
		{
			int num = String.instancehelper_charAt(P_0, 0);
			if (num != 73 && num != 83 && num != 66 && num != 67 && num != 90)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CannotCompileException("type mismatch");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 89, 103, 108, 114 })]
		internal override int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			P_2.addAload(0);
			P_2.addIconst(value);
			P_2.addPutfield(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 99, 108, 114 })]
		internal override int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			P_2.addIconst(value);
			P_2.addPutstatic(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1244)]
		internal override int getConstantValue(ConstPool P_0, CtClass P_1)
		{
			int result = P_0.addIntegerInfo(value);
			_ = null;
			return result;
		}
	}

	internal class LongInitializer : Initializer
	{
		internal long value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1251)]
		internal LongInitializer(long P_0)
		{
			value = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 117, 109, 112 })]
		internal override void check(string P_0)
		{
			if (!String.instancehelper_equals(P_0, "J"))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CannotCompileException("type mismatch");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 126, 103, 108, 114 })]
		internal override int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			P_2.addAload(0);
			P_2.addLdc2w(value);
			P_2.addPutfield(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 136, 108, 114 })]
		internal override int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			P_2.addLdc2w(value);
			P_2.addPutstatic(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 143, 104, 111 })]
		internal override int getConstantValue(ConstPool P_0, CtClass P_1)
		{
			if (P_1 == CtClass.longType)
			{
				int result = P_0.addLongInfo(value);
				_ = null;
				return result;
			}
			return 0;
		}
	}

	internal class MethodInitializer : NewInitializer
	{
		internal string methodName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1138)]
		internal MethodInitializer()
		{
		}

		private string getDescriptor()
		{
			if (stringParams == null)
			{
				if (withConstructorParams)
				{
					return "(Ljava/lang/Object;[Ljava/lang/Object;)";
				}
				return "(Ljava/lang/Object;)";
			}
			if (withConstructorParams)
			{
				return "(Ljava/lang/Object;[Ljava/lang/String;[Ljava/lang/Object;)";
			}
			return "(Ljava/lang/Object;[Ljava/lang/String;)";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[]
		{
			164, 13, 103, 135, 104, 132, 138, 104, 172, 103,
			124, 115, 109
		})]
		internal override int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			P_2.addAload(0);
			P_2.addAload(0);
			int num = ((stringParams != null) ? (compileStringParameter(P_2) + 2) : 2);
			if (withConstructorParams)
			{
				num += CtNewWrappedMethod.compileParameterList(P_2, P_3, 1);
			}
			string text = Descriptor.of(P_0);
			string desc = new StringBuilder().append(getDescriptor()).append(text).toString();
			P_2.addInvokestatic(objectType, methodName, desc);
			P_2.addPutfield(Bytecode.___003C_003ETHIS, P_1, text);
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[]
		{
			164, 57, 98, 104, 136, 102, 170, 103, 127, 9,
			109
		})]
		internal override int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			int num = 1;
			string str;
			if (stringParams == null)
			{
				str = "()";
			}
			else
			{
				str = "([Ljava/lang/String;)";
				num += compileStringParameter(P_2);
			}
			string text = Descriptor.of(P_0);
			P_2.addInvokestatic(objectType, methodName, new StringBuilder().append(str).append(text).toString());
			P_2.addPutstatic(Bytecode.___003C_003ETHIS, P_1, text);
			return num;
		}
	}

	internal class MultiArrayInitializer : Initializer
	{
		internal CtClass type;

		internal int[] dim;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1437)]
		internal MultiArrayInitializer(CtClass P_0, int[] P_1)
		{
			type = P_0;
			dim = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 165, 47, 107, 112 })]
		internal override void check(string P_0)
		{
			if (String.instancehelper_charAt(P_0, 0) != '[')
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CannotCompileException("type mismatch");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 165, 56, 103, 110, 114 })]
		internal override int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			P_2.addAload(0);
			int num = P_2.addMultiNewarray(P_0, dim);
			P_2.addPutfield(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return num + 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 165, 66, 110, 114 })]
		internal override int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			int result = P_2.addMultiNewarray(P_0, dim);
			P_2.addPutstatic(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return result;
		}
	}

	internal class NewInitializer : Initializer
	{
		internal CtClass objectType;

		internal string[] stringParams;

		internal bool withConstructorParams;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1040)]
		internal NewInitializer()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[]
		{
			163, 234, 104, 103, 107, 102, 104, 103, 110, 232,
			60, 230, 71
		})]
		protected internal int compileStringParameter(Bytecode P_0)
		{
			int num = stringParams.Length;
			P_0.addIconst(num);
			P_0.addAnewarray("java.lang.String");
			for (int i = 0; i < num; i++)
			{
				P_0.add(89);
				P_0.addIconst(i);
				P_0.addLdc(stringParams[i]);
				P_0.add(83);
			}
			return 4;
		}

		private string getDescriptor()
		{
			if (stringParams == null)
			{
				if (withConstructorParams)
				{
					return "(Ljava/lang/Object;[Ljava/lang/Object;)V";
				}
				return "(Ljava/lang/Object;)V";
			}
			if (withConstructorParams)
			{
				return "(Ljava/lang/Object;[Ljava/lang/String;[Ljava/lang/Object;)V";
			}
			return "(Ljava/lang/Object;[Ljava/lang/String;)V";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[]
		{
			163, 171, 103, 108, 104, 135, 104, 132, 138, 104,
			172, 119, 114
		})]
		internal override int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			P_2.addAload(0);
			P_2.addNew(objectType);
			P_2.add(89);
			P_2.addAload(0);
			int num = ((stringParams != null) ? (compileStringParameter(P_2) + 4) : 4);
			if (withConstructorParams)
			{
				num += CtNewWrappedMethod.compileParameterList(P_2, P_3, 1);
			}
			P_2.addInvokespecial(objectType, "<init>", getDescriptor());
			P_2.addPutfield(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[]
		{
			163, 215, 108, 136, 98, 104, 136, 102, 170, 114,
			114
		})]
		internal override int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			P_2.addNew(objectType);
			P_2.add(89);
			int num = 2;
			string desc;
			if (stringParams == null)
			{
				desc = "()V";
			}
			else
			{
				desc = "([Ljava/lang/String;)V";
				num += compileStringParameter(P_2);
			}
			P_2.addInvokespecial(objectType, "<init>", desc);
			P_2.addPutstatic(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return num;
		}
	}

	internal class ParamInitializer : Initializer
	{
		internal int nthParam;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(978)]
		internal ParamInitializer()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			158, 147, 98, 102, 134, 99, 132, 130, 104, 102,
			106, 134, 228, 59, 232, 72
		})]
		internal static int nthParamToLocal(int P_0, CtClass[] P_1, bool P_2)
		{
			CtClass longType = CtClass.longType;
			CtClass doubleType = CtClass.doubleType;
			int num = ((!P_2) ? 1 : 0);
			for (int i = 0; i < P_0; i++)
			{
				CtClass ctClass = P_1[i];
				num = ((ctClass != longType && ctClass != doubleType) ? (num + 1) : (num + 2));
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 163, 103, 111, 103, 111, 107, 114, 130 })]
		internal override int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			if (P_3 != null && nthParam < (nint)P_3.LongLength)
			{
				P_2.addAload(0);
				int n = nthParamToLocal(nthParam, P_3, false);
				int result = P_2.addLoad(n, P_0) + 1;
				P_2.addPutfield(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
				return result;
			}
			return 0;
		}

		[Throws(new string[] { "javassist.CannotCompileException" })]
		internal override int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			return 0;
		}
	}

	internal class PtreeInitializer : CodeInitializer0
	{
		private ASTree expression;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(958)]
		internal PtreeInitializer(ASTree P_0)
		{
			expression = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 163, 80, 110 })]
		internal override void compileExpr(Javac P_0)
		{
			P_0.compileExpr(expression);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(967)]
		internal override int getConstantValue(ConstPool P_0, CtClass P_1)
		{
			int constantValue = getConstantValue2(P_0, P_1, expression);
			_ = null;
			return constantValue;
		}
	}

	internal class StringInitializer : Initializer
	{
		internal string value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1368)]
		internal StringInitializer(string P_0)
		{
			value = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 237, 103, 108, 114 })]
		internal override int compile(CtClass P_0, string P_1, Bytecode P_2, CtClass[] P_3, Javac P_4)
		{
			P_2.addAload(0);
			P_2.addLdc(value);
			P_2.addPutfield(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 164, 247, 108, 114 })]
		internal override int compileIfStatic(CtClass P_0, string P_1, Bytecode P_2, Javac P_3)
		{
			P_2.addLdc(value);
			P_2.addPutstatic(Bytecode.___003C_003ETHIS, P_1, Descriptor.of(P_0));
			return 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 254, 114, 111 })]
		internal override int getConstantValue(ConstPool P_0, CtClass P_1)
		{
			if (String.instancehelper_equals(P_1.getName(), "java.lang.String"))
			{
				int result = P_0.addStringInfo(value);
				_ = null;
				return result;
			}
			return 0;
		}
	}

	internal const string javaLangString = "java.lang.String";

	protected internal FieldInfo fieldInfo;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(222)]
	public override string getName()
	{
		string name = fieldInfo.getName();
		_ = null;
		return name;
	}

	public virtual FieldInfo getFieldInfo2()
	{
		return fieldInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 76, 127, 27, 49 })]
	public override string toString()
	{
		string result = new StringBuilder().append(getDeclaringClass().getName()).append(".").append(getName())
			.append(":")
			.append(fieldInfo.getDescriptor())
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(214)]
	public override CtClass getDeclaringClass()
	{
		CtClass result = base.getDeclaringClass();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 249, 107, 107 })]
	public override string getGenericSignature()
	{
		string result = ((javassist.bytecode.SignatureAttribute)fieldInfo.getAttribute("Signature"))?.getSignature();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(351)]
	public override string getSignature()
	{
		string descriptor = fieldInfo.getDescriptor();
		_ = null;
		return descriptor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(240)]
	public override int getModifiers()
	{
		int result = AccessFlag.toModifier(fieldInfo.getAccessFlags());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 21, 112 })]
	public CtField(CtClass type, string name, CtClass declaring)
		: this(Descriptor.of(type), name, declaring)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 136, 107, 115 })]
	public override void setModifiers(int mod)
	{
		declaringClass.checkModify();
		fieldInfo.setAccessFlags(AccessFlag.of(mod));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 67, 105, 103 })]
	internal CtField(FieldInfo P_0, CtClass P_1)
		: base(P_1)
	{
		fieldInfo = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 93, 103, 99, 98 })]
	internal virtual Initializer getInit()
	{
		ASTree initAST = getInitAST();
		if (initAST == null)
		{
			return null;
		}
		Initializer result = Initializer.byExpr(initAST);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 161, 18, 113, 37 })]
	public virtual CtClass getType()
	{
		CtClass result = Descriptor.toCtClass(fieldInfo.getDescriptor(), declaringClass.getClassPool());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 57, 105, 103, 99, 112, 154, 115 })]
	private CtField(string P_0, string P_1, CtClass P_2)
		: base(P_2)
	{
		ClassFile classFile = P_2.getClassFile2();
		if (classFile == null)
		{
			string msg = new StringBuilder().append("bad declaring class: ").append(P_2.getName()).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(msg);
		}
		fieldInfo = new FieldInfo(classFile.getConstPool(), P_1, P_0);
	}

	protected internal virtual ASTree getInitAST()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 159, 61, 130, 103, 102, 107, 102, 107 })]
	private object[] getAnnotations(bool P_0)
	{
		FieldInfo fieldInfo = getFieldInfo2();
		AnnotationsAttribute annotationsAttribute = (AnnotationsAttribute)fieldInfo.getAttribute("RuntimeInvisibleAnnotations");
		AnnotationsAttribute annotationsAttribute2 = (AnnotationsAttribute)fieldInfo.getAttribute("RuntimeVisibleAnnotations");
		object[] result = CtClassType.toAnnotationType(P_0, getDeclaringClass().getClassPool(), annotationsAttribute, annotationsAttribute2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 44, 159, 0, 103, 113, 103, 108, 127, 0, 113 })]
	public CtField(CtField src, CtClass declaring)
		: this(src.fieldInfo.getDescriptor(), src.fieldInfo.getName(), declaring)
	{
		FieldInfo fieldInfo = this.fieldInfo;
		fieldInfo.setAccessFlags(src.fieldInfo.getAccessFlags());
		ConstPool constPool = fieldInfo.getConstPool();
		List attributes = src.fieldInfo.getAttributes();
		Iterator iterator = attributes.iterator();
		while (iterator.hasNext())
		{
			AttributeInfo attributeInfo = (AttributeInfo)iterator.next();
			fieldInfo.addAttribute(attributeInfo.copy(constPool, null));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 82, 105, 109, 105, 114 })]
	protected internal override void extendToString(StringBuilder buffer)
	{
		buffer.append(' ');
		buffer.append(getName());
		buffer.append(' ');
		buffer.append(fieldInfo.getDescriptor());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 116, 135, 104, 104, 223, 1, 2, 98, 173 })]
	public static CtField make(string src, CtClass declaring)
	{
		//Discarded unreachable code: IL_0021
		Javac javac = new Javac(declaring);
		CompileError compileError;
		try
		{
			CtMember ctMember = javac.compile(src);
			if (ctMember is CtField)
			{
				return (CtField)ctMember;
			}
		}
		catch (CompileError x)
		{
			compileError = ByteCodeHelper.MapException<CompileError>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0033;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException("not a field");
		IL_0033:
		CompileError e = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 69, 107 })]
	public virtual FieldInfo getFieldInfo()
	{
		declaringClass.checkModify();
		return fieldInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 115, 107, 110 })]
	public virtual void setName(string newName)
	{
		declaringClass.checkModify();
		fieldInfo.setName(newName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 149, 103, 102, 107, 102, 107 })]
	public override bool hasAnnotation(string typeName)
	{
		FieldInfo fieldInfo = getFieldInfo2();
		AnnotationsAttribute annotationsAttribute = (AnnotationsAttribute)fieldInfo.getAttribute("RuntimeInvisibleAnnotations");
		AnnotationsAttribute annotationsAttribute2 = (AnnotationsAttribute)fieldInfo.getAttribute("RuntimeVisibleAnnotations");
		bool result = CtClassType.hasAnnotationType(typeName, getDeclaringClass().getClassPool(), annotationsAttribute, annotationsAttribute2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)Ljava/lang/Object;")]
	[LineNumberTable(new byte[] { 160, 171, 103, 102, 107, 102, 107 })]
	public override object getAnnotation(Class clz)
	{
		FieldInfo fieldInfo = getFieldInfo2();
		AnnotationsAttribute annotationsAttribute = (AnnotationsAttribute)fieldInfo.getAttribute("RuntimeInvisibleAnnotations");
		AnnotationsAttribute annotationsAttribute2 = (AnnotationsAttribute)fieldInfo.getAttribute("RuntimeVisibleAnnotations");
		object annotationType = CtClassType.getAnnotationType(clz, getDeclaringClass().getClassPool(), annotationsAttribute, annotationsAttribute2);
		_ = null;
		return annotationType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(303)]
	public override object[] getAnnotations()
	{
		object[] annotations = getAnnotations(false);
		_ = null;
		return annotations;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 204, 157, 97 })]
	public override object[] getAvailableAnnotations()
	{
		//Discarded unreachable code: IL_0009
		java.lang.ClassNotFoundException ex;
		try
		{
			return getAnnotations(true);
		}
		catch (java.lang.ClassNotFoundException x)
		{
			ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		java.lang.ClassNotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("Unexpected exception", cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 10, 107, 126 })]
	public override void setGenericSignature(string sig)
	{
		declaringClass.checkModify();
		fieldInfo.addAttribute(new javassist.bytecode.SignatureAttribute(fieldInfo.getConstPool(), sig));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 37, 107, 115 })]
	public virtual void setType(CtClass clazz)
	{
		declaringClass.checkModify();
		fieldInfo.setDescriptor(Descriptor.of(clazz));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 59, 108, 99, 130, 108, 159, 12, 143, 143,
		143, 136, 119, 111, 137, 138
	})]
	public virtual object getConstantValue()
	{
		int constantValue = fieldInfo.getConstantValue();
		if (constantValue == 0)
		{
			return null;
		}
		ConstPool constPool = fieldInfo.getConstPool();
		switch (constPool.getTag(constantValue))
		{
		case 5:
		{
			Long result5 = Long.valueOf(constPool.getLongInfo(constantValue));
			_ = null;
			return result5;
		}
		case 4:
		{
			Float result4 = Float.valueOf(constPool.getFloatInfo(constantValue));
			_ = null;
			return result4;
		}
		case 6:
		{
			Double result3 = Double.valueOf(constPool.getDoubleInfo(constantValue));
			_ = null;
			return result3;
		}
		case 3:
		{
			int integerInfo = constPool.getIntegerInfo(constantValue);
			if (String.instancehelper_equals("Z", fieldInfo.getDescriptor()))
			{
				Boolean result = Boolean.valueOf((integerInfo != 0) ? true : false);
				_ = null;
				return result;
			}
			Integer result2 = Integer.valueOf(integerInfo);
			_ = null;
			return result2;
		}
		case 8:
		{
			string stringInfo = constPool.getStringInfo(constantValue);
			_ = null;
			return stringInfo;
		}
		default:
		{
			string message = new StringBuilder().append("bad tag: ").append(constPool.getTag(constantValue)).append(" at ")
				.append(constantValue)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 98, 109, 99, 98 })]
	public override byte[] getAttribute(string name)
	{
		AttributeInfo attribute = fieldInfo.getAttribute(name);
		if (attribute == null)
		{
			return null;
		}
		byte[] result = attribute.get();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 116, 107, 159, 0 })]
	public override void setAttribute(string name, byte[] data)
	{
		declaringClass.checkModify();
		fieldInfo.addAttribute(new AttributeInfo(fieldInfo.getConstPool(), name, data));
	}
}
