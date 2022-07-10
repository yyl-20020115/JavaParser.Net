using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.compiler.ast;

namespace javassist.compiler;

public class JvstTypeChecker : TypeChecker
{
	private JvstCodeGen codeGen;

	public virtual void addNullIfVoid()
	{
		if (exprType == 344)
		{
			exprType = 307;
			arrayDim = 0;
			className = "java/lang/Object";
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 139, 103, 105, 154, 104, 104 })]
	internal virtual void compileInvokeSpecial(ASTree P_0, string P_1, string P_2, string P_3, ASTList P_4)
	{
		P_0.accept(this);
		int methodArgsLength = getMethodArgsLength(P_4);
		atMethodArgs(P_4, new int[methodArgsLength], new int[methodArgsLength], new string[methodArgsLength]);
		setReturnType(P_3);
		addNullIfVoid();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 180, 106, 103 })]
	public JvstTypeChecker(CtClass cc, ClassPool cp, JvstCodeGen gen)
		: base(cc, cp)
	{
		codeGen = gen;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 149, 104, 136, 105 })]
	protected internal virtual void compileUnwrapValue(CtClass type)
	{
		if (type == CtClass.voidType)
		{
			addNullIfVoid();
		}
		else
		{
			setType(type);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		74, 108, 108, 127, 4, 105, 104, 103, 108, 103,
		103, 135
	})]
	protected internal virtual void atCastToRtype(CastExpr expr)
	{
		CtClass returnType = codeGen.returnType;
		expr.getOprand().accept(this);
		if (exprType == 344 || CodeGen.isRefType(exprType) || arrayDim > 0)
		{
			compileUnwrapValue(returnType);
		}
		else if (returnType is CtPrimitiveType)
		{
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)returnType;
			int num = (exprType = MemberResolver.descToType(ctPrimitiveType.getDescriptor()));
			arrayDim = 0;
			className = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 88, 108, 118, 129, 126, 104, 107, 103, 139 })]
	protected internal virtual void atCastToWrapper(CastExpr expr)
	{
		expr.getOprand().accept(this);
		if (!CodeGen.isRefType(exprType) && arrayDim <= 0)
		{
			CtClass ctClass = resolver.lookupClass(exprType, arrayDim, className);
			if (ctClass is CtPrimitiveType)
			{
				exprType = 307;
				arrayDim = 0;
				className = "java/lang/Object";
			}
		}
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	protected internal virtual void atCflow(ASTList cname)
	{
		exprType = 324;
		arrayDim = 0;
		className = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 159, 106 })]
	public virtual void setType(CtClass type)
	{
		setType(type, 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 82, 108, 98, 99, 103, 123, 109, 177, 132,
		104, 130
	})]
	public override int getMethodArgsLength(ASTList args)
	{
		string paramListName = codeGen.paramListName;
		int num = 0;
		while (args != null)
		{
			ASTree aSTree = args.head();
			if (aSTree is Member && String.instancehelper_equals(((Member)aSTree).get(), paramListName))
			{
				if (codeGen.paramTypeList != null)
				{
					num = (int)(num + (nint)codeGen.paramTypeList.LongLength);
				}
			}
			else
			{
				num++;
			}
			args = args.tail();
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 102, 108, 108, 98, 102, 103, 127, 2, 102,
		100, 105, 102, 104, 105, 105, 106, 228, 58, 232,
		72, 162, 103, 105, 105, 106, 164, 104, 101
	})]
	public override void atMethodArgs(ASTList args, int[] types, int[] dims, string[] cnames)
	{
		CtClass[] paramTypeList = codeGen.paramTypeList;
		string paramListName = codeGen.paramListName;
		int num = 0;
		while (args != null)
		{
			ASTree aSTree = args.head();
			if (aSTree is Member && String.instancehelper_equals(((Member)aSTree).get(), paramListName))
			{
				if (paramTypeList != null)
				{
					int num2 = paramTypeList.Length;
					for (int i = 0; i < num2; i++)
					{
						CtClass type = paramTypeList[i];
						setType(type);
						types[num] = exprType;
						dims[num] = arrayDim;
						cnames[num] = className;
						num++;
					}
				}
			}
			else
			{
				aSTree.accept(this);
				types[num] = exprType;
				dims[num] = arrayDim;
				cnames[num] = className;
				num++;
			}
			args = args.tail();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 163, 104, 103, 113, 103, 103, 101, 136, 218,
		2, 97, 191, 11, 107, 103, 145
	})]
	private void setType(CtClass P_0, int P_1)
	{
		if (P_0.isPrimitive())
		{
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)P_0;
			exprType = MemberResolver.descToType(ctPrimitiveType.getDescriptor());
			arrayDim = P_1;
			className = null;
			return;
		}
		if (P_0.isArray())
		{
			try
			{
				setType(P_0.getComponentType(), P_1 + 1);
				return;
			}
			catch (NotFoundException)
			{
			}
			_ = null;
			string s = new StringBuilder().append("undefined type: ").append(P_0.getName()).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(s);
		}
		exprType = 307;
		arrayDim = P_1;
		className = MemberResolver.javaToJvmName(P_0.getName());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		8, 103, 115, 107, 103, 144, 109, 107, 103, 141,
		115, 103, 107, 103, 173, 105
	})]
	public override void atMember(Member mem)
	{
		string @this = mem.get();
		if (String.instancehelper_equals(@this, codeGen.paramArrayName))
		{
			exprType = 307;
			arrayDim = 1;
			className = "java/lang/Object";
		}
		else if (String.instancehelper_equals(@this, "$sig"))
		{
			exprType = 307;
			arrayDim = 1;
			className = "java/lang/Class";
		}
		else if (String.instancehelper_equals(@this, "$type") || String.instancehelper_equals(@this, "$class"))
		{
			exprType = 307;
			arrayDim = 0;
			className = "java/lang/Class";
		}
		else
		{
			base.atMember(mem);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		33, 113, 119, 104, 108, 99, 129, 99, 102, 41,
		134, 130, 109
	})]
	protected internal override void atFieldAssign(Expr expr, int op, ASTree left, ASTree right)
	{
		if (left is Member && String.instancehelper_equals(((Member)left).get(), codeGen.paramArrayName))
		{
			right.accept(this);
			CtClass[] paramTypeList = codeGen.paramTypeList;
			if (paramTypeList != null)
			{
				int num = paramTypeList.Length;
				for (int i = 0; i < num; i++)
				{
					compileUnwrapValue(paramTypeList[i]);
				}
			}
		}
		else
		{
			base.atFieldAssign(expr, op, left, right);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		50, 103, 110, 103, 112, 108, 115, 105, 129, 109,
		105, 225, 69, 105
	})]
	public override void atCastExpr(CastExpr expr)
	{
		ASTList aSTList = expr.getClassName();
		if (aSTList != null && expr.getArrayDim() == 0)
		{
			ASTree aSTree = aSTList.head();
			if (aSTree is Symbol && aSTList.tail() == null)
			{
				string @this = ((Symbol)aSTree).get();
				if (String.instancehelper_equals(@this, codeGen.returnCastName))
				{
					atCastToRtype(expr);
					return;
				}
				if (String.instancehelper_equals(@this, "$w"))
				{
					atCastToWrapper(expr);
					return;
				}
			}
		}
		base.atCastExpr(expr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		105, 103, 107, 108, 121, 103, 109, 42, 135, 129,
		109, 115, 193, 105
	})]
	public override void atCallExpr(CallExpr expr)
	{
		ASTree aSTree = expr.oprand1();
		if (aSTree is Member)
		{
			string @this = ((Member)aSTree).get();
			if (codeGen.procHandler != null && String.instancehelper_equals(@this, codeGen.proceedName))
			{
				codeGen.procHandler.setReturnType(this, (ASTList)expr.oprand2());
				return;
			}
			if (String.instancehelper_equals(@this, "$cflow"))
			{
				atCflow((ASTList)expr.oprand2());
				return;
			}
		}
		base.atCallExpr(expr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 71, 113, 103, 103, 110, 59, 161 })]
	public virtual bool isParamListName(ASTList args)
	{
		if (codeGen.paramTypeList != null && args != null && args.tail() == null)
		{
			ASTree aSTree = args.head();
			return (aSTree is Member && String.instancehelper_equals(((Member)aSTree).get(), codeGen.paramListName)) ? true : false;
		}
		return false;
	}
}
