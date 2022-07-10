using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.reflectionmodel;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.resolution.typesolvers;

public class ClassLoaderTypeSolver : java.lang.TypeSolver
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon0(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024tryToSolveType_00240(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			SymbolReference result = SymbolReference.solved((ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Supplier
	{
		internal ___003C_003EAnon2()
		{
		}

		public object get()
		{
			SymbolReference result = lambda_0024tryToSolveType_00241();
			
			return result;
		}
	}

	private TypeSolver parent;

	private ClassLoader classLoader;

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedReferenceTypeDeclaration solveType(string P_0)
	{
		return TypeSolver._003Cdefault_003EsolveType(this, P_0);
	}

	protected internal virtual bool filterName(string name)
	{
		return true;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual TypeSolver getRoot()
	{
		return TypeSolver._003Cdefault_003EgetRoot(this);
	}

	
		[LineNumberTable(new byte[]
	{
		21, 204, 104, 208, 109, 127, 16, 225, 71, 107,
		129, 105, 100, 139, 105, 107, 105, 105, 108, 101,
		125, 123, 42, 161, 235, 69
	})]
	public virtual SymbolReference tryToSolveType(string name)
	{
		//Discarded unreachable code: IL_0044
		if (filterName(name))
		{
			try
			{
				try
				{
					if (classLoader == null)
					{
						
						throw new RuntimeException("The ClassLoaderTypeSolver has been probably loaded through the bootstrap class loader. This usage is not supported by the JavaSymbolSolver");
					}
					Class clazz = classLoader.loadClass(name);
					return SymbolReference.solved(ReflectionFactory.typeDeclarationFor(clazz, getRoot()));
				}
				catch (System.Exception x)
				{
					if (ByteCodeHelper.MapException<java.lang.NoClassDefFoundError>(x, ByteCodeHelper.MapFlags.Unused) == null)
					{
						throw;
					}
				}
			}
			catch (java.lang.ClassNotFoundException)
			{
				goto IL_005c;
			}
			
			return SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
		}
		return SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
		IL_005c:
		
		int num = java.lang.String.instancehelper_lastIndexOf(name, 46);
		if (num == -1)
		{
			return SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
		}
		string name2 = java.lang.String.instancehelper_substring(name, 0, num);
		string text = java.lang.String.instancehelper_substring(name, num + 1);
		SymbolReference symbolReference = tryToSolveType(name2);
		if (symbolReference.isSolved())
		{
			Optional optional = ((ResolvedReferenceTypeDeclaration)symbolReference.getCorrespondingDeclaration()).internalTypes().stream().filter(new ___003C_003EAnon0(text))
				.findFirst();
			return (SymbolReference)optional.map(new ___003C_003EAnon1()).orElseGet(new ___003C_003EAnon2());
		}
		return SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
	}

	
	
	
	private static bool lambda_0024tryToSolveType_00240(string P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		bool result = java.lang.String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static SymbolReference lambda_0024tryToSolveType_00241()
	{
		SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
		
		return result;
	}

	
	
	public ClassLoaderTypeSolver(ClassLoader classLoader)
	{
		this.classLoader = classLoader;
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
