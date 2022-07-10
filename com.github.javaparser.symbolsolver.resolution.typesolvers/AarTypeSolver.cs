using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.nio.file;
using java.util.jar;
using java.util.zip;

namespace com.github.javaparser.symbolsolver.resolution.typesolvers;

public class AarTypeSolver : TypeSolver
{
	private JarTypeSolver @delegate;

	
	
	
	public AarTypeSolver(File aarFile)
	{
		JarFile jarFile = new JarFile(aarFile);
		ZipEntry entry = jarFile.getEntry("classes.jar");
		if (entry == null)
		{
			string s = String.format("The given file (%s) is malformed: entry classes.jar was not found", aarFile.getAbsolutePath());
			
			throw new IllegalArgumentException(s);
		}
		@delegate = new JarTypeSolver(jarFile.getInputStream(entry));
	}

	
	
	
	public AarTypeSolver(string aarFile)
		: this(new File(aarFile))
	{
	}

	
	
	
	public AarTypeSolver(Path aarFile)
		: this(aarFile.toFile())
	{
	}

	
	
	public virtual TypeSolver getParent()
	{
		TypeSolver parent = @delegate.getParent();
		
		return parent;
	}

	
	
	public virtual void setParent(TypeSolver parent)
	{
		if (parent == this)
		{
			
			throw new IllegalStateException("The parent of this TypeSolver cannot be itself.");
		}
		@delegate.setParent(parent);
	}

	
		
	public virtual SymbolReference tryToSolveType(string name)
	{
		SymbolReference result = @delegate.tryToSolveType(name);
		
		return result;
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
