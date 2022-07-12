

using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.typesolvers;

public class ReflectionTypeSolver : ClassLoaderTypeSolver
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private bool jreOnly;

	
	private static CallerID ___003CcallerID_003E;

	
	
	public ReflectionTypeSolver()
		: this(jreOnly: true)
	{
	}

	
	
	public ReflectionTypeSolver(bool jreOnly)
		: base(ClassLiteral<ReflectionTypeSolver>.Value.getClassLoader(ReflectionTypeSolver.___003CGetCallerID_003E()))
	{
		this.jreOnly = jreOnly;
	}

	
	
	protected internal override bool filterName(string name)
	{
		return (!jreOnly || String.instancehelper_startsWith(name, "java.") || String.instancehelper_startsWith(name, "javax.")) ? true : false;
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
