using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.validator.language_level_validations.chunks;


public class VarValidator: TypedValidator, BiConsumer
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Optional parentNode = ((Parameter)P_0).getParentNode();
			
			return parentNode;
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
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Boolean result = lambda_0024accept_00240((Node)P_0);
			
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
		private readonly VarValidator arg_00241;

		private readonly ProblemReporter arg_00242;

		private readonly VarType arg_00243;

		internal ___003C_003EAnon2(VarValidator P_0, ProblemReporter P_1, VarType P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024accept_00244(arg_00242, arg_00243, (VariableDeclarator)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly VarValidator arg_00241;

		private readonly VarType arg_00242;

		private readonly ProblemReporter arg_00243;

		private readonly VariableDeclarator arg_00244;

		internal ___003C_003EAnon3(VarValidator P_0, VarType P_1, ProblemReporter P_2, VariableDeclarator P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_00243(arg_00242, arg_00243, arg_00244, (Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly VarValidator arg_00241;

		private readonly VarType arg_00242;

		private readonly ProblemReporter arg_00243;

		private readonly VariableDeclarator arg_00244;

		internal ___003C_003EAnon4(VarValidator P_0, VarType P_1, ProblemReporter P_2, VariableDeclarator P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_00242(arg_00242, arg_00243, arg_00244, (Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Consumer
	{
		private readonly ProblemReporter arg_00241;

		private readonly VarType arg_00242;

		internal ___003C_003EAnon5(ProblemReporter P_0, VarType P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024null_00241(arg_00241, arg_00242, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	private bool varAllowedInLambdaParameters;

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private void reportIllegalPosition(VarType n, ProblemReporter reporter)
	{
		reporter.report(n, "\"var\" is not allowed here.");
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		1, 117, 136, 104, 111, 111, 111, 123, 99, 161,
		106, 129, 245, 112
	})]
	public virtual void accept(VarType node, ProblemReporter reporter)
	{
		Optional optional = node.findAncestor(new Class[1] { ClassLiteral<VariableDeclarator>.Value });
		if (!optional.isPresent())
		{
			if (!varAllowedInLambdaParameters || !((Boolean)node.findAncestor(new Class[1] { ClassLiteral<Parameter>.Value }).flatMap(new ___003C_003EAnon0()).map(new ___003C_003EAnon1())
				.orElse(Boolean.valueOf(b: false))).booleanValue())
			{
				reportIllegalPosition(node, reporter);
			}
		}
		else
		{
			optional.ifPresent(new ___003C_003EAnon2(this, reporter, node));
		}
	}

	
	
	
	
	private static Boolean lambda_0024accept_00240(Node p)
	{
		Boolean result = Boolean.valueOf(p is LambdaExpr);
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024accept_00244(ProblemReporter reporter, VarType node, VariableDeclarator vd)
	{
		if (vd.getType().isArrayType())
		{
			reporter.report(vd, "\"var\" cannot have extra array brackets.");
		}
		Optional parentNode = vd.getParentNode();
		if (!parentNode.isPresent())
		{
			reportIllegalPosition(node, reporter);
		}
		else
		{
			parentNode.ifPresent(new ___003C_003EAnon3(this, node, reporter, vd));
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	[LineNumberTable(new byte[]
	{
		26, 105, 106, 129, 104, 110, 146, 104, 104, 106,
		129, 246, 86
	})]
	private void lambda_0024null_00243(VarType node, ProblemReporter reporter, VariableDeclarator vd, Node vdeNode)
	{
		if (!(vdeNode is VariableDeclarationExpr))
		{
			reportIllegalPosition(node, reporter);
			return;
		}
		VariableDeclarationExpr variableDeclarationExpr = (VariableDeclarationExpr)vdeNode;
		if (variableDeclarationExpr.getVariables().size() > 1)
		{
			reporter.report(variableDeclarationExpr, "\"var\" only takes a single variable.");
		}
		Optional parentNode = vdeNode.getParentNode();
		if (!parentNode.isPresent())
		{
			reportIllegalPosition(node, reporter);
		}
		else
		{
			parentNode.ifPresent(new ___003C_003EAnon4(this, node, reporter, vd));
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024null_00242(VarType node, ProblemReporter reporter, VariableDeclarator vd, Node c)
	{
		if ((!(c is ForStmt) && !(c is ForEachStmt) && !(c is ExpressionStmt) && !(c is TryStmt)) || 1 == 0)
		{
			reportIllegalPosition(node, reporter);
		}
		if (c is ExpressionStmt)
		{
			if (!vd.getInitializer().isPresent())
			{
				reporter.report(node, "\"var\" needs an initializer.");
			}
			vd.getInitializer().ifPresent(new ___003C_003EAnon5(reporter, node));
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024null_00241(ProblemReporter reporter, VarType node, Expression initializer)
	{
		if (initializer is NullLiteralExpr)
		{
			reporter.report(node, "\"var\" cannot infer type from just null.");
		}
		if (initializer is ArrayInitializerExpr)
		{
			reporter.report(node, "\"var\" cannot infer array types.");
		}
	}

	
	
	
	public VarValidator(bool varAllowedInLambdaParameters)
	{
		this.varAllowedInLambdaParameters = varAllowedInLambdaParameters;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void accept(Node node, ProblemReporter reporter)
	{
		accept((VarType)node, reporter);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void accept(object node, object reporter)
	{
		accept((VarType)node, (ProblemReporter)reporter);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BiConsumer andThen(BiConsumer P_0)
	{
		return BiConsumer._003Cdefault_003EandThen(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Processor processor()
	{
		return TypedValidator._003Cdefault_003Eprocessor(this);
	}
}
