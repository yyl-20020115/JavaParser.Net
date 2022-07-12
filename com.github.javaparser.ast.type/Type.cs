using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.types;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.type;


public abstract class Type : Node, Resolvable
{
		private NodeList annotations;

	
	
	protected internal new static void ___003Cclinit_003E()
	{
	}

	public abstract string asString();

	
		
	public virtual Optional toClassOrInterfaceType()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
	
	public new virtual Type clone()
	{
		return (Type)accept(new CloneVisitor(), null);
	}

	public virtual string toDescriptor()
	{
		return "";
	}

	public virtual Type getElementType()
	{
		return this;
	}

	public abstract ResolvedType resolve();

	public virtual int getArrayLevel()
	{
		return 0;
	}

	
		
	
	public Type(TokenRange tokenRange, NodeList annotations)
		: base(tokenRange)
	{
		setAnnotations(annotations);
		customInitialization();
	}

	
		
	
	public virtual Type setAnnotations(NodeList annotations)
	{
		Utils.assertNotNull(annotations);
		if (annotations == this.annotations)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EANNOTATIONS, this.annotations, annotations);
		if (this.annotations != null)
		{
			this.annotations.setParentNode(null);
		}
		this.annotations = annotations;
		setAsParentNodeOf(annotations);
		return this;
	}

		public virtual NodeList getAnnotations()
	{
		return annotations;
	}

	
	
	public new virtual TypeMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EtypeMetaModel;
	}

	
	
	
	protected internal Type(TokenRange range)
		: this(range, new NodeList())
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public Type(NodeList annotations)
		: this(null, annotations)
	{
	}

	
	
	
	public virtual AnnotationExpr getAnnotation(int i)
	{
		return (AnnotationExpr)getAnnotations().get(i);
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < annotations.size(); i++)
		{
			if (annotations.get(i) == node)
			{
				annotations.remove(i);
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
		for (int i = 0; i < annotations.size(); i++)
		{
			if (annotations.get(i) == node)
			{
				annotations.set(i, (AnnotationExpr)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public virtual bool isArrayType()
	{
		return false;
	}

	
	
	public virtual ArrayType asArrayType()
	{
		string s = CodeGenerationUtils.f("%s is not ArrayType, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isClassOrInterfaceType()
	{
		return false;
	}

	
	
	public virtual ClassOrInterfaceType asClassOrInterfaceType()
	{
		string s = CodeGenerationUtils.f("%s is not ClassOrInterfaceType, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isIntersectionType()
	{
		return false;
	}

	
	
	public virtual IntersectionType asIntersectionType()
	{
		string s = CodeGenerationUtils.f("%s is not IntersectionType, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isPrimitiveType()
	{
		return false;
	}

	
	
	public virtual PrimitiveType asPrimitiveType()
	{
		string s = CodeGenerationUtils.f("%s is not PrimitiveType, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isReferenceType()
	{
		return false;
	}

	
	
	public virtual ReferenceType asReferenceType()
	{
		string s = CodeGenerationUtils.f("%s is not ReferenceType, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isTypeParameter()
	{
		return false;
	}

	
	
	public virtual TypeParameter asTypeParameter()
	{
		string s = CodeGenerationUtils.f("%s is not TypeParameter, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isUnionType()
	{
		return false;
	}

	
	
	public virtual UnionType asUnionType()
	{
		string s = CodeGenerationUtils.f("%s is not UnionType, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isUnknownType()
	{
		return false;
	}

	
	
	public virtual UnknownType asUnknownType()
	{
		string s = CodeGenerationUtils.f("%s is not UnknownType, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isVoidType()
	{
		return false;
	}

	
	
	public virtual VoidType asVoidType()
	{
		string s = CodeGenerationUtils.f("%s is not VoidType, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isWildcardType()
	{
		return false;
	}

	
	
	public virtual WildcardType asWildcardType()
	{
		string s = CodeGenerationUtils.f("%s is not WildcardType, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

		
	public virtual void ifArrayType(Consumer action)
	{
	}

		
	public virtual void ifClassOrInterfaceType(Consumer action)
	{
	}

		
	public virtual void ifIntersectionType(Consumer action)
	{
	}

		
	public virtual void ifPrimitiveType(Consumer action)
	{
	}

		
	public virtual void ifReferenceType(Consumer action)
	{
	}

		
	public virtual void ifTypeParameter(Consumer action)
	{
	}

		
	public virtual void ifUnionType(Consumer action)
	{
	}

		
	public virtual void ifUnknownType(Consumer action)
	{
	}

		
	public virtual void ifVoidType(Consumer action)
	{
	}

		
	public virtual void ifWildcardType(Consumer action)
	{
	}

	
		
	public virtual Optional toArrayType()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toIntersectionType()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toPrimitiveType()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toReferenceType()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toTypeParameter()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toUnionType()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toUnknownType()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toVoidType()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toWildcardType()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	public virtual bool isVarType()
	{
		return false;
	}

	
	
	public virtual VarType asVarType()
	{
		string s = CodeGenerationUtils.f("%s is not VarType, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toVarType()
	{
		Optional result = Optional.empty();
		
		return result;
	}

		
	public virtual void ifVarType(Consumer action)
	{
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		TypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		Type result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		Type result = clone();
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedType result = resolve();
		
		return result;
	}

	
	static Type()
	{
		Node.___003Cclinit_003E();
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
