
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.model.resolution;

using ikvm.@internal;
using java.lang;
using java.util.function;

namespace com.github.javaparser.symbolsolver.resolution.naming;

public class NameLogic
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Interface | Modifiers.Abstract)]
		internal interface PredicateOnParentAndChild
	{
				virtual bool isSatisfied(Node P_0, Node P_1);
	}

	
	private sealed class ___003C_003EAnon0 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_00240((Name)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_00241((PackageDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon2()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_00242((ImportDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon3()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_00243((MarkerAnnotationExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon4()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_00244((ClassOrInterfaceDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon5()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_00245((ClassOrInterfaceDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon6 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon6()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_00246((ClassOrInterfaceType)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon7 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon7()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_00247((VariableDeclarator)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon8 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon8()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_00248((NameExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon9 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon9()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_00249((FieldAccessExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon10 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon10()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002410((MethodDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon11 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon11()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002411((Parameter)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon12 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon12()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002412((MethodCallExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon13 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon13()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002413((ConstructorDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon14 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon14()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002414((AnnotationDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon15 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon15()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002415((AnnotationMemberDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon16 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon16()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002416((AnnotationMemberDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon17 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon17()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002417((MethodDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon18 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon18()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002418((MethodDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon19 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon19()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002419((Parameter)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon20 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon20()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002420((Parameter)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon21 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon21()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002421((PatternExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon22 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon22()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002422((PatternExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon23 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon23()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002423((ReceiverParameter)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon24 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon24()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002424((MethodCallExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon25 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon25()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002425((ConstructorDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon26 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon26()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002426((TypeParameter)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon27 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon27()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002427((EnumDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon28 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon28()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002428((EnumConstantDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon29 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon29()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002429((FieldAccessExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon30 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon30()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002430((ObjectCreationExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon31 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon31()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002431((ReturnStmt)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon32 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon32()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002432((ModuleDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon33 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon33()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002433((ModuleRequiresDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon34 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon34()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002434((ModuleExportsDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon35 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon35()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002435((ModuleExportsDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon36 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon36()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002436((ModuleOpensDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon37 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon37()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002437((ModuleOpensDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon38 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon38()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002438((ModuleUsesDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon39 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon39()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002439((ModuleProvidesDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon40 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon40()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002440((ClassExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon41 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon41()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002441((ThisExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon42 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon42()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002442((SuperExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon43 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon43()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002443((VariableDeclarator)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon44 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon44()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002444((VariableDeclarator)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon45 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon45()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002445((ArrayCreationExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon46 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon46()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002446((CastExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon47 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon47()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002447((InstanceOfExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon48 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon48()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002448((TypeExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon49 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon49()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002449((ArrayAccessExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon50 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon50()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002450((UnaryExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon51 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon51()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002451((AssignExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon52 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon52()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002452((TryStmt)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon53 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon53()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002453((VariableDeclarator)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon54 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon54()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002454((VariableDeclarator)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon55 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon55()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002455((VariableDeclarator)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon56 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon56()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002456((MemberValuePair)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon57 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon57()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002457((MemberValuePair)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon58 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon58()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002458((ExplicitConstructorInvocationStmt)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon59 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon59()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024classifyRole_002459((ObjectCreationExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon60 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon60(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024reclassificationOfContextuallyAmbiguousQualifiedAmbiguousName_002460(arg_00241, (MethodUsage)P_0);
			
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

	
	private sealed class ___003C_003EAnon61 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon61(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024reclassificationOfContextuallyAmbiguousQualifiedAmbiguousName_002461(arg_00241, (ResolvedFieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon62 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon62()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAAmbiguousName_002462((FieldAccessExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon63 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon63()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAAmbiguousName_002463((MethodCallExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon64 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon64()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAAmbiguousName_002464((MemberValuePair)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon65 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon65()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAPackageOrTypeName_002465((ClassOrInterfaceType)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon66 : PredicateOnParentAndChild
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon66(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAPackageOrTypeName_002466(arg_00241, (ImportDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon67 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon67()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAMethodName_002467((MethodCallExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon68 : PredicateOnParentAndChild
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon68(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAModuleName_002468(arg_00241, (ModuleRequiresDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon69 : PredicateOnParentAndChild
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon69(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAModuleName_002469(arg_00241, (ModuleExportsDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon70 : PredicateOnParentAndChild
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon70(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAModuleName_002470(arg_00241, (ModuleOpensDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon71 : PredicateOnParentAndChild
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon71(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAPackageName_002471(arg_00241, (ModuleExportsDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon72 : PredicateOnParentAndChild
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon72(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAPackageName_002472(arg_00241, (ModuleOpensDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon73 : PredicateOnParentAndChild
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon73(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAPackageName_002473(arg_00241, (Name)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon74 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon74()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002474((ModuleUsesDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon75 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon75()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002475((ModuleProvidesDirective)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon76 : PredicateOnParentAndChild
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon76(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002476(arg_00241, (ImportDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon77 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon77()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002478((Name)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon78 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon78()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002479((ImportDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon79 : PredicateOnParentAndChild
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon79(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002480(arg_00241, (ImportDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon80 : PredicateOnParentAndChild
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon80(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002481(arg_00241, (ConstructorDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon81 : PredicateOnParentAndChild
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon81(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002482(arg_00241, (AnnotationExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon82 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon82()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002483((ClassExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon83 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon83()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002484((ThisExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon84 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon84()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002485((SuperExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon85 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon85()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002486((ClassOrInterfaceDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon86 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon86()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002487((MethodDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon87 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon87()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002488((AnnotationMemberDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon88 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon88()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002489((MethodDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon89 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon89()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002490((ConstructorDeclaration)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon90 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon90()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002492((VariableDeclarator)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon91 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon91()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002493((Parameter)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon92 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon92()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002494((ReceiverParameter)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon93 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon93()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002496((VariableDeclarator)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon94 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon94()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002497((ClassOrInterfaceType)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon95 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon95()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002498((MethodCallExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon96 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon96()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_002499((ObjectCreationExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon97 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon97()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_0024100((ArrayCreationExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon98 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon98()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_0024101((CastExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon99 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon99()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_0024102((InstanceOfExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon100 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon100()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyATypeName_0024104((TypeExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon101 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon101()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024106((NameExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon102 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon102()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024107((ExplicitConstructorInvocationStmt)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon103 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon103()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024109((NameExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon104 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon104()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024110((ObjectCreationExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon105 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon105()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024112((NameExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon106 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon106()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024113((ArrayAccessExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon107 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon107()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024115((NameExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon108 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon108()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024116((UnaryExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon109 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon109()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024118((NameExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon110 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon110()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024119((AssignExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon111 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon111()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024121((NameExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon112 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon112()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024125((NameExpr)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon113 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon113()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024126((TryStmt)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon114 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon114()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024isSyntacticallyAnExpressionName_0024129((VariableDeclarator)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon115 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon115()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024whenParentIs_0024130(P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon116 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon116()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024128((VariableDeclarationExpr)P_0, (VariableDeclarator)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon117 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon117()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024127((TryStmt)P_0, (VariableDeclarationExpr)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon118 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon118()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024124((VariableDeclarator)P_0, (NameExpr)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon119 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon119()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024123((VariableDeclarationExpr)P_0, (VariableDeclarator)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon120 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon120()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024122((TryStmt)P_0, (VariableDeclarationExpr)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon121 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon121()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024120((TryStmt)P_0, (NameExpr)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon122 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon122()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024117((AssignExpr)P_0, (NameExpr)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon123 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon123()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024114((UnaryExpr)P_0, (NameExpr)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon124 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon124()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024111((ArrayAccessExpr)P_0, (NameExpr)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon125 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon125()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024108((ObjectCreationExpr)P_0, (NameExpr)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon126 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon126()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024105((ExplicitConstructorInvocationStmt)P_0, (NameExpr)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon127 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon127()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_0024103((MethodReferenceExpr)P_0, (TypeExpr)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon128 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon128()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_002495((VariableDeclarationExpr)P_0, (VariableDeclarator)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon129 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon129()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_002491((FieldDeclaration)P_0, (VariableDeclarator)P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon130 : PredicateOnParentAndChild
	{
		internal ___003C_003EAnon130()
		{
		}

		public bool isSatisfied(Node P_0, Node P_1)
		{
			bool result = lambda_0024null_002477((ImportDeclaration)P_0, (Name)P_1);
			
			return result;
		}
	}

	
	internal static bool _0024assertionsDisabled;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public static bool isQualifiedName(Node node)
	{
		if (!isAName(node))
		{
			
			throw new IllegalArgumentException();
		}
		string @this = nameAsString(node);
		CharSequence s = default(CharSequence);
		object obj = (s.___003Cref_003E = ".");
		bool result = String.instancehelper_contains(@this, s);
		
		return result;
	}

	
	
	public static bool isAName(Node node)
	{
		if (node is FieldAccessExpr)
		{
			FieldAccessExpr fieldAccessExpr = (FieldAccessExpr)node;
			bool result = isAName(fieldAccessExpr.getScope());
			
			return result;
		}
		return (node is SimpleName || node is Name || node is ClassOrInterfaceType || node is NameExpr) ? true : false;
	}

	
	
	public static string nameAsString(Node name)
	{
		if (!isAName(name))
		{
			
			throw new IllegalArgumentException("A name was expected");
		}
		if (name is Name)
		{
			string result = ((Name)name).asString();
			
			return result;
		}
		if (name is SimpleName)
		{
			string identifier = ((SimpleName)name).getIdentifier();
			
			return identifier;
		}
		if (name is ClassOrInterfaceType)
		{
			string result2 = ((ClassOrInterfaceType)name).asString();
			
			return result2;
		}
		if (name is FieldAccessExpr)
		{
			FieldAccessExpr fieldAccessExpr = (FieldAccessExpr)name;
			if (isAName(fieldAccessExpr.getScope()))
			{
				string result3 = new StringBuilder().append(nameAsString(fieldAccessExpr.getScope())).append(".").append(nameAsString(fieldAccessExpr.getName()))
					.ToString();
				
				return result3;
			}
			
			throw new IllegalArgumentException();
		}
		if (name is NameExpr)
		{
			string result4 = ((NameExpr)name).getNameAsString();
			
			return result4;
		}
		string message = new StringBuilder().append("Unknown type of name found: ").append(name).append(" (")
			.append(Object.instancehelper_getClass(name).getCanonicalName())
			.append(")")
			.ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
		
	private static bool whenParentIs(Class P_0, Node P_1, PredicateOnParentAndChild P_2)
	{
		if (P_1.getParentNode().isPresent())
		{
			Node obj = (Node)P_1.getParentNode().get();
			return (P_0.isInstance(obj) && P_2.isSatisfied((Node)P_0.cast(obj), P_1)) ? true : false;
		}
		return false;
	}

	
	
	public static NameRole classifyRole(Node name)
	{
		if (!isAName(name))
		{
			
			throw new IllegalArgumentException("The given node is not a name");
		}
		if (!name.getParentNode().isPresent())
		{
			
			throw new IllegalArgumentException("We cannot understand the role of a name if it has no parent");
		}
		if (whenParentIs(ClassLiteral<Name>.Value, name, new ___003C_003EAnon0()))
		{
			NameRole result = classifyRole((Node)name.getParentNode().get());
			
			return result;
		}
		if (whenParentIs(ClassLiteral<PackageDeclaration>.Value, name, new ___003C_003EAnon1()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<ImportDeclaration>.Value, name, new ___003C_003EAnon2()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<MarkerAnnotationExpr>.Value, name, new ___003C_003EAnon3()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ClassOrInterfaceDeclaration>.Value, name, new ___003C_003EAnon4()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<ClassOrInterfaceDeclaration>.Value, name, new ___003C_003EAnon5()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ClassOrInterfaceType>.Value, name, new ___003C_003EAnon6()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<VariableDeclarator>.Value, name, new ___003C_003EAnon7()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<NameExpr>.Value, name, new ___003C_003EAnon8()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<FieldAccessExpr>.Value, name, new ___003C_003EAnon9()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<MethodDeclaration>.Value, name, new ___003C_003EAnon10()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<Parameter>.Value, name, new ___003C_003EAnon11()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<MethodCallExpr>.Value, name, new ___003C_003EAnon12()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ConstructorDeclaration>.Value, name, new ___003C_003EAnon13()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<AnnotationDeclaration>.Value, name, new ___003C_003EAnon14()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<AnnotationMemberDeclaration>.Value, name, new ___003C_003EAnon15()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<AnnotationMemberDeclaration>.Value, name, new ___003C_003EAnon16()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<MethodDeclaration>.Value, name, new ___003C_003EAnon17()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<MethodDeclaration>.Value, name, new ___003C_003EAnon18()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<Parameter>.Value, name, new ___003C_003EAnon19()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<Parameter>.Value, name, new ___003C_003EAnon20()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<PatternExpr>.Value, name, new ___003C_003EAnon21()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<PatternExpr>.Value, name, new ___003C_003EAnon22()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ReceiverParameter>.Value, name, new ___003C_003EAnon23()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<MethodCallExpr>.Value, name, new ___003C_003EAnon24()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ConstructorDeclaration>.Value, name, new ___003C_003EAnon25()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<TypeParameter>.Value, name, new ___003C_003EAnon26()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<EnumDeclaration>.Value, name, new ___003C_003EAnon27()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<EnumConstantDeclaration>.Value, name, new ___003C_003EAnon28()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<FieldAccessExpr>.Value, name, new ___003C_003EAnon29()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ObjectCreationExpr>.Value, name, new ___003C_003EAnon30()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ReturnStmt>.Value, name, new ___003C_003EAnon31()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ModuleDeclaration>.Value, name, new ___003C_003EAnon32()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<ModuleRequiresDirective>.Value, name, new ___003C_003EAnon33()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ModuleExportsDirective>.Value, name, new ___003C_003EAnon34()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ModuleExportsDirective>.Value, name, new ___003C_003EAnon35()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ModuleOpensDirective>.Value, name, new ___003C_003EAnon36()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ModuleOpensDirective>.Value, name, new ___003C_003EAnon37()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ModuleUsesDirective>.Value, name, new ___003C_003EAnon38()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ModuleProvidesDirective>.Value, name, new ___003C_003EAnon39()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ClassExpr>.Value, name, new ___003C_003EAnon40()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ThisExpr>.Value, name, new ___003C_003EAnon41()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<SuperExpr>.Value, name, new ___003C_003EAnon42()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<VariableDeclarator>.Value, name, new ___003C_003EAnon43()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<VariableDeclarator>.Value, name, new ___003C_003EAnon44()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ArrayCreationExpr>.Value, name, new ___003C_003EAnon45()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<CastExpr>.Value, name, new ___003C_003EAnon46()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<InstanceOfExpr>.Value, name, new ___003C_003EAnon47()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<TypeExpr>.Value, name, new ___003C_003EAnon48()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ArrayAccessExpr>.Value, name, new ___003C_003EAnon49()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<UnaryExpr>.Value, name, new ___003C_003EAnon50()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<AssignExpr>.Value, name, new ___003C_003EAnon51()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<TryStmt>.Value, name, new ___003C_003EAnon52()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<VariableDeclarator>.Value, name, new ___003C_003EAnon53()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<VariableDeclarator>.Value, name, new ___003C_003EAnon54()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<VariableDeclarator>.Value, name, new ___003C_003EAnon55()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<MemberValuePair>.Value, name, new ___003C_003EAnon56()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<MemberValuePair>.Value, name, new ___003C_003EAnon57()))
		{
			return NameRole.___003C_003EDECLARATION;
		}
		if (whenParentIs(ClassLiteral<ExplicitConstructorInvocationStmt>.Value, name, new ___003C_003EAnon58()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (whenParentIs(ClassLiteral<ObjectCreationExpr>.Value, name, new ___003C_003EAnon59()))
		{
			return NameRole.___003C_003EREFERENCE;
		}
		if (name.getParentNode().isPresent() && isAName((Node)name.getParentNode().get()))
		{
			NameRole result2 = classifyRole((Node)name.getParentNode().get());
			
			return result2;
		}
		string message = new StringBuilder().append("Unable to classify role of name contained in ").append(Object.instancehelper_getClass((Node)name.getParentNode().get()).getSimpleName()).ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
	
	public static NameCategory syntacticClassificationAccordingToContext(Node name)
	{
		if (name.getParentNode().isPresent())
		{
			Node node = (Node)name.getParentNode().get();
			if (isAName(node) && String.instancehelper_equals(nameAsString(name), nameAsString(node)))
			{
				NameCategory result = syntacticClassificationAccordingToContext(node);
				
				return result;
			}
		}
		if (isSyntacticallyATypeName(name))
		{
			return NameCategory.___003C_003ETYPE_NAME;
		}
		if (isSyntacticallyAnExpressionName(name))
		{
			return NameCategory.___003C_003EEXPRESSION_NAME;
		}
		if (isSyntacticallyAMethodName(name))
		{
			return NameCategory.___003C_003EMETHOD_NAME;
		}
		if (isSyntacticallyAPackageOrTypeName(name))
		{
			return NameCategory.___003C_003EPACKAGE_OR_TYPE_NAME;
		}
		if (isSyntacticallyAAmbiguousName(name))
		{
			return NameCategory.___003C_003EAMBIGUOUS_NAME;
		}
		if (isSyntacticallyAModuleName(name))
		{
			return NameCategory.___003C_003EMODULE_NAME;
		}
		if (isSyntacticallyAPackageName(name))
		{
			return NameCategory.___003C_003EPACKAGE_NAME;
		}
		if (name is NameExpr)
		{
			return NameCategory.___003C_003EEXPRESSION_NAME;
		}
		if (name is FieldAccessExpr)
		{
			return NameCategory.___003C_003EEXPRESSION_NAME;
		}
		if (name is ClassOrInterfaceType)
		{
			return NameCategory.___003C_003ETYPE_NAME;
		}
		if (name.getParentNode().isPresent() && name.getParentNode().get() is ClassOrInterfaceType)
		{
			return NameCategory.___003C_003ETYPE_NAME;
		}
		if (name.getParentNode().isPresent() && name.getParentNode().get() is FieldAccessExpr)
		{
			return NameCategory.___003C_003EEXPRESSION_NAME;
		}
		string message = new StringBuilder().append("Unable to classify category of name contained in ").append(Object.instancehelper_getClass((Node)name.getParentNode().get()).getSimpleName()).append(". See ")
			.append(name)
			.append(" at ")
			.append(name.getRange())
			.ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
	
	private static NameCategory reclassificationOfContextuallyAmbiguousNames(Node P_0, NameCategory P_1, TypeSolver P_2)
	{
		if (!P_1.isNeedingDisambiguation())
		{
			string s = new StringBuilder().append("The Name Category is not ambiguous: ").append(P_1).ToString();
			
			throw new IllegalArgumentException(s);
		}
		if (P_1 == NameCategory.___003C_003EAMBIGUOUS_NAME && isSimpleName(P_0))
		{
			NameCategory result = reclassificationOfContextuallyAmbiguousSimpleAmbiguousName(P_0, P_2);
			
			return result;
		}
		if (P_1 == NameCategory.___003C_003EAMBIGUOUS_NAME && isQualifiedName(P_0))
		{
			NameCategory result2 = reclassificationOfContextuallyAmbiguousQualifiedAmbiguousName(P_0, P_2);
			
			return result2;
		}
		if (P_1 == NameCategory.___003C_003EPACKAGE_OR_TYPE_NAME)
		{
			NameCategory result3 = reclassificationOfContextuallyAmbiguousPackageOrTypeName(P_0, P_2);
			
			return result3;
		}
		
		throw new UnsupportedOperationException("I do not know how to handle this semantic reclassification of ambiguous name categories");
	}

	
	
	public static bool isSimpleName(Node node)
	{
		return (!isQualifiedName(node)) ? true : false;
	}

	
	
	private static NameCategory reclassificationOfContextuallyAmbiguousSimpleAmbiguousName(Node P_0, TypeSolver P_1)
	{
		string name = nameAsString(P_0);
		Context context = JavaParserFactory.getContext(P_0, P_1);
		if (context.patternExprInScope(name).isPresent())
		{
			return NameCategory.___003C_003EEXPRESSION_NAME;
		}
		if (context.localVariableDeclarationInScope(name).isPresent())
		{
			return NameCategory.___003C_003EEXPRESSION_NAME;
		}
		if (context.parameterDeclarationInScope(name).isPresent())
		{
			return NameCategory.___003C_003EEXPRESSION_NAME;
		}
		if (context.fieldDeclarationInScope(name).isPresent())
		{
			return NameCategory.___003C_003EEXPRESSION_NAME;
		}
		return NameCategory.___003C_003EPACKAGE_NAME;
	}

	
	
	private static NameCategory reclassificationOfContextuallyAmbiguousQualifiedAmbiguousName(Node P_0, TypeSolver P_1)
	{
		Node qualifier = getQualifier(P_0);
		string text = nameAsString(getRightMostName(P_0));
		NameCategory nameCategory = classifyReference(qualifier, P_1);
		if (nameCategory == NameCategory.___003C_003EPACKAGE_NAME)
		{
			if (P_1.hasType(nameAsString(P_0)))
			{
				return NameCategory.___003C_003ETYPE_NAME;
			}
			return NameCategory.___003C_003EPACKAGE_NAME;
		}
		if (nameCategory == NameCategory.___003C_003ETYPE_NAME)
		{
			SymbolReference symbolReference = JavaParserFactory.getContext(qualifier, P_1).solveType(nameAsString(qualifier));
			if (symbolReference.isSolved())
			{
				ResolvedTypeDeclaration resolvedTypeDeclaration = (ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration();
				if (resolvedTypeDeclaration is ResolvedReferenceTypeDeclaration)
				{
					ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = resolvedTypeDeclaration.asReferenceType();
					if (resolvedReferenceTypeDeclaration.getAllMethods().stream().anyMatch(new ___003C_003EAnon60(text)))
					{
						return NameCategory.___003C_003EEXPRESSION_NAME;
					}
					if (resolvedReferenceTypeDeclaration.getAllFields().stream().anyMatch(new ___003C_003EAnon61(text)))
					{
						return NameCategory.___003C_003EEXPRESSION_NAME;
					}
					if (resolvedReferenceTypeDeclaration.hasInternalType(text))
					{
						return NameCategory.___003C_003ETYPE_NAME;
					}
					return NameCategory.___003C_003ECOMPILATION_ERROR;
				}
				
				throw new UnsupportedOperationException("The name is a type but it has been resolved to something that is not a reference type");
			}
			string name = new StringBuilder().append("Unable to solve context type: ").append(nameAsString(qualifier)).ToString();
			
			throw new UnsolvedSymbolException(name);
		}
		if (nameCategory == NameCategory.___003C_003EEXPRESSION_NAME)
		{
			return NameCategory.___003C_003EEXPRESSION_NAME;
		}
		
		throw new UnsupportedOperationException("I do not know how to handle this semantic reclassification of ambiguous name categories");
	}

	
	
	private static NameCategory reclassificationOfContextuallyAmbiguousPackageOrTypeName(Node P_0, TypeSolver P_1)
	{
		if (isSimpleName(P_0))
		{
			if (JavaParserFactory.getContext(P_0, P_1).solveType(nameAsString(P_0)).isSolved())
			{
				return NameCategory.___003C_003ETYPE_NAME;
			}
			return NameCategory.___003C_003EPACKAGE_NAME;
		}
		if (isQualifiedName(P_0))
		{
			if (JavaParserFactory.getContext(P_0, P_1).solveType(nameAsString(P_0)).isSolved())
			{
				return NameCategory.___003C_003ETYPE_NAME;
			}
			return NameCategory.___003C_003EPACKAGE_NAME;
		}
		
		throw new UnsupportedOperationException("This is unexpected: the name is neither simple or qualified");
	}

	
	
	private static Node getQualifier(Node P_0)
	{
		if (P_0 is FieldAccessExpr)
		{
			FieldAccessExpr fieldAccessExpr = (FieldAccessExpr)P_0;
			Expression scope = fieldAccessExpr.getScope();
			
			return scope;
		}
		string canonicalName = Object.instancehelper_getClass(P_0).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	private static Node getRightMostName(Node P_0)
	{
		if (P_0 is FieldAccessExpr)
		{
			FieldAccessExpr fieldAccessExpr = (FieldAccessExpr)P_0;
			SimpleName name = fieldAccessExpr.getName();
			
			return name;
		}
		string canonicalName = Object.instancehelper_getClass(P_0).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public static NameCategory classifyReference(Node name, TypeSolver typeSolver)
	{
		if (!name.getParentNode().isPresent())
		{
			
			throw new IllegalArgumentException("We cannot understand the category of a name if it has no parent");
		}
		if (classifyRole(name) != NameRole.___003C_003EREFERENCE)
		{
			
			throw new IllegalArgumentException("This method can be used only to classify names used as references");
		}
		NameCategory nameCategory = syntacticClassificationAccordingToContext(name);
		if (nameCategory.isNeedingDisambiguation())
		{
			NameCategory nameCategory2 = reclassificationOfContextuallyAmbiguousNames(name, nameCategory, typeSolver);
			if (!_0024assertionsDisabled && nameCategory2.isNeedingDisambiguation())
			{
				
				throw new AssertionError();
			}
			return nameCategory2;
		}
		return nameCategory;
	}

	
	
	private static bool isSyntacticallyATypeName(Node P_0)
	{
		if (whenParentIs(ClassLiteral<ModuleUsesDirective>.Value, P_0, new ___003C_003EAnon74()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ModuleProvidesDirective>.Value, P_0, new ___003C_003EAnon75()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ImportDeclaration>.Value, P_0, new ___003C_003EAnon76(P_0)))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<Name>.Value, P_0, new ___003C_003EAnon77()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ImportDeclaration>.Value, P_0, new ___003C_003EAnon78()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ImportDeclaration>.Value, P_0, new ___003C_003EAnon79(P_0)))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ConstructorDeclaration>.Value, P_0, new ___003C_003EAnon80(P_0)))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<AnnotationExpr>.Value, P_0, new ___003C_003EAnon81(P_0)))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ClassExpr>.Value, P_0, new ___003C_003EAnon82()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ThisExpr>.Value, P_0, new ___003C_003EAnon83()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<SuperExpr>.Value, P_0, new ___003C_003EAnon84()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ClassOrInterfaceDeclaration>.Value, P_0, new ___003C_003EAnon85()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<MethodDeclaration>.Value, P_0, new ___003C_003EAnon86()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<AnnotationMemberDeclaration>.Value, P_0, new ___003C_003EAnon87()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<MethodDeclaration>.Value, P_0, new ___003C_003EAnon88()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ConstructorDeclaration>.Value, P_0, new ___003C_003EAnon89()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<VariableDeclarator>.Value, P_0, new ___003C_003EAnon90()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<Parameter>.Value, P_0, new ___003C_003EAnon91()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ReceiverParameter>.Value, P_0, new ___003C_003EAnon92()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<VariableDeclarator>.Value, P_0, new ___003C_003EAnon93()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ClassOrInterfaceType>.Value, P_0, new ___003C_003EAnon94()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<MethodCallExpr>.Value, P_0, new ___003C_003EAnon95()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ObjectCreationExpr>.Value, P_0, new ___003C_003EAnon96()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ArrayCreationExpr>.Value, P_0, new ___003C_003EAnon97()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<CastExpr>.Value, P_0, new ___003C_003EAnon98()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<InstanceOfExpr>.Value, P_0, new ___003C_003EAnon99()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<TypeExpr>.Value, P_0, new ___003C_003EAnon100()))
		{
			return true;
		}
		return false;
	}

	
	
	private static bool isSyntacticallyAnExpressionName(Node P_0)
	{
		if (whenParentIs(ClassLiteral<NameExpr>.Value, P_0, new ___003C_003EAnon101()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ExplicitConstructorInvocationStmt>.Value, P_0, new ___003C_003EAnon102()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<NameExpr>.Value, P_0, new ___003C_003EAnon103()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ObjectCreationExpr>.Value, P_0, new ___003C_003EAnon104()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<NameExpr>.Value, P_0, new ___003C_003EAnon105()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ArrayAccessExpr>.Value, P_0, new ___003C_003EAnon106()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<NameExpr>.Value, P_0, new ___003C_003EAnon107()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<UnaryExpr>.Value, P_0, new ___003C_003EAnon108()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<NameExpr>.Value, P_0, new ___003C_003EAnon109()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<AssignExpr>.Value, P_0, new ___003C_003EAnon110()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<NameExpr>.Value, P_0, new ___003C_003EAnon111()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<NameExpr>.Value, P_0, new ___003C_003EAnon112()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<TryStmt>.Value, P_0, new ___003C_003EAnon113()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<VariableDeclarator>.Value, P_0, new ___003C_003EAnon114()))
		{
			return true;
		}
		return false;
	}

	
	
	private static bool isSyntacticallyAMethodName(Node P_0)
	{
		if (whenParentIs(ClassLiteral<MethodCallExpr>.Value, P_0, new ___003C_003EAnon67()))
		{
			return true;
		}
		return false;
	}

	
	
	private static bool isSyntacticallyAPackageOrTypeName(Node P_0)
	{
		if (whenParentIs(ClassLiteral<ClassOrInterfaceType>.Value, P_0, new ___003C_003EAnon65()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ImportDeclaration>.Value, P_0, new ___003C_003EAnon66(P_0)))
		{
			return true;
		}
		return false;
	}

	
	
	private static bool isSyntacticallyAAmbiguousName(Node P_0)
	{
		if (whenParentIs(ClassLiteral<FieldAccessExpr>.Value, P_0, new ___003C_003EAnon62()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<MethodCallExpr>.Value, P_0, new ___003C_003EAnon63()))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<MemberValuePair>.Value, P_0, new ___003C_003EAnon64()))
		{
			return true;
		}
		return false;
	}

	
	
	private static bool isSyntacticallyAModuleName(Node P_0)
	{
		if (whenParentIs(ClassLiteral<ModuleRequiresDirective>.Value, P_0, new ___003C_003EAnon68(P_0)))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ModuleExportsDirective>.Value, P_0, new ___003C_003EAnon69(P_0)))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ModuleOpensDirective>.Value, P_0, new ___003C_003EAnon70(P_0)))
		{
			return true;
		}
		return false;
	}

	
	
	private static bool isSyntacticallyAPackageName(Node P_0)
	{
		if (whenParentIs(ClassLiteral<ModuleExportsDirective>.Value, P_0, new ___003C_003EAnon71(P_0)))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<ModuleOpensDirective>.Value, P_0, new ___003C_003EAnon72(P_0)))
		{
			return true;
		}
		if (whenParentIs(ClassLiteral<Name>.Value, P_0, new ___003C_003EAnon73(P_0)))
		{
			return true;
		}
		return false;
	}

	
	
	
	private static bool lambda_0024classifyRole_00240(Name P_0, Node P_1)
	{
		return (P_0.getQualifier().isPresent() && P_0.getQualifier().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_00241(PackageDeclaration P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_00242(ImportDeclaration P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_00243(MarkerAnnotationExpr P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_00244(ClassOrInterfaceDeclaration P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_00245(ClassOrInterfaceDeclaration P_0, Node P_1)
	{
		return (P_0.getExtendedTypes().contains((object)P_1) || P_0.getImplementedTypes().contains((object)P_1)) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_00246(ClassOrInterfaceType P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_00247(VariableDeclarator P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_00248(NameExpr P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_00249(FieldAccessExpr P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002410(MethodDeclaration P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002411(Parameter P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002412(MethodCallExpr P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002413(ConstructorDeclaration P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002414(AnnotationDeclaration P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002415(AnnotationMemberDeclaration P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002416(AnnotationMemberDeclaration P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002417(MethodDeclaration P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002418(MethodDeclaration P_0, Node P_1)
	{
		return (P_0.getType() == P_1 || P_0.getThrownExceptions().contains((object)P_1)) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_002419(Parameter P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002420(Parameter P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002421(PatternExpr P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002422(PatternExpr P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002423(ReceiverParameter P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002424(MethodCallExpr P_0, Node P_1)
	{
		return (P_0.getName() == P_1 || (P_0.getTypeArguments().isPresent() && ((NodeList)P_0.getTypeArguments().get()).contains((object)P_1)) || (P_0.hasScope() && P_0.getScope().get() == P_1)) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_002425(ConstructorDeclaration P_0, Node P_1)
	{
		return (P_0.getName() == P_1 || P_0.getThrownExceptions().contains((object)P_1)) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_002426(TypeParameter P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002427(EnumDeclaration P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002428(EnumConstantDeclaration P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002429(FieldAccessExpr P_0, Node P_1)
	{
		return (P_0.getName() == P_1 || P_0.getScope() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_002430(ObjectCreationExpr P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002431(ReturnStmt P_0, Node P_1)
	{
		return (P_0.getExpression().isPresent() && P_0.getExpression().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_002432(ModuleDeclaration P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002433(ModuleRequiresDirective P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002434(ModuleExportsDirective P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002435(ModuleExportsDirective P_0, Node P_1)
	{
		bool result = P_0.getModuleNames().contains((object)P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024classifyRole_002436(ModuleOpensDirective P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002437(ModuleOpensDirective P_0, Node P_1)
	{
		bool result = P_0.getModuleNames().contains((object)P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024classifyRole_002438(ModuleUsesDirective P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002439(ModuleProvidesDirective P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002440(ClassExpr P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002441(ThisExpr P_0, Node P_1)
	{
		return (P_0.getTypeName().isPresent() && P_0.getTypeName().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_002442(SuperExpr P_0, Node P_1)
	{
		return (P_0.getTypeName().isPresent() && P_0.getTypeName().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_002443(VariableDeclarator P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002444(VariableDeclarator P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002445(ArrayCreationExpr P_0, Node P_1)
	{
		return P_0.getElementType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002446(CastExpr P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002447(InstanceOfExpr P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002448(TypeExpr P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002449(ArrayAccessExpr P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002450(UnaryExpr P_0, Node P_1)
	{
		return P_0.getExpression() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002451(AssignExpr P_0, Node P_1)
	{
		return (P_0.getTarget() == P_1 || P_0.getValue() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_002452(TryStmt P_0, Node P_1)
	{
		bool result = P_0.getResources().contains((object)P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024classifyRole_002453(VariableDeclarator P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002454(VariableDeclarator P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002455(VariableDeclarator P_0, Node P_1)
	{
		return (P_0.getInitializer().isPresent() && P_0.getInitializer().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_002456(MemberValuePair P_0, Node P_1)
	{
		return P_0.getValue() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002457(MemberValuePair P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024classifyRole_002458(ExplicitConstructorInvocationStmt P_0, Node P_1)
	{
		return ((P_0.getExpression().isPresent() && P_0.getExpression().get() == P_1) || (P_0.getTypeArguments().isPresent() && ((NodeList)P_0.getTypeArguments().get()).contains((object)P_1))) ? true : false;
	}

	
	
	
	private static bool lambda_0024classifyRole_002459(ObjectCreationExpr P_0, Node P_1)
	{
		return (P_0.getType() == P_1 || (P_0.hasScope() && P_0.getScope().get() == P_1)) ? true : false;
	}

	
	
	
	private static bool lambda_0024reclassificationOfContextuallyAmbiguousQualifiedAmbiguousName_002460(string P_0, MethodUsage P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024reclassificationOfContextuallyAmbiguousQualifiedAmbiguousName_002461(string P_0, ResolvedFieldDeclaration P_1)
	{
		return (P_1.isStatic() && String.instancehelper_equals(P_1.getName(), P_0)) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAAmbiguousName_002462(FieldAccessExpr P_0, Node P_1)
	{
		return P_0.getScope() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAAmbiguousName_002463(MethodCallExpr P_0, Node P_1)
	{
		return (P_0.hasScope() && P_0.getScope().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAAmbiguousName_002464(MemberValuePair P_0, Node P_1)
	{
		return P_0.getValue() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAPackageOrTypeName_002465(ClassOrInterfaceType P_0, Node P_1)
	{
		return (P_0.getScope().isPresent() && P_0.getScope().get() == P_1 && (isSyntacticallyATypeName(P_0) || isSyntacticallyAPackageOrTypeName(P_0))) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAPackageOrTypeName_002466(Node P_0, ImportDeclaration P_1, Node P_2)
	{
		return (!P_1.isStatic() && P_1.isAsterisk() && P_1.getName() == P_0) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAMethodName_002467(MethodCallExpr P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAModuleName_002468(Node P_0, ModuleRequiresDirective P_1, Node P_2)
	{
		return P_1.getName() == P_0;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAModuleName_002469(Node P_0, ModuleExportsDirective P_1, Node P_2)
	{
		bool result = P_1.getModuleNames().contains((object)P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAModuleName_002470(Node P_0, ModuleOpensDirective P_1, Node P_2)
	{
		bool result = P_1.getModuleNames().contains((object)P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAPackageName_002471(Node P_0, ModuleExportsDirective P_1, Node P_2)
	{
		return P_1.getName() == P_0;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAPackageName_002472(Node P_0, ModuleOpensDirective P_1, Node P_2)
	{
		return P_1.getName() == P_0;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAPackageName_002473(Node P_0, Name P_1, Node P_2)
	{
		return (P_1.getQualifier().isPresent() && P_1.getQualifier().get() == P_0 && isSyntacticallyAPackageName(P_1)) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002474(ModuleUsesDirective P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002475(ModuleProvidesDirective P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002476(Node P_0, ImportDeclaration P_1, Node P_2)
	{
		return (!P_1.isStatic() && !P_1.isAsterisk() && P_1.getName() == P_0) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002478(Name P_0, Node P_1)
	{
		bool result = whenParentIs(ClassLiteral<ImportDeclaration>.Value, P_0, new ___003C_003EAnon130());
		
		return result;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002479(ImportDeclaration P_0, Node P_1)
	{
		return (P_0.isStatic() && !P_0.isAsterisk() && P_0.getName() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002480(Node P_0, ImportDeclaration P_1, Node P_2)
	{
		return (P_1.isStatic() && P_1.isAsterisk() && P_1.getName() == P_0) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002481(Node P_0, ConstructorDeclaration P_1, Node P_2)
	{
		return P_1.getName() == P_0;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002482(Node P_0, AnnotationExpr P_1, Node P_2)
	{
		return P_1.getName() == P_0;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002483(ClassExpr P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002484(ThisExpr P_0, Node P_1)
	{
		return (P_0.getTypeName().isPresent() && P_0.getTypeName().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002485(SuperExpr P_0, Node P_1)
	{
		return (P_0.getTypeName().isPresent() && P_0.getTypeName().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002486(ClassOrInterfaceDeclaration P_0, Node P_1)
	{
		return (P_0.getExtendedTypes().contains((object)P_1) || P_0.getImplementedTypes().contains((object)P_1)) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002487(MethodDeclaration P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002488(AnnotationMemberDeclaration P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002489(MethodDeclaration P_0, Node P_1)
	{
		bool result = P_0.getThrownExceptions().contains((object)P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002490(ConstructorDeclaration P_0, Node P_1)
	{
		bool result = P_0.getThrownExceptions().contains((object)P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002492(VariableDeclarator P_0, Node P_1)
	{
		return (P_0.getType() == P_1 && whenParentIs(ClassLiteral<FieldDeclaration>.Value, P_0, new ___003C_003EAnon129())) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002493(Parameter P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002494(ReceiverParameter P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002496(VariableDeclarator P_0, Node P_1)
	{
		return (P_0.getType() == P_1 && whenParentIs(ClassLiteral<VariableDeclarationExpr>.Value, P_0, new ___003C_003EAnon128())) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002497(ClassOrInterfaceType P_0, Node P_1)
	{
		return (P_0.getTypeArguments().isPresent() && ((NodeList)P_0.getTypeArguments().get()).contains((object)P_1)) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002498(MethodCallExpr P_0, Node P_1)
	{
		return (P_0.getTypeArguments().isPresent() && ((NodeList)P_0.getTypeArguments().get()).contains((object)P_1)) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_002499(ObjectCreationExpr P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_0024100(ArrayCreationExpr P_0, Node P_1)
	{
		return P_0.getElementType() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_0024101(CastExpr P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_0024102(InstanceOfExpr P_0, Node P_1)
	{
		return P_0.getType() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyATypeName_0024104(TypeExpr P_0, Node P_1)
	{
		return (P_0.getType() == P_1 && whenParentIs(ClassLiteral<MethodReferenceExpr>.Value, P_0, new ___003C_003EAnon127())) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024106(NameExpr P_0, Node P_1)
	{
		return (P_0.getName() == P_1 && whenParentIs(ClassLiteral<ExplicitConstructorInvocationStmt>.Value, P_0, new ___003C_003EAnon126())) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024107(ExplicitConstructorInvocationStmt P_0, Node P_1)
	{
		return (P_0.getExpression().isPresent() && P_0.getExpression().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024109(NameExpr P_0, Node P_1)
	{
		return (P_0.getName() == P_1 && whenParentIs(ClassLiteral<ObjectCreationExpr>.Value, P_0, new ___003C_003EAnon125())) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024110(ObjectCreationExpr P_0, Node P_1)
	{
		return (P_0.hasScope() && P_0.getScope().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024112(NameExpr P_0, Node P_1)
	{
		return (P_0.getName() == P_1 && whenParentIs(ClassLiteral<ArrayAccessExpr>.Value, P_0, new ___003C_003EAnon124())) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024113(ArrayAccessExpr P_0, Node P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024115(NameExpr P_0, Node P_1)
	{
		return (P_0.getName() == P_1 && whenParentIs(ClassLiteral<UnaryExpr>.Value, P_0, new ___003C_003EAnon123())) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024116(UnaryExpr P_0, Node P_1)
	{
		return (P_0.getExpression() == P_1 && P_0.isPostfix()) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024118(NameExpr P_0, Node P_1)
	{
		return (P_0.getName() == P_1 && whenParentIs(ClassLiteral<AssignExpr>.Value, P_0, new ___003C_003EAnon122())) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024119(AssignExpr P_0, Node P_1)
	{
		return P_0.getTarget() == P_1;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024121(NameExpr P_0, Node P_1)
	{
		return (P_0.getName() == P_1 && whenParentIs(ClassLiteral<TryStmt>.Value, P_0, new ___003C_003EAnon121())) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024125(NameExpr P_0, Node P_1)
	{
		return (P_0.getName() == P_1 && whenParentIs(ClassLiteral<VariableDeclarator>.Value, P_0, new ___003C_003EAnon118())) ? true : false;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024126(TryStmt P_0, Node P_1)
	{
		bool result = P_0.getResources().contains((object)P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024isSyntacticallyAnExpressionName_0024129(VariableDeclarator P_0, Node P_1)
	{
		return (P_0.getInitializer().isPresent() && P_0.getInitializer().get() == P_1 && whenParentIs(ClassLiteral<VariableDeclarationExpr>.Value, P_0, new ___003C_003EAnon116())) ? true : false;
	}

	
	private static bool lambda_0024whenParentIs_0024130(Node P_0, Node P_1)
	{
		return true;
	}

	
	
	
	private static bool lambda_0024null_0024128(VariableDeclarationExpr P_0, VariableDeclarator P_1)
	{
		return (P_0.getVariables().contains(P_1) && whenParentIs(ClassLiteral<TryStmt>.Value, P_0, new ___003C_003EAnon117())) ? true : false;
	}

	
	
	
	private static bool lambda_0024null_0024127(TryStmt P_0, VariableDeclarationExpr P_1)
	{
		bool result = P_0.getResources().contains(P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024null_0024124(VariableDeclarator P_0, NameExpr P_1)
	{
		return (P_0.getInitializer().isPresent() && P_0.getInitializer().get() == P_1 && whenParentIs(ClassLiteral<VariableDeclarationExpr>.Value, P_0, new ___003C_003EAnon119())) ? true : false;
	}

	
	
	
	private static bool lambda_0024null_0024123(VariableDeclarationExpr P_0, VariableDeclarator P_1)
	{
		return (P_0.getVariables().contains(P_1) && whenParentIs(ClassLiteral<TryStmt>.Value, P_0, new ___003C_003EAnon120())) ? true : false;
	}

	
	
	
	private static bool lambda_0024null_0024122(TryStmt P_0, VariableDeclarationExpr P_1)
	{
		bool result = P_0.getResources().contains(P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024null_0024120(TryStmt P_0, NameExpr P_1)
	{
		bool result = P_0.getResources().contains(P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024null_0024117(AssignExpr P_0, NameExpr P_1)
	{
		return P_0.getTarget() == P_1;
	}

	
	
	
	private static bool lambda_0024null_0024114(UnaryExpr P_0, NameExpr P_1)
	{
		return (P_0.getExpression() == P_1 && P_0.isPostfix()) ? true : false;
	}

	
	
	
	private static bool lambda_0024null_0024111(ArrayAccessExpr P_0, NameExpr P_1)
	{
		return P_0.getName() == P_1;
	}

	
	
	
	private static bool lambda_0024null_0024108(ObjectCreationExpr P_0, NameExpr P_1)
	{
		return (P_0.hasScope() && P_0.getScope().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024null_0024105(ExplicitConstructorInvocationStmt P_0, NameExpr P_1)
	{
		return (P_0.getExpression().isPresent() && P_0.getExpression().get() == P_1) ? true : false;
	}

	
	
	
	private static bool lambda_0024null_0024103(MethodReferenceExpr P_0, TypeExpr P_1)
	{
		return P_0.getScope() == P_1;
	}

	
	
	
	private static bool lambda_0024null_002495(VariableDeclarationExpr P_0, VariableDeclarator P_1)
	{
		bool result = P_0.getVariables().contains(P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024null_002491(FieldDeclaration P_0, VariableDeclarator P_1)
	{
		bool result = P_0.getVariables().contains(P_1);
		
		return result;
	}

	
	
	
	private static bool lambda_0024null_002477(ImportDeclaration P_0, Name P_1)
	{
		return (P_0.isStatic() && !P_0.isAsterisk() && P_0.getName() == P_1) ? true : false;
	}

	
	
	public NameLogic()
	{
	}

	
		
	private static bool whenParentIs(Class P_0, Node P_1)
	{
		bool result = whenParentIs(P_0, P_1, new ___003C_003EAnon115());
		
		return result;
	}

	
	static NameLogic()
	{
		_0024assertionsDisabled = ((!ClassLiteral<NameLogic>.Value.desiredAssertionStatus()) ? true : false);
	}
}
