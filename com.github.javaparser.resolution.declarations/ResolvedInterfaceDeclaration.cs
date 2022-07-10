using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedInterfaceDeclaration : ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isInterface(ResolvedInterfaceDeclaration P_0)
		{
			
			return _003Cdefault_003EisInterface(P_0);
		}

		public unsafe static List getAllInterfacesExtended(ResolvedInterfaceDeclaration P_0)
		{
			
			return _003Cdefault_003EgetAllInterfacesExtended(P_0);
		}
	}

		virtual List getInterfacesExtended();

	
	bool isInterface();

	
	static bool _003Cdefault_003EisInterface(ResolvedInterfaceDeclaration P_0)
	{
		return true;
	}

	
		virtual List getAllInterfacesExtended();

	
	
	
	static List _003Cdefault_003EgetAllInterfacesExtended(ResolvedInterfaceDeclaration P_0)
	{
		ArrayList arrayList = new ArrayList();
		Iterator iterator = P_0.getInterfacesExtended().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			((List)arrayList).add((object)resolvedReferenceType);
			((List)arrayList).addAll((Collection)resolvedReferenceType.getAllInterfacesAncestors());
		}
		return arrayList;
	}
}
