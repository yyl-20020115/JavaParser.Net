using System.ComponentModel;

using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution.types;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public abstract class Expression : Node
{
	
	
	protected internal new static void ___003Cclinit_003E()
	{
	}

	
	
	public virtual IntegerLiteralExpr asIntegerLiteralExpr()
	{
		string s = CodeGenerationUtils.f("%s is not IntegerLiteralExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
	
	
	public Expression(TokenRange tokenRange)
		: base(tokenRange)
	{
		customInitialization();
	}

	public virtual bool isPolyExpression()
	{
		return false;
	}

	protected internal virtual bool isAssignmentContext()
	{
		return false;
	}

	protected internal virtual bool isInvocationContext()
	{
		return false;
	}

	
	
	public bool elidesTypeArguments()
	{
		if (!hasScope() || !(this is NodeWithTypeArguments))
		{
			return true;
		}
		Expression expression = (Expression)((NodeWithOptionalScope)this).getScope().get();
		NodeWithTypeArguments nodeWithTypeArguments = (NodeWithTypeArguments)this;
		return (expression.elidesTypeArguments() && (!nodeWithTypeArguments.getTypeArguments().isPresent() || nodeWithTypeArguments.isUsingDiamondOperator())) ? true : false;
	}

	
	
	public new virtual ExpressionMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EexpressionMetaModel;
	}

	
	
	public new virtual Expression clone()
	{
		return (Expression)accept(new CloneVisitor(), null);
	}

	
	
	
	public Expression()
		: this(null)
	{
	}

	public virtual bool isAnnotationExpr()
	{
		return false;
	}

	
	
	public virtual AnnotationExpr asAnnotationExpr()
	{
		string s = CodeGenerationUtils.f("%s is not AnnotationExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isArrayAccessExpr()
	{
		return false;
	}

	
	
	public virtual ArrayAccessExpr asArrayAccessExpr()
	{
		string s = CodeGenerationUtils.f("%s is not ArrayAccessExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isArrayCreationExpr()
	{
		return false;
	}

	
	
	public virtual ArrayCreationExpr asArrayCreationExpr()
	{
		string s = CodeGenerationUtils.f("%s is not ArrayCreationExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isArrayInitializerExpr()
	{
		return false;
	}

	
	
	public virtual ArrayInitializerExpr asArrayInitializerExpr()
	{
		string s = CodeGenerationUtils.f("%s is not ArrayInitializerExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isAssignExpr()
	{
		return false;
	}

	
	
	public virtual AssignExpr asAssignExpr()
	{
		string s = CodeGenerationUtils.f("%s is not AssignExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isBinaryExpr()
	{
		return false;
	}

	
	
	public virtual BinaryExpr asBinaryExpr()
	{
		string s = CodeGenerationUtils.f("%s is not BinaryExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isBooleanLiteralExpr()
	{
		return false;
	}

	
	
	public virtual BooleanLiteralExpr asBooleanLiteralExpr()
	{
		string s = CodeGenerationUtils.f("%s is not BooleanLiteralExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isCastExpr()
	{
		return false;
	}

	
	
	public virtual CastExpr asCastExpr()
	{
		string s = CodeGenerationUtils.f("%s is not CastExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isCharLiteralExpr()
	{
		return false;
	}

	
	
	public virtual CharLiteralExpr asCharLiteralExpr()
	{
		string s = CodeGenerationUtils.f("%s is not CharLiteralExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isClassExpr()
	{
		return false;
	}

	
	
	public virtual ClassExpr asClassExpr()
	{
		string s = CodeGenerationUtils.f("%s is not ClassExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isConditionalExpr()
	{
		return false;
	}

	
	
	public virtual ConditionalExpr asConditionalExpr()
	{
		string s = CodeGenerationUtils.f("%s is not ConditionalExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isDoubleLiteralExpr()
	{
		return false;
	}

	
	
	public virtual DoubleLiteralExpr asDoubleLiteralExpr()
	{
		string s = CodeGenerationUtils.f("%s is not DoubleLiteralExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isEnclosedExpr()
	{
		return false;
	}

	
	
	public virtual EnclosedExpr asEnclosedExpr()
	{
		string s = CodeGenerationUtils.f("%s is not EnclosedExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isFieldAccessExpr()
	{
		return false;
	}

	
	
	public virtual FieldAccessExpr asFieldAccessExpr()
	{
		string s = CodeGenerationUtils.f("%s is not FieldAccessExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isInstanceOfExpr()
	{
		return false;
	}

	
	
	public virtual InstanceOfExpr asInstanceOfExpr()
	{
		string s = CodeGenerationUtils.f("%s is not InstanceOfExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isIntegerLiteralExpr()
	{
		return false;
	}

	public virtual bool isLambdaExpr()
	{
		return false;
	}

	
	
	public virtual LambdaExpr asLambdaExpr()
	{
		string s = CodeGenerationUtils.f("%s is not LambdaExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isLiteralExpr()
	{
		return false;
	}

	
	
	public virtual LiteralExpr asLiteralExpr()
	{
		string s = CodeGenerationUtils.f("%s is not LiteralExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isLiteralStringValueExpr()
	{
		return false;
	}

	
	
	public virtual LiteralStringValueExpr asLiteralStringValueExpr()
	{
		string s = CodeGenerationUtils.f("%s is not LiteralStringValueExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isLongLiteralExpr()
	{
		return false;
	}

	
	
	public virtual LongLiteralExpr asLongLiteralExpr()
	{
		string s = CodeGenerationUtils.f("%s is not LongLiteralExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isMarkerAnnotationExpr()
	{
		return false;
	}

	
	
	public virtual MarkerAnnotationExpr asMarkerAnnotationExpr()
	{
		string s = CodeGenerationUtils.f("%s is not MarkerAnnotationExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isMethodCallExpr()
	{
		return false;
	}

	
	
	public virtual MethodCallExpr asMethodCallExpr()
	{
		string s = CodeGenerationUtils.f("%s is not MethodCallExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isMethodReferenceExpr()
	{
		return false;
	}

	
	
	public virtual MethodReferenceExpr asMethodReferenceExpr()
	{
		string s = CodeGenerationUtils.f("%s is not MethodReferenceExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isNameExpr()
	{
		return false;
	}

	
	
	public virtual NameExpr asNameExpr()
	{
		string s = CodeGenerationUtils.f("%s is not NameExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isNormalAnnotationExpr()
	{
		return false;
	}

	
	
	public virtual NormalAnnotationExpr asNormalAnnotationExpr()
	{
		string s = CodeGenerationUtils.f("%s is not NormalAnnotationExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isNullLiteralExpr()
	{
		return false;
	}

	
	
	public virtual NullLiteralExpr asNullLiteralExpr()
	{
		string s = CodeGenerationUtils.f("%s is not NullLiteralExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isObjectCreationExpr()
	{
		return false;
	}

	
	
	public virtual ObjectCreationExpr asObjectCreationExpr()
	{
		string s = CodeGenerationUtils.f("%s is not ObjectCreationExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isSingleMemberAnnotationExpr()
	{
		return false;
	}

	
	
	public virtual SingleMemberAnnotationExpr asSingleMemberAnnotationExpr()
	{
		string s = CodeGenerationUtils.f("%s is not SingleMemberAnnotationExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isStringLiteralExpr()
	{
		return false;
	}

	
	
	public virtual StringLiteralExpr asStringLiteralExpr()
	{
		string s = CodeGenerationUtils.f("%s is not StringLiteralExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isSuperExpr()
	{
		return false;
	}

	
	
	public virtual SuperExpr asSuperExpr()
	{
		string s = CodeGenerationUtils.f("%s is not SuperExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isThisExpr()
	{
		return false;
	}

	
	
	public virtual ThisExpr asThisExpr()
	{
		string s = CodeGenerationUtils.f("%s is not ThisExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isTypeExpr()
	{
		return false;
	}

	
	
	public virtual TypeExpr asTypeExpr()
	{
		string s = CodeGenerationUtils.f("%s is not TypeExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isUnaryExpr()
	{
		return false;
	}

	
	
	public virtual UnaryExpr asUnaryExpr()
	{
		string s = CodeGenerationUtils.f("%s is not UnaryExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isVariableDeclarationExpr()
	{
		return false;
	}

	
	
	public virtual VariableDeclarationExpr asVariableDeclarationExpr()
	{
		string s = CodeGenerationUtils.f("%s is not VariableDeclarationExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

		
	public virtual void ifAnnotationExpr(Consumer action)
	{
	}

		
	public virtual void ifArrayAccessExpr(Consumer action)
	{
	}

		
	public virtual void ifArrayCreationExpr(Consumer action)
	{
	}

		
	public virtual void ifArrayInitializerExpr(Consumer action)
	{
	}

		
	public virtual void ifAssignExpr(Consumer action)
	{
	}

		
	public virtual void ifBinaryExpr(Consumer action)
	{
	}

		
	public virtual void ifBooleanLiteralExpr(Consumer action)
	{
	}

		
	public virtual void ifCastExpr(Consumer action)
	{
	}

		
	public virtual void ifCharLiteralExpr(Consumer action)
	{
	}

		
	public virtual void ifClassExpr(Consumer action)
	{
	}

		
	public virtual void ifConditionalExpr(Consumer action)
	{
	}

		
	public virtual void ifDoubleLiteralExpr(Consumer action)
	{
	}

		
	public virtual void ifEnclosedExpr(Consumer action)
	{
	}

		
	public virtual void ifFieldAccessExpr(Consumer action)
	{
	}

		
	public virtual void ifInstanceOfExpr(Consumer action)
	{
	}

		
	public virtual void ifIntegerLiteralExpr(Consumer action)
	{
	}

		
	public virtual void ifLambdaExpr(Consumer action)
	{
	}

		
	public virtual void ifLiteralExpr(Consumer action)
	{
	}

		
	public virtual void ifLiteralStringValueExpr(Consumer action)
	{
	}

		
	public virtual void ifLongLiteralExpr(Consumer action)
	{
	}

		
	public virtual void ifMarkerAnnotationExpr(Consumer action)
	{
	}

		
	public virtual void ifMethodCallExpr(Consumer action)
	{
	}

		
	public virtual void ifMethodReferenceExpr(Consumer action)
	{
	}

		
	public virtual void ifNameExpr(Consumer action)
	{
	}

		
	public virtual void ifNormalAnnotationExpr(Consumer action)
	{
	}

		
	public virtual void ifNullLiteralExpr(Consumer action)
	{
	}

		
	public virtual void ifObjectCreationExpr(Consumer action)
	{
	}

		
	public virtual void ifSingleMemberAnnotationExpr(Consumer action)
	{
	}

		
	public virtual void ifStringLiteralExpr(Consumer action)
	{
	}

		
	public virtual void ifSuperExpr(Consumer action)
	{
	}

		
	public virtual void ifThisExpr(Consumer action)
	{
	}

		
	public virtual void ifTypeExpr(Consumer action)
	{
	}

		
	public virtual void ifUnaryExpr(Consumer action)
	{
	}

		
	public virtual void ifVariableDeclarationExpr(Consumer action)
	{
	}

	
	
	public virtual ResolvedType calculateResolvedType()
	{
		ResolvedType result = getSymbolResolver().calculateType(this);
		
		return result;
	}

	
		
	public virtual Optional toAnnotationExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toArrayAccessExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toArrayCreationExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toArrayInitializerExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toAssignExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toBinaryExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toBooleanLiteralExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toCastExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toCharLiteralExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toClassExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toConditionalExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toDoubleLiteralExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toEnclosedExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toFieldAccessExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toInstanceOfExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toIntegerLiteralExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toLambdaExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toLiteralExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toLiteralStringValueExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toLongLiteralExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toMarkerAnnotationExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toMethodCallExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toMethodReferenceExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toNameExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toNormalAnnotationExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toNullLiteralExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toObjectCreationExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toSingleMemberAnnotationExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toStringLiteralExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toSuperExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toThisExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toTypeExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toUnaryExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toVariableDeclarationExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	public virtual bool isSwitchExpr()
	{
		return false;
	}

	
	
	public virtual SwitchExpr asSwitchExpr()
	{
		string s = CodeGenerationUtils.f("%s is not SwitchExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toSwitchExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

		
	public virtual void ifSwitchExpr(Consumer action)
	{
	}

	public virtual bool isTextBlockLiteralExpr()
	{
		return false;
	}

	
	
	public virtual TextBlockLiteralExpr asTextBlockLiteralExpr()
	{
		string s = CodeGenerationUtils.f("%s is not TextBlockLiteralExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toTextBlockLiteralExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

		
	public virtual void ifTextBlockLiteralExpr(Consumer action)
	{
	}

	public virtual bool isPatternExpr()
	{
		return false;
	}

	
	
	public virtual PatternExpr asPatternExpr()
	{
		string s = CodeGenerationUtils.f("%s is not PatternExpr, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toPatternExpr()
	{
		Optional result = Optional.empty();
		
		return result;
	}

		
	public virtual void ifPatternExpr(Consumer action)
	{
	}

	
	
	public virtual bool isStandaloneExpression()
	{
		return (!isPolyExpression()) ? true : false;
	}

	
	
	public virtual bool isQualified()
	{
		bool result = hasScope();
		
		return result;
	}

	
	
	public bool appearsInAssignmentContext()
	{
		if (getParentNode().isPresent() && getParentNode().get() is Expression)
		{
			bool result = ((Expression)getParentNode().get()).isAssignmentContext();
			
			return result;
		}
		return false;
	}

	
	
	public bool appearsInInvocationContext()
	{
		if (getParentNode().isPresent() && getParentNode().get() is Expression)
		{
			bool result = ((Expression)getParentNode().get()).isInvocationContext();
			
			return result;
		}
		return false;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ExpressionMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		Expression result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		Expression result = clone();
		
		return result;
	}

	
	static Expression()
	{
		Node.___003Cclinit_003E();
	}
}
