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

public abstract class GenericListVisitorAdapter : GenericVisitor
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = Objects.nonNull((Node)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly GenericListVisitorAdapter arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon1(GenericListVisitorAdapter P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Stream result = arg_00241.lambda_0024visit_00240(arg_00242, (Node)P_0);
			
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

	
		
	
	public virtual List visit(PatternExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(TextBlockLiteralExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(YieldStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getExpression().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(SwitchExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getEntries().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getSelector().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(Modifier n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(VarType n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ReceiverParameter n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(UnparsableStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ModuleOpensDirective n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getModuleNames().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ModuleUsesDirective n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ModuleProvidesDirective n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getWith().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ModuleExportsDirective n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getModuleNames().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ModuleRequiresDirective n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ModuleDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getDirectives().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ImportDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(SimpleName n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(Name n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getQualifier().isPresent())
		{
			List list = (List)((Name)n.getQualifier().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(NodeList n, object arg)
	{
		return (List)n.stream().filter(new ___003C_003EAnon0()).flatMap(new ___003C_003EAnon1(this, arg))
			.collect(Collectors.toList());
	}

	
		
	
	public virtual List visit(TypeExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(MethodReferenceExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getScope().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getTypeArguments().isPresent())
		{
			list = (List)((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(LambdaExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getBody().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getParameters().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(CatchClause n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getBody().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getParameter().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(TryStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getCatchClauses().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getFinallyBlock().isPresent())
		{
			list = (List)((BlockStmt)n.getFinallyBlock().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getResources().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getTryBlock().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(SynchronizedStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getBody().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getExpression().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ThrowStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getExpression().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ForStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getBody().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getCompare().isPresent())
		{
			list = (List)((Expression)n.getCompare().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getInitialization().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getUpdate().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ForEachStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getBody().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getIterable().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getVariable().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(DoStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getBody().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getCondition().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ContinueStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getLabel().isPresent())
		{
			List list = (List)((SimpleName)n.getLabel().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(WhileStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getBody().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getCondition().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(IfStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getCondition().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getElseStmt().isPresent())
		{
			list = (List)((Statement)n.getElseStmt().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getThenStmt().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ReturnStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getExpression().isPresent())
		{
			List list = (List)((Expression)n.getExpression().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(BreakStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getLabel().isPresent())
		{
			List list = (List)((SimpleName)n.getLabel().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(SwitchEntry n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getLabels().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getStatements().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(SwitchStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getEntries().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getSelector().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ExpressionStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getExpression().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(EmptyStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(LabeledStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getLabel().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getStatement().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(BlockStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getStatements().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(AssertStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getCheck().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getMessage().isPresent())
		{
			list = (List)((Expression)n.getMessage().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(LocalRecordDeclarationStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getRecordDeclaration().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(LocalClassDeclarationStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getClassDeclaration().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getArguments().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getExpression().isPresent())
		{
			list = (List)((Expression)n.getExpression().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getTypeArguments().isPresent())
		{
			list = (List)((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(MemberValuePair n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getValue().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(NormalAnnotationExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getPairs().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(SingleMemberAnnotationExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getMemberValue().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(MarkerAnnotationExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(VariableDeclarationExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getVariables().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(UnaryExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getExpression().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(SuperExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getTypeName().isPresent())
		{
			List list = (List)((Name)n.getTypeName().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ThisExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getTypeName().isPresent())
		{
			List list = (List)((Name)n.getTypeName().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ObjectCreationExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list;
		if (n.getAnonymousClassBody().isPresent())
		{
			list = (List)((NodeList)n.getAnonymousClassBody().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getArguments().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getScope().isPresent())
		{
			list = (List)((Expression)n.getScope().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getTypeArguments().isPresent())
		{
			list = (List)((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(NameExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(MethodCallExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getArguments().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getScope().isPresent())
		{
			list = (List)((Expression)n.getScope().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getTypeArguments().isPresent())
		{
			list = (List)((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(NullLiteralExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(BooleanLiteralExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(DoubleLiteralExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(CharLiteralExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(LongLiteralExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(IntegerLiteralExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(StringLiteralExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(InstanceOfExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getExpression().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getPattern().isPresent())
		{
			list = (List)((PatternExpr)n.getPattern().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(FieldAccessExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getScope().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getTypeArguments().isPresent())
		{
			list = (List)((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(EnclosedExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getInner().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ConditionalExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getCondition().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getElseExpr().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getThenExpr().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ClassExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(CastExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getExpression().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(BinaryExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getLeft().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getRight().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(AssignExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getTarget().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getValue().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ArrayInitializerExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getValues().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ArrayCreationExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getElementType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getInitializer().isPresent())
		{
			list = (List)((ArrayInitializerExpr)n.getInitializer().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getLevels().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ArrayAccessExpr n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getIndex().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(UnknownType n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(WildcardType n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list;
		if (n.getExtendedType().isPresent())
		{
			list = (List)((ReferenceType)n.getExtendedType().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getSuperType().isPresent())
		{
			list = (List)((ReferenceType)n.getSuperType().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(VoidType n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(UnionType n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getElements().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(IntersectionType n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getElements().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ArrayCreationLevel n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getDimension().isPresent())
		{
			list = (List)((Expression)n.getDimension().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ArrayType n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getComponentType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(PrimitiveType n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ClassOrInterfaceType n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getScope().isPresent())
		{
			list = (List)((ClassOrInterfaceType)n.getScope().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getTypeArguments().isPresent())
		{
			list = (List)((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(JavadocComment n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(InitializerDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getBody().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(Parameter n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getVarArgsAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(MethodDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list;
		if (n.getBody().isPresent())
		{
			list = (List)((BlockStmt)n.getBody().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getParameters().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getReceiverParameter().isPresent())
		{
			list = (List)((ReceiverParameter)n.getReceiverParameter().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getThrownExceptions().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getTypeParameters().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ConstructorDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getBody().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getParameters().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getReceiverParameter().isPresent())
		{
			list = (List)((ReceiverParameter)n.getReceiverParameter().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getThrownExceptions().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getTypeParameters().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(VariableDeclarator n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list;
		if (n.getInitializer().isPresent())
		{
			list = (List)((Expression)n.getInitializer().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(FieldDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getVariables().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(AnnotationMemberDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list;
		if (n.getDefaultValue().isPresent())
		{
			list = (List)((Expression)n.getDefaultValue().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getType().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(AnnotationDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getMembers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(EnumConstantDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getArguments().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getClassBody().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(EnumDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getEntries().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getImplementedTypes().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getMembers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(CompactConstructorDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getBody().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getThrownExceptions().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getTypeParameters().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(RecordDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getImplementedTypes().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getParameters().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getReceiverParameter().isPresent())
		{
			list = (List)((ReceiverParameter)n.getReceiverParameter().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getTypeParameters().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getMembers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(ClassOrInterfaceDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getExtendedTypes().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getImplementedTypes().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getTypeParameters().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getMembers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getModifiers().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(BlockComment n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(LineComment n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		if (n.getComment().isPresent())
		{
			List list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(TypeParameter n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getTypeBound().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(PackageDeclaration n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getAnnotations().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		list = (List)n.getName().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
		
	
	public virtual List visit(CompilationUnit n, object arg)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)n.getImports().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getModule().isPresent())
		{
			list = (List)((ModuleDeclaration)n.getModule().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		if (n.getPackageDeclaration().isPresent())
		{
			list = (List)((PackageDeclaration)n.getPackageDeclaration().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		list = (List)n.getTypes().accept(this, arg);
		if (list != null)
		{
			((List)arrayList).addAll((Collection)list);
		}
		if (n.getComment().isPresent())
		{
			list = (List)((Comment)n.getComment().get()).accept(this, arg);
			if (list != null)
			{
				((List)arrayList).addAll((Collection)list);
			}
		}
		return arrayList;
	}

	
	
	
	
	private Stream lambda_0024visit_00240(object arg, Node v)
	{
		Stream result = ((List)v.accept(this, arg)).stream();
		
		return result;
	}

	
	
	public GenericListVisitorAdapter()
	{
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(PatternExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(TextBlockLiteralExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(YieldStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SwitchExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(Modifier n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(VarType n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ReceiverParameter n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(UnparsableStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleOpensDirective n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleUsesDirective n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleProvidesDirective n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleExportsDirective n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleRequiresDirective n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ModuleDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ImportDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SimpleName n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(Name n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(NodeList n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(TypeExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(MethodReferenceExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LambdaExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(CatchClause n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(TryStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SynchronizedStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ThrowStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ForStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ForEachStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(DoStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ContinueStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(WhileStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(IfStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ReturnStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(BreakStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SwitchEntry n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SwitchStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ExpressionStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(EmptyStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LabeledStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(BlockStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(AssertStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LocalRecordDeclarationStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LocalClassDeclarationStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ExplicitConstructorInvocationStmt n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(MemberValuePair n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(NormalAnnotationExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SingleMemberAnnotationExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(MarkerAnnotationExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(VariableDeclarationExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(UnaryExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(SuperExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ThisExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ObjectCreationExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(NameExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(MethodCallExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(NullLiteralExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(BooleanLiteralExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(DoubleLiteralExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(CharLiteralExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LongLiteralExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(IntegerLiteralExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(StringLiteralExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(InstanceOfExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(FieldAccessExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(EnclosedExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ConditionalExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ClassExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(CastExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(BinaryExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(AssignExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ArrayInitializerExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ArrayCreationExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ArrayAccessExpr n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(UnknownType n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(WildcardType n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(VoidType n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(UnionType n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(IntersectionType n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ArrayCreationLevel n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ArrayType n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(PrimitiveType n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ClassOrInterfaceType n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(JavadocComment n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(InitializerDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(Parameter n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(MethodDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ConstructorDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(VariableDeclarator n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(FieldDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(AnnotationMemberDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(AnnotationDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(EnumConstantDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(EnumDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(CompactConstructorDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(RecordDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(ClassOrInterfaceDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(BlockComment n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(LineComment n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(TypeParameter n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(PackageDeclaration n, object arg)
	{
		List result = visit(n, arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Evisit(CompilationUnit n, object arg)
	{
		List result = visit(n, arg);
		
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
