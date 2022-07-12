using System.ComponentModel;

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

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.body;


public class ConstructorDeclaration : CallableDeclaration, NodeWithBlockStmt, NodeWithAccessModifiers, NodeWithPublicModifier, NodeWithModifiers, NodeWithPrivateModifier, NodeWithProtectedModifier, NodeWithJavadoc, NodeWithSimpleName, NodeWithParameters, NodeWithThrownExceptions, NodeWithTypeParameters, Resolvable
{
	private BlockStmt body;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	public ConstructorDeclaration()
		: this(null, new NodeList(), new NodeList(), new NodeList(), new SimpleName(), new NodeList(), new NodeList(), new BlockStmt(), null)
	{
	}


	public override Node setPublic(bool P_0)
	{
		return NodeWithPublicModifier._003Cdefault_003EsetPublic(this, P_0);
	}


	public override Node setName(string P_0)
	{
		return NodeWithSimpleName._003Cdefault_003EsetName(this, P_0);
	}


	public override Node addParameter(Class P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}


	public override Node setJavadocComment(string P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}

	public virtual BlockStmt getBody()
	{
		return body;
	}


	public override Node addParameter(string P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}

	
		
	
	public new virtual ConstructorDeclaration setModifiers(NodeList modifiers)
	{
		return (ConstructorDeclaration)base.setModifiers(modifiers);
	}

	
	
	
	public new virtual ConstructorDeclaration setName(SimpleName name)
	{
		return (ConstructorDeclaration)base.setName(name);
	}


	public override bool hasParametersOfType(Class[] P_0)
	{
		return NodeWithParameters._003Cdefault_003EhasParametersOfType(this, P_0);
	}


	public override bool hasParametersOfType(string[] P_0)
	{
		return NodeWithParameters._003Cdefault_003EhasParametersOfType(this, P_0);
	}

	
		
	
	public ConstructorDeclaration(TokenRange tokenRange, NodeList modifiers, NodeList annotations, NodeList typeParameters, SimpleName name, NodeList parameters, NodeList thrownExceptions, BlockStmt body, ReceiverParameter receiverParameter)
		: base(tokenRange, modifiers, annotations, typeParameters, name, parameters, thrownExceptions, receiverParameter)
	{
		setBody(body);
		customInitialization();
	}

	
	
	
	public virtual ConstructorDeclaration setBody(BlockStmt body)
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


	public override AccessSpecifier getAccessSpecifier()
	{
		return NodeWithModifiers._003Cdefault_003EgetAccessSpecifier(this);
	}


	public override Parameter getParameter(int P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameter(this, P_0);
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ConstructorDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EconstructorDeclarationMetaModel;
	}

	
	
	public new virtual ConstructorDeclaration clone()
	{
		return (ConstructorDeclaration)accept(new CloneVisitor(), null);
	}

	
		
	
	public new virtual ConstructorDeclaration setTypeParameters(NodeList typeParameters)
	{
		return (ConstructorDeclaration)base.setTypeParameters(typeParameters);
	}

	
		
	
	public new virtual ConstructorDeclaration setThrownExceptions(NodeList thrownExceptions)
	{
		return (ConstructorDeclaration)base.setThrownExceptions(thrownExceptions);
	}

	
		
	
	public new virtual ConstructorDeclaration setParameters(NodeList parameters)
	{
		return (ConstructorDeclaration)base.setParameters(parameters);
	}

	
	
	public virtual ResolvedConstructorDeclaration resolve()
	{
		return (ResolvedConstructorDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedConstructorDeclaration>.Value);
	}

	
	
	
	public ConstructorDeclaration(string name)
		: this(null, new NodeList(new Modifier()), new NodeList(), new NodeList(), new SimpleName(name), new NodeList(), new NodeList(), new BlockStmt(), null)
	{
	}

	
		
	
	public ConstructorDeclaration(NodeList modifiers, string name)
		: this(null, modifiers, new NodeList(), new NodeList(), new SimpleName(name), new NodeList(), new NodeList(), new BlockStmt(), null)
	{
	}

	
		
	
	public ConstructorDeclaration(NodeList modifiers, NodeList annotations, NodeList typeParameters, SimpleName name, NodeList parameters, NodeList thrownExceptions, BlockStmt body)
		: this(null, modifiers, annotations, typeParameters, name, parameters, thrownExceptions, body, null)
	{
	}

	
		
	
	
	public ConstructorDeclaration(NodeList modifiers, NodeList annotations, NodeList typeParameters, SimpleName name, NodeList parameters, NodeList thrownExceptions, BlockStmt body, ReceiverParameter receiverParameter)
		: this(null, modifiers, annotations, typeParameters, name, parameters, thrownExceptions, body, receiverParameter)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	
	public override string getDeclarationAsString(bool includingModifiers, bool includingThrows, bool includingParameterName)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (includingModifiers)
		{
			AccessSpecifier accessSpecifier = getAccessSpecifier();
			stringBuilder.append(accessSpecifier.asString()).append(" ");
		}
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
			}
			else
			{
				stringBuilder.append(parameter.getType().toString(Node.___003C_003EprettyPrinterNoCommentsConfiguration));
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
		stringBuilder.append('(');
		for (int i = 0; i < getParameters().size(); i++)
		{
			stringBuilder.append(getParameter(i).getType().toDescriptor());
		}
		string result = stringBuilder.append(")V").ToString();
		
		return result;
	}

	
	
	
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
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isConstructorDeclaration()
	{
		return true;
	}

	public override ConstructorDeclaration asConstructorDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifConstructorDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toConstructorDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual CallableDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		ConstructorDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003Eclone()
	{
		ConstructorDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003EsetTypeParameters(NodeList typeParameters)
	{
		ConstructorDeclaration result = setTypeParameters(typeParameters);
		
		return result;
	}

	
	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003EsetThrownExceptions(NodeList thrownExceptions)
	{
		ConstructorDeclaration result = setThrownExceptions(thrownExceptions);
		
		return result;
	}

	
	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003EsetParameters(NodeList parameters)
	{
		ConstructorDeclaration result = setParameters(parameters);
		
		return result;
	}

	
	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003EsetName(SimpleName name)
	{
		ConstructorDeclaration result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public new virtual CallableDeclaration _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		ConstructorDeclaration result = setModifiers(modifiers);
		
		return result;
	}

	
	
	
	
	
	public override Node _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		ConstructorDeclaration result = setModifiers(modifiers);
		
		return result;
	}

	
	
	
	
	
	public override Node _003Cbridge_003EsetName(SimpleName name)
	{
		ConstructorDeclaration result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public override Node _003Cbridge_003EsetParameters(NodeList parameters)
	{
		ConstructorDeclaration result = setParameters(parameters);
		
		return result;
	}

	
	
	
	
	
	public override Node _003Cbridge_003EsetThrownExceptions(NodeList thrownExceptions)
	{
		ConstructorDeclaration result = setThrownExceptions(thrownExceptions);
		
		return result;
	}

	
	
	
	
	
	public override Node _003Cbridge_003EsetTypeParameters(NodeList typeParameters)
	{
		ConstructorDeclaration result = setTypeParameters(typeParameters);
		
		return result;
	}

	
	
	
	
	public override BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		ConstructorDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override BodyDeclaration _003Cbridge_003Eclone()
	{
		ConstructorDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ConstructorDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ConstructorDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ConstructorDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetBody(BlockStmt body)
	{
		ConstructorDeclaration result = setBody(body);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedConstructorDeclaration result = resolve();
		
		return result;
	}


	public virtual BlockStmt createBody()
	{
		return NodeWithBlockStmt._003Cdefault_003EcreateBody(this);
	}


	public override Node addModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EaddModifier(this, P_0);
	}


	public override Node removeModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EremoveModifier(this, P_0);
	}


	public override Node setModifier(Modifier.Keyword P_0, bool P_1)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifier(this, P_0, P_1);
	}


	public override bool hasModifier(Modifier.Keyword P_0)
	{
		return NodeWithModifiers._003Cdefault_003EhasModifier(this, P_0);
	}


	public override Node setModifiers(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifiers(this, P_0);
	}


	public override bool isPublic()
	{
		return NodeWithPublicModifier._003Cdefault_003EisPublic(this);
	}


	public override bool isPrivate()
	{
		return NodeWithPrivateModifier._003Cdefault_003EisPrivate(this);
	}


	public override Node setPrivate(bool P_0)
	{
		return NodeWithPrivateModifier._003Cdefault_003EsetPrivate(this, P_0);
	}


	public override bool isProtected()
	{
		return NodeWithProtectedModifier._003Cdefault_003EisProtected(this);
	}


	public override Node setProtected(bool P_0)
	{
		return NodeWithProtectedModifier._003Cdefault_003EsetProtected(this, P_0);
	}


	public override Optional getJavadocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadocComment(this);
	}


	public override Optional getJavadoc()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadoc(this);
	}


	public override Node setJavadocComment(JavadocComment P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}


	public override Node setJavadocComment(string P_0, Javadoc P_1)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0, P_1);
	}


	public override Node setJavadocComment(Javadoc P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}


	public override bool removeJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EremoveJavaDocComment(this);
	}


	public override bool hasJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EhasJavaDocComment(this);
	}


	public override string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}


	public override NameExpr getNameAsExpression()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsExpression(this);
	}


	public override Node setParameter(int P_0, Parameter P_1)
	{
		return NodeWithParameters._003Cdefault_003EsetParameter(this, P_0, P_1);
	}


	public override Node addParameter(Type P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}


	public override Node addParameter(Parameter P_0)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0);
	}


	public override Parameter addAndGetParameter(Type P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}


	public override Parameter addAndGetParameter(Class P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}


	public override Parameter addAndGetParameter(string P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}


	public override Parameter addAndGetParameter(Parameter P_0)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0);
	}


	public override Optional getParameterByName(string P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByName(this, P_0);
	}


	public override Optional getParameterByType(string P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByType(this, P_0);
	}


	public override Optional getParameterByType(Class P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByType(this, P_0);
	}


	public override ReferenceType getThrownException(int P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EgetThrownException(this, P_0);
	}


	public override Node addThrownException(ReferenceType P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EaddThrownException(this, P_0);
	}


	public override Node addThrownException(Class P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EaddThrownException(this, P_0);
	}


	public override bool isThrown(Class P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EisThrown(this, P_0);
	}


	public override bool isThrown(string P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EisThrown(this, P_0);
	}


	public override TypeParameter getTypeParameter(int P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EgetTypeParameter(this, P_0);
	}


	public override Node setTypeParameter(int P_0, TypeParameter P_1)
	{
		return NodeWithTypeParameters._003Cdefault_003EsetTypeParameter(this, P_0, P_1);
	}


	public override Node addTypeParameter(TypeParameter P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EaddTypeParameter(this, P_0);
	}


	public override Node addTypeParameter(string P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EaddTypeParameter(this, P_0);
	}


	public override bool isGeneric()
	{
		return NodeWithTypeParameters._003Cdefault_003EisGeneric(this);
	}

	
	static ConstructorDeclaration()
	{
		CallableDeclaration.___003Cclinit_003E();
	}

	Node NodeWithBlockStmt.NodeWithBlockStmt_003A_003AsetBody(BlockStmt P_0)
	{
		return _003Cbridge_003EsetBody(P_0);
	}

	Node NodeWithModifiers.NodeWithModifiers_003A_003AsetModifiers(NodeList P_0)
	{
		return this._003Cbridge_003EsetModifiers(P_0);
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

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
