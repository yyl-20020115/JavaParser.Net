
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.types;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class MethodType
{
		private List typeParameters;

		private List formalArgumentTypes;

	private ResolvedType returnType;

		private List exceptionTypes;

		public virtual List getFormalArgumentTypes()
	{
		return formalArgumentTypes;
	}

	public virtual ResolvedType getReturnType()
	{
		return returnType;
	}

		public virtual List getTypeParameters()
	{
		return typeParameters;
	}

		public virtual List getExceptionTypes()
	{
		return exceptionTypes;
	}

	
		
	public MethodType(List typeParameters, List formalArgumentTypes, ResolvedType returnType, List exceptionTypes)
	{
		this.typeParameters = typeParameters;
		this.formalArgumentTypes = formalArgumentTypes;
		this.returnType = returnType;
		this.exceptionTypes = exceptionTypes;
	}

	
	
	public static MethodType fromMethodUsage(MethodUsage methodUsage)
	{
		MethodType result = new MethodType(methodUsage.getDeclaration().getTypeParameters(), methodUsage.getParamTypes(), methodUsage.returnType(), methodUsage.exceptionTypes());
		
		return result;
	}
}
