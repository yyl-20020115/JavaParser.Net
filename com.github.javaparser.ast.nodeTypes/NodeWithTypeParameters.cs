
using com.github.javaparser.ast.type;


namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithTypeParameters
{
	
	public static class __DefaultMethods
	{
		public unsafe static TypeParameter getTypeParameter(NodeWithTypeParameters P_0, int P_1)
		{
			
			return _003Cdefault_003EgetTypeParameter(P_0, P_1);
		}

		public unsafe static Node setTypeParameter(NodeWithTypeParameters P_0, int P_1, TypeParameter P_2)
		{
			
			return _003Cdefault_003EsetTypeParameter(P_0, P_1, P_2);
		}

		public unsafe static Node addTypeParameter(NodeWithTypeParameters P_0, TypeParameter P_1)
		{
			
			return _003Cdefault_003EaddTypeParameter(P_0, P_1);
		}

		public unsafe static Node addTypeParameter(NodeWithTypeParameters P_0, string P_1)
		{
			
			return _003Cdefault_003EaddTypeParameter(P_0, P_1);
		}

		public unsafe static bool isGeneric(NodeWithTypeParameters P_0)
		{
			
			return _003Cdefault_003EisGeneric(P_0);
		}
	}

		virtual NodeList getTypeParameters();

	
		
	virtual Node addTypeParameter(TypeParameter typeParameter);

	
	
	
	static Node _003Cdefault_003EaddTypeParameter(NodeWithTypeParameters P_0, TypeParameter P_1)
	{
		P_0.getTypeParameters().add(P_1);
		return (Node)P_0;
	}

	
	
	virtual TypeParameter getTypeParameter(int i);

	
	
	
	static TypeParameter _003Cdefault_003EgetTypeParameter(NodeWithTypeParameters P_0, int P_1)
	{
		return (TypeParameter)P_0.getTypeParameters().get(P_1);
	}

	
		
	virtual Node setTypeParameter(int i, TypeParameter typeParameter);

	
	
	
	static Node _003Cdefault_003EsetTypeParameter(NodeWithTypeParameters P_0, int P_1, TypeParameter P_2)
	{
		P_0.getTypeParameters().set(P_1, P_2);
		return (Node)P_0;
	}

	
		
	virtual Node addTypeParameter(string typeParameter);

	
	
	
	static Node _003Cdefault_003EaddTypeParameter(NodeWithTypeParameters P_0, string P_1)
	{
		Node result = P_0.addTypeParameter(StaticJavaParser.parseTypeParameter(P_1));
		
		return result;
	}

		
	virtual Node setTypeParameters(NodeList typeParameters);

	
	virtual bool isGeneric();

	
	
	
	static bool _003Cdefault_003EisGeneric(NodeWithTypeParameters P_0)
	{
		return P_0.getTypeParameters().size() > 0;
	}
}
