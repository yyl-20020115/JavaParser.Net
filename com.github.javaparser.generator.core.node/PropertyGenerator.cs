
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.generator.core.utils;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator.core.node;

public class PropertyGenerator : NodeGenerator
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly PropertyGenerator arg_00241;

		internal ___003C_003EAnon0(PropertyGenerator P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024generateNode_00240((PropertyMetaModel)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Comparator
	{
		internal ___003C_003EAnon1()
		{
		}

		public int compare(object P_0, object P_1)
		{
			int result = String.instancehelper_compareTo((string)P_0, (string)P_1);
			
			return result;
		}

		
		public Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		
		public bool equals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}

		
		public Comparator reversed()
		{
			return Comparator._003Cdefault_003Ereversed(this);
		}

		
		public Comparator thenComparing(Function P_0, Comparator P_1)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
		}

		
		public Comparator thenComparing(Function P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		
		public Comparator thenComparingInt(ToIntFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
		}

		
		public Comparator thenComparingLong(ToLongFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
		}

		
		public Comparator thenComparingDouble(ToDoubleFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
		}
	}

	
		private Map declaredProperties;

	
		private Map derivedProperties;

	
	
	public PropertyGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
		declaredProperties = new HashMap();
		derivedProperties = new HashMap();
	}

	
	
	private void generateGetter(BaseNodeMetaModel P_0, ClassOrInterfaceDeclaration P_1, PropertyMetaModel P_2)
	{
		MethodDeclaration.___003Cclinit_003E();
		MethodDeclaration methodDeclaration = new MethodDeclaration(Modifier.createModifierList(Modifier.Keyword.___003C_003EPUBLIC), StaticJavaParser.parseType(P_2.getTypeNameForGetter()), P_2.getGetterMethodName());
		annotateWhenOverridden(P_0, methodDeclaration);
		BlockStmt blockStmt = (BlockStmt)methodDeclaration.getBody().get();
		blockStmt.getStatements().clear();
		if (P_2.isOptional())
		{
			((CompilationUnit)P_1.findCompilationUnit().get()).addImport(ClassLiteral<Optional>.Value);
			blockStmt.addStatement(CodeGenerationUtils.f("return Optional.ofNullable(%s);", P_2.getName()));
		}
		else
		{
			blockStmt.addStatement(CodeGenerationUtils.f("return %s;", P_2.getName()));
		}
		addOrReplaceWhenSameSignature(P_1, methodDeclaration);
	}

	
	
	private void generateSetter(BaseNodeMetaModel P_0, ClassOrInterfaceDeclaration P_1, PropertyMetaModel P_2)
	{
		((CompilationUnit)P_1.findCompilationUnit().get()).addImport(ClassLiteral<ObservableProperty>.Value);
		string name = P_2.getName();
		string text = Utils.camelCaseToScreaming((!String.instancehelper_startsWith(name, "is")) ? name : String.instancehelper_substring(name, 2));
		declaredProperties.put(text, P_2);
		if (P_2 == JavaParserMetaModel.___003C_003EnodeMetaModel.commentPropertyMetaModel)
		{
			return;
		}
		MethodDeclaration.___003Cclinit_003E();
		MethodDeclaration methodDeclaration = new MethodDeclaration(Modifier.createModifierList(Modifier.Keyword.___003C_003EPUBLIC), StaticJavaParser.parseType(P_2.getContainingNodeMetaModel().getTypeNameGenerified()), P_2.getSetterMethodName());
		annotateWhenOverridden(P_0, methodDeclaration);
		if (P_2.getContainingNodeMetaModel().hasWildcard())
		{
			methodDeclaration.setType(StaticJavaParser.parseType("T"));
		}
		methodDeclaration.addAndGetParameter(P_2.getTypeNameForSetter(), P_2.getName()).addModifier(new Modifier.Keyword[1] { Modifier.Keyword.___003C_003EFINAL });
		BlockStmt blockStmt = (BlockStmt)methodDeclaration.getBody().get();
		blockStmt.getStatements().clear();
		if (P_2.isRequired())
		{
			Class type = P_2.getType();
			if (P_2.isNonEmpty() && P_2.isSingular())
			{
				((CompilationUnit)P_1.findCompilationUnit().get()).addImport("com.github.javaparser.utils.Utils.assertNonEmpty", isStatic: true, isAsterisk: false);
				blockStmt.addStatement(CodeGenerationUtils.f("assertNonEmpty(%s);", name));
			}
			else if (type != Boolean.TYPE && type != Integer.TYPE)
			{
				((CompilationUnit)P_1.findCompilationUnit().get()).addImport("com.github.javaparser.utils.Utils.assertNotNull", isStatic: true, isAsterisk: false);
				blockStmt.addStatement(CodeGenerationUtils.f("assertNotNull(%s);", name));
			}
		}
		string text2 = CodeUtils.castValue("this", methodDeclaration.getType(), P_0.getTypeName());
		blockStmt.addStatement(CodeGenerationUtils.f("if (%s == this.%s) { return %s; }", name, name, text2));
		blockStmt.addStatement(CodeGenerationUtils.f("notifyPropertyChange(ObservableProperty.%s, this.%s, %s);", text, name, name));
		if (P_2.isNode())
		{
			blockStmt.addStatement(CodeGenerationUtils.f("if (this.%s != null) this.%s.setParentNode(null);", name, name));
		}
		blockStmt.addStatement(CodeGenerationUtils.f("this.%s = %s;", name, name));
		if (P_2.isNode())
		{
			blockStmt.addStatement(CodeGenerationUtils.f("setAsParentNodeOf(%s);", name));
		}
		if (P_2.getContainingNodeMetaModel().hasWildcard())
		{
			blockStmt.addStatement(CodeGenerationUtils.f("return (T) this;"));
		}
		else
		{
			blockStmt.addStatement(CodeGenerationUtils.f("return this;"));
		}
		addOrReplaceWhenSameSignature(P_1, methodDeclaration);
		if (P_2.getContainingNodeMetaModel().hasWildcard())
		{
			annotateSuppressWarnings(methodDeclaration);
		}
	}

	
	
	private void generateObservableProperty(EnumDeclaration P_0, PropertyMetaModel P_1, bool P_2)
	{
		int num = ((!ClassLiteral<Node>.Value.isAssignableFrom(P_1.getType())) ? 1 : 0);
		string name = P_1.getName();
		string name2 = Utils.camelCaseToScreaming((!String.instancehelper_startsWith(name, "is")) ? name : String.instancehelper_substring(name, 2));
		EnumConstantDeclaration enumConstantDeclaration = P_0.addEnumConstant(name2);
		if (num != 0)
		{
			enumConstantDeclaration.addArgument("Type.SINGLE_ATTRIBUTE");
		}
		else if (P_1.isNodeList())
		{
			enumConstantDeclaration.addArgument("Type.MULTIPLE_REFERENCE");
		}
		else
		{
			enumConstantDeclaration.addArgument("Type.SINGLE_REFERENCE");
		}
		if (P_2)
		{
			enumConstantDeclaration.addArgument("true");
		}
	}

	
	
	
	private void lambda_0024generateNode_00240(PropertyMetaModel P_0)
	{
		_ = (PropertyMetaModel)derivedProperties.put(P_0.getName(), P_0);
	}

	
	
	protected internal override void generateNode(BaseNodeMetaModel nodeMetaModel, CompilationUnit nodeCu, ClassOrInterfaceDeclaration nodeCoid)
	{
		Iterator iterator = nodeMetaModel.getDeclaredPropertyMetaModels().iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			generateGetter(nodeMetaModel, nodeCoid, propertyMetaModel);
			generateSetter(nodeMetaModel, nodeCoid, propertyMetaModel);
		}
		nodeMetaModel.getDerivedPropertyMetaModels().forEach(new ___003C_003EAnon0(this));
	}

	
	
	
	protected internal override void after()
	{
		CompilationUnit compilationUnit = (CompilationUnit)___003C_003EsourceRoot.tryToParse("com.github.javaparser.ast.observer", "ObservableProperty.java").getResult().get();
		EnumDeclaration enumDeclaration = (EnumDeclaration)compilationUnit.getEnumByName("ObservableProperty").get();
		enumDeclaration.getEntries().clear();
		LinkedList linkedList = new LinkedList(declaredProperties.keySet());
		((List)linkedList).sort((Comparator)new ___003C_003EAnon1());
		Iterator iterator = ((List)linkedList).iterator();
		while (iterator.hasNext())
		{
			string key = (string)iterator.next();
			generateObservableProperty(enumDeclaration, (PropertyMetaModel)declaredProperties.get(key), false);
		}
		LinkedList linkedList2 = new LinkedList(derivedProperties.keySet());
		((List)linkedList2).sort((Comparator)new ___003C_003EAnon1());
		Iterator iterator2 = ((List)linkedList2).iterator();
		while (iterator2.hasNext())
		{
			string key2 = (string)iterator2.next();
			generateObservableProperty(enumDeclaration, (PropertyMetaModel)derivedProperties.get(key2), true);
		}
		enumDeclaration.addEnumConstant("RANGE");
		enumDeclaration.addEnumConstant("COMMENTED_NODE");
	}
}
