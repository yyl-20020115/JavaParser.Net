using System;

using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.cache;
using com.github.javaparser.symbolsolver.model.resolution;

using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.resolution.typesolvers;

public class CombinedTypeSolver : java.lang.TypeSolver
{
	public class ExceptionHandlers
	{
		
		private sealed class ___003C_003EAnon0 : Predicate
		{
			private readonly Class[] arg_00241;

			internal ___003C_003EAnon0(Class[] P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024getTypeBasedBlacklist_00242(arg_00241, (System.Exception)P_0);
				
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

		
		private sealed class ___003C_003EAnon1 : Predicate
		{
			private readonly Class[] arg_00241;

			internal ___003C_003EAnon1(Class[] P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024getTypeBasedWhitelist_00243(arg_00241, (System.Exception)P_0);
				
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

		
		private sealed class ___003C_003EAnon2 : Predicate
		{
			internal ___003C_003EAnon2()
			{
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024static_00240((System.Exception)P_0);
				
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

		
		private sealed class ___003C_003EAnon3 : Predicate
		{
			internal ___003C_003EAnon3()
			{
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024static_00241((System.Exception)P_0);
				
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

				internal static Predicate ___003C_003EIGNORE_NONE;

				internal static Predicate ___003C_003EIGNORE_ALL;

				internal static Predicate ___003C_003EIGNORE_UNSUPPORTED_OPERATION;

				internal static Predicate ___003C_003EIGNORE_UNSOLVED_SYMBOL;

				internal static Predicate ___003C_003EIGNORE_UNSUPPORTED_AND_UNSOLVED;

		
		public static Predicate IGNORE_NONE
		{
			
			get
			{
				return ___003C_003EIGNORE_NONE;
			}
		}

		
		public static Predicate IGNORE_ALL
		{
			
			get
			{
				return ___003C_003EIGNORE_ALL;
			}
		}

		
		public static Predicate IGNORE_UNSUPPORTED_OPERATION
		{
			
			get
			{
				return ___003C_003EIGNORE_UNSUPPORTED_OPERATION;
			}
		}

		
		public static Predicate IGNORE_UNSOLVED_SYMBOL
		{
			
			get
			{
				return ___003C_003EIGNORE_UNSOLVED_SYMBOL;
			}
		}

		
		public static Predicate IGNORE_UNSUPPORTED_AND_UNSOLVED
		{
			
			get
			{
				return ___003C_003EIGNORE_UNSUPPORTED_AND_UNSOLVED;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				
		public static Predicate getTypeBasedWhitelist(params Class[] whitelist)
		{
			return new ___003C_003EAnon1(whitelist);
		}

		
		
		
		private static bool lambda_0024getTypeBasedBlacklist_00242(Class[] P_0, System.Exception P_1)
		{
			int num = P_0.Length;
			for (int i = 0; i < num; i++)
			{
				Class @class = P_0[i];
				if (@class.isAssignableFrom(java.lang.Object.instancehelper_getClass(P_1)))
				{
					return false;
				}
			}
			return true;
		}

		
		
		
		private static bool lambda_0024getTypeBasedWhitelist_00243(Class[] P_0, System.Exception P_1)
		{
			int num = P_0.Length;
			for (int i = 0; i < num; i++)
			{
				Class @class = P_0[i];
				if (@class.isAssignableFrom(java.lang.Object.instancehelper_getClass(P_1)))
				{
					return true;
				}
			}
			return false;
		}

		
		private static bool lambda_0024static_00240(System.Exception P_0)
		{
			return false;
		}

		
		private static bool lambda_0024static_00241(System.Exception P_0)
		{
			return true;
		}

		
		
		public ExceptionHandlers()
		{
		}

		
				
		public static Predicate getTypeBasedBlacklist(params Class[] blacklist)
		{
			return new ___003C_003EAnon0(blacklist);
		}

		
		static ExceptionHandlers()
		{
			___003C_003EIGNORE_NONE = new ___003C_003EAnon2();
			___003C_003EIGNORE_ALL = new ___003C_003EAnon3();
			___003C_003EIGNORE_UNSUPPORTED_OPERATION = getTypeBasedWhitelist(ClassLiteral<UnsupportedOperationException>.Value);
			___003C_003EIGNORE_UNSOLVED_SYMBOL = getTypeBasedWhitelist(ClassLiteral<UnsolvedSymbolException>.Value);
			___003C_003EIGNORE_UNSUPPORTED_AND_UNSOLVED = getTypeBasedWhitelist(ClassLiteral<UnsupportedOperationException>.Value, ClassLiteral<UnsolvedSymbolException>.Value);
		}
	}

	
		private Cache typeCache;

	private TypeSolver parent;

		private List elements;

		private Predicate exceptionHandler;

	
		
	public CombinedTypeSolver(Iterable elements)
		: this(ExceptionHandlers.___003C_003EIGNORE_NONE, elements)
	{
	}

	
		
	public CombinedTypeSolver(Predicate exceptionHandler, Iterable elements)
		: this(exceptionHandler, elements, NoCache.create())
	{
	}

	
		
	public CombinedTypeSolver(Predicate exceptionHandler, Iterable elements, Cache typeCache)
	{
		this.elements = new ArrayList();
		Objects.requireNonNull(typeCache, "The typeCache can't be null.");
		setExceptionHandler(exceptionHandler);
		this.typeCache = typeCache;
		Iterator iterator = elements.iterator();
		while (iterator.hasNext())
		{
			TypeSolver typeSolver = (TypeSolver)iterator.next();
			add(typeSolver, resetCache: false);
		}
	}

		public virtual void setExceptionHandler(Predicate exceptionHandler)
	{
		this.exceptionHandler = exceptionHandler;
	}

	
	
	public virtual void add(TypeSolver typeSolver, bool resetCache)
	{
		Objects.requireNonNull(typeSolver, "The type solver can't be null");
		elements.add(typeSolver);
		typeSolver.setParent(this);
		if (resetCache)
		{
			typeCache.removeAll();
		}
	}

	
		
	public virtual SymbolReference tryToSolveType(string name)
	{
		//Discarded unreachable code: IL_0066
		Optional optional = typeCache.get(name);
		if (optional.isPresent())
		{
			return (SymbolReference)optional.get();
		}
		Iterator iterator = elements.iterator();
		while (iterator.hasNext())
		{
			TypeSolver typeSolver = (TypeSolver)iterator.next();
			System.Exception ex2;
			try
			{
				SymbolReference symbolReference = typeSolver.tryToSolveType(name);
				if (symbolReference.isSolved())
				{
					typeCache.put(name, symbolReference);
					return symbolReference;
				}
			}
			catch (System.Exception x)
			{
				System.Exception ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				if (ex == null)
				{
					throw;
				}
				ex2 = ex;
				goto IL_0081;
			}
			continue;
			IL_0081:
			System.Exception ex3 = ex2;
			if (!exceptionHandler.test(ex3))
			{
				throw (ex3);
			}
		}
		SymbolReference symbolReference2 = SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
		typeCache.put(name, symbolReference2);
		return symbolReference2;
	}

	
	
	public CombinedTypeSolver(params TypeSolver[] elements)
		: this(Arrays.asList(elements))
	{
	}

	
		
	public CombinedTypeSolver(Predicate exceptionHandler, params TypeSolver[] elements)
		: this(exceptionHandler, Arrays.asList(elements))
	{
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

	
	
	public virtual void add(TypeSolver typeSolver)
	{
		add(typeSolver, resetCache: true);
	}

	
	
	
	public virtual ResolvedReferenceTypeDeclaration solveType(string name)
	{
		SymbolReference symbolReference = tryToSolveType(name);
		if (symbolReference.isSolved())
		{
			return (ResolvedReferenceTypeDeclaration)symbolReference.getCorrespondingDeclaration();
		}
		
		throw new UnsolvedSymbolException(name);
	}


	public virtual TypeSolver getRoot()
	{
		return TypeSolver._003Cdefault_003EgetRoot(this);
	}


	public virtual ResolvedReferenceTypeDeclaration getSolvedJavaLangObject()
	{
		return TypeSolver._003Cdefault_003EgetSolvedJavaLangObject(this);
	}


	public virtual bool hasType(string P_0)
	{
		return TypeSolver._003Cdefault_003EhasType(this, P_0);
	}
}
