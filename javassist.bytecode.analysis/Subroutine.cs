using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace javassist.bytecode.analysis;

public class Subroutine : Object
{
	[IKVM.Attributes.Signature("Ljava/util/List<Ljava/lang/Integer;>;")]
	private List m_callers;

	[IKVM.Attributes.Signature("Ljava/util/Set<Ljava/lang/Integer;>;")]
	private Set m_access;

	private int m_start;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	public virtual bool isAccessed(int index)
	{
		bool result = this.m_access.contains(Integer.valueOf(index));
		_ = null;
		return result;
	}

	[IKVM.Attributes.Signature("()Ljava/util/Collection<Ljava/lang/Integer;>;")]
	public virtual Collection callers()
	{
		return this.m_callers;
	}

	[IKVM.Attributes.Signature("()Ljava/util/Collection<Ljava/lang/Integer;>;")]
	public virtual Collection accessed()
	{
		return this.m_access;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 191, 114 })]
	public virtual void access(int index)
	{
		this.m_access.add(Integer.valueOf(index));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 177, 232, 60, 107, 203, 103, 114 })]
	public Subroutine(int start, int caller)
	{
		this.m_callers = new ArrayList();
		this.m_access = new HashSet();
		this.m_start = start;
		this.m_callers.add(Integer.valueOf(caller));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 114 })]
	public virtual void addCaller(int caller)
	{
		this.m_callers.add(Integer.valueOf(caller));
	}

	public virtual int start()
	{
		return this.m_start;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(66)]
	public override string toString()
	{
		string result = new StringBuilder().append("start = ").append(this.m_start).append(" callers = ")
			.append(Object.instancehelper_toString(this.m_callers))
			.toString();
		_ = null;
		return result;
	}
}
