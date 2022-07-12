
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.resolution.types.parametrization;

using java.lang;
using java.util;

namespace com.github.javaparser.resolution;

public class MethodUsage: ResolvedTypeParametrized
{
	private ResolvedMethodDeclaration declaration;

		private List paramTypes;

		private List m_exceptionTypes;

	private ResolvedType m_returnType;

	private ResolvedTypeParametersMap m_typeParametersMap;

	
		
	
	private MethodUsage(ResolvedMethodDeclaration declaration, List paramTypes, ResolvedType returnType, List exceptionTypes, ResolvedTypeParametersMap typeParametersMap)
	{
		this.paramTypes = new ArrayList();
		this.m_exceptionTypes = new ArrayList();
		this.declaration = declaration;
		this.paramTypes = paramTypes;
		this.m_returnType = returnType;
		this.m_exceptionTypes = exceptionTypes;
		this.m_typeParametersMap = typeParametersMap;
	}

	
	
	public virtual int getNoParams()
	{
		int result = paramTypes.size();
		
		return result;
	}

	
	
	
	public virtual MethodUsage replaceParamType(int i, ResolvedType replaced)
	{
		if (i < 0 || i >= getNoParams())
		{
			
			throw new IllegalArgumentException();
		}
		if (paramTypes.get(i) == replaced)
		{
			return this;
		}
		LinkedList linkedList = new LinkedList(paramTypes);
		((List)linkedList).set(i, (object)replaced);
		MethodUsage result = new MethodUsage(declaration, linkedList, this.m_returnType, this.m_exceptionTypes, this.m_typeParametersMap);
		
		return result;
	}

	
	
	
	public virtual MethodUsage replaceExceptionType(int i, ResolvedType replaced)
	{
		if (i < 0 || i >= this.m_exceptionTypes.size())
		{
			
			throw new IllegalArgumentException();
		}
		if (this.m_exceptionTypes.get(i) == replaced)
		{
			return this;
		}
		LinkedList linkedList = new LinkedList(this.m_exceptionTypes);
		((List)linkedList).set(i, (object)replaced);
		MethodUsage result = new MethodUsage(declaration, paramTypes, this.m_returnType, linkedList, this.m_typeParametersMap);
		
		return result;
	}

	
	
	
	public virtual MethodUsage replaceReturnType(ResolvedType returnType)
	{
		if (returnType == this.m_returnType)
		{
			return this;
		}
		MethodUsage result = new MethodUsage(declaration, paramTypes, returnType, this.m_exceptionTypes, this.m_typeParametersMap);
		
		return result;
	}

	public virtual ResolvedMethodDeclaration getDeclaration()
	{
		return declaration;
	}

	
	
	public virtual string getSignature()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append(getName());
		stringBuilder.append("(");
		for (int i = 0; i < getNoParams(); i++)
		{
			if (i != 0)
			{
				stringBuilder.append(", ");
			}
			ResolvedType paramType = getParamType(i);
			if (paramType.isArray() && getDeclaration().getParam(i).isVariadic())
			{
				stringBuilder.append(paramType.asArrayType().getComponentType().describe()).append("...");
			}
			else
			{
				stringBuilder.append(paramType.describe());
			}
		}
		stringBuilder.append(")");
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	public virtual string getName()
	{
		string name = declaration.getName();
		
		return name;
	}

	
	
	
	public virtual ResolvedType getParamType(int i)
	{
		return (ResolvedType)paramTypes.get(i);
	}

	
	
	
	public MethodUsage(ResolvedMethodDeclaration declaration)
	{
		paramTypes = new ArrayList();
		this.m_exceptionTypes = new ArrayList();
		this.m_typeParametersMap = ResolvedTypeParametersMap.empty();
		this.declaration = declaration;
		for (int i = 0; i < declaration.getNumberOfParams(); i++)
		{
			paramTypes.add(declaration.getParam(i).getType());
		}
		for (int i = 0; i < declaration.getNumberOfSpecifiedExceptions(); i++)
		{
			this.m_exceptionTypes.add(declaration.getSpecifiedException(i));
		}
		this.m_returnType = declaration.getReturnType();
	}

	
		
	
	public MethodUsage(ResolvedMethodDeclaration declaration, List paramTypes, ResolvedType returnType)
		: this(declaration, paramTypes, returnType, declaration.getSpecifiedExceptions(), ResolvedTypeParametersMap.empty())
	{
	}

	
		
	
	public MethodUsage(ResolvedMethodDeclaration declaration, List paramTypes, ResolvedType returnType, List exceptionTypes)
		: this(declaration, paramTypes, returnType, exceptionTypes, ResolvedTypeParametersMap.empty())
	{
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("MethodUsage{declaration=").append(declaration).append(", paramTypes=")
			.append(paramTypes)
			.append('}')
			.ToString();
		
		return result;
	}

	
	
	public virtual ResolvedReferenceTypeDeclaration declaringType()
	{
		ResolvedReferenceTypeDeclaration result = declaration.declaringType();
		
		return result;
	}

	public virtual ResolvedType returnType()
	{
		return this.m_returnType;
	}

		public virtual List getParamTypes()
	{
		return paramTypes;
	}

	
	
	
	public virtual MethodUsage replaceTypeParameter(ResolvedTypeParameterDeclaration typeParameter, ResolvedType type)
	{
		if (type == null)
		{
			
			throw new IllegalArgumentException();
		}
		MethodUsage methodUsage = new MethodUsage(declaration, paramTypes, this.m_returnType, this.m_exceptionTypes, this.m_typeParametersMap.toBuilder().setValue(typeParameter, type).build());
		HashMap inferredTypes = new HashMap();
		ResolvedType resolvedType;
		for (int i = 0; i < paramTypes.size(); i++)
		{
			resolvedType = (ResolvedType)paramTypes.get(i);
			ResolvedType replaced = resolvedType.replaceTypeVariables(typeParameter, type, inferredTypes);
			methodUsage = methodUsage.replaceParamType(i, replaced);
		}
		for (int i = 0; i < this.m_exceptionTypes.size(); i++)
		{
			resolvedType = (ResolvedType)this.m_exceptionTypes.get(i);
			ResolvedType replaced = resolvedType.replaceTypeVariables(typeParameter, type, inferredTypes);
			methodUsage = methodUsage.replaceExceptionType(i, replaced);
		}
		ResolvedType resolvedType2 = methodUsage.m_returnType;
		resolvedType = resolvedType2.replaceTypeVariables(typeParameter, type, inferredTypes);
		return methodUsage.replaceReturnType(resolvedType);
	}

	public virtual ResolvedTypeParametersMap typeParametersMap()
	{
		return this.m_typeParametersMap;
	}

	
	
	public virtual string getQualifiedSignature()
	{
		string result = new StringBuilder().append(getDeclaration().declaringType().getQualifiedName()).append(".").append(getSignature())
			.ToString();
		
		return result;
	}

		public virtual List exceptionTypes()
	{
		return this.m_exceptionTypes;
	}
}
