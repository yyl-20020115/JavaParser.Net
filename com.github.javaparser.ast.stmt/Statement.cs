using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.stmt;

public abstract class Statement : Node
{
	
	
	protected internal new static void ___003Cclinit_003E()
	{
	}

	public virtual bool isExpressionStmt()
	{
		return false;
	}

	
	
	public virtual ExpressionStmt asExpressionStmt()
	{
		string s = CodeGenerationUtils.f("%s is not ExpressionStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toBlockStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	public virtual bool isEmptyStmt()
	{
		return false;
	}

	
	
	public new virtual Statement clone()
	{
		return (Statement)accept(new CloneVisitor(), null);
	}

	
	
	
	public Statement(TokenRange tokenRange)
		: base(tokenRange)
	{
		customInitialization();
	}

	
	
	public new virtual StatementMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EstatementMetaModel;
	}

	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public Statement()
		: this(null)
	{
	}

	public virtual bool isAssertStmt()
	{
		return false;
	}

	
	
	public virtual AssertStmt asAssertStmt()
	{
		string s = CodeGenerationUtils.f("%s is not AssertStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isBlockStmt()
	{
		return false;
	}

	
	
	public virtual BlockStmt asBlockStmt()
	{
		string s = CodeGenerationUtils.f("%s is not BlockStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isBreakStmt()
	{
		return false;
	}

	
	
	public virtual BreakStmt asBreakStmt()
	{
		string s = CodeGenerationUtils.f("%s is not BreakStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isContinueStmt()
	{
		return false;
	}

	
	
	public virtual ContinueStmt asContinueStmt()
	{
		string s = CodeGenerationUtils.f("%s is not ContinueStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isDoStmt()
	{
		return false;
	}

	
	
	public virtual DoStmt asDoStmt()
	{
		string s = CodeGenerationUtils.f("%s is not DoStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
	
	public virtual EmptyStmt asEmptyStmt()
	{
		string s = CodeGenerationUtils.f("%s is not EmptyStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isExplicitConstructorInvocationStmt()
	{
		return false;
	}

	
	
	public virtual ExplicitConstructorInvocationStmt asExplicitConstructorInvocationStmt()
	{
		string s = CodeGenerationUtils.f("%s is not ExplicitConstructorInvocationStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isForStmt()
	{
		return false;
	}

	
	
	public virtual ForStmt asForStmt()
	{
		string s = CodeGenerationUtils.f("%s is not ForStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isIfStmt()
	{
		return false;
	}

	
	
	public virtual IfStmt asIfStmt()
	{
		string s = CodeGenerationUtils.f("%s is not IfStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isLabeledStmt()
	{
		return false;
	}

	
	
	public virtual LabeledStmt asLabeledStmt()
	{
		string s = CodeGenerationUtils.f("%s is not LabeledStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isLocalClassDeclarationStmt()
	{
		return false;
	}

	public virtual bool isLocalRecordDeclarationStmt()
	{
		return false;
	}

	
	
	public virtual LocalClassDeclarationStmt asLocalClassDeclarationStmt()
	{
		string s = CodeGenerationUtils.f("%s is not LocalClassDeclarationStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
	
	public virtual LocalRecordDeclarationStmt asLocalRecordDeclarationStmt()
	{
		string s = CodeGenerationUtils.f("%s is not LocalRecordDeclarationStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isReturnStmt()
	{
		return false;
	}

	
	
	public virtual ReturnStmt asReturnStmt()
	{
		string s = CodeGenerationUtils.f("%s is not ReturnStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isSwitchStmt()
	{
		return false;
	}

	
	
	public virtual SwitchStmt asSwitchStmt()
	{
		string s = CodeGenerationUtils.f("%s is not SwitchStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isSynchronizedStmt()
	{
		return false;
	}

	
	
	public virtual SynchronizedStmt asSynchronizedStmt()
	{
		string s = CodeGenerationUtils.f("%s is not SynchronizedStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isThrowStmt()
	{
		return false;
	}

	
	
	public virtual ThrowStmt asThrowStmt()
	{
		string s = CodeGenerationUtils.f("%s is not ThrowStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isTryStmt()
	{
		return false;
	}

	
	
	public virtual TryStmt asTryStmt()
	{
		string s = CodeGenerationUtils.f("%s is not TryStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isUnparsableStmt()
	{
		return false;
	}

	
	
	public virtual UnparsableStmt asUnparsableStmt()
	{
		string s = CodeGenerationUtils.f("%s is not UnparsableStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isWhileStmt()
	{
		return false;
	}

	
	
	public virtual WhileStmt asWhileStmt()
	{
		string s = CodeGenerationUtils.f("%s is not WhileStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

		
	public virtual void ifAssertStmt(Consumer action)
	{
	}

		
	public virtual void ifBlockStmt(Consumer action)
	{
	}

		
	public virtual void ifBreakStmt(Consumer action)
	{
	}

		
	public virtual void ifContinueStmt(Consumer action)
	{
	}

		
	public virtual void ifDoStmt(Consumer action)
	{
	}

		
	public virtual void ifEmptyStmt(Consumer action)
	{
	}

		
	public virtual void ifExplicitConstructorInvocationStmt(Consumer action)
	{
	}

		
	public virtual void ifExpressionStmt(Consumer action)
	{
	}

		
	public virtual void ifForStmt(Consumer action)
	{
	}

		
	public virtual void ifIfStmt(Consumer action)
	{
	}

		
	public virtual void ifLabeledStmt(Consumer action)
	{
	}

		
	public virtual void ifLocalClassDeclarationStmt(Consumer action)
	{
	}

		
	public virtual void ifLocalRecordDeclarationStmt(Consumer action)
	{
	}

		
	public virtual void ifReturnStmt(Consumer action)
	{
	}

		
	public virtual void ifSwitchStmt(Consumer action)
	{
	}

		
	public virtual void ifSynchronizedStmt(Consumer action)
	{
	}

		
	public virtual void ifThrowStmt(Consumer action)
	{
	}

		
	public virtual void ifTryStmt(Consumer action)
	{
	}

		
	public virtual void ifUnparsableStmt(Consumer action)
	{
	}

		
	public virtual void ifWhileStmt(Consumer action)
	{
	}

	
		
	public virtual Optional toAssertStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toBreakStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toContinueStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toDoStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toEmptyStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toExplicitConstructorInvocationStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toExpressionStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toForStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toIfStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toLabeledStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toLocalClassDeclarationStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toLocalRecordDeclarationStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toReturnStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toSwitchStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toSynchronizedStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toThrowStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toTryStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toUnparsableStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toWhileStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	public virtual bool isForEachStmt()
	{
		return false;
	}

	
	
	public virtual ForEachStmt asForEachStmt()
	{
		string s = CodeGenerationUtils.f("%s is not ForEachStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toForEachStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

		
	public virtual void ifForEachStmt(Consumer action)
	{
	}

	public virtual bool isYieldStmt()
	{
		return false;
	}

	
	
	public virtual YieldStmt asYieldStmt()
	{
		string s = CodeGenerationUtils.f("%s is not YieldStmt, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toYieldStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

		
	public virtual void ifYieldStmt(Consumer action)
	{
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		StatementMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		Statement result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		Statement result = clone();
		
		return result;
	}

	
	static Statement()
	{
		Node.___003Cclinit_003E();
	}
}
