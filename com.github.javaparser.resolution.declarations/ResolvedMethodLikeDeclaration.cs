
using com.github.javaparser.resolution.types;

using java.lang;
using java.util;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedMethodLikeDeclaration : ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier
{
	
	public new static class __DefaultMethods
	{
		public unsafe static string getPackageName(ResolvedMethodLikeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetPackageName(P_0);
		}

		public unsafe static string getClassName(ResolvedMethodLikeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetClassName(P_0);
		}

		public unsafe static string getQualifiedName(ResolvedMethodLikeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetQualifiedName(P_0);
		}

		public unsafe static string getSignature(ResolvedMethodLikeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetSignature(P_0);
		}

		public unsafe static string getQualifiedSignature(ResolvedMethodLikeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetQualifiedSignature(P_0);
		}

		public unsafe static ResolvedParameterDeclaration getLastParam(ResolvedMethodLikeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetLastParam(P_0);
		}

		public unsafe static bool hasVariadicParameter(ResolvedMethodLikeDeclaration P_0)
		{
			
			return _003Cdefault_003EhasVariadicParameter(P_0);
		}

		public unsafe static Optional findTypeParameter(ResolvedMethodLikeDeclaration P_0, string P_1)
		{
			
			return _003Cdefault_003EfindTypeParameter(P_0, P_1);
		}

		public unsafe static List getSpecifiedExceptions(ResolvedMethodLikeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetSpecifiedExceptions(P_0);
		}
	}

	virtual ResolvedReferenceTypeDeclaration declaringType();

	virtual int getNumberOfParams();

	
	virtual ResolvedParameterDeclaration getParam(int i);

	
	virtual string getSignature();

	
	
	
	static string _003Cdefault_003EgetSignature(ResolvedMethodLikeDeclaration P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append(P_0.getName());
		stringBuilder.append("(");
		for (int i = 0; i < P_0.getNumberOfParams(); i++)
		{
			if (i != 0)
			{
				stringBuilder.append(", ");
			}
			stringBuilder.append(P_0.getParam(i).describeType());
		}
		stringBuilder.append(")");
		string result = stringBuilder.ToString();
		
		return result;
	}

	virtual int getNumberOfSpecifiedExceptions();

	
	virtual ResolvedType getSpecifiedException(int index);

	
	virtual string getPackageName();

	
	
	
	static string _003Cdefault_003EgetPackageName(ResolvedMethodLikeDeclaration P_0)
	{
		string packageName = P_0.declaringType().getPackageName();
		
		return packageName;
	}

	
	virtual string getClassName();

	
	
	
	static string _003Cdefault_003EgetClassName(ResolvedMethodLikeDeclaration P_0)
	{
		string className = P_0.declaringType().getClassName();
		
		return className;
	}

	
	virtual string getQualifiedName();

	
	
	
	static string _003Cdefault_003EgetQualifiedName(ResolvedMethodLikeDeclaration P_0)
	{
		string result = new StringBuilder().append(P_0.declaringType().getQualifiedName()).append(".").append(P_0.getName())
			.ToString();
		
		return result;
	}

	
	virtual string getQualifiedSignature();

	
	
	
	static string _003Cdefault_003EgetQualifiedSignature(ResolvedMethodLikeDeclaration P_0)
	{
		string result = new StringBuilder().append(P_0.declaringType().getId()).append(".").append(P_0.getSignature())
			.ToString();
		
		return result;
	}

	
	virtual ResolvedParameterDeclaration getLastParam();

	
	
	
	static ResolvedParameterDeclaration _003Cdefault_003EgetLastParam(ResolvedMethodLikeDeclaration P_0)
	{
		if (P_0.getNumberOfParams() == 0)
		{
			
			throw new UnsupportedOperationException("This method has no typeParametersValues, therefore it has no a last parameter");
		}
		ResolvedParameterDeclaration param = P_0.getParam(P_0.getNumberOfParams() - 1);
		
		return param;
	}

	
	virtual bool hasVariadicParameter();

	
	
	
	static bool _003Cdefault_003EhasVariadicParameter(ResolvedMethodLikeDeclaration P_0)
	{
		if (P_0.getNumberOfParams() == 0)
		{
			return false;
		}
		bool result = P_0.getParam(P_0.getNumberOfParams() - 1).isVariadic();
		
		return result;
	}

	
		
	Optional findTypeParameter(string name);

	
	
	
	static Optional _003Cdefault_003EfindTypeParameter(ResolvedMethodLikeDeclaration P_0, string P_1)
	{
		Iterator iterator = P_0.getTypeParameters().iterator();
		while (iterator.hasNext())
		{
			ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = (ResolvedTypeParameterDeclaration)iterator.next();
			if (String.instancehelper_equals(resolvedTypeParameterDeclaration.getName(), P_1))
			{
				Optional result = Optional.of(resolvedTypeParameterDeclaration);
				
				return result;
			}
		}
		Optional result2 = P_0.declaringType().findTypeParameter(P_1);
		
		return result2;
	}

	
		virtual List getSpecifiedExceptions();

	
	
	
	static List _003Cdefault_003EgetSpecifiedExceptions(ResolvedMethodLikeDeclaration P_0)
	{
		if (P_0.getNumberOfSpecifiedExceptions() == 0)
		{
			List result = Collections.emptyList();
			
			return result;
		}
		LinkedList linkedList = new LinkedList();
		for (int i = 0; i < P_0.getNumberOfSpecifiedExceptions(); i++)
		{
			((List)linkedList).add((object)P_0.getSpecifiedException(i));
		}
		return linkedList;
	}
}
