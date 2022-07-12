using System;

using com.github.javaparser.ast.type;

using java.lang;

namespace com.github.javaparser.ast.nodeTypes;

public abstract class NodeWithImplements
{
	
	public static class __DefaultMethods
	{
		public unsafe static ClassOrInterfaceType getImplementedTypes(NodeWithImplements P_0, int P_1)
		{
			
			return _003Cdefault_003EgetImplementedTypes(P_0, P_1);
		}

		public unsafe static Node setImplementedType(NodeWithImplements P_0, int P_1, ClassOrInterfaceType P_2)
		{
			
			return _003Cdefault_003EsetImplementedType(P_0, P_1, P_2);
		}

		public unsafe static Node addImplementedType(NodeWithImplements P_0, ClassOrInterfaceType P_1)
		{
			
			return _003Cdefault_003EaddImplementedType(P_0, P_1);
		}

		public unsafe static Node addImplements(NodeWithImplements P_0, string P_1)
		{
			
			return _003Cdefault_003EaddImplements(P_0, P_1);
		}

		public unsafe static Node addImplements(NodeWithImplements P_0, Class P_1)
		{
			
			return _003Cdefault_003EaddImplements(P_0, P_1);
		}

		public unsafe static Node addImplementedType(NodeWithImplements P_0, string P_1)
		{
			
			return _003Cdefault_003EaddImplementedType(P_0, P_1);
		}

		public unsafe static Node addImplementedType(NodeWithImplements P_0, Class P_1)
		{
			
			return _003Cdefault_003EaddImplementedType(P_0, P_1);
		}
	}

		virtual NodeList getImplementedTypes();

	
		
	virtual Node addImplementedType(string name);

	
	
	
	static Node _003Cdefault_003EaddImplementedType(NodeWithImplements P_0, string P_1)
	{
		P_0.getImplementedTypes().add(StaticJavaParser.parseClassOrInterfaceType(P_1));
		return (Node)P_0;
	}

	
		
	virtual Node addImplementedType(Class clazz);

	
	
	
	static Node _003Cdefault_003EaddImplementedType(NodeWithImplements P_0, Class P_1)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		Node result = P_0.addImplementedType(P_1.getSimpleName());
		
		return result;
	}

		
	virtual void tryAddImportToParentCompilationUnit(Class clazz);

	
	
	virtual ClassOrInterfaceType getImplementedTypes(int i);

	
	
	
	static ClassOrInterfaceType _003Cdefault_003EgetImplementedTypes(NodeWithImplements P_0, int P_1)
	{
		return (ClassOrInterfaceType)P_0.getImplementedTypes().get(P_1);
	}

		
	virtual Node setImplementedTypes(NodeList implementsList);

	
		
	virtual Node setImplementedType(int i, ClassOrInterfaceType implement);

	
	
	
	static Node _003Cdefault_003EsetImplementedType(NodeWithImplements P_0, int P_1, ClassOrInterfaceType P_2)
	{
		P_0.getImplementedTypes().set(P_1, P_2);
		return (Node)P_0;
	}

	
		
	virtual Node addImplementedType(ClassOrInterfaceType implement);

	
	
	
	static Node _003Cdefault_003EaddImplementedType(NodeWithImplements P_0, ClassOrInterfaceType P_1)
	{
		P_0.getImplementedTypes().add(P_1);
		return (Node)P_0;
	}

	
	
		
	virtual Node addImplements(string name);

	
	
	
	static Node _003Cdefault_003EaddImplements(NodeWithImplements P_0, string P_1)
	{
		Node result = P_0.addImplementedType(P_1);
		
		return result;
	}

	
	
		
	virtual Node addImplements(Class clazz);

	
	
	
	static Node _003Cdefault_003EaddImplements(NodeWithImplements P_0, Class P_1)
	{
		Node result = P_0.addImplementedType(P_1);
		
		return result;
	}
}
