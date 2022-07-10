using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.ast.observer;

public class AstObserver
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	
	public class ListChangeType : java.lang.Enum
	{
		[Serializable]
		
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


		[MethodParameters(new Modifiers[]
{
			Modifiers.Synthetic,
			Modifiers.Synthetic
})]
		
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

	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void propertyChange(Node observedNode, ObservableProperty property, object oldValue, object newValue)
	{
	}
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void parentChange(Node observedNode, Node previousParent, Node newParent)
    {

    }

		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void listChange(NodeList observedNode, ListChangeType type, int index, Node nodeAddedOrRemoved)
    {

    }

		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void listReplacement(NodeList observedNode, int index, Node oldNode, Node newNode)
    {

    }
}
