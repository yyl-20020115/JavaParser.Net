using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.nodeTypes.modifiers;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.body;


public class AnnotationDeclaration : TypeDeclaration, NodeWithAbstractModifier, NodeWithModifiers, Resolvable
{
	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public AnnotationDeclaration(TokenRange tokenRange, NodeList modifiers, NodeList annotations, SimpleName name, NodeList members)
		: base(tokenRange, modifiers, annotations, name, members)
	{
		customInitialization();
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ResolvedAnnotationDeclaration resolve()
	{
		return (ResolvedAnnotationDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedAnnotationDeclaration>.Value);
	}

	
	
	public new virtual AnnotationDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EannotationDeclarationMetaModel;
	}

	
	
	public new virtual AnnotationDeclaration clone()
	{
		return (AnnotationDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	public AnnotationDeclaration()
		: this(null, new NodeList(), new NodeList(), new SimpleName(), new NodeList())
	{
	}

	
		
	
	public AnnotationDeclaration(NodeList modifiers, string name)
		: this(null, modifiers, new NodeList(), new SimpleName(name), new NodeList())
	{
	}

	
		
	
	
	public AnnotationDeclaration(NodeList modifiers, NodeList annotations, SimpleName name, NodeList members)
		: this(null, modifiers, annotations, name, members)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public override bool isAnnotationDeclaration()
	{
		return true;
	}

	public override AnnotationDeclaration asAnnotationDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifAnnotationDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toAnnotationDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	public override FieldDeclaration addField(Type type, string name, params Modifier.Keyword[] modifiers)
	{
		
		throw new IllegalStateException("Cannot add a field to an annotation declaration.");
	}

	
	
	
	
	public virtual ResolvedReferenceTypeDeclaration _003Cbridge_003Eresolve()
	{
		ResolvedAnnotationDeclaration result = resolve();
		
		return result;
	}

	
	
	
	
	public new virtual TypeDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		AnnotationDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual TypeDeclaration _003Cbridge_003Eclone()
	{
		AnnotationDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		AnnotationDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override BodyDeclaration _003Cbridge_003Eclone()
	{
		AnnotationDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		AnnotationDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		AnnotationDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		AnnotationDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedAnnotationDeclaration result = resolve();
		
		return result;
	}


	public override Node addModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EaddModifier(this, P_0);
	}


	public override Node removeModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EremoveModifier(this, P_0);
	}


	public override Node setModifier(Modifier.Keyword P_0, bool P_1)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifier(this, P_0, P_1);
	}


	public override bool hasModifier(Modifier.Keyword P_0)
	{
		return NodeWithModifiers._003Cdefault_003EhasModifier(this, P_0);
	}


	public override Node setModifiers(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifiers(this, P_0);
	}


	public override AccessSpecifier getAccessSpecifier()
	{
		return NodeWithModifiers._003Cdefault_003EgetAccessSpecifier(this);
	}


	public virtual bool isAbstract()
	{
		return NodeWithAbstractModifier._003Cdefault_003EisAbstract(this);
	}


	public virtual Node setAbstract(bool P_0)
	{
		return NodeWithAbstractModifier._003Cdefault_003EsetAbstract(this, P_0);
	}

	
	static AnnotationDeclaration()
	{
		TypeDeclaration.___003Cclinit_003E();
	}

	Node NodeWithModifiers.NodeWithModifiers_003A_003AsetModifiers(NodeList P_0)
	{
		return _003Cbridge_003EsetModifiers(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return this._003Cbridge_003Eresolve();
	}
}
