
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.resolution.typesolvers;

using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.constraintformulas;

public class TypeCompatibleWithType : ConstraintFormula
{
	private ResolvedType s;

	private ResolvedType t;

	private TypeSolver typeSolver;

	
	
	public TypeCompatibleWithType(TypeSolver typeSolver, ResolvedType s, ResolvedType t)
	{
		this.typeSolver = typeSolver;
		this.s = s;
		this.t = t;
	}

	
	
	public override ReductionResult reduce(BoundSet currentBoundSet)
	{
		if (TypeHelper.isProperType(s) && TypeHelper.isProperType(t))
		{
			if (TypeHelper.isCompatibleInALooseInvocationContext(s, t))
			{
				ReductionResult result = ReductionResult.trueResult();
				
				return result;
			}
			ReductionResult result2 = ReductionResult.falseResult();
			
			return result2;
		}
		if (s.isPrimitive())
		{
			ReflectionTypeSolver reflectionTypeSolver = new ReflectionTypeSolver();
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl referenceTypeImpl = new ReferenceTypeImpl(reflectionTypeSolver.solveType(s.asPrimitive().getBoxTypeQName()), reflectionTypeSolver);
			ReductionResult result3 = ReductionResult.oneConstraint(new TypeCompatibleWithType(reflectionTypeSolver, referenceTypeImpl, t));
			
			return result3;
		}
		if (t.isPrimitive())
		{
			ReflectionTypeSolver reflectionTypeSolver = new ReflectionTypeSolver();
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl referenceTypeImpl = new ReferenceTypeImpl(reflectionTypeSolver.solveType(t.asPrimitive().getBoxTypeQName()), reflectionTypeSolver);
			ReductionResult result4 = ReductionResult.oneConstraint(new TypeSameAsType(s, referenceTypeImpl));
			
			return result4;
		}
		if (t.isReferenceType() && t.asReferenceType().getTypeDeclaration().isPresent() && !((ResolvedReferenceTypeDeclaration)t.asReferenceType().getTypeDeclaration().get()).getTypeParameters().isEmpty())
		{
			int num = (t.isAssignableBy(s) ? 1 : 0);
			ResolvedType resolvedType = t.asReferenceType().toRawType();
			int num2 = (resolvedType.isAssignableBy(s) ? 1 : 0);
			if (num == 0 && num2 != 0)
			{
				ReductionResult result5 = ReductionResult.trueResult();
				
				return result5;
			}
		}
		if (t.isArray())
		{
			
			throw new UnsupportedOperationException();
		}
		ReductionResult result6 = ReductionResult.empty().withConstraint(new TypeSubtypeOfType(typeSolver, s, t));
		
		return result6;
	}

	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || ((object)this).GetType() != o.GetType())
		{
			return false;
		}
		TypeCompatibleWithType typeCompatibleWithType = (TypeCompatibleWithType)o;
		if (!Object.instancehelper_equals(s, typeCompatibleWithType.s))
		{
			return false;
		}
		bool result = Object.instancehelper_equals(t, typeCompatibleWithType.t);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = Object.instancehelper_hashCode(s);
		return 31 * num + Object.instancehelper_hashCode(t);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("TypeCompatibleWithType{s=").append(s).append(", t=")
			.append(t)
			.append('}')
			.ToString();
		
		return result;
	}
}
