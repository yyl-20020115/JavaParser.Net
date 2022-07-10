using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.type;

public class VarType : Type
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public VarType(TokenRange tokenRange)
		: base(tokenRange)
	{
		customInitialization();
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

	
	
	public new virtual VarTypeMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EvarTypeMetaModel;
	}

	
	
	public new virtual VarType clone()
	{
		return (VarType)accept(new CloneVisitor(), null);
	}

	
		
	
	public new virtual VarType setAnnotations(NodeList annotations)
	{
		return (VarType)base.setAnnotations(annotations);
	}

	
	
	public override ResolvedType resolve()
	{
		return (ResolvedType)getSymbolResolver().toResolvedType(this, ClassLiteral<ResolvedType>.Value);
	}

	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public VarType()
		: this(null)
	{
	}

	public override string asString()
	{
		return "var";
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

	public override bool isVarType()
	{
		return true;
	}

	public override VarType asVarType()
	{
		return this;
	}

	
		
	public override Optional toVarType()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		
	
	public override void ifVarType(Consumer action)
	{
		action.accept(this);
	}

	
	
	
	
	public new virtual TypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		VarTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Type _003Cbridge_003Eclone()
	{
		VarType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Type _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		VarType result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	public override object _003Cbridge_003Eresolve()
	{
		ResolvedType result = resolve();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		VarTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		VarType result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		VarType result = clone();
		
		return result;
	}

	
	static VarType()
	{
		Type.___003Cclinit_003E();
	}
}
