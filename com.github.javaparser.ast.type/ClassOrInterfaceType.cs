using System;
using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution.types;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.type;


public class ClassOrInterfaceType : ReferenceType, NodeWithSimpleName, NodeWithAnnotations, NodeWithTypeArguments
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
			lambda_0024getNameWithScope_00240(arg_00241, (ClassOrInterfaceType)P_0);
			
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
			lambda_0024asString_00241(arg_00241, (ClassOrInterfaceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly StringBuilder arg_00241;

		internal ___003C_003EAnon2(StringBuilder P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024asString_00242(arg_00241, (NodeList)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
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

	
	private ClassOrInterfaceType scope;

	private SimpleName name;

		
	private NodeList typeArguments;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	public ClassOrInterfaceType()
		: this(null, null, new SimpleName(), null, new NodeList())
	{
	}

	
		
	
	public ClassOrInterfaceType(TokenRange tokenRange, ClassOrInterfaceType scope, SimpleName name, NodeList typeArguments, NodeList annotations)
		: base(tokenRange, annotations)
	{
		setScope(scope);
		setName(name);
		setTypeArguments(typeArguments);
		customInitialization();
	}

	
	
	
	public virtual ClassOrInterfaceType setScope(ClassOrInterfaceType scope)
	{
		if (scope == this.scope)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ESCOPE, this.scope, scope);
		if (this.scope != null)
		{
			this.scope.setParentNode(null);
		}
		this.scope = scope;
		setAsParentNodeOf(scope);
		return this;
	}

	
	
	
	public virtual ClassOrInterfaceType setName(SimpleName name)
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

	
		
	
	public virtual ClassOrInterfaceType setTypeArguments(NodeList typeArguments)
	{
		if (typeArguments == this.typeArguments)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE_ARGUMENTS, this.typeArguments, typeArguments);
		if (this.typeArguments != null)
		{
			this.typeArguments.setParentNode(null);
		}
		this.typeArguments = typeArguments;
		setAsParentNodeOf(typeArguments);
		return this;
	}

	
		
	public virtual Optional getScope()
	{
		Optional result = Optional.ofNullable(scope);
		
		return result;
	}

	
	
	public virtual bool isBoxedType()
	{
		bool result = PrimitiveType.unboxMap.containsKey(name.getIdentifier());
		
		return result;
	}

	
	
	public virtual ClassOrInterfaceType removeScope()
	{
		ClassOrInterfaceType result = setScope(null);
		
		return result;
	}

	
		
	public virtual Optional getTypeArguments()
	{
		Optional result = Optional.ofNullable(typeArguments);
		
		return result;
	}

	
	
	public override ResolvedType resolve()
	{
		return (ResolvedType)getSymbolResolver().toResolvedType(this, ClassLiteral<ResolvedType>.Value);
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ClassOrInterfaceTypeMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EclassOrInterfaceTypeMetaModel;
	}

	
	
	public new virtual ClassOrInterfaceType clone()
	{
		return (ClassOrInterfaceType)accept(new CloneVisitor(), null);
	}

	
		
	
	public new virtual ClassOrInterfaceType setAnnotations(NodeList annotations)
	{
		return (ClassOrInterfaceType)base.setAnnotations(annotations);
	}

	
	
	public override string asString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		getScope().ifPresent(new ___003C_003EAnon1(stringBuilder));
		stringBuilder.append(name.asString());
		getTypeArguments().ifPresent(new ___003C_003EAnon2(stringBuilder));
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	public virtual string getNameWithScope()
	{
		StringBuilder stringBuilder = new StringBuilder();
		getScope().ifPresent(new ___003C_003EAnon0(stringBuilder));
		stringBuilder.append(name.asString());
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	
	
	private static void lambda_0024getNameWithScope_00240(StringBuilder str, ClassOrInterfaceType s)
	{
		str.append(s.getNameWithScope()).append(".");
	}

	
	
	
	
	private static void lambda_0024asString_00241(StringBuilder str, ClassOrInterfaceType s)
	{
		str.append(s.asString()).append(".");
	}

	
	
	
	
	private static void lambda_0024asString_00242(StringBuilder str, NodeList ta)
	{
		Stream obj = ta.stream().map(new ___003C_003EAnon3());
		object __003Cref_003E = ">";
		object __003Cref_003E2 = "<";
		CharSequence charSequence = default(CharSequence);
		object obj2 = (charSequence.___003Cref_003E = ",");
		CharSequence delimiter = charSequence;
		obj2 = (charSequence.___003Cref_003E = __003Cref_003E2);
		CharSequence prefix = charSequence;
		obj2 = (charSequence.___003Cref_003E = __003Cref_003E);
		str.append((string)obj.collect(Collectors.joining(delimiter, prefix, charSequence)));
	}

	
	
	
	
	public ClassOrInterfaceType(string name)
		: this(null, null, new SimpleName(name), null, new NodeList())
	{
	}

	
	
	
	public ClassOrInterfaceType(ClassOrInterfaceType scope, string name)
		: this(null, scope, new SimpleName(name), null, new NodeList())
	{
	}

	
		
	
	public ClassOrInterfaceType(ClassOrInterfaceType scope, SimpleName name, NodeList typeArguments)
		: this(null, scope, name, typeArguments, new NodeList())
	{
	}

	
		
	
	
	public ClassOrInterfaceType(ClassOrInterfaceType scope, SimpleName name, NodeList typeArguments, NodeList annotations)
		: this(null, scope, name, typeArguments, annotations)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual SimpleName getName()
	{
		return name;
	}

	
	
	
	public virtual PrimitiveType toUnboxedType()
	{
		if (!isBoxedType())
		{
			string message = new StringBuilder().append(name).append(" isn't a boxed type.").ToString();
			
			throw new UnsupportedOperationException(message);
		}
		PrimitiveType.___003Cclinit_003E();
		PrimitiveType result = new PrimitiveType((PrimitiveType.Primitive)PrimitiveType.unboxMap.get(name.getIdentifier()));
		
		return result;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (scope != null && node == scope)
		{
			removeScope();
			return true;
		}
		if (typeArguments != null)
		{
			for (int i = 0; i < typeArguments.size(); i++)
			{
				if (typeArguments.get(i) == node)
				{
					typeArguments.remove(i);
					return true;
				}
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	
	public override string toDescriptor()
	{
		object[] array = new object[1];
		string qualifiedName = resolve().asReferenceType().getQualifiedName();
		object __003Cref_003E = "/";
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = ".");
		CharSequence target = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		array[0] = java.lang.String.instancehelper_replace(qualifiedName, target, charSequence);
		string result = java.lang.String.format("L%s;", array);
		
		return result;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == name)
		{
			setName((SimpleName)replacementNode);
			return true;
		}
		if (scope != null && node == scope)
		{
			setScope((ClassOrInterfaceType)replacementNode);
			return true;
		}
		if (typeArguments != null)
		{
			for (int i = 0; i < typeArguments.size(); i++)
			{
				if (typeArguments.get(i) == node)
				{
					typeArguments.set(i, (Type)replacementNode);
					return true;
				}
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isClassOrInterfaceType()
	{
		return true;
	}

	public override ClassOrInterfaceType asClassOrInterfaceType()
	{
		return this;
	}

	
		
	
	public override void ifClassOrInterfaceType(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toClassOrInterfaceType()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ReferenceTypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ClassOrInterfaceTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual ReferenceType _003Cbridge_003Eclone()
	{
		ClassOrInterfaceType result = clone();
		
		return result;
	}

	
	
	
	
	public override TypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ClassOrInterfaceTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Type _003Cbridge_003Eclone()
	{
		ClassOrInterfaceType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Type _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		ClassOrInterfaceType result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	public override object _003Cbridge_003Eresolve()
	{
		ResolvedType result = resolve();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ClassOrInterfaceTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ClassOrInterfaceType result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ClassOrInterfaceType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		ClassOrInterfaceType result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		ClassOrInterfaceType result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetTypeArguments(NodeList typeArguments)
	{
		ClassOrInterfaceType result = setTypeArguments(typeArguments);
		
		return result;
	}


	public virtual Node setName(string P_0)
	{
		return NodeWithSimpleName._003Cdefault_003EsetName(this, P_0);
	}


	public virtual string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}


	public virtual NameExpr getNameAsExpression()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsExpression(this);
	}


	public virtual Node setAnnotation(int P_0, AnnotationExpr P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EsetAnnotation(this, P_0, P_1);
	}


	public virtual Node addAnnotation(AnnotationExpr P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}


	public virtual Node addAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}


	public virtual NormalAnnotationExpr addAndGetAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}


	public virtual Node addAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}


	public virtual NormalAnnotationExpr addAndGetAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}


	public virtual Node addMarkerAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}


	public virtual Node addMarkerAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}


	public virtual Node addSingleMemberAnnotation(string P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}


	public virtual Node addSingleMemberAnnotation(Class P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}


	public virtual Node addSingleMemberAnnotation(string P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}


	public virtual Node addSingleMemberAnnotation(Class P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}


	public virtual bool isAnnotationPresent(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}


	public virtual bool isAnnotationPresent(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}


	public virtual Optional getAnnotationByName(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByName(this, P_0);
	}


	public virtual Optional getAnnotationByClass(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByClass(this, P_0);
	}


	public virtual bool isUsingDiamondOperator()
	{
		return NodeWithTypeArguments._003Cdefault_003EisUsingDiamondOperator(this);
	}


	public virtual Node setDiamondOperator()
	{
		return NodeWithTypeArguments._003Cdefault_003EsetDiamondOperator(this);
	}


	public virtual Node removeTypeArguments()
	{
		return NodeWithTypeArguments._003Cdefault_003EremoveTypeArguments(this);
	}


	public virtual Node setTypeArguments(Type[] P_0)
	{
		return NodeWithTypeArguments._003Cdefault_003EsetTypeArguments(this, P_0);
	}

	
	static ClassOrInterfaceType()
	{
		ReferenceType.___003Cclinit_003E();
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	Node NodeWithAnnotations.NodeWithAnnotations_003A_003AsetAnnotations(NodeList P_0)
	{
		return this._003Cbridge_003EsetAnnotations(P_0);
	}

	Node NodeWithTypeArguments.NodeWithTypeArguments_003A_003AsetTypeArguments(NodeList P_0)
	{
		return _003Cbridge_003EsetTypeArguments(P_0);
	}
}
