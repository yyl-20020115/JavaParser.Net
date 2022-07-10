using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.resolution;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class FieldAccessContext : AbstractJavaParserContext
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon0(string P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Value result = lambda_0024solveSymbolAsValue_00240(arg_00241, (ResolvedType)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveField_00241(arg_00241, (ResolvedEnumConstantDeclaration)P_0);
			
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

	private const string ARRAY_LENGTH_FIELD_NAME = "length";

	
		
	private Optional solveSymbolAsValue(string P_0, ResolvedReferenceType P_1)
	{
		Optional typeDeclaration = P_1.getTypeDeclaration();
		if (typeDeclaration.isPresent())
		{
			ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)typeDeclaration.get();
			if (resolvedReferenceTypeDeclaration.isEnum())
			{
				ResolvedEnumDeclaration resolvedEnumDeclaration = (ResolvedEnumDeclaration)resolvedReferenceTypeDeclaration;
				if (resolvedEnumDeclaration.hasEnumConstant(P_0))
				{
					Optional result = Optional.of(new Value(resolvedEnumDeclaration.getEnumConstant(P_0).getType(), P_0));
					
					return result;
				}
			}
		}
		Optional fieldType = P_1.getFieldType(P_0);
		Optional result2 = fieldType.map(new ___003C_003EAnon0(P_0));
		
		return result2;
	}

	
	
	
	private static Value lambda_0024solveSymbolAsValue_00240(string P_0, ResolvedType P_1)
	{
		Value result = new Value(P_1, P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024solveField_00241(string P_0, ResolvedEnumConstantDeclaration P_1)
	{
		bool result = java.lang.String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	public FieldAccessContext(FieldAccessExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		if (java.lang.String.instancehelper_equals(((FieldAccessExpr)wrappedNode).getName().ToString(), name) && ((FieldAccessExpr)wrappedNode).getScope() is ThisExpr)
		{
			ResolvedType typeOfThisIn = JavaParserFacade.get(typeSolver).getTypeOfThisIn(wrappedNode);
			if (typeOfThisIn.asReferenceType().getTypeDeclaration().isPresent())
			{
				SymbolReference result = new SymbolSolver(typeSolver).solveSymbolInType((ResolvedTypeDeclaration)typeOfThisIn.asReferenceType().getTypeDeclaration().get(), name);
				
				return result;
			}
		}
		SymbolReference result2 = JavaParserFactory.getContext(Navigator.demandParentNode(wrappedNode), typeSolver).solveSymbol(name);
		
		return result2;
	}

	
		
	public override SymbolReference solveType(string name)
	{
		SymbolReference result = JavaParserFactory.getContext(Navigator.demandParentNode(wrappedNode), typeSolver).solveType(name);
		
		return result;
	}

	
		
	public override SymbolReference solveMethod(string name, List parameterTypes, bool staticOnly)
	{
		SymbolReference result = JavaParserFactory.getContext(Navigator.demandParentNode(wrappedNode), typeSolver).solveMethod(name, parameterTypes, staticOnly: false);
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		39, 113, 127, 1, 114, 117, 151, 104, 112, 104,
		154, 168
	})]
	public override Optional solveSymbolAsValue(string name)
	{
		Expression scope = ((FieldAccessExpr)wrappedNode).getScope();
		if (java.lang.String.instancehelper_equals(((FieldAccessExpr)wrappedNode).getName().ToString(), name))
		{
			ResolvedType type = JavaParserFacade.get(typeSolver).getType(scope);
			if (type.isArray() && java.lang.String.instancehelper_equals(name, "length"))
			{
				Optional result = Optional.of(new Value(ResolvedPrimitiveType.___003C_003EINT, "length"));
				
				return result;
			}
			if (type.isReferenceType())
			{
				Optional result2 = solveSymbolAsValue(name, type.asReferenceType());
				
				return result2;
			}
			if (type.isConstraint())
			{
				Optional result3 = solveSymbolAsValue(name, type.asConstraintType().getBound().asReferenceType());
				
				return result3;
			}
			Optional result4 = Optional.empty();
			
			return result4;
		}
		Optional result5 = solveSymbolAsValueInParentContext(name);
		
		return result5;
	}

	
		[LineNumberTable(new byte[]
	{
		76, 124, 126, 104, 127, 7, 104, 209, 127, 25,
		129, 101
	})]
	public virtual SymbolReference solveField(string name)
	{
		//Discarded unreachable code: IL_00a3
		Collection collection = findTypeDeclarations(Optional.of(((FieldAccessExpr)wrappedNode).getScope()));
		Iterator iterator = collection.iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)iterator.next();
			if (resolvedReferenceTypeDeclaration.isEnum())
			{
				Optional optional = resolvedReferenceTypeDeclaration.asEnum().getEnumConstants().stream()
					.filter(new ___003C_003EAnon1(name))
					.findFirst();
				if (optional.isPresent())
				{
					return SymbolReference.solved((ResolvedDeclaration)optional.get());
				}
			}
			try
			{
				return SymbolReference.solved(resolvedReferenceTypeDeclaration.getField(((FieldAccessExpr)wrappedNode).getName().getId()));
			}
			catch (System.Exception x)
			{
				ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
			}
			
		}
		return SymbolReference.unsolved(ClassLiteral<ResolvedFieldDeclaration>.Value);
	}
}
