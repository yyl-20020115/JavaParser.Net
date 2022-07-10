using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithDeclaration
{
	
	public static class __DefaultMethods
	{
		public unsafe static string getDeclarationAsString(NodeWithDeclaration P_0)
		{
			
			return _003Cdefault_003EgetDeclarationAsString(P_0);
		}

		public unsafe static string getDeclarationAsString(NodeWithDeclaration P_0, bool P_1, bool P_2)
		{
			
			return _003Cdefault_003EgetDeclarationAsString(P_0, P_1, P_2);
		}
	}

	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual string getDeclarationAsString(bool includingModifiers, bool includingThrows, bool includingParameterName);

	
	virtual string getDeclarationAsString();

	
	
	
	static string _003Cdefault_003EgetDeclarationAsString(NodeWithDeclaration P_0)
	{
		string declarationAsString = P_0.getDeclarationAsString(includingModifiers: true, includingThrows: true, includingParameterName: true);
		
		return declarationAsString;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual string getDeclarationAsString(bool includingModifiers, bool includingThrows);

	
	
	
	static string _003Cdefault_003EgetDeclarationAsString(NodeWithDeclaration P_0, bool P_1, bool P_2)
	{
		string declarationAsString = P_0.getDeclarationAsString(P_1, P_2, includingParameterName: true);
		
		return declarationAsString;
	}
}
