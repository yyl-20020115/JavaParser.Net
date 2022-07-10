using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.javassistmodel;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.file;
using java.util;
using java.util.jar;
using javassist;

namespace com.github.javaparser.symbolsolver.resolution.typesolvers;

public class JarTypeSolver :  TypeSolver
{
	private const string CLASS_EXTENSION = ".class";

	
	private ClassPool classPool;

	
		private Map knownClasses;

	private TypeSolver parent;

	
	
	
	public JarTypeSolver(InputStream jarInputStream)
	{
		classPool = new ClassPool();
		knownClasses = new HashMap();
		addPathToJar(dumpToTempFile(jarInputStream).getAbsolutePath());
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

	
		
	public virtual SymbolReference tryToSolveType(string name)
	{
		//Discarded unreachable code: IL_003e
		string text = (string)knownClasses.get(name);
		if (text == null)
		{
			return SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
		}
		try
		{
			return SymbolReference.solved(JavassistFactory.toTypeDeclaration(classPool.get(text), getRoot()));
		}
		catch (NotFoundException)
		{
		}
		
		string s = java.lang.String.format("Unable to get class with name %s from class pool.This was not suppose to happen, please report at https://github.com/javaparser/javaparser/issues", text);
		
		throw new IllegalStateException(s);
	}

	
	
	
	public JarTypeSolver(string pathToJar)
	{
		classPool = new ClassPool();
		knownClasses = new HashMap();
		addPathToJar(pathToJar);
	}

	
	
	
	public JarTypeSolver(File pathToJar)
		: this(pathToJar.getAbsolutePath())
	{
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 78, 109, 249, 71, 226, 58, 161, 108, 104,
		135
	})]
	private void addPathToJar(string P_0)
	{
		NotFoundException ex;
		try
		{
			classPool.appendClassPath(P_0);
			registerKnownClassesFor(P_0);
			return;
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException ex2 = ex;
		FileNotFoundException ex3 = new FileNotFoundException(Throwable.instancehelper_getMessage(ex2));
		Throwable.instancehelper_initCause(ex3, ex2);
		throw Throwable.___003Cunmap_003E(ex3);
	}

	
	
	[LineNumberTable(new byte[]
	{
		117, 112, 134, 139, 137, 109, 159, 5, 127, 3,
		102, 63, 10, 102, 48, 102, 238, 57, 247, 70,
		102, 9, 127, 5, 102, 59, 102, 45, 102, 43,
		102, 33, 102, 98
	})]
	private File dumpToTempFile(InputStream P_0)
	{
		File file = File.createTempFile("jar_file_from_input_stream", ".jar");
		file.deleteOnExit();
		byte[] b = new byte[8192];
		FileOutputStream fileOutputStream;
		System.Exception ex;
		System.Exception ex2;
		System.Exception ex3;
		System.Exception ex4;
		try
		{
			fileOutputStream = new FileOutputStream(file);
			ex = null;
			try
			{
				try
				{
					int len;
					while ((len = P_0.read(b)) != -1)
					{
						fileOutputStream.write(b, 0, len);
					}
				}
				catch (System.Exception x)
				{
					ex2 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto end_IL_0021;
				}
			}
			catch (System.Exception x2)
			{
				ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
				goto IL_0088;
			}
			if (fileOutputStream != null)
			{
				if ((object)null == null)
				{
					goto IL_00b8;
				}
				try
				{
					fileOutputStream.close();
				}
				catch (System.Exception x3)
				{
					ex4 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
					goto IL_0096;
				}
			}
			goto IL_016c;
			end_IL_0021:;
		}
		catch
		{
			//try-fault
			P_0.close();
			throw;
		}
		System.Exception ex5 = ex2;
		try
		{
			ex5 = ex5;
			try
			{
				System.Exception ex6 = ex5;
				ex = ex6;
				throw Throwable.___003Cunmap_003E(ex6);
			}
			catch (System.Exception x4)
			{
				ex5 = ByteCodeHelper.MapException<System.Exception>(x4, ByteCodeHelper.MapFlags.None);
			}
		}
		catch
		{
			//try-fault
			P_0.close();
			throw;
		}
		System.Exception ex7 = ex5;
		goto IL_00f8;
		IL_00b8:
		try
		{
			fileOutputStream.close();
		}
		catch
		{
			//try-fault
			P_0.close();
			throw;
		}
		goto IL_016c;
		IL_0096:
		ex5 = ex4;
		try
		{
			System.Exception ex6 = ex5;
			Throwable.instancehelper_addSuppressed(null, ex6);
		}
		catch
		{
			//try-fault
			P_0.close();
			throw;
		}
		goto IL_016c;
		IL_016c:
		P_0.close();
		return file;
		IL_0088:
		ex7 = ex3;
		goto IL_00f8;
		IL_012b:
		System.Exception ex8;
		System.Exception ex9 = ex8;
		try
		{
			System.Exception exception = ex9;
			Throwable.instancehelper_addSuppressed(ex, exception);
		}
		catch
		{
			//try-fault
			P_0.close();
			throw;
		}
		goto IL_015d;
		IL_015d:
		System.Exception ex10;
		try
		{
			throw Throwable.___003Cunmap_003E(ex10);
		}
		catch
		{
			//try-fault
			P_0.close();
			throw;
		}
		IL_00f8:
		ex8 = ex7;
		try
		{
			ex10 = ex8;
			if (fileOutputStream != null)
			{
				if (ex == null)
				{
					goto IL_014a;
				}
				try
				{
					fileOutputStream.close();
				}
				catch (System.Exception x5)
				{
					ex8 = ByteCodeHelper.MapException<System.Exception>(x5, ByteCodeHelper.MapFlags.None);
					goto IL_012b;
				}
			}
		}
		catch
		{
			//try-fault
			P_0.close();
			throw;
		}
		goto IL_015d;
		IL_014a:
		try
		{
			fileOutputStream.close();
		}
		catch
		{
			//try-fault
			P_0.close();
			throw;
		}
		goto IL_015d;
	}

	
	
	[LineNumberTable(new byte[]
	{
		160,
		100,
		137,
		103,
		139,
		140,
		122,
		109,
		205,
		107,
		146,
		176,
		145,
		95,
		28,
		byte.MaxValue,
		39,
		43,
		237,
		85,
		127,
		22
	})]
	private void registerKnownClassesFor(string P_0)
	{
		JarFile jarFile = new JarFile(P_0);
		System.Exception ex = null;
		System.Exception ex2;
		try
		{
			try
			{
				Enumeration enumeration = jarFile.entries();
				while (enumeration.hasMoreElements())
				{
					JarEntry jarEntry = (JarEntry)enumeration.nextElement();
					if (!jarEntry.isDirectory() && java.lang.String.instancehelper_endsWith(jarEntry.getName(), ".class"))
					{
						string text = convertEntryPathToClassName(jarEntry.getName());
						string text2 = convertEntryPathToClassPoolName(jarEntry.getName());
						if (java.lang.String.instancehelper_equals(text, text2))
						{
							knownClasses.put(text, text);
						}
						else
						{
							knownClasses.put(text, text2);
						}
					}
				}
			}
			catch (System.Exception x)
			{
				ex2 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_00d0;
			}
		}
		catch
		{
			//try-fault
			System.Exception ex3;
			if (jarFile != null)
			{
				if (ex != null)
				{
					try
					{
						jarFile.close();
					}
					catch (System.Exception x2)
					{
						ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
						goto IL_00b5;
					}
				}
				else
				{
					jarFile.close();
				}
			}
			goto end_IL_0099;
			IL_00b5:
			System.Exception exception = ex3;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_0099:
			throw;
		}
		if (jarFile == null)
		{
			return;
		}
		if ((object)null != null)
		{
			System.Exception ex4;
			try
			{
				jarFile.close();
				return;
			}
			catch (System.Exception x3)
			{
				ex4 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
			}
			System.Exception exception2 = ex4;
			Throwable.instancehelper_addSuppressed(null, exception2);
		}
		else
		{
			jarFile.close();
		}
		return;
		IL_00d0:
		System.Exception ex5 = ex2;
		try
		{
			System.Exception exception2 = ex5;
			ex = exception2;
			throw Throwable.___003Cunmap_003E(exception2);
		}
		catch
		{
			//try-fault
			if (jarFile != null)
			{
				if (ex != null)
				{
					try
					{
						jarFile.close();
					}
					catch (System.Exception x4)
					{
						ex5 = ByteCodeHelper.MapException<System.Exception>(x4, ByteCodeHelper.MapFlags.None);
						goto IL_0143;
					}
				}
				else
				{
					jarFile.close();
				}
			}
			goto end_IL_0127;
			IL_0143:
			System.Exception exception = ex5;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_0127:
			throw;
		}
	}

	
	
	private static string convertEntryPathToClassName(string P_0)
	{
		if (!java.lang.String.instancehelper_endsWith(P_0, ".class"))
		{
			string s = java.lang.String.format("The entry path should end with %s", ".class");
			
			throw new IllegalArgumentException(s);
		}
		string @this = java.lang.String.instancehelper_substring(P_0, 0, java.lang.String.instancehelper_length(P_0) - java.lang.String.instancehelper_length(".class"));
		@this = java.lang.String.instancehelper_replace(@this, '/', '.');
		return java.lang.String.instancehelper_replace(@this, '$', '.');
	}

	
	
	private static string convertEntryPathToClassPoolName(string P_0)
	{
		if (!java.lang.String.instancehelper_endsWith(P_0, ".class"))
		{
			string s = java.lang.String.format("The entry path should end with %s", ".class");
			
			throw new IllegalArgumentException(s);
		}
		string @this = java.lang.String.instancehelper_substring(P_0, 0, java.lang.String.instancehelper_length(P_0) - java.lang.String.instancehelper_length(".class"));
		string result = java.lang.String.instancehelper_replace(@this, '/', '.');
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual TypeSolver getRoot()
	{
		return TypeSolver._003Cdefault_003EgetRoot(this);
	}

	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static JarTypeSolver getJarTypeSolver(string pathToJar)
	{
		JarTypeSolver result = new JarTypeSolver(pathToJar);
		
		return result;
	}

	
	
	
	public JarTypeSolver(Path pathToJar)
		: this(pathToJar.toFile())
	{
	}

	
		
	public virtual Set getKnownClasses()
	{
		Set result = knownClasses.keySet();
		
		return result;
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
