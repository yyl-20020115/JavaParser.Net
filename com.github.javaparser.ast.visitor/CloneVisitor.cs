using System.ComponentModel;

using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.visitor;

public class CloneVisitor : GenericVisitor
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly CompilationUnit arg_00241;

		internal ___003C_003EAnon0(CompilationUnit P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024visit_00240(arg_00241, (CompilationUnit.Storage)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Comment result = ((Comment)P_0).clone();
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly CompilationUnit arg_00241;

		internal ___003C_003EAnon2(CompilationUnit P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly PackageDeclaration arg_00241;

		internal ___003C_003EAnon3(PackageDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly TypeParameter arg_00241;

		internal ___003C_003EAnon4(TypeParameter P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Consumer
	{
		private readonly LineComment arg_00241;

		internal ___003C_003EAnon5(LineComment P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Consumer
	{
		private readonly BlockComment arg_00241;

		internal ___003C_003EAnon6(BlockComment P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : Consumer
	{
		private readonly ClassOrInterfaceDeclaration arg_00241;

		internal ___003C_003EAnon7(ClassOrInterfaceDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon8 : Consumer
	{
		private readonly EnumDeclaration arg_00241;

		internal ___003C_003EAnon8(EnumDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon9 : Consumer
	{
		private readonly EnumConstantDeclaration arg_00241;

		internal ___003C_003EAnon9(EnumConstantDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon10 : Consumer
	{
		private readonly AnnotationDeclaration arg_00241;

		internal ___003C_003EAnon10(AnnotationDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon11 : Consumer
	{
		private readonly AnnotationMemberDeclaration arg_00241;

		internal ___003C_003EAnon11(AnnotationMemberDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon12 : Consumer
	{
		private readonly FieldDeclaration arg_00241;

		internal ___003C_003EAnon12(FieldDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon13 : Consumer
	{
		private readonly VariableDeclarator arg_00241;

		internal ___003C_003EAnon13(VariableDeclarator P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon14 : Consumer
	{
		private readonly ConstructorDeclaration arg_00241;

		internal ___003C_003EAnon14(ConstructorDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon15 : Consumer
	{
		private readonly MethodDeclaration arg_00241;

		internal ___003C_003EAnon15(MethodDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon16 : Consumer
	{
		private readonly Parameter arg_00241;

		internal ___003C_003EAnon16(Parameter P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon17 : Consumer
	{
		private readonly InitializerDeclaration arg_00241;

		internal ___003C_003EAnon17(InitializerDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon18 : Consumer
	{
		private readonly JavadocComment arg_00241;

		internal ___003C_003EAnon18(JavadocComment P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon19 : Consumer
	{
		private readonly ClassOrInterfaceType arg_00241;

		internal ___003C_003EAnon19(ClassOrInterfaceType P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon20 : Consumer
	{
		private readonly PrimitiveType arg_00241;

		internal ___003C_003EAnon20(PrimitiveType P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon21 : Consumer
	{
		private readonly ArrayType arg_00241;

		internal ___003C_003EAnon21(ArrayType P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon22 : Consumer
	{
		private readonly ArrayCreationLevel arg_00241;

		internal ___003C_003EAnon22(ArrayCreationLevel P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon23 : Consumer
	{
		private readonly IntersectionType arg_00241;

		internal ___003C_003EAnon23(IntersectionType P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon24 : Consumer
	{
		private readonly UnionType arg_00241;

		internal ___003C_003EAnon24(UnionType P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon25 : Consumer
	{
		private readonly VoidType arg_00241;

		internal ___003C_003EAnon25(VoidType P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon26 : Consumer
	{
		private readonly WildcardType arg_00241;

		internal ___003C_003EAnon26(WildcardType P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon27 : Consumer
	{
		private readonly UnknownType arg_00241;

		internal ___003C_003EAnon27(UnknownType P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon28 : Consumer
	{
		private readonly ArrayAccessExpr arg_00241;

		internal ___003C_003EAnon28(ArrayAccessExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon29 : Consumer
	{
		private readonly ArrayCreationExpr arg_00241;

		internal ___003C_003EAnon29(ArrayCreationExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon30 : Consumer
	{
		private readonly ArrayInitializerExpr arg_00241;

		internal ___003C_003EAnon30(ArrayInitializerExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon31 : Consumer
	{
		private readonly AssignExpr arg_00241;

		internal ___003C_003EAnon31(AssignExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon32 : Consumer
	{
		private readonly BinaryExpr arg_00241;

		internal ___003C_003EAnon32(BinaryExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon33 : Consumer
	{
		private readonly CastExpr arg_00241;

		internal ___003C_003EAnon33(CastExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon34 : Consumer
	{
		private readonly ClassExpr arg_00241;

		internal ___003C_003EAnon34(ClassExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon35 : Consumer
	{
		private readonly ConditionalExpr arg_00241;

		internal ___003C_003EAnon35(ConditionalExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon36 : Consumer
	{
		private readonly EnclosedExpr arg_00241;

		internal ___003C_003EAnon36(EnclosedExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon37 : Consumer
	{
		private readonly FieldAccessExpr arg_00241;

		internal ___003C_003EAnon37(FieldAccessExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon38 : Consumer
	{
		private readonly InstanceOfExpr arg_00241;

		internal ___003C_003EAnon38(InstanceOfExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon39 : Consumer
	{
		private readonly StringLiteralExpr arg_00241;

		internal ___003C_003EAnon39(StringLiteralExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon40 : Consumer
	{
		private readonly IntegerLiteralExpr arg_00241;

		internal ___003C_003EAnon40(IntegerLiteralExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon41 : Consumer
	{
		private readonly LongLiteralExpr arg_00241;

		internal ___003C_003EAnon41(LongLiteralExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon42 : Consumer
	{
		private readonly CharLiteralExpr arg_00241;

		internal ___003C_003EAnon42(CharLiteralExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon43 : Consumer
	{
		private readonly DoubleLiteralExpr arg_00241;

		internal ___003C_003EAnon43(DoubleLiteralExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon44 : Consumer
	{
		private readonly BooleanLiteralExpr arg_00241;

		internal ___003C_003EAnon44(BooleanLiteralExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon45 : Consumer
	{
		private readonly NullLiteralExpr arg_00241;

		internal ___003C_003EAnon45(NullLiteralExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon46 : Consumer
	{
		private readonly MethodCallExpr arg_00241;

		internal ___003C_003EAnon46(MethodCallExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon47 : Consumer
	{
		private readonly NameExpr arg_00241;

		internal ___003C_003EAnon47(NameExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon48 : Consumer
	{
		private readonly ObjectCreationExpr arg_00241;

		internal ___003C_003EAnon48(ObjectCreationExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon49 : Consumer
	{
		private readonly Name arg_00241;

		internal ___003C_003EAnon49(Name P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon50 : Consumer
	{
		private readonly SimpleName arg_00241;

		internal ___003C_003EAnon50(SimpleName P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon51 : Consumer
	{
		private readonly ThisExpr arg_00241;

		internal ___003C_003EAnon51(ThisExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon52 : Consumer
	{
		private readonly SuperExpr arg_00241;

		internal ___003C_003EAnon52(SuperExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon53 : Consumer
	{
		private readonly UnaryExpr arg_00241;

		internal ___003C_003EAnon53(UnaryExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon54 : Consumer
	{
		private readonly VariableDeclarationExpr arg_00241;

		internal ___003C_003EAnon54(VariableDeclarationExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon55 : Consumer
	{
		private readonly MarkerAnnotationExpr arg_00241;

		internal ___003C_003EAnon55(MarkerAnnotationExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon56 : Consumer
	{
		private readonly SingleMemberAnnotationExpr arg_00241;

		internal ___003C_003EAnon56(SingleMemberAnnotationExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon57 : Consumer
	{
		private readonly NormalAnnotationExpr arg_00241;

		internal ___003C_003EAnon57(NormalAnnotationExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon58 : Consumer
	{
		private readonly MemberValuePair arg_00241;

		internal ___003C_003EAnon58(MemberValuePair P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon59 : Consumer
	{
		private readonly ExplicitConstructorInvocationStmt arg_00241;

		internal ___003C_003EAnon59(ExplicitConstructorInvocationStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon60 : Consumer
	{
		private readonly LocalClassDeclarationStmt arg_00241;

		internal ___003C_003EAnon60(LocalClassDeclarationStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon61 : Consumer
	{
		private readonly LocalRecordDeclarationStmt arg_00241;

		internal ___003C_003EAnon61(LocalRecordDeclarationStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon62 : Consumer
	{
		private readonly AssertStmt arg_00241;

		internal ___003C_003EAnon62(AssertStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon63 : Consumer
	{
		private readonly BlockStmt arg_00241;

		internal ___003C_003EAnon63(BlockStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon64 : Consumer
	{
		private readonly LabeledStmt arg_00241;

		internal ___003C_003EAnon64(LabeledStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon65 : Consumer
	{
		private readonly EmptyStmt arg_00241;

		internal ___003C_003EAnon65(EmptyStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon66 : Consumer
	{
		private readonly ExpressionStmt arg_00241;

		internal ___003C_003EAnon66(ExpressionStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon67 : Consumer
	{
		private readonly SwitchStmt arg_00241;

		internal ___003C_003EAnon67(SwitchStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon68 : Consumer
	{
		private readonly SwitchEntry arg_00241;

		internal ___003C_003EAnon68(SwitchEntry P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon69 : Consumer
	{
		private readonly BreakStmt arg_00241;

		internal ___003C_003EAnon69(BreakStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon70 : Consumer
	{
		private readonly ReturnStmt arg_00241;

		internal ___003C_003EAnon70(ReturnStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon71 : Consumer
	{
		private readonly IfStmt arg_00241;

		internal ___003C_003EAnon71(IfStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon72 : Consumer
	{
		private readonly WhileStmt arg_00241;

		internal ___003C_003EAnon72(WhileStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon73 : Consumer
	{
		private readonly ContinueStmt arg_00241;

		internal ___003C_003EAnon73(ContinueStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon74 : Consumer
	{
		private readonly DoStmt arg_00241;

		internal ___003C_003EAnon74(DoStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon75 : Consumer
	{
		private readonly ForEachStmt arg_00241;

		internal ___003C_003EAnon75(ForEachStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon76 : Consumer
	{
		private readonly ForStmt arg_00241;

		internal ___003C_003EAnon76(ForStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon77 : Consumer
	{
		private readonly ThrowStmt arg_00241;

		internal ___003C_003EAnon77(ThrowStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon78 : Consumer
	{
		private readonly SynchronizedStmt arg_00241;

		internal ___003C_003EAnon78(SynchronizedStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon79 : Consumer
	{
		private readonly TryStmt arg_00241;

		internal ___003C_003EAnon79(TryStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon80 : Consumer
	{
		private readonly CatchClause arg_00241;

		internal ___003C_003EAnon80(CatchClause P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon81 : Consumer
	{
		private readonly LambdaExpr arg_00241;

		internal ___003C_003EAnon81(LambdaExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon82 : Consumer
	{
		private readonly MethodReferenceExpr arg_00241;

		internal ___003C_003EAnon82(MethodReferenceExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon83 : Consumer
	{
		private readonly TypeExpr arg_00241;

		internal ___003C_003EAnon83(TypeExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon84 : Consumer
	{
		private readonly ImportDeclaration arg_00241;

		internal ___003C_003EAnon84(ImportDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon85 : Consumer
	{
		private readonly ModuleDeclaration arg_00241;

		internal ___003C_003EAnon85(ModuleDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon86 : Consumer
	{
		private readonly ModuleRequiresDirective arg_00241;

		internal ___003C_003EAnon86(ModuleRequiresDirective P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon87 : Consumer
	{
		private readonly ModuleExportsDirective arg_00241;

		internal ___003C_003EAnon87(ModuleExportsDirective P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon88 : Consumer
	{
		private readonly ModuleProvidesDirective arg_00241;

		internal ___003C_003EAnon88(ModuleProvidesDirective P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon89 : Consumer
	{
		private readonly ModuleUsesDirective arg_00241;

		internal ___003C_003EAnon89(ModuleUsesDirective P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon90 : Consumer
	{
		private readonly ModuleOpensDirective arg_00241;

		internal ___003C_003EAnon90(ModuleOpensDirective P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon91 : Consumer
	{
		private readonly UnparsableStmt arg_00241;

		internal ___003C_003EAnon91(UnparsableStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon92 : Consumer
	{
		private readonly ReceiverParameter arg_00241;

		internal ___003C_003EAnon92(ReceiverParameter P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon93 : Consumer
	{
		private readonly VarType arg_00241;

		internal ___003C_003EAnon93(VarType P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon94 : Consumer
	{
		private readonly Modifier arg_00241;

		internal ___003C_003EAnon94(Modifier P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon95 : Consumer
	{
		private readonly SwitchExpr arg_00241;

		internal ___003C_003EAnon95(SwitchExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon96 : Consumer
	{
		private readonly YieldStmt arg_00241;

		internal ___003C_003EAnon96(YieldStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon97 : Consumer
	{
		private readonly TextBlockLiteralExpr arg_00241;

		internal ___003C_003EAnon97(TextBlockLiteralExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon98 : Consumer
	{
		private readonly PatternExpr arg_00241;

		internal ___003C_003EAnon98(PatternExpr P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon99 : Consumer
	{
		private readonly RecordDeclaration arg_00241;

		internal ___003C_003EAnon99(RecordDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon100 : Consumer
	{
		private readonly CompactConstructorDeclaration arg_00241;

		internal ___003C_003EAnon100(CompactConstructorDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addOrphanComment((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	
	public CloneVisitor()
	{
	}

	
		
	
	private NodeList cloneList(NodeList list, object arg)
	{
		if (list == null)
		{
			return null;
		}
		return (NodeList)list.accept(this, arg);
	}

	
		
	
	protected internal virtual Node cloneNode(Optional node, object arg)
	{
		if (!node.isPresent())
		{
			return null;
		}
		Node node2 = (Node)((Node)node.get()).accept(this, arg);
		if (node2 == null)
		{
			return null;
		}
		return node2;
	}

	
	
	
	private void copyData(Node source, Node destination)
	{
		Iterator iterator = source.getDataKeys().iterator();
		while (iterator.hasNext())
		{
			DataKey key = (DataKey)iterator.next();
			destination.setData(key, source.getData(key));
		}
	}

	
		
	
	protected internal virtual Node cloneNode(Node node, object arg)
	{
		if (node == null)
		{
			return null;
		}
		Node node2 = (Node)node.accept(this, arg);
		if (node2 == null)
		{
			return null;
		}
		return node2;
	}

	
	
	
	public unsafe virtual Visitable visit(PatternExpr n, object arg)
	{
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		ReferenceType type = (ReferenceType)cloneNode(n.getType(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		PatternExpr.___003Cclinit_003E();
		PatternExpr patternExpr = new PatternExpr((TokenRange)n.getTokenRange().orElse(null), type, name);
		patternExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon98(patternExpr));
		copyData(n, patternExpr);
		return patternExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(TextBlockLiteralExpr n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		TextBlockLiteralExpr.___003Cclinit_003E();
		TextBlockLiteralExpr textBlockLiteralExpr = new TextBlockLiteralExpr((TokenRange)n.getTokenRange().orElse(null), n.getValue());
		textBlockLiteralExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon97(textBlockLiteralExpr));
		copyData(n, textBlockLiteralExpr);
		return textBlockLiteralExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(YieldStmt n, object arg)
	{
		Expression expression = (Expression)cloneNode(n.getExpression(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		YieldStmt.___003Cclinit_003E();
		YieldStmt yieldStmt = new YieldStmt((TokenRange)n.getTokenRange().orElse(null), expression);
		yieldStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon96(yieldStmt));
		copyData(n, yieldStmt);
		return yieldStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(SwitchExpr n, object arg)
	{
		NodeList entries = cloneList(n.getEntries(), arg);
		Expression selector = (Expression)cloneNode(n.getSelector(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		SwitchExpr.___003Cclinit_003E();
		SwitchExpr switchExpr = new SwitchExpr((TokenRange)n.getTokenRange().orElse(null), selector, entries);
		switchExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon95(switchExpr));
		copyData(n, switchExpr);
		return switchExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(Modifier n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		Modifier.___003Cclinit_003E();
		Modifier modifier = new Modifier((TokenRange)n.getTokenRange().orElse(null), n.getKeyword());
		modifier.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon94(modifier));
		copyData(n, modifier);
		return modifier;
	}

	
	
	
	public unsafe virtual Visitable visit(VarType n, object arg)
	{
		cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		VarType.___003Cclinit_003E();
		VarType varType = new VarType((TokenRange)n.getTokenRange().orElse(null));
		varType.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon93(varType));
		copyData(n, varType);
		return varType;
	}

	
	
	
	public unsafe virtual Visitable visit(ReceiverParameter n, object arg)
	{
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Name name = (Name)cloneNode(n.getName(), arg);
		Type type = (Type)cloneNode(n.getType(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ReceiverParameter.___003Cclinit_003E();
		ReceiverParameter receiverParameter = new ReceiverParameter((TokenRange)n.getTokenRange().orElse(null), annotations, type, name);
		receiverParameter.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon92(receiverParameter));
		copyData(n, receiverParameter);
		return receiverParameter;
	}

	
	
	
	public unsafe virtual Visitable visit(UnparsableStmt n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		UnparsableStmt.___003Cclinit_003E();
		UnparsableStmt unparsableStmt = new UnparsableStmt((TokenRange)n.getTokenRange().orElse(null));
		unparsableStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon91(unparsableStmt));
		copyData(n, unparsableStmt);
		return unparsableStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(ModuleOpensDirective n, object arg)
	{
		NodeList moduleNames = cloneList(n.getModuleNames(), arg);
		Name name = (Name)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ModuleOpensDirective.___003Cclinit_003E();
		ModuleOpensDirective moduleOpensDirective = new ModuleOpensDirective((TokenRange)n.getTokenRange().orElse(null), name, moduleNames);
		moduleOpensDirective.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon90(moduleOpensDirective));
		copyData(n, moduleOpensDirective);
		return moduleOpensDirective;
	}

	
	
	
	public unsafe virtual Visitable visit(ModuleUsesDirective n, object arg)
	{
		Name name = (Name)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ModuleUsesDirective.___003Cclinit_003E();
		ModuleUsesDirective moduleUsesDirective = new ModuleUsesDirective((TokenRange)n.getTokenRange().orElse(null), name);
		moduleUsesDirective.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon89(moduleUsesDirective));
		copyData(n, moduleUsesDirective);
		return moduleUsesDirective;
	}

	
	
	
	public unsafe virtual Visitable visit(ModuleProvidesDirective n, object arg)
	{
		Name name = (Name)cloneNode(n.getName(), arg);
		NodeList with = cloneList(n.getWith(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ModuleProvidesDirective.___003Cclinit_003E();
		ModuleProvidesDirective moduleProvidesDirective = new ModuleProvidesDirective((TokenRange)n.getTokenRange().orElse(null), name, with);
		moduleProvidesDirective.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon88(moduleProvidesDirective));
		copyData(n, moduleProvidesDirective);
		return moduleProvidesDirective;
	}

	
	
	
	public unsafe virtual Visitable visit(ModuleExportsDirective n, object arg)
	{
		NodeList moduleNames = cloneList(n.getModuleNames(), arg);
		Name name = (Name)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ModuleExportsDirective.___003Cclinit_003E();
		ModuleExportsDirective moduleExportsDirective = new ModuleExportsDirective((TokenRange)n.getTokenRange().orElse(null), name, moduleNames);
		moduleExportsDirective.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon87(moduleExportsDirective));
		copyData(n, moduleExportsDirective);
		return moduleExportsDirective;
	}

	
	
	
	public unsafe virtual Visitable visit(ModuleRequiresDirective n, object arg)
	{
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		Name name = (Name)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ModuleRequiresDirective.___003Cclinit_003E();
		ModuleRequiresDirective moduleRequiresDirective = new ModuleRequiresDirective((TokenRange)n.getTokenRange().orElse(null), modifiers, name);
		moduleRequiresDirective.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon86(moduleRequiresDirective));
		copyData(n, moduleRequiresDirective);
		return moduleRequiresDirective;
	}

	
	
	
	public unsafe virtual Visitable visit(ModuleDeclaration n, object arg)
	{
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		NodeList directives = cloneList(n.getDirectives(), arg);
		Name name = (Name)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ModuleDeclaration.___003Cclinit_003E();
		ModuleDeclaration moduleDeclaration = new ModuleDeclaration((TokenRange)n.getTokenRange().orElse(null), annotations, name, n.isOpen(), directives);
		moduleDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon85(moduleDeclaration));
		copyData(n, moduleDeclaration);
		return moduleDeclaration;
	}

	
	
	
	public unsafe virtual Node visit(ImportDeclaration n, object arg)
	{
		Name name = (Name)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ImportDeclaration.___003Cclinit_003E();
		ImportDeclaration importDeclaration = new ImportDeclaration((TokenRange)n.getTokenRange().orElse(null), name, n.isStatic(), n.isAsterisk());
		importDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon84(importDeclaration));
		copyData(n, importDeclaration);
		return importDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(SimpleName n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		SimpleName.___003Cclinit_003E();
		SimpleName simpleName = new SimpleName((TokenRange)n.getTokenRange().orElse(null), n.getIdentifier());
		simpleName.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon50(simpleName));
		copyData(n, simpleName);
		return simpleName;
	}

	
	
	
	public unsafe virtual Visitable visit(Name n, object arg)
	{
		Name qualifier = (Name)cloneNode(n.getQualifier(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		Name.___003Cclinit_003E();
		Name name = new Name((TokenRange)n.getTokenRange().orElse(null), qualifier, n.getIdentifier());
		name.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon49(name));
		copyData(n, name);
		return name;
	}

	
	
	
	public virtual Visitable visit(NodeList n, object arg)
	{
		NodeList nodeList = new NodeList();
		Iterator iterator = n.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			Node node = (Node)((Node)obj).accept(this, arg);
			if (node != null)
			{
				nodeList.add(node);
			}
		}
		return nodeList;
	}

	
	
	
	public unsafe virtual Visitable visit(TypeExpr n, object arg)
	{
		Type type = (Type)cloneNode(n.getType(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		TypeExpr.___003Cclinit_003E();
		TypeExpr typeExpr = new TypeExpr((TokenRange)n.getTokenRange().orElse(null), type);
		typeExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon83(typeExpr));
		copyData(n, typeExpr);
		return typeExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(MethodReferenceExpr n, object arg)
	{
		Expression scope = (Expression)cloneNode(n.getScope(), arg);
		NodeList typeArguments = cloneList((NodeList)n.getTypeArguments().orElse(null), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		MethodReferenceExpr.___003Cclinit_003E();
		MethodReferenceExpr methodReferenceExpr = new MethodReferenceExpr((TokenRange)n.getTokenRange().orElse(null), scope, typeArguments, n.getIdentifier());
		methodReferenceExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon82(methodReferenceExpr));
		copyData(n, methodReferenceExpr);
		return methodReferenceExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(LambdaExpr n, object arg)
	{
		Statement body = (Statement)cloneNode(n.getBody(), arg);
		NodeList parameters = cloneList(n.getParameters(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		LambdaExpr.___003Cclinit_003E();
		LambdaExpr lambdaExpr = new LambdaExpr((TokenRange)n.getTokenRange().orElse(null), parameters, body, n.isEnclosingParameters());
		lambdaExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon81(lambdaExpr));
		copyData(n, lambdaExpr);
		return lambdaExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(CatchClause n, object arg)
	{
		BlockStmt body = (BlockStmt)cloneNode(n.getBody(), arg);
		Parameter parameter = (Parameter)cloneNode(n.getParameter(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		CatchClause.___003Cclinit_003E();
		CatchClause catchClause = new CatchClause((TokenRange)n.getTokenRange().orElse(null), parameter, body);
		catchClause.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon80(catchClause));
		copyData(n, catchClause);
		return catchClause;
	}

	
	
	
	public unsafe virtual Visitable visit(TryStmt n, object arg)
	{
		NodeList catchClauses = cloneList(n.getCatchClauses(), arg);
		BlockStmt finallyBlock = (BlockStmt)cloneNode(n.getFinallyBlock(), arg);
		NodeList resources = cloneList(n.getResources(), arg);
		BlockStmt tryBlock = (BlockStmt)cloneNode(n.getTryBlock(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		TryStmt.___003Cclinit_003E();
		TryStmt tryStmt = new TryStmt((TokenRange)n.getTokenRange().orElse(null), resources, tryBlock, catchClauses, finallyBlock);
		tryStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon79(tryStmt));
		copyData(n, tryStmt);
		return tryStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(SynchronizedStmt n, object arg)
	{
		BlockStmt body = (BlockStmt)cloneNode(n.getBody(), arg);
		Expression expression = (Expression)cloneNode(n.getExpression(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		SynchronizedStmt.___003Cclinit_003E();
		SynchronizedStmt synchronizedStmt = new SynchronizedStmt((TokenRange)n.getTokenRange().orElse(null), expression, body);
		synchronizedStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon78(synchronizedStmt));
		copyData(n, synchronizedStmt);
		return synchronizedStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(ThrowStmt n, object arg)
	{
		Expression expression = (Expression)cloneNode(n.getExpression(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ThrowStmt.___003Cclinit_003E();
		ThrowStmt throwStmt = new ThrowStmt((TokenRange)n.getTokenRange().orElse(null), expression);
		throwStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon77(throwStmt));
		copyData(n, throwStmt);
		return throwStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(ForStmt n, object arg)
	{
		Statement body = (Statement)cloneNode(n.getBody(), arg);
		Expression compare = (Expression)cloneNode(n.getCompare(), arg);
		NodeList initialization = cloneList(n.getInitialization(), arg);
		NodeList update = cloneList(n.getUpdate(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ForStmt.___003Cclinit_003E();
		ForStmt forStmt = new ForStmt((TokenRange)n.getTokenRange().orElse(null), initialization, compare, update, body);
		forStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon76(forStmt));
		copyData(n, forStmt);
		return forStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(ForEachStmt n, object arg)
	{
		Statement body = (Statement)cloneNode(n.getBody(), arg);
		Expression iterable = (Expression)cloneNode(n.getIterable(), arg);
		VariableDeclarationExpr variable = (VariableDeclarationExpr)cloneNode(n.getVariable(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ForEachStmt.___003Cclinit_003E();
		ForEachStmt forEachStmt = new ForEachStmt((TokenRange)n.getTokenRange().orElse(null), variable, iterable, body);
		forEachStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon75(forEachStmt));
		copyData(n, forEachStmt);
		return forEachStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(DoStmt n, object arg)
	{
		Statement body = (Statement)cloneNode(n.getBody(), arg);
		Expression condition = (Expression)cloneNode(n.getCondition(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		DoStmt.___003Cclinit_003E();
		DoStmt doStmt = new DoStmt((TokenRange)n.getTokenRange().orElse(null), body, condition);
		doStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon74(doStmt));
		copyData(n, doStmt);
		return doStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(ContinueStmt n, object arg)
	{
		SimpleName label = (SimpleName)cloneNode(n.getLabel(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ContinueStmt.___003Cclinit_003E();
		ContinueStmt continueStmt = new ContinueStmt((TokenRange)n.getTokenRange().orElse(null), label);
		continueStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon73(continueStmt));
		copyData(n, continueStmt);
		return continueStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(WhileStmt n, object arg)
	{
		Statement body = (Statement)cloneNode(n.getBody(), arg);
		Expression condition = (Expression)cloneNode(n.getCondition(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		WhileStmt.___003Cclinit_003E();
		WhileStmt whileStmt = new WhileStmt((TokenRange)n.getTokenRange().orElse(null), condition, body);
		whileStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon72(whileStmt));
		copyData(n, whileStmt);
		return whileStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(IfStmt n, object arg)
	{
		Expression condition = (Expression)cloneNode(n.getCondition(), arg);
		Statement elseStmt = (Statement)cloneNode(n.getElseStmt(), arg);
		Statement thenStmt = (Statement)cloneNode(n.getThenStmt(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		IfStmt.___003Cclinit_003E();
		IfStmt ifStmt = new IfStmt((TokenRange)n.getTokenRange().orElse(null), condition, thenStmt, elseStmt);
		ifStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon71(ifStmt));
		copyData(n, ifStmt);
		return ifStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(ReturnStmt n, object arg)
	{
		Expression expression = (Expression)cloneNode(n.getExpression(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ReturnStmt.___003Cclinit_003E();
		ReturnStmt returnStmt = new ReturnStmt((TokenRange)n.getTokenRange().orElse(null), expression);
		returnStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon70(returnStmt));
		copyData(n, returnStmt);
		return returnStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(BreakStmt n, object arg)
	{
		SimpleName label = (SimpleName)cloneNode(n.getLabel(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		BreakStmt.___003Cclinit_003E();
		BreakStmt breakStmt = new BreakStmt((TokenRange)n.getTokenRange().orElse(null), label);
		breakStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon69(breakStmt));
		copyData(n, breakStmt);
		return breakStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(SwitchEntry n, object arg)
	{
		NodeList labels = cloneList(n.getLabels(), arg);
		NodeList statements = cloneList(n.getStatements(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		SwitchEntry.___003Cclinit_003E();
		SwitchEntry switchEntry = new SwitchEntry((TokenRange)n.getTokenRange().orElse(null), labels, n.getType(), statements);
		switchEntry.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon68(switchEntry));
		copyData(n, switchEntry);
		return switchEntry;
	}

	
	
	
	public unsafe virtual Visitable visit(SwitchStmt n, object arg)
	{
		NodeList entries = cloneList(n.getEntries(), arg);
		Expression selector = (Expression)cloneNode(n.getSelector(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		SwitchStmt.___003Cclinit_003E();
		SwitchStmt switchStmt = new SwitchStmt((TokenRange)n.getTokenRange().orElse(null), selector, entries);
		switchStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon67(switchStmt));
		copyData(n, switchStmt);
		return switchStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(ExpressionStmt n, object arg)
	{
		Expression expression = (Expression)cloneNode(n.getExpression(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ExpressionStmt.___003Cclinit_003E();
		ExpressionStmt expressionStmt = new ExpressionStmt((TokenRange)n.getTokenRange().orElse(null), expression);
		expressionStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon66(expressionStmt));
		copyData(n, expressionStmt);
		return expressionStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(EmptyStmt n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		EmptyStmt.___003Cclinit_003E();
		EmptyStmt emptyStmt = new EmptyStmt((TokenRange)n.getTokenRange().orElse(null));
		emptyStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon65(emptyStmt));
		copyData(n, emptyStmt);
		return emptyStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(LabeledStmt n, object arg)
	{
		SimpleName label = (SimpleName)cloneNode(n.getLabel(), arg);
		Statement statement = (Statement)cloneNode(n.getStatement(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		LabeledStmt.___003Cclinit_003E();
		LabeledStmt labeledStmt = new LabeledStmt((TokenRange)n.getTokenRange().orElse(null), label, statement);
		labeledStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon64(labeledStmt));
		copyData(n, labeledStmt);
		return labeledStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(BlockStmt n, object arg)
	{
		NodeList statements = cloneList(n.getStatements(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		BlockStmt.___003Cclinit_003E();
		BlockStmt blockStmt = new BlockStmt((TokenRange)n.getTokenRange().orElse(null), statements);
		blockStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon63(blockStmt));
		copyData(n, blockStmt);
		return blockStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(AssertStmt n, object arg)
	{
		Expression check = (Expression)cloneNode(n.getCheck(), arg);
		Expression message = (Expression)cloneNode(n.getMessage(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		AssertStmt.___003Cclinit_003E();
		AssertStmt assertStmt = new AssertStmt((TokenRange)n.getTokenRange().orElse(null), check, message);
		assertStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon62(assertStmt));
		copyData(n, assertStmt);
		return assertStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(LocalRecordDeclarationStmt n, object arg)
	{
		RecordDeclaration recordDeclaration = (RecordDeclaration)cloneNode(n.getRecordDeclaration(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		LocalRecordDeclarationStmt.___003Cclinit_003E();
		LocalRecordDeclarationStmt localRecordDeclarationStmt = new LocalRecordDeclarationStmt((TokenRange)n.getTokenRange().orElse(null), recordDeclaration);
		localRecordDeclarationStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon61(localRecordDeclarationStmt));
		copyData(n, localRecordDeclarationStmt);
		return localRecordDeclarationStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(LocalClassDeclarationStmt n, object arg)
	{
		ClassOrInterfaceDeclaration classDeclaration = (ClassOrInterfaceDeclaration)cloneNode(n.getClassDeclaration(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		LocalClassDeclarationStmt.___003Cclinit_003E();
		LocalClassDeclarationStmt localClassDeclarationStmt = new LocalClassDeclarationStmt((TokenRange)n.getTokenRange().orElse(null), classDeclaration);
		localClassDeclarationStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon60(localClassDeclarationStmt));
		copyData(n, localClassDeclarationStmt);
		return localClassDeclarationStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		NodeList arguments = cloneList(n.getArguments(), arg);
		Expression expression = (Expression)cloneNode(n.getExpression(), arg);
		NodeList typeArguments = cloneList((NodeList)n.getTypeArguments().orElse(null), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ExplicitConstructorInvocationStmt.___003Cclinit_003E();
		ExplicitConstructorInvocationStmt explicitConstructorInvocationStmt = new ExplicitConstructorInvocationStmt((TokenRange)n.getTokenRange().orElse(null), typeArguments, n.isThis(), expression, arguments);
		explicitConstructorInvocationStmt.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon59(explicitConstructorInvocationStmt));
		copyData(n, explicitConstructorInvocationStmt);
		return explicitConstructorInvocationStmt;
	}

	
	
	
	public unsafe virtual Visitable visit(MemberValuePair n, object arg)
	{
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		Expression value = (Expression)cloneNode(n.getValue(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		MemberValuePair.___003Cclinit_003E();
		MemberValuePair memberValuePair = new MemberValuePair((TokenRange)n.getTokenRange().orElse(null), name, value);
		memberValuePair.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon58(memberValuePair));
		copyData(n, memberValuePair);
		return memberValuePair;
	}

	
	
	
	public unsafe virtual Visitable visit(NormalAnnotationExpr n, object arg)
	{
		NodeList pairs = cloneList(n.getPairs(), arg);
		Name name = (Name)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		NormalAnnotationExpr.___003Cclinit_003E();
		NormalAnnotationExpr normalAnnotationExpr = new NormalAnnotationExpr((TokenRange)n.getTokenRange().orElse(null), name, pairs);
		normalAnnotationExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon57(normalAnnotationExpr));
		copyData(n, normalAnnotationExpr);
		return normalAnnotationExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(SingleMemberAnnotationExpr n, object arg)
	{
		Expression memberValue = (Expression)cloneNode(n.getMemberValue(), arg);
		Name name = (Name)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		SingleMemberAnnotationExpr.___003Cclinit_003E();
		SingleMemberAnnotationExpr singleMemberAnnotationExpr = new SingleMemberAnnotationExpr((TokenRange)n.getTokenRange().orElse(null), name, memberValue);
		singleMemberAnnotationExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon56(singleMemberAnnotationExpr));
		copyData(n, singleMemberAnnotationExpr);
		return singleMemberAnnotationExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(MarkerAnnotationExpr n, object arg)
	{
		Name name = (Name)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		MarkerAnnotationExpr.___003Cclinit_003E();
		MarkerAnnotationExpr markerAnnotationExpr = new MarkerAnnotationExpr((TokenRange)n.getTokenRange().orElse(null), name);
		markerAnnotationExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon55(markerAnnotationExpr));
		copyData(n, markerAnnotationExpr);
		return markerAnnotationExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(VariableDeclarationExpr n, object arg)
	{
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		NodeList variables = cloneList(n.getVariables(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		VariableDeclarationExpr.___003Cclinit_003E();
		VariableDeclarationExpr variableDeclarationExpr = new VariableDeclarationExpr((TokenRange)n.getTokenRange().orElse(null), modifiers, annotations, variables);
		variableDeclarationExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon54(variableDeclarationExpr));
		copyData(n, variableDeclarationExpr);
		return variableDeclarationExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(UnaryExpr n, object arg)
	{
		Expression expression = (Expression)cloneNode(n.getExpression(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		UnaryExpr.___003Cclinit_003E();
		UnaryExpr unaryExpr = new UnaryExpr((TokenRange)n.getTokenRange().orElse(null), expression, n.getOperator());
		unaryExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon53(unaryExpr));
		copyData(n, unaryExpr);
		return unaryExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(SuperExpr n, object arg)
	{
		Name typeName = (Name)cloneNode(n.getTypeName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		SuperExpr.___003Cclinit_003E();
		SuperExpr superExpr = new SuperExpr((TokenRange)n.getTokenRange().orElse(null), typeName);
		superExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon52(superExpr));
		copyData(n, superExpr);
		return superExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(ThisExpr n, object arg)
	{
		Name typeName = (Name)cloneNode(n.getTypeName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ThisExpr.___003Cclinit_003E();
		ThisExpr thisExpr = new ThisExpr((TokenRange)n.getTokenRange().orElse(null), typeName);
		thisExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon51(thisExpr));
		copyData(n, thisExpr);
		return thisExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(ObjectCreationExpr n, object arg)
	{
		NodeList anonymousClassBody = cloneList((NodeList)n.getAnonymousClassBody().orElse(null), arg);
		NodeList arguments = cloneList(n.getArguments(), arg);
		Expression scope = (Expression)cloneNode(n.getScope(), arg);
		ClassOrInterfaceType type = (ClassOrInterfaceType)cloneNode(n.getType(), arg);
		NodeList typeArguments = cloneList((NodeList)n.getTypeArguments().orElse(null), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ObjectCreationExpr.___003Cclinit_003E();
		ObjectCreationExpr objectCreationExpr = new ObjectCreationExpr((TokenRange)n.getTokenRange().orElse(null), scope, type, typeArguments, arguments, anonymousClassBody);
		objectCreationExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon48(objectCreationExpr));
		copyData(n, objectCreationExpr);
		return objectCreationExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(NameExpr n, object arg)
	{
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		NameExpr.___003Cclinit_003E();
		NameExpr nameExpr = new NameExpr((TokenRange)n.getTokenRange().orElse(null), name);
		nameExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon47(nameExpr));
		copyData(n, nameExpr);
		return nameExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(MethodCallExpr n, object arg)
	{
		NodeList arguments = cloneList(n.getArguments(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		Expression scope = (Expression)cloneNode(n.getScope(), arg);
		NodeList typeArguments = cloneList((NodeList)n.getTypeArguments().orElse(null), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		MethodCallExpr.___003Cclinit_003E();
		MethodCallExpr methodCallExpr = new MethodCallExpr((TokenRange)n.getTokenRange().orElse(null), scope, typeArguments, name, arguments);
		methodCallExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon46(methodCallExpr));
		copyData(n, methodCallExpr);
		return methodCallExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(NullLiteralExpr n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		NullLiteralExpr.___003Cclinit_003E();
		NullLiteralExpr nullLiteralExpr = new NullLiteralExpr((TokenRange)n.getTokenRange().orElse(null));
		nullLiteralExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon45(nullLiteralExpr));
		copyData(n, nullLiteralExpr);
		return nullLiteralExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(BooleanLiteralExpr n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		BooleanLiteralExpr.___003Cclinit_003E();
		BooleanLiteralExpr booleanLiteralExpr = new BooleanLiteralExpr((TokenRange)n.getTokenRange().orElse(null), n.isValue());
		booleanLiteralExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon44(booleanLiteralExpr));
		copyData(n, booleanLiteralExpr);
		return booleanLiteralExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(DoubleLiteralExpr n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		DoubleLiteralExpr.___003Cclinit_003E();
		DoubleLiteralExpr doubleLiteralExpr = new DoubleLiteralExpr((TokenRange)n.getTokenRange().orElse(null), n.getValue());
		doubleLiteralExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon43(doubleLiteralExpr));
		copyData(n, doubleLiteralExpr);
		return doubleLiteralExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(CharLiteralExpr n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		CharLiteralExpr.___003Cclinit_003E();
		CharLiteralExpr charLiteralExpr = new CharLiteralExpr((TokenRange)n.getTokenRange().orElse(null), n.getValue());
		charLiteralExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon42(charLiteralExpr));
		copyData(n, charLiteralExpr);
		return charLiteralExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(LongLiteralExpr n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		LongLiteralExpr.___003Cclinit_003E();
		LongLiteralExpr longLiteralExpr = new LongLiteralExpr((TokenRange)n.getTokenRange().orElse(null), n.getValue());
		longLiteralExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon41(longLiteralExpr));
		copyData(n, longLiteralExpr);
		return longLiteralExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(IntegerLiteralExpr n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		IntegerLiteralExpr.___003Cclinit_003E();
		IntegerLiteralExpr integerLiteralExpr = new IntegerLiteralExpr((TokenRange)n.getTokenRange().orElse(null), n.getValue());
		integerLiteralExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon40(integerLiteralExpr));
		copyData(n, integerLiteralExpr);
		return integerLiteralExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(StringLiteralExpr n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		StringLiteralExpr.___003Cclinit_003E();
		StringLiteralExpr stringLiteralExpr = new StringLiteralExpr((TokenRange)n.getTokenRange().orElse(null), n.getValue());
		stringLiteralExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon39(stringLiteralExpr));
		copyData(n, stringLiteralExpr);
		return stringLiteralExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(InstanceOfExpr n, object arg)
	{
		Expression expression = (Expression)cloneNode(n.getExpression(), arg);
		PatternExpr pattern = (PatternExpr)cloneNode(n.getPattern(), arg);
		ReferenceType type = (ReferenceType)cloneNode(n.getType(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		InstanceOfExpr.___003Cclinit_003E();
		InstanceOfExpr instanceOfExpr = new InstanceOfExpr((TokenRange)n.getTokenRange().orElse(null), expression, type, pattern);
		instanceOfExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon38(instanceOfExpr));
		copyData(n, instanceOfExpr);
		return instanceOfExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(FieldAccessExpr n, object arg)
	{
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		Expression scope = (Expression)cloneNode(n.getScope(), arg);
		NodeList typeArguments = cloneList((NodeList)n.getTypeArguments().orElse(null), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		FieldAccessExpr.___003Cclinit_003E();
		FieldAccessExpr fieldAccessExpr = new FieldAccessExpr((TokenRange)n.getTokenRange().orElse(null), scope, typeArguments, name);
		fieldAccessExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon37(fieldAccessExpr));
		copyData(n, fieldAccessExpr);
		return fieldAccessExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(EnclosedExpr n, object arg)
	{
		Expression inner = (Expression)cloneNode(n.getInner(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		EnclosedExpr.___003Cclinit_003E();
		EnclosedExpr enclosedExpr = new EnclosedExpr((TokenRange)n.getTokenRange().orElse(null), inner);
		enclosedExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon36(enclosedExpr));
		copyData(n, enclosedExpr);
		return enclosedExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(ConditionalExpr n, object arg)
	{
		Expression condition = (Expression)cloneNode(n.getCondition(), arg);
		Expression elseExpr = (Expression)cloneNode(n.getElseExpr(), arg);
		Expression thenExpr = (Expression)cloneNode(n.getThenExpr(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ConditionalExpr.___003Cclinit_003E();
		ConditionalExpr conditionalExpr = new ConditionalExpr((TokenRange)n.getTokenRange().orElse(null), condition, thenExpr, elseExpr);
		conditionalExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon35(conditionalExpr));
		copyData(n, conditionalExpr);
		return conditionalExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(ClassExpr n, object arg)
	{
		Type type = (Type)cloneNode(n.getType(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ClassExpr.___003Cclinit_003E();
		ClassExpr classExpr = new ClassExpr((TokenRange)n.getTokenRange().orElse(null), type);
		classExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon34(classExpr));
		copyData(n, classExpr);
		return classExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(CastExpr n, object arg)
	{
		Expression expression = (Expression)cloneNode(n.getExpression(), arg);
		Type type = (Type)cloneNode(n.getType(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		CastExpr.___003Cclinit_003E();
		CastExpr castExpr = new CastExpr((TokenRange)n.getTokenRange().orElse(null), type, expression);
		castExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon33(castExpr));
		copyData(n, castExpr);
		return castExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(BinaryExpr n, object arg)
	{
		Expression left = (Expression)cloneNode(n.getLeft(), arg);
		Expression right = (Expression)cloneNode(n.getRight(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		BinaryExpr.___003Cclinit_003E();
		BinaryExpr binaryExpr = new BinaryExpr((TokenRange)n.getTokenRange().orElse(null), left, right, n.getOperator());
		binaryExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon32(binaryExpr));
		copyData(n, binaryExpr);
		return binaryExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(AssignExpr n, object arg)
	{
		Expression target = (Expression)cloneNode(n.getTarget(), arg);
		Expression value = (Expression)cloneNode(n.getValue(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		AssignExpr.___003Cclinit_003E();
		AssignExpr assignExpr = new AssignExpr((TokenRange)n.getTokenRange().orElse(null), target, value, n.getOperator());
		assignExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon31(assignExpr));
		copyData(n, assignExpr);
		return assignExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(ArrayInitializerExpr n, object arg)
	{
		NodeList values = cloneList(n.getValues(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ArrayInitializerExpr.___003Cclinit_003E();
		ArrayInitializerExpr arrayInitializerExpr = new ArrayInitializerExpr((TokenRange)n.getTokenRange().orElse(null), values);
		arrayInitializerExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon30(arrayInitializerExpr));
		copyData(n, arrayInitializerExpr);
		return arrayInitializerExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(ArrayCreationExpr n, object arg)
	{
		Type elementType = (Type)cloneNode(n.getElementType(), arg);
		ArrayInitializerExpr initializer = (ArrayInitializerExpr)cloneNode(n.getInitializer(), arg);
		NodeList levels = cloneList(n.getLevels(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ArrayCreationExpr.___003Cclinit_003E();
		ArrayCreationExpr arrayCreationExpr = new ArrayCreationExpr((TokenRange)n.getTokenRange().orElse(null), elementType, levels, initializer);
		arrayCreationExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon29(arrayCreationExpr));
		copyData(n, arrayCreationExpr);
		return arrayCreationExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(ArrayAccessExpr n, object arg)
	{
		Expression index = (Expression)cloneNode(n.getIndex(), arg);
		Expression name = (Expression)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ArrayAccessExpr.___003Cclinit_003E();
		ArrayAccessExpr arrayAccessExpr = new ArrayAccessExpr((TokenRange)n.getTokenRange().orElse(null), name, index);
		arrayAccessExpr.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon28(arrayAccessExpr));
		copyData(n, arrayAccessExpr);
		return arrayAccessExpr;
	}

	
	
	
	public unsafe virtual Visitable visit(UnknownType n, object arg)
	{
		cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		UnknownType.___003Cclinit_003E();
		UnknownType unknownType = new UnknownType((TokenRange)n.getTokenRange().orElse(null));
		unknownType.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon27(unknownType));
		copyData(n, unknownType);
		return unknownType;
	}

	
	
	
	public unsafe virtual Visitable visit(WildcardType n, object arg)
	{
		ReferenceType extendedType = (ReferenceType)cloneNode(n.getExtendedType(), arg);
		ReferenceType superType = (ReferenceType)cloneNode(n.getSuperType(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		WildcardType.___003Cclinit_003E();
		WildcardType wildcardType = new WildcardType((TokenRange)n.getTokenRange().orElse(null), extendedType, superType, annotations);
		wildcardType.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon26(wildcardType));
		copyData(n, wildcardType);
		return wildcardType;
	}

	
	
	
	public unsafe virtual Visitable visit(VoidType n, object arg)
	{
		cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		VoidType.___003Cclinit_003E();
		VoidType voidType = new VoidType((TokenRange)n.getTokenRange().orElse(null));
		voidType.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon25(voidType));
		copyData(n, voidType);
		return voidType;
	}

	
	
	
	public unsafe virtual Visitable visit(UnionType n, object arg)
	{
		NodeList elements = cloneList(n.getElements(), arg);
		cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		UnionType.___003Cclinit_003E();
		UnionType unionType = new UnionType((TokenRange)n.getTokenRange().orElse(null), elements);
		unionType.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon24(unionType));
		copyData(n, unionType);
		return unionType;
	}

	
	
	
	public unsafe virtual Visitable visit(IntersectionType n, object arg)
	{
		NodeList elements = cloneList(n.getElements(), arg);
		cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		IntersectionType.___003Cclinit_003E();
		IntersectionType intersectionType = new IntersectionType((TokenRange)n.getTokenRange().orElse(null), elements);
		intersectionType.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon23(intersectionType));
		copyData(n, intersectionType);
		return intersectionType;
	}

	
	
	
	public unsafe virtual Visitable visit(ArrayCreationLevel n, object arg)
	{
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Expression dimension = (Expression)cloneNode(n.getDimension(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ArrayCreationLevel.___003Cclinit_003E();
		ArrayCreationLevel arrayCreationLevel = new ArrayCreationLevel((TokenRange)n.getTokenRange().orElse(null), dimension, annotations);
		arrayCreationLevel.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon22(arrayCreationLevel));
		copyData(n, arrayCreationLevel);
		return arrayCreationLevel;
	}

	
	
	
	public unsafe virtual Visitable visit(ArrayType n, object arg)
	{
		Type componentType = (Type)cloneNode(n.getComponentType(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ArrayType.___003Cclinit_003E();
		ArrayType arrayType = new ArrayType((TokenRange)n.getTokenRange().orElse(null), componentType, n.getOrigin(), annotations);
		arrayType.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon21(arrayType));
		copyData(n, arrayType);
		return arrayType;
	}

	
	
	
	public unsafe virtual Visitable visit(PrimitiveType n, object arg)
	{
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		PrimitiveType.___003Cclinit_003E();
		PrimitiveType primitiveType = new PrimitiveType((TokenRange)n.getTokenRange().orElse(null), n.getType(), annotations);
		primitiveType.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon20(primitiveType));
		copyData(n, primitiveType);
		return primitiveType;
	}

	
	
	
	public unsafe virtual Visitable visit(ClassOrInterfaceType n, object arg)
	{
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		ClassOrInterfaceType scope = (ClassOrInterfaceType)cloneNode(n.getScope(), arg);
		NodeList typeArguments = cloneList((NodeList)n.getTypeArguments().orElse(null), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ClassOrInterfaceType.___003Cclinit_003E();
		ClassOrInterfaceType classOrInterfaceType = new ClassOrInterfaceType((TokenRange)n.getTokenRange().orElse(null), scope, name, typeArguments, annotations);
		classOrInterfaceType.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon19(classOrInterfaceType));
		copyData(n, classOrInterfaceType);
		return classOrInterfaceType;
	}

	
	
	
	public unsafe virtual Visitable visit(JavadocComment n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		JavadocComment.___003Cclinit_003E();
		JavadocComment javadocComment = new JavadocComment((TokenRange)n.getTokenRange().orElse(null), n.getContent());
		javadocComment.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon18(javadocComment));
		copyData(n, javadocComment);
		return javadocComment;
	}

	
	
	
	public unsafe virtual Visitable visit(InitializerDeclaration n, object arg)
	{
		BlockStmt body = (BlockStmt)cloneNode(n.getBody(), arg);
		cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		InitializerDeclaration.___003Cclinit_003E();
		InitializerDeclaration initializerDeclaration = new InitializerDeclaration((TokenRange)n.getTokenRange().orElse(null), n.isStatic(), body);
		initializerDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon17(initializerDeclaration));
		copyData(n, initializerDeclaration);
		return initializerDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(Parameter n, object arg)
	{
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		Type type = (Type)cloneNode(n.getType(), arg);
		NodeList varArgsAnnotations = cloneList(n.getVarArgsAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		Parameter.___003Cclinit_003E();
		Parameter parameter = new Parameter((TokenRange)n.getTokenRange().orElse(null), modifiers, annotations, type, n.isVarArgs(), varArgsAnnotations, name);
		parameter.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon16(parameter));
		copyData(n, parameter);
		return parameter;
	}

	
	
	
	public unsafe virtual Visitable visit(MethodDeclaration n, object arg)
	{
		BlockStmt body = (BlockStmt)cloneNode(n.getBody(), arg);
		Type type = (Type)cloneNode(n.getType(), arg);
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		NodeList parameters = cloneList(n.getParameters(), arg);
		ReceiverParameter receiverParameter = (ReceiverParameter)cloneNode(n.getReceiverParameter(), arg);
		NodeList thrownExceptions = cloneList(n.getThrownExceptions(), arg);
		NodeList typeParameters = cloneList(n.getTypeParameters(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		MethodDeclaration.___003Cclinit_003E();
		MethodDeclaration methodDeclaration = new MethodDeclaration((TokenRange)n.getTokenRange().orElse(null), modifiers, annotations, typeParameters, type, name, parameters, thrownExceptions, body, receiverParameter);
		methodDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon15(methodDeclaration));
		copyData(n, methodDeclaration);
		return methodDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(ConstructorDeclaration n, object arg)
	{
		BlockStmt body = (BlockStmt)cloneNode(n.getBody(), arg);
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		NodeList parameters = cloneList(n.getParameters(), arg);
		ReceiverParameter receiverParameter = (ReceiverParameter)cloneNode(n.getReceiverParameter(), arg);
		NodeList thrownExceptions = cloneList(n.getThrownExceptions(), arg);
		NodeList typeParameters = cloneList(n.getTypeParameters(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ConstructorDeclaration.___003Cclinit_003E();
		ConstructorDeclaration constructorDeclaration = new ConstructorDeclaration((TokenRange)n.getTokenRange().orElse(null), modifiers, annotations, typeParameters, name, parameters, thrownExceptions, body, receiverParameter);
		constructorDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon14(constructorDeclaration));
		copyData(n, constructorDeclaration);
		return constructorDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(VariableDeclarator n, object arg)
	{
		Expression initializer = (Expression)cloneNode(n.getInitializer(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		Type type = (Type)cloneNode(n.getType(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		VariableDeclarator.___003Cclinit_003E();
		VariableDeclarator variableDeclarator = new VariableDeclarator((TokenRange)n.getTokenRange().orElse(null), type, name, initializer);
		variableDeclarator.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon13(variableDeclarator));
		copyData(n, variableDeclarator);
		return variableDeclarator;
	}

	
	
	
	public unsafe virtual Visitable visit(FieldDeclaration n, object arg)
	{
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		NodeList variables = cloneList(n.getVariables(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		FieldDeclaration.___003Cclinit_003E();
		FieldDeclaration fieldDeclaration = new FieldDeclaration((TokenRange)n.getTokenRange().orElse(null), modifiers, annotations, variables);
		fieldDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon12(fieldDeclaration));
		copyData(n, fieldDeclaration);
		return fieldDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(AnnotationMemberDeclaration n, object arg)
	{
		Expression defaultValue = (Expression)cloneNode(n.getDefaultValue(), arg);
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		Type type = (Type)cloneNode(n.getType(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		AnnotationMemberDeclaration.___003Cclinit_003E();
		AnnotationMemberDeclaration annotationMemberDeclaration = new AnnotationMemberDeclaration((TokenRange)n.getTokenRange().orElse(null), modifiers, annotations, type, name, defaultValue);
		annotationMemberDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon11(annotationMemberDeclaration));
		copyData(n, annotationMemberDeclaration);
		return annotationMemberDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(AnnotationDeclaration n, object arg)
	{
		NodeList members = cloneList(n.getMembers(), arg);
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		AnnotationDeclaration.___003Cclinit_003E();
		AnnotationDeclaration annotationDeclaration = new AnnotationDeclaration((TokenRange)n.getTokenRange().orElse(null), modifiers, annotations, name, members);
		annotationDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon10(annotationDeclaration));
		copyData(n, annotationDeclaration);
		return annotationDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(EnumConstantDeclaration n, object arg)
	{
		NodeList arguments = cloneList(n.getArguments(), arg);
		NodeList classBody = cloneList(n.getClassBody(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		EnumConstantDeclaration.___003Cclinit_003E();
		EnumConstantDeclaration enumConstantDeclaration = new EnumConstantDeclaration((TokenRange)n.getTokenRange().orElse(null), annotations, name, arguments, classBody);
		enumConstantDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon9(enumConstantDeclaration));
		copyData(n, enumConstantDeclaration);
		return enumConstantDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(EnumDeclaration n, object arg)
	{
		NodeList entries = cloneList(n.getEntries(), arg);
		NodeList implementedTypes = cloneList(n.getImplementedTypes(), arg);
		NodeList members = cloneList(n.getMembers(), arg);
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		EnumDeclaration.___003Cclinit_003E();
		EnumDeclaration enumDeclaration = new EnumDeclaration((TokenRange)n.getTokenRange().orElse(null), modifiers, annotations, name, implementedTypes, entries, members);
		enumDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon8(enumDeclaration));
		copyData(n, enumDeclaration);
		return enumDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(CompactConstructorDeclaration n, object arg)
	{
		BlockStmt body = (BlockStmt)cloneNode(n.getBody(), arg);
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		NodeList thrownExceptions = cloneList(n.getThrownExceptions(), arg);
		NodeList typeParameters = cloneList(n.getTypeParameters(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		CompactConstructorDeclaration.___003Cclinit_003E();
		CompactConstructorDeclaration compactConstructorDeclaration = new CompactConstructorDeclaration((TokenRange)n.getTokenRange().orElse(null), modifiers, annotations, typeParameters, name, thrownExceptions, body);
		compactConstructorDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon100(compactConstructorDeclaration));
		copyData(n, compactConstructorDeclaration);
		return compactConstructorDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(RecordDeclaration n, object arg)
	{
		NodeList implementedTypes = cloneList(n.getImplementedTypes(), arg);
		NodeList parameters = cloneList(n.getParameters(), arg);
		ReceiverParameter receiverParameter = (ReceiverParameter)cloneNode(n.getReceiverParameter(), arg);
		NodeList typeParameters = cloneList(n.getTypeParameters(), arg);
		NodeList members = cloneList(n.getMembers(), arg);
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		RecordDeclaration.___003Cclinit_003E();
		RecordDeclaration recordDeclaration = new RecordDeclaration((TokenRange)n.getTokenRange().orElse(null), modifiers, annotations, name, parameters, typeParameters, implementedTypes, members, receiverParameter);
		recordDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon99(recordDeclaration));
		copyData(n, recordDeclaration);
		return recordDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(ClassOrInterfaceDeclaration n, object arg)
	{
		NodeList extendedTypes = cloneList(n.getExtendedTypes(), arg);
		NodeList implementedTypes = cloneList(n.getImplementedTypes(), arg);
		NodeList typeParameters = cloneList(n.getTypeParameters(), arg);
		NodeList members = cloneList(n.getMembers(), arg);
		NodeList modifiers = cloneList(n.getModifiers(), arg);
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		ClassOrInterfaceDeclaration.___003Cclinit_003E();
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = new ClassOrInterfaceDeclaration((TokenRange)n.getTokenRange().orElse(null), modifiers, annotations, n.isInterface(), name, typeParameters, extendedTypes, implementedTypes, members);
		classOrInterfaceDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon7(classOrInterfaceDeclaration));
		copyData(n, classOrInterfaceDeclaration);
		return classOrInterfaceDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(BlockComment n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		BlockComment.___003Cclinit_003E();
		BlockComment blockComment = new BlockComment((TokenRange)n.getTokenRange().orElse(null), n.getContent());
		blockComment.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon6(blockComment));
		copyData(n, blockComment);
		return blockComment;
	}

	
	
	
	public unsafe virtual Visitable visit(LineComment n, object arg)
	{
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		LineComment.___003Cclinit_003E();
		LineComment lineComment = new LineComment((TokenRange)n.getTokenRange().orElse(null), n.getContent());
		lineComment.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon5(lineComment));
		copyData(n, lineComment);
		return lineComment;
	}

	
	
	
	public unsafe virtual Visitable visit(TypeParameter n, object arg)
	{
		SimpleName name = (SimpleName)cloneNode(n.getName(), arg);
		NodeList typeBound = cloneList(n.getTypeBound(), arg);
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		TypeParameter.___003Cclinit_003E();
		TypeParameter typeParameter = new TypeParameter((TokenRange)n.getTokenRange().orElse(null), name, typeBound, annotations);
		typeParameter.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon4(typeParameter));
		copyData(n, typeParameter);
		return typeParameter;
	}

	
	
	
	public unsafe virtual Visitable visit(PackageDeclaration n, object arg)
	{
		NodeList annotations = cloneList(n.getAnnotations(), arg);
		Name name = (Name)cloneNode(n.getName(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		PackageDeclaration.___003Cclinit_003E();
		PackageDeclaration packageDeclaration = new PackageDeclaration((TokenRange)n.getTokenRange().orElse(null), annotations, name);
		packageDeclaration.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon3(packageDeclaration));
		copyData(n, packageDeclaration);
		return packageDeclaration;
	}

	
	
	
	public unsafe virtual Visitable visit(CompilationUnit n, object arg)
	{
		NodeList imports = cloneList(n.getImports(), arg);
		ModuleDeclaration module = (ModuleDeclaration)cloneNode(n.getModule(), arg);
		PackageDeclaration packageDeclaration = (PackageDeclaration)cloneNode(n.getPackageDeclaration(), arg);
		NodeList types = cloneList(n.getTypes(), arg);
		Comment comment = (Comment)cloneNode(n.getComment(), arg);
		CompilationUnit.___003Cclinit_003E();
		CompilationUnit compilationUnit = new CompilationUnit((TokenRange)n.getTokenRange().orElse(null), packageDeclaration, imports, types, module);
		n.getStorage().ifPresent(new ___003C_003EAnon0(compilationUnit));
		compilationUnit.setComment(comment);
		Stream stream = n.getOrphanComments().stream().map(new ___003C_003EAnon1());
		
		stream.forEach(new ___003C_003EAnon2(compilationUnit));
		copyData(n, compilationUnit);
		return compilationUnit;
	}

	
	
	
	
	private static void lambda_0024visit_00240(CompilationUnit r, CompilationUnit.Storage s)
	{
		r.setStorage(s.getPath(), s.getEncoding());
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(PatternExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(TextBlockLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(YieldStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SwitchExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(Modifier n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(VarType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ReceiverParameter n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(UnparsableStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleOpensDirective n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleUsesDirective n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleProvidesDirective n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleExportsDirective n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleRequiresDirective n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ImportDeclaration n, object arg)
	{
		Node result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SimpleName n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(Name n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(NodeList n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(TypeExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(MethodReferenceExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LambdaExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(CatchClause n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(TryStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SynchronizedStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ThrowStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ForStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ForEachStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(DoStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ContinueStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(WhileStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(IfStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ReturnStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(BreakStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SwitchEntry n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SwitchStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ExpressionStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(EmptyStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LabeledStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(BlockStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(AssertStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LocalRecordDeclarationStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LocalClassDeclarationStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ExplicitConstructorInvocationStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(MemberValuePair n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(NormalAnnotationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SingleMemberAnnotationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(MarkerAnnotationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(VariableDeclarationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(UnaryExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SuperExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ThisExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ObjectCreationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(NameExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(MethodCallExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(NullLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(BooleanLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(DoubleLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(CharLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LongLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(IntegerLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(StringLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(InstanceOfExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(FieldAccessExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(EnclosedExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ConditionalExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ClassExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(CastExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(BinaryExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(AssignExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ArrayInitializerExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ArrayCreationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ArrayAccessExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(UnknownType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(WildcardType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(VoidType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(UnionType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(IntersectionType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ArrayCreationLevel n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ArrayType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(PrimitiveType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ClassOrInterfaceType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(JavadocComment n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(InitializerDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(Parameter n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(MethodDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ConstructorDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(VariableDeclarator n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(FieldDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(AnnotationMemberDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(AnnotationDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(EnumConstantDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(EnumDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(CompactConstructorDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(RecordDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ClassOrInterfaceDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(BlockComment n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LineComment n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(TypeParameter n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(PackageDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(CompilationUnit n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	object GenericVisitor_003A_003Avisit(CompilationUnit P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(PackageDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(TypeParameter P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(LineComment P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(BlockComment P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ClassOrInterfaceDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(RecordDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(CompactConstructorDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(EnumDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(EnumConstantDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(AnnotationDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(AnnotationMemberDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(FieldDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(VariableDeclarator P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ConstructorDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(MethodDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(Parameter P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(InitializerDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(JavadocComment P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ClassOrInterfaceType P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(PrimitiveType P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ArrayType P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ArrayCreationLevel P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(IntersectionType P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(UnionType P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(VoidType P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(WildcardType P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(UnknownType P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ArrayAccessExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ArrayCreationExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ArrayInitializerExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(AssignExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(BinaryExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(CastExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ClassExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ConditionalExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(EnclosedExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(FieldAccessExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(InstanceOfExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(StringLiteralExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(IntegerLiteralExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(LongLiteralExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(CharLiteralExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(DoubleLiteralExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(BooleanLiteralExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(NullLiteralExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(MethodCallExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(NameExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ObjectCreationExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ThisExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(SuperExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(UnaryExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(VariableDeclarationExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(MarkerAnnotationExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(SingleMemberAnnotationExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(NormalAnnotationExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(MemberValuePair P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ExplicitConstructorInvocationStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(LocalClassDeclarationStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(LocalRecordDeclarationStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(AssertStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(BlockStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(LabeledStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(EmptyStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ExpressionStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(SwitchStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(SwitchEntry P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(BreakStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ReturnStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(IfStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(WhileStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ContinueStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(DoStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ForEachStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ForStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ThrowStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(SynchronizedStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(TryStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(CatchClause P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(LambdaExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(MethodReferenceExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(TypeExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(NodeList P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(Name P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(SimpleName P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ImportDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ModuleDeclaration P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ModuleRequiresDirective P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ModuleExportsDirective P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ModuleProvidesDirective P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ModuleUsesDirective P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ModuleOpensDirective P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(UnparsableStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(ReceiverParameter P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(VarType P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(Modifier P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(SwitchExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(YieldStmt P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(TextBlockLiteralExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}

	object GenericVisitor_003A_003Avisit(PatternExpr P_0, object P_1)
	{
		return _003Cbridge_003Evisit(P_0, P_1);
	}
}
