using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class MarkerAnnotationExpr : AnnotationExpr
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public MarkerAnnotationExpr(Name name)
		: this(null, name)
	{
	}

	
	
	
	public MarkerAnnotationExpr(TokenRange tokenRange, Name name)
		: base(tokenRange, name)
	{
		customInitialization();
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual MarkerAnnotationExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmarkerAnnotationExprMetaModel;
	}

	
	
	public new virtual MarkerAnnotationExpr clone()
	{
		return (MarkerAnnotationExpr)accept(new CloneVisitor(), null);
	}

	
	
	public MarkerAnnotationExpr()
		: this(null, new Name())
	{
	}

	
	
	
	public MarkerAnnotationExpr(string name)
		: this(null, StaticJavaParser.parseName(name))
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public override bool isMarkerAnnotationExpr()
	{
		return true;
	}

	public override MarkerAnnotationExpr asMarkerAnnotationExpr()
	{
		return this;
	}

	
		
	
	public override void ifMarkerAnnotationExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toMarkerAnnotationExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual AnnotationExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		MarkerAnnotationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual AnnotationExpr _003Cbridge_003Eclone()
	{
		MarkerAnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		MarkerAnnotationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		MarkerAnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		MarkerAnnotationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		MarkerAnnotationExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		MarkerAnnotationExpr result = clone();
		
		return result;
	}

	
	static MarkerAnnotationExpr()
	{
		AnnotationExpr.___003Cclinit_003E();
	}
}
