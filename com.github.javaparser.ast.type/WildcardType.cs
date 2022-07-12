using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution.types;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.type;


public class WildcardType : Type, NodeWithAnnotations
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly StringBuilder arg_00241;

		internal ___003C_003EAnon0(StringBuilder P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024asString_00240(arg_00241, (ReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly StringBuilder arg_00241;

		internal ___003C_003EAnon1(StringBuilder P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024asString_00241(arg_00241, (ReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private ReferenceType extendedType;

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private ReferenceType superType;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public WildcardType(TokenRange tokenRange, ReferenceType extendedType, ReferenceType superType, NodeList annotations)
		: base(tokenRange, annotations)
	{
		setExtendedType(extendedType);
		setSuperType(superType);
		customInitialization();
	}

	
	
	
	public virtual WildcardType setExtendedType(ReferenceType extendedType)
	{
		if (extendedType == this.extendedType)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EEXTENDED_TYPE, this.extendedType, extendedType);
		if (this.extendedType != null)
		{
			this.extendedType.setParentNode(null);
		}
		this.extendedType = extendedType;
		setAsParentNodeOf(extendedType);
		return this;
	}

	
	
	
	public virtual WildcardType setSuperType(ReferenceType superType)
	{
		if (superType == this.superType)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ESUPER_TYPE, this.superType, superType);
		if (this.superType != null)
		{
			this.superType.setParentNode(null);
		}
		this.superType = superType;
		setAsParentNodeOf(superType);
		return this;
	}

	
	
	public virtual WildcardType removeExtendedType()
	{
		WildcardType result = setExtendedType(null);
		
		return result;
	}

	
	
	public virtual WildcardType removeSuperType()
	{
		WildcardType result = setSuperType(null);
		
		return result;
	}

	
		
	public virtual Optional getExtendedType()
	{
		Optional result = Optional.ofNullable(extendedType);
		
		return result;
	}

	
		
	public virtual Optional getSuperType()
	{
		Optional result = Optional.ofNullable(superType);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ResolvedWildcard resolve()
	{
		return (ResolvedWildcard)getSymbolResolver().toResolvedType(this, ClassLiteral<ResolvedWildcard>.Value);
	}

	
	
	public new virtual WildcardTypeMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EwildcardTypeMetaModel;
	}

	
	
	public new virtual WildcardType clone()
	{
		return (WildcardType)accept(new CloneVisitor(), null);
	}

	
		
	
	public new virtual WildcardType setAnnotations(NodeList annotations)
	{
		return (WildcardType)base.setAnnotations(annotations);
	}

	
	
	
	
	private static void lambda_0024asString_00240(StringBuilder str, ReferenceType t)
	{
		str.append(" extends ").append(t.asString());
	}

	
	
	
	
	private static void lambda_0024asString_00241(StringBuilder str, ReferenceType t)
	{
		str.append(" super ").append(t.asString());
	}

	
	
	public WildcardType()
		: this(null, null, null, new NodeList())
	{
	}

	
	
	
	public WildcardType(ReferenceType extendedType)
		: this(null, extendedType, null, new NodeList())
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public WildcardType(ReferenceType extendedType, ReferenceType superType, NodeList annotations)
		: this(null, extendedType, superType, annotations)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (extendedType != null && node == extendedType)
		{
			removeExtendedType();
			return true;
		}
		if (superType != null && node == superType)
		{
			removeSuperType();
			return true;
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	
	public override string asString()
	{
		StringBuilder stringBuilder = new StringBuilder("?");
		getExtendedType().ifPresent(new ___003C_003EAnon0(stringBuilder));
		getSuperType().ifPresent(new ___003C_003EAnon1(stringBuilder));
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (extendedType != null && node == extendedType)
		{
			setExtendedType((ReferenceType)replacementNode);
			return true;
		}
		if (superType != null && node == superType)
		{
			setSuperType((ReferenceType)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	
	public WildcardType(TokenRange tokenRange, ReferenceType extendedType, ReferenceType superType)
		: base(tokenRange)
	{
		setExtendedType(extendedType);
		setSuperType(superType);
		customInitialization();
	}

	public override bool isWildcardType()
	{
		return true;
	}

	public override WildcardType asWildcardType()
	{
		return this;
	}

	
		
	
	public override void ifWildcardType(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toWildcardType()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ResolvedType _003Cbridge_003Eresolve()
	{
		ResolvedWildcard result = resolve();
		
		return result;
	}

	
	
	
	
	public new virtual TypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		WildcardTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Type _003Cbridge_003Eclone()
	{
		WildcardType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Type _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		WildcardType result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	public override object _003Cbridge_003Eresolve()
	{
		ResolvedWildcard result = resolve();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		WildcardTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		WildcardType result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		WildcardType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		WildcardType result = setAnnotations(annotations);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setAnnotation(int P_0, AnnotationExpr P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EsetAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(AnnotationExpr P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual NormalAnnotationExpr addAndGetAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual NormalAnnotationExpr addAndGetAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addMarkerAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addMarkerAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(string P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(Class P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(string P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(Class P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isAnnotationPresent(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isAnnotationPresent(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getAnnotationByName(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByName(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getAnnotationByClass(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByClass(this, P_0);
	}

	
	static WildcardType()
	{
		Type.___003Cclinit_003E();
	}

	Node NodeWithAnnotations.NodeWithAnnotations_003A_003AsetAnnotations(NodeList P_0)
	{
		return this._003Cbridge_003EsetAnnotations(P_0);
	}
}
