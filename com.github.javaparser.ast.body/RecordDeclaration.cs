using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.nodeTypes.modifiers;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.body;


public class RecordDeclaration : TypeDeclaration, NodeWithParameters, NodeWithImplements, NodeWithTypeParameters, NodeWithFinalModifier, NodeWithModifiers, Resolvable
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Boolean result = lambda_0024isLocalRecordDeclaration_00240((Node)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getCompactConstructors_00241((BodyDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			CompactConstructorDeclaration result = lambda_0024getCompactConstructors_00242((BodyDeclaration)P_0);
			
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

		private NodeList typeParameters;

		private NodeList implementedTypes;

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private ReceiverParameter receiverParameter;

		private NodeList parameters;

	
	
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
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public RecordDeclaration(TokenRange tokenRange, NodeList modifiers, NodeList annotations, SimpleName name, NodeList parameters, NodeList typeParameters, NodeList implementedTypes, NodeList members, ReceiverParameter receiverParameter)
		: base(tokenRange, modifiers, annotations, name, members)
	{
		setParameters(parameters);
		setTypeParameters(typeParameters);
		setImplementedTypes(implementedTypes);
		setReceiverParameter(receiverParameter);
		customInitialization();
	}

	
		
	
	public virtual RecordDeclaration setParameters(NodeList parameters)
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

	
		
	
	public virtual RecordDeclaration setTypeParameters(NodeList typeParameters)
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

	
		
	
	public virtual RecordDeclaration setImplementedTypes(NodeList implementedTypes)
	{
		Utils.assertNotNull(implementedTypes);
		if (implementedTypes == this.implementedTypes)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EIMPLEMENTED_TYPES, this.implementedTypes, implementedTypes);
		if (this.implementedTypes != null)
		{
			this.implementedTypes.setParentNode(null);
		}
		this.implementedTypes = implementedTypes;
		setAsParentNodeOf(implementedTypes);
		return this;
	}

	
	
	
	public virtual RecordDeclaration setReceiverParameter(ReceiverParameter receiverParameter)
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

	
	
	public virtual bool isLocalRecordDeclaration()
	{
		bool result = ((Boolean)getParentNode().map(new ___003C_003EAnon0()).orElse(Boolean.valueOf(b: false))).booleanValue();
		
		return result;
	}

	
	
	public virtual RecordDeclaration removeReceiverParameter()
	{
		RecordDeclaration result = setReceiverParameter(null);
		
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

	
	
	public new virtual RecordDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003ErecordDeclarationMetaModel;
	}

	
	
	public new virtual RecordDeclaration clone()
	{
		return (RecordDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	public override ResolvedReferenceTypeDeclaration resolve()
	{
		return (ResolvedReferenceTypeDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
	}

	
	
	
	
	private static Boolean lambda_0024isLocalRecordDeclaration_00240(Node p)
	{
		Boolean result = Boolean.valueOf(p is LocalRecordDeclarationStmt);
		
		return result;
	}

	
	
	
	private static bool lambda_0024getCompactConstructors_00241(BodyDeclaration m)
	{
		return m is CompactConstructorDeclaration;
	}

	
	
	
	private static CompactConstructorDeclaration lambda_0024getCompactConstructors_00242(BodyDeclaration m)
	{
		return (CompactConstructorDeclaration)m;
	}

	
	
	public RecordDeclaration()
		: this(null, new NodeList(), new NodeList(), new SimpleName(), new NodeList(), new NodeList(), new NodeList(), new NodeList(), null)
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public RecordDeclaration(NodeList modifiers, string name)
		: this(null, modifiers, new NodeList(), new SimpleName(name), new NodeList(), new NodeList(), new NodeList(), new NodeList(), null)
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
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public RecordDeclaration(NodeList modifiers, NodeList annotations, SimpleName name, NodeList parameters, NodeList typeParameters, NodeList implementedTypes, NodeList members, ReceiverParameter receiverParameter)
		: this(null, modifiers, annotations, name, parameters, typeParameters, implementedTypes, members, receiverParameter)
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

		public virtual NodeList getImplementedTypes()
	{
		return implementedTypes;
	}

		public virtual NodeList getTypeParameters()
	{
		return typeParameters;
	}

	
		
	public override Optional getFullyQualifiedName()
	{
		if (isLocalRecordDeclaration())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Optional fullyQualifiedName = base.getFullyQualifiedName();
		
		return fullyQualifiedName;
	}

	public override bool isRecordDeclaration()
	{
		return true;
	}

	public override RecordDeclaration asRecordDeclaration()
	{
		return this;
	}

	
		
	public override Optional toRecordDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		
	
	public override void ifRecordDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 118, 99, 130, 112, 111, 109, 226, 61, 230,
		70, 112, 111, 109, 226, 61, 230, 70, 104, 105,
		103, 162, 112, 111, 109, 226, 61, 230, 70
	})]
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < implementedTypes.size(); i++)
		{
			if (implementedTypes.get(i) == node)
			{
				implementedTypes.remove(i);
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
		160, 151, 99, 130, 112, 111, 115, 226, 61, 230,
		70, 112, 111, 115, 226, 61, 230, 70, 104, 105,
		109, 162, 112, 111, 115, 226, 61, 230, 70
	})]
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < implementedTypes.size(); i++)
		{
			if (implementedTypes.get(i) == node)
			{
				implementedTypes.set(i, (ClassOrInterfaceType)replacementNode);
				return true;
			}
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

		public virtual NodeList getParameters()
	{
		return parameters;
	}

	
		
	public virtual Optional getReceiverParameter()
	{
		Optional result = Optional.ofNullable(receiverParameter);
		
		return result;
	}

	public virtual bool isFinal()
	{
		return true;
	}

	
	
	public override bool isStatic()
	{
		if (getParentNode().isPresent())
		{
			Node node = (Node)getParentNode().get();
			if (!(node is CompilationUnit))
			{
				return true;
			}
		}
		bool result = base.isStatic();
		
		return result;
	}

	
		
	public virtual List getCompactConstructors()
	{
		List result = Collections.unmodifiableList((List)getMembers().stream().filter(new ___003C_003EAnon1()).map(new ___003C_003EAnon2())
			.collect(Collectors.toList()));
		
		return result;
	}

	
	
	
	
	public new virtual TypeDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		RecordDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual TypeDeclaration _003Cbridge_003Eclone()
	{
		RecordDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		RecordDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override BodyDeclaration _003Cbridge_003Eclone()
	{
		RecordDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		RecordDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		RecordDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		RecordDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetParameters(NodeList parameters)
	{
		RecordDeclaration result = setParameters(parameters);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetImplementedTypes(NodeList implementedTypes)
	{
		RecordDeclaration result = setImplementedTypes(implementedTypes);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetTypeParameters(NodeList typeParameters)
	{
		RecordDeclaration result = setTypeParameters(typeParameters);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedReferenceTypeDeclaration result = resolve();
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Parameter getParameter(int P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setParameter(int P_0, Parameter P_1)
	{
		return NodeWithParameters._003Cdefault_003EsetParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addParameter(Type P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addParameter(Class P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addParameter(string P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addParameter(Parameter P_0)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Parameter addAndGetParameter(Type P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Parameter addAndGetParameter(Class P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Parameter addAndGetParameter(string P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Parameter addAndGetParameter(Parameter P_0)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getParameterByName(string P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByName(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getParameterByType(string P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getParameterByType(Class P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasParametersOfType(string[] P_0)
	{
		return NodeWithParameters._003Cdefault_003EhasParametersOfType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasParametersOfType(Class[] P_0)
	{
		return NodeWithParameters._003Cdefault_003EhasParametersOfType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ClassOrInterfaceType getImplementedTypes(int P_0)
	{
		return NodeWithImplements._003Cdefault_003EgetImplementedTypes(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setImplementedType(int P_0, ClassOrInterfaceType P_1)
	{
		return NodeWithImplements._003Cdefault_003EsetImplementedType(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addImplementedType(ClassOrInterfaceType P_0)
	{
		return NodeWithImplements._003Cdefault_003EaddImplementedType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addImplements(string P_0)
	{
		return NodeWithImplements._003Cdefault_003EaddImplements(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addImplements(Class P_0)
	{
		return NodeWithImplements._003Cdefault_003EaddImplements(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addImplementedType(string P_0)
	{
		return NodeWithImplements._003Cdefault_003EaddImplementedType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addImplementedType(Class P_0)
	{
		return NodeWithImplements._003Cdefault_003EaddImplementedType(this, P_0);
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

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node addModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EaddModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node removeModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EremoveModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setModifier(Modifier.Keyword P_0, bool P_1)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifier(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasModifier(Modifier.Keyword P_0)
	{
		return NodeWithModifiers._003Cdefault_003EhasModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Node setModifiers(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifiers(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override AccessSpecifier getAccessSpecifier()
	{
		return NodeWithModifiers._003Cdefault_003EgetAccessSpecifier(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setFinal(bool P_0)
	{
		return NodeWithFinalModifier._003Cdefault_003EsetFinal(this, P_0);
	}

	
	static RecordDeclaration()
	{
		TypeDeclaration.___003Cclinit_003E();
	}

	Node NodeWithParameters.NodeWithParameters_003A_003AsetParameters(NodeList P_0)
	{
		return _003Cbridge_003EsetParameters(P_0);
	}

	Node NodeWithImplements.NodeWithImplements_003A_003AsetImplementedTypes(NodeList P_0)
	{
		return _003Cbridge_003EsetImplementedTypes(P_0);
	}

	Node NodeWithTypeParameters.NodeWithTypeParameters_003A_003AsetTypeParameters(NodeList P_0)
	{
		return _003Cbridge_003EsetTypeParameters(P_0);
	}

	Node NodeWithModifiers.NodeWithModifiers_003A_003AsetModifiers(NodeList P_0)
	{
		return _003Cbridge_003EsetModifiers(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
