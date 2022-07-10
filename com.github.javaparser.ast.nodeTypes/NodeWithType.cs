using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithType
{
	
	public static class __DefaultMethods
	{
		public unsafe static Node setType(NodeWithType P_0, Class P_1)
		{
			
			return _003Cdefault_003EsetType(P_0, P_1);
		}

		public unsafe static Node setType(NodeWithType P_0, string P_1)
		{
			
			return _003Cdefault_003EsetType(P_0, P_1);
		}

		public unsafe static string getTypeAsString(NodeWithType P_0)
		{
			
			return _003Cdefault_003EgetTypeAsString(P_0);
		}
	}

	
		
	virtual Node setType(string typeString);

	
	
	
	static Node _003Cdefault_003EsetType(NodeWithType P_0, string P_1)
	{
		Utils.assertNonEmpty(P_1);
		Node result = P_0.setType(StaticJavaParser.parseType(P_1));
		
		return result;
	}

		
	virtual void tryAddImportToParentCompilationUnit(Class clazz);

		
	virtual Node setType(Type type);

		virtual Type getType();

	
		
	virtual Node setType(Class typeClass);

	
	
	
	static Node _003Cdefault_003EsetType(NodeWithType P_0, Class P_1)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		Node result = P_0.setType(StaticJavaParser.parseType(P_1.getSimpleName()));
		
		return result;
	}

	
	virtual string getTypeAsString();

	
	
	
	static string _003Cdefault_003EgetTypeAsString(NodeWithType P_0)
	{
		string result = P_0.getType().asString();
		
		return result;
	}
}
