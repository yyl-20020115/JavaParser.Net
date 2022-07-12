using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution.types;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.type;

public class UnknownType : Type
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public UnknownType(TokenRange tokenRange)
		: base(tokenRange)
	{
		customInitialization();
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual UnknownTypeMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EunknownTypeMetaModel;
	}

	
	
	public new virtual UnknownType clone()
	{
		return (UnknownType)accept(new CloneVisitor(), null);
	}

	
		
	
	public new virtual UnknownType setAnnotations(NodeList annotations)
	{
		if (annotations.size() > 0)
		{
			
			throw new IllegalStateException("Inferred lambda types cannot be annotated.");
		}
		return (UnknownType)base.setAnnotations(annotations);
	}

	
	
	public override ResolvedType resolve()
	{
		return (ResolvedType)getSymbolResolver().toResolvedType(this, ClassLiteral<ResolvedReferenceType>.Value);
	}

	
	
	
	public UnknownType()
		: this(null)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public override string asString()
	{
		return "";
	}

	public override bool isUnknownType()
	{
		return true;
	}

	public override UnknownType asUnknownType()
	{
		return this;
	}

	
		
	
	public override void ifUnknownType(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toUnknownType()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	public override bool isPhantom()
	{
		return true;
	}

	
	
	
	
	public new virtual TypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		UnknownTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Type _003Cbridge_003Eclone()
	{
		UnknownType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Type _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		UnknownType result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	public override object _003Cbridge_003Eresolve()
	{
		ResolvedType result = resolve();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		UnknownTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		UnknownType result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		UnknownType result = clone();
		
		return result;
	}

	
	static UnknownType()
	{
		Type.___003Cclinit_003E();
	}
}
