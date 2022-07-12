
using com.github.javaparser.resolution.declarations;

using java.util;

namespace com.github.javaparser.resolution.types.parametrization;

public interface ResolvedTypeParameterValueProvider
{
	
	public static class __DefaultMethods
	{
		public unsafe static ResolvedType useThisTypeParametersOnTheGivenType(ResolvedTypeParameterValueProvider P_0, ResolvedType P_1)
		{
			
			return _003Cdefault_003EuseThisTypeParametersOnTheGivenType(P_0, P_1);
		}
	}

	
	private sealed class ___003C_003EAnon1 : ResolvedTypeTransformer
	{
		private readonly ResolvedTypeParameterValueProvider arg_00241;

		internal ___003C_003EAnon1(ResolvedTypeParameterValueProvider P_0)
		{
			arg_00241 = P_0;
		}

		public ResolvedType transform(ResolvedType P_0)
		{
			ResolvedType result = arg_00241.useThisTypeParametersOnTheGivenType(P_0);
			
			return result;
		}
	}

		
	virtual Optional typeParamValue(ResolvedTypeParameterDeclaration typeParameterDeclaration);

	
	
	virtual ResolvedType useThisTypeParametersOnTheGivenType(ResolvedType type);

	
	
	
	static ResolvedType _003Cdefault_003EuseThisTypeParametersOnTheGivenType(ResolvedTypeParameterValueProvider P_0, ResolvedType P_1)
	{
		if (P_1.isTypeVariable())
		{
			ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = P_1.asTypeParameter();
			if (resolvedTypeParameterDeclaration.declaredOnType())
			{
				Optional optional = P_0.typeParamValue(resolvedTypeParameterDeclaration);
				if (optional.isPresent())
				{
					P_1 = (ResolvedType)optional.get();
				}
			}
		}
		if (P_1.isWildcard() && P_1.asWildcard().isBounded())
		{
			if (P_1.asWildcard().isExtends())
			{
				ResolvedWildcard result = ResolvedWildcard.extendsBound(P_0.useThisTypeParametersOnTheGivenType(P_1.asWildcard().getBoundedType()));
				
				return result;
			}
			ResolvedWildcard result2 = ResolvedWildcard.superBound(P_0.useThisTypeParametersOnTheGivenType(P_1.asWildcard().getBoundedType()));
			
			return result2;
		}
		if (P_1.isReferenceType())
		{
			P_1 = P_1.asReferenceType().transformTypeParameters(new ___003C_003EAnon1(P_0));
		}
		return P_1;
	}

		
	virtual Optional getGenericParameterByName(string name);
}
