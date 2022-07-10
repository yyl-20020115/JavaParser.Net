using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.nodeTypes.modifiers;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.javadoc;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.body;

[Implements(new string[]
{
	"com.github.javaparser.ast.nodeTypes.NodeWithType", "com.github.javaparser.ast.nodeTypes.NodeWithOptionalBlockStmt", "com.github.javaparser.ast.nodeTypes.NodeWithJavadoc", "com.github.javaparser.ast.nodeTypes.NodeWithDeclaration", "com.github.javaparser.ast.nodeTypes.NodeWithSimpleName", "com.github.javaparser.ast.nodeTypes.NodeWithParameters", "com.github.javaparser.ast.nodeTypes.NodeWithThrownExceptions", "com.github.javaparser.ast.nodeTypes.NodeWithTypeParameters", "com.github.javaparser.ast.nodeTypes.modifiers.NodeWithAccessModifiers", "com.github.javaparser.ast.nodeTypes.modifiers.NodeWithAbstractModifier",
	"com.github.javaparser.ast.nodeTypes.modifiers.NodeWithStaticModifier", "com.github.javaparser.ast.nodeTypes.modifiers.NodeWithFinalModifier", "com.github.javaparser.ast.nodeTypes.modifiers.NodeWithStrictfpModifier", "com.github.javaparser.resolution.Resolvable"
})]
public class MethodDeclaration : CallableDeclaration, NodeWithType, NodeWithOptionalBlockStmt, NodeWithJavadoc, NodeWithDeclaration, NodeWithSimpleName, NodeWithParameters, NodeWithThrownExceptions, NodeWithTypeParameters, NodeWithAccessModifiers, NodeWithPublicModifier, NodeWithModifiers, NodeWithPrivateModifier, NodeWithProtectedModifier, NodeWithAbstractModifier, NodeWithStaticModifier, NodeWithFinalModifier, NodeWithStrictfpModifier, Resolvable
{
	private Type type;

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private BlockStmt body;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public MethodDeclaration(NodeList modifiers, Type type, string name)
		: this(null, modifiers, new NodeList(), new NodeList(), type, new SimpleName(name), new NodeList(), new NodeList(), new BlockStmt(), null)
	{
	}

	
	
	
	public virtual MethodDeclaration setType(Type type)
	{
		Utils.assertNotNull(type);
		if (type == this.type)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE, this.type, type);
		if (this.type != null)
		{
			this.type.setParentNode(null);
		}
		this.type = type;
		setAsParentNodeOf(type);
		return this;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Parameter addAndGetParameter(string P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}

	
		
	public virtual Optional getBody()
	{
		Optional result = Optional.ofNullable(body);
		
		return result;
	}

	public virtual Type getType()
	{
		return type;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node addParameter(string P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setType(string P_0)
	{
		return NodeWithType._003Cdefault_003EsetType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node addModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EaddModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Parameter getParameter(int P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameter(this, P_0);
	}

	
	
	
	public virtual MethodDeclaration setBody(BlockStmt body)
	{
		if (body == this.body)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EBODY, this.body, body);
		if (this.body != null)
		{
			this.body.setParentNode(null);
		}
		this.body = body;
		setAsParentNodeOf(body);
		return this;
	}

	
	
	public MethodDeclaration()
		: this(null, new NodeList(), new NodeList(), new NodeList(), new ClassOrInterfaceType(), new SimpleName(), new NodeList(), new NodeList(), new BlockStmt(), null)
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setName(string P_0)
	{
		return NodeWithSimpleName._003Cdefault_003EsetName(this, P_0);
	}

	
		
	
	public new virtual MethodDeclaration setModifiers(NodeList modifiers)
	{
		return (MethodDeclaration)base.setModifiers(modifiers);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasParametersOfType(Class[] P_0)
	{
		return NodeWithParameters._003Cdefault_003EhasParametersOfType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasParametersOfType(string[] P_0)
	{
		return NodeWithParameters._003Cdefault_003EhasParametersOfType(this, P_0);
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public MethodDeclaration(TokenRange tokenRange, NodeList modifiers, NodeList annotations, NodeList typeParameters, Type type, SimpleName name, NodeList parameters, NodeList thrownExceptions, BlockStmt body, ReceiverParameter receiverParameter)
		: base(tokenRange, modifiers, annotations, typeParameters, name, parameters, thrownExceptions, receiverParameter)
	{
		setType(type);
		setBody(body);
		customInitialization();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override AccessSpecifier getAccessSpecifier()
	{
		return NodeWithModifiers._003Cdefault_003EgetAccessSpecifier(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isStatic()
	{
		return NodeWithStaticModifier._003Cdefault_003EisStatic(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isAbstract()
	{
		return NodeWithAbstractModifier._003Cdefault_003EisAbstract(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isFinal()
	{
		return NodeWithFinalModifier._003Cdefault_003EisFinal(this);
	}

	
	
	public virtual bool isNative()
	{
		bool result = hasModifier(Modifier.Keyword.___003C_003ENATIVE);
		
		return result;
	}

	
	
	public virtual bool isSynchronized()
	{
		bool result = hasModifier(Modifier.Keyword.___003C_003ESYNCHRONIZED);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasModifier(Modifier.Keyword P_0)
	{
		return NodeWithModifiers._003Cdefault_003EhasModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setModifier(Modifier.Keyword P_0, bool P_1)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifier(this, P_0, P_1);
	}

	
	
	public virtual MethodDeclaration removeBody()
	{
		MethodDeclaration result = setBody(null);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual MethodDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmethodDeclarationMetaModel;
	}

	
	
	public new virtual MethodDeclaration clone()
	{
		return (MethodDeclaration)accept(new CloneVisitor(), null);
	}

	
		
	
	public new virtual MethodDeclaration setTypeParameters(NodeList typeParameters)
	{
		return (MethodDeclaration)base.setTypeParameters(typeParameters);
	}

	
		
	
	public new virtual MethodDeclaration setThrownExceptions(NodeList thrownExceptions)
	{
		return (MethodDeclaration)base.setThrownExceptions(thrownExceptions);
	}

	
		
	
	public new virtual MethodDeclaration setParameters(NodeList parameters)
	{
		return (MethodDeclaration)base.setParameters(parameters);
	}

	
	
	
	public new virtual MethodDeclaration setName(SimpleName name)
	{
		return (MethodDeclaration)base.setName(name);
	}

	
	
	public virtual ResolvedMethodDeclaration resolve()
	{
		return (ResolvedMethodDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedMethodDeclaration>.Value);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public MethodDeclaration(NodeList modifiers, string name, Type type, NodeList parameters)
		: this(null, modifiers, new NodeList(), new NodeList(), type, new SimpleName(name), parameters, new NodeList(), new BlockStmt(), null)
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public MethodDeclaration(NodeList modifiers, NodeList annotations, NodeList typeParameters, Type type, SimpleName name, NodeList parameters, NodeList thrownExceptions, BlockStmt body)
		: this(null, modifiers, annotations, typeParameters, type, name, parameters, thrownExceptions, body, null)
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		(Modifiers)0
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public MethodDeclaration(NodeList modifiers, NodeList annotations, NodeList typeParameters, Type type, SimpleName name, NodeList parameters, NodeList thrownExceptions, BlockStmt body, ReceiverParameter receiverParameter)
		: this(null, modifiers, annotations, typeParameters, type, name, parameters, thrownExceptions, body, receiverParameter)
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		159, 96, 134, 102, 102, 104, 120, 104, 140, 104,
		140, 104, 140, 104, 140, 104, 172, 119, 108, 109,
		108, 99, 127, 8, 100, 133, 140, 99, 149, 120,
		105, 172, 101, 108, 110
	})]
	public override string getDeclarationAsString(bool includingModifiers, bool includingThrows, bool includingParameterName)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (includingModifiers)
		{
			AccessSpecifier accessSpecifier = getAccessSpecifier();
			stringBuilder.append(accessSpecifier.asString()).append(" ");
			if (isStatic())
			{
				stringBuilder.append("static ");
			}
			if (isAbstract())
			{
				stringBuilder.append("abstract ");
			}
			if (isFinal())
			{
				stringBuilder.append("final ");
			}
			if (isNative())
			{
				stringBuilder.append("native ");
			}
			if (isSynchronized())
			{
				stringBuilder.append("synchronized ");
			}
		}
		stringBuilder.append(getType().toString(Node.___003C_003EprettyPrinterNoCommentsConfiguration));
		stringBuilder.append(" ");
		stringBuilder.append(getName());
		stringBuilder.append("(");
		int num = 1;
		Iterator iterator = getParameters().iterator();
		while (iterator.hasNext())
		{
			Parameter parameter = (Parameter)iterator.next();
			if (num != 0)
			{
				num = 0;
			}
			else
			{
				stringBuilder.append(", ");
			}
			if (includingParameterName)
			{
				stringBuilder.append(parameter.toString(Node.___003C_003EprettyPrinterNoCommentsConfiguration));
				continue;
			}
			stringBuilder.append(parameter.getType().toString(Node.___003C_003EprettyPrinterNoCommentsConfiguration));
			if (parameter.isVarArgs())
			{
				stringBuilder.append("...");
			}
		}
		stringBuilder.append(")");
		stringBuilder.append(appendThrowsIfRequested(includingThrows));
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	public virtual string toDescriptor()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append("(");
		for (int i = 0; i < getParameters().size(); i++)
		{
			stringBuilder.append(getParameter(i).getType().toDescriptor());
		}
		stringBuilder.append(")");
		stringBuilder.append(getType().toDescriptor());
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	public virtual bool isDefault()
	{
		bool result = hasModifier(Modifier.Keyword.___003C_003EDEFAULT);
		
		return result;
	}

	
	
	
	public virtual MethodDeclaration setNative(bool set)
	{
		return (MethodDeclaration)setModifier(Modifier.Keyword.___003C_003ENATIVE, set);
	}

	
	
	
	public virtual MethodDeclaration setSynchronized(bool set)
	{
		return (MethodDeclaration)setModifier(Modifier.Keyword.___003C_003ESYNCHRONIZED, set);
	}

	
	
	
	public virtual MethodDeclaration setDefault(bool set)
	{
		return (MethodDeclaration)setModifier(Modifier.Keyword.___003C_003EDEFAULT, set);
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (body != null && node == body)
		{
			removeBody();
			return true;
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 193, 99, 130, 104, 105, 109, 162, 105, 109,
		130
	})]
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (body != null && node == body)
		{
			setBody((BlockStmt)replacementNode);
			return true;
		}
		if (node == type)
		{
			setType((Type)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isMethodDeclaration()
	{
		return true;
	}

	public override MethodDeclaration asMethodDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifMethodDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toMethodDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual CallableDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		MethodDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003Eclone()
	{
		MethodDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003EsetTypeParameters(NodeList typeParameters)
	{
		MethodDeclaration result = setTypeParameters(typeParameters);
		
		return result;
	}

	
	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003EsetThrownExceptions(NodeList thrownExceptions)
	{
		MethodDeclaration result = setThrownExceptions(thrownExceptions);
		
		return result;
	}

	
	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003EsetParameters(NodeList parameters)
	{
		MethodDeclaration result = setParameters(parameters);
		
		return result;
	}

	
	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003EsetName(SimpleName name)
	{
		MethodDeclaration result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		MethodDeclaration result = setModifiers(modifiers);
		
		return result;
	}

	
	
	
	
	
	public override Node _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		MethodDeclaration result = setModifiers(modifiers);
		
		return result;
	}

	
	
	
	
	
	public override Node _003Cbridge_003EsetName(SimpleName name)
	{
		MethodDeclaration result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public override Node _003Cbridge_003EsetParameters(NodeList parameters)
	{
		MethodDeclaration result = setParameters(parameters);
		
		return result;
	}

	
	
	
	
	
	public override Node _003Cbridge_003EsetThrownExceptions(NodeList thrownExceptions)
	{
		MethodDeclaration result = setThrownExceptions(thrownExceptions);
		
		return result;
	}

	
	
	
	
	
	public override Node _003Cbridge_003EsetTypeParameters(NodeList typeParameters)
	{
		MethodDeclaration result = setTypeParameters(typeParameters);
		
		return result;
	}

	
	
	
	
	public override BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		MethodDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override BodyDeclaration _003Cbridge_003Eclone()
	{
		MethodDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		MethodDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		MethodDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		MethodDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetType(Type type)
	{
		MethodDeclaration result = setType(type);
		
		return result;
	}

	
	
	
	
	public virtual Node _003Cbridge_003EremoveBody()
	{
		MethodDeclaration result = removeBody();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetBody(BlockStmt body)
	{
		MethodDeclaration result = setBody(body);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedMethodDeclaration result = resolve();
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setType(Class P_0)
	{
		return NodeWithType._003Cdefault_003EsetType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getTypeAsString()
	{
		return NodeWithType._003Cdefault_003EgetTypeAsString(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BlockStmt createBody()
	{
		return NodeWithOptionalBlockStmt._003Cdefault_003EcreateBody(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Optional getJavadocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadocComment(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Optional getJavadoc()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadoc(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setJavadocComment(string P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setJavadocComment(JavadocComment P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setJavadocComment(string P_0, Javadoc P_1)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setJavadocComment(Javadoc P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool removeJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EremoveJavaDocComment(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EhasJavaDocComment(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override string getDeclarationAsString()
	{
		return NodeWithDeclaration._003Cdefault_003EgetDeclarationAsString(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override string getDeclarationAsString(bool P_0, bool P_1)
	{
		return NodeWithDeclaration._003Cdefault_003EgetDeclarationAsString(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override NameExpr getNameAsExpression()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsExpression(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setParameter(int P_0, Parameter P_1)
	{
		return NodeWithParameters._003Cdefault_003EsetParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node addParameter(Type P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node addParameter(Class P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node addParameter(Parameter P_0)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Parameter addAndGetParameter(Type P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Parameter addAndGetParameter(Class P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Parameter addAndGetParameter(Parameter P_0)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Optional getParameterByName(string P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByName(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Optional getParameterByType(string P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Optional getParameterByType(Class P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ReferenceType getThrownException(int P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EgetThrownException(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node addThrownException(ReferenceType P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EaddThrownException(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node addThrownException(Class P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EaddThrownException(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isThrown(Class P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EisThrown(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isThrown(string P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EisThrown(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override TypeParameter getTypeParameter(int P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EgetTypeParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setTypeParameter(int P_0, TypeParameter P_1)
	{
		return NodeWithTypeParameters._003Cdefault_003EsetTypeParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node addTypeParameter(TypeParameter P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EaddTypeParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node addTypeParameter(string P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EaddTypeParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isGeneric()
	{
		return NodeWithTypeParameters._003Cdefault_003EisGeneric(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node removeModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EremoveModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setModifiers(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifiers(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isPublic()
	{
		return NodeWithPublicModifier._003Cdefault_003EisPublic(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setPublic(bool P_0)
	{
		return NodeWithPublicModifier._003Cdefault_003EsetPublic(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isPrivate()
	{
		return NodeWithPrivateModifier._003Cdefault_003EisPrivate(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setPrivate(bool P_0)
	{
		return NodeWithPrivateModifier._003Cdefault_003EsetPrivate(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isProtected()
	{
		return NodeWithProtectedModifier._003Cdefault_003EisProtected(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setProtected(bool P_0)
	{
		return NodeWithProtectedModifier._003Cdefault_003EsetProtected(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setAbstract(bool P_0)
	{
		return NodeWithAbstractModifier._003Cdefault_003EsetAbstract(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setStatic(bool P_0)
	{
		return NodeWithStaticModifier._003Cdefault_003EsetStatic(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setFinal(bool P_0)
	{
		return NodeWithFinalModifier._003Cdefault_003EsetFinal(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isStrictfp()
	{
		return NodeWithStrictfpModifier._003Cdefault_003EisStrictfp(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setStrictfp(bool P_0)
	{
		return NodeWithStrictfpModifier._003Cdefault_003EsetStrictfp(this, P_0);
	}

	
	static MethodDeclaration()
	{
		CallableDeclaration.___003Cclinit_003E();
	}

	Node NodeWithType.NodeWithType_003A_003AsetType(Type P_0)
	{
		return _003Cbridge_003EsetType(P_0);
	}

	Node NodeWithOptionalBlockStmt.NodeWithOptionalBlockStmt_003A_003AsetBody(BlockStmt P_0)
	{
		return _003Cbridge_003EsetBody(P_0);
	}

	Node NodeWithOptionalBlockStmt.NodeWithOptionalBlockStmt_003A_003AremoveBody()
	{
		return _003Cbridge_003EremoveBody();
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return this._003Cbridge_003EsetName(P_0);
	}

	Node NodeWithParameters.NodeWithParameters_003A_003AsetParameters(NodeList P_0)
	{
		return this._003Cbridge_003EsetParameters(P_0);
	}

	Node NodeWithThrownExceptions.NodeWithThrownExceptions_003A_003AsetThrownExceptions(NodeList P_0)
	{
		return this._003Cbridge_003EsetThrownExceptions(P_0);
	}

	Node NodeWithTypeParameters.NodeWithTypeParameters_003A_003AsetTypeParameters(NodeList P_0)
	{
		return this._003Cbridge_003EsetTypeParameters(P_0);
	}

	Node NodeWithModifiers.NodeWithModifiers_003A_003AsetModifiers(NodeList P_0)
	{
		return this._003Cbridge_003EsetModifiers(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
