using System.Runtime.CompilerServices;
using com.github.javaparser.printer.concretesyntaxmodel;
using IKVM.Attributes;

namespace com.github.javaparser.printer.lexicalpreservation;

public interface DifferenceElement
{
	
	public static class __DefaultMethods
	{
		public unsafe static bool isChild(DifferenceElement P_0)
		{
			
			return _003Cdefault_003EisChild(P_0);
		}

		public unsafe static DifferenceElement replaceEolTokens(DifferenceElement P_0, CsmElement P_1)
		{
			
			return _003Cdefault_003EreplaceEolTokens(P_0, P_1);
		}
	}

	
	public static class __Methods
	{
		public static DifferenceElement added(CsmElement P_0)
		{
			return DifferenceElement.added(P_0);
		}

		public static DifferenceElement removed(CsmElement P_0)
		{
			return DifferenceElement.removed(P_0);
		}

		public static DifferenceElement kept(CsmElement P_0)
		{
			return DifferenceElement.kept(P_0);
		}
	}

	virtual CsmElement getElement();

	
	
	
	static DifferenceElement added(CsmElement element)
	{
		Added result = new Added(element);
		
		return result;
	}

	
	
	
	static DifferenceElement removed(CsmElement element)
	{
		Removed result = new Removed(element);
		
		return result;
	}

	
	
	
	static DifferenceElement kept(CsmElement element)
	{
		Kept result = new Kept(element);
		
		return result;
	}

	virtual bool isAdded();

	virtual bool isRemoved();

	
	virtual bool isChild();

	
	
	
	static bool _003Cdefault_003EisChild(DifferenceElement P_0)
	{
		return P_0.getElement() is LexicalDifferenceCalculator.CsmChild;
	}

	
	
	virtual DifferenceElement replaceEolTokens(CsmElement lineSeparator);

	
	static DifferenceElement _003Cdefault_003EreplaceEolTokens(DifferenceElement P_0, CsmElement P_1)
	{
		return P_0;
	}
}
