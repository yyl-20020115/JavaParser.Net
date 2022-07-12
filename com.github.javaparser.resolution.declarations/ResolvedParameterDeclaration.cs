

using java.lang;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedParameterDeclaration : ResolvedValueDeclaration, ResolvedDeclaration
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isParameter(ResolvedParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EisParameter(P_0);
		}

		public unsafe static bool hasName(ResolvedParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EhasName(P_0);
		}

		public unsafe static ResolvedParameterDeclaration asParameter(ResolvedParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EasParameter(P_0);
		}

		public unsafe static string describeType(ResolvedParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EdescribeType(P_0);
		}
	}

	
	virtual string describeType();

	
	
	
	static string _003Cdefault_003EdescribeType(ResolvedParameterDeclaration P_0)
	{
		if (P_0.isVariadic())
		{
			string result = new StringBuilder().append(P_0.getType().asArrayType().getComponentType()
				.describe()).append("...").ToString();
			
			return result;
		}
		string result2 = P_0.getType().describe();
		
		return result2;
	}

	virtual bool isVariadic();

	
	bool isParameter();

	
	static bool _003Cdefault_003EisParameter(ResolvedParameterDeclaration P_0)
	{
		return true;
	}

	
	bool hasName();

	
	static bool _003Cdefault_003EhasName(ResolvedParameterDeclaration P_0)
	{
		return true;
	}

	
	ResolvedParameterDeclaration asParameter();

	
	static ResolvedParameterDeclaration _003Cdefault_003EasParameter(ResolvedParameterDeclaration P_0)
	{
		return P_0;
	}
}
