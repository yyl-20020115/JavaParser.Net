using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;

public class LocalClassDeclarationStmt : Statement
{
	private ClassOrInterfaceDeclaration classDeclaration;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public LocalClassDeclarationStmt(TokenRange tokenRange, ClassOrInterfaceDeclaration classDeclaration)
		: base(tokenRange)
	{
		setClassDeclaration(classDeclaration);
		customInitialization();
	}

	
	
	
	public virtual LocalClassDeclarationStmt setClassDeclaration(ClassOrInterfaceDeclaration classDeclaration)
	{
		Utils.assertNotNull(classDeclaration);
		if (classDeclaration == this.classDeclaration)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ECLASS_DECLARATION, this.classDeclaration, classDeclaration);
		if (this.classDeclaration != null)
		{
			this.classDeclaration.setParentNode(null);
		}
		this.classDeclaration = classDeclaration;
		setAsParentNodeOf(classDeclaration);
		return this;
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

	
	
	public new virtual LocalClassDeclarationStmtMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003ElocalClassDeclarationStmtMetaModel;
	}

	
	
	public new virtual LocalClassDeclarationStmt clone()
	{
		return (LocalClassDeclarationStmt)accept(new CloneVisitor(), null);
	}

	
	
	public LocalClassDeclarationStmt()
		: this(null, new ClassOrInterfaceDeclaration())
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public LocalClassDeclarationStmt(ClassOrInterfaceDeclaration classDeclaration)
		: this(null, classDeclaration)
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

	public virtual ClassOrInterfaceDeclaration getClassDeclaration()
	{
		return classDeclaration;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == classDeclaration)
		{
			setClassDeclaration((ClassOrInterfaceDeclaration)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isLocalClassDeclarationStmt()
	{
		return true;
	}

	public override LocalClassDeclarationStmt asLocalClassDeclarationStmt()
	{
		return this;
	}

	
		
	
	public override void ifLocalClassDeclarationStmt(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toLocalClassDeclarationStmt()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual StatementMetaModel _003Cbridge_003EgetMetaModel()
	{
		LocalClassDeclarationStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Statement _003Cbridge_003Eclone()
	{
		LocalClassDeclarationStmt result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		LocalClassDeclarationStmtMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		LocalClassDeclarationStmt result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		LocalClassDeclarationStmt result = clone();
		
		return result;
	}

	
	static LocalClassDeclarationStmt()
	{
		Statement.___003Cclinit_003E();
	}
}
