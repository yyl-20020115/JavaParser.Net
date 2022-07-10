using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
[Implements(new string[] { "javassist.compiler.TokenId" })]
public class Declarator : ASTList, TokenId
{
	private const long serialVersionUID = 1L;

	protected internal int varType;

	protected internal int arrayDim;

	protected internal int localVar;

	protected internal string qualifiedClass;

	public virtual int getLocalVar()
	{
		return localVar;
	}

	public virtual void setLocalVar(int n)
	{
		localVar = n;
	}

	public virtual int getType()
	{
		return varType;
	}

	public virtual string getClassName()
	{
		return qualifiedClass;
	}

	public virtual void setClassName(string s)
	{
		qualifiedClass = s;
	}

	public virtual int getArrayDim()
	{
		return arrayDim;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 38, 103, 99, 105 })]
	public virtual ASTree getInitializer()
	{
		ASTList aSTList = tail();
		if (aSTList != null)
		{
			ASTree result = aSTList.head();
			_ = null;
			return result;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(83)]
	public virtual Symbol getVariable()
	{
		return (Symbol)getLeft();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 116, 162, 99, 130, 102, 104 })]
	public static string astToClassName(ASTList name, char sep)
	{
		if (name == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		astToClassName(stringBuilder, name, sep);
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 3, 105, 103, 103, 104, 103, 104, 104 })]
	public Declarator(int type, string jvmClassName, int dim, int var, Symbol sym)
		: base(null)
	{
		varType = type;
		arrayDim = dim;
		localVar = var;
		qualifiedClass = jvmClassName;
		setLeft(sym);
		ASTList.append(this, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 176, 105, 103, 103, 103, 103 })]
	public Declarator(int type, int dim)
		: base(null)
	{
		varType = type;
		arrayDim = dim;
		localVar = -1;
		qualifiedClass = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(85)]
	public virtual void setVariable(Symbol sym)
	{
		setLeft(sym);
	}

	[LineNumberTable(77)]
	public virtual void addArrayDim(int d)
	{
		arrayDim += d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 184, 105, 107, 103, 103, 110 })]
	public Declarator(ASTList className, int dim)
		: base(null)
	{
		varType = 307;
		arrayDim = dim;
		localVar = -1;
		qualifiedClass = astToClassName(className, '/');
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 116, 108, 103, 104 })]
	public virtual Declarator make(Symbol sym, int dim, ASTree init)
	{
		Declarator declarator = new Declarator(varType, arrayDim + dim);
		declarator.qualifiedClass = qualifiedClass;
		declarator.setLeft(sym);
		ASTList.append(declarator, init);
		return declarator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 113, 130, 103, 104, 116, 104, 141, 104, 99,
		130, 104, 98
	})]
	private static void astToClassName(StringBuilder P_0, ASTList P_1, char P_2)
	{
		while (true)
		{
			ASTree aSTree = P_1.head();
			if (aSTree is Symbol)
			{
				P_0.append(((Symbol)aSTree).get());
			}
			else if (aSTree is ASTList)
			{
				astToClassName(P_0, (ASTList)aSTree, P_2);
			}
			P_1 = P_1.tail();
			if (P_1 == null)
			{
				break;
			}
			P_0.append(P_2);
		}
	}

	public override string getTag()
	{
		return "decl";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 53, 105 })]
	public override void accept(Visitor v)
	{
		v.atDeclarator(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Declarator(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
