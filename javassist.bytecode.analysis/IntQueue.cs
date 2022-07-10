using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace javassist.bytecode.analysis;

internal class IntQueue : Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[IKVM.Attributes.EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Entry : Object
	{
		private Entry next;

		private int value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(21)]
		internal Entry(int P_0, _1 P_1)
			: this(P_0)
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(21)]
		internal static Entry access_0024102(Entry P_0, Entry P_1)
		{
			P_0.next = P_1;
			return P_1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(21)]
		internal static int access_0024200(Entry P_0)
		{
			return P_0.value;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(21)]
		internal static Entry access_0024100(Entry P_0)
		{
			return P_0.next;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 166, 104, 103 })]
		private Entry(int P_0)
		{
			value = P_0;
		}
	}

	private Entry head;

	private Entry tail;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(20)]
	internal IntQueue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 175, 104, 104, 109, 135, 104, 103 })]
	internal virtual void add(int P_0)
	{
		Entry entry = new Entry(P_0, null);
		if (tail != null)
		{
			Entry.access_0024102(tail, entry);
		}
		tail = entry;
		if (head == null)
		{
			head = entry;
		}
	}

	internal virtual bool isEmpty()
	{
		return head == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 189, 104, 139, 108, 113, 104, 135 })]
	internal virtual int take()
	{
		if (head == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		int result = Entry.access_0024200(head);
		head = Entry.access_0024100(head);
		if (head == null)
		{
			tail = null;
		}
		return result;
	}
}
