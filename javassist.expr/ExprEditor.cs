using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;

namespace javassist.expr;

public class ExprEditor : Object
{
	internal sealed class LoopContext : Object
	{
		internal NewOp newList;

		internal int maxLocals;

		internal int maxStack;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 116, 104, 103, 103, 103 })]
		internal LoopContext(int P_0)
		{
			maxLocals = P_0;
			maxStack = 0;
			newList = null;
		}

		internal virtual void updateMax(int P_0, int P_1)
		{
			if (maxLocals < P_0)
			{
				maxLocals = P_0;
			}
			if (maxStack < P_1)
			{
				maxStack = P_1;
			}
		}
	}

	internal sealed class NewOp : Object
	{
		internal NewOp next;

		internal int pos;

		internal string type;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 104, 104, 103, 103, 103 })]
		internal NewOp(NewOp P_0, int P_1, string P_2)
		{
			next = P_0;
			pos = P_1;
			type = P_2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		37, 103, 99, 130, 103, 98, 140, 104, 108, 132,
		104, 105, 105, 110, 104, 105, 98, 244, 59, 232,
		75, 110, 140, 147, 99, 104, 37, 249, 69, 2,
		98, 180
	})]
	public virtual bool doit(CtClass clazz, MethodInfo minfo)
	{
		CodeAttribute codeAttribute = minfo.getCodeAttribute();
		if (codeAttribute == null)
		{
			return false;
		}
		CodeIterator codeIterator = codeAttribute.iterator();
		int num = 0;
		LoopContext loopContext = new LoopContext(codeAttribute.getMaxLocals());
		while (codeIterator.hasNext())
		{
			if (loopBody(codeIterator, clazz, minfo, loopContext))
			{
				num = 1;
			}
		}
		ExceptionTable exceptionTable = codeAttribute.getExceptionTable();
		int num2 = exceptionTable.size();
		for (int i = 0; i < num2; i++)
		{
			Handler handler = new Handler(exceptionTable, i, codeIterator, clazz, minfo);
			edit(handler);
			if (handler.edited())
			{
				num = 1;
				loopContext.updateMax(handler.locals(), handler.stack());
			}
		}
		if (codeAttribute.getMaxLocals() < loopContext.maxLocals)
		{
			codeAttribute.setMaxLocals(loopContext.maxLocals);
		}
		codeAttribute.setMaxStack(codeAttribute.getMaxStack() + loopContext.maxStack);
		BadBytecode badBytecode;
		try
		{
			if (num != 0)
			{
				minfo.rebuildStackMapIf6(clazz.getClassPool(), clazz.getClassFile2());
				return (byte)num != 0;
			}
			return (byte)num != 0;
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode badBytecode2 = badBytecode;
		string msg = Throwable.instancehelper_getMessage(badBytecode2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(msg, badBytecode2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 85, 98, 116, 104, 109, 98, 104, 100, 136, 130 })]
	internal virtual bool doit(CtClass P_0, MethodInfo P_1, LoopContext P_2, CodeIterator P_3, int P_4)
	{
		int result = 0;
		while (P_3.hasNext() && P_3.lookAhead() < P_4)
		{
			int codeLength = P_3.getCodeLength();
			if (loopBody(P_3, P_0, P_1, P_2))
			{
				result = 1;
				int codeLength2 = P_3.getCodeLength();
				if (codeLength != codeLength2)
				{
					P_4 += codeLength2 - codeLength;
				}
			}
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160, 72, 98, 103, 136, 104, 101, 107, 184, 106,
		150, 191, 1, 107, 150, 104, 106, 107, 117, 101,
		107, 105, 101, 112, 37, 136, 152, 113, 176, 107,
		115, 107, 99, 104, 130, 99, 168, 165, 152, 107,
		147, 104, 106, 147, 104, 106, 209, 107, 115, 133,
		159, 0, 98
	})]
	internal bool loopBody(CodeIterator P_0, CtClass P_1, MethodInfo P_2, LoopContext P_3)
	{
		//Discarded unreachable code: IL_0232
		BadBytecode badBytecode;
		try
		{
			Expr expr = null;
			int num = P_0.next();
			int num2 = P_0.byteAt(num);
			switch (num2)
			{
			case 182:
			case 184:
			case 185:
				expr = new MethodCall(num, P_0, P_1, P_2);
				edit((MethodCall)expr);
				break;
			case 178:
			case 179:
			case 180:
			case 181:
				expr = new FieldAccess(num, P_0, P_1, P_2, num2);
				edit((FieldAccess)expr);
				break;
			case 187:
			{
				int index = P_0.u16bitAt(num + 1);
				P_3.newList = new NewOp(P_3.newList, num, P_2.getConstPool().getClassInfo(index));
				break;
			}
			case 183:
			{
				NewOp newList = P_3.newList;
				if (newList != null && P_2.getConstPool().isConstructor(newList.type, P_0.u16bitAt(num + 1)) > 0)
				{
					expr = new NewExpr(num, P_0, P_1, P_2, newList.type, newList.pos);
					edit((NewExpr)expr);
					P_3.newList = newList.next;
					break;
				}
				MethodCall methodCall = new MethodCall(num, P_0, P_1, P_2);
				if (String.instancehelper_equals(methodCall.getMethodName(), "<init>"))
				{
					ConstructorCall constructorCall = new ConstructorCall(num, P_0, P_1, P_2);
					expr = constructorCall;
					edit(constructorCall);
				}
				else
				{
					expr = methodCall;
					edit(methodCall);
				}
				break;
			}
			case 188:
			case 189:
			case 197:
				expr = new NewArray(num, P_0, P_1, P_2, num2);
				edit((NewArray)expr);
				break;
			case 193:
				expr = new Instanceof(num, P_0, P_1, P_2);
				edit((Instanceof)expr);
				break;
			case 192:
				expr = new Cast(num, P_0, P_1, P_2);
				edit((Cast)expr);
				break;
			}
			if (expr != null && expr.edited())
			{
				P_3.updateMax(expr.locals(), expr.stack());
				return true;
			}
			return false;
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode e = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[Throws(new string[] { "javassist.CannotCompileException" })]
	public virtual void edit(Handler h)
	{
	}

	[Throws(new string[] { "javassist.CannotCompileException" })]
	public virtual void edit(MethodCall m)
	{
	}

	[Throws(new string[] { "javassist.CannotCompileException" })]
	public virtual void edit(FieldAccess f)
	{
	}

	[Throws(new string[] { "javassist.CannotCompileException" })]
	public virtual void edit(NewExpr e)
	{
	}

	[Throws(new string[] { "javassist.CannotCompileException" })]
	public virtual void edit(ConstructorCall c)
	{
	}

	[Throws(new string[] { "javassist.CannotCompileException" })]
	public virtual void edit(NewArray a)
	{
	}

	[Throws(new string[] { "javassist.CannotCompileException" })]
	public virtual void edit(Instanceof i)
	{
	}

	[Throws(new string[] { "javassist.CannotCompileException" })]
	public virtual void edit(Cast c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(79)]
	public ExprEditor()
	{
	}
}
