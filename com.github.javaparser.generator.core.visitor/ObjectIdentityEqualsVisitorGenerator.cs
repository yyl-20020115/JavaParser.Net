using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.util.function;

namespace com.github.javaparser.generator.core.visitor;

public class ObjectIdentityEqualsVisitorGenerator : VisitorGenerator
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		internal ___003C_003EAnon0()
		{
		}

		public void accept(object P_0)
		{
			lambda_0024generateVisitMethodBody_00240((Parameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	
	public ObjectIdentityEqualsVisitorGenerator(SourceRoot sourceRoot)
		: base(sourceRoot, "com.github.javaparser.ast.visitor", "ObjectIdentityEqualsVisitor", "Boolean", "Visitable", createMissingVisitMethods: true)
	{
	}

	
	
	
	private static void lambda_0024generateVisitMethodBody_00240(Parameter P_0)
	{
		_ = (Parameter)P_0.setFinal(true);
	}

	
	
	protected internal override void generateVisitMethodBody(BaseNodeMetaModel node, MethodDeclaration visitMethod, CompilationUnit compilationUnit)
	{
		visitMethod.getParameters().forEach(new ___003C_003EAnon0());
		BlockStmt blockStmt = (BlockStmt)visitMethod.getBody().get();
		blockStmt.getStatements().clear();
		blockStmt.addStatement("return n == arg;");
	}
}
