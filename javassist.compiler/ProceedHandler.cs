using IKVM.Attributes;
using javassist.bytecode;
using javassist.compiler.ast;

namespace javassist.compiler;

public interface ProceedHandler
{
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	virtual void doit(JvstCodeGen jcg, Bytecode b, ASTList astl);

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	virtual void setReturnType(JvstTypeChecker jtc, ASTList astl);
}
