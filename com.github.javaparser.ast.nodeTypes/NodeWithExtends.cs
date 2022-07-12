using System;

using com.github.javaparser.ast.type;

using java.lang;

namespace com.github.javaparser.ast.nodeTypes;

public abstract class NodeWithExtends
{
	
	public static class __DefaultMethods
	{
		public unsafe static ClassOrInterfaceType getExtendedTypes(NodeWithExtends P_0, int P_1)
		{
			
			return _003Cdefault_003EgetExtendedTypes(P_0, P_1);
		}

		public unsafe static Node setExtendedType(NodeWithExtends P_0, int P_1, ClassOrInterfaceType P_2)
		{
			
			return _003Cdefault_003EsetExtendedType(P_0, P_1, P_2);
		}

		public unsafe static Node addExtendedType(NodeWithExtends P_0, ClassOrInterfaceType P_1)
		{
			
			return _003Cdefault_003EaddExtendedType(P_0, P_1);
		}

		public unsafe static Node addExtends(NodeWithExtends P_0, Class P_1)
		{
			
			return _003Cdefault_003EaddExtends(P_0, P_1);
		}

		public unsafe static Node addExtends(NodeWithExtends P_0, string P_1)
		{
			
			return _003Cdefault_003EaddExtends(P_0, P_1);
		}

		public unsafe static Node addExtendedType(NodeWithExtends P_0, Class P_1)
		{
			
			return _003Cdefault_003EaddExtendedType(P_0, P_1);
		}

		public unsafe static Node addExtendedType(NodeWithExtends P_0, string P_1)
		{
			
			return _003Cdefault_003EaddExtendedType(P_0, P_1);
		}
	}

	public abstract NodeList getExtendedTypes();

	

	public abstract Node addExtendedType(Class clazz);

	
	
	
	static Node _003Cdefault_003EaddExtendedType(NodeWithExtends P_0, Class P_1)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		Node result = P_0.addExtendedType(P_1.getSimpleName());
		
		return result;
	}

	
		
	abstract Node addExtendedType(string name);

	
	
	
	static Node _003Cdefault_003EaddExtendedType(NodeWithExtends P_0, string P_1)
	{
		P_0.getExtendedTypes().add(StaticJavaParser.parseClassOrInterfaceType(P_1));
		return (Node)P_0;
	}

		
	abstract void tryAddImportToParentCompilationUnit(Class clazz);

	

	abstract ClassOrInterfaceType getExtendedTypes(int i);

	
	
	
	static ClassOrInterfaceType _003Cdefault_003EgetExtendedTypes(NodeWithExtends P_0, int P_1)
	{
		return (ClassOrInterfaceType)P_0.getExtendedTypes().get(P_1);
	}

		
	virtual Node setExtendedTypes(NodeList extendsList);

	
		
	abstract Node setExtendedType(int i, ClassOrInterfaceType extend);

	
	
	
	static Node _003Cdefault_003EsetExtendedType(NodeWithExtends P_0, int P_1, ClassOrInterfaceType P_2)
	{
		P_0.getExtendedTypes().set(P_1, P_2);
		return (Node)P_0;
	}

	

	abstract Node addExtendedType(ClassOrInterfaceType extend);

	
	
	
	static Node _003Cdefault_003EaddExtendedType(NodeWithExtends P_0, ClassOrInterfaceType P_1)
	{
		P_0.getExtendedTypes().add(P_1);
		return (Node)P_0;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	abstract Node addExtends(Class clazz);

	
	
	
	public static Node _003Cdefault_003EaddExtends(NodeWithExtends P_0, Class P_1)
	{
		Node result = P_0.addExtendedType(P_1);
		
		return result;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	abstract Node addExtends(string name);

	
	
	
	static Node _003Cdefault_003EaddExtends(NodeWithExtends P_0, string P_1)
	{
		Node result = P_0.addExtendedType(P_1);
		
		return result;
	}
}
