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

namespace com.github.javaparser.ast.body;


public class ClassOrInterfaceDeclaration : TypeDeclaration, NodeWithImplements, NodeWithExtends, NodeWithTypeParameters, NodeWithAbstractModifier, NodeWithModifiers, NodeWithFinalModifier, Resolvable
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Boolean result = lambda_0024isLocalClassDeclaration_00240((Node)P_0);
			
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

	private bool m_isInterface;

		private NodeList typeParameters;

		private NodeList extendedTypes;

		private NodeList implementedTypes;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	[LineNumberTable(new byte[]
	{
		126, 99, 130, 112, 111, 109, 226, 61, 230, 70,
		112, 111, 109, 226, 61, 230, 70, 112, 111, 109,
		226, 61, 230, 70
	})]
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < extendedTypes.size(); i++)
		{
			if (extendedTypes.get(i) == node)
			{
				extendedTypes.remove(i);
				return true;
			}
		}
		for (int i = 0; i < implementedTypes.size(); i++)
		{
			if (implementedTypes.get(i) == node)
			{
				implementedTypes.remove(i);
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

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setFinal(bool P_0)
	{
		return NodeWithFinalModifier._003Cdefault_003EsetFinal(this, P_0);
	}

	public virtual bool isInterface()
	{
		return this.m_isInterface;
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
	
	public ClassOrInterfaceDeclaration(TokenRange tokenRange, NodeList modifiers, NodeList annotations, bool isInterface, SimpleName name, NodeList typeParameters, NodeList extendedTypes, NodeList implementedTypes, NodeList members)
		: base(tokenRange, modifiers, annotations, name, members)
	{
		setInterface(isInterface);
		setTypeParameters(typeParameters);
		setExtendedTypes(extendedTypes);
		setImplementedTypes(implementedTypes);
		customInitialization();
	}

	
	
	
	public virtual ClassOrInterfaceDeclaration setInterface(bool isInterface)
	{
		if (isInterface == this.m_isInterface)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EINTERFACE, Boolean.valueOf(this.m_isInterface), Boolean.valueOf(isInterface));
		this.m_isInterface = isInterface;
		return this;
	}

	
		
	
	public virtual ClassOrInterfaceDeclaration setTypeParameters(NodeList typeParameters)
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

	
		
	
	public virtual ClassOrInterfaceDeclaration setExtendedTypes(NodeList extendedTypes)
	{
		Utils.assertNotNull(extendedTypes);
		if (extendedTypes == this.extendedTypes)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EEXTENDED_TYPES, this.extendedTypes, extendedTypes);
		if (this.extendedTypes != null)
		{
			this.extendedTypes.setParentNode(null);
		}
		this.extendedTypes = extendedTypes;
		setAsParentNodeOf(extendedTypes);
		return this;
	}

	
		
	
	public virtual ClassOrInterfaceDeclaration setImplementedTypes(NodeList implementedTypes)
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

	
	
	public virtual bool isLocalClassDeclaration()
	{
		bool result = ((Boolean)getParentNode().map(new ___003C_003EAnon0()).orElse(Boolean.valueOf(b: false))).booleanValue();
		
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

	
	
	public new virtual ClassOrInterfaceDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EclassOrInterfaceDeclarationMetaModel;
	}

	
	
	public new virtual ClassOrInterfaceDeclaration clone()
	{
		return (ClassOrInterfaceDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	public override ResolvedReferenceTypeDeclaration resolve()
	{
		return (ResolvedReferenceTypeDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
	}

	
	
	
	
	private static Boolean lambda_0024isLocalClassDeclaration_00240(Node p)
	{
		Boolean result = Boolean.valueOf(p is LocalClassDeclarationStmt);
		
		return result;
	}

	
	
	public ClassOrInterfaceDeclaration()
		: this(null, new NodeList(), new NodeList(), isInterface: false, new SimpleName(), new NodeList(), new NodeList(), new NodeList(), new NodeList())
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public ClassOrInterfaceDeclaration(NodeList modifiers, bool isInterface, string name)
		: this(null, modifiers, new NodeList(), isInterface, new SimpleName(name), new NodeList(), new NodeList(), new NodeList(), new NodeList())
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
	public ClassOrInterfaceDeclaration(NodeList modifiers, NodeList annotations, bool isInterface, SimpleName name, NodeList typeParameters, NodeList extendedTypes, NodeList implementedTypes, NodeList members)
		: this(null, modifiers, annotations, isInterface, name, typeParameters, extendedTypes, implementedTypes, members)
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

		public virtual NodeList getExtendedTypes()
	{
		return extendedTypes;
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
		if (isLocalClassDeclaration())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Optional fullyQualifiedName = base.getFullyQualifiedName();
		
		return fullyQualifiedName;
	}

	
	
	public virtual bool isInnerClass()
	{
		return (isNestedType() && !this.m_isInterface && !isStatic()) ? true : false;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 124, 99, 130, 112, 111, 115, 226, 61, 230,
		70, 112, 111, 115, 226, 61, 230, 70, 112, 111,
		115, 226, 61, 230, 70
	})]
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < extendedTypes.size(); i++)
		{
			if (extendedTypes.get(i) == node)
			{
				extendedTypes.set(i, (ClassOrInterfaceType)replacementNode);
				return true;
			}
		}
		for (int i = 0; i < implementedTypes.size(); i++)
		{
			if (implementedTypes.get(i) == node)
			{
				implementedTypes.set(i, (ClassOrInterfaceType)replacementNode);
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

	public override bool isClassOrInterfaceDeclaration()
	{
		return true;
	}

	public override ClassOrInterfaceDeclaration asClassOrInterfaceDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifClassOrInterfaceDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toClassOrInterfaceDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual TypeDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		ClassOrInterfaceDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual TypeDeclaration _003Cbridge_003Eclone()
	{
		ClassOrInterfaceDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		ClassOrInterfaceDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override BodyDeclaration _003Cbridge_003Eclone()
	{
		ClassOrInterfaceDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ClassOrInterfaceDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ClassOrInterfaceDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ClassOrInterfaceDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetImplementedTypes(NodeList implementedTypes)
	{
		ClassOrInterfaceDeclaration result = setImplementedTypes(implementedTypes);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetExtendedTypes(NodeList extendedTypes)
	{
		ClassOrInterfaceDeclaration result = setExtendedTypes(extendedTypes);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetTypeParameters(NodeList typeParameters)
	{
		ClassOrInterfaceDeclaration result = setTypeParameters(typeParameters);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedReferenceTypeDeclaration result = resolve();
		
		return result;
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
	public virtual ClassOrInterfaceType getExtendedTypes(int P_0)
	{
		return NodeWithExtends._003Cdefault_003EgetExtendedTypes(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setExtendedType(int P_0, ClassOrInterfaceType P_1)
	{
		return NodeWithExtends._003Cdefault_003EsetExtendedType(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addExtendedType(ClassOrInterfaceType P_0)
	{
		return NodeWithExtends._003Cdefault_003EaddExtendedType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addExtends(Class P_0)
	{
		return NodeWithExtends._003Cdefault_003EaddExtends(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addExtends(string P_0)
	{
		return NodeWithExtends._003Cdefault_003EaddExtends(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addExtendedType(Class P_0)
	{
		return NodeWithExtends._003Cdefault_003EaddExtendedType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addExtendedType(string P_0)
	{
		return NodeWithExtends._003Cdefault_003EaddExtendedType(this, P_0);
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
	public virtual bool isAbstract()
	{
		return NodeWithAbstractModifier._003Cdefault_003EisAbstract(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setAbstract(bool P_0)
	{
		return NodeWithAbstractModifier._003Cdefault_003EsetAbstract(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isFinal()
	{
		return NodeWithFinalModifier._003Cdefault_003EisFinal(this);
	}

	
	static ClassOrInterfaceDeclaration()
	{
		TypeDeclaration.___003Cclinit_003E();
	}

	Node NodeWithImplements.NodeWithImplements_003A_003AsetImplementedTypes(NodeList P_0)
	{
		return _003Cbridge_003EsetImplementedTypes(P_0);
	}

	Node NodeWithExtends.NodeWithExtends_003A_003AsetExtendedTypes(NodeList P_0)
	{
		return _003Cbridge_003EsetExtendedTypes(P_0);
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
