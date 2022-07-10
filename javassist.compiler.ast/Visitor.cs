using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

public class Visitor : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(26)]
	public Visitor()
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atASTList(ASTList n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atPair(Pair n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atFieldDecl(FieldDecl n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atMethodDecl(MethodDecl n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atStmnt(Stmnt n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atDeclarator(Declarator n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atAssignExpr(AssignExpr n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atCondExpr(CondExpr n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atBinExpr(BinExpr n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atExpr(Expr n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atCallExpr(CallExpr n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atCastExpr(CastExpr n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atInstanceOfExpr(InstanceOfExpr n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atNewExpr(NewExpr n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atSymbol(Symbol n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atMember(Member n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atVariable(Variable n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atKeyword(Keyword n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atStringL(StringL n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atIntConst(IntConst n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atDoubleConst(DoubleConst n)
	{
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atArrayInit(ArrayInit n)
	{
	}
}
