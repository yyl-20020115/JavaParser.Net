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


public class CompactConstructorDeclaration : BodyDeclaration, NodeWithBlockStmt, NodeWithAccessModifiers, NodeWithPublicModifier, NodeWithModifiers, NodeWithPrivateModifier, NodeWithProtectedModifier, NodeWithJavadoc, NodeWithSimpleName, NodeWithThrownExceptions, NodeWithTypeParameters, Resolvable
{
		private NodeList modifiers;

	private BlockStmt body;

		private NodeList typeParameters;

	private SimpleName name;

		private NodeList thrownExceptions;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public CompactConstructorDeclaration(TokenRange tokenRange, NodeList modifiers, NodeList annotations, NodeList typeParameters, SimpleName name, NodeList thrownExceptions, BlockStmt body)
		: base(tokenRange, annotations)
	{
		setModifiers(modifiers);
		setTypeParameters(typeParameters);
		setName(name);
		setThrownExceptions(thrownExceptions);
		setBody(body);
		customInitialization();
	}

	
		
	
	public virtual CompactConstructorDeclaration setModifiers(NodeList modifiers)
	{
		Utils.assertNotNull(modifiers);
		if (modifiers == this.modifiers)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EMODIFIERS, this.modifiers, modifiers);
		if (this.modifiers != null)
		{
			this.modifiers.setParentNode(null);
		}
		this.modifiers = modifiers;
		setAsParentNodeOf(modifiers);
		return this;
	}

	
		
	
	public virtual CompactConstructorDeclaration setTypeParameters(NodeList typeParameters)
	{
		Utils.assertNotNull(typeParameters);
		if (typeParameters == this.typeParameters)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE_PARAMETERS, this.typeParameters, typeParameters);
		if (this.typeParameters != null)
		{
			this.typeParameters.setParentNode(null);
		}
		this.typeParameters = typeParameters;
		setAsParentNodeOf(typeParameters);
		return this;
	}

	
	
	
	public virtual CompactConstructorDeclaration setName(SimpleName name)
	{
		Utils.assertNotNull(name);
		if (name == this.name)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ENAME, this.name, name);
		if (this.name != null)
		{
			this.name.setParentNode(null);
		}
		this.name = name;
		setAsParentNodeOf(name);
		return this;
	}

	
		
	
	public virtual CompactConstructorDeclaration setThrownExceptions(NodeList thrownExceptions)
	{
		Utils.assertNotNull(thrownExceptions);
		if (thrownExceptions == this.thrownExceptions)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETHROWN_EXCEPTIONS, this.thrownExceptions, thrownExceptions);
		if (this.thrownExceptions != null)
		{
			this.thrownExceptions.setParentNode(null);
		}
		this.thrownExceptions = thrownExceptions;
		setAsParentNodeOf(thrownExceptions);
		return this;
	}

	
	
	
	public virtual CompactConstructorDeclaration setBody(BlockStmt body)
	{
		Utils.assertNotNull(body);
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

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual AccessSpecifier getAccessSpecifier()
	{
		return NodeWithModifiers._003Cdefault_003EgetAccessSpecifier(this);
	}

	public virtual SimpleName getName()
	{
		return name;
	}

	
	
	[LineNumberTable(new byte[]
	{
		159, 79, 66, 102, 102, 98, 127, 2, 99, 98,
		142, 140, 115, 130
	})]
	protected internal virtual string appendThrowsIfRequested(bool includingThrows)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (includingThrows)
		{
			int num = 1;
			Iterator iterator = getThrownExceptions().iterator();
			while (iterator.hasNext())
			{
				ReferenceType referenceType = (ReferenceType)iterator.next();
				if (num != 0)
				{
					num = 0;
					stringBuilder.append(" throws ");
				}
				else
				{
					stringBuilder.append(", ");
				}
				stringBuilder.append(referenceType.toString(Node.___003C_003EprettyPrinterNoCommentsConfiguration));
			}
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

		public virtual NodeList getThrownExceptions()
	{
		return thrownExceptions;
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

	
	
	public new virtual CompactConstructorDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EcompactConstructorDeclarationMetaModel;
	}

	
	
	public new virtual CompactConstructorDeclaration clone()
	{
		return (CompactConstructorDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedConstructorDeclaration resolve()
	{
		return (ResolvedConstructorDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedConstructorDeclaration>.Value);
	}

	
	
	public CompactConstructorDeclaration()
		: this(null, new NodeList(), new NodeList(), new NodeList(), new SimpleName(), new NodeList(), new BlockStmt())
	{
	}

	
	
	
	public CompactConstructorDeclaration(string name)
		: this(null, new NodeList(new Modifier()), new NodeList(), new NodeList(), new SimpleName(name), new NodeList(), new BlockStmt())
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public CompactConstructorDeclaration(NodeList modifiers, string name)
		: this(null, modifiers, new NodeList(), new NodeList(), new SimpleName(name), new NodeList(), new BlockStmt())
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public CompactConstructorDeclaration(NodeList modifiers, NodeList annotations, NodeList typeParameters, SimpleName name, NodeList thrownExceptions, BlockStmt body)
		: this(null, modifiers, annotations, typeParameters, name, thrownExceptions, body)
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

	public virtual BlockStmt getBody()
	{
		return body;
	}

		public virtual NodeList getModifiers()
	{
		return modifiers;
	}

		public virtual NodeList getTypeParameters()
	{
		return typeParameters;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		159, 83, 132, 102, 99, 103, 151, 109, 108, 98,
		108, 110
	})]
	public virtual string getDeclarationAsString(bool includingModifiers, bool includingThrows, bool includingParameterName)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (includingModifiers)
		{
			AccessSpecifier accessSpecifier = getAccessSpecifier();
			stringBuilder.append(accessSpecifier.asString()).append(" ");
		}
		stringBuilder.append(getName());
		stringBuilder.append("(");
		_ = 1;
		stringBuilder.append(")");
		stringBuilder.append(appendThrowsIfRequested(includingThrows));
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 157, 99, 130, 112, 111, 109, 226, 61, 230,
		70, 112, 111, 109, 226, 61, 230, 70, 112, 111,
		109, 226, 61, 230, 70
	})]
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < modifiers.size(); i++)
		{
			if (modifiers.get(i) == node)
			{
				modifiers.remove(i);
				return true;
			}
		}
		for (int i = 0; i < thrownExceptions.size(); i++)
		{
			if (thrownExceptions.get(i) == node)
			{
				thrownExceptions.remove(i);
				return true;
			}
		}
		for (int i = 0; i < typeParameters.size(); i++)
		{
			if (typeParameters.get(i) == node)
			{
				typeParameters.remove(i);
				return true;
			}
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
		160, 196, 99, 130, 105, 109, 130, 112, 111, 115,
		226, 61, 230, 70, 105, 109, 130, 112, 111, 115,
		226, 61, 230, 70, 112, 111, 115, 226, 61, 230,
		70
	})]
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == body)
		{
			setBody((BlockStmt)replacementNode);
			return true;
		}
		for (int i = 0; i < modifiers.size(); i++)
		{
			if (modifiers.get(i) == node)
			{
				modifiers.set(i, (Modifier)replacementNode);
				return true;
			}
		}
		if (node == name)
		{
			setName((SimpleName)replacementNode);
			return true;
		}
		for (int i = 0; i < thrownExceptions.size(); i++)
		{
			if (thrownExceptions.get(i) == node)
			{
				thrownExceptions.set(i, (ReferenceType)replacementNode);
				return true;
			}
		}
		for (int i = 0; i < typeParameters.size(); i++)
		{
			if (typeParameters.get(i) == node)
			{
				typeParameters.set(i, (TypeParameter)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isCompactConstructorDeclaration()
	{
		return true;
	}

	public override CompactConstructorDeclaration asCompactConstructorDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifCompactConstructorDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toCompactConstructorDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public CompactConstructorDeclaration(TokenRange tokenRange, NodeList annotations, BlockStmt body)
		: base(tokenRange, annotations)
	{
		setBody(body);
		customInitialization();
	}

	
	
	
	
	public new virtual BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		CompactConstructorDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual BodyDeclaration _003Cbridge_003Eclone()
	{
		CompactConstructorDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		CompactConstructorDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		CompactConstructorDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		CompactConstructorDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetBody(BlockStmt body)
	{
		CompactConstructorDeclaration result = setBody(body);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		CompactConstructorDeclaration result = setModifiers(modifiers);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		CompactConstructorDeclaration result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetThrownExceptions(NodeList thrownExceptions)
	{
		CompactConstructorDeclaration result = setThrownExceptions(thrownExceptions);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetTypeParameters(NodeList typeParameters)
	{
		CompactConstructorDeclaration result = setTypeParameters(typeParameters);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedConstructorDeclaration result = resolve();
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BlockStmt createBody()
	{
		return NodeWithBlockStmt._003Cdefault_003EcreateBody(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EaddModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node removeModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EremoveModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setModifier(Modifier.Keyword P_0, bool P_1)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifier(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasModifier(Modifier.Keyword P_0)
	{
		return NodeWithModifiers._003Cdefault_003EhasModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setModifiers(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifiers(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isPublic()
	{
		return NodeWithPublicModifier._003Cdefault_003EisPublic(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setPublic(bool P_0)
	{
		return NodeWithPublicModifier._003Cdefault_003EsetPublic(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isPrivate()
	{
		return NodeWithPrivateModifier._003Cdefault_003EisPrivate(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setPrivate(bool P_0)
	{
		return NodeWithPrivateModifier._003Cdefault_003EsetPrivate(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isProtected()
	{
		return NodeWithProtectedModifier._003Cdefault_003EisProtected(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setProtected(bool P_0)
	{
		return NodeWithProtectedModifier._003Cdefault_003EsetProtected(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getJavadocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadocComment(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getJavadoc()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadoc(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setJavadocComment(string P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setJavadocComment(JavadocComment P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setJavadocComment(string P_0, Javadoc P_1)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setJavadocComment(Javadoc P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool removeJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EremoveJavaDocComment(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EhasJavaDocComment(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setName(string P_0)
	{
		return NodeWithSimpleName._003Cdefault_003EsetName(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual NameExpr getNameAsExpression()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsExpression(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ReferenceType getThrownException(int P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EgetThrownException(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addThrownException(ReferenceType P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EaddThrownException(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addThrownException(Class P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EaddThrownException(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isThrown(Class P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EisThrown(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isThrown(string P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EisThrown(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual TypeParameter getTypeParameter(int P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EgetTypeParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setTypeParameter(int P_0, TypeParameter P_1)
	{
		return NodeWithTypeParameters._003Cdefault_003EsetTypeParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addTypeParameter(TypeParameter P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EaddTypeParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addTypeParameter(string P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EaddTypeParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isGeneric()
	{
		return NodeWithTypeParameters._003Cdefault_003EisGeneric(this);
	}

	
	static CompactConstructorDeclaration()
	{
		BodyDeclaration.___003Cclinit_003E();
	}

	Node NodeWithBlockStmt.NodeWithBlockStmt_003A_003AsetBody(BlockStmt P_0)
	{
		return _003Cbridge_003EsetBody(P_0);
	}

	Node NodeWithModifiers.NodeWithModifiers_003A_003AsetModifiers(NodeList P_0)
	{
		return _003Cbridge_003EsetModifiers(P_0);
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	Node NodeWithThrownExceptions.NodeWithThrownExceptions_003A_003AsetThrownExceptions(NodeList P_0)
	{
		return _003Cbridge_003EsetThrownExceptions(P_0);
	}

	Node NodeWithTypeParameters.NodeWithTypeParameters_003A_003AsetTypeParameters(NodeList P_0)
	{
		return _003Cbridge_003EsetTypeParameters(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
