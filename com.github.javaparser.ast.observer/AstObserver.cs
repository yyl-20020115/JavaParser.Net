using System;


using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.ast.observer;

public class AstObserver
{
	
	
	
	public class ListChangeType : java.lang.Enum
	{
		
		
		public enum __Enum
		{
			ADDITION,
			REMOVAL
		}

		
		internal static ListChangeType ___003C_003EADDITION;

		
		internal static ListChangeType ___003C_003EREMOVAL;

		
		private static ListChangeType[] _0024VALUES;

		
		public static ListChangeType ADDITION
		{
			
			get
			{
				return ___003C_003EADDITION;
			}
		}

		
		public static ListChangeType REMOVAL
		{
			
			get
			{
				return ___003C_003EREMOVAL;
			}
		}


		
		public static void ___003Cclinit_003E()
		{
		}


		
		
		private ListChangeType(string _0024enum_0024name, int _0024enum_0024ordinal)
	: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			GC.KeepAlive(this);
		}


		
		public static ListChangeType[] values()
		{
			return (ListChangeType[])_0024VALUES.Clone();
		}


		
		
		public static ListChangeType valueOf(string name)
		{
			return (ListChangeType)java.lang.Enum.valueOf(ClassLiteral<ListChangeType>.Value, name);
		}

		
		static ListChangeType()
		{
			___003C_003EADDITION = new ListChangeType("ADDITION", 0);
			___003C_003EREMOVAL = new ListChangeType("REMOVAL", 1);
			_0024VALUES = new ListChangeType[2] { ___003C_003EADDITION, ___003C_003EREMOVAL };
		}
	}

	
	public virtual void propertyChange(Node observedNode, ObservableProperty property, object oldValue, object newValue)
	{
	}
	
	public virtual void parentChange(Node observedNode, Node previousParent, Node newParent)
    {

    }

		
	public virtual void listChange(NodeList observedNode, ListChangeType type, int index, Node nodeAddedOrRemoved)
    {

    }

		
	public virtual void listReplacement(NodeList observedNode, int index, Node oldNode, Node newNode)
    {

    }
}
