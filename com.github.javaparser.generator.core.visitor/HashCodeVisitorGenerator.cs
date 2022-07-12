
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator.core.visitor;

public class HashCodeVisitorGenerator : VisitorGenerator
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

	
	
	public HashCodeVisitorGenerator(SourceRoot sourceRoot)
		: base(sourceRoot, "com.github.javaparser.ast.visitor", "HashCodeVisitor", "Integer", "Void", createMissingVisitMethods: true)
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
		SeparatedItemStringBuilder separatedItemStringBuilder = new SeparatedItemStringBuilder("return ", "* 31 +", ";");
		List allPropertyMetaModels = node.getAllPropertyMetaModels();
		CharSequence format = default(CharSequence);
		if (allPropertyMetaModels.isEmpty())
		{
			object[] args = new object[0];
			object obj = (format.___003Cref_003E = "0");
			separatedItemStringBuilder.append(format, args);
		}
		else
		{
			Iterator iterator = allPropertyMetaModels.iterator();
			while (iterator.hasNext())
			{
				PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
				string text = new StringBuilder().append(propertyMetaModel.getGetterMethodName()).append("()").ToString();
				if (propertyMetaModel.getNodeReference().isPresent())
				{
					if (propertyMetaModel.isOptional())
					{
						object[] args = new object[2] { text, text };
						object obj = (format.___003Cref_003E = "(n.%s.isPresent()? n.%s.get().accept(this, arg):0)");
						separatedItemStringBuilder.append(format, args);
					}
					else
					{
						object[] args = new object[1] { text };
						object obj = (format.___003Cref_003E = "(n.%s.accept(this, arg))");
						separatedItemStringBuilder.append(format, args);
					}
					continue;
				}
				Class type = propertyMetaModel.getType();
				if (Object.instancehelper_equals(type, Boolean.TYPE))
				{
					object[] args = new object[1] { text };
					object obj = (format.___003Cref_003E = "(n.%s?1:0)");
					separatedItemStringBuilder.append(format, args);
				}
				else if (Object.instancehelper_equals(type, Integer.TYPE))
				{
					object[] args = new object[1] { text };
					object obj = (format.___003Cref_003E = "n.%s");
					separatedItemStringBuilder.append(format, args);
				}
				else
				{
					object[] args = new object[1] { text };
					object obj = (format.___003Cref_003E = "(n.%s.GetHashCode())");
					separatedItemStringBuilder.append(format, args);
				}
			}
		}
		blockStmt.addStatement(StaticJavaParser.parseStatement(separatedItemStringBuilder.ToString()));
	}
}
