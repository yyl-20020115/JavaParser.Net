
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.model.resolution;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typesolvers;

public class MemoryTypeSolver: TypeSolver
{
	private TypeSolver parent;

		private Map declarationMap;

	
	
	public MemoryTypeSolver()
	{
		declarationMap = new HashMap();
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("MemoryTypeSolver{parent=").append(parent).append(", declarationMap=")
			.append(declarationMap)
			.append('}')
			.ToString();
		
		return result;
	}

	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (!(o is MemoryTypeSolver))
		{
			return false;
		}
		MemoryTypeSolver memoryTypeSolver = (MemoryTypeSolver)o;
		if (parent != null)
		{
			if (!Object.instancehelper_equals(parent, memoryTypeSolver.parent))
			{
				goto IL_003c;
			}
		}
		else if (memoryTypeSolver.parent != null)
		{
			goto IL_003c;
		}
		if (declarationMap != null)
		{
			if (declarationMap.equals(memoryTypeSolver.declarationMap))
			{
				goto IL_0063;
			}
		}
		else if (memoryTypeSolver.declarationMap == null)
		{
			goto IL_0063;
		}
		int result = 0;
		goto IL_0067;
		IL_003c:
		return false;
		IL_0063:
		result = 1;
		goto IL_0067;
		IL_0067:
		return (byte)result != 0;
	}

	
	
	public override int GetHashCode()
	{
		int num = ((parent != null) ? Object.instancehelper_hashCode(parent) : 0);
		return 31 * num + ((declarationMap != null) ? declarationMap.GetHashCode() : 0);
	}

	public virtual TypeSolver getParent()
	{
		return parent;
	}

	
	
	public virtual void setParent(TypeSolver parent)
	{
		Objects.requireNonNull(parent);
		if (this.parent != null)
		{
			
			throw new IllegalStateException("This TypeSolver already has a parent.");
		}
		if (parent == this)
		{
			
			throw new IllegalStateException("The parent of this TypeSolver cannot be itself.");
		}
		this.parent = parent;
	}

	
	
	public virtual void addDeclaration(string name, ResolvedReferenceTypeDeclaration typeDeclaration)
	{
		declarationMap.put(name, typeDeclaration);
	}

	
		
	public virtual SymbolReference tryToSolveType(string name)
	{
		if (declarationMap.containsKey(name))
		{
			SymbolReference result = SymbolReference.solved((ResolvedDeclaration)declarationMap.get(name));
			
			return result;
		}
		SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
		
		return result2;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual TypeSolver getRoot()
	{
		return TypeSolver._003Cdefault_003EgetRoot(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedReferenceTypeDeclaration solveType(string P_0)
	{
		return TypeSolver._003Cdefault_003EsolveType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedReferenceTypeDeclaration getSolvedJavaLangObject()
	{
		return TypeSolver._003Cdefault_003EgetSolvedJavaLangObject(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasType(string P_0)
	{
		return TypeSolver._003Cdefault_003EhasType(this, P_0);
	}
}
