using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.visitor;

public class ModifierVisitor: GenericVisitor
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon0(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_00240(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon1(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Expression result = arg_00241.lambda_0024visit_00241(arg_00242, (Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon2(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_00242(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon3(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_00243(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon4(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ArrayInitializerExpr result = arg_00241.lambda_0024visit_00244(arg_00242, (ArrayInitializerExpr)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon5(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_00245(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon6(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_00246(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon7 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon7(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Expression result = arg_00241.lambda_0024visit_00247(arg_00242, (Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon8 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon8(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_00248(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon9 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon9(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_00249(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon10 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon10(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002410(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon11 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon11(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002411(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon12 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon12(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002412(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon13 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon13(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			SimpleName result = arg_00241.lambda_0024visit_002413(arg_00242, (SimpleName)P_0);
			
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

	
	private sealed class ___003C_003EAnon14 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon14(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002414(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon15 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon15(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002415(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon16 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon16(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002416(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon17 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon17(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002417(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon18 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon18(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002418(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon19 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon19(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002419(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon20 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon20(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ReceiverParameter result = arg_00241.lambda_0024visit_002420(arg_00242, (ReceiverParameter)P_0);
			
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

	
	private sealed class ___003C_003EAnon21 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon21(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002421(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon22 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon22(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ClassOrInterfaceType result = arg_00241.lambda_0024visit_002422(arg_00242, (ClassOrInterfaceType)P_0);
			
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

	
	private sealed class ___003C_003EAnon23 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon23(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002423(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon24 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon24(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ModuleDeclaration result = arg_00241.lambda_0024visit_002424(arg_00242, (ModuleDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon25 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon25(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			PackageDeclaration result = arg_00241.lambda_0024visit_002425(arg_00242, (PackageDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon26 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon26(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002426(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon27 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon27(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002427(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon28 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon28(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ReceiverParameter result = arg_00241.lambda_0024visit_002428(arg_00242, (ReceiverParameter)P_0);
			
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

	
	private sealed class ___003C_003EAnon29 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon29(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002429(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon30 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon30(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002430(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon31 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon31(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			SimpleName result = arg_00241.lambda_0024visit_002431(arg_00242, (SimpleName)P_0);
			
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

	
	private sealed class ___003C_003EAnon32 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon32(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002432(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon33 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon33(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002433(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon34 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon34(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002434(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon35 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon35(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002435(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon36 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon36(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002436(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon37 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon37(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002437(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon38 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon38(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002438(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon39 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon39(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Expression result = arg_00241.lambda_0024visit_002439(arg_00242, (Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon40 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon40(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002440(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon41 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon41(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002441(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon42 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon42(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002442(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon43 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon43(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002443(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon44 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon44(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002444(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon45 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon45(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Expression result = arg_00241.lambda_0024visit_002445(arg_00242, (Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon46 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon46(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002446(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon47 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon47(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Statement result = arg_00241.lambda_0024visit_002447(arg_00242, (Statement)P_0);
			
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

	
	private sealed class ___003C_003EAnon48 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon48(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002448(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon49 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon49(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002449(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon50 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon50(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			PatternExpr result = arg_00241.lambda_0024visit_002450(arg_00242, (PatternExpr)P_0);
			
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

	
	private sealed class ___003C_003EAnon51 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon51(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002451(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon52 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon52(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002452(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon53 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon53(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002453(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon54 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon54(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002454(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon55 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon55(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002455(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon56 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon56(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002456(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon57 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon57(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002457(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon58 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon58(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Expression result = arg_00241.lambda_0024visit_002458(arg_00242, (Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon59 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon59(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002459(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon60 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon60(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			BlockStmt result = arg_00241.lambda_0024visit_002460(arg_00242, (BlockStmt)P_0);
			
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

	
	private sealed class ___003C_003EAnon61 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon61(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ReceiverParameter result = arg_00241.lambda_0024visit_002461(arg_00242, (ReceiverParameter)P_0);
			
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

	
	private sealed class ___003C_003EAnon62 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon62(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002462(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon63 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon63(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002463(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon64 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon64(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002464(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon65 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon65(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002465(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon66 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon66(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Expression result = arg_00241.lambda_0024visit_002466(arg_00242, (Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon67 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon67(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002467(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon68 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon68(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002468(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon69 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon69(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002469(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon70 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon70(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Name result = arg_00241.lambda_0024visit_002470(arg_00242, (Name)P_0);
			
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

	
	private sealed class ___003C_003EAnon71 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon71(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002471(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon72 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon72(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002472(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon73 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon73(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002473(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon74 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon74(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002474(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon75 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon75(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Expression result = arg_00241.lambda_0024visit_002475(arg_00242, (Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon76 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon76(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002476(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon77 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon77(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002477(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon78 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon78(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002478(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon79 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon79(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Expression result = arg_00241.lambda_0024visit_002479(arg_00242, (Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon80 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon80(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002480(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon81 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon81(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002481(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon82 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon82(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002482(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon83 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon83(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Name result = arg_00241.lambda_0024visit_002483(arg_00242, (Name)P_0);
			
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

	
	private sealed class ___003C_003EAnon84 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon84(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002484(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon85 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon85(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002485(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon86 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon86(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002486(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon87 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon87(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002487(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon88 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon88(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Name result = arg_00241.lambda_0024visit_002488(arg_00242, (Name)P_0);
			
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

	
	private sealed class ___003C_003EAnon89 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon89(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002489(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon90 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon90(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002490(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon91 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon91(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			BlockStmt result = arg_00241.lambda_0024visit_002491(arg_00242, (BlockStmt)P_0);
			
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

	
	private sealed class ___003C_003EAnon92 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon92(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002492(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon93 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon93(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002493(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon94 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon94(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002494(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon95 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon95(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002495(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon96 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon96(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002496(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon97 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon97(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002497(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon98 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon98(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_002498(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon99 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon99(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Expression result = arg_00241.lambda_0024visit_002499(arg_00242, (Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon100 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon100(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024100(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon101 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon101(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024101(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon102 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon102(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024102(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon103 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon103(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ReferenceType result = arg_00241.lambda_0024visit_0024103(arg_00242, (ReferenceType)P_0);
			
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

	
	private sealed class ___003C_003EAnon104 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon104(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ReferenceType result = arg_00241.lambda_0024visit_0024104(arg_00242, (ReferenceType)P_0);
			
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

	
	private sealed class ___003C_003EAnon105 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon105(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024105(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon106 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon106(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024106(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon107 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon107(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024107(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon108 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon108(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024108(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon109 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon109(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024109(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon110 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon110(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024110(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon111 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon111(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024111(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon112 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon112(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			NodeList result = arg_00241.lambda_0024modifyList_0024112(arg_00242, (NodeList)P_0);
			
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

	
	private sealed class ___003C_003EAnon113 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon113(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024113(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon114 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon114(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024114(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon115 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon115(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024115(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon116 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon116(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024116(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon117 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon117(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024117(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon118 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon118(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024118(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon119 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon119(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024119(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon120 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon120(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024120(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon121 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon121(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024121(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon122 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon122(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024122(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon123 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon123(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024123(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon124 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon124(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024124(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon125 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon125(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024125(arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon126 : Function
	{
		private readonly ModifierVisitor arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon126(ModifierVisitor P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Comment result = arg_00241.lambda_0024visit_0024126(arg_00242, (Comment)P_0);
			
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

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private NodeList modifyList(NodeList list, object arg)
	{
		return (NodeList)list.accept(this, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private NodeList modifyList(Optional list, object arg)
	{
		return (NodeList)list.map(new ___003C_003EAnon112(this, arg)).orElse(null);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 184, 115, 115, 127, 4, 102, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(PatternExpr n, object arg)
	{
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		ReferenceType referenceType = (ReferenceType)n.getType().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon126(this, arg)).orElse(null);
		if (simpleName == null || referenceType == null)
		{
			return null;
		}
		n.setName(simpleName);
		n.setType(referenceType);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(TextBlockLiteralExpr n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon125(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(YieldStmt n, object arg)
	{
		Expression expression = (Expression)n.getExpression().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon124(this, arg)).orElse(null);
		if (expression == null)
		{
			return null;
		}
		n.setExpression(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 153, 110, 115, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(SwitchExpr n, object arg)
	{
		NodeList entries = modifyList(n.getEntries(), arg);
		Expression expression = (Expression)n.getSelector().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon123(this, arg)).orElse(null);
		if (expression == null)
		{
			return null;
		}
		n.setEntries(entries);
		n.setSelector(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(Modifier n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon122(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(VarType n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon121(this, arg)).orElse(null);
		n.setAnnotations(annotations);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 122, 110, 115, 115, 127, 4, 102, 98, 104,
		104, 104, 104
	})]
	public virtual Visitable visit(ReceiverParameter n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		Name name = (Name)n.getName().accept(this, arg);
		Type type = (Type)n.getType().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon120(this, arg)).orElse(null);
		if (name == null || type == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setName(name);
		n.setType(type);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(UnparsableStmt n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon119(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 102, 110, 115, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(ModuleOpensDirective n, object arg)
	{
		NodeList moduleNames = modifyList(n.getModuleNames(), arg);
		Name name = (Name)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon118(this, arg)).orElse(null);
		if (name == null)
		{
			return null;
		}
		n.setModuleNames(moduleNames);
		n.setName(name);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(ModuleUsesDirective n, object arg)
	{
		Name name = (Name)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon117(this, arg)).orElse(null);
		if (name == null)
		{
			return null;
		}
		n.setName(name);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 78, 115, 110, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(ModuleProvidesDirective n, object arg)
	{
		Name name = (Name)n.getName().accept(this, arg);
		NodeList with = modifyList(n.getWith(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon116(this, arg)).orElse(null);
		if (name == null)
		{
			return null;
		}
		n.setName(name);
		n.setWith(with);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 65, 110, 115, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(ModuleExportsDirective n, object arg)
	{
		NodeList moduleNames = modifyList(n.getModuleNames(), arg);
		Name name = (Name)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon115(this, arg)).orElse(null);
		if (name == null)
		{
			return null;
		}
		n.setModuleNames(moduleNames);
		n.setName(name);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 52, 110, 115, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(ModuleRequiresDirective n, object arg)
	{
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		Name name = (Name)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon114(this, arg)).orElse(null);
		if (name == null)
		{
			return null;
		}
		n.setModifiers(modifiers);
		n.setName(name);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 38, 110, 110, 115, 127, 4, 99, 98, 104,
		104, 104, 104
	})]
	public virtual Visitable visit(ModuleDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList directives = modifyList(n.getDirectives(), arg);
		Name name = (Name)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon113(this, arg)).orElse(null);
		if (name == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setDirectives(directives);
		n.setName(name);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Node visit(ImportDeclaration n, object arg)
	{
		Name name = (Name)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon109(this, arg)).orElse(null);
		if (name == null)
		{
			return null;
		}
		n.setName(name);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(SimpleName n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon73(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(Name n, object arg)
	{
		Name qualifier = (Name)n.getQualifier().map(new ___003C_003EAnon70(this, arg)).orElse(null);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon71(this, arg)).orElse(null);
		n.setQualifier(qualifier);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		163, 241, 104, 130, 102, 103, 123, 111, 111, 98,
		124, 105, 143, 148, 98
	})]
	public virtual Visitable visit(NodeList n, object arg)
	{
		if (n.isEmpty())
		{
			return n;
		}
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList(n);
		Iterator iterator = ((List)arrayList2).iterator();
		while (iterator.hasNext())
		{
			Node node = (Node)iterator.next();
			Node b = (Node)node.accept(this, arg);
			((List)arrayList).add((object)new Pair(node, b));
		}
		iterator = ((List)arrayList).iterator();
		while (iterator.hasNext())
		{
			Pair pair = (Pair)iterator.next();
			if (pair.___003C_003Eb == null)
			{
				Utils.removeElementByObjectIdentity(n, pair.___003C_003Ea);
			}
			else
			{
				Utils.replaceElementByObjectIdentity(n, pair.___003C_003Ea, pair.___003C_003Eb);
			}
		}
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(TypeExpr n, object arg)
	{
		Type type = (Type)n.getType().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon108(this, arg)).orElse(null);
		if (type == null)
		{
			return null;
		}
		n.setType(type);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 217, 115, 110, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(MethodReferenceExpr n, object arg)
	{
		Expression expression = (Expression)n.getScope().accept(this, arg);
		NodeList typeArguments = modifyList(n.getTypeArguments(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon107(this, arg)).orElse(null);
		if (expression == null)
		{
			return null;
		}
		n.setScope(expression);
		n.setTypeArguments(typeArguments);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 204, 115, 110, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(LambdaExpr n, object arg)
	{
		Statement statement = (Statement)n.getBody().accept(this, arg);
		NodeList parameters = modifyList(n.getParameters(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon106(this, arg)).orElse(null);
		if (statement == null)
		{
			return null;
		}
		n.setBody(statement);
		n.setParameters(parameters);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 93, 115, 115, 127, 4, 102, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(CatchClause n, object arg)
	{
		BlockStmt blockStmt = (BlockStmt)n.getBody().accept(this, arg);
		Parameter parameter = (Parameter)n.getParameter().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon16(this, arg)).orElse(null);
		if (blockStmt == null || parameter == null)
		{
			return null;
		}
		n.setBody(blockStmt);
		n.setParameter(parameter);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 65, 110, 127, 4, 110, 115, 127, 5, 99,
		98, 104, 104, 104, 104, 105
	})]
	public virtual Visitable visit(TryStmt n, object arg)
	{
		NodeList catchClauses = modifyList(n.getCatchClauses(), arg);
		BlockStmt finallyBlock = (BlockStmt)n.getFinallyBlock().map(new ___003C_003EAnon91(this, arg)).orElse(null);
		NodeList resources = modifyList(n.getResources(), arg);
		BlockStmt blockStmt = (BlockStmt)n.getTryBlock().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon92(this, arg)).orElse(null);
		if (blockStmt == null)
		{
			return null;
		}
		n.setCatchClauses(catchClauses);
		n.setFinallyBlock(finallyBlock);
		n.setResources(resources);
		n.setTryBlock(blockStmt);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 32, 115, 115, 127, 4, 102, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(SynchronizedStmt n, object arg)
	{
		BlockStmt blockStmt = (BlockStmt)n.getBody().accept(this, arg);
		Expression expression = (Expression)n.getExpression().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon87(this, arg)).orElse(null);
		if (blockStmt == null || expression == null)
		{
			return null;
		}
		n.setBody(blockStmt);
		n.setExpression(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(ThrowStmt n, object arg)
	{
		Expression expression = (Expression)n.getExpression().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon90(this, arg)).orElse(null);
		if (expression == null)
		{
			return null;
		}
		n.setExpression(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 163, 115, 127, 4, 110, 110, 127, 5, 99,
		98, 104, 104, 104, 104, 105
	})]
	public virtual Visitable visit(ForStmt n, object arg)
	{
		Statement statement = (Statement)n.getBody().accept(this, arg);
		Expression compare = (Expression)n.getCompare().map(new ___003C_003EAnon45(this, arg)).orElse(null);
		NodeList initialization = modifyList(n.getInitialization(), arg);
		NodeList update = modifyList(n.getUpdate(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon46(this, arg)).orElse(null);
		if (statement == null)
		{
			return null;
		}
		n.setBody(statement);
		n.setCompare(compare);
		n.setInitialization(initialization);
		n.setUpdate(update);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 148, 115, 115, 115, 127, 4, 105, 98, 104,
		104, 104, 104
	})]
	public virtual Visitable visit(ForEachStmt n, object arg)
	{
		Statement statement = (Statement)n.getBody().accept(this, arg);
		Expression expression = (Expression)n.getIterable().accept(this, arg);
		VariableDeclarationExpr variableDeclarationExpr = (VariableDeclarationExpr)n.getVariable().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon44(this, arg)).orElse(null);
		if (statement == null || expression == null || variableDeclarationExpr == null)
		{
			return null;
		}
		n.setBody(statement);
		n.setIterable(expression);
		n.setVariable(variableDeclarationExpr);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 18, 115, 115, 127, 4, 102, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(DoStmt n, object arg)
	{
		Statement statement = (Statement)n.getBody().accept(this, arg);
		Expression expression = (Expression)n.getCondition().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon33(this, arg)).orElse(null);
		if (statement == null || expression == null)
		{
			return null;
		}
		n.setBody(statement);
		n.setCondition(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(ContinueStmt n, object arg)
	{
		SimpleName label = (SimpleName)n.getLabel().map(new ___003C_003EAnon31(this, arg)).orElse(null);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon32(this, arg)).orElse(null);
		n.setLabel(label);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 178, 115, 115, 127, 4, 102, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(WhileStmt n, object arg)
	{
		Statement statement = (Statement)n.getBody().accept(this, arg);
		Expression expression = (Expression)n.getCondition().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon102(this, arg)).orElse(null);
		if (statement == null || expression == null)
		{
			return null;
		}
		n.setBody(statement);
		n.setCondition(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 180, 115, 127, 4, 115, 127, 4, 102, 98,
		104, 104, 104, 104
	})]
	public virtual Visitable visit(IfStmt n, object arg)
	{
		Expression expression = (Expression)n.getCondition().accept(this, arg);
		Statement elseStmt = (Statement)n.getElseStmt().map(new ___003C_003EAnon47(this, arg)).orElse(null);
		Statement statement = (Statement)n.getThenStmt().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon48(this, arg)).orElse(null);
		if (expression == null || statement == null)
		{
			return null;
		}
		n.setCondition(expression);
		n.setElseStmt(elseStmt);
		n.setThenStmt(statement);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(ReturnStmt n, object arg)
	{
		Expression expression = (Expression)n.getExpression().map(new ___003C_003EAnon79(this, arg)).orElse(null);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon80(this, arg)).orElse(null);
		n.setExpression(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(BreakStmt n, object arg)
	{
		SimpleName label = (SimpleName)n.getLabel().map(new ___003C_003EAnon13(this, arg)).orElse(null);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon14(this, arg)).orElse(null);
		n.setLabel(label);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(SwitchEntry n, object arg)
	{
		NodeList labels = modifyList(n.getLabels(), arg);
		NodeList statements = modifyList(n.getStatements(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon85(this, arg)).orElse(null);
		n.setLabels(labels);
		n.setStatements(statements);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 19, 110, 115, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(SwitchStmt n, object arg)
	{
		NodeList entries = modifyList(n.getEntries(), arg);
		Expression expression = (Expression)n.getSelector().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon86(this, arg)).orElse(null);
		if (expression == null)
		{
			return null;
		}
		n.setEntries(entries);
		n.setSelector(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(ExpressionStmt n, object arg)
	{
		Expression expression = (Expression)n.getExpression().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon41(this, arg)).orElse(null);
		if (expression == null)
		{
			return null;
		}
		n.setExpression(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(EmptyStmt n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon35(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 237, 115, 115, 127, 4, 102, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(LabeledStmt n, object arg)
	{
		SimpleName simpleName = (SimpleName)n.getLabel().accept(this, arg);
		Statement statement = (Statement)n.getStatement().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon54(this, arg)).orElse(null);
		if (simpleName == null || statement == null)
		{
			return null;
		}
		n.setLabel(simpleName);
		n.setStatement(statement);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(BlockStmt n, object arg)
	{
		NodeList statements = modifyList(n.getStatements(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon11(this, arg)).orElse(null);
		n.setStatements(statements);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		78, 115, 127, 4, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(AssertStmt n, object arg)
	{
		Expression expression = (Expression)n.getCheck().accept(this, arg);
		Expression message = (Expression)n.getMessage().map(new ___003C_003EAnon7(this, arg)).orElse(null);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon8(this, arg)).orElse(null);
		if (expression == null)
		{
			return null;
		}
		n.setCheck(expression);
		n.setMessage(message);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(LocalRecordDeclarationStmt n, object arg)
	{
		RecordDeclaration recordDeclaration = (RecordDeclaration)n.getRecordDeclaration().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon94(this, arg)).orElse(null);
		if (recordDeclaration == null)
		{
			return null;
		}
		n.setRecordDeclaration(recordDeclaration);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(LocalClassDeclarationStmt n, object arg)
	{
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = (ClassOrInterfaceDeclaration)n.getClassDeclaration().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon93(this, arg)).orElse(null);
		if (classOrInterfaceDeclaration == null)
		{
			return null;
		}
		n.setClassDeclaration(classOrInterfaceDeclaration);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 94, 110, 127, 4, 110, 127, 4, 104, 104,
		104, 104
	})]
	public virtual Visitable visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		NodeList arguments = modifyList(n.getArguments(), arg);
		Expression expression = (Expression)n.getExpression().map(new ___003C_003EAnon39(this, arg)).orElse(null);
		NodeList typeArguments = modifyList(n.getTypeArguments(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon40(this, arg)).orElse(null);
		n.setArguments(arguments);
		n.setExpression(expression);
		n.setTypeArguments(typeArguments);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 12, 115, 115, 127, 4, 102, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(MemberValuePair n, object arg)
	{
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Expression expression = (Expression)n.getValue().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon57(this, arg)).orElse(null);
		if (simpleName == null || expression == null)
		{
			return null;
		}
		n.setName(simpleName);
		n.setValue(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 80, 110, 115, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(NormalAnnotationExpr n, object arg)
	{
		NodeList pairs = modifyList(n.getPairs(), arg);
		Name name = (Name)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon64(this, arg)).orElse(null);
		if (name == null)
		{
			return null;
		}
		n.setPairs(pairs);
		n.setName(name);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 235, 115, 115, 127, 4, 102, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(SingleMemberAnnotationExpr n, object arg)
	{
		Expression expression = (Expression)n.getMemberValue().accept(this, arg);
		Name name = (Name)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon81(this, arg)).orElse(null);
		if (expression == null || name == null)
		{
			return null;
		}
		n.setMemberValue(expression);
		n.setName(name);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(MarkerAnnotationExpr n, object arg)
	{
		Name name = (Name)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon56(this, arg)).orElse(null);
		if (name == null)
		{
			return null;
		}
		n.setName(name);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 139, 110, 110, 110, 127, 4, 104, 98, 104,
		104, 104, 104
	})]
	public virtual Visitable visit(VariableDeclarationExpr n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		NodeList nodeList = modifyList(n.getVariables(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon98(this, arg)).orElse(null);
		if (nodeList.isEmpty())
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setModifiers(modifiers);
		n.setVariables(nodeList);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(UnaryExpr n, object arg)
	{
		Expression expression = (Expression)n.getExpression().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon96(this, arg)).orElse(null);
		if (expression == null)
		{
			return null;
		}
		n.setExpression(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162,
		byte.MaxValue,
		127,
		4,
		127,
		4,
		104,
		104
	})]
	public virtual Visitable visit(SuperExpr n, object arg)
	{
		Name typeName = (Name)n.getTypeName().map(new ___003C_003EAnon83(this, arg)).orElse(null);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon84(this, arg)).orElse(null);
		n.setTypeName(typeName);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(ThisExpr n, object arg)
	{
		Name typeName = (Name)n.getTypeName().map(new ___003C_003EAnon88(this, arg)).orElse(null);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon89(this, arg)).orElse(null);
		n.setTypeName(typeName);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 100, 110, 110, 127, 4, 115, 111, 127, 5,
		99, 98, 104, 104, 104, 104, 105, 105
	})]
	public virtual Visitable visit(ObjectCreationExpr n, object arg)
	{
		NodeList anonymousClassBody = modifyList(n.getAnonymousClassBody(), arg);
		NodeList arguments = modifyList(n.getArguments(), arg);
		Expression scope = (Expression)n.getScope().map(new ___003C_003EAnon66(this, arg)).orElse(null);
		ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)n.getType().accept(this, arg);
		NodeList typeArguments = modifyList(n.getTypeArguments(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon67(this, arg)).orElse(null);
		if (classOrInterfaceType == null)
		{
			return null;
		}
		n.setAnonymousClassBody(anonymousClassBody);
		n.setArguments(arguments);
		n.setScope(scope);
		n.setType(classOrInterfaceType);
		n.setTypeArguments(typeArguments);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(NameExpr n, object arg)
	{
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon63(this, arg)).orElse(null);
		if (simpleName == null)
		{
			return null;
		}
		n.setName(simpleName);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 25, 110, 115, 127, 4, 110, 127, 5, 99,
		98, 104, 104, 104, 104, 105
	})]
	public virtual Visitable visit(MethodCallExpr n, object arg)
	{
		NodeList arguments = modifyList(n.getArguments(), arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Expression scope = (Expression)n.getScope().map(new ___003C_003EAnon58(this, arg)).orElse(null);
		NodeList typeArguments = modifyList(n.getTypeArguments(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon59(this, arg)).orElse(null);
		if (simpleName == null)
		{
			return null;
		}
		n.setArguments(arguments);
		n.setName(simpleName);
		n.setScope(scope);
		n.setTypeArguments(typeArguments);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(NullLiteralExpr n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon65(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(BooleanLiteralExpr n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon12(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(DoubleLiteralExpr n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon34(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(CharLiteralExpr n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon17(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(LongLiteralExpr n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon55(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(IntegerLiteralExpr n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon52(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(StringLiteralExpr n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon82(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 208, 115, 127, 4, 115, 127, 4, 102, 98,
		104, 104, 104, 104
	})]
	public virtual Visitable visit(InstanceOfExpr n, object arg)
	{
		Expression expression = (Expression)n.getExpression().accept(this, arg);
		PatternExpr pattern = (PatternExpr)n.getPattern().map(new ___003C_003EAnon50(this, arg)).orElse(null);
		ReferenceType referenceType = (ReferenceType)n.getType().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon51(this, arg)).orElse(null);
		if (expression == null || referenceType == null)
		{
			return null;
		}
		n.setExpression(expression);
		n.setPattern(pattern);
		n.setType(referenceType);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 118, 115, 115, 110, 127, 4, 102, 98, 104,
		104, 104, 104
	})]
	public virtual Visitable visit(FieldAccessExpr n, object arg)
	{
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Expression expression = (Expression)n.getScope().accept(this, arg);
		NodeList typeArguments = modifyList(n.getTypeArguments(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon42(this, arg)).orElse(null);
		if (simpleName == null || expression == null)
		{
			return null;
		}
		n.setName(simpleName);
		n.setScope(expression);
		n.setTypeArguments(typeArguments);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(EnclosedExpr n, object arg)
	{
		Expression expression = (Expression)n.getInner().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon36(this, arg)).orElse(null);
		if (expression == null)
		{
			return null;
		}
		n.setInner(expression);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 204, 115, 115, 115, 127, 4, 105, 98, 104,
		104, 104, 104
	})]
	public virtual Visitable visit(ConditionalExpr n, object arg)
	{
		Expression expression = (Expression)n.getCondition().accept(this, arg);
		Expression expression2 = (Expression)n.getElseExpr().accept(this, arg);
		Expression expression3 = (Expression)n.getThenExpr().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon27(this, arg)).orElse(null);
		if (expression == null || expression2 == null || expression3 == null)
		{
			return null;
		}
		n.setCondition(expression);
		n.setElseExpr(expression2);
		n.setThenExpr(expression3);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(ClassExpr n, object arg)
	{
		Type type = (Type)n.getType().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon18(this, arg)).orElse(null);
		if (type == null)
		{
			return null;
		}
		n.setType(type);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 80, 115, 115, 127, 4, 102, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(CastExpr n, object arg)
	{
		Expression expression = (Expression)n.getExpression().accept(this, arg);
		Type type = (Type)n.getType().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon15(this, arg)).orElse(null);
		if (expression == null || type == null)
		{
			return null;
		}
		n.setExpression(expression);
		n.setType(type);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		104, 115, 115, 127, 4, 99, 98, 99, 98, 104,
		104, 104
	})]
	public virtual Visitable visit(BinaryExpr n, object arg)
	{
		Expression expression = (Expression)n.getLeft().accept(this, arg);
		Expression expression2 = (Expression)n.getRight().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon10(this, arg)).orElse(null);
		if (expression == null)
		{
			return expression2;
		}
		if (expression2 == null)
		{
			return expression;
		}
		n.setLeft(expression);
		n.setRight(expression2);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(AssignExpr n, object arg)
	{
		Expression expression = (Expression)n.getTarget().accept(this, arg);
		Expression expression2 = (Expression)n.getValue().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon9(this, arg)).orElse(null);
		if (expression == null || expression2 == null)
		{
			return null;
		}
		n.setTarget(expression);
		n.setValue(expression2);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(ArrayInitializerExpr n, object arg)
	{
		NodeList values = modifyList(n.getValues(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon6(this, arg)).orElse(null);
		n.setValues(values);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		54, 115, 127, 4, 110, 127, 4, 107, 98, 104,
		104, 104, 104
	})]
	public virtual Visitable visit(ArrayCreationExpr n, object arg)
	{
		Type type = (Type)n.getElementType().accept(this, arg);
		ArrayInitializerExpr initializer = (ArrayInitializerExpr)n.getInitializer().map(new ___003C_003EAnon4(this, arg)).orElse(null);
		NodeList nodeList = modifyList(n.getLevels(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon5(this, arg)).orElse(null);
		if (type == null || nodeList.isEmpty())
		{
			return null;
		}
		n.setElementType(type);
		n.setInitializer(initializer);
		n.setLevels(nodeList);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(ArrayAccessExpr n, object arg)
	{
		Expression expression = (Expression)n.getIndex().accept(this, arg);
		Expression expression2 = (Expression)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon3(this, arg)).orElse(null);
		if (expression == null || expression2 == null)
		{
			return null;
		}
		n.setIndex(expression);
		n.setName(expression2);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(UnknownType n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon97(this, arg)).orElse(null);
		n.setAnnotations(annotations);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 191, 110, 127, 4, 127, 4, 127, 4, 104,
		104, 104, 104
	})]
	public virtual Visitable visit(WildcardType n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		ReferenceType extendedType = (ReferenceType)n.getExtendedType().map(new ___003C_003EAnon103(this, arg)).orElse(null);
		ReferenceType superType = (ReferenceType)n.getSuperType().map(new ___003C_003EAnon104(this, arg)).orElse(null);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon105(this, arg)).orElse(null);
		n.setAnnotations(annotations);
		n.setExtendedType(extendedType);
		n.setSuperType(superType);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(VoidType n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon101(this, arg)).orElse(null);
		n.setAnnotations(annotations);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 213, 110, 110, 127, 4, 104, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(UnionType n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList nodeList = modifyList(n.getElements(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon78(this, arg)).orElse(null);
		if (nodeList.isEmpty())
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setElements(nodeList);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 200, 110, 110, 127, 4, 104, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(IntersectionType n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList nodeList = modifyList(n.getElements(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon77(this, arg)).orElse(null);
		if (nodeList.isEmpty())
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setElements(nodeList);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(ArrayCreationLevel n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		Expression dimension = (Expression)n.getDimension().map(new ___003C_003EAnon75(this, arg)).orElse(null);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon76(this, arg)).orElse(null);
		n.setAnnotations(annotations);
		n.setDimension(dimension);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 176, 110, 115, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(ArrayType n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		Type type = (Type)n.getComponentType().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon74(this, arg)).orElse(null);
		if (type == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setComponentType(type);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(PrimitiveType n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon72(this, arg)).orElse(null);
		n.setAnnotations(annotations);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 172, 110, 115, 127, 4, 110, 127, 5, 99,
		98, 104, 104, 104, 104, 105
	})]
	public virtual Visitable visit(ClassOrInterfaceType n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		ClassOrInterfaceType scope = (ClassOrInterfaceType)n.getScope().map(new ___003C_003EAnon22(this, arg)).orElse(null);
		NodeList typeArguments = modifyList(n.getTypeArguments(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon23(this, arg)).orElse(null);
		if (simpleName == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setName(simpleName);
		n.setScope(scope);
		n.setTypeArguments(typeArguments);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(JavadocComment n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon53(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 195, 110, 115, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(InitializerDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		BlockStmt blockStmt = (BlockStmt)n.getBody().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon49(this, arg)).orElse(null);
		if (blockStmt == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setBody(blockStmt);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 132, 110, 110, 115, 115, 111, 127, 5, 102,
		98, 104, 104, 104, 104, 105, 105
	})]
	public virtual Visitable visit(Parameter n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Type type = (Type)n.getType().accept(this, arg);
		NodeList varArgsAnnotations = modifyList(n.getVarArgsAnnotations(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon69(this, arg)).orElse(null);
		if (simpleName == null || type == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setModifiers(modifiers);
		n.setName(simpleName);
		n.setType(type);
		n.setVarArgsAnnotations(varArgsAnnotations);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 42, 110, 110, 127, 4, 115, 116, 111, 127,
		5, 111, 111, 127, 5, 103, 98, 104, 104, 104,
		104, 105, 105, 105, 105, 105, 105
	})]
	public virtual Visitable visit(MethodDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		BlockStmt body = (BlockStmt)n.getBody().map(new ___003C_003EAnon60(this, arg)).orElse(null);
		Type type = (Type)n.getType().accept(this, arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		NodeList parameters = modifyList(n.getParameters(), arg);
		ReceiverParameter receiverParameter = (ReceiverParameter)n.getReceiverParameter().map(new ___003C_003EAnon61(this, arg)).orElse(null);
		NodeList thrownExceptions = modifyList(n.getThrownExceptions(), arg);
		NodeList typeParameters = modifyList(n.getTypeParameters(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon62(this, arg)).orElse(null);
		if (type == null || simpleName == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setModifiers(modifiers);
		n.setBody(body);
		n.setType(type);
		n.setName(simpleName);
		n.setParameters(parameters);
		n.setReceiverParameter(receiverParameter);
		n.setThrownExceptions(thrownExceptions);
		n.setTypeParameters(typeParameters);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 219, 110, 110, 115, 115, 111, 127, 5, 111,
		111, 127, 5, 102, 98, 104, 104, 104, 104, 105,
		105, 105, 105, 105
	})]
	public virtual Visitable visit(ConstructorDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		BlockStmt blockStmt = (BlockStmt)n.getBody().accept(this, arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		NodeList parameters = modifyList(n.getParameters(), arg);
		ReceiverParameter receiverParameter = (ReceiverParameter)n.getReceiverParameter().map(new ___003C_003EAnon28(this, arg)).orElse(null);
		NodeList thrownExceptions = modifyList(n.getThrownExceptions(), arg);
		NodeList typeParameters = modifyList(n.getTypeParameters(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon29(this, arg)).orElse(null);
		if (blockStmt == null || simpleName == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setModifiers(modifiers);
		n.setBody(blockStmt);
		n.setName(simpleName);
		n.setParameters(parameters);
		n.setReceiverParameter(receiverParameter);
		n.setThrownExceptions(thrownExceptions);
		n.setTypeParameters(typeParameters);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 154, 127, 4, 115, 115, 127, 4, 102, 98,
		104, 104, 104, 104
	})]
	public virtual Visitable visit(VariableDeclarator n, object arg)
	{
		Expression initializer = (Expression)n.getInitializer().map(new ___003C_003EAnon99(this, arg)).orElse(null);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Type type = (Type)n.getType().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon100(this, arg)).orElse(null);
		if (simpleName == null || type == null)
		{
			return null;
		}
		n.setInitializer(initializer);
		n.setName(simpleName);
		n.setType(type);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 133, 110, 110, 110, 127, 4, 104, 98, 104,
		104, 104, 104
	})]
	public virtual Visitable visit(FieldDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		NodeList nodeList = modifyList(n.getVariables(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon43(this, arg)).orElse(null);
		if (nodeList.isEmpty())
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setModifiers(modifiers);
		n.setVariables(nodeList);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		22, 110, 110, 127, 4, 115, 116, 127, 5, 103,
		98, 104, 104, 104, 104, 105, 105
	})]
	public virtual Visitable visit(AnnotationMemberDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		Expression defaultValue = (Expression)n.getDefaultValue().map(new ___003C_003EAnon1(this, arg)).orElse(null);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Type type = (Type)n.getType().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon2(this, arg)).orElse(null);
		if (simpleName == null || type == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setModifiers(modifiers);
		n.setDefaultValue(defaultValue);
		n.setName(simpleName);
		n.setType(type);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		5, 110, 110, 110, 115, 127, 5, 99, 98, 104,
		104, 104, 104, 105
	})]
	public virtual Visitable visit(AnnotationDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		NodeList members = modifyList(n.getMembers(), arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon0(this, arg)).orElse(null);
		if (simpleName == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setModifiers(modifiers);
		n.setMembers(members);
		n.setName(simpleName);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 56, 110, 110, 110, 115, 127, 5, 99, 98,
		104, 104, 104, 104, 105
	})]
	public virtual Visitable visit(EnumConstantDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList arguments = modifyList(n.getArguments(), arg);
		NodeList classBody = modifyList(n.getClassBody(), arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon37(this, arg)).orElse(null);
		if (simpleName == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setArguments(arguments);
		n.setClassBody(classBody);
		n.setName(simpleName);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 73, 110, 110, 110, 110, 111, 116, 127, 5,
		100, 98, 104, 104, 104, 104, 105, 105, 105
	})]
	public virtual Visitable visit(EnumDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		NodeList entries = modifyList(n.getEntries(), arg);
		NodeList implementedTypes = modifyList(n.getImplementedTypes(), arg);
		NodeList members = modifyList(n.getMembers(), arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon38(this, arg)).orElse(null);
		if (simpleName == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setModifiers(modifiers);
		n.setEntries(entries);
		n.setImplementedTypes(implementedTypes);
		n.setMembers(members);
		n.setName(simpleName);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 244, 110, 110, 115, 115, 111, 111, 127, 5,
		102, 98, 104, 104, 104, 104, 105, 105, 105
	})]
	public virtual Visitable visit(CompactConstructorDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		BlockStmt blockStmt = (BlockStmt)n.getBody().accept(this, arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		NodeList thrownExceptions = modifyList(n.getThrownExceptions(), arg);
		NodeList typeParameters = modifyList(n.getTypeParameters(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon30(this, arg)).orElse(null);
		if (blockStmt == null || simpleName == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setModifiers(modifiers);
		n.setBody(blockStmt);
		n.setName(simpleName);
		n.setThrownExceptions(thrownExceptions);
		n.setTypeParameters(typeParameters);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 147, 110, 110, 110, 110, 127, 5, 111, 111,
		116, 127, 5, 100, 98, 104, 104, 104, 104, 105,
		105, 105, 105, 105
	})]
	public virtual Visitable visit(RecordDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		NodeList implementedTypes = modifyList(n.getImplementedTypes(), arg);
		NodeList parameters = modifyList(n.getParameters(), arg);
		ReceiverParameter receiverParameter = (ReceiverParameter)n.getReceiverParameter().map(new ___003C_003EAnon20(this, arg)).orElse(null);
		NodeList typeParameters = modifyList(n.getTypeParameters(), arg);
		NodeList members = modifyList(n.getMembers(), arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon21(this, arg)).orElse(null);
		if (simpleName == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setModifiers(modifiers);
		n.setImplementedTypes(implementedTypes);
		n.setParameters(parameters);
		n.setReceiverParameter(receiverParameter);
		n.setTypeParameters(typeParameters);
		n.setMembers(members);
		n.setName(simpleName);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 124, 110, 110, 110, 110, 111, 111, 116, 127,
		5, 100, 98, 104, 104, 104, 104, 105, 105, 105,
		105
	})]
	public virtual Visitable visit(ClassOrInterfaceDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		NodeList modifiers = modifyList(n.getModifiers(), arg);
		NodeList extendedTypes = modifyList(n.getExtendedTypes(), arg);
		NodeList implementedTypes = modifyList(n.getImplementedTypes(), arg);
		NodeList typeParameters = modifyList(n.getTypeParameters(), arg);
		NodeList members = modifyList(n.getMembers(), arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon19(this, arg)).orElse(null);
		if (simpleName == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setModifiers(modifiers);
		n.setExtendedTypes(extendedTypes);
		n.setImplementedTypes(implementedTypes);
		n.setTypeParameters(typeParameters);
		n.setMembers(members);
		n.setName(simpleName);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(BlockComment n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon110(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Visitable visit(LineComment n, object arg)
	{
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon111(this, arg)).orElse(null);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 104, 110, 115, 110, 127, 4, 99, 98, 104,
		104, 104, 104
	})]
	public virtual Visitable visit(TypeParameter n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		SimpleName simpleName = (SimpleName)n.getName().accept(this, arg);
		NodeList typeBound = modifyList(n.getTypeBound(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon95(this, arg)).orElse(null);
		if (simpleName == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setName(simpleName);
		n.setTypeBound(typeBound);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 119, 110, 115, 127, 4, 99, 98, 104, 104,
		104
	})]
	public virtual Visitable visit(PackageDeclaration n, object arg)
	{
		NodeList annotations = modifyList(n.getAnnotations(), arg);
		Name name = (Name)n.getName().accept(this, arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon68(this, arg)).orElse(null);
		if (name == null)
		{
			return null;
		}
		n.setAnnotations(annotations);
		n.setName(name);
		n.setComment(comment);
		return n;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 189, 110, 127, 4, 127, 4, 110, 127, 5,
		104, 104, 104, 104, 105
	})]
	public virtual Visitable visit(CompilationUnit n, object arg)
	{
		NodeList imports = modifyList(n.getImports(), arg);
		ModuleDeclaration module = (ModuleDeclaration)n.getModule().map(new ___003C_003EAnon24(this, arg)).orElse(null);
		PackageDeclaration packageDeclaration = (PackageDeclaration)n.getPackageDeclaration().map(new ___003C_003EAnon25(this, arg)).orElse(null);
		NodeList types = modifyList(n.getTypes(), arg);
		Comment comment = (Comment)n.getComment().map(new ___003C_003EAnon26(this, arg)).orElse(null);
		n.setImports(imports);
		n.setModule(module);
		n.setPackageDeclaration(packageDeclaration);
		n.setTypes(types);
		n.setComment(comment);
		return n;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_00240(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Expression lambda_0024visit_00241(object arg, Expression s)
	{
		return (Expression)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_00242(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_00243(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private ArrayInitializerExpr lambda_0024visit_00244(object arg, ArrayInitializerExpr s)
	{
		return (ArrayInitializerExpr)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_00245(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_00246(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Expression lambda_0024visit_00247(object arg, Expression s)
	{
		return (Expression)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_00248(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_00249(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002410(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002411(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002412(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private SimpleName lambda_0024visit_002413(object arg, SimpleName s)
	{
		return (SimpleName)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002414(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002415(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002416(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002417(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002418(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002419(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private ReceiverParameter lambda_0024visit_002420(object arg, ReceiverParameter s)
	{
		return (ReceiverParameter)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002421(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private ClassOrInterfaceType lambda_0024visit_002422(object arg, ClassOrInterfaceType s)
	{
		return (ClassOrInterfaceType)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002423(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private ModuleDeclaration lambda_0024visit_002424(object arg, ModuleDeclaration s)
	{
		return (ModuleDeclaration)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private PackageDeclaration lambda_0024visit_002425(object arg, PackageDeclaration s)
	{
		return (PackageDeclaration)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002426(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002427(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private ReceiverParameter lambda_0024visit_002428(object arg, ReceiverParameter s)
	{
		return (ReceiverParameter)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002429(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002430(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private SimpleName lambda_0024visit_002431(object arg, SimpleName s)
	{
		return (SimpleName)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002432(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002433(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002434(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002435(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002436(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002437(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002438(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Expression lambda_0024visit_002439(object arg, Expression s)
	{
		return (Expression)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002440(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002441(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002442(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002443(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002444(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Expression lambda_0024visit_002445(object arg, Expression s)
	{
		return (Expression)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002446(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Statement lambda_0024visit_002447(object arg, Statement s)
	{
		return (Statement)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002448(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002449(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private PatternExpr lambda_0024visit_002450(object arg, PatternExpr s)
	{
		return (PatternExpr)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002451(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002452(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002453(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002454(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002455(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002456(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002457(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Expression lambda_0024visit_002458(object arg, Expression s)
	{
		return (Expression)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002459(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private BlockStmt lambda_0024visit_002460(object arg, BlockStmt s)
	{
		return (BlockStmt)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private ReceiverParameter lambda_0024visit_002461(object arg, ReceiverParameter s)
	{
		return (ReceiverParameter)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002462(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002463(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002464(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002465(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Expression lambda_0024visit_002466(object arg, Expression s)
	{
		return (Expression)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002467(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002468(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002469(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Name lambda_0024visit_002470(object arg, Name s)
	{
		return (Name)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002471(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002472(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002473(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002474(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Expression lambda_0024visit_002475(object arg, Expression s)
	{
		return (Expression)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002476(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002477(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002478(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Expression lambda_0024visit_002479(object arg, Expression s)
	{
		return (Expression)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002480(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002481(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002482(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Name lambda_0024visit_002483(object arg, Name s)
	{
		return (Name)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002484(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002485(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002486(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002487(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Name lambda_0024visit_002488(object arg, Name s)
	{
		return (Name)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002489(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002490(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private BlockStmt lambda_0024visit_002491(object arg, BlockStmt s)
	{
		return (BlockStmt)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002492(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002493(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002494(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002495(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002496(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002497(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_002498(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Expression lambda_0024visit_002499(object arg, Expression s)
	{
		return (Expression)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024100(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024101(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024102(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private ReferenceType lambda_0024visit_0024103(object arg, ReferenceType s)
	{
		return (ReferenceType)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private ReferenceType lambda_0024visit_0024104(object arg, ReferenceType s)
	{
		return (ReferenceType)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024105(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024106(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024107(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024108(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024109(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024110(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024111(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private NodeList lambda_0024modifyList_0024112(object arg, NodeList ns)
	{
		NodeList result = modifyList(ns, arg);
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024113(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024114(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024115(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024116(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024117(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024118(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024119(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024120(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024121(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024122(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024123(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024124(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024125(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private Comment lambda_0024visit_0024126(object arg, Comment s)
	{
		return (Comment)s.accept(this, arg);
	}

	
	
	public ModifierVisitor()
	{
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(PatternExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(TextBlockLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(YieldStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(SwitchExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(Modifier n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(VarType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ReceiverParameter n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(UnparsableStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ModuleOpensDirective n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ModuleUsesDirective n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ModuleProvidesDirective n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ModuleExportsDirective n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ModuleRequiresDirective n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ModuleDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ImportDeclaration n, object arg)
	{
		Node result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(SimpleName n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(Name n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(NodeList n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(TypeExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(MethodReferenceExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(LambdaExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(CatchClause n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(TryStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(SynchronizedStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ThrowStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ForStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ForEachStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(DoStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ContinueStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(WhileStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(IfStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ReturnStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(BreakStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(SwitchEntry n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(SwitchStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ExpressionStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(EmptyStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(LabeledStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(BlockStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(AssertStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(LocalRecordDeclarationStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(LocalClassDeclarationStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ExplicitConstructorInvocationStmt n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(MemberValuePair n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(NormalAnnotationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(SingleMemberAnnotationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(MarkerAnnotationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(VariableDeclarationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(UnaryExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(SuperExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ThisExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ObjectCreationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(NameExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(MethodCallExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(NullLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(BooleanLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(DoubleLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(CharLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(LongLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(IntegerLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(StringLiteralExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(InstanceOfExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(FieldAccessExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(EnclosedExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ConditionalExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ClassExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(CastExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(BinaryExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(AssignExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ArrayInitializerExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ArrayCreationExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ArrayAccessExpr n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(UnknownType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(WildcardType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(VoidType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(UnionType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(IntersectionType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ArrayCreationLevel n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ArrayType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(PrimitiveType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ClassOrInterfaceType n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(JavadocComment n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(InitializerDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(Parameter n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(MethodDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ConstructorDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(VariableDeclarator n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(FieldDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(AnnotationMemberDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(AnnotationDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(EnumConstantDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(EnumDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(CompactConstructorDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(RecordDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(ClassOrInterfaceDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(BlockComment n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(LineComment n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(TypeParameter n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object _003Cbridge_003Evisit(PackageDeclaration n, object arg)
	{
		Visitable result = visit(n, arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
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
