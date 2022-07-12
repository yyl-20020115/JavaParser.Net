using System.ComponentModel;

using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.nodeTypes.modifiers;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.javadoc;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.body;

[Implements(new string[]
{
	"com.github.javaparser.ast.nodeTypes.modifiers.NodeWithAccessModifiers", "com.github.javaparser.ast.nodeTypes.NodeWithDeclaration", "com.github.javaparser.ast.nodeTypes.NodeWithSimpleName", "com.github.javaparser.ast.nodeTypes.NodeWithParameters", "com.github.javaparser.ast.nodeTypes.NodeWithThrownExceptions", "com.github.javaparser.ast.nodeTypes.NodeWithTypeParameters", "com.github.javaparser.ast.nodeTypes.NodeWithJavadoc", "com.github.javaparser.ast.nodeTypes.modifiers.NodeWithAbstractModifier", "com.github.javaparser.ast.nodeTypes.modifiers.NodeWithStaticModifier", "com.github.javaparser.ast.nodeTypes.modifiers.NodeWithFinalModifier",
	"com.github.javaparser.ast.nodeTypes.modifiers.NodeWithStrictfpModifier"
})]
public abstract class CallableDeclaration : BodyDeclaration, NodeWithAccessModifiers, NodeWithPublicModifier, NodeWithModifiers, NodeWithPrivateModifier, NodeWithProtectedModifier, NodeWithDeclaration, NodeWithSimpleName, NodeWithParameters, NodeWithThrownExceptions, NodeWithTypeParameters, NodeWithJavadoc, NodeWithAbstractModifier, NodeWithStaticModifier, NodeWithFinalModifier, NodeWithStrictfpModifier
{
	
	
	
	
	internal new class _1
	{
		_1()
		{
			throw null;
		}
	}

	public class Signature
	{
		
		private sealed class ___003C_003EAnon0 : Function
		{
			internal ___003C_003EAnon0()
			{
			}

			public object apply(object P_0)
			{
				string result = ((Type)P_0).asString();
				
				return result;
			}

			
			public Function compose(Function P_0)
			{
				return Function._003Cdefault_003Ecompose(this, P_0);
			}

			
			public Function andThen(Function P_0)
			{
				return Function._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		private string name;

		
				private List parameterTypes;

		
		
		
		public override bool Equals(object o)
		{
			if (this == o)
			{
				return true;
			}
			if (o == null || ((object)this).GetType() != o.GetType())
			{
				return false;
			}
			Signature signature = (Signature)o;
			if (!String.instancehelper_equals(name, signature.name))
			{
				return false;
			}
			if (!parameterTypes.equals(signature.parameterTypes))
			{
				return false;
			}
			return true;
		}

		
		
		
		internal Signature(string P_0, List P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		
				
		
		private Signature(string name, List parameterTypes)
		{
			this.name = name;
			this.parameterTypes = parameterTypes;
		}

		
		
		public virtual string asString()
		{
			Stream stream = parameterTypes.stream().map(new ___003C_003EAnon0());
			string text = new StringBuilder().append(name).append("(").ToString();
			object __003Cref_003E = ")";
			object __003Cref_003E2 = text;
			CharSequence charSequence = default(CharSequence);
			object obj = (charSequence.___003Cref_003E = ", ");
			CharSequence delimiter = charSequence;
			obj = (charSequence.___003Cref_003E = __003Cref_003E2);
			CharSequence prefix = charSequence;
			obj = (charSequence.___003Cref_003E = __003Cref_003E);
			return (string)stream.collect(Collectors.joining(delimiter, prefix, charSequence));
		}

		public virtual string getName()
		{
			return name;
		}

				public virtual List getParameterTypes()
		{
			return parameterTypes;
		}

		
		
		public override int GetHashCode()
		{
			int num = String.instancehelper_hashCode(name);
			return 31 * num + parameterTypes.GetHashCode();
		}

		
		
		public override string ToString()
		{
			string result = asString();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly CallableDeclaration arg_00241;

		internal ___003C_003EAnon0(CallableDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Type typeWithVarargsAsArray = arg_00241.getTypeWithVarargsAsArray((Parameter)P_0);
			
			return typeWithVarargsAsArray;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly CallableDeclaration arg_00241;

		internal ___003C_003EAnon1(CallableDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Type result = arg_00241.stripGenerics((Type)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Function
	{
		private readonly CallableDeclaration arg_00241;

		internal ___003C_003EAnon2(CallableDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Type result = arg_00241.stripAnnotations((Type)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

		private NodeList modifiers;

		private NodeList typeParameters;

	private SimpleName name;

		private NodeList parameters;

		private NodeList thrownExceptions;

	
	private ReceiverParameter receiverParameter;

	
	
	protected internal new static void ___003Cclinit_003E()
	{
	}

	
	
	public virtual Signature getSignature()
	{
		Signature result = new Signature(getName().getIdentifier(), (List)getParameters().stream().map(new ___003C_003EAnon0(this)).map(new ___003C_003EAnon1(this))
			.map(new ___003C_003EAnon2(this))
			.collect(Collectors.toList()), null);
		
		return result;
	}


	public virtual Optional getJavadocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadocComment(this);
	}


	public virtual Node setJavadocComment(JavadocComment P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}

		public virtual NodeList getParameters()
	{
		return parameters;
	}


	public virtual string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}


	public virtual Node setPublic(bool P_0)
	{
		return NodeWithPublicModifier._003Cdefault_003EsetPublic(this, P_0);
	}


	public virtual Node setName(string P_0)
	{
		return NodeWithSimpleName._003Cdefault_003EsetName(this, P_0);
	}


	public virtual Node addParameter(Class P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}


	public virtual Node setJavadocComment(string P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}


	public virtual Node addParameter(string P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}


	public virtual Parameter addAndGetParameter(string P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}


	public virtual Node addModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EaddModifier(this, P_0);
	}


	public virtual Parameter getParameter(int P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameter(this, P_0);
	}


	public virtual bool hasParametersOfType(Class[] P_0)
	{
		return NodeWithParameters._003Cdefault_003EhasParametersOfType(this, P_0);
	}


	public virtual bool hasParametersOfType(string[] P_0)
	{
		return NodeWithParameters._003Cdefault_003EhasParametersOfType(this, P_0);
	}

	
		
	
	public CallableDeclaration(TokenRange tokenRange, NodeList modifiers, NodeList annotations, NodeList typeParameters, SimpleName name, NodeList parameters, NodeList thrownExceptions, ReceiverParameter receiverParameter)
		: base(tokenRange, annotations)
	{
		setModifiers(modifiers);
		setTypeParameters(typeParameters);
		setName(name);
		setParameters(parameters);
		setThrownExceptions(thrownExceptions);
		setReceiverParameter(receiverParameter);
		customInitialization();
	}

	
		
	
	public virtual CallableDeclaration setModifiers(NodeList modifiers)
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

	
		
	
	public virtual CallableDeclaration setTypeParameters(NodeList typeParameters)
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

	
		
	
	public virtual CallableDeclaration setName(SimpleName name)
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

	
		
	
	public virtual CallableDeclaration setParameters(NodeList parameters)
	{
		Utils.assertNotNull(parameters);
		if (parameters == this.parameters)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EPARAMETERS, this.parameters, parameters);
		if (this.parameters != null)
		{
			this.parameters.setParentNode(null);
		}
		this.parameters = parameters;
		setAsParentNodeOf(parameters);
		return this;
	}

	
		
	
	public virtual CallableDeclaration setThrownExceptions(NodeList thrownExceptions)
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

	
		
	
	public virtual CallableDeclaration setReceiverParameter(ReceiverParameter receiverParameter)
	{
		if (receiverParameter == this.receiverParameter)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ERECEIVER_PARAMETER, this.receiverParameter, receiverParameter);
		if (this.receiverParameter != null)
		{
			this.receiverParameter.setParentNode(null);
		}
		this.receiverParameter = receiverParameter;
		setAsParentNodeOf(receiverParameter);
		return this;
	}

		public virtual NodeList getThrownExceptions()
	{
		return thrownExceptions;
	}

	
	
	public virtual CallableDeclaration removeReceiverParameter()
	{
		CallableDeclaration result = setReceiverParameter(null);
		
		return result;
	}

	public virtual SimpleName getName()
	{
		return name;
	}

	
	
	public virtual bool isVariableArityMethod()
	{
		return (getParameters().size() > 0 && ((Parameter)getParameters().getLast().get()).isVarArgs()) ? true : false;
	}

	
	
	public new virtual CallableDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EcallableDeclarationMetaModel;
	}

	
		
	public new virtual CallableDeclaration clone()
	{
		return (CallableDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	
	private Type getTypeWithVarargsAsArray(Parameter p)
	{
		Type type = p.getType().clone();
		if (p.isVarArgs())
		{
			ArrayType.___003Cclinit_003E();
			type = new ArrayType(type);
		}
		return type;
	}

	
	
	
	private Type stripGenerics(Type type)
	{
		if (type is NodeWithTypeArguments)
		{
			((NodeWithTypeArguments)type).setTypeArguments((NodeList)null);
		}
		return type;
	}

	
	
	
	private Type stripAnnotations(Type type)
	{
		if (type is NodeWithAnnotations)
		{
			((NodeWithAnnotations)type).setAnnotations(new NodeList());
		}
		return type;
	}

	
		
	
	
	internal CallableDeclaration(NodeList modifiers, NodeList annotations, NodeList typeParameters, SimpleName name, NodeList parameters, NodeList thrownExceptions, ReceiverParameter receiverParameter)
		: this(null, modifiers, annotations, typeParameters, name, parameters, thrownExceptions, receiverParameter)
	{
	}

		public virtual NodeList getModifiers()
	{
		return modifiers;
	}

		public virtual NodeList getTypeParameters()
	{
		return typeParameters;
	}

	
	
	
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
		for (int i = 0; i < parameters.size(); i++)
		{
			if (parameters.get(i) == node)
			{
				parameters.remove(i);
				return true;
			}
		}
		if (receiverParameter != null && node == receiverParameter)
		{
			removeReceiverParameter();
			return true;
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

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
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
		for (int i = 0; i < parameters.size(); i++)
		{
			if (parameters.get(i) == node)
			{
				parameters.set(i, (Parameter)replacementNode);
				return true;
			}
		}
		if (receiverParameter != null && node == receiverParameter)
		{
			setReceiverParameter((ReceiverParameter)replacementNode);
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

	public override bool isCallableDeclaration()
	{
		return true;
	}

	public override CallableDeclaration asCallableDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifCallableDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public virtual Optional getReceiverParameter()
	{
		Optional result = Optional.ofNullable(receiverParameter);
		
		return result;
	}

	
		
	public override Optional toCallableDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	public virtual bool isFixedArityMethod()
	{
		return (!isVariableArityMethod()) ? true : false;
	}

	
	
	
	
	public new virtual BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		CallableDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual BodyDeclaration _003Cbridge_003Eclone()
	{
		CallableDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		CallableDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		CallableDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		CallableDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		CallableDeclaration result = setModifiers(modifiers);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		CallableDeclaration result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetParameters(NodeList parameters)
	{
		CallableDeclaration result = setParameters(parameters);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetThrownExceptions(NodeList thrownExceptions)
	{
		CallableDeclaration result = setThrownExceptions(thrownExceptions);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetTypeParameters(NodeList typeParameters)
	{
		CallableDeclaration result = setTypeParameters(typeParameters);
		
		return result;
	}


	public virtual Node removeModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EremoveModifier(this, P_0);
	}


	public virtual Node setModifier(Modifier.Keyword P_0, bool P_1)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifier(this, P_0, P_1);
	}


	public virtual bool hasModifier(Modifier.Keyword P_0)
	{
		return NodeWithModifiers._003Cdefault_003EhasModifier(this, P_0);
	}


	public virtual Node setModifiers(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifiers(this, P_0);
	}


	public virtual AccessSpecifier getAccessSpecifier()
	{
		return NodeWithModifiers._003Cdefault_003EgetAccessSpecifier(this);
	}


	public virtual bool isPublic()
	{
		return NodeWithPublicModifier._003Cdefault_003EisPublic(this);
	}


	public virtual bool isPrivate()
	{
		return NodeWithPrivateModifier._003Cdefault_003EisPrivate(this);
	}


	public virtual Node setPrivate(bool P_0)
	{
		return NodeWithPrivateModifier._003Cdefault_003EsetPrivate(this, P_0);
	}


	public virtual bool isProtected()
	{
		return NodeWithProtectedModifier._003Cdefault_003EisProtected(this);
	}


	public virtual Node setProtected(bool P_0)
	{
		return NodeWithProtectedModifier._003Cdefault_003EsetProtected(this, P_0);
	}


	public virtual string getDeclarationAsString()
	{
		return NodeWithDeclaration._003Cdefault_003EgetDeclarationAsString(this);
	}


	public virtual string getDeclarationAsString(bool P_0, bool P_1)
	{
		return NodeWithDeclaration._003Cdefault_003EgetDeclarationAsString(this, P_0, P_1);
	}


	public abstract string getDeclarationAsString(bool P_0, bool P_1, bool P_2);


	public virtual NameExpr getNameAsExpression()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsExpression(this);
	}


	public virtual Node setParameter(int P_0, Parameter P_1)
	{
		return NodeWithParameters._003Cdefault_003EsetParameter(this, P_0, P_1);
	}


	public virtual Node addParameter(Type P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}


	public virtual Node addParameter(Parameter P_0)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0);
	}


	public virtual Parameter addAndGetParameter(Type P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}


	public virtual Parameter addAndGetParameter(Class P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}


	public virtual Parameter addAndGetParameter(Parameter P_0)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0);
	}


	public virtual Optional getParameterByName(string P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByName(this, P_0);
	}


	public virtual Optional getParameterByType(string P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByType(this, P_0);
	}


	public virtual Optional getParameterByType(Class P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByType(this, P_0);
	}


	public virtual ReferenceType getThrownException(int P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EgetThrownException(this, P_0);
	}


	public virtual Node addThrownException(ReferenceType P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EaddThrownException(this, P_0);
	}


	public virtual Node addThrownException(Class P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EaddThrownException(this, P_0);
	}


	public virtual bool isThrown(Class P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EisThrown(this, P_0);
	}


	public virtual bool isThrown(string P_0)
	{
		return NodeWithThrownExceptions._003Cdefault_003EisThrown(this, P_0);
	}


	public virtual TypeParameter getTypeParameter(int P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EgetTypeParameter(this, P_0);
	}


	public virtual Node setTypeParameter(int P_0, TypeParameter P_1)
	{
		return NodeWithTypeParameters._003Cdefault_003EsetTypeParameter(this, P_0, P_1);
	}


	public virtual Node addTypeParameter(TypeParameter P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EaddTypeParameter(this, P_0);
	}


	public virtual Node addTypeParameter(string P_0)
	{
		return NodeWithTypeParameters._003Cdefault_003EaddTypeParameter(this, P_0);
	}


	public virtual bool isGeneric()
	{
		return NodeWithTypeParameters._003Cdefault_003EisGeneric(this);
	}


	public virtual Optional getJavadoc()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadoc(this);
	}


	public virtual Node setJavadocComment(string P_0, Javadoc P_1)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0, P_1);
	}


	public virtual Node setJavadocComment(Javadoc P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}


	public virtual bool removeJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EremoveJavaDocComment(this);
	}


	public virtual bool hasJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EhasJavaDocComment(this);
	}


	public virtual bool isAbstract()
	{
		return NodeWithAbstractModifier._003Cdefault_003EisAbstract(this);
	}


	public virtual Node setAbstract(bool P_0)
	{
		return NodeWithAbstractModifier._003Cdefault_003EsetAbstract(this, P_0);
	}


	public virtual bool isStatic()
	{
		return NodeWithStaticModifier._003Cdefault_003EisStatic(this);
	}


	public virtual Node setStatic(bool P_0)
	{
		return NodeWithStaticModifier._003Cdefault_003EsetStatic(this, P_0);
	}


	public virtual bool isFinal()
	{
		return NodeWithFinalModifier._003Cdefault_003EisFinal(this);
	}


	public virtual Node setFinal(bool P_0)
	{
		return NodeWithFinalModifier._003Cdefault_003EsetFinal(this, P_0);
	}


	public virtual bool isStrictfp()
	{
		return NodeWithStrictfpModifier._003Cdefault_003EisStrictfp(this);
	}


	public virtual Node setStrictfp(bool P_0)
	{
		return NodeWithStrictfpModifier._003Cdefault_003EsetStrictfp(this, P_0);
	}

	
	static CallableDeclaration()
	{
		BodyDeclaration.___003Cclinit_003E();
	}

	Node NodeWithModifiers.NodeWithModifiers_003A_003AsetModifiers(NodeList P_0)
	{
		return _003Cbridge_003EsetModifiers(P_0);
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	Node NodeWithParameters.NodeWithParameters_003A_003AsetParameters(NodeList P_0)
	{
		return _003Cbridge_003EsetParameters(P_0);
	}

	Node NodeWithThrownExceptions.NodeWithThrownExceptions_003A_003AsetThrownExceptions(NodeList P_0)
	{
		return _003Cbridge_003EsetThrownExceptions(P_0);
	}

	Node NodeWithTypeParameters.NodeWithTypeParameters_003A_003AsetTypeParameters(NodeList P_0)
	{
		return _003Cbridge_003EsetTypeParameters(P_0);
	}
}
