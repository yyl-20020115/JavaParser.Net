using System.Runtime.CompilerServices;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.reflectionmodel;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.declarations.common;

public class MethodDeclarationCommonLogic
{
	
	private sealed class ___003C_003EAnon0 : ResolvedTypeTransformer
	{
		private readonly MethodDeclarationCommonLogic arg_00241;

		private readonly Context arg_00242;

		internal ___003C_003EAnon0(MethodDeclarationCommonLogic P_0, Context P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public ResolvedType transform(ResolvedType P_0)
		{
			ResolvedType result = arg_00241.lambda_0024replaceTypeParams_00240(arg_00242, P_0);
			
			return result;
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
			bool result = lambda_0024typeParamByName_00241(arg_00241, (ResolvedTypeParameterDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		private readonly MethodDeclarationCommonLogic arg_00241;

		internal ___003C_003EAnon2(MethodDeclarationCommonLogic P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedType result = arg_00241.lambda_0024typeParamByName_00242((ResolvedTypeParameterDeclaration)P_0);
			
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

	private ResolvedMethodDeclaration methodDeclaration;

	private TypeSolver typeSolver;

	
	
	private ResolvedType replaceTypeParams(ResolvedType P_0, Context P_1)
	{
		if (P_0.isTypeVariable())
		{
			ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = P_0.asTypeParameter();
			if (resolvedTypeParameterDeclaration.declaredOnType())
			{
				Optional optional = typeParamByName(resolvedTypeParameterDeclaration.getName(), P_1);
				if (optional.isPresent())
				{
					P_0 = (ResolvedType)optional.get();
				}
			}
		}
		if (P_0.isReferenceType())
		{
			P_0.asReferenceType().transformTypeParameters(new ___003C_003EAnon0(this, P_1));
		}
		return P_0;
	}

	
		
	protected internal virtual Optional typeParamByName(string name, Context context)
	{
		Optional result = methodDeclaration.getTypeParameters().stream().filter(new ___003C_003EAnon1(name))
			.map(new ___003C_003EAnon2(this))
			.findFirst();
		
		return result;
	}

	
	
	protected internal virtual ResolvedType toType(ResolvedTypeParameterDeclaration typeParameterDeclaration)
	{
		ResolvedTypeVariable result = new ResolvedTypeVariable(typeParameterDeclaration);
		
		return result;
	}

	
	
	
	private ResolvedType lambda_0024replaceTypeParams_00240(Context P_0, ResolvedType P_1)
	{
		ResolvedType result = replaceTypeParams(P_1, P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024typeParamByName_00241(string P_0, ResolvedTypeParameterDeclaration P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private ResolvedType lambda_0024typeParamByName_00242(ResolvedTypeParameterDeclaration P_0)
	{
		ResolvedType result = toType(P_0);
		
		return result;
	}

	
	
	public MethodDeclarationCommonLogic(ResolvedMethodDeclaration methodDeclaration, TypeSolver typeSolver)
	{
		this.methodDeclaration = methodDeclaration;
		this.typeSolver = typeSolver;
	}

	
		[LineNumberTable(new byte[]
	{
		3, 115, 102, 112, 121, 8, 230, 72, 108, 117,
		111, 169, 124, 162, 143, 114, 174, 236, 49, 235,
		82, 144
	})]
	public virtual MethodUsage resolveTypeVariables(Context context, List parameterTypes)
	{
		ResolvedType actual = replaceTypeParams(methodDeclaration.getReturnType(), context);
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < methodDeclaration.getNumberOfParams(); i++)
		{
			ResolvedType e = replaceTypeParams(methodDeclaration.getParam(i).getType(), context);
			((List)arrayList).add((object)e);
		}
		InferenceContext inferenceContext = new InferenceContext(MyObjectProvider.___003C_003EINSTANCE);
		for (int j = 0; j < methodDeclaration.getNumberOfParams(); j++)
		{
			ResolvedParameterDeclaration param = methodDeclaration.getParam(j);
			ResolvedType resolvedType = param.getType();
			if (param.isVariadic() && parameterTypes.size() < methodDeclaration.getNumberOfParams())
			{
				break;
			}
			ResolvedType resolvedType2 = (ResolvedType)parameterTypes.get(j);
			if (param.isVariadic() && !resolvedType2.isArray())
			{
				resolvedType = resolvedType.asArrayType().getComponentType();
			}
			inferenceContext.addPair(resolvedType, resolvedType2);
		}
		actual = inferenceContext.resolve(inferenceContext.addSingle(actual));
		MethodUsage result = new MethodUsage(methodDeclaration, arrayList, actual);
		
		return result;
	}
}
