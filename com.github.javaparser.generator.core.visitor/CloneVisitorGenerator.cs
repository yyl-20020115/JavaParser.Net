
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator.core.visitor;

public class CloneVisitorGenerator : VisitorGenerator
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

	
	
	public CloneVisitorGenerator(SourceRoot sourceRoot)
		: base(sourceRoot, "com.github.javaparser.ast.visitor", "CloneVisitor", "Visitable", "Object", createMissingVisitMethods: true)
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
		Iterator iterator = node.getAllPropertyMetaModels().iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			string text = new StringBuilder().append(propertyMetaModel.getGetterMethodName()).append("()").ToString();
			if (propertyMetaModel.getNodeReference().isPresent())
			{
				if (propertyMetaModel.isOptional() && propertyMetaModel.isNodeList())
				{
					blockStmt.addStatement(CodeGenerationUtils.f("NodeList<%s> %s = cloneList(n.%s.orElse(null), arg);", propertyMetaModel.getTypeNameGenerified(), propertyMetaModel.getName(), text));
				}
				else if (propertyMetaModel.isNodeList())
				{
					blockStmt.addStatement(CodeGenerationUtils.f("NodeList<%s> %s = cloneList(n.%s, arg);", propertyMetaModel.getTypeNameGenerified(), propertyMetaModel.getName(), text));
				}
				else
				{
					blockStmt.addStatement(CodeGenerationUtils.f("%s %s = cloneNode(n.%s, arg);", propertyMetaModel.getTypeNameGenerified(), propertyMetaModel.getName(), text));
				}
			}
		}
		SeparatedItemStringBuilder separatedItemStringBuilder = new SeparatedItemStringBuilder(CodeGenerationUtils.f("%s r = new %s(", node.getTypeNameGenerified(), node.getTypeNameGenerified()), ",", ");");
		object[] args = new object[0];
		CharSequence format = default(CharSequence);
		object obj = (format.___003Cref_003E = "n.getTokenRange().orElse(null)");
		separatedItemStringBuilder.append(format, args);
		Iterator iterator2 = node.getConstructorParameters().iterator();
		while (iterator2.hasNext())
		{
			PropertyMetaModel propertyMetaModel2 = (PropertyMetaModel)iterator2.next();
			if (!String.instancehelper_equals(propertyMetaModel2.getName(), "comment"))
			{
				if (propertyMetaModel2.getNodeReference().isPresent())
				{
					string name = propertyMetaModel2.getName();
					args = new object[0];
					obj = (format.___003Cref_003E = name);
					separatedItemStringBuilder.append(format, args);
				}
				else
				{
					string __003Cref_003E = CodeGenerationUtils.f("n.%s()", propertyMetaModel2.getGetterMethodName());
					args = new object[0];
					obj = (format.___003Cref_003E = __003Cref_003E);
					separatedItemStringBuilder.append(format, args);
				}
			}
		}
		blockStmt.addStatement(separatedItemStringBuilder.ToString());
		if (node is CompilationUnitMetaModel)
		{
			blockStmt.addStatement("n.getStorage().ifPresent(s -> r.setStorage(s.getPath(), s.getEncoding()));");
		}
		blockStmt.addStatement("r.setComment(comment);");
		blockStmt.addStatement("n.getOrphanComments().stream().map(Comment::clone).forEach(r::addOrphanComment);");
		blockStmt.addStatement("copyData(n, r);");
		blockStmt.addStatement("return r;");
	}
}
