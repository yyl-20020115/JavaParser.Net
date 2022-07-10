using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.javaparsermodel.contexts;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.core.resolution;

public interface Context
{
	private static class ___003C_003EPIM
	{
		
		
		
		internal static bool lambda_0024localVariableDeclarationInScope_00240(string P_0, VariableDeclarator P_1)
		{
			bool result = String.instancehelper_equals(P_1.getNameAsString(), P_0);
			
			return result;
		}

		
		
		
		internal static bool lambda_0024parameterDeclarationInScope_00241(string P_0, Parameter P_1)
		{
			bool result = String.instancehelper_equals(P_1.getNameAsString(), P_0);
			
			return result;
		}

		
		
		
		internal static bool lambda_0024patternExprInScope_00242(string P_0, PatternExpr P_1)
		{
			bool result = String.instancehelper_equals(P_1.getNameAsString(), P_0);
			
			return result;
		}

		
		
		
		internal static bool lambda_0024fieldDeclarationInScope_00243(string P_0, ResolvedFieldDeclaration P_1)
		{
			bool result = String.instancehelper_equals(P_1.getName(), P_0);
			
			return result;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static Optional solveGenericType(Context P_0, string P_1)
		{
			
			return _003Cdefault_003EsolveGenericType(P_0, P_1);
		}

		public unsafe static Optional solveGenericTypeInParentContext(Context P_0, string P_1)
		{
			
			return _003Cdefault_003EsolveGenericTypeInParentContext(P_0, P_1);
		}

		public unsafe static SymbolReference solveType(Context P_0, string P_1)
		{
			
			return _003Cdefault_003EsolveType(P_0, P_1);
		}

		public unsafe static SymbolReference solveTypeInParentContext(Context P_0, string P_1)
		{
			
			return _003Cdefault_003EsolveTypeInParentContext(P_0, P_1);
		}

		public unsafe static SymbolReference solveSymbol(Context P_0, string P_1)
		{
			
			return _003Cdefault_003EsolveSymbol(P_0, P_1);
		}

		public unsafe static SymbolReference solveSymbolInParentContext(Context P_0, string P_1)
		{
			
			return _003Cdefault_003EsolveSymbolInParentContext(P_0, P_1);
		}

		public unsafe static Optional solveSymbolAsValue(Context P_0, string P_1)
		{
			
			return _003Cdefault_003EsolveSymbolAsValue(P_0, P_1);
		}

		public unsafe static Optional solveSymbolAsValueInParentContext(Context P_0, string P_1)
		{
			
			return _003Cdefault_003EsolveSymbolAsValueInParentContext(P_0, P_1);
		}

		public unsafe static List fieldsExposedToChild(Context P_0, Node P_1)
		{
			
			return _003Cdefault_003EfieldsExposedToChild(P_0, P_1);
		}

		public unsafe static List localVariablesExposedToChild(Context P_0, Node P_1)
		{
			
			return _003Cdefault_003ElocalVariablesExposedToChild(P_0, P_1);
		}

		public unsafe static List parametersExposedToChild(Context P_0, Node P_1)
		{
			
			return _003Cdefault_003EparametersExposedToChild(P_0, P_1);
		}

		public unsafe static List patternExprsExposedToChild(Context P_0, Node P_1)
		{
			
			return _003Cdefault_003EpatternExprsExposedToChild(P_0, P_1);
		}

		public unsafe static List patternExprsExposedFromChildren(Context P_0)
		{
			
			return _003Cdefault_003EpatternExprsExposedFromChildren(P_0);
		}

		public unsafe static List negatedPatternExprsExposedFromChildren(Context P_0)
		{
			
			return _003Cdefault_003EnegatedPatternExprsExposedFromChildren(P_0);
		}

		public unsafe static Optional localVariableDeclarationInScope(Context P_0, string P_1)
		{
			
			return _003Cdefault_003ElocalVariableDeclarationInScope(P_0, P_1);
		}

		public unsafe static Optional parameterDeclarationInScope(Context P_0, string P_1)
		{
			
			return _003Cdefault_003EparameterDeclarationInScope(P_0, P_1);
		}

		public unsafe static Optional patternExprInScope(Context P_0, string P_1)
		{
			
			return _003Cdefault_003EpatternExprInScope(P_0, P_1);
		}

		public unsafe static Optional fieldDeclarationInScope(Context P_0, string P_1)
		{
			
			return _003Cdefault_003EfieldDeclarationInScope(P_0, P_1);
		}

		public unsafe static SymbolReference solveConstructor(Context P_0, List P_1)
		{
			
			return _003Cdefault_003EsolveConstructor(P_0, P_1);
		}

		public unsafe static SymbolReference solveMethod(Context P_0, string P_1, List P_2, bool P_3)
		{
			
			return _003Cdefault_003EsolveMethod(P_0, P_1, P_2, P_3);
		}

		public unsafe static SymbolReference solveMethodInParentContext(Context P_0, string P_1, List P_2, bool P_3)
		{
			
			return _003Cdefault_003EsolveMethodInParentContext(P_0, P_1, P_2, P_3);
		}

		public unsafe static Optional solveMethodAsUsage(Context P_0, string P_1, List P_2)
		{
			
			return _003Cdefault_003EsolveMethodAsUsage(P_0, P_1, P_2);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024localVariableDeclarationInScope_00240(arg_00241, (VariableDeclarator)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon2(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024parameterDeclarationInScope_00241(arg_00241, (Parameter)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon3(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024patternExprInScope_00242(arg_00241, (PatternExpr)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon4(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024fieldDeclarationInScope_00243(arg_00241, (ResolvedFieldDeclaration)P_0);
			
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

	
		virtual Optional solveGenericTypeInParentContext(string name);

	
	
	
	static Optional _003Cdefault_003EsolveGenericTypeInParentContext(Context P_0, string P_1)
	{
		Optional parent = P_0.getParent();
		if (!parent.isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Optional result2 = ((Context)parent.get()).solveGenericType(P_1);
		
		return result2;
	}

		virtual Optional getParent();

	
		virtual Optional solveGenericType(string name);

	
	
	
	static Optional _003Cdefault_003EsolveGenericType(Context P_0, string P_1)
	{
		Optional result = P_0.solveGenericTypeInParentContext(P_1);
		
		return result;
	}

	
		virtual SymbolReference solveTypeInParentContext(string name);

	
	
	
	static SymbolReference _003Cdefault_003EsolveTypeInParentContext(Context P_0, string P_1)
	{
		Optional parent = P_0.getParent();
		if (!parent.isPresent())
		{
			SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
			
			return result;
		}
		SymbolReference result2 = ((Context)parent.get()).solveType(P_1);
		
		return result2;
	}

	
		virtual SymbolReference solveType(string name);

	
	
	
	static SymbolReference _003Cdefault_003EsolveType(Context P_0, string P_1)
	{
		SymbolReference result = P_0.solveTypeInParentContext(P_1);
		
		return result;
	}

	
		virtual SymbolReference solveSymbolInParentContext(string name);

	
	
	
	static SymbolReference _003Cdefault_003EsolveSymbolInParentContext(Context P_0, string P_1)
	{
		Optional parent = P_0.getParent();
		if (!parent.isPresent())
		{
			SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
			
			return result;
		}
		SymbolReference result2 = ((Context)parent.get()).solveSymbol(P_1);
		
		return result2;
	}

	
		virtual SymbolReference solveSymbol(string name);

	
	
	
	static SymbolReference _003Cdefault_003EsolveSymbol(Context P_0, string P_1)
	{
		SymbolReference result = P_0.solveSymbolInParentContext(P_1);
		
		return result;
	}

	
		virtual List localVariablesExposedToChild(Node child);

	
	
	
	static List _003Cdefault_003ElocalVariablesExposedToChild(Context P_0, Node P_1)
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		virtual Optional localVariableDeclarationInScope(string name);

	
	
	[LineNumberTable(new byte[]
	{
		160, 110, 109, 200, 108, 113, 98, 101, 112, 101,
		134, 104, 226, 69
	})]
	static Optional _003Cdefault_003ElocalVariableDeclarationInScope(Context P_0, string P_1)
	{
		if (!P_0.getParent().isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Node wrappedNode = ((AbstractJavaParserContext)P_0).getWrappedNode();
		Context context = (Context)P_0.getParent().get();
		Optional optional = context.localVariablesExposedToChild(wrappedNode).stream().filter(new ___003C_003EAnon1(P_1))
			.findFirst();
		if (optional.isPresent())
		{
			return optional;
		}
		Optional result2 = context.localVariableDeclarationInScope(P_1);
		
		return result2;
	}

	
		virtual List parametersExposedToChild(Node child);

	
	
	
	static List _003Cdefault_003EparametersExposedToChild(Context P_0, Node P_1)
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		virtual Optional parameterDeclarationInScope(string name);

	
	
	[LineNumberTable(new byte[]
	{
		160, 133, 109, 200, 108, 113, 98, 101, 112, 101,
		134, 104, 194
	})]
	static Optional _003Cdefault_003EparameterDeclarationInScope(Context P_0, string P_1)
	{
		if (!P_0.getParent().isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Node wrappedNode = ((AbstractJavaParserContext)P_0).getWrappedNode();
		Context context = (Context)P_0.getParent().get();
		Optional optional = context.parametersExposedToChild(wrappedNode).stream().filter(new ___003C_003EAnon2(P_1))
			.findFirst();
		if (optional.isPresent())
		{
			return optional;
		}
		Optional result2 = context.parameterDeclarationInScope(P_1);
		
		return result2;
	}

	
		virtual List patternExprsExposedToChild(Node child);

	
	
	
	static List _003Cdefault_003EpatternExprsExposedToChild(Context P_0, Node P_1)
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		virtual Optional patternExprInScope(string name);

	
	
	[LineNumberTable(new byte[]
	{
		160, 175, 109, 136, 241, 70, 108, 98, 101, 112,
		101, 134, 104, 194
	})]
	static Optional _003Cdefault_003EpatternExprInScope(Context P_0, string P_1)
	{
		if (!P_0.getParent().isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Context context = (Context)P_0.getParent().get();
		Node wrappedNode = ((AbstractJavaParserContext)P_0).getWrappedNode();
		Optional optional = context.patternExprsExposedToChild(wrappedNode).stream().filter(new ___003C_003EAnon3(P_1))
			.findFirst();
		if (optional.isPresent())
		{
			return optional;
		}
		Optional result2 = context.patternExprInScope(P_1);
		
		return result2;
	}

	
		virtual List fieldsExposedToChild(Node child);

	
	
	
	static List _003Cdefault_003EfieldsExposedToChild(Context P_0, Node P_1)
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		virtual Optional fieldDeclarationInScope(string name);

	
	
	[LineNumberTable(new byte[]
	{
		160, 200, 109, 136, 145, 108, 98, 101, 112, 101,
		134, 104, 194
	})]
	static Optional _003Cdefault_003EfieldDeclarationInScope(Context P_0, string P_1)
	{
		if (!P_0.getParent().isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Context context = (Context)P_0.getParent().get();
		Node wrappedNode = ((AbstractJavaParserContext)P_0).getWrappedNode();
		Optional optional = context.fieldsExposedToChild(wrappedNode).stream().filter(new ___003C_003EAnon4(P_1))
			.findFirst();
		if (optional.isPresent())
		{
			return optional;
		}
		Optional result2 = context.fieldDeclarationInScope(P_1);
		
		return result2;
	}

	
		virtual SymbolReference solveMethodInParentContext(string name, List argumentsTypes, bool staticOnly);

	
	
	
	static SymbolReference _003Cdefault_003EsolveMethodInParentContext(Context P_0, string P_1, List P_2, bool P_3)
	{
		Optional parent = P_0.getParent();
		if (!parent.isPresent())
		{
			SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedMethodDeclaration>.Value);
			
			return result;
		}
		SymbolReference result2 = ((Context)parent.get()).solveMethod(P_1, P_2, P_3);
		
		return result2;
	}

	
		virtual SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly);

	
	
	
	static SymbolReference _003Cdefault_003EsolveMethod(Context P_0, string P_1, List P_2, bool P_3)
	{
		SymbolReference result = P_0.solveMethodInParentContext(P_1, P_2, P_3);
		
		return result;
	}

	
		virtual Optional solveSymbolAsValue(string name);

	
	
	
	static Optional _003Cdefault_003EsolveSymbolAsValue(Context P_0, string P_1)
	{
		SymbolReference symbolReference = P_0.solveSymbol(P_1);
		if (!symbolReference.isSolved())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Optional result2 = Optional.of(Value.from((ResolvedValueDeclaration)symbolReference.getCorrespondingDeclaration()));
		
		return result2;
	}

	
		virtual Optional solveSymbolAsValueInParentContext(string name);

	
	
	
	static Optional _003Cdefault_003EsolveSymbolAsValueInParentContext(Context P_0, string P_1)
	{
		SymbolReference symbolReference = P_0.solveSymbolInParentContext(P_1);
		if (!symbolReference.isSolved())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Optional result2 = Optional.of(Value.from((ResolvedValueDeclaration)symbolReference.getCorrespondingDeclaration()));
		
		return result2;
	}

	
		virtual List patternExprsExposedFromChildren();

	
	
	
	static List _003Cdefault_003EpatternExprsExposedFromChildren(Context P_0)
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		virtual List negatedPatternExprsExposedFromChildren();

	
	
	
	static List _003Cdefault_003EnegatedPatternExprsExposedFromChildren(Context P_0)
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		virtual SymbolReference solveConstructor(List argumentsTypes);

	
	
	
	static SymbolReference _003Cdefault_003EsolveConstructor(Context P_0, List P_1)
	{
		
		throw new IllegalArgumentException("Constructor resolution is available only on Class Context");
	}

	
		virtual Optional solveMethodAsUsage(string name, List argumentsTypes);

	
	
	[LineNumberTable(new byte[]
	{
		160,
		byte.MaxValue,
		106,
		104,
		108,
		104,
		146,
		6,
		240,
		70,
		110,
		137
	})]
	static Optional _003Cdefault_003EsolveMethodAsUsage(Context P_0, string P_1, List P_2)
	{
		SymbolReference symbolReference = P_0.solveMethod(P_1, P_2, staticOnly: false);
		if (symbolReference.isSolved())
		{
			ResolvedMethodDeclaration resolvedMethodDeclaration = (ResolvedMethodDeclaration)symbolReference.getCorrespondingDeclaration();
			if (!(resolvedMethodDeclaration is TypeVariableResolutionCapability))
			{
				string message = String.format("Resolved method declarations must implement %s.", ClassLiteral<TypeVariableResolutionCapability>.Value.getName());
				
				throw new UnsupportedOperationException(message);
			}
			MethodUsage value = ((TypeVariableResolutionCapability)resolvedMethodDeclaration).resolveTypeVariables(P_0, P_2);
			Optional result = Optional.of(value);
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}
}
