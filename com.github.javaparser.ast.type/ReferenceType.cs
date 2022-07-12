using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.type;

public abstract class ReferenceType : Type
{
	
	
	protected internal new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public ReferenceType(TokenRange tokenRange, NodeList annotations)
		: base(tokenRange, annotations)
	{
		customInitialization();
	}

	
	
	public new virtual ReferenceTypeMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EreferenceTypeMetaModel;
	}

	
	
	public new virtual ReferenceType clone()
	{
		return (ReferenceType)accept(new CloneVisitor(), null);
	}

	
	
	public ReferenceType()
		: this(null, new NodeList())
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public ReferenceType(NodeList annotations)
		: this(null, annotations)
	{
	}

	public override bool isReferenceType()
	{
		return true;
	}

	public override ReferenceType asReferenceType()
	{
		return this;
	}

	
		
	
	public override void ifReferenceType(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toReferenceType()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	public abstract override string toDescriptor();

	
	
	
	
	public new virtual TypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ReferenceTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Type _003Cbridge_003Eclone()
	{
		ReferenceType result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ReferenceTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ReferenceType result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ReferenceType result = clone();
		
		return result;
	}

	
	static ReferenceType()
	{
		Type.___003Cclinit_003E();
	}
}
