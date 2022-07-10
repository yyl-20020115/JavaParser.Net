using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedEnumConstantDeclaration : ResolvedValueDeclaration, ResolvedDeclaration
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isEnumConstant(ResolvedEnumConstantDeclaration P_0)
		{
			
			return _003Cdefault_003EisEnumConstant(P_0);
		}

		public unsafe static ResolvedEnumConstantDeclaration asEnumConstant(ResolvedEnumConstantDeclaration P_0)
		{
			
			return _003Cdefault_003EasEnumConstant(P_0);
		}
	}

	string getName();

	
	bool isEnumConstant();

	
	static bool _003Cdefault_003EisEnumConstant(ResolvedEnumConstantDeclaration P_0)
	{
		return true;
	}

	
	ResolvedEnumConstantDeclaration asEnumConstant();

	
	static ResolvedEnumConstantDeclaration _003Cdefault_003EasEnumConstant(ResolvedEnumConstantDeclaration P_0)
	{
		return P_0;
	}
}
