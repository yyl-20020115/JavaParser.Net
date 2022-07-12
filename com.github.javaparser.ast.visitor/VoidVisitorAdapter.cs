
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.visitor;

public abstract class VoidVisitorAdapter: VoidVisitor
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon0(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00240(arg_00242, (BodyDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon1(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00241(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon2(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00242(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon3(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00243(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon4(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00244(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon5(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00245(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon6(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00246(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon7(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00247(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon8 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon8(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00248(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon9 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon9(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00249(arg_00242, (ArrayInitializerExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon10 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon10(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002410(arg_00242, (ArrayCreationLevel)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon11 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon11(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002411(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon12 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon12(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002412(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon13 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon13(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002413(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon14 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon14(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002414(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon15 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon15(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002415(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon16 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon16(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002416(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon17 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon17(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002417(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon18 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon18(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002418(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon19 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon19(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002419(arg_00242, (Statement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon20 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon20(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002420(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon21 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon21(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002421(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon22 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon22(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002422(arg_00242, (SimpleName)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon23 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon23(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002423(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon24 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon24(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002424(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon25 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon25(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002425(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon26 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon26(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002426(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon27 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon27(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002427(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon28 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon28(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002428(arg_00242, (ClassOrInterfaceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon29 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon29(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002429(arg_00242, (ClassOrInterfaceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon30 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon30(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002430(arg_00242, (TypeParameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon31 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon31(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002431(arg_00242, (BodyDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon32 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon32(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002432(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon33 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon33(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002433(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon34 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon34(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002434(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon35 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon35(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002435(arg_00242, (ClassOrInterfaceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon36 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon36(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002437(arg_00242, (NodeList)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon37 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon37(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002438(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon38 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon38(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002439(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon39 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon39(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002440(arg_00242, (ImportDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon40 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon40(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002441(arg_00242, (ModuleDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon41 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon41(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002442(arg_00242, (PackageDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon42 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon42(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002443(arg_00242, (TypeDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon43 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon43(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002444(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon44 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon44(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002445(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon45 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon45(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002446(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon46 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon46(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002447(arg_00242, (Parameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon47 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon47(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002448(arg_00242, (ReceiverParameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon48 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon48(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002449(arg_00242, (ReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon49 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon49(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002450(arg_00242, (TypeParameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon50 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon50(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002451(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon51 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon51(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002452(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon52 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon52(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002453(arg_00242, (SimpleName)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon53 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon53(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002454(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon54 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon54(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002455(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon55 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon55(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002456(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon56 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon56(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002457(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon57 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon57(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002458(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon58 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon58(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002459(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon59 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon59(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002460(arg_00242, (BodyDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon60 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon60(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002461(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon61 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon61(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002462(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon62 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon62(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002463(arg_00242, (EnumConstantDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon63 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon63(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002464(arg_00242, (ClassOrInterfaceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon64 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon64(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002465(arg_00242, (BodyDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon65 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon65(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002466(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon66 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon66(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002467(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon67 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon67(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002468(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon68 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon68(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002469(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon69 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon69(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002470(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon70 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon70(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002472(arg_00242, (NodeList)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon71 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon71(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002473(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon72 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon72(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002474(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon73 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon73(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002476(arg_00242, (NodeList)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon74 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon74(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002477(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon75 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon75(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002478(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon76 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon76(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002479(arg_00242, (VariableDeclarator)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon77 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon77(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002480(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon78 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon78(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002481(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon79 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon79(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002482(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon80 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon80(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002483(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon81 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon81(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002484(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon82 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon82(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002485(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon83 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon83(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002486(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon84 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon84(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002487(arg_00242, (Statement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon85 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon85(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002488(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon86 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon86(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002489(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon87 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon87(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002490(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon88 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon88(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002491(arg_00242, (PatternExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon89 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon89(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002492(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon90 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon90(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002493(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon91 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon91(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002494(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon92 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon92(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002495(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon93 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon93(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002496(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon94 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon94(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002497(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon95 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon95(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002498(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon96 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon96(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002499(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon97 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon97(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024100(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon98 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon98(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024101(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon99 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon99(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024103(arg_00242, (NodeList)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon100 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon100(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024104(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon101 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon101(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024105(arg_00242, (BlockStmt)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon102 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon102(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024106(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon103 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon103(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024107(arg_00242, (Parameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon104 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon104(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024108(arg_00242, (ReceiverParameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon105 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon105(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024109(arg_00242, (ReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon106 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon106(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024110(arg_00242, (TypeParameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon107 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon107(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024111(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon108 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon108(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024112(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon109 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon109(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024113(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon110 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon110(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024114(arg_00242, (MemberValuePair)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon111 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon111(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024115(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon112 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon112(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024116(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon113 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon113(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024118(arg_00242, (NodeList)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon114 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon114(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024119(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon115 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon115(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024120(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon116 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon116(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024122(arg_00242, (NodeList)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon117 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon117(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024123(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon118 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon118(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024124(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon119 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon119(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024125(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon120 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon120(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024126(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon121 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon121(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024127(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon122 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon122(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024128(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon123 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon123(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024129(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon124 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon124(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024130(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon125 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon125(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024131(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon126 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon126(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024132(arg_00242, (Name)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon127 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon127(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024133(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon128 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon128(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024134(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon129 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon129(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024135(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon130 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon130(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024136(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon131 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon131(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024137(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon132 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon132(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024138(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon133 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon133(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024139(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon134 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon134(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024140(arg_00242, (ReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon135 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon135(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024141(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon136 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon136(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024142(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon137 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon137(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024143(arg_00242, (ReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon138 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon138(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024144(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon139 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon139(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024145(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon140 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon140(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024146(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon141 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon141(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024147(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon142 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon142(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024148(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon143 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon143(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024149(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon144 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon144(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024150(arg_00242, (Name)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon145 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon145(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024151(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon146 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon146(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024152(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon147 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon147(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024153(arg_00242, (Statement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon148 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon148(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024154(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon149 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon149(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024155(arg_00242, (SwitchEntry)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon150 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon150(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024156(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon151 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon151(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024157(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon152 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon152(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024158(arg_00242, (Name)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon153 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon153(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024159(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon154 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon154(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024160(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon155 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon155(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024161(arg_00242, (CatchClause)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon156 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon156(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024162(arg_00242, (BlockStmt)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon157 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon157(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024163(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon158 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon158(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024164(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon159 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon159(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024165(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon160 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon160(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024166(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon161 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon161(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024167(arg_00242, (ClassOrInterfaceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon162 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon162(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024168(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon163 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon163(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024169(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon164 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon164(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024170(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon165 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon165(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024171(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon166 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon166(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024172(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon167 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon167(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024173(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon168 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon168(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024174(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon169 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon169(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024175(arg_00242, (VariableDeclarator)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon170 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon170(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024176(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon171 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon171(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024177(arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon172 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon172(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024178(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon173 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon173(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024179(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon174 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon174(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024180(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon175 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon175(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024181(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon176 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon176(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024182(arg_00242, (ReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon177 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon177(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024183(arg_00242, (ReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon178 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon178(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024184(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon179 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon179(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024185(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon180 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon180(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024186(arg_00242, (Parameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon181 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon181(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024187(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon182 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon182(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024189(arg_00242, (NodeList)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon183 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon183(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024190(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon184 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon184(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024191(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon185 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon185(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024192(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon186 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon186(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024193(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon187 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon187(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024194(arg_00242, (ModuleDirective)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon188 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon188(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024195(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon189 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon189(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024196(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon190 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon190(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024197(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon191 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon191(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024198(arg_00242, (Name)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon192 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon192(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024199(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon193 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon193(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024200(arg_00242, (Name)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon194 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon194(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024201(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon195 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon195(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024202(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon196 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon196(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024203(arg_00242, (Name)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon197 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon197(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024204(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon198 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon198(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024205(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon199 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon199(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024206(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon200 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon200(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024207(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon201 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon201(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024208(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon202 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon202(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024209(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon203 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon203(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024210(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon204 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon204(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024211(arg_00242, (SwitchEntry)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon205 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon205(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024212(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon206 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon206(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024213(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon207 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon207(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024214(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon208 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon208(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024215(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon209 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon209(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024216(arg_00242, (ClassOrInterfaceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon210 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon210(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024217(arg_00242, (Parameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon211 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon211(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024218(arg_00242, (ReceiverParameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon212 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon212(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024219(arg_00242, (TypeParameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon213 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon213(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024220(arg_00242, (BodyDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon214 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon214(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024221(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon215 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon215(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024222(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon216 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon216(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024223(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon217 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon217(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024224(arg_00242, (Modifier)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon218 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon218(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024225(arg_00242, (ReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon219 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon219(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024226(arg_00242, (TypeParameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon220 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon220(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024227(arg_00242, (AnnotationExpr)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon221 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon221(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_0024228(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon222 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon222(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_0024188(arg_00242, (Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon223 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon223(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_0024121(arg_00242, (Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon224 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon224(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_0024117(arg_00242, (BodyDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon225 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon225(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_0024102(arg_00242, (Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon226 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon226(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_002475(arg_00242, (Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon227 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon227(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_002471(arg_00242, (Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon228 : Consumer
	{
		private readonly VoidVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon228(VoidVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_002436(arg_00242, (Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	
	
	
	private void lambda_0024visit_00240(object arg, BodyDeclaration p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_00241(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_00242(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_00243(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_00244(object arg, Expression l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_00245(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_00246(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_00247(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_00248(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_00249(object arg, ArrayInitializerExpr l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002410(object arg, ArrayCreationLevel p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002411(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002412(object arg, Expression p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002413(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002414(object arg, Expression l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002415(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002416(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002417(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002418(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002419(object arg, Statement p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002420(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002421(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002422(object arg, SimpleName l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002423(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002424(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002425(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002426(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002427(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002428(object arg, ClassOrInterfaceType p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002429(object arg, ClassOrInterfaceType p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002430(object arg, TypeParameter p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002431(object arg, BodyDeclaration p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002432(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002433(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002434(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002435(object arg, ClassOrInterfaceType l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002437(object arg, NodeList l)
	{
		l.forEach(new ___003C_003EAnon228(this, arg));
	}

	
	
	
	
	private void lambda_0024visit_002438(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002439(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002440(object arg, ImportDeclaration p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002441(object arg, ModuleDeclaration l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002442(object arg, PackageDeclaration l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002443(object arg, TypeDeclaration p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002444(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002445(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002446(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002447(object arg, Parameter p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002448(object arg, ReceiverParameter l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002449(object arg, ReferenceType p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002450(object arg, TypeParameter p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002451(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002452(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002453(object arg, SimpleName l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002454(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002455(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002456(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002457(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002458(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002459(object arg, Expression p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002460(object arg, BodyDeclaration p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002461(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002462(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002463(object arg, EnumConstantDeclaration p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002464(object arg, ClassOrInterfaceType p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002465(object arg, BodyDeclaration p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002466(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002467(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002468(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002469(object arg, Expression p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002470(object arg, Expression l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002472(object arg, NodeList l)
	{
		l.forEach(new ___003C_003EAnon227(this, arg));
	}

	
	
	
	
	private void lambda_0024visit_002473(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002474(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002476(object arg, NodeList l)
	{
		l.forEach(new ___003C_003EAnon226(this, arg));
	}

	
	
	
	
	private void lambda_0024visit_002477(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002478(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002479(object arg, VariableDeclarator p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002480(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002481(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002482(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002483(object arg, Expression l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002484(object arg, Expression p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002485(object arg, Expression p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002486(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002487(object arg, Statement l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002488(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002489(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002490(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002491(object arg, PatternExpr l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002492(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002493(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002494(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002495(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002496(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002497(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002498(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002499(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024100(object arg, Expression p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024101(object arg, Expression l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024103(object arg, NodeList l)
	{
		l.forEach(new ___003C_003EAnon225(this, arg));
	}

	
	
	
	
	private void lambda_0024visit_0024104(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024105(object arg, BlockStmt l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024106(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024107(object arg, Parameter p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024108(object arg, ReceiverParameter l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024109(object arg, ReferenceType p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024110(object arg, TypeParameter p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024111(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024112(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024113(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024114(object arg, MemberValuePair p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024115(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024116(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024118(object arg, NodeList l)
	{
		l.forEach(new ___003C_003EAnon224(this, arg));
	}

	
	
	
	
	private void lambda_0024visit_0024119(object arg, Expression p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024120(object arg, Expression l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024122(object arg, NodeList l)
	{
		l.forEach(new ___003C_003EAnon223(this, arg));
	}

	
	
	
	
	private void lambda_0024visit_0024123(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024124(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024125(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024126(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024127(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024128(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024129(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024130(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024131(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024132(object arg, Name l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024133(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024134(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024135(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024136(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024137(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024138(object arg, Expression l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024139(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024140(object arg, ReferenceType p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024141(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024142(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024143(object arg, ReferenceType p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024144(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024145(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024146(object arg, Expression l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024147(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024148(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024149(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024150(object arg, Name l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024151(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024152(object arg, Expression p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024153(object arg, Statement p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024154(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024155(object arg, SwitchEntry p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024156(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024157(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024158(object arg, Name l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024159(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024160(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024161(object arg, CatchClause p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024162(object arg, BlockStmt l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024163(object arg, Expression p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024164(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024165(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024166(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024167(object arg, ClassOrInterfaceType p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024168(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024169(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024170(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024171(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024172(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024173(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024174(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024175(object arg, VariableDeclarator p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024176(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024177(object arg, Expression l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024178(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024179(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024180(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024181(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024182(object arg, ReferenceType l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024183(object arg, ReferenceType l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024184(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024185(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024186(object arg, Parameter p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024187(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024189(object arg, NodeList l)
	{
		l.forEach(new ___003C_003EAnon222(this, arg));
	}

	
	
	
	
	private void lambda_0024visit_0024190(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024191(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024192(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024193(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024194(object arg, ModuleDirective p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024195(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024196(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024197(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024198(object arg, Name p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024199(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024200(object arg, Name p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024201(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024202(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024203(object arg, Name p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024204(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024205(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024206(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024207(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024208(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024209(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024210(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024211(object arg, SwitchEntry p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024212(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024213(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024214(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024215(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024216(object arg, ClassOrInterfaceType p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024217(object arg, Parameter p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024218(object arg, ReceiverParameter l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024219(object arg, TypeParameter p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024220(object arg, BodyDeclaration p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024221(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024222(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024223(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024224(object arg, Modifier p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024225(object arg, ReferenceType p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024226(object arg, TypeParameter p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024227(object arg, AnnotationExpr p)
	{
		p.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_0024228(object arg, Comment l)
	{
		l.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024null_0024188(object arg, Type v)
	{
		v.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024null_0024121(object arg, Type v)
	{
		v.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024null_0024117(object arg, BodyDeclaration v)
	{
		v.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024null_0024102(object arg, Type v)
	{
		v.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024null_002475(object arg, Type v)
	{
		v.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024null_002471(object arg, Type v)
	{
		v.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024null_002436(object arg, Type v)
	{
		v.accept(this, arg);
	}

	
	
	public VoidVisitorAdapter()
	{
	}

	
		
	
	public virtual void visit(AnnotationDeclaration n, object arg)
	{
		n.getMembers().forEach(new ___003C_003EAnon0(this, arg));
		n.getModifiers().forEach(new ___003C_003EAnon1(this, arg));
		n.getName().accept(this, arg);
		n.getAnnotations().forEach(new ___003C_003EAnon2(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon3(this, arg));
	}

	
		
	
	public virtual void visit(AnnotationMemberDeclaration n, object arg)
	{
		n.getDefaultValue().ifPresent(new ___003C_003EAnon4(this, arg));
		n.getModifiers().forEach(new ___003C_003EAnon5(this, arg));
		n.getName().accept(this, arg);
		n.getType().accept(this, arg);
		n.getAnnotations().forEach(new ___003C_003EAnon6(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon7(this, arg));
	}

	
		
	
	public virtual void visit(ArrayAccessExpr n, object arg)
	{
		n.getIndex().accept(this, arg);
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon8(this, arg));
	}

	
		
	
	public virtual void visit(ArrayCreationExpr n, object arg)
	{
		n.getElementType().accept(this, arg);
		n.getInitializer().ifPresent(new ___003C_003EAnon9(this, arg));
		n.getLevels().forEach(new ___003C_003EAnon10(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon11(this, arg));
	}

	
		
	
	public virtual void visit(ArrayInitializerExpr n, object arg)
	{
		n.getValues().forEach(new ___003C_003EAnon12(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon13(this, arg));
	}

	
		
	
	public virtual void visit(AssertStmt n, object arg)
	{
		n.getCheck().accept(this, arg);
		n.getMessage().ifPresent(new ___003C_003EAnon14(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon15(this, arg));
	}

	
		
	
	public virtual void visit(AssignExpr n, object arg)
	{
		n.getTarget().accept(this, arg);
		n.getValue().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon16(this, arg));
	}

	
		
	
	public virtual void visit(BinaryExpr n, object arg)
	{
		n.getLeft().accept(this, arg);
		n.getRight().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon17(this, arg));
	}

	
		
	
	public virtual void visit(BlockComment n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon18(this, arg));
	}

	
		
	
	public virtual void visit(BlockStmt n, object arg)
	{
		n.getStatements().forEach(new ___003C_003EAnon19(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon20(this, arg));
	}

	
		
	
	public virtual void visit(BooleanLiteralExpr n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon21(this, arg));
	}

	
		
	
	public virtual void visit(BreakStmt n, object arg)
	{
		n.getLabel().ifPresent(new ___003C_003EAnon22(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon23(this, arg));
	}

	
		
	
	public virtual void visit(CastExpr n, object arg)
	{
		n.getExpression().accept(this, arg);
		n.getType().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon24(this, arg));
	}

	
		
	
	public virtual void visit(CatchClause n, object arg)
	{
		n.getBody().accept(this, arg);
		n.getParameter().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon25(this, arg));
	}

	
		
	
	public virtual void visit(CharLiteralExpr n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon26(this, arg));
	}

	
		
	
	public virtual void visit(ClassExpr n, object arg)
	{
		n.getType().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon27(this, arg));
	}

	
		
	
	public virtual void visit(ClassOrInterfaceDeclaration n, object arg)
	{
		n.getExtendedTypes().forEach(new ___003C_003EAnon28(this, arg));
		n.getImplementedTypes().forEach(new ___003C_003EAnon29(this, arg));
		n.getTypeParameters().forEach(new ___003C_003EAnon30(this, arg));
		n.getMembers().forEach(new ___003C_003EAnon31(this, arg));
		n.getModifiers().forEach(new ___003C_003EAnon32(this, arg));
		n.getName().accept(this, arg);
		n.getAnnotations().forEach(new ___003C_003EAnon33(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon34(this, arg));
	}

	
		
	
	public virtual void visit(ClassOrInterfaceType n, object arg)
	{
		n.getName().accept(this, arg);
		n.getScope().ifPresent(new ___003C_003EAnon35(this, arg));
		n.getTypeArguments().ifPresent(new ___003C_003EAnon36(this, arg));
		n.getAnnotations().forEach(new ___003C_003EAnon37(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon38(this, arg));
	}

	
		
	
	public virtual void visit(CompilationUnit n, object arg)
	{
		n.getImports().forEach(new ___003C_003EAnon39(this, arg));
		n.getModule().ifPresent(new ___003C_003EAnon40(this, arg));
		n.getPackageDeclaration().ifPresent(new ___003C_003EAnon41(this, arg));
		n.getTypes().forEach(new ___003C_003EAnon42(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon43(this, arg));
	}

	
		
	
	public virtual void visit(ConditionalExpr n, object arg)
	{
		n.getCondition().accept(this, arg);
		n.getElseExpr().accept(this, arg);
		n.getThenExpr().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon44(this, arg));
	}

	
		
	
	public virtual void visit(ConstructorDeclaration n, object arg)
	{
		n.getBody().accept(this, arg);
		n.getModifiers().forEach(new ___003C_003EAnon45(this, arg));
		n.getName().accept(this, arg);
		n.getParameters().forEach(new ___003C_003EAnon46(this, arg));
		n.getReceiverParameter().ifPresent(new ___003C_003EAnon47(this, arg));
		n.getThrownExceptions().forEach(new ___003C_003EAnon48(this, arg));
		n.getTypeParameters().forEach(new ___003C_003EAnon49(this, arg));
		n.getAnnotations().forEach(new ___003C_003EAnon50(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon51(this, arg));
	}

	
		
	
	public virtual void visit(ContinueStmt n, object arg)
	{
		n.getLabel().ifPresent(new ___003C_003EAnon52(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon53(this, arg));
	}

	
		
	
	public virtual void visit(DoStmt n, object arg)
	{
		n.getBody().accept(this, arg);
		n.getCondition().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon54(this, arg));
	}

	
		
	
	public virtual void visit(DoubleLiteralExpr n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon55(this, arg));
	}

	
		
	
	public virtual void visit(EmptyStmt n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon56(this, arg));
	}

	
		
	
	public virtual void visit(EnclosedExpr n, object arg)
	{
		n.getInner().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon57(this, arg));
	}

	
		
	
	public virtual void visit(EnumConstantDeclaration n, object arg)
	{
		n.getArguments().forEach(new ___003C_003EAnon58(this, arg));
		n.getClassBody().forEach(new ___003C_003EAnon59(this, arg));
		n.getName().accept(this, arg);
		n.getAnnotations().forEach(new ___003C_003EAnon60(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon61(this, arg));
	}

	
		
	
	public virtual void visit(EnumDeclaration n, object arg)
	{
		n.getEntries().forEach(new ___003C_003EAnon62(this, arg));
		n.getImplementedTypes().forEach(new ___003C_003EAnon63(this, arg));
		n.getMembers().forEach(new ___003C_003EAnon64(this, arg));
		n.getModifiers().forEach(new ___003C_003EAnon65(this, arg));
		n.getName().accept(this, arg);
		n.getAnnotations().forEach(new ___003C_003EAnon66(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon67(this, arg));
	}

	
		
	
	public virtual void visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		n.getArguments().forEach(new ___003C_003EAnon68(this, arg));
		n.getExpression().ifPresent(new ___003C_003EAnon69(this, arg));
		n.getTypeArguments().ifPresent(new ___003C_003EAnon70(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon71(this, arg));
	}

	
		
	
	public virtual void visit(ExpressionStmt n, object arg)
	{
		n.getExpression().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon72(this, arg));
	}

	
		
	
	public virtual void visit(FieldAccessExpr n, object arg)
	{
		n.getName().accept(this, arg);
		n.getScope().accept(this, arg);
		n.getTypeArguments().ifPresent(new ___003C_003EAnon73(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon74(this, arg));
	}

	
		
	
	public virtual void visit(FieldDeclaration n, object arg)
	{
		n.getModifiers().forEach(new ___003C_003EAnon75(this, arg));
		n.getVariables().forEach(new ___003C_003EAnon76(this, arg));
		n.getAnnotations().forEach(new ___003C_003EAnon77(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon78(this, arg));
	}

	
		
	
	public virtual void visit(ForEachStmt n, object arg)
	{
		n.getBody().accept(this, arg);
		n.getIterable().accept(this, arg);
		n.getVariable().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon79(this, arg));
	}

	
		
	
	public virtual void visit(ForStmt n, object arg)
	{
		n.getBody().accept(this, arg);
		n.getCompare().ifPresent(new ___003C_003EAnon80(this, arg));
		n.getInitialization().forEach(new ___003C_003EAnon81(this, arg));
		n.getUpdate().forEach(new ___003C_003EAnon82(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon83(this, arg));
	}

	
		
	
	public virtual void visit(IfStmt n, object arg)
	{
		n.getCondition().accept(this, arg);
		n.getElseStmt().ifPresent(new ___003C_003EAnon84(this, arg));
		n.getThenStmt().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon85(this, arg));
	}

	
		
	
	public virtual void visit(InitializerDeclaration n, object arg)
	{
		n.getBody().accept(this, arg);
		n.getAnnotations().forEach(new ___003C_003EAnon86(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon87(this, arg));
	}

	
		
	
	public virtual void visit(InstanceOfExpr n, object arg)
	{
		n.getExpression().accept(this, arg);
		n.getPattern().ifPresent(new ___003C_003EAnon88(this, arg));
		n.getType().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon89(this, arg));
	}

	
		
	
	public virtual void visit(IntegerLiteralExpr n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon90(this, arg));
	}

	
		
	
	public virtual void visit(JavadocComment n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon91(this, arg));
	}

	
		
	
	public virtual void visit(LabeledStmt n, object arg)
	{
		n.getLabel().accept(this, arg);
		n.getStatement().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon92(this, arg));
	}

	
		
	
	public virtual void visit(LineComment n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon93(this, arg));
	}

	
		
	
	public virtual void visit(LongLiteralExpr n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon94(this, arg));
	}

	
		
	
	public virtual void visit(MarkerAnnotationExpr n, object arg)
	{
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon95(this, arg));
	}

	
		
	
	public virtual void visit(MemberValuePair n, object arg)
	{
		n.getName().accept(this, arg);
		n.getValue().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon96(this, arg));
	}

	
		
	
	public virtual void visit(MethodCallExpr n, object arg)
	{
		n.getArguments().forEach(new ___003C_003EAnon97(this, arg));
		n.getName().accept(this, arg);
		n.getScope().ifPresent(new ___003C_003EAnon98(this, arg));
		n.getTypeArguments().ifPresent(new ___003C_003EAnon99(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon100(this, arg));
	}

	
		
	
	public virtual void visit(MethodDeclaration n, object arg)
	{
		n.getBody().ifPresent(new ___003C_003EAnon101(this, arg));
		n.getType().accept(this, arg);
		n.getModifiers().forEach(new ___003C_003EAnon102(this, arg));
		n.getName().accept(this, arg);
		n.getParameters().forEach(new ___003C_003EAnon103(this, arg));
		n.getReceiverParameter().ifPresent(new ___003C_003EAnon104(this, arg));
		n.getThrownExceptions().forEach(new ___003C_003EAnon105(this, arg));
		n.getTypeParameters().forEach(new ___003C_003EAnon106(this, arg));
		n.getAnnotations().forEach(new ___003C_003EAnon107(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon108(this, arg));
	}

	
		
	
	public virtual void visit(NameExpr n, object arg)
	{
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon109(this, arg));
	}

	
		
	
	public virtual void visit(NormalAnnotationExpr n, object arg)
	{
		n.getPairs().forEach(new ___003C_003EAnon110(this, arg));
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon111(this, arg));
	}

	
		
	
	public virtual void visit(NullLiteralExpr n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon112(this, arg));
	}

	
		
	
	public virtual void visit(ObjectCreationExpr n, object arg)
	{
		n.getAnonymousClassBody().ifPresent(new ___003C_003EAnon113(this, arg));
		n.getArguments().forEach(new ___003C_003EAnon114(this, arg));
		n.getScope().ifPresent(new ___003C_003EAnon115(this, arg));
		n.getType().accept(this, arg);
		n.getTypeArguments().ifPresent(new ___003C_003EAnon116(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon117(this, arg));
	}

	
		
	
	public virtual void visit(PackageDeclaration n, object arg)
	{
		n.getAnnotations().forEach(new ___003C_003EAnon118(this, arg));
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon119(this, arg));
	}

	
		
	
	public virtual void visit(Parameter n, object arg)
	{
		n.getAnnotations().forEach(new ___003C_003EAnon120(this, arg));
		n.getModifiers().forEach(new ___003C_003EAnon121(this, arg));
		n.getName().accept(this, arg);
		n.getType().accept(this, arg);
		n.getVarArgsAnnotations().forEach(new ___003C_003EAnon122(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon123(this, arg));
	}

	
		
	
	public virtual void visit(PrimitiveType n, object arg)
	{
		n.getAnnotations().forEach(new ___003C_003EAnon124(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon125(this, arg));
	}

	
		
	
	public virtual void visit(Name n, object arg)
	{
		n.getQualifier().ifPresent(new ___003C_003EAnon126(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon127(this, arg));
	}

	
		
	
	public virtual void visit(SimpleName n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon128(this, arg));
	}

	
		
	
	public virtual void visit(ArrayType n, object arg)
	{
		n.getComponentType().accept(this, arg);
		n.getAnnotations().forEach(new ___003C_003EAnon129(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon130(this, arg));
	}

	
		
	
	public virtual void visit(ArrayCreationLevel n, object arg)
	{
		n.getAnnotations().forEach(new ___003C_003EAnon131(this, arg));
		n.getDimension().ifPresent(new ___003C_003EAnon132(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon133(this, arg));
	}

	
		
	
	public virtual void visit(IntersectionType n, object arg)
	{
		n.getElements().forEach(new ___003C_003EAnon134(this, arg));
		n.getAnnotations().forEach(new ___003C_003EAnon135(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon136(this, arg));
	}

	
		
	
	public virtual void visit(UnionType n, object arg)
	{
		n.getElements().forEach(new ___003C_003EAnon137(this, arg));
		n.getAnnotations().forEach(new ___003C_003EAnon138(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon139(this, arg));
	}

	
		
	
	public virtual void visit(ReturnStmt n, object arg)
	{
		n.getExpression().ifPresent(new ___003C_003EAnon140(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon141(this, arg));
	}

	
		
	
	public virtual void visit(SingleMemberAnnotationExpr n, object arg)
	{
		n.getMemberValue().accept(this, arg);
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon142(this, arg));
	}

	
		
	
	public virtual void visit(StringLiteralExpr n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon143(this, arg));
	}

	
		
	
	public virtual void visit(SuperExpr n, object arg)
	{
		n.getTypeName().ifPresent(new ___003C_003EAnon144(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon145(this, arg));
	}

	
		
	
	public virtual void visit(SwitchEntry n, object arg)
	{
		n.getLabels().forEach(new ___003C_003EAnon146(this, arg));
		n.getStatements().forEach(new ___003C_003EAnon147(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon148(this, arg));
	}

	
		
	
	public virtual void visit(SwitchStmt n, object arg)
	{
		n.getEntries().forEach(new ___003C_003EAnon149(this, arg));
		n.getSelector().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon150(this, arg));
	}

	
		
	
	public virtual void visit(SynchronizedStmt n, object arg)
	{
		n.getBody().accept(this, arg);
		n.getExpression().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon151(this, arg));
	}

	
		
	
	public virtual void visit(ThisExpr n, object arg)
	{
		n.getTypeName().ifPresent(new ___003C_003EAnon152(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon153(this, arg));
	}

	
		
	
	public virtual void visit(ThrowStmt n, object arg)
	{
		n.getExpression().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon154(this, arg));
	}

	
		
	
	public virtual void visit(TryStmt n, object arg)
	{
		n.getCatchClauses().forEach(new ___003C_003EAnon155(this, arg));
		n.getFinallyBlock().ifPresent(new ___003C_003EAnon156(this, arg));
		n.getResources().forEach(new ___003C_003EAnon157(this, arg));
		n.getTryBlock().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon158(this, arg));
	}

	
		
	
	public virtual void visit(LocalClassDeclarationStmt n, object arg)
	{
		n.getClassDeclaration().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon159(this, arg));
	}

	
		
	
	public virtual void visit(LocalRecordDeclarationStmt n, object arg)
	{
		n.getRecordDeclaration().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon160(this, arg));
	}

	
		
	
	public virtual void visit(TypeParameter n, object arg)
	{
		n.getName().accept(this, arg);
		n.getTypeBound().forEach(new ___003C_003EAnon161(this, arg));
		n.getAnnotations().forEach(new ___003C_003EAnon162(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon163(this, arg));
	}

	
		
	
	public virtual void visit(UnaryExpr n, object arg)
	{
		n.getExpression().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon164(this, arg));
	}

	
		
	
	public virtual void visit(UnknownType n, object arg)
	{
		n.getAnnotations().forEach(new ___003C_003EAnon165(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon166(this, arg));
	}

	
		
	
	public virtual void visit(VariableDeclarationExpr n, object arg)
	{
		n.getAnnotations().forEach(new ___003C_003EAnon167(this, arg));
		n.getModifiers().forEach(new ___003C_003EAnon168(this, arg));
		n.getVariables().forEach(new ___003C_003EAnon169(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon170(this, arg));
	}

	
		
	
	public virtual void visit(VariableDeclarator n, object arg)
	{
		n.getInitializer().ifPresent(new ___003C_003EAnon171(this, arg));
		n.getName().accept(this, arg);
		n.getType().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon172(this, arg));
	}

	
		
	
	public virtual void visit(VoidType n, object arg)
	{
		n.getAnnotations().forEach(new ___003C_003EAnon173(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon174(this, arg));
	}

	
		
	
	public virtual void visit(WhileStmt n, object arg)
	{
		n.getBody().accept(this, arg);
		n.getCondition().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon175(this, arg));
	}

	
		
	
	public virtual void visit(WildcardType n, object arg)
	{
		n.getExtendedType().ifPresent(new ___003C_003EAnon176(this, arg));
		n.getSuperType().ifPresent(new ___003C_003EAnon177(this, arg));
		n.getAnnotations().forEach(new ___003C_003EAnon178(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon179(this, arg));
	}

	
		
	
	public virtual void visit(LambdaExpr n, object arg)
	{
		n.getBody().accept(this, arg);
		n.getParameters().forEach(new ___003C_003EAnon180(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon181(this, arg));
	}

	
		
	
	public virtual void visit(MethodReferenceExpr n, object arg)
	{
		n.getScope().accept(this, arg);
		n.getTypeArguments().ifPresent(new ___003C_003EAnon182(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon183(this, arg));
	}

	
		
	
	public virtual void visit(TypeExpr n, object arg)
	{
		n.getType().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon184(this, arg));
	}

	
		
	
	public virtual void visit(NodeList n, object arg)
	{
		Iterator iterator = n.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			((Node)obj).accept(this, arg);
		}
	}

	
		
	
	public virtual void visit(ImportDeclaration n, object arg)
	{
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon185(this, arg));
	}

	
		
	
	public virtual void visit(ModuleDeclaration n, object arg)
	{
		n.getAnnotations().forEach(new ___003C_003EAnon186(this, arg));
		n.getDirectives().forEach(new ___003C_003EAnon187(this, arg));
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon188(this, arg));
	}

	
		
	
	public virtual void visit(ModuleRequiresDirective n, object arg)
	{
		n.getModifiers().forEach(new ___003C_003EAnon189(this, arg));
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon190(this, arg));
	}

	
		
	
	public virtual void visit(ModuleExportsDirective n, object arg)
	{
		n.getModuleNames().forEach(new ___003C_003EAnon191(this, arg));
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon192(this, arg));
	}

	
		
	
	public virtual void visit(ModuleProvidesDirective n, object arg)
	{
		n.getName().accept(this, arg);
		n.getWith().forEach(new ___003C_003EAnon193(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon194(this, arg));
	}

	
		
	
	public virtual void visit(ModuleUsesDirective n, object arg)
	{
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon195(this, arg));
	}

	
		
	
	public virtual void visit(ModuleOpensDirective n, object arg)
	{
		n.getModuleNames().forEach(new ___003C_003EAnon196(this, arg));
		n.getName().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon197(this, arg));
	}

	
		
	
	public virtual void visit(UnparsableStmt n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon198(this, arg));
	}

	
		
	
	public virtual void visit(ReceiverParameter n, object arg)
	{
		n.getAnnotations().forEach(new ___003C_003EAnon199(this, arg));
		n.getName().accept(this, arg);
		n.getType().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon200(this, arg));
	}

	
		
	
	public virtual void visit(VarType n, object arg)
	{
		n.getAnnotations().forEach(new ___003C_003EAnon201(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon202(this, arg));
	}

	
		
	
	public virtual void visit(Modifier n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon203(this, arg));
	}

	
		
	
	public virtual void visit(SwitchExpr n, object arg)
	{
		n.getEntries().forEach(new ___003C_003EAnon204(this, arg));
		n.getSelector().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon205(this, arg));
	}

	
		
	
	public virtual void visit(TextBlockLiteralExpr n, object arg)
	{
		n.getComment().ifPresent(new ___003C_003EAnon206(this, arg));
	}

	
		
	
	public virtual void visit(YieldStmt n, object arg)
	{
		n.getExpression().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon207(this, arg));
	}

	
		
	
	public virtual void visit(PatternExpr n, object arg)
	{
		n.getName().accept(this, arg);
		n.getType().accept(this, arg);
		n.getComment().ifPresent(new ___003C_003EAnon208(this, arg));
	}

	
		
	
	public virtual void visit(RecordDeclaration n, object arg)
	{
		n.getImplementedTypes().forEach(new ___003C_003EAnon209(this, arg));
		n.getParameters().forEach(new ___003C_003EAnon210(this, arg));
		n.getReceiverParameter().ifPresent(new ___003C_003EAnon211(this, arg));
		n.getTypeParameters().forEach(new ___003C_003EAnon212(this, arg));
		n.getMembers().forEach(new ___003C_003EAnon213(this, arg));
		n.getModifiers().forEach(new ___003C_003EAnon214(this, arg));
		n.getName().accept(this, arg);
		n.getAnnotations().forEach(new ___003C_003EAnon215(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon216(this, arg));
	}

	
		
	
	public virtual void visit(CompactConstructorDeclaration n, object arg)
	{
		n.getBody().accept(this, arg);
		n.getModifiers().forEach(new ___003C_003EAnon217(this, arg));
		n.getName().accept(this, arg);
		n.getThrownExceptions().forEach(new ___003C_003EAnon218(this, arg));
		n.getTypeParameters().forEach(new ___003C_003EAnon219(this, arg));
		n.getAnnotations().forEach(new ___003C_003EAnon220(this, arg));
		n.getComment().ifPresent(new ___003C_003EAnon221(this, arg));
	}
}
