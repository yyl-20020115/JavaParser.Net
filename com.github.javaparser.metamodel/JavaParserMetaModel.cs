using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class JavaParserMetaModel
{
	
		private static List nodeMetaModels;

	internal static NodeMetaModel ___003C_003EnodeMetaModel;

	internal static BodyDeclarationMetaModel ___003C_003EbodyDeclarationMetaModel;

	internal static CallableDeclarationMetaModel ___003C_003EcallableDeclarationMetaModel;

	internal static ExpressionMetaModel ___003C_003EexpressionMetaModel;

	internal static StatementMetaModel ___003C_003EstatementMetaModel;

	internal static TypeMetaModel ___003C_003EtypeMetaModel;

	internal static AnnotationExprMetaModel ___003C_003EannotationExprMetaModel;

	internal static ReferenceTypeMetaModel ___003C_003EreferenceTypeMetaModel;

	internal static TypeDeclarationMetaModel ___003C_003EtypeDeclarationMetaModel;

	internal static LiteralExprMetaModel ___003C_003EliteralExprMetaModel;

	internal static LiteralStringValueExprMetaModel ___003C_003EliteralStringValueExprMetaModel;

	internal static StringLiteralExprMetaModel ___003C_003EstringLiteralExprMetaModel;

	internal static ModuleDeclarationMetaModel ___003C_003EmoduleDeclarationMetaModel;

	internal static ModuleDirectiveMetaModel ___003C_003EmoduleDirectiveMetaModel;

	internal static ArrayCreationLevelMetaModel ___003C_003EarrayCreationLevelMetaModel;

	internal static CompilationUnitMetaModel ___003C_003EcompilationUnitMetaModel;

	internal static ImportDeclarationMetaModel ___003C_003EimportDeclarationMetaModel;

	internal static ModifierMetaModel ___003C_003EmodifierMetaModel;

	internal static PackageDeclarationMetaModel ___003C_003EpackageDeclarationMetaModel;

	internal static AnnotationDeclarationMetaModel ___003C_003EannotationDeclarationMetaModel;

	internal static AnnotationMemberDeclarationMetaModel ___003C_003EannotationMemberDeclarationMetaModel;

	internal static ClassOrInterfaceDeclarationMetaModel ___003C_003EclassOrInterfaceDeclarationMetaModel;

	internal static ConstructorDeclarationMetaModel ___003C_003EconstructorDeclarationMetaModel;

	internal static EnumConstantDeclarationMetaModel ___003C_003EenumConstantDeclarationMetaModel;

	internal static EnumDeclarationMetaModel ___003C_003EenumDeclarationMetaModel;

	internal static FieldDeclarationMetaModel ___003C_003EfieldDeclarationMetaModel;

	internal static InitializerDeclarationMetaModel ___003C_003EinitializerDeclarationMetaModel;

	internal static MethodDeclarationMetaModel ___003C_003EmethodDeclarationMetaModel;

	internal static ParameterMetaModel ___003C_003EparameterMetaModel;

	internal static ReceiverParameterMetaModel ___003C_003EreceiverParameterMetaModel;

	internal static RecordDeclarationMetaModel ___003C_003ErecordDeclarationMetaModel;

	internal static CompactConstructorDeclarationMetaModel ___003C_003EcompactConstructorDeclarationMetaModel;

	internal static VariableDeclaratorMetaModel ___003C_003EvariableDeclaratorMetaModel;

	internal static CommentMetaModel ___003C_003EcommentMetaModel;

	internal static BlockCommentMetaModel ___003C_003EblockCommentMetaModel;

	internal static JavadocCommentMetaModel ___003C_003EjavadocCommentMetaModel;

	internal static LineCommentMetaModel ___003C_003ElineCommentMetaModel;

	internal static ArrayAccessExprMetaModel ___003C_003EarrayAccessExprMetaModel;

	internal static ArrayCreationExprMetaModel ___003C_003EarrayCreationExprMetaModel;

	internal static ArrayInitializerExprMetaModel ___003C_003EarrayInitializerExprMetaModel;

	internal static AssignExprMetaModel ___003C_003EassignExprMetaModel;

	internal static BinaryExprMetaModel ___003C_003EbinaryExprMetaModel;

	internal static BooleanLiteralExprMetaModel ___003C_003EbooleanLiteralExprMetaModel;

	internal static CastExprMetaModel ___003C_003EcastExprMetaModel;

	internal static CharLiteralExprMetaModel ___003C_003EcharLiteralExprMetaModel;

	internal static ClassExprMetaModel ___003C_003EclassExprMetaModel;

	internal static ConditionalExprMetaModel ___003C_003EconditionalExprMetaModel;

	internal static DoubleLiteralExprMetaModel ___003C_003EdoubleLiteralExprMetaModel;

	internal static EnclosedExprMetaModel ___003C_003EenclosedExprMetaModel;

	internal static FieldAccessExprMetaModel ___003C_003EfieldAccessExprMetaModel;

	internal static InstanceOfExprMetaModel ___003C_003EinstanceOfExprMetaModel;

	internal static IntegerLiteralExprMetaModel ___003C_003EintegerLiteralExprMetaModel;

	internal static LambdaExprMetaModel ___003C_003ElambdaExprMetaModel;

	internal static LongLiteralExprMetaModel ___003C_003ElongLiteralExprMetaModel;

	internal static MarkerAnnotationExprMetaModel ___003C_003EmarkerAnnotationExprMetaModel;

	internal static MemberValuePairMetaModel ___003C_003EmemberValuePairMetaModel;

	internal static MethodCallExprMetaModel ___003C_003EmethodCallExprMetaModel;

	internal static MethodReferenceExprMetaModel ___003C_003EmethodReferenceExprMetaModel;

	internal static NameExprMetaModel ___003C_003EnameExprMetaModel;

	internal static NameMetaModel ___003C_003EnameMetaModel;

	internal static NormalAnnotationExprMetaModel ___003C_003EnormalAnnotationExprMetaModel;

	internal static NullLiteralExprMetaModel ___003C_003EnullLiteralExprMetaModel;

	internal static ObjectCreationExprMetaModel ___003C_003EobjectCreationExprMetaModel;

	internal static PatternExprMetaModel ___003C_003EpatternExprMetaModel;

	internal static SingleMemberAnnotationExprMetaModel ___003C_003EsingleMemberAnnotationExprMetaModel;

	internal static SimpleNameMetaModel ___003C_003EsimpleNameMetaModel;

	internal static SuperExprMetaModel ___003C_003EsuperExprMetaModel;

	internal static SwitchExprMetaModel ___003C_003EswitchExprMetaModel;

	internal static TextBlockLiteralExprMetaModel ___003C_003EtextBlockLiteralExprMetaModel;

	internal static ThisExprMetaModel ___003C_003EthisExprMetaModel;

	internal static TypeExprMetaModel ___003C_003EtypeExprMetaModel;

	internal static UnaryExprMetaModel ___003C_003EunaryExprMetaModel;

	internal static VariableDeclarationExprMetaModel ___003C_003EvariableDeclarationExprMetaModel;

	internal static AssertStmtMetaModel ___003C_003EassertStmtMetaModel;

	internal static BlockStmtMetaModel ___003C_003EblockStmtMetaModel;

	internal static BreakStmtMetaModel ___003C_003EbreakStmtMetaModel;

	internal static CatchClauseMetaModel ___003C_003EcatchClauseMetaModel;

	internal static ContinueStmtMetaModel ___003C_003EcontinueStmtMetaModel;

	internal static DoStmtMetaModel ___003C_003EdoStmtMetaModel;

	internal static EmptyStmtMetaModel ___003C_003EemptyStmtMetaModel;

	internal static ExplicitConstructorInvocationStmtMetaModel ___003C_003EexplicitConstructorInvocationStmtMetaModel;

	internal static ExpressionStmtMetaModel ___003C_003EexpressionStmtMetaModel;

	internal static ForEachStmtMetaModel ___003C_003EforEachStmtMetaModel;

	internal static ForStmtMetaModel ___003C_003EforStmtMetaModel;

	internal static IfStmtMetaModel ___003C_003EifStmtMetaModel;

	internal static LabeledStmtMetaModel ___003C_003ElabeledStmtMetaModel;

	internal static LocalClassDeclarationStmtMetaModel ___003C_003ElocalClassDeclarationStmtMetaModel;

	internal static LocalRecordDeclarationStmtMetaModel ___003C_003ElocalRecordDeclarationStmtMetaModel;

	internal static ReturnStmtMetaModel ___003C_003EreturnStmtMetaModel;

	internal static SwitchEntryMetaModel ___003C_003EswitchEntryMetaModel;

	internal static SwitchStmtMetaModel ___003C_003EswitchStmtMetaModel;

	internal static SynchronizedStmtMetaModel ___003C_003EsynchronizedStmtMetaModel;

	internal static ThrowStmtMetaModel ___003C_003EthrowStmtMetaModel;

	internal static TryStmtMetaModel ___003C_003EtryStmtMetaModel;

	internal static UnparsableStmtMetaModel ___003C_003EunparsableStmtMetaModel;

	internal static WhileStmtMetaModel ___003C_003EwhileStmtMetaModel;

	internal static YieldStmtMetaModel ___003C_003EyieldStmtMetaModel;

	internal static ArrayTypeMetaModel ___003C_003EarrayTypeMetaModel;

	internal static ClassOrInterfaceTypeMetaModel ___003C_003EclassOrInterfaceTypeMetaModel;

	internal static IntersectionTypeMetaModel ___003C_003EintersectionTypeMetaModel;

	internal static PrimitiveTypeMetaModel ___003C_003EprimitiveTypeMetaModel;

	internal static TypeParameterMetaModel ___003C_003EtypeParameterMetaModel;

	internal static UnionTypeMetaModel ___003C_003EunionTypeMetaModel;

	internal static UnknownTypeMetaModel ___003C_003EunknownTypeMetaModel;

	internal static VarTypeMetaModel ___003C_003EvarTypeMetaModel;

	internal static VoidTypeMetaModel ___003C_003EvoidTypeMetaModel;

	internal static WildcardTypeMetaModel ___003C_003EwildcardTypeMetaModel;

	internal static ModuleExportsDirectiveMetaModel ___003C_003EmoduleExportsDirectiveMetaModel;

	internal static ModuleOpensDirectiveMetaModel ___003C_003EmoduleOpensDirectiveMetaModel;

	internal static ModuleProvidesDirectiveMetaModel ___003C_003EmoduleProvidesDirectiveMetaModel;

	internal static ModuleRequiresDirectiveMetaModel ___003C_003EmoduleRequiresDirectiveMetaModel;

	internal static ModuleUsesDirectiveMetaModel ___003C_003EmoduleUsesDirectiveMetaModel;

	
	public static NodeMetaModel nodeMetaModel
	{
		
		get
		{
			return ___003C_003EnodeMetaModel;
		}
	}

	
	public static BodyDeclarationMetaModel bodyDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EbodyDeclarationMetaModel;
		}
	}

	
	public static CallableDeclarationMetaModel callableDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EcallableDeclarationMetaModel;
		}
	}

	
	public static ExpressionMetaModel expressionMetaModel
	{
		
		get
		{
			return ___003C_003EexpressionMetaModel;
		}
	}

	
	public static StatementMetaModel statementMetaModel
	{
		
		get
		{
			return ___003C_003EstatementMetaModel;
		}
	}

	
	public static TypeMetaModel typeMetaModel
	{
		
		get
		{
			return ___003C_003EtypeMetaModel;
		}
	}

	
	public static AnnotationExprMetaModel annotationExprMetaModel
	{
		
		get
		{
			return ___003C_003EannotationExprMetaModel;
		}
	}

	
	public static ReferenceTypeMetaModel referenceTypeMetaModel
	{
		
		get
		{
			return ___003C_003EreferenceTypeMetaModel;
		}
	}

	
	public static TypeDeclarationMetaModel typeDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EtypeDeclarationMetaModel;
		}
	}

	
	public static LiteralExprMetaModel literalExprMetaModel
	{
		
		get
		{
			return ___003C_003EliteralExprMetaModel;
		}
	}

	
	public static LiteralStringValueExprMetaModel literalStringValueExprMetaModel
	{
		
		get
		{
			return ___003C_003EliteralStringValueExprMetaModel;
		}
	}

	
	public static StringLiteralExprMetaModel stringLiteralExprMetaModel
	{
		
		get
		{
			return ___003C_003EstringLiteralExprMetaModel;
		}
	}

	
	public static ModuleDeclarationMetaModel moduleDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EmoduleDeclarationMetaModel;
		}
	}

	
	public static ModuleDirectiveMetaModel moduleDirectiveMetaModel
	{
		
		get
		{
			return ___003C_003EmoduleDirectiveMetaModel;
		}
	}

	
	public static ArrayCreationLevelMetaModel arrayCreationLevelMetaModel
	{
		
		get
		{
			return ___003C_003EarrayCreationLevelMetaModel;
		}
	}

	
	public static CompilationUnitMetaModel compilationUnitMetaModel
	{
		
		get
		{
			return ___003C_003EcompilationUnitMetaModel;
		}
	}

	
	public static ImportDeclarationMetaModel importDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EimportDeclarationMetaModel;
		}
	}

	
	public static ModifierMetaModel modifierMetaModel
	{
		
		get
		{
			return ___003C_003EmodifierMetaModel;
		}
	}

	
	public static PackageDeclarationMetaModel packageDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EpackageDeclarationMetaModel;
		}
	}

	
	public static AnnotationDeclarationMetaModel annotationDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EannotationDeclarationMetaModel;
		}
	}

	
	public static AnnotationMemberDeclarationMetaModel annotationMemberDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EannotationMemberDeclarationMetaModel;
		}
	}

	
	public static ClassOrInterfaceDeclarationMetaModel classOrInterfaceDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EclassOrInterfaceDeclarationMetaModel;
		}
	}

	
	public static ConstructorDeclarationMetaModel constructorDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EconstructorDeclarationMetaModel;
		}
	}

	
	public static EnumConstantDeclarationMetaModel enumConstantDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EenumConstantDeclarationMetaModel;
		}
	}

	
	public static EnumDeclarationMetaModel enumDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EenumDeclarationMetaModel;
		}
	}

	
	public static FieldDeclarationMetaModel fieldDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EfieldDeclarationMetaModel;
		}
	}

	
	public static InitializerDeclarationMetaModel initializerDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EinitializerDeclarationMetaModel;
		}
	}

	
	public static MethodDeclarationMetaModel methodDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EmethodDeclarationMetaModel;
		}
	}

	
	public static ParameterMetaModel parameterMetaModel
	{
		
		get
		{
			return ___003C_003EparameterMetaModel;
		}
	}

	
	public static ReceiverParameterMetaModel receiverParameterMetaModel
	{
		
		get
		{
			return ___003C_003EreceiverParameterMetaModel;
		}
	}

	
	public static RecordDeclarationMetaModel recordDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003ErecordDeclarationMetaModel;
		}
	}

	
	public static CompactConstructorDeclarationMetaModel compactConstructorDeclarationMetaModel
	{
		
		get
		{
			return ___003C_003EcompactConstructorDeclarationMetaModel;
		}
	}

	
	public static VariableDeclaratorMetaModel variableDeclaratorMetaModel
	{
		
		get
		{
			return ___003C_003EvariableDeclaratorMetaModel;
		}
	}

	
	public static CommentMetaModel commentMetaModel
	{
		
		get
		{
			return ___003C_003EcommentMetaModel;
		}
	}

	
	public static BlockCommentMetaModel blockCommentMetaModel
	{
		
		get
		{
			return ___003C_003EblockCommentMetaModel;
		}
	}

	
	public static JavadocCommentMetaModel javadocCommentMetaModel
	{
		
		get
		{
			return ___003C_003EjavadocCommentMetaModel;
		}
	}

	
	public static LineCommentMetaModel lineCommentMetaModel
	{
		
		get
		{
			return ___003C_003ElineCommentMetaModel;
		}
	}

	
	public static ArrayAccessExprMetaModel arrayAccessExprMetaModel
	{
		
		get
		{
			return ___003C_003EarrayAccessExprMetaModel;
		}
	}

	
	public static ArrayCreationExprMetaModel arrayCreationExprMetaModel
	{
		
		get
		{
			return ___003C_003EarrayCreationExprMetaModel;
		}
	}

	
	public static ArrayInitializerExprMetaModel arrayInitializerExprMetaModel
	{
		
		get
		{
			return ___003C_003EarrayInitializerExprMetaModel;
		}
	}

	
	public static AssignExprMetaModel assignExprMetaModel
	{
		
		get
		{
			return ___003C_003EassignExprMetaModel;
		}
	}

	
	public static BinaryExprMetaModel binaryExprMetaModel
	{
		
		get
		{
			return ___003C_003EbinaryExprMetaModel;
		}
	}

	
	public static BooleanLiteralExprMetaModel booleanLiteralExprMetaModel
	{
		
		get
		{
			return ___003C_003EbooleanLiteralExprMetaModel;
		}
	}

	
	public static CastExprMetaModel castExprMetaModel
	{
		
		get
		{
			return ___003C_003EcastExprMetaModel;
		}
	}

	
	public static CharLiteralExprMetaModel charLiteralExprMetaModel
	{
		
		get
		{
			return ___003C_003EcharLiteralExprMetaModel;
		}
	}

	
	public static ClassExprMetaModel classExprMetaModel
	{
		
		get
		{
			return ___003C_003EclassExprMetaModel;
		}
	}

	
	public static ConditionalExprMetaModel conditionalExprMetaModel
	{
		
		get
		{
			return ___003C_003EconditionalExprMetaModel;
		}
	}

	
	public static DoubleLiteralExprMetaModel doubleLiteralExprMetaModel
	{
		
		get
		{
			return ___003C_003EdoubleLiteralExprMetaModel;
		}
	}

	
	public static EnclosedExprMetaModel enclosedExprMetaModel
	{
		
		get
		{
			return ___003C_003EenclosedExprMetaModel;
		}
	}

	
	public static FieldAccessExprMetaModel fieldAccessExprMetaModel
	{
		
		get
		{
			return ___003C_003EfieldAccessExprMetaModel;
		}
	}

	
	public static InstanceOfExprMetaModel instanceOfExprMetaModel
	{
		
		get
		{
			return ___003C_003EinstanceOfExprMetaModel;
		}
	}

	
	public static IntegerLiteralExprMetaModel integerLiteralExprMetaModel
	{
		
		get
		{
			return ___003C_003EintegerLiteralExprMetaModel;
		}
	}

	
	public static LambdaExprMetaModel lambdaExprMetaModel
	{
		
		get
		{
			return ___003C_003ElambdaExprMetaModel;
		}
	}

	
	public static LongLiteralExprMetaModel longLiteralExprMetaModel
	{
		
		get
		{
			return ___003C_003ElongLiteralExprMetaModel;
		}
	}

	
	public static MarkerAnnotationExprMetaModel markerAnnotationExprMetaModel
	{
		
		get
		{
			return ___003C_003EmarkerAnnotationExprMetaModel;
		}
	}

	
	public static MemberValuePairMetaModel memberValuePairMetaModel
	{
		
		get
		{
			return ___003C_003EmemberValuePairMetaModel;
		}
	}

	
	public static MethodCallExprMetaModel methodCallExprMetaModel
	{
		
		get
		{
			return ___003C_003EmethodCallExprMetaModel;
		}
	}

	
	public static MethodReferenceExprMetaModel methodReferenceExprMetaModel
	{
		
		get
		{
			return ___003C_003EmethodReferenceExprMetaModel;
		}
	}

	
	public static NameExprMetaModel nameExprMetaModel
	{
		
		get
		{
			return ___003C_003EnameExprMetaModel;
		}
	}

	
	public static NameMetaModel nameMetaModel
	{
		
		get
		{
			return ___003C_003EnameMetaModel;
		}
	}

	
	public static NormalAnnotationExprMetaModel normalAnnotationExprMetaModel
	{
		
		get
		{
			return ___003C_003EnormalAnnotationExprMetaModel;
		}
	}

	
	public static NullLiteralExprMetaModel nullLiteralExprMetaModel
	{
		
		get
		{
			return ___003C_003EnullLiteralExprMetaModel;
		}
	}

	
	public static ObjectCreationExprMetaModel objectCreationExprMetaModel
	{
		
		get
		{
			return ___003C_003EobjectCreationExprMetaModel;
		}
	}

	
	public static PatternExprMetaModel patternExprMetaModel
	{
		
		get
		{
			return ___003C_003EpatternExprMetaModel;
		}
	}

	
	public static SingleMemberAnnotationExprMetaModel singleMemberAnnotationExprMetaModel
	{
		
		get
		{
			return ___003C_003EsingleMemberAnnotationExprMetaModel;
		}
	}

	
	public static SimpleNameMetaModel simpleNameMetaModel
	{
		
		get
		{
			return ___003C_003EsimpleNameMetaModel;
		}
	}

	
	public static SuperExprMetaModel superExprMetaModel
	{
		
		get
		{
			return ___003C_003EsuperExprMetaModel;
		}
	}

	
	public static SwitchExprMetaModel switchExprMetaModel
	{
		
		get
		{
			return ___003C_003EswitchExprMetaModel;
		}
	}

	
	public static TextBlockLiteralExprMetaModel textBlockLiteralExprMetaModel
	{
		
		get
		{
			return ___003C_003EtextBlockLiteralExprMetaModel;
		}
	}

	
	public static ThisExprMetaModel thisExprMetaModel
	{
		
		get
		{
			return ___003C_003EthisExprMetaModel;
		}
	}

	
	public static TypeExprMetaModel typeExprMetaModel
	{
		
		get
		{
			return ___003C_003EtypeExprMetaModel;
		}
	}

	
	public static UnaryExprMetaModel unaryExprMetaModel
	{
		
		get
		{
			return ___003C_003EunaryExprMetaModel;
		}
	}

	
	public static VariableDeclarationExprMetaModel variableDeclarationExprMetaModel
	{
		
		get
		{
			return ___003C_003EvariableDeclarationExprMetaModel;
		}
	}

	
	public static AssertStmtMetaModel assertStmtMetaModel
	{
		
		get
		{
			return ___003C_003EassertStmtMetaModel;
		}
	}

	
	public static BlockStmtMetaModel blockStmtMetaModel
	{
		
		get
		{
			return ___003C_003EblockStmtMetaModel;
		}
	}

	
	public static BreakStmtMetaModel breakStmtMetaModel
	{
		
		get
		{
			return ___003C_003EbreakStmtMetaModel;
		}
	}

	
	public static CatchClauseMetaModel catchClauseMetaModel
	{
		
		get
		{
			return ___003C_003EcatchClauseMetaModel;
		}
	}

	
	public static ContinueStmtMetaModel continueStmtMetaModel
	{
		
		get
		{
			return ___003C_003EcontinueStmtMetaModel;
		}
	}

	
	public static DoStmtMetaModel doStmtMetaModel
	{
		
		get
		{
			return ___003C_003EdoStmtMetaModel;
		}
	}

	
	public static EmptyStmtMetaModel emptyStmtMetaModel
	{
		
		get
		{
			return ___003C_003EemptyStmtMetaModel;
		}
	}

	
	public static ExplicitConstructorInvocationStmtMetaModel explicitConstructorInvocationStmtMetaModel
	{
		
		get
		{
			return ___003C_003EexplicitConstructorInvocationStmtMetaModel;
		}
	}

	
	public static ExpressionStmtMetaModel expressionStmtMetaModel
	{
		
		get
		{
			return ___003C_003EexpressionStmtMetaModel;
		}
	}

	
	public static ForEachStmtMetaModel forEachStmtMetaModel
	{
		
		get
		{
			return ___003C_003EforEachStmtMetaModel;
		}
	}

	
	public static ForStmtMetaModel forStmtMetaModel
	{
		
		get
		{
			return ___003C_003EforStmtMetaModel;
		}
	}

	
	public static IfStmtMetaModel ifStmtMetaModel
	{
		
		get
		{
			return ___003C_003EifStmtMetaModel;
		}
	}

	
	public static LabeledStmtMetaModel labeledStmtMetaModel
	{
		
		get
		{
			return ___003C_003ElabeledStmtMetaModel;
		}
	}

	
	public static LocalClassDeclarationStmtMetaModel localClassDeclarationStmtMetaModel
	{
		
		get
		{
			return ___003C_003ElocalClassDeclarationStmtMetaModel;
		}
	}

	
	public static LocalRecordDeclarationStmtMetaModel localRecordDeclarationStmtMetaModel
	{
		
		get
		{
			return ___003C_003ElocalRecordDeclarationStmtMetaModel;
		}
	}

	
	public static ReturnStmtMetaModel returnStmtMetaModel
	{
		
		get
		{
			return ___003C_003EreturnStmtMetaModel;
		}
	}

	
	public static SwitchEntryMetaModel switchEntryMetaModel
	{
		
		get
		{
			return ___003C_003EswitchEntryMetaModel;
		}
	}

	
	public static SwitchStmtMetaModel switchStmtMetaModel
	{
		
		get
		{
			return ___003C_003EswitchStmtMetaModel;
		}
	}

	
	public static SynchronizedStmtMetaModel synchronizedStmtMetaModel
	{
		
		get
		{
			return ___003C_003EsynchronizedStmtMetaModel;
		}
	}

	
	public static ThrowStmtMetaModel throwStmtMetaModel
	{
		
		get
		{
			return ___003C_003EthrowStmtMetaModel;
		}
	}

	
	public static TryStmtMetaModel tryStmtMetaModel
	{
		
		get
		{
			return ___003C_003EtryStmtMetaModel;
		}
	}

	
	public static UnparsableStmtMetaModel unparsableStmtMetaModel
	{
		
		get
		{
			return ___003C_003EunparsableStmtMetaModel;
		}
	}

	
	public static WhileStmtMetaModel whileStmtMetaModel
	{
		
		get
		{
			return ___003C_003EwhileStmtMetaModel;
		}
	}

	
	public static YieldStmtMetaModel yieldStmtMetaModel
	{
		
		get
		{
			return ___003C_003EyieldStmtMetaModel;
		}
	}

	
	public static ArrayTypeMetaModel arrayTypeMetaModel
	{
		
		get
		{
			return ___003C_003EarrayTypeMetaModel;
		}
	}

	
	public static ClassOrInterfaceTypeMetaModel classOrInterfaceTypeMetaModel
	{
		
		get
		{
			return ___003C_003EclassOrInterfaceTypeMetaModel;
		}
	}

	
	public static IntersectionTypeMetaModel intersectionTypeMetaModel
	{
		
		get
		{
			return ___003C_003EintersectionTypeMetaModel;
		}
	}

	
	public static PrimitiveTypeMetaModel primitiveTypeMetaModel
	{
		
		get
		{
			return ___003C_003EprimitiveTypeMetaModel;
		}
	}

	
	public static TypeParameterMetaModel typeParameterMetaModel
	{
		
		get
		{
			return ___003C_003EtypeParameterMetaModel;
		}
	}

	
	public static UnionTypeMetaModel unionTypeMetaModel
	{
		
		get
		{
			return ___003C_003EunionTypeMetaModel;
		}
	}

	
	public static UnknownTypeMetaModel unknownTypeMetaModel
	{
		
		get
		{
			return ___003C_003EunknownTypeMetaModel;
		}
	}

	
	public static VarTypeMetaModel varTypeMetaModel
	{
		
		get
		{
			return ___003C_003EvarTypeMetaModel;
		}
	}

	
	public static VoidTypeMetaModel voidTypeMetaModel
	{
		
		get
		{
			return ___003C_003EvoidTypeMetaModel;
		}
	}

	
	public static WildcardTypeMetaModel wildcardTypeMetaModel
	{
		
		get
		{
			return ___003C_003EwildcardTypeMetaModel;
		}
	}

	
	public static ModuleExportsDirectiveMetaModel moduleExportsDirectiveMetaModel
	{
		
		get
		{
			return ___003C_003EmoduleExportsDirectiveMetaModel;
		}
	}

	
	public static ModuleOpensDirectiveMetaModel moduleOpensDirectiveMetaModel
	{
		
		get
		{
			return ___003C_003EmoduleOpensDirectiveMetaModel;
		}
	}

	
	public static ModuleProvidesDirectiveMetaModel moduleProvidesDirectiveMetaModel
	{
		
		get
		{
			return ___003C_003EmoduleProvidesDirectiveMetaModel;
		}
	}

	
	public static ModuleRequiresDirectiveMetaModel moduleRequiresDirectiveMetaModel
	{
		
		get
		{
			return ___003C_003EmoduleRequiresDirectiveMetaModel;
		}
	}

	
	public static ModuleUsesDirectiveMetaModel moduleUsesDirectiveMetaModel
	{
		
		get
		{
			return ___003C_003EmoduleUsesDirectiveMetaModel;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

		public static List getNodeMetaModels()
	{
		return nodeMetaModels;
	}

	
	[LineNumberTable(new byte[]
	{
		160, 185, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 112, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 112, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 112, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 112, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 112, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 112, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 112, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 112, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 112, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 112, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 112, 112, 112
	})]
	private static void initializeNodeMetaModels()
	{
		nodeMetaModels.add(___003C_003EannotationDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EannotationExprMetaModel);
		nodeMetaModels.add(___003C_003EannotationMemberDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EarrayAccessExprMetaModel);
		nodeMetaModels.add(___003C_003EarrayCreationExprMetaModel);
		nodeMetaModels.add(___003C_003EarrayCreationLevelMetaModel);
		nodeMetaModels.add(___003C_003EarrayInitializerExprMetaModel);
		nodeMetaModels.add(___003C_003EarrayTypeMetaModel);
		nodeMetaModels.add(___003C_003EassertStmtMetaModel);
		nodeMetaModels.add(___003C_003EassignExprMetaModel);
		nodeMetaModels.add(___003C_003EbinaryExprMetaModel);
		nodeMetaModels.add(___003C_003EblockCommentMetaModel);
		nodeMetaModels.add(___003C_003EblockStmtMetaModel);
		nodeMetaModels.add(___003C_003EbodyDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EbooleanLiteralExprMetaModel);
		nodeMetaModels.add(___003C_003EbreakStmtMetaModel);
		nodeMetaModels.add(___003C_003EcallableDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EcastExprMetaModel);
		nodeMetaModels.add(___003C_003EcatchClauseMetaModel);
		nodeMetaModels.add(___003C_003EcharLiteralExprMetaModel);
		nodeMetaModels.add(___003C_003EclassExprMetaModel);
		nodeMetaModels.add(___003C_003EclassOrInterfaceDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EclassOrInterfaceTypeMetaModel);
		nodeMetaModels.add(___003C_003EcommentMetaModel);
		nodeMetaModels.add(___003C_003EcompactConstructorDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EcompilationUnitMetaModel);
		nodeMetaModels.add(___003C_003EconditionalExprMetaModel);
		nodeMetaModels.add(___003C_003EconstructorDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EcontinueStmtMetaModel);
		nodeMetaModels.add(___003C_003EdoStmtMetaModel);
		nodeMetaModels.add(___003C_003EdoubleLiteralExprMetaModel);
		nodeMetaModels.add(___003C_003EemptyStmtMetaModel);
		nodeMetaModels.add(___003C_003EenclosedExprMetaModel);
		nodeMetaModels.add(___003C_003EenumConstantDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EenumDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EexplicitConstructorInvocationStmtMetaModel);
		nodeMetaModels.add(___003C_003EexpressionMetaModel);
		nodeMetaModels.add(___003C_003EexpressionStmtMetaModel);
		nodeMetaModels.add(___003C_003EfieldAccessExprMetaModel);
		nodeMetaModels.add(___003C_003EfieldDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EforEachStmtMetaModel);
		nodeMetaModels.add(___003C_003EforStmtMetaModel);
		nodeMetaModels.add(___003C_003EifStmtMetaModel);
		nodeMetaModels.add(___003C_003EimportDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EinitializerDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EinstanceOfExprMetaModel);
		nodeMetaModels.add(___003C_003EintegerLiteralExprMetaModel);
		nodeMetaModels.add(___003C_003EintersectionTypeMetaModel);
		nodeMetaModels.add(___003C_003EjavadocCommentMetaModel);
		nodeMetaModels.add(___003C_003ElabeledStmtMetaModel);
		nodeMetaModels.add(___003C_003ElambdaExprMetaModel);
		nodeMetaModels.add(___003C_003ElineCommentMetaModel);
		nodeMetaModels.add(___003C_003EliteralExprMetaModel);
		nodeMetaModels.add(___003C_003EliteralStringValueExprMetaModel);
		nodeMetaModels.add(___003C_003ElocalClassDeclarationStmtMetaModel);
		nodeMetaModels.add(___003C_003ElocalRecordDeclarationStmtMetaModel);
		nodeMetaModels.add(___003C_003ElongLiteralExprMetaModel);
		nodeMetaModels.add(___003C_003EmarkerAnnotationExprMetaModel);
		nodeMetaModels.add(___003C_003EmemberValuePairMetaModel);
		nodeMetaModels.add(___003C_003EmethodCallExprMetaModel);
		nodeMetaModels.add(___003C_003EmethodDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EmethodReferenceExprMetaModel);
		nodeMetaModels.add(___003C_003EmodifierMetaModel);
		nodeMetaModels.add(___003C_003EmoduleDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EmoduleDirectiveMetaModel);
		nodeMetaModels.add(___003C_003EmoduleExportsDirectiveMetaModel);
		nodeMetaModels.add(___003C_003EmoduleOpensDirectiveMetaModel);
		nodeMetaModels.add(___003C_003EmoduleProvidesDirectiveMetaModel);
		nodeMetaModels.add(___003C_003EmoduleRequiresDirectiveMetaModel);
		nodeMetaModels.add(___003C_003EmoduleUsesDirectiveMetaModel);
		nodeMetaModels.add(___003C_003EnameExprMetaModel);
		nodeMetaModels.add(___003C_003EnameMetaModel);
		nodeMetaModels.add(___003C_003EnodeMetaModel);
		nodeMetaModels.add(___003C_003EnormalAnnotationExprMetaModel);
		nodeMetaModels.add(___003C_003EnullLiteralExprMetaModel);
		nodeMetaModels.add(___003C_003EobjectCreationExprMetaModel);
		nodeMetaModels.add(___003C_003EpackageDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EparameterMetaModel);
		nodeMetaModels.add(___003C_003EpatternExprMetaModel);
		nodeMetaModels.add(___003C_003EprimitiveTypeMetaModel);
		nodeMetaModels.add(___003C_003EreceiverParameterMetaModel);
		nodeMetaModels.add(___003C_003ErecordDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EreferenceTypeMetaModel);
		nodeMetaModels.add(___003C_003EreturnStmtMetaModel);
		nodeMetaModels.add(___003C_003EsimpleNameMetaModel);
		nodeMetaModels.add(___003C_003EsingleMemberAnnotationExprMetaModel);
		nodeMetaModels.add(___003C_003EstatementMetaModel);
		nodeMetaModels.add(___003C_003EstringLiteralExprMetaModel);
		nodeMetaModels.add(___003C_003EsuperExprMetaModel);
		nodeMetaModels.add(___003C_003EswitchEntryMetaModel);
		nodeMetaModels.add(___003C_003EswitchExprMetaModel);
		nodeMetaModels.add(___003C_003EswitchStmtMetaModel);
		nodeMetaModels.add(___003C_003EsynchronizedStmtMetaModel);
		nodeMetaModels.add(___003C_003EtextBlockLiteralExprMetaModel);
		nodeMetaModels.add(___003C_003EthisExprMetaModel);
		nodeMetaModels.add(___003C_003EthrowStmtMetaModel);
		nodeMetaModels.add(___003C_003EtryStmtMetaModel);
		nodeMetaModels.add(___003C_003EtypeDeclarationMetaModel);
		nodeMetaModels.add(___003C_003EtypeExprMetaModel);
		nodeMetaModels.add(___003C_003EtypeMetaModel);
		nodeMetaModels.add(___003C_003EtypeParameterMetaModel);
		nodeMetaModels.add(___003C_003EunaryExprMetaModel);
		nodeMetaModels.add(___003C_003EunionTypeMetaModel);
		nodeMetaModels.add(___003C_003EunknownTypeMetaModel);
		nodeMetaModels.add(___003C_003EunparsableStmtMetaModel);
		nodeMetaModels.add(___003C_003EvarTypeMetaModel);
		nodeMetaModels.add(___003C_003EvariableDeclarationExprMetaModel);
		nodeMetaModels.add(___003C_003EvariableDeclaratorMetaModel);
		nodeMetaModels.add(___003C_003EvoidTypeMetaModel);
		nodeMetaModels.add(___003C_003EwhileStmtMetaModel);
		nodeMetaModels.add(___003C_003EwildcardTypeMetaModel);
		nodeMetaModels.add(___003C_003EyieldStmtMetaModel);
	}

	
	[LineNumberTable(new byte[]
	{
		161, 45, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 13, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 8, 122, 127, 13, 122, 127, 13, 122,
		127, 8, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 8, 122, 127, 8, 122,
		127, 13, 122, 127, 8, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 8, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 13, 122, 127, 13, 122, 127, 8, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 8,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 13, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 13, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 8,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 13, 122, 127, 13, 122, 127, 13, 122, 127,
		8, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 8, 122, 127, 13, 122, 127, 8, 122,
		127, 13, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 8, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 8, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 13, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 8, 122, 127, 8, 122, 127, 13,
		122, 127, 13, 122, 127, 8, 122, 127, 13, 122,
		127, 8, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 8, 122, 127, 13, 122,
		127, 13, 122, 127, 13, 122, 127, 8, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 8, 122,
		127, 8, 122, 127, 8, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 13, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 8, 122, 127, 13, 122, 127, 8, 122,
		127, 13, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 13, 122, 127, 8, 122, 127, 8, 122, 127,
		8, 122, 127, 8, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 13, 122, 127, 13, 122, 127, 8, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 13, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 8,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 8, 122, 127, 13, 122, 127, 8, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122, 127, 13, 122, 127, 13, 122, 127, 13, 122,
		127, 13, 122, 127, 13, 122, 127, 13, 122, 127,
		13, 122, 127, 13, 122, 127, 13, 122, 127, 13,
		122
	})]
	private static void initializePropertyMetaModels()
	{
		___003C_003EnodeMetaModel.commentPropertyMetaModel = new PropertyMetaModel(___003C_003EnodeMetaModel, "comment", ClassLiteral<Comment>.Value, Optional.of(___003C_003EcommentMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EnodeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EnodeMetaModel.commentPropertyMetaModel);
		___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel = new PropertyMetaModel(___003C_003EbodyDeclarationMetaModel, "annotations", ClassLiteral<AnnotationExpr>.Value, Optional.of(___003C_003EannotationExprMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EbodyDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.modifiersPropertyMetaModel = new PropertyMetaModel(___003C_003EcallableDeclarationMetaModel, "modifiers", ClassLiteral<Modifier>.Value, Optional.of(___003C_003EmodifierMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EcallableDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcallableDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EcallableDeclarationMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcallableDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcallableDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.parametersPropertyMetaModel = new PropertyMetaModel(___003C_003EcallableDeclarationMetaModel, "parameters", ClassLiteral<Parameter>.Value, Optional.of(___003C_003EparameterMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EcallableDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcallableDeclarationMetaModel.parametersPropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.receiverParameterPropertyMetaModel = new PropertyMetaModel(___003C_003EcallableDeclarationMetaModel, "receiverParameter", ClassLiteral<ReceiverParameter>.Value, Optional.of(___003C_003EreceiverParameterMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcallableDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcallableDeclarationMetaModel.receiverParameterPropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.thrownExceptionsPropertyMetaModel = new PropertyMetaModel(___003C_003EcallableDeclarationMetaModel, "thrownExceptions", ClassLiteral<ReferenceType>.Value, Optional.of(___003C_003EreferenceTypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EcallableDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcallableDeclarationMetaModel.thrownExceptionsPropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.typeParametersPropertyMetaModel = new PropertyMetaModel(___003C_003EcallableDeclarationMetaModel, "typeParameters", ClassLiteral<TypeParameter>.Value, Optional.of(___003C_003EtypeParameterMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EcallableDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcallableDeclarationMetaModel.typeParametersPropertyMetaModel);
		___003C_003EtypeMetaModel.annotationsPropertyMetaModel = new PropertyMetaModel(___003C_003EtypeMetaModel, "annotations", ClassLiteral<AnnotationExpr>.Value, Optional.of(___003C_003EannotationExprMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EtypeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EtypeMetaModel.annotationsPropertyMetaModel);
		___003C_003EannotationExprMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EannotationExprMetaModel, "name", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EannotationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EannotationExprMetaModel.namePropertyMetaModel);
		___003C_003EtypeDeclarationMetaModel.membersPropertyMetaModel = new PropertyMetaModel(___003C_003EtypeDeclarationMetaModel, "members", ClassLiteral<BodyDeclaration>.Value, Optional.of(___003C_003EbodyDeclarationMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: true);
		___003C_003EtypeDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EtypeDeclarationMetaModel.membersPropertyMetaModel);
		___003C_003EtypeDeclarationMetaModel.modifiersPropertyMetaModel = new PropertyMetaModel(___003C_003EtypeDeclarationMetaModel, "modifiers", ClassLiteral<Modifier>.Value, Optional.of(___003C_003EmodifierMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EtypeDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EtypeDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EtypeDeclarationMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EtypeDeclarationMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EtypeDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EtypeDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EliteralStringValueExprMetaModel.valuePropertyMetaModel = new PropertyMetaModel(___003C_003EliteralStringValueExprMetaModel, "value", ClassLiteral<String>.Value, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EliteralStringValueExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EliteralStringValueExprMetaModel.valuePropertyMetaModel);
		___003C_003EmoduleDeclarationMetaModel.annotationsPropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleDeclarationMetaModel, "annotations", ClassLiteral<AnnotationExpr>.Value, Optional.of(___003C_003EannotationExprMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EmoduleDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EmoduleDeclarationMetaModel.directivesPropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleDeclarationMetaModel, "directives", ClassLiteral<ModuleDirective>.Value, Optional.of(___003C_003EmoduleDirectiveMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EmoduleDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleDeclarationMetaModel.directivesPropertyMetaModel);
		___003C_003EmoduleDeclarationMetaModel.isOpenPropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleDeclarationMetaModel, "isOpen", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmoduleDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleDeclarationMetaModel.isOpenPropertyMetaModel);
		___003C_003EmoduleDeclarationMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleDeclarationMetaModel, "name", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmoduleDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EarrayCreationLevelMetaModel.annotationsPropertyMetaModel = new PropertyMetaModel(___003C_003EarrayCreationLevelMetaModel, "annotations", ClassLiteral<AnnotationExpr>.Value, Optional.of(___003C_003EannotationExprMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EarrayCreationLevelMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EarrayCreationLevelMetaModel.annotationsPropertyMetaModel);
		___003C_003EarrayCreationLevelMetaModel.dimensionPropertyMetaModel = new PropertyMetaModel(___003C_003EarrayCreationLevelMetaModel, "dimension", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EarrayCreationLevelMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EarrayCreationLevelMetaModel.dimensionPropertyMetaModel);
		___003C_003EcompilationUnitMetaModel.importsPropertyMetaModel = new PropertyMetaModel(___003C_003EcompilationUnitMetaModel, "imports", ClassLiteral<ImportDeclaration>.Value, Optional.of(___003C_003EimportDeclarationMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EcompilationUnitMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcompilationUnitMetaModel.importsPropertyMetaModel);
		___003C_003EcompilationUnitMetaModel.modulePropertyMetaModel = new PropertyMetaModel(___003C_003EcompilationUnitMetaModel, "module", ClassLiteral<ModuleDeclaration>.Value, Optional.of(___003C_003EmoduleDeclarationMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcompilationUnitMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcompilationUnitMetaModel.modulePropertyMetaModel);
		___003C_003EcompilationUnitMetaModel.packageDeclarationPropertyMetaModel = new PropertyMetaModel(___003C_003EcompilationUnitMetaModel, "packageDeclaration", ClassLiteral<PackageDeclaration>.Value, Optional.of(___003C_003EpackageDeclarationMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcompilationUnitMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcompilationUnitMetaModel.packageDeclarationPropertyMetaModel);
		___003C_003EcompilationUnitMetaModel.typesPropertyMetaModel = new PropertyMetaModel(___003C_003EcompilationUnitMetaModel, "types", ClassLiteral<TypeDeclaration>.Value, Optional.of(___003C_003EtypeDeclarationMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: true);
		___003C_003EcompilationUnitMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcompilationUnitMetaModel.typesPropertyMetaModel);
		___003C_003EimportDeclarationMetaModel.isAsteriskPropertyMetaModel = new PropertyMetaModel(___003C_003EimportDeclarationMetaModel, "isAsterisk", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EimportDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EimportDeclarationMetaModel.isAsteriskPropertyMetaModel);
		___003C_003EimportDeclarationMetaModel.isStaticPropertyMetaModel = new PropertyMetaModel(___003C_003EimportDeclarationMetaModel, "isStatic", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EimportDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EimportDeclarationMetaModel.isStaticPropertyMetaModel);
		___003C_003EimportDeclarationMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EimportDeclarationMetaModel, "name", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EimportDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EimportDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EmodifierMetaModel.keywordPropertyMetaModel = new PropertyMetaModel(___003C_003EmodifierMetaModel, "keyword", ClassLiteral<Modifier.Keyword>.Value, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmodifierMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmodifierMetaModel.keywordPropertyMetaModel);
		___003C_003EpackageDeclarationMetaModel.annotationsPropertyMetaModel = new PropertyMetaModel(___003C_003EpackageDeclarationMetaModel, "annotations", ClassLiteral<AnnotationExpr>.Value, Optional.of(___003C_003EannotationExprMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EpackageDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EpackageDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EpackageDeclarationMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EpackageDeclarationMetaModel, "name", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EpackageDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EpackageDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EannotationMemberDeclarationMetaModel.defaultValuePropertyMetaModel = new PropertyMetaModel(___003C_003EannotationMemberDeclarationMetaModel, "defaultValue", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EannotationMemberDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EannotationMemberDeclarationMetaModel.defaultValuePropertyMetaModel);
		___003C_003EannotationMemberDeclarationMetaModel.modifiersPropertyMetaModel = new PropertyMetaModel(___003C_003EannotationMemberDeclarationMetaModel, "modifiers", ClassLiteral<Modifier>.Value, Optional.of(___003C_003EmodifierMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EannotationMemberDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EannotationMemberDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EannotationMemberDeclarationMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EannotationMemberDeclarationMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EannotationMemberDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EannotationMemberDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EannotationMemberDeclarationMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EannotationMemberDeclarationMetaModel, "type", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EannotationMemberDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EannotationMemberDeclarationMetaModel.typePropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.extendedTypesPropertyMetaModel = new PropertyMetaModel(___003C_003EclassOrInterfaceDeclarationMetaModel, "extendedTypes", ClassLiteral<ClassOrInterfaceType>.Value, Optional.of(___003C_003EclassOrInterfaceTypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EclassOrInterfaceDeclarationMetaModel.extendedTypesPropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.implementedTypesPropertyMetaModel = new PropertyMetaModel(___003C_003EclassOrInterfaceDeclarationMetaModel, "implementedTypes", ClassLiteral<ClassOrInterfaceType>.Value, Optional.of(___003C_003EclassOrInterfaceTypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EclassOrInterfaceDeclarationMetaModel.implementedTypesPropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.isInterfacePropertyMetaModel = new PropertyMetaModel(___003C_003EclassOrInterfaceDeclarationMetaModel, "isInterface", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EclassOrInterfaceDeclarationMetaModel.isInterfacePropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.typeParametersPropertyMetaModel = new PropertyMetaModel(___003C_003EclassOrInterfaceDeclarationMetaModel, "typeParameters", ClassLiteral<TypeParameter>.Value, Optional.of(___003C_003EtypeParameterMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EclassOrInterfaceDeclarationMetaModel.typeParametersPropertyMetaModel);
		___003C_003EconstructorDeclarationMetaModel.bodyPropertyMetaModel = new PropertyMetaModel(___003C_003EconstructorDeclarationMetaModel, "body", ClassLiteral<BlockStmt>.Value, Optional.of(___003C_003EblockStmtMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EconstructorDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EconstructorDeclarationMetaModel.bodyPropertyMetaModel);
		___003C_003EenumConstantDeclarationMetaModel.argumentsPropertyMetaModel = new PropertyMetaModel(___003C_003EenumConstantDeclarationMetaModel, "arguments", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EenumConstantDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EenumConstantDeclarationMetaModel.argumentsPropertyMetaModel);
		___003C_003EenumConstantDeclarationMetaModel.classBodyPropertyMetaModel = new PropertyMetaModel(___003C_003EenumConstantDeclarationMetaModel, "classBody", ClassLiteral<BodyDeclaration>.Value, Optional.of(___003C_003EbodyDeclarationMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: true);
		___003C_003EenumConstantDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EenumConstantDeclarationMetaModel.classBodyPropertyMetaModel);
		___003C_003EenumConstantDeclarationMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EenumConstantDeclarationMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EenumConstantDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EenumConstantDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EenumDeclarationMetaModel.entriesPropertyMetaModel = new PropertyMetaModel(___003C_003EenumDeclarationMetaModel, "entries", ClassLiteral<EnumConstantDeclaration>.Value, Optional.of(___003C_003EenumConstantDeclarationMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EenumDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EenumDeclarationMetaModel.entriesPropertyMetaModel);
		___003C_003EenumDeclarationMetaModel.implementedTypesPropertyMetaModel = new PropertyMetaModel(___003C_003EenumDeclarationMetaModel, "implementedTypes", ClassLiteral<ClassOrInterfaceType>.Value, Optional.of(___003C_003EclassOrInterfaceTypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EenumDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EenumDeclarationMetaModel.implementedTypesPropertyMetaModel);
		___003C_003EfieldDeclarationMetaModel.modifiersPropertyMetaModel = new PropertyMetaModel(___003C_003EfieldDeclarationMetaModel, "modifiers", ClassLiteral<Modifier>.Value, Optional.of(___003C_003EmodifierMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EfieldDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EfieldDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EfieldDeclarationMetaModel.variablesPropertyMetaModel = new PropertyMetaModel(___003C_003EfieldDeclarationMetaModel, "variables", ClassLiteral<VariableDeclarator>.Value, Optional.of(___003C_003EvariableDeclaratorMetaModel), isOptional: false, isNonEmpty: true, isNodeList: true, hasWildcard: false);
		___003C_003EfieldDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EfieldDeclarationMetaModel.variablesPropertyMetaModel);
		___003C_003EfieldDeclarationMetaModel.maximumCommonTypePropertyMetaModel = new PropertyMetaModel(___003C_003EfieldDeclarationMetaModel, "maximumCommonType", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EfieldDeclarationMetaModel.getDerivedPropertyMetaModels().add(___003C_003EfieldDeclarationMetaModel.maximumCommonTypePropertyMetaModel);
		___003C_003EinitializerDeclarationMetaModel.bodyPropertyMetaModel = new PropertyMetaModel(___003C_003EinitializerDeclarationMetaModel, "body", ClassLiteral<BlockStmt>.Value, Optional.of(___003C_003EblockStmtMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EinitializerDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EinitializerDeclarationMetaModel.bodyPropertyMetaModel);
		___003C_003EinitializerDeclarationMetaModel.isStaticPropertyMetaModel = new PropertyMetaModel(___003C_003EinitializerDeclarationMetaModel, "isStatic", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EinitializerDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EinitializerDeclarationMetaModel.isStaticPropertyMetaModel);
		___003C_003EmethodDeclarationMetaModel.bodyPropertyMetaModel = new PropertyMetaModel(___003C_003EmethodDeclarationMetaModel, "body", ClassLiteral<BlockStmt>.Value, Optional.of(___003C_003EblockStmtMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmethodDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmethodDeclarationMetaModel.bodyPropertyMetaModel);
		___003C_003EmethodDeclarationMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EmethodDeclarationMetaModel, "type", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmethodDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmethodDeclarationMetaModel.typePropertyMetaModel);
		___003C_003EparameterMetaModel.annotationsPropertyMetaModel = new PropertyMetaModel(___003C_003EparameterMetaModel, "annotations", ClassLiteral<AnnotationExpr>.Value, Optional.of(___003C_003EannotationExprMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EparameterMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EparameterMetaModel.annotationsPropertyMetaModel);
		___003C_003EparameterMetaModel.isVarArgsPropertyMetaModel = new PropertyMetaModel(___003C_003EparameterMetaModel, "isVarArgs", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EparameterMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EparameterMetaModel.isVarArgsPropertyMetaModel);
		___003C_003EparameterMetaModel.modifiersPropertyMetaModel = new PropertyMetaModel(___003C_003EparameterMetaModel, "modifiers", ClassLiteral<Modifier>.Value, Optional.of(___003C_003EmodifierMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EparameterMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EparameterMetaModel.modifiersPropertyMetaModel);
		___003C_003EparameterMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EparameterMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EparameterMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EparameterMetaModel.namePropertyMetaModel);
		___003C_003EparameterMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EparameterMetaModel, "type", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EparameterMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EparameterMetaModel.typePropertyMetaModel);
		___003C_003EparameterMetaModel.varArgsAnnotationsPropertyMetaModel = new PropertyMetaModel(___003C_003EparameterMetaModel, "varArgsAnnotations", ClassLiteral<AnnotationExpr>.Value, Optional.of(___003C_003EannotationExprMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EparameterMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EparameterMetaModel.varArgsAnnotationsPropertyMetaModel);
		___003C_003EreceiverParameterMetaModel.annotationsPropertyMetaModel = new PropertyMetaModel(___003C_003EreceiverParameterMetaModel, "annotations", ClassLiteral<AnnotationExpr>.Value, Optional.of(___003C_003EannotationExprMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EreceiverParameterMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EreceiverParameterMetaModel.annotationsPropertyMetaModel);
		___003C_003EreceiverParameterMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EreceiverParameterMetaModel, "name", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EreceiverParameterMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EreceiverParameterMetaModel.namePropertyMetaModel);
		___003C_003EreceiverParameterMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EreceiverParameterMetaModel, "type", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EreceiverParameterMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EreceiverParameterMetaModel.typePropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.implementedTypesPropertyMetaModel = new PropertyMetaModel(___003C_003ErecordDeclarationMetaModel, "implementedTypes", ClassLiteral<ClassOrInterfaceType>.Value, Optional.of(___003C_003EclassOrInterfaceTypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003ErecordDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003ErecordDeclarationMetaModel.implementedTypesPropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.parametersPropertyMetaModel = new PropertyMetaModel(___003C_003ErecordDeclarationMetaModel, "parameters", ClassLiteral<Parameter>.Value, Optional.of(___003C_003EparameterMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003ErecordDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003ErecordDeclarationMetaModel.parametersPropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.receiverParameterPropertyMetaModel = new PropertyMetaModel(___003C_003ErecordDeclarationMetaModel, "receiverParameter", ClassLiteral<ReceiverParameter>.Value, Optional.of(___003C_003EreceiverParameterMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003ErecordDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003ErecordDeclarationMetaModel.receiverParameterPropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.typeParametersPropertyMetaModel = new PropertyMetaModel(___003C_003ErecordDeclarationMetaModel, "typeParameters", ClassLiteral<TypeParameter>.Value, Optional.of(___003C_003EtypeParameterMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003ErecordDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003ErecordDeclarationMetaModel.typeParametersPropertyMetaModel);
		___003C_003EcompactConstructorDeclarationMetaModel.bodyPropertyMetaModel = new PropertyMetaModel(___003C_003EcompactConstructorDeclarationMetaModel, "body", ClassLiteral<BlockStmt>.Value, Optional.of(___003C_003EblockStmtMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcompactConstructorDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcompactConstructorDeclarationMetaModel.bodyPropertyMetaModel);
		___003C_003EcompactConstructorDeclarationMetaModel.modifiersPropertyMetaModel = new PropertyMetaModel(___003C_003EcompactConstructorDeclarationMetaModel, "modifiers", ClassLiteral<Modifier>.Value, Optional.of(___003C_003EmodifierMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EcompactConstructorDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcompactConstructorDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EcompactConstructorDeclarationMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EcompactConstructorDeclarationMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcompactConstructorDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcompactConstructorDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EcompactConstructorDeclarationMetaModel.thrownExceptionsPropertyMetaModel = new PropertyMetaModel(___003C_003EcompactConstructorDeclarationMetaModel, "thrownExceptions", ClassLiteral<ReferenceType>.Value, Optional.of(___003C_003EreferenceTypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EcompactConstructorDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcompactConstructorDeclarationMetaModel.thrownExceptionsPropertyMetaModel);
		___003C_003EcompactConstructorDeclarationMetaModel.typeParametersPropertyMetaModel = new PropertyMetaModel(___003C_003EcompactConstructorDeclarationMetaModel, "typeParameters", ClassLiteral<TypeParameter>.Value, Optional.of(___003C_003EtypeParameterMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EcompactConstructorDeclarationMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcompactConstructorDeclarationMetaModel.typeParametersPropertyMetaModel);
		___003C_003EvariableDeclaratorMetaModel.initializerPropertyMetaModel = new PropertyMetaModel(___003C_003EvariableDeclaratorMetaModel, "initializer", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: true, isNonEmpty: true, isNodeList: false, hasWildcard: false);
		___003C_003EvariableDeclaratorMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EvariableDeclaratorMetaModel.initializerPropertyMetaModel);
		___003C_003EvariableDeclaratorMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EvariableDeclaratorMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EvariableDeclaratorMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EvariableDeclaratorMetaModel.namePropertyMetaModel);
		___003C_003EvariableDeclaratorMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EvariableDeclaratorMetaModel, "type", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EvariableDeclaratorMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EvariableDeclaratorMetaModel.typePropertyMetaModel);
		___003C_003EcommentMetaModel.contentPropertyMetaModel = new PropertyMetaModel(___003C_003EcommentMetaModel, "content", ClassLiteral<String>.Value, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcommentMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcommentMetaModel.contentPropertyMetaModel);
		___003C_003EarrayAccessExprMetaModel.indexPropertyMetaModel = new PropertyMetaModel(___003C_003EarrayAccessExprMetaModel, "index", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EarrayAccessExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EarrayAccessExprMetaModel.indexPropertyMetaModel);
		___003C_003EarrayAccessExprMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EarrayAccessExprMetaModel, "name", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EarrayAccessExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EarrayAccessExprMetaModel.namePropertyMetaModel);
		___003C_003EarrayCreationExprMetaModel.elementTypePropertyMetaModel = new PropertyMetaModel(___003C_003EarrayCreationExprMetaModel, "elementType", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EarrayCreationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EarrayCreationExprMetaModel.elementTypePropertyMetaModel);
		___003C_003EarrayCreationExprMetaModel.initializerPropertyMetaModel = new PropertyMetaModel(___003C_003EarrayCreationExprMetaModel, "initializer", ClassLiteral<ArrayInitializerExpr>.Value, Optional.of(___003C_003EarrayInitializerExprMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EarrayCreationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EarrayCreationExprMetaModel.initializerPropertyMetaModel);
		___003C_003EarrayCreationExprMetaModel.levelsPropertyMetaModel = new PropertyMetaModel(___003C_003EarrayCreationExprMetaModel, "levels", ClassLiteral<ArrayCreationLevel>.Value, Optional.of(___003C_003EarrayCreationLevelMetaModel), isOptional: false, isNonEmpty: true, isNodeList: true, hasWildcard: false);
		___003C_003EarrayCreationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EarrayCreationExprMetaModel.levelsPropertyMetaModel);
		___003C_003EarrayInitializerExprMetaModel.valuesPropertyMetaModel = new PropertyMetaModel(___003C_003EarrayInitializerExprMetaModel, "values", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EarrayInitializerExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EarrayInitializerExprMetaModel.valuesPropertyMetaModel);
		___003C_003EassignExprMetaModel.operatorPropertyMetaModel = new PropertyMetaModel(___003C_003EassignExprMetaModel, "operator", ClassLiteral<AssignExpr.Operator>.Value, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EassignExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EassignExprMetaModel.operatorPropertyMetaModel);
		___003C_003EassignExprMetaModel.targetPropertyMetaModel = new PropertyMetaModel(___003C_003EassignExprMetaModel, "target", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EassignExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EassignExprMetaModel.targetPropertyMetaModel);
		___003C_003EassignExprMetaModel.valuePropertyMetaModel = new PropertyMetaModel(___003C_003EassignExprMetaModel, "value", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EassignExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EassignExprMetaModel.valuePropertyMetaModel);
		___003C_003EbinaryExprMetaModel.leftPropertyMetaModel = new PropertyMetaModel(___003C_003EbinaryExprMetaModel, "left", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EbinaryExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EbinaryExprMetaModel.leftPropertyMetaModel);
		___003C_003EbinaryExprMetaModel.operatorPropertyMetaModel = new PropertyMetaModel(___003C_003EbinaryExprMetaModel, "operator", ClassLiteral<BinaryExpr.Operator>.Value, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EbinaryExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EbinaryExprMetaModel.operatorPropertyMetaModel);
		___003C_003EbinaryExprMetaModel.rightPropertyMetaModel = new PropertyMetaModel(___003C_003EbinaryExprMetaModel, "right", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EbinaryExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EbinaryExprMetaModel.rightPropertyMetaModel);
		___003C_003EbooleanLiteralExprMetaModel.valuePropertyMetaModel = new PropertyMetaModel(___003C_003EbooleanLiteralExprMetaModel, "value", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EbooleanLiteralExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EbooleanLiteralExprMetaModel.valuePropertyMetaModel);
		___003C_003EcastExprMetaModel.expressionPropertyMetaModel = new PropertyMetaModel(___003C_003EcastExprMetaModel, "expression", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcastExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcastExprMetaModel.expressionPropertyMetaModel);
		___003C_003EcastExprMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EcastExprMetaModel, "type", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcastExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcastExprMetaModel.typePropertyMetaModel);
		___003C_003EclassExprMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EclassExprMetaModel, "type", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EclassExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EclassExprMetaModel.typePropertyMetaModel);
		___003C_003EconditionalExprMetaModel.conditionPropertyMetaModel = new PropertyMetaModel(___003C_003EconditionalExprMetaModel, "condition", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EconditionalExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EconditionalExprMetaModel.conditionPropertyMetaModel);
		___003C_003EconditionalExprMetaModel.elseExprPropertyMetaModel = new PropertyMetaModel(___003C_003EconditionalExprMetaModel, "elseExpr", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EconditionalExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EconditionalExprMetaModel.elseExprPropertyMetaModel);
		___003C_003EconditionalExprMetaModel.thenExprPropertyMetaModel = new PropertyMetaModel(___003C_003EconditionalExprMetaModel, "thenExpr", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EconditionalExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EconditionalExprMetaModel.thenExprPropertyMetaModel);
		___003C_003EenclosedExprMetaModel.innerPropertyMetaModel = new PropertyMetaModel(___003C_003EenclosedExprMetaModel, "inner", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EenclosedExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EenclosedExprMetaModel.innerPropertyMetaModel);
		___003C_003EfieldAccessExprMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EfieldAccessExprMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EfieldAccessExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EfieldAccessExprMetaModel.namePropertyMetaModel);
		___003C_003EfieldAccessExprMetaModel.scopePropertyMetaModel = new PropertyMetaModel(___003C_003EfieldAccessExprMetaModel, "scope", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EfieldAccessExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EfieldAccessExprMetaModel.scopePropertyMetaModel);
		___003C_003EfieldAccessExprMetaModel.typeArgumentsPropertyMetaModel = new PropertyMetaModel(___003C_003EfieldAccessExprMetaModel, "typeArguments", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: true, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EfieldAccessExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EfieldAccessExprMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EfieldAccessExprMetaModel.usingDiamondOperatorPropertyMetaModel = new PropertyMetaModel(___003C_003EfieldAccessExprMetaModel, "usingDiamondOperator", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EfieldAccessExprMetaModel.getDerivedPropertyMetaModels().add(___003C_003EfieldAccessExprMetaModel.usingDiamondOperatorPropertyMetaModel);
		___003C_003EinstanceOfExprMetaModel.expressionPropertyMetaModel = new PropertyMetaModel(___003C_003EinstanceOfExprMetaModel, "expression", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EinstanceOfExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EinstanceOfExprMetaModel.expressionPropertyMetaModel);
		___003C_003EinstanceOfExprMetaModel.patternPropertyMetaModel = new PropertyMetaModel(___003C_003EinstanceOfExprMetaModel, "pattern", ClassLiteral<PatternExpr>.Value, Optional.of(___003C_003EpatternExprMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EinstanceOfExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EinstanceOfExprMetaModel.patternPropertyMetaModel);
		___003C_003EinstanceOfExprMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EinstanceOfExprMetaModel, "type", ClassLiteral<ReferenceType>.Value, Optional.of(___003C_003EreferenceTypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EinstanceOfExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EinstanceOfExprMetaModel.typePropertyMetaModel);
		___003C_003ElambdaExprMetaModel.bodyPropertyMetaModel = new PropertyMetaModel(___003C_003ElambdaExprMetaModel, "body", ClassLiteral<Statement>.Value, Optional.of(___003C_003EstatementMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003ElambdaExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003ElambdaExprMetaModel.bodyPropertyMetaModel);
		___003C_003ElambdaExprMetaModel.isEnclosingParametersPropertyMetaModel = new PropertyMetaModel(___003C_003ElambdaExprMetaModel, "isEnclosingParameters", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003ElambdaExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003ElambdaExprMetaModel.isEnclosingParametersPropertyMetaModel);
		___003C_003ElambdaExprMetaModel.parametersPropertyMetaModel = new PropertyMetaModel(___003C_003ElambdaExprMetaModel, "parameters", ClassLiteral<Parameter>.Value, Optional.of(___003C_003EparameterMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003ElambdaExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003ElambdaExprMetaModel.parametersPropertyMetaModel);
		___003C_003ElambdaExprMetaModel.expressionBodyPropertyMetaModel = new PropertyMetaModel(___003C_003ElambdaExprMetaModel, "expressionBody", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003ElambdaExprMetaModel.getDerivedPropertyMetaModels().add(___003C_003ElambdaExprMetaModel.expressionBodyPropertyMetaModel);
		___003C_003EmemberValuePairMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EmemberValuePairMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmemberValuePairMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmemberValuePairMetaModel.namePropertyMetaModel);
		___003C_003EmemberValuePairMetaModel.valuePropertyMetaModel = new PropertyMetaModel(___003C_003EmemberValuePairMetaModel, "value", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmemberValuePairMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmemberValuePairMetaModel.valuePropertyMetaModel);
		___003C_003EmethodCallExprMetaModel.argumentsPropertyMetaModel = new PropertyMetaModel(___003C_003EmethodCallExprMetaModel, "arguments", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EmethodCallExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmethodCallExprMetaModel.argumentsPropertyMetaModel);
		___003C_003EmethodCallExprMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EmethodCallExprMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmethodCallExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmethodCallExprMetaModel.namePropertyMetaModel);
		___003C_003EmethodCallExprMetaModel.scopePropertyMetaModel = new PropertyMetaModel(___003C_003EmethodCallExprMetaModel, "scope", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmethodCallExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmethodCallExprMetaModel.scopePropertyMetaModel);
		___003C_003EmethodCallExprMetaModel.typeArgumentsPropertyMetaModel = new PropertyMetaModel(___003C_003EmethodCallExprMetaModel, "typeArguments", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: true, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EmethodCallExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmethodCallExprMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EmethodCallExprMetaModel.usingDiamondOperatorPropertyMetaModel = new PropertyMetaModel(___003C_003EmethodCallExprMetaModel, "usingDiamondOperator", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmethodCallExprMetaModel.getDerivedPropertyMetaModels().add(___003C_003EmethodCallExprMetaModel.usingDiamondOperatorPropertyMetaModel);
		___003C_003EmethodReferenceExprMetaModel.identifierPropertyMetaModel = new PropertyMetaModel(___003C_003EmethodReferenceExprMetaModel, "identifier", ClassLiteral<String>.Value, Optional.empty(), isOptional: false, isNonEmpty: true, isNodeList: false, hasWildcard: false);
		___003C_003EmethodReferenceExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmethodReferenceExprMetaModel.identifierPropertyMetaModel);
		___003C_003EmethodReferenceExprMetaModel.scopePropertyMetaModel = new PropertyMetaModel(___003C_003EmethodReferenceExprMetaModel, "scope", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmethodReferenceExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmethodReferenceExprMetaModel.scopePropertyMetaModel);
		___003C_003EmethodReferenceExprMetaModel.typeArgumentsPropertyMetaModel = new PropertyMetaModel(___003C_003EmethodReferenceExprMetaModel, "typeArguments", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: true, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EmethodReferenceExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmethodReferenceExprMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EmethodReferenceExprMetaModel.usingDiamondOperatorPropertyMetaModel = new PropertyMetaModel(___003C_003EmethodReferenceExprMetaModel, "usingDiamondOperator", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmethodReferenceExprMetaModel.getDerivedPropertyMetaModels().add(___003C_003EmethodReferenceExprMetaModel.usingDiamondOperatorPropertyMetaModel);
		___003C_003EnameExprMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EnameExprMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EnameExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EnameExprMetaModel.namePropertyMetaModel);
		___003C_003EnameMetaModel.identifierPropertyMetaModel = new PropertyMetaModel(___003C_003EnameMetaModel, "identifier", ClassLiteral<String>.Value, Optional.empty(), isOptional: false, isNonEmpty: true, isNodeList: false, hasWildcard: false);
		___003C_003EnameMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EnameMetaModel.identifierPropertyMetaModel);
		___003C_003EnameMetaModel.qualifierPropertyMetaModel = new PropertyMetaModel(___003C_003EnameMetaModel, "qualifier", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EnameMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EnameMetaModel.qualifierPropertyMetaModel);
		___003C_003EnormalAnnotationExprMetaModel.pairsPropertyMetaModel = new PropertyMetaModel(___003C_003EnormalAnnotationExprMetaModel, "pairs", ClassLiteral<MemberValuePair>.Value, Optional.of(___003C_003EmemberValuePairMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EnormalAnnotationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EnormalAnnotationExprMetaModel.pairsPropertyMetaModel);
		___003C_003EobjectCreationExprMetaModel.anonymousClassBodyPropertyMetaModel = new PropertyMetaModel(___003C_003EobjectCreationExprMetaModel, "anonymousClassBody", ClassLiteral<BodyDeclaration>.Value, Optional.of(___003C_003EbodyDeclarationMetaModel), isOptional: true, isNonEmpty: false, isNodeList: true, hasWildcard: true);
		___003C_003EobjectCreationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EobjectCreationExprMetaModel.anonymousClassBodyPropertyMetaModel);
		___003C_003EobjectCreationExprMetaModel.argumentsPropertyMetaModel = new PropertyMetaModel(___003C_003EobjectCreationExprMetaModel, "arguments", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EobjectCreationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EobjectCreationExprMetaModel.argumentsPropertyMetaModel);
		___003C_003EobjectCreationExprMetaModel.scopePropertyMetaModel = new PropertyMetaModel(___003C_003EobjectCreationExprMetaModel, "scope", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EobjectCreationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EobjectCreationExprMetaModel.scopePropertyMetaModel);
		___003C_003EobjectCreationExprMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EobjectCreationExprMetaModel, "type", ClassLiteral<ClassOrInterfaceType>.Value, Optional.of(___003C_003EclassOrInterfaceTypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EobjectCreationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EobjectCreationExprMetaModel.typePropertyMetaModel);
		___003C_003EobjectCreationExprMetaModel.typeArgumentsPropertyMetaModel = new PropertyMetaModel(___003C_003EobjectCreationExprMetaModel, "typeArguments", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: true, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EobjectCreationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EobjectCreationExprMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EobjectCreationExprMetaModel.usingDiamondOperatorPropertyMetaModel = new PropertyMetaModel(___003C_003EobjectCreationExprMetaModel, "usingDiamondOperator", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EobjectCreationExprMetaModel.getDerivedPropertyMetaModels().add(___003C_003EobjectCreationExprMetaModel.usingDiamondOperatorPropertyMetaModel);
		___003C_003EpatternExprMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EpatternExprMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EpatternExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EpatternExprMetaModel.namePropertyMetaModel);
		___003C_003EpatternExprMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EpatternExprMetaModel, "type", ClassLiteral<ReferenceType>.Value, Optional.of(___003C_003EreferenceTypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EpatternExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EpatternExprMetaModel.typePropertyMetaModel);
		___003C_003EsingleMemberAnnotationExprMetaModel.memberValuePropertyMetaModel = new PropertyMetaModel(___003C_003EsingleMemberAnnotationExprMetaModel, "memberValue", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EsingleMemberAnnotationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EsingleMemberAnnotationExprMetaModel.memberValuePropertyMetaModel);
		___003C_003EsimpleNameMetaModel.identifierPropertyMetaModel = new PropertyMetaModel(___003C_003EsimpleNameMetaModel, "identifier", ClassLiteral<String>.Value, Optional.empty(), isOptional: false, isNonEmpty: true, isNodeList: false, hasWildcard: false);
		___003C_003EsimpleNameMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EsimpleNameMetaModel.identifierPropertyMetaModel);
		___003C_003EsuperExprMetaModel.typeNamePropertyMetaModel = new PropertyMetaModel(___003C_003EsuperExprMetaModel, "typeName", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EsuperExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EsuperExprMetaModel.typeNamePropertyMetaModel);
		___003C_003EswitchExprMetaModel.entriesPropertyMetaModel = new PropertyMetaModel(___003C_003EswitchExprMetaModel, "entries", ClassLiteral<SwitchEntry>.Value, Optional.of(___003C_003EswitchEntryMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EswitchExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EswitchExprMetaModel.entriesPropertyMetaModel);
		___003C_003EswitchExprMetaModel.selectorPropertyMetaModel = new PropertyMetaModel(___003C_003EswitchExprMetaModel, "selector", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EswitchExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EswitchExprMetaModel.selectorPropertyMetaModel);
		___003C_003EthisExprMetaModel.typeNamePropertyMetaModel = new PropertyMetaModel(___003C_003EthisExprMetaModel, "typeName", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EthisExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EthisExprMetaModel.typeNamePropertyMetaModel);
		___003C_003EtypeExprMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EtypeExprMetaModel, "type", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EtypeExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EtypeExprMetaModel.typePropertyMetaModel);
		___003C_003EunaryExprMetaModel.expressionPropertyMetaModel = new PropertyMetaModel(___003C_003EunaryExprMetaModel, "expression", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EunaryExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EunaryExprMetaModel.expressionPropertyMetaModel);
		___003C_003EunaryExprMetaModel.operatorPropertyMetaModel = new PropertyMetaModel(___003C_003EunaryExprMetaModel, "operator", ClassLiteral<UnaryExpr.Operator>.Value, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EunaryExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EunaryExprMetaModel.operatorPropertyMetaModel);
		___003C_003EunaryExprMetaModel.postfixPropertyMetaModel = new PropertyMetaModel(___003C_003EunaryExprMetaModel, "postfix", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EunaryExprMetaModel.getDerivedPropertyMetaModels().add(___003C_003EunaryExprMetaModel.postfixPropertyMetaModel);
		___003C_003EunaryExprMetaModel.prefixPropertyMetaModel = new PropertyMetaModel(___003C_003EunaryExprMetaModel, "prefix", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EunaryExprMetaModel.getDerivedPropertyMetaModels().add(___003C_003EunaryExprMetaModel.prefixPropertyMetaModel);
		___003C_003EvariableDeclarationExprMetaModel.annotationsPropertyMetaModel = new PropertyMetaModel(___003C_003EvariableDeclarationExprMetaModel, "annotations", ClassLiteral<AnnotationExpr>.Value, Optional.of(___003C_003EannotationExprMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EvariableDeclarationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EvariableDeclarationExprMetaModel.annotationsPropertyMetaModel);
		___003C_003EvariableDeclarationExprMetaModel.modifiersPropertyMetaModel = new PropertyMetaModel(___003C_003EvariableDeclarationExprMetaModel, "modifiers", ClassLiteral<Modifier>.Value, Optional.of(___003C_003EmodifierMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EvariableDeclarationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EvariableDeclarationExprMetaModel.modifiersPropertyMetaModel);
		___003C_003EvariableDeclarationExprMetaModel.variablesPropertyMetaModel = new PropertyMetaModel(___003C_003EvariableDeclarationExprMetaModel, "variables", ClassLiteral<VariableDeclarator>.Value, Optional.of(___003C_003EvariableDeclaratorMetaModel), isOptional: false, isNonEmpty: true, isNodeList: true, hasWildcard: false);
		___003C_003EvariableDeclarationExprMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EvariableDeclarationExprMetaModel.variablesPropertyMetaModel);
		___003C_003EvariableDeclarationExprMetaModel.maximumCommonTypePropertyMetaModel = new PropertyMetaModel(___003C_003EvariableDeclarationExprMetaModel, "maximumCommonType", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EvariableDeclarationExprMetaModel.getDerivedPropertyMetaModels().add(___003C_003EvariableDeclarationExprMetaModel.maximumCommonTypePropertyMetaModel);
		___003C_003EassertStmtMetaModel.checkPropertyMetaModel = new PropertyMetaModel(___003C_003EassertStmtMetaModel, "check", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EassertStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EassertStmtMetaModel.checkPropertyMetaModel);
		___003C_003EassertStmtMetaModel.messagePropertyMetaModel = new PropertyMetaModel(___003C_003EassertStmtMetaModel, "message", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EassertStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EassertStmtMetaModel.messagePropertyMetaModel);
		___003C_003EblockStmtMetaModel.statementsPropertyMetaModel = new PropertyMetaModel(___003C_003EblockStmtMetaModel, "statements", ClassLiteral<Statement>.Value, Optional.of(___003C_003EstatementMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EblockStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EblockStmtMetaModel.statementsPropertyMetaModel);
		___003C_003EbreakStmtMetaModel.labelPropertyMetaModel = new PropertyMetaModel(___003C_003EbreakStmtMetaModel, "label", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EbreakStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EbreakStmtMetaModel.labelPropertyMetaModel);
		___003C_003EcatchClauseMetaModel.bodyPropertyMetaModel = new PropertyMetaModel(___003C_003EcatchClauseMetaModel, "body", ClassLiteral<BlockStmt>.Value, Optional.of(___003C_003EblockStmtMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcatchClauseMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcatchClauseMetaModel.bodyPropertyMetaModel);
		___003C_003EcatchClauseMetaModel.parameterPropertyMetaModel = new PropertyMetaModel(___003C_003EcatchClauseMetaModel, "parameter", ClassLiteral<Parameter>.Value, Optional.of(___003C_003EparameterMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcatchClauseMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcatchClauseMetaModel.parameterPropertyMetaModel);
		___003C_003EcontinueStmtMetaModel.labelPropertyMetaModel = new PropertyMetaModel(___003C_003EcontinueStmtMetaModel, "label", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EcontinueStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EcontinueStmtMetaModel.labelPropertyMetaModel);
		___003C_003EdoStmtMetaModel.bodyPropertyMetaModel = new PropertyMetaModel(___003C_003EdoStmtMetaModel, "body", ClassLiteral<Statement>.Value, Optional.of(___003C_003EstatementMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EdoStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EdoStmtMetaModel.bodyPropertyMetaModel);
		___003C_003EdoStmtMetaModel.conditionPropertyMetaModel = new PropertyMetaModel(___003C_003EdoStmtMetaModel, "condition", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EdoStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EdoStmtMetaModel.conditionPropertyMetaModel);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.argumentsPropertyMetaModel = new PropertyMetaModel(___003C_003EexplicitConstructorInvocationStmtMetaModel, "arguments", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EexplicitConstructorInvocationStmtMetaModel.argumentsPropertyMetaModel);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.expressionPropertyMetaModel = new PropertyMetaModel(___003C_003EexplicitConstructorInvocationStmtMetaModel, "expression", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EexplicitConstructorInvocationStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.isThisPropertyMetaModel = new PropertyMetaModel(___003C_003EexplicitConstructorInvocationStmtMetaModel, "isThis", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EexplicitConstructorInvocationStmtMetaModel.isThisPropertyMetaModel);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.typeArgumentsPropertyMetaModel = new PropertyMetaModel(___003C_003EexplicitConstructorInvocationStmtMetaModel, "typeArguments", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: true, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EexplicitConstructorInvocationStmtMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.usingDiamondOperatorPropertyMetaModel = new PropertyMetaModel(___003C_003EexplicitConstructorInvocationStmtMetaModel, "usingDiamondOperator", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.getDerivedPropertyMetaModels().add(___003C_003EexplicitConstructorInvocationStmtMetaModel.usingDiamondOperatorPropertyMetaModel);
		___003C_003EexpressionStmtMetaModel.expressionPropertyMetaModel = new PropertyMetaModel(___003C_003EexpressionStmtMetaModel, "expression", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EexpressionStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EexpressionStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EforEachStmtMetaModel.bodyPropertyMetaModel = new PropertyMetaModel(___003C_003EforEachStmtMetaModel, "body", ClassLiteral<Statement>.Value, Optional.of(___003C_003EstatementMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EforEachStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EforEachStmtMetaModel.bodyPropertyMetaModel);
		___003C_003EforEachStmtMetaModel.iterablePropertyMetaModel = new PropertyMetaModel(___003C_003EforEachStmtMetaModel, "iterable", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EforEachStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EforEachStmtMetaModel.iterablePropertyMetaModel);
		___003C_003EforEachStmtMetaModel.variablePropertyMetaModel = new PropertyMetaModel(___003C_003EforEachStmtMetaModel, "variable", ClassLiteral<VariableDeclarationExpr>.Value, Optional.of(___003C_003EvariableDeclarationExprMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EforEachStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EforEachStmtMetaModel.variablePropertyMetaModel);
		___003C_003EforStmtMetaModel.bodyPropertyMetaModel = new PropertyMetaModel(___003C_003EforStmtMetaModel, "body", ClassLiteral<Statement>.Value, Optional.of(___003C_003EstatementMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EforStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EforStmtMetaModel.bodyPropertyMetaModel);
		___003C_003EforStmtMetaModel.comparePropertyMetaModel = new PropertyMetaModel(___003C_003EforStmtMetaModel, "compare", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EforStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EforStmtMetaModel.comparePropertyMetaModel);
		___003C_003EforStmtMetaModel.initializationPropertyMetaModel = new PropertyMetaModel(___003C_003EforStmtMetaModel, "initialization", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EforStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EforStmtMetaModel.initializationPropertyMetaModel);
		___003C_003EforStmtMetaModel.updatePropertyMetaModel = new PropertyMetaModel(___003C_003EforStmtMetaModel, "update", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EforStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EforStmtMetaModel.updatePropertyMetaModel);
		___003C_003EifStmtMetaModel.conditionPropertyMetaModel = new PropertyMetaModel(___003C_003EifStmtMetaModel, "condition", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EifStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EifStmtMetaModel.conditionPropertyMetaModel);
		___003C_003EifStmtMetaModel.elseStmtPropertyMetaModel = new PropertyMetaModel(___003C_003EifStmtMetaModel, "elseStmt", ClassLiteral<Statement>.Value, Optional.of(___003C_003EstatementMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EifStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EifStmtMetaModel.elseStmtPropertyMetaModel);
		___003C_003EifStmtMetaModel.thenStmtPropertyMetaModel = new PropertyMetaModel(___003C_003EifStmtMetaModel, "thenStmt", ClassLiteral<Statement>.Value, Optional.of(___003C_003EstatementMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EifStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EifStmtMetaModel.thenStmtPropertyMetaModel);
		___003C_003EifStmtMetaModel.cascadingIfStmtPropertyMetaModel = new PropertyMetaModel(___003C_003EifStmtMetaModel, "cascadingIfStmt", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EifStmtMetaModel.getDerivedPropertyMetaModels().add(___003C_003EifStmtMetaModel.cascadingIfStmtPropertyMetaModel);
		___003C_003EifStmtMetaModel.elseBlockPropertyMetaModel = new PropertyMetaModel(___003C_003EifStmtMetaModel, "elseBlock", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EifStmtMetaModel.getDerivedPropertyMetaModels().add(___003C_003EifStmtMetaModel.elseBlockPropertyMetaModel);
		___003C_003EifStmtMetaModel.elseBranchPropertyMetaModel = new PropertyMetaModel(___003C_003EifStmtMetaModel, "elseBranch", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EifStmtMetaModel.getDerivedPropertyMetaModels().add(___003C_003EifStmtMetaModel.elseBranchPropertyMetaModel);
		___003C_003EifStmtMetaModel.thenBlockPropertyMetaModel = new PropertyMetaModel(___003C_003EifStmtMetaModel, "thenBlock", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EifStmtMetaModel.getDerivedPropertyMetaModels().add(___003C_003EifStmtMetaModel.thenBlockPropertyMetaModel);
		___003C_003ElabeledStmtMetaModel.labelPropertyMetaModel = new PropertyMetaModel(___003C_003ElabeledStmtMetaModel, "label", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003ElabeledStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003ElabeledStmtMetaModel.labelPropertyMetaModel);
		___003C_003ElabeledStmtMetaModel.statementPropertyMetaModel = new PropertyMetaModel(___003C_003ElabeledStmtMetaModel, "statement", ClassLiteral<Statement>.Value, Optional.of(___003C_003EstatementMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003ElabeledStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003ElabeledStmtMetaModel.statementPropertyMetaModel);
		___003C_003ElocalClassDeclarationStmtMetaModel.classDeclarationPropertyMetaModel = new PropertyMetaModel(___003C_003ElocalClassDeclarationStmtMetaModel, "classDeclaration", ClassLiteral<ClassOrInterfaceDeclaration>.Value, Optional.of(___003C_003EclassOrInterfaceDeclarationMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003ElocalClassDeclarationStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003ElocalClassDeclarationStmtMetaModel.classDeclarationPropertyMetaModel);
		___003C_003ElocalRecordDeclarationStmtMetaModel.recordDeclarationPropertyMetaModel = new PropertyMetaModel(___003C_003ElocalRecordDeclarationStmtMetaModel, "recordDeclaration", ClassLiteral<RecordDeclaration>.Value, Optional.of(___003C_003ErecordDeclarationMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003ElocalRecordDeclarationStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003ElocalRecordDeclarationStmtMetaModel.recordDeclarationPropertyMetaModel);
		___003C_003EreturnStmtMetaModel.expressionPropertyMetaModel = new PropertyMetaModel(___003C_003EreturnStmtMetaModel, "expression", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EreturnStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EreturnStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EswitchEntryMetaModel.labelsPropertyMetaModel = new PropertyMetaModel(___003C_003EswitchEntryMetaModel, "labels", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EswitchEntryMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EswitchEntryMetaModel.labelsPropertyMetaModel);
		___003C_003EswitchEntryMetaModel.statementsPropertyMetaModel = new PropertyMetaModel(___003C_003EswitchEntryMetaModel, "statements", ClassLiteral<Statement>.Value, Optional.of(___003C_003EstatementMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EswitchEntryMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EswitchEntryMetaModel.statementsPropertyMetaModel);
		___003C_003EswitchEntryMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EswitchEntryMetaModel, "type", ClassLiteral<SwitchEntry.Type>.Value, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EswitchEntryMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EswitchEntryMetaModel.typePropertyMetaModel);
		___003C_003EswitchStmtMetaModel.entriesPropertyMetaModel = new PropertyMetaModel(___003C_003EswitchStmtMetaModel, "entries", ClassLiteral<SwitchEntry>.Value, Optional.of(___003C_003EswitchEntryMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EswitchStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EswitchStmtMetaModel.entriesPropertyMetaModel);
		___003C_003EswitchStmtMetaModel.selectorPropertyMetaModel = new PropertyMetaModel(___003C_003EswitchStmtMetaModel, "selector", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EswitchStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EswitchStmtMetaModel.selectorPropertyMetaModel);
		___003C_003EsynchronizedStmtMetaModel.bodyPropertyMetaModel = new PropertyMetaModel(___003C_003EsynchronizedStmtMetaModel, "body", ClassLiteral<BlockStmt>.Value, Optional.of(___003C_003EblockStmtMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EsynchronizedStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EsynchronizedStmtMetaModel.bodyPropertyMetaModel);
		___003C_003EsynchronizedStmtMetaModel.expressionPropertyMetaModel = new PropertyMetaModel(___003C_003EsynchronizedStmtMetaModel, "expression", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EsynchronizedStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EsynchronizedStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EthrowStmtMetaModel.expressionPropertyMetaModel = new PropertyMetaModel(___003C_003EthrowStmtMetaModel, "expression", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EthrowStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EthrowStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EtryStmtMetaModel.catchClausesPropertyMetaModel = new PropertyMetaModel(___003C_003EtryStmtMetaModel, "catchClauses", ClassLiteral<CatchClause>.Value, Optional.of(___003C_003EcatchClauseMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EtryStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EtryStmtMetaModel.catchClausesPropertyMetaModel);
		___003C_003EtryStmtMetaModel.finallyBlockPropertyMetaModel = new PropertyMetaModel(___003C_003EtryStmtMetaModel, "finallyBlock", ClassLiteral<BlockStmt>.Value, Optional.of(___003C_003EblockStmtMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EtryStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EtryStmtMetaModel.finallyBlockPropertyMetaModel);
		___003C_003EtryStmtMetaModel.resourcesPropertyMetaModel = new PropertyMetaModel(___003C_003EtryStmtMetaModel, "resources", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EtryStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EtryStmtMetaModel.resourcesPropertyMetaModel);
		___003C_003EtryStmtMetaModel.tryBlockPropertyMetaModel = new PropertyMetaModel(___003C_003EtryStmtMetaModel, "tryBlock", ClassLiteral<BlockStmt>.Value, Optional.of(___003C_003EblockStmtMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EtryStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EtryStmtMetaModel.tryBlockPropertyMetaModel);
		___003C_003EwhileStmtMetaModel.bodyPropertyMetaModel = new PropertyMetaModel(___003C_003EwhileStmtMetaModel, "body", ClassLiteral<Statement>.Value, Optional.of(___003C_003EstatementMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EwhileStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EwhileStmtMetaModel.bodyPropertyMetaModel);
		___003C_003EwhileStmtMetaModel.conditionPropertyMetaModel = new PropertyMetaModel(___003C_003EwhileStmtMetaModel, "condition", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EwhileStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EwhileStmtMetaModel.conditionPropertyMetaModel);
		___003C_003EyieldStmtMetaModel.expressionPropertyMetaModel = new PropertyMetaModel(___003C_003EyieldStmtMetaModel, "expression", ClassLiteral<Expression>.Value, Optional.of(___003C_003EexpressionMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EyieldStmtMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EyieldStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EarrayTypeMetaModel.componentTypePropertyMetaModel = new PropertyMetaModel(___003C_003EarrayTypeMetaModel, "componentType", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EarrayTypeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EarrayTypeMetaModel.componentTypePropertyMetaModel);
		___003C_003EarrayTypeMetaModel.originPropertyMetaModel = new PropertyMetaModel(___003C_003EarrayTypeMetaModel, "origin", ClassLiteral<ArrayType.Origin>.Value, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EarrayTypeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EarrayTypeMetaModel.originPropertyMetaModel);
		___003C_003EclassOrInterfaceTypeMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EclassOrInterfaceTypeMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EclassOrInterfaceTypeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EclassOrInterfaceTypeMetaModel.namePropertyMetaModel);
		___003C_003EclassOrInterfaceTypeMetaModel.scopePropertyMetaModel = new PropertyMetaModel(___003C_003EclassOrInterfaceTypeMetaModel, "scope", ClassLiteral<ClassOrInterfaceType>.Value, Optional.of(___003C_003EclassOrInterfaceTypeMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EclassOrInterfaceTypeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EclassOrInterfaceTypeMetaModel.scopePropertyMetaModel);
		___003C_003EclassOrInterfaceTypeMetaModel.typeArgumentsPropertyMetaModel = new PropertyMetaModel(___003C_003EclassOrInterfaceTypeMetaModel, "typeArguments", ClassLiteral<Type>.Value, Optional.of(___003C_003EtypeMetaModel), isOptional: true, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EclassOrInterfaceTypeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EclassOrInterfaceTypeMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EclassOrInterfaceTypeMetaModel.usingDiamondOperatorPropertyMetaModel = new PropertyMetaModel(___003C_003EclassOrInterfaceTypeMetaModel, "usingDiamondOperator", Boolean.TYPE, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EclassOrInterfaceTypeMetaModel.getDerivedPropertyMetaModels().add(___003C_003EclassOrInterfaceTypeMetaModel.usingDiamondOperatorPropertyMetaModel);
		___003C_003EintersectionTypeMetaModel.elementsPropertyMetaModel = new PropertyMetaModel(___003C_003EintersectionTypeMetaModel, "elements", ClassLiteral<ReferenceType>.Value, Optional.of(___003C_003EreferenceTypeMetaModel), isOptional: false, isNonEmpty: true, isNodeList: true, hasWildcard: false);
		___003C_003EintersectionTypeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EintersectionTypeMetaModel.elementsPropertyMetaModel);
		___003C_003EprimitiveTypeMetaModel.typePropertyMetaModel = new PropertyMetaModel(___003C_003EprimitiveTypeMetaModel, "type", ClassLiteral<PrimitiveType.Primitive>.Value, Optional.empty(), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EprimitiveTypeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EprimitiveTypeMetaModel.typePropertyMetaModel);
		___003C_003EtypeParameterMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EtypeParameterMetaModel, "name", ClassLiteral<SimpleName>.Value, Optional.of(___003C_003EsimpleNameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EtypeParameterMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EtypeParameterMetaModel.namePropertyMetaModel);
		___003C_003EtypeParameterMetaModel.typeBoundPropertyMetaModel = new PropertyMetaModel(___003C_003EtypeParameterMetaModel, "typeBound", ClassLiteral<ClassOrInterfaceType>.Value, Optional.of(___003C_003EclassOrInterfaceTypeMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EtypeParameterMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EtypeParameterMetaModel.typeBoundPropertyMetaModel);
		___003C_003EunionTypeMetaModel.elementsPropertyMetaModel = new PropertyMetaModel(___003C_003EunionTypeMetaModel, "elements", ClassLiteral<ReferenceType>.Value, Optional.of(___003C_003EreferenceTypeMetaModel), isOptional: false, isNonEmpty: true, isNodeList: true, hasWildcard: false);
		___003C_003EunionTypeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EunionTypeMetaModel.elementsPropertyMetaModel);
		___003C_003EwildcardTypeMetaModel.extendedTypePropertyMetaModel = new PropertyMetaModel(___003C_003EwildcardTypeMetaModel, "extendedType", ClassLiteral<ReferenceType>.Value, Optional.of(___003C_003EreferenceTypeMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EwildcardTypeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EwildcardTypeMetaModel.extendedTypePropertyMetaModel);
		___003C_003EwildcardTypeMetaModel.superTypePropertyMetaModel = new PropertyMetaModel(___003C_003EwildcardTypeMetaModel, "superType", ClassLiteral<ReferenceType>.Value, Optional.of(___003C_003EreferenceTypeMetaModel), isOptional: true, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EwildcardTypeMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EwildcardTypeMetaModel.superTypePropertyMetaModel);
		___003C_003EmoduleExportsDirectiveMetaModel.moduleNamesPropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleExportsDirectiveMetaModel, "moduleNames", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EmoduleExportsDirectiveMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleExportsDirectiveMetaModel.moduleNamesPropertyMetaModel);
		___003C_003EmoduleExportsDirectiveMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleExportsDirectiveMetaModel, "name", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmoduleExportsDirectiveMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleExportsDirectiveMetaModel.namePropertyMetaModel);
		___003C_003EmoduleOpensDirectiveMetaModel.moduleNamesPropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleOpensDirectiveMetaModel, "moduleNames", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EmoduleOpensDirectiveMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleOpensDirectiveMetaModel.moduleNamesPropertyMetaModel);
		___003C_003EmoduleOpensDirectiveMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleOpensDirectiveMetaModel, "name", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmoduleOpensDirectiveMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleOpensDirectiveMetaModel.namePropertyMetaModel);
		___003C_003EmoduleProvidesDirectiveMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleProvidesDirectiveMetaModel, "name", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmoduleProvidesDirectiveMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleProvidesDirectiveMetaModel.namePropertyMetaModel);
		___003C_003EmoduleProvidesDirectiveMetaModel.withPropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleProvidesDirectiveMetaModel, "with", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EmoduleProvidesDirectiveMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleProvidesDirectiveMetaModel.withPropertyMetaModel);
		___003C_003EmoduleRequiresDirectiveMetaModel.modifiersPropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleRequiresDirectiveMetaModel, "modifiers", ClassLiteral<Modifier>.Value, Optional.of(___003C_003EmodifierMetaModel), isOptional: false, isNonEmpty: false, isNodeList: true, hasWildcard: false);
		___003C_003EmoduleRequiresDirectiveMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleRequiresDirectiveMetaModel.modifiersPropertyMetaModel);
		___003C_003EmoduleRequiresDirectiveMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleRequiresDirectiveMetaModel, "name", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmoduleRequiresDirectiveMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleRequiresDirectiveMetaModel.namePropertyMetaModel);
		___003C_003EmoduleUsesDirectiveMetaModel.namePropertyMetaModel = new PropertyMetaModel(___003C_003EmoduleUsesDirectiveMetaModel, "name", ClassLiteral<Name>.Value, Optional.of(___003C_003EnameMetaModel), isOptional: false, isNonEmpty: false, isNodeList: false, hasWildcard: false);
		___003C_003EmoduleUsesDirectiveMetaModel.getDeclaredPropertyMetaModels().add(___003C_003EmoduleUsesDirectiveMetaModel.namePropertyMetaModel);
	}

	
	[LineNumberTable(new byte[]
	{
		159, 182, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122, 122, 122, 122, 122, 122, 122, 122,
		122, 122, 122
	})]
	private static void initializeConstructorParameters()
	{
		___003C_003EbodyDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.typeParametersPropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.parametersPropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.thrownExceptionsPropertyMetaModel);
		___003C_003EcallableDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.receiverParameterPropertyMetaModel);
		___003C_003EtypeMetaModel.getConstructorParameters().add(___003C_003EtypeMetaModel.annotationsPropertyMetaModel);
		___003C_003EannotationExprMetaModel.getConstructorParameters().add(___003C_003EannotationExprMetaModel.namePropertyMetaModel);
		___003C_003EreferenceTypeMetaModel.getConstructorParameters().add(___003C_003EtypeMetaModel.annotationsPropertyMetaModel);
		___003C_003EtypeDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EtypeDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EtypeDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EtypeDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.membersPropertyMetaModel);
		___003C_003EliteralStringValueExprMetaModel.getConstructorParameters().add(___003C_003EliteralStringValueExprMetaModel.valuePropertyMetaModel);
		___003C_003EstringLiteralExprMetaModel.getConstructorParameters().add(___003C_003EliteralStringValueExprMetaModel.valuePropertyMetaModel);
		___003C_003EmoduleDeclarationMetaModel.getConstructorParameters().add(___003C_003EmoduleDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EmoduleDeclarationMetaModel.getConstructorParameters().add(___003C_003EmoduleDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EmoduleDeclarationMetaModel.getConstructorParameters().add(___003C_003EmoduleDeclarationMetaModel.isOpenPropertyMetaModel);
		___003C_003EmoduleDeclarationMetaModel.getConstructorParameters().add(___003C_003EmoduleDeclarationMetaModel.directivesPropertyMetaModel);
		___003C_003EarrayCreationLevelMetaModel.getConstructorParameters().add(___003C_003EarrayCreationLevelMetaModel.dimensionPropertyMetaModel);
		___003C_003EarrayCreationLevelMetaModel.getConstructorParameters().add(___003C_003EarrayCreationLevelMetaModel.annotationsPropertyMetaModel);
		___003C_003EcompilationUnitMetaModel.getConstructorParameters().add(___003C_003EcompilationUnitMetaModel.packageDeclarationPropertyMetaModel);
		___003C_003EcompilationUnitMetaModel.getConstructorParameters().add(___003C_003EcompilationUnitMetaModel.importsPropertyMetaModel);
		___003C_003EcompilationUnitMetaModel.getConstructorParameters().add(___003C_003EcompilationUnitMetaModel.typesPropertyMetaModel);
		___003C_003EcompilationUnitMetaModel.getConstructorParameters().add(___003C_003EcompilationUnitMetaModel.modulePropertyMetaModel);
		___003C_003EimportDeclarationMetaModel.getConstructorParameters().add(___003C_003EimportDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EimportDeclarationMetaModel.getConstructorParameters().add(___003C_003EimportDeclarationMetaModel.isStaticPropertyMetaModel);
		___003C_003EimportDeclarationMetaModel.getConstructorParameters().add(___003C_003EimportDeclarationMetaModel.isAsteriskPropertyMetaModel);
		___003C_003EmodifierMetaModel.getConstructorParameters().add(___003C_003EmodifierMetaModel.keywordPropertyMetaModel);
		___003C_003EpackageDeclarationMetaModel.getConstructorParameters().add(___003C_003EpackageDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EpackageDeclarationMetaModel.getConstructorParameters().add(___003C_003EpackageDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EannotationDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EannotationDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EannotationDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EannotationDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.membersPropertyMetaModel);
		___003C_003EannotationMemberDeclarationMetaModel.getConstructorParameters().add(___003C_003EannotationMemberDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EannotationMemberDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EannotationMemberDeclarationMetaModel.getConstructorParameters().add(___003C_003EannotationMemberDeclarationMetaModel.typePropertyMetaModel);
		___003C_003EannotationMemberDeclarationMetaModel.getConstructorParameters().add(___003C_003EannotationMemberDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EannotationMemberDeclarationMetaModel.getConstructorParameters().add(___003C_003EannotationMemberDeclarationMetaModel.defaultValuePropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getConstructorParameters().add(___003C_003EclassOrInterfaceDeclarationMetaModel.isInterfacePropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getConstructorParameters().add(___003C_003EclassOrInterfaceDeclarationMetaModel.typeParametersPropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getConstructorParameters().add(___003C_003EclassOrInterfaceDeclarationMetaModel.extendedTypesPropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getConstructorParameters().add(___003C_003EclassOrInterfaceDeclarationMetaModel.implementedTypesPropertyMetaModel);
		___003C_003EclassOrInterfaceDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.membersPropertyMetaModel);
		___003C_003EconstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EconstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EconstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.typeParametersPropertyMetaModel);
		___003C_003EconstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EconstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.parametersPropertyMetaModel);
		___003C_003EconstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.thrownExceptionsPropertyMetaModel);
		___003C_003EconstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EconstructorDeclarationMetaModel.bodyPropertyMetaModel);
		___003C_003EconstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.receiverParameterPropertyMetaModel);
		___003C_003EenumConstantDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EenumConstantDeclarationMetaModel.getConstructorParameters().add(___003C_003EenumConstantDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EenumConstantDeclarationMetaModel.getConstructorParameters().add(___003C_003EenumConstantDeclarationMetaModel.argumentsPropertyMetaModel);
		___003C_003EenumConstantDeclarationMetaModel.getConstructorParameters().add(___003C_003EenumConstantDeclarationMetaModel.classBodyPropertyMetaModel);
		___003C_003EenumDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EenumDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EenumDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EenumDeclarationMetaModel.getConstructorParameters().add(___003C_003EenumDeclarationMetaModel.implementedTypesPropertyMetaModel);
		___003C_003EenumDeclarationMetaModel.getConstructorParameters().add(___003C_003EenumDeclarationMetaModel.entriesPropertyMetaModel);
		___003C_003EenumDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.membersPropertyMetaModel);
		___003C_003EfieldDeclarationMetaModel.getConstructorParameters().add(___003C_003EfieldDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EfieldDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EfieldDeclarationMetaModel.getConstructorParameters().add(___003C_003EfieldDeclarationMetaModel.variablesPropertyMetaModel);
		___003C_003EinitializerDeclarationMetaModel.getConstructorParameters().add(___003C_003EinitializerDeclarationMetaModel.isStaticPropertyMetaModel);
		___003C_003EinitializerDeclarationMetaModel.getConstructorParameters().add(___003C_003EinitializerDeclarationMetaModel.bodyPropertyMetaModel);
		___003C_003EmethodDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EmethodDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EmethodDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.typeParametersPropertyMetaModel);
		___003C_003EmethodDeclarationMetaModel.getConstructorParameters().add(___003C_003EmethodDeclarationMetaModel.typePropertyMetaModel);
		___003C_003EmethodDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EmethodDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.parametersPropertyMetaModel);
		___003C_003EmethodDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.thrownExceptionsPropertyMetaModel);
		___003C_003EmethodDeclarationMetaModel.getConstructorParameters().add(___003C_003EmethodDeclarationMetaModel.bodyPropertyMetaModel);
		___003C_003EmethodDeclarationMetaModel.getConstructorParameters().add(___003C_003EcallableDeclarationMetaModel.receiverParameterPropertyMetaModel);
		___003C_003EparameterMetaModel.getConstructorParameters().add(___003C_003EparameterMetaModel.modifiersPropertyMetaModel);
		___003C_003EparameterMetaModel.getConstructorParameters().add(___003C_003EparameterMetaModel.annotationsPropertyMetaModel);
		___003C_003EparameterMetaModel.getConstructorParameters().add(___003C_003EparameterMetaModel.typePropertyMetaModel);
		___003C_003EparameterMetaModel.getConstructorParameters().add(___003C_003EparameterMetaModel.isVarArgsPropertyMetaModel);
		___003C_003EparameterMetaModel.getConstructorParameters().add(___003C_003EparameterMetaModel.varArgsAnnotationsPropertyMetaModel);
		___003C_003EparameterMetaModel.getConstructorParameters().add(___003C_003EparameterMetaModel.namePropertyMetaModel);
		___003C_003EreceiverParameterMetaModel.getConstructorParameters().add(___003C_003EreceiverParameterMetaModel.annotationsPropertyMetaModel);
		___003C_003EreceiverParameterMetaModel.getConstructorParameters().add(___003C_003EreceiverParameterMetaModel.typePropertyMetaModel);
		___003C_003EreceiverParameterMetaModel.getConstructorParameters().add(___003C_003EreceiverParameterMetaModel.namePropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.namePropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.getConstructorParameters().add(___003C_003ErecordDeclarationMetaModel.parametersPropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.getConstructorParameters().add(___003C_003ErecordDeclarationMetaModel.typeParametersPropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.getConstructorParameters().add(___003C_003ErecordDeclarationMetaModel.implementedTypesPropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.getConstructorParameters().add(___003C_003EtypeDeclarationMetaModel.membersPropertyMetaModel);
		___003C_003ErecordDeclarationMetaModel.getConstructorParameters().add(___003C_003ErecordDeclarationMetaModel.receiverParameterPropertyMetaModel);
		___003C_003EcompactConstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EcompactConstructorDeclarationMetaModel.modifiersPropertyMetaModel);
		___003C_003EcompactConstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EbodyDeclarationMetaModel.annotationsPropertyMetaModel);
		___003C_003EcompactConstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EcompactConstructorDeclarationMetaModel.typeParametersPropertyMetaModel);
		___003C_003EcompactConstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EcompactConstructorDeclarationMetaModel.namePropertyMetaModel);
		___003C_003EcompactConstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EcompactConstructorDeclarationMetaModel.thrownExceptionsPropertyMetaModel);
		___003C_003EcompactConstructorDeclarationMetaModel.getConstructorParameters().add(___003C_003EcompactConstructorDeclarationMetaModel.bodyPropertyMetaModel);
		___003C_003EvariableDeclaratorMetaModel.getConstructorParameters().add(___003C_003EvariableDeclaratorMetaModel.typePropertyMetaModel);
		___003C_003EvariableDeclaratorMetaModel.getConstructorParameters().add(___003C_003EvariableDeclaratorMetaModel.namePropertyMetaModel);
		___003C_003EvariableDeclaratorMetaModel.getConstructorParameters().add(___003C_003EvariableDeclaratorMetaModel.initializerPropertyMetaModel);
		___003C_003EcommentMetaModel.getConstructorParameters().add(___003C_003EcommentMetaModel.contentPropertyMetaModel);
		___003C_003EblockCommentMetaModel.getConstructorParameters().add(___003C_003EcommentMetaModel.contentPropertyMetaModel);
		___003C_003EjavadocCommentMetaModel.getConstructorParameters().add(___003C_003EcommentMetaModel.contentPropertyMetaModel);
		___003C_003ElineCommentMetaModel.getConstructorParameters().add(___003C_003EcommentMetaModel.contentPropertyMetaModel);
		___003C_003EarrayAccessExprMetaModel.getConstructorParameters().add(___003C_003EarrayAccessExprMetaModel.namePropertyMetaModel);
		___003C_003EarrayAccessExprMetaModel.getConstructorParameters().add(___003C_003EarrayAccessExprMetaModel.indexPropertyMetaModel);
		___003C_003EarrayCreationExprMetaModel.getConstructorParameters().add(___003C_003EarrayCreationExprMetaModel.elementTypePropertyMetaModel);
		___003C_003EarrayCreationExprMetaModel.getConstructorParameters().add(___003C_003EarrayCreationExprMetaModel.levelsPropertyMetaModel);
		___003C_003EarrayCreationExprMetaModel.getConstructorParameters().add(___003C_003EarrayCreationExprMetaModel.initializerPropertyMetaModel);
		___003C_003EarrayInitializerExprMetaModel.getConstructorParameters().add(___003C_003EarrayInitializerExprMetaModel.valuesPropertyMetaModel);
		___003C_003EassignExprMetaModel.getConstructorParameters().add(___003C_003EassignExprMetaModel.targetPropertyMetaModel);
		___003C_003EassignExprMetaModel.getConstructorParameters().add(___003C_003EassignExprMetaModel.valuePropertyMetaModel);
		___003C_003EassignExprMetaModel.getConstructorParameters().add(___003C_003EassignExprMetaModel.operatorPropertyMetaModel);
		___003C_003EbinaryExprMetaModel.getConstructorParameters().add(___003C_003EbinaryExprMetaModel.leftPropertyMetaModel);
		___003C_003EbinaryExprMetaModel.getConstructorParameters().add(___003C_003EbinaryExprMetaModel.rightPropertyMetaModel);
		___003C_003EbinaryExprMetaModel.getConstructorParameters().add(___003C_003EbinaryExprMetaModel.operatorPropertyMetaModel);
		___003C_003EbooleanLiteralExprMetaModel.getConstructorParameters().add(___003C_003EbooleanLiteralExprMetaModel.valuePropertyMetaModel);
		___003C_003EcastExprMetaModel.getConstructorParameters().add(___003C_003EcastExprMetaModel.typePropertyMetaModel);
		___003C_003EcastExprMetaModel.getConstructorParameters().add(___003C_003EcastExprMetaModel.expressionPropertyMetaModel);
		___003C_003EcharLiteralExprMetaModel.getConstructorParameters().add(___003C_003EliteralStringValueExprMetaModel.valuePropertyMetaModel);
		___003C_003EclassExprMetaModel.getConstructorParameters().add(___003C_003EclassExprMetaModel.typePropertyMetaModel);
		___003C_003EconditionalExprMetaModel.getConstructorParameters().add(___003C_003EconditionalExprMetaModel.conditionPropertyMetaModel);
		___003C_003EconditionalExprMetaModel.getConstructorParameters().add(___003C_003EconditionalExprMetaModel.thenExprPropertyMetaModel);
		___003C_003EconditionalExprMetaModel.getConstructorParameters().add(___003C_003EconditionalExprMetaModel.elseExprPropertyMetaModel);
		___003C_003EdoubleLiteralExprMetaModel.getConstructorParameters().add(___003C_003EliteralStringValueExprMetaModel.valuePropertyMetaModel);
		___003C_003EenclosedExprMetaModel.getConstructorParameters().add(___003C_003EenclosedExprMetaModel.innerPropertyMetaModel);
		___003C_003EfieldAccessExprMetaModel.getConstructorParameters().add(___003C_003EfieldAccessExprMetaModel.scopePropertyMetaModel);
		___003C_003EfieldAccessExprMetaModel.getConstructorParameters().add(___003C_003EfieldAccessExprMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EfieldAccessExprMetaModel.getConstructorParameters().add(___003C_003EfieldAccessExprMetaModel.namePropertyMetaModel);
		___003C_003EinstanceOfExprMetaModel.getConstructorParameters().add(___003C_003EinstanceOfExprMetaModel.expressionPropertyMetaModel);
		___003C_003EinstanceOfExprMetaModel.getConstructorParameters().add(___003C_003EinstanceOfExprMetaModel.typePropertyMetaModel);
		___003C_003EinstanceOfExprMetaModel.getConstructorParameters().add(___003C_003EinstanceOfExprMetaModel.patternPropertyMetaModel);
		___003C_003EintegerLiteralExprMetaModel.getConstructorParameters().add(___003C_003EliteralStringValueExprMetaModel.valuePropertyMetaModel);
		___003C_003ElambdaExprMetaModel.getConstructorParameters().add(___003C_003ElambdaExprMetaModel.parametersPropertyMetaModel);
		___003C_003ElambdaExprMetaModel.getConstructorParameters().add(___003C_003ElambdaExprMetaModel.bodyPropertyMetaModel);
		___003C_003ElambdaExprMetaModel.getConstructorParameters().add(___003C_003ElambdaExprMetaModel.isEnclosingParametersPropertyMetaModel);
		___003C_003ElongLiteralExprMetaModel.getConstructorParameters().add(___003C_003EliteralStringValueExprMetaModel.valuePropertyMetaModel);
		___003C_003EmarkerAnnotationExprMetaModel.getConstructorParameters().add(___003C_003EannotationExprMetaModel.namePropertyMetaModel);
		___003C_003EmemberValuePairMetaModel.getConstructorParameters().add(___003C_003EmemberValuePairMetaModel.namePropertyMetaModel);
		___003C_003EmemberValuePairMetaModel.getConstructorParameters().add(___003C_003EmemberValuePairMetaModel.valuePropertyMetaModel);
		___003C_003EmethodCallExprMetaModel.getConstructorParameters().add(___003C_003EmethodCallExprMetaModel.scopePropertyMetaModel);
		___003C_003EmethodCallExprMetaModel.getConstructorParameters().add(___003C_003EmethodCallExprMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EmethodCallExprMetaModel.getConstructorParameters().add(___003C_003EmethodCallExprMetaModel.namePropertyMetaModel);
		___003C_003EmethodCallExprMetaModel.getConstructorParameters().add(___003C_003EmethodCallExprMetaModel.argumentsPropertyMetaModel);
		___003C_003EmethodReferenceExprMetaModel.getConstructorParameters().add(___003C_003EmethodReferenceExprMetaModel.scopePropertyMetaModel);
		___003C_003EmethodReferenceExprMetaModel.getConstructorParameters().add(___003C_003EmethodReferenceExprMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EmethodReferenceExprMetaModel.getConstructorParameters().add(___003C_003EmethodReferenceExprMetaModel.identifierPropertyMetaModel);
		___003C_003EnameExprMetaModel.getConstructorParameters().add(___003C_003EnameExprMetaModel.namePropertyMetaModel);
		___003C_003EnameMetaModel.getConstructorParameters().add(___003C_003EnameMetaModel.qualifierPropertyMetaModel);
		___003C_003EnameMetaModel.getConstructorParameters().add(___003C_003EnameMetaModel.identifierPropertyMetaModel);
		___003C_003EnormalAnnotationExprMetaModel.getConstructorParameters().add(___003C_003EannotationExprMetaModel.namePropertyMetaModel);
		___003C_003EnormalAnnotationExprMetaModel.getConstructorParameters().add(___003C_003EnormalAnnotationExprMetaModel.pairsPropertyMetaModel);
		___003C_003EobjectCreationExprMetaModel.getConstructorParameters().add(___003C_003EobjectCreationExprMetaModel.scopePropertyMetaModel);
		___003C_003EobjectCreationExprMetaModel.getConstructorParameters().add(___003C_003EobjectCreationExprMetaModel.typePropertyMetaModel);
		___003C_003EobjectCreationExprMetaModel.getConstructorParameters().add(___003C_003EobjectCreationExprMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EobjectCreationExprMetaModel.getConstructorParameters().add(___003C_003EobjectCreationExprMetaModel.argumentsPropertyMetaModel);
		___003C_003EobjectCreationExprMetaModel.getConstructorParameters().add(___003C_003EobjectCreationExprMetaModel.anonymousClassBodyPropertyMetaModel);
		___003C_003EpatternExprMetaModel.getConstructorParameters().add(___003C_003EpatternExprMetaModel.typePropertyMetaModel);
		___003C_003EpatternExprMetaModel.getConstructorParameters().add(___003C_003EpatternExprMetaModel.namePropertyMetaModel);
		___003C_003EsingleMemberAnnotationExprMetaModel.getConstructorParameters().add(___003C_003EannotationExprMetaModel.namePropertyMetaModel);
		___003C_003EsingleMemberAnnotationExprMetaModel.getConstructorParameters().add(___003C_003EsingleMemberAnnotationExprMetaModel.memberValuePropertyMetaModel);
		___003C_003EsimpleNameMetaModel.getConstructorParameters().add(___003C_003EsimpleNameMetaModel.identifierPropertyMetaModel);
		___003C_003EsuperExprMetaModel.getConstructorParameters().add(___003C_003EsuperExprMetaModel.typeNamePropertyMetaModel);
		___003C_003EswitchExprMetaModel.getConstructorParameters().add(___003C_003EswitchExprMetaModel.selectorPropertyMetaModel);
		___003C_003EswitchExprMetaModel.getConstructorParameters().add(___003C_003EswitchExprMetaModel.entriesPropertyMetaModel);
		___003C_003EtextBlockLiteralExprMetaModel.getConstructorParameters().add(___003C_003EliteralStringValueExprMetaModel.valuePropertyMetaModel);
		___003C_003EthisExprMetaModel.getConstructorParameters().add(___003C_003EthisExprMetaModel.typeNamePropertyMetaModel);
		___003C_003EtypeExprMetaModel.getConstructorParameters().add(___003C_003EtypeExprMetaModel.typePropertyMetaModel);
		___003C_003EunaryExprMetaModel.getConstructorParameters().add(___003C_003EunaryExprMetaModel.expressionPropertyMetaModel);
		___003C_003EunaryExprMetaModel.getConstructorParameters().add(___003C_003EunaryExprMetaModel.operatorPropertyMetaModel);
		___003C_003EvariableDeclarationExprMetaModel.getConstructorParameters().add(___003C_003EvariableDeclarationExprMetaModel.modifiersPropertyMetaModel);
		___003C_003EvariableDeclarationExprMetaModel.getConstructorParameters().add(___003C_003EvariableDeclarationExprMetaModel.annotationsPropertyMetaModel);
		___003C_003EvariableDeclarationExprMetaModel.getConstructorParameters().add(___003C_003EvariableDeclarationExprMetaModel.variablesPropertyMetaModel);
		___003C_003EassertStmtMetaModel.getConstructorParameters().add(___003C_003EassertStmtMetaModel.checkPropertyMetaModel);
		___003C_003EassertStmtMetaModel.getConstructorParameters().add(___003C_003EassertStmtMetaModel.messagePropertyMetaModel);
		___003C_003EblockStmtMetaModel.getConstructorParameters().add(___003C_003EblockStmtMetaModel.statementsPropertyMetaModel);
		___003C_003EbreakStmtMetaModel.getConstructorParameters().add(___003C_003EbreakStmtMetaModel.labelPropertyMetaModel);
		___003C_003EcatchClauseMetaModel.getConstructorParameters().add(___003C_003EcatchClauseMetaModel.parameterPropertyMetaModel);
		___003C_003EcatchClauseMetaModel.getConstructorParameters().add(___003C_003EcatchClauseMetaModel.bodyPropertyMetaModel);
		___003C_003EcontinueStmtMetaModel.getConstructorParameters().add(___003C_003EcontinueStmtMetaModel.labelPropertyMetaModel);
		___003C_003EdoStmtMetaModel.getConstructorParameters().add(___003C_003EdoStmtMetaModel.bodyPropertyMetaModel);
		___003C_003EdoStmtMetaModel.getConstructorParameters().add(___003C_003EdoStmtMetaModel.conditionPropertyMetaModel);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.getConstructorParameters().add(___003C_003EexplicitConstructorInvocationStmtMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.getConstructorParameters().add(___003C_003EexplicitConstructorInvocationStmtMetaModel.isThisPropertyMetaModel);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.getConstructorParameters().add(___003C_003EexplicitConstructorInvocationStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EexplicitConstructorInvocationStmtMetaModel.getConstructorParameters().add(___003C_003EexplicitConstructorInvocationStmtMetaModel.argumentsPropertyMetaModel);
		___003C_003EexpressionStmtMetaModel.getConstructorParameters().add(___003C_003EexpressionStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EforEachStmtMetaModel.getConstructorParameters().add(___003C_003EforEachStmtMetaModel.variablePropertyMetaModel);
		___003C_003EforEachStmtMetaModel.getConstructorParameters().add(___003C_003EforEachStmtMetaModel.iterablePropertyMetaModel);
		___003C_003EforEachStmtMetaModel.getConstructorParameters().add(___003C_003EforEachStmtMetaModel.bodyPropertyMetaModel);
		___003C_003EforStmtMetaModel.getConstructorParameters().add(___003C_003EforStmtMetaModel.initializationPropertyMetaModel);
		___003C_003EforStmtMetaModel.getConstructorParameters().add(___003C_003EforStmtMetaModel.comparePropertyMetaModel);
		___003C_003EforStmtMetaModel.getConstructorParameters().add(___003C_003EforStmtMetaModel.updatePropertyMetaModel);
		___003C_003EforStmtMetaModel.getConstructorParameters().add(___003C_003EforStmtMetaModel.bodyPropertyMetaModel);
		___003C_003EifStmtMetaModel.getConstructorParameters().add(___003C_003EifStmtMetaModel.conditionPropertyMetaModel);
		___003C_003EifStmtMetaModel.getConstructorParameters().add(___003C_003EifStmtMetaModel.thenStmtPropertyMetaModel);
		___003C_003EifStmtMetaModel.getConstructorParameters().add(___003C_003EifStmtMetaModel.elseStmtPropertyMetaModel);
		___003C_003ElabeledStmtMetaModel.getConstructorParameters().add(___003C_003ElabeledStmtMetaModel.labelPropertyMetaModel);
		___003C_003ElabeledStmtMetaModel.getConstructorParameters().add(___003C_003ElabeledStmtMetaModel.statementPropertyMetaModel);
		___003C_003ElocalClassDeclarationStmtMetaModel.getConstructorParameters().add(___003C_003ElocalClassDeclarationStmtMetaModel.classDeclarationPropertyMetaModel);
		___003C_003ElocalRecordDeclarationStmtMetaModel.getConstructorParameters().add(___003C_003ElocalRecordDeclarationStmtMetaModel.recordDeclarationPropertyMetaModel);
		___003C_003EreturnStmtMetaModel.getConstructorParameters().add(___003C_003EreturnStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EswitchEntryMetaModel.getConstructorParameters().add(___003C_003EswitchEntryMetaModel.labelsPropertyMetaModel);
		___003C_003EswitchEntryMetaModel.getConstructorParameters().add(___003C_003EswitchEntryMetaModel.typePropertyMetaModel);
		___003C_003EswitchEntryMetaModel.getConstructorParameters().add(___003C_003EswitchEntryMetaModel.statementsPropertyMetaModel);
		___003C_003EswitchStmtMetaModel.getConstructorParameters().add(___003C_003EswitchStmtMetaModel.selectorPropertyMetaModel);
		___003C_003EswitchStmtMetaModel.getConstructorParameters().add(___003C_003EswitchStmtMetaModel.entriesPropertyMetaModel);
		___003C_003EsynchronizedStmtMetaModel.getConstructorParameters().add(___003C_003EsynchronizedStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EsynchronizedStmtMetaModel.getConstructorParameters().add(___003C_003EsynchronizedStmtMetaModel.bodyPropertyMetaModel);
		___003C_003EthrowStmtMetaModel.getConstructorParameters().add(___003C_003EthrowStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EtryStmtMetaModel.getConstructorParameters().add(___003C_003EtryStmtMetaModel.resourcesPropertyMetaModel);
		___003C_003EtryStmtMetaModel.getConstructorParameters().add(___003C_003EtryStmtMetaModel.tryBlockPropertyMetaModel);
		___003C_003EtryStmtMetaModel.getConstructorParameters().add(___003C_003EtryStmtMetaModel.catchClausesPropertyMetaModel);
		___003C_003EtryStmtMetaModel.getConstructorParameters().add(___003C_003EtryStmtMetaModel.finallyBlockPropertyMetaModel);
		___003C_003EwhileStmtMetaModel.getConstructorParameters().add(___003C_003EwhileStmtMetaModel.conditionPropertyMetaModel);
		___003C_003EwhileStmtMetaModel.getConstructorParameters().add(___003C_003EwhileStmtMetaModel.bodyPropertyMetaModel);
		___003C_003EyieldStmtMetaModel.getConstructorParameters().add(___003C_003EyieldStmtMetaModel.expressionPropertyMetaModel);
		___003C_003EarrayTypeMetaModel.getConstructorParameters().add(___003C_003EarrayTypeMetaModel.componentTypePropertyMetaModel);
		___003C_003EarrayTypeMetaModel.getConstructorParameters().add(___003C_003EarrayTypeMetaModel.originPropertyMetaModel);
		___003C_003EarrayTypeMetaModel.getConstructorParameters().add(___003C_003EtypeMetaModel.annotationsPropertyMetaModel);
		___003C_003EclassOrInterfaceTypeMetaModel.getConstructorParameters().add(___003C_003EclassOrInterfaceTypeMetaModel.scopePropertyMetaModel);
		___003C_003EclassOrInterfaceTypeMetaModel.getConstructorParameters().add(___003C_003EclassOrInterfaceTypeMetaModel.namePropertyMetaModel);
		___003C_003EclassOrInterfaceTypeMetaModel.getConstructorParameters().add(___003C_003EclassOrInterfaceTypeMetaModel.typeArgumentsPropertyMetaModel);
		___003C_003EclassOrInterfaceTypeMetaModel.getConstructorParameters().add(___003C_003EtypeMetaModel.annotationsPropertyMetaModel);
		___003C_003EintersectionTypeMetaModel.getConstructorParameters().add(___003C_003EintersectionTypeMetaModel.elementsPropertyMetaModel);
		___003C_003EprimitiveTypeMetaModel.getConstructorParameters().add(___003C_003EprimitiveTypeMetaModel.typePropertyMetaModel);
		___003C_003EprimitiveTypeMetaModel.getConstructorParameters().add(___003C_003EtypeMetaModel.annotationsPropertyMetaModel);
		___003C_003EtypeParameterMetaModel.getConstructorParameters().add(___003C_003EtypeParameterMetaModel.namePropertyMetaModel);
		___003C_003EtypeParameterMetaModel.getConstructorParameters().add(___003C_003EtypeParameterMetaModel.typeBoundPropertyMetaModel);
		___003C_003EtypeParameterMetaModel.getConstructorParameters().add(___003C_003EtypeMetaModel.annotationsPropertyMetaModel);
		___003C_003EunionTypeMetaModel.getConstructorParameters().add(___003C_003EunionTypeMetaModel.elementsPropertyMetaModel);
		___003C_003EwildcardTypeMetaModel.getConstructorParameters().add(___003C_003EwildcardTypeMetaModel.extendedTypePropertyMetaModel);
		___003C_003EwildcardTypeMetaModel.getConstructorParameters().add(___003C_003EwildcardTypeMetaModel.superTypePropertyMetaModel);
		___003C_003EwildcardTypeMetaModel.getConstructorParameters().add(___003C_003EtypeMetaModel.annotationsPropertyMetaModel);
		___003C_003EmoduleExportsDirectiveMetaModel.getConstructorParameters().add(___003C_003EmoduleExportsDirectiveMetaModel.namePropertyMetaModel);
		___003C_003EmoduleExportsDirectiveMetaModel.getConstructorParameters().add(___003C_003EmoduleExportsDirectiveMetaModel.moduleNamesPropertyMetaModel);
		___003C_003EmoduleOpensDirectiveMetaModel.getConstructorParameters().add(___003C_003EmoduleOpensDirectiveMetaModel.namePropertyMetaModel);
		___003C_003EmoduleOpensDirectiveMetaModel.getConstructorParameters().add(___003C_003EmoduleOpensDirectiveMetaModel.moduleNamesPropertyMetaModel);
		___003C_003EmoduleProvidesDirectiveMetaModel.getConstructorParameters().add(___003C_003EmoduleProvidesDirectiveMetaModel.namePropertyMetaModel);
		___003C_003EmoduleProvidesDirectiveMetaModel.getConstructorParameters().add(___003C_003EmoduleProvidesDirectiveMetaModel.withPropertyMetaModel);
		___003C_003EmoduleRequiresDirectiveMetaModel.getConstructorParameters().add(___003C_003EmoduleRequiresDirectiveMetaModel.modifiersPropertyMetaModel);
		___003C_003EmoduleRequiresDirectiveMetaModel.getConstructorParameters().add(___003C_003EmoduleRequiresDirectiveMetaModel.namePropertyMetaModel);
		___003C_003EmoduleUsesDirectiveMetaModel.getConstructorParameters().add(___003C_003EmoduleUsesDirectiveMetaModel.namePropertyMetaModel);
	}

	
	
	private JavaParserMetaModel()
	{
	}

	
		
	
	public static Optional getNodeMetaModel(Class c)
	{
		Iterator iterator = nodeMetaModels.iterator();
		while (iterator.hasNext())
		{
			BaseNodeMetaModel baseNodeMetaModel = (BaseNodeMetaModel)iterator.next();
			if (String.instancehelper_equals(baseNodeMetaModel.getTypeName(), c.getSimpleName()))
			{
				Optional result = Optional.of(baseNodeMetaModel);
				
				return result;
			}
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	[LineNumberTable(new byte[]
	{
		159, 178, 234, 163, 49, 175, 180, 180, 180, 180,
		180, 180, 180, 180, 180, 180, 180, 180, 180, 180,
		180, 180, 180, 180, 180, 180, 180, 180, 180, 180,
		180, 180, 180, 180, 180, 180, 180, 180, 180, 180,
		180, 180, 180, 180, 180, 180, 180, 180, 180, 180,
		180, 180, 180, 180, 180, 180, 180, 180, 180, 180,
		180, 180, 180, 180, 180, 180, 180, 180, 180, 180,
		180, 180, 180, 180, 180, 180, 180, 180, 180, 180,
		180, 180, 180, 180, 180, 180, 180, 180, 180, 180,
		180, 180, 180, 180, 180, 180, 180, 180, 180, 180,
		180, 180, 180, 180, 180, 180, 180, 180, 180, 180,
		180, 180, 180, 180, 180, 180, 180, 101, 101, 103
	})]
	static JavaParserMetaModel()
	{
		nodeMetaModels = new ArrayList();
		___003C_003EnodeMetaModel = new NodeMetaModel(Optional.empty());
		___003C_003EbodyDeclarationMetaModel = new BodyDeclarationMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EcallableDeclarationMetaModel = new CallableDeclarationMetaModel(Optional.of(___003C_003EbodyDeclarationMetaModel));
		___003C_003EexpressionMetaModel = new ExpressionMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EstatementMetaModel = new StatementMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EtypeMetaModel = new TypeMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EannotationExprMetaModel = new AnnotationExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EreferenceTypeMetaModel = new ReferenceTypeMetaModel(Optional.of(___003C_003EtypeMetaModel));
		___003C_003EtypeDeclarationMetaModel = new TypeDeclarationMetaModel(Optional.of(___003C_003EbodyDeclarationMetaModel));
		___003C_003EliteralExprMetaModel = new LiteralExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EliteralStringValueExprMetaModel = new LiteralStringValueExprMetaModel(Optional.of(___003C_003EliteralExprMetaModel));
		___003C_003EstringLiteralExprMetaModel = new StringLiteralExprMetaModel(Optional.of(___003C_003EliteralStringValueExprMetaModel));
		___003C_003EmoduleDeclarationMetaModel = new ModuleDeclarationMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EmoduleDirectiveMetaModel = new ModuleDirectiveMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EarrayCreationLevelMetaModel = new ArrayCreationLevelMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EcompilationUnitMetaModel = new CompilationUnitMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EimportDeclarationMetaModel = new ImportDeclarationMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EmodifierMetaModel = new ModifierMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EpackageDeclarationMetaModel = new PackageDeclarationMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EannotationDeclarationMetaModel = new AnnotationDeclarationMetaModel(Optional.of(___003C_003EtypeDeclarationMetaModel));
		___003C_003EannotationMemberDeclarationMetaModel = new AnnotationMemberDeclarationMetaModel(Optional.of(___003C_003EbodyDeclarationMetaModel));
		___003C_003EclassOrInterfaceDeclarationMetaModel = new ClassOrInterfaceDeclarationMetaModel(Optional.of(___003C_003EtypeDeclarationMetaModel));
		___003C_003EconstructorDeclarationMetaModel = new ConstructorDeclarationMetaModel(Optional.of(___003C_003EcallableDeclarationMetaModel));
		___003C_003EenumConstantDeclarationMetaModel = new EnumConstantDeclarationMetaModel(Optional.of(___003C_003EbodyDeclarationMetaModel));
		___003C_003EenumDeclarationMetaModel = new EnumDeclarationMetaModel(Optional.of(___003C_003EtypeDeclarationMetaModel));
		___003C_003EfieldDeclarationMetaModel = new FieldDeclarationMetaModel(Optional.of(___003C_003EbodyDeclarationMetaModel));
		___003C_003EinitializerDeclarationMetaModel = new InitializerDeclarationMetaModel(Optional.of(___003C_003EbodyDeclarationMetaModel));
		___003C_003EmethodDeclarationMetaModel = new MethodDeclarationMetaModel(Optional.of(___003C_003EcallableDeclarationMetaModel));
		___003C_003EparameterMetaModel = new ParameterMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EreceiverParameterMetaModel = new ReceiverParameterMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003ErecordDeclarationMetaModel = new RecordDeclarationMetaModel(Optional.of(___003C_003EtypeDeclarationMetaModel));
		___003C_003EcompactConstructorDeclarationMetaModel = new CompactConstructorDeclarationMetaModel(Optional.of(___003C_003EbodyDeclarationMetaModel));
		___003C_003EvariableDeclaratorMetaModel = new VariableDeclaratorMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EcommentMetaModel = new CommentMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EblockCommentMetaModel = new BlockCommentMetaModel(Optional.of(___003C_003EcommentMetaModel));
		___003C_003EjavadocCommentMetaModel = new JavadocCommentMetaModel(Optional.of(___003C_003EcommentMetaModel));
		___003C_003ElineCommentMetaModel = new LineCommentMetaModel(Optional.of(___003C_003EcommentMetaModel));
		___003C_003EarrayAccessExprMetaModel = new ArrayAccessExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EarrayCreationExprMetaModel = new ArrayCreationExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EarrayInitializerExprMetaModel = new ArrayInitializerExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EassignExprMetaModel = new AssignExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EbinaryExprMetaModel = new BinaryExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EbooleanLiteralExprMetaModel = new BooleanLiteralExprMetaModel(Optional.of(___003C_003EliteralExprMetaModel));
		___003C_003EcastExprMetaModel = new CastExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EcharLiteralExprMetaModel = new CharLiteralExprMetaModel(Optional.of(___003C_003EliteralStringValueExprMetaModel));
		___003C_003EclassExprMetaModel = new ClassExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EconditionalExprMetaModel = new ConditionalExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EdoubleLiteralExprMetaModel = new DoubleLiteralExprMetaModel(Optional.of(___003C_003EliteralStringValueExprMetaModel));
		___003C_003EenclosedExprMetaModel = new EnclosedExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EfieldAccessExprMetaModel = new FieldAccessExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EinstanceOfExprMetaModel = new InstanceOfExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EintegerLiteralExprMetaModel = new IntegerLiteralExprMetaModel(Optional.of(___003C_003EliteralStringValueExprMetaModel));
		___003C_003ElambdaExprMetaModel = new LambdaExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003ElongLiteralExprMetaModel = new LongLiteralExprMetaModel(Optional.of(___003C_003EliteralStringValueExprMetaModel));
		___003C_003EmarkerAnnotationExprMetaModel = new MarkerAnnotationExprMetaModel(Optional.of(___003C_003EannotationExprMetaModel));
		___003C_003EmemberValuePairMetaModel = new MemberValuePairMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EmethodCallExprMetaModel = new MethodCallExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EmethodReferenceExprMetaModel = new MethodReferenceExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EnameExprMetaModel = new NameExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EnameMetaModel = new NameMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EnormalAnnotationExprMetaModel = new NormalAnnotationExprMetaModel(Optional.of(___003C_003EannotationExprMetaModel));
		___003C_003EnullLiteralExprMetaModel = new NullLiteralExprMetaModel(Optional.of(___003C_003EliteralExprMetaModel));
		___003C_003EobjectCreationExprMetaModel = new ObjectCreationExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EpatternExprMetaModel = new PatternExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EsingleMemberAnnotationExprMetaModel = new SingleMemberAnnotationExprMetaModel(Optional.of(___003C_003EannotationExprMetaModel));
		___003C_003EsimpleNameMetaModel = new SimpleNameMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EsuperExprMetaModel = new SuperExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EswitchExprMetaModel = new SwitchExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EtextBlockLiteralExprMetaModel = new TextBlockLiteralExprMetaModel(Optional.of(___003C_003EliteralStringValueExprMetaModel));
		___003C_003EthisExprMetaModel = new ThisExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EtypeExprMetaModel = new TypeExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EunaryExprMetaModel = new UnaryExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EvariableDeclarationExprMetaModel = new VariableDeclarationExprMetaModel(Optional.of(___003C_003EexpressionMetaModel));
		___003C_003EassertStmtMetaModel = new AssertStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EblockStmtMetaModel = new BlockStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EbreakStmtMetaModel = new BreakStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EcatchClauseMetaModel = new CatchClauseMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EcontinueStmtMetaModel = new ContinueStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EdoStmtMetaModel = new DoStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EemptyStmtMetaModel = new EmptyStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EexplicitConstructorInvocationStmtMetaModel = new ExplicitConstructorInvocationStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EexpressionStmtMetaModel = new ExpressionStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EforEachStmtMetaModel = new ForEachStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EforStmtMetaModel = new ForStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EifStmtMetaModel = new IfStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003ElabeledStmtMetaModel = new LabeledStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003ElocalClassDeclarationStmtMetaModel = new LocalClassDeclarationStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003ElocalRecordDeclarationStmtMetaModel = new LocalRecordDeclarationStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EreturnStmtMetaModel = new ReturnStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EswitchEntryMetaModel = new SwitchEntryMetaModel(Optional.of(___003C_003EnodeMetaModel));
		___003C_003EswitchStmtMetaModel = new SwitchStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EsynchronizedStmtMetaModel = new SynchronizedStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EthrowStmtMetaModel = new ThrowStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EtryStmtMetaModel = new TryStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EunparsableStmtMetaModel = new UnparsableStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EwhileStmtMetaModel = new WhileStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EyieldStmtMetaModel = new YieldStmtMetaModel(Optional.of(___003C_003EstatementMetaModel));
		___003C_003EarrayTypeMetaModel = new ArrayTypeMetaModel(Optional.of(___003C_003EreferenceTypeMetaModel));
		___003C_003EclassOrInterfaceTypeMetaModel = new ClassOrInterfaceTypeMetaModel(Optional.of(___003C_003EreferenceTypeMetaModel));
		___003C_003EintersectionTypeMetaModel = new IntersectionTypeMetaModel(Optional.of(___003C_003EtypeMetaModel));
		___003C_003EprimitiveTypeMetaModel = new PrimitiveTypeMetaModel(Optional.of(___003C_003EtypeMetaModel));
		___003C_003EtypeParameterMetaModel = new TypeParameterMetaModel(Optional.of(___003C_003EreferenceTypeMetaModel));
		___003C_003EunionTypeMetaModel = new UnionTypeMetaModel(Optional.of(___003C_003EtypeMetaModel));
		___003C_003EunknownTypeMetaModel = new UnknownTypeMetaModel(Optional.of(___003C_003EtypeMetaModel));
		___003C_003EvarTypeMetaModel = new VarTypeMetaModel(Optional.of(___003C_003EtypeMetaModel));
		___003C_003EvoidTypeMetaModel = new VoidTypeMetaModel(Optional.of(___003C_003EtypeMetaModel));
		___003C_003EwildcardTypeMetaModel = new WildcardTypeMetaModel(Optional.of(___003C_003EtypeMetaModel));
		___003C_003EmoduleExportsDirectiveMetaModel = new ModuleExportsDirectiveMetaModel(Optional.of(___003C_003EmoduleDirectiveMetaModel));
		___003C_003EmoduleOpensDirectiveMetaModel = new ModuleOpensDirectiveMetaModel(Optional.of(___003C_003EmoduleDirectiveMetaModel));
		___003C_003EmoduleProvidesDirectiveMetaModel = new ModuleProvidesDirectiveMetaModel(Optional.of(___003C_003EmoduleDirectiveMetaModel));
		___003C_003EmoduleRequiresDirectiveMetaModel = new ModuleRequiresDirectiveMetaModel(Optional.of(___003C_003EmoduleDirectiveMetaModel));
		___003C_003EmoduleUsesDirectiveMetaModel = new ModuleUsesDirectiveMetaModel(Optional.of(___003C_003EmoduleDirectiveMetaModel));
		initializeNodeMetaModels();
		initializePropertyMetaModels();
		initializeConstructorParameters();
	}
}
