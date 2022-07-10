using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedPatternDeclaration : ResolvedValueDeclaration, ResolvedDeclaration
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isPattern(ResolvedPatternDeclaration P_0)
		{
			
			return _003Cdefault_003EisPattern(P_0);
		}

		public unsafe static ResolvedPatternDeclaration asPattern(ResolvedPatternDeclaration P_0)
		{
			
			return _003Cdefault_003EasPattern(P_0);
		}

		public unsafe static bool hasName(ResolvedPatternDeclaration P_0)
		{
			
			return _003Cdefault_003EhasName(P_0);
		}

		public unsafe static string describeType(ResolvedPatternDeclaration P_0)
		{
			
			return _003Cdefault_003EdescribeType(P_0);
		}
	}

	
	bool isPattern();

	
	static bool _003Cdefault_003EisPattern(ResolvedPatternDeclaration P_0)
	{
		return true;
	}

	
	ResolvedPatternDeclaration asPattern();

	
	static ResolvedPatternDeclaration _003Cdefault_003EasPattern(ResolvedPatternDeclaration P_0)
	{
		return P_0;
	}

	
	bool hasName();

	
	static bool _003Cdefault_003EhasName(ResolvedPatternDeclaration P_0)
	{
		return true;
	}

	
	virtual string describeType();

	
	
	
	static string _003Cdefault_003EdescribeType(ResolvedPatternDeclaration P_0)
	{
		string result = P_0.getType().describe();
		
		return result;
	}
}
