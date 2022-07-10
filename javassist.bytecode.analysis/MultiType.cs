using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace javassist.bytecode.analysis;

public class MultiType : Type
{
	[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;")]
	private Map interfaces;

	private Type resolved;

	private Type potentialClass;

	private MultiType mergeSource;

	private bool changed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		67, 104, 143, 109, 130, 118, 135, 137, 145, 127,
		1, 134, 194, 105, 103, 134, 162, 104, 108, 134,
		162
	})]
	public virtual bool isAssignableTo(Type type)
	{
		if (resolved != null)
		{
			bool result = type.isAssignableFrom(resolved);
			_ = null;
			return result;
		}
		if (Type.___003C_003EOBJECT.equals(type))
		{
			return true;
		}
		if (potentialClass != null && !type.isAssignableFrom(potentialClass))
		{
			potentialClass = null;
		}
		Map map = mergeMultiAndSingle(this, type);
		if (map.size() == 1 && potentialClass == null)
		{
			resolved = Type.get((CtClass)map.values().iterator().next());
			propogateResolved();
			return true;
		}
		if (map.size() >= 1)
		{
			interfaces = map;
			propogateState();
			return true;
		}
		if (potentialClass != null)
		{
			resolved = potentialClass;
			propogateResolved();
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;)V")]
	[LineNumberTable(new byte[] { 6, 106 })]
	public MultiType(Map interfaces)
		: this(interfaces, null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;Ljavassist/bytecode/analysis/Type;)V")]
	[LineNumberTable(new byte[] { 10, 233, 57, 231, 72, 103, 103 })]
	public MultiType(Map interfaces, Type potentialClass)
		: base(null)
	{
		changed = false;
		this.interfaces = interfaces;
		this.potentialClass = potentialClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 21, 104, 142 })]
	public override CtClass getCtClass()
	{
		if (resolved != null)
		{
			CtClass ctClass = resolved.getCtClass();
			_ = null;
			return ctClass;
		}
		CtClass ctClass2 = Type.___003C_003EOBJECT.getCtClass();
		_ = null;
		return ctClass2;
	}

	internal override bool popChanged()
	{
		int result = (changed ? 1 : 0);
		changed = false;
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 176, 104, 142 })]
	public override int hashCode()
	{
		if (resolved != null)
		{
			int result = resolved.hashCode();
			_ = null;
			return result;
		}
		int result2 = interfaces.keySet().hashCode();
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 184, 104, 130, 103, 104, 116, 104, 130 })]
	public override bool equals(object o)
	{
		if (!(o is MultiType))
		{
			return false;
		}
		MultiType multiType = (MultiType)o;
		if (resolved != null)
		{
			bool result = resolved.equals(multiType.resolved);
			_ = null;
			return result;
		}
		if (multiType.resolved != null)
		{
			return false;
		}
		bool result2 = interfaces.keySet().equals(multiType.interfaces.keySet());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 198, 104, 142, 102, 105, 127, 6, 116, 104,
		155, 110, 105
	})]
	public override string toString()
	{
		if (resolved != null)
		{
			string result = resolved.toString();
			_ = null;
			return result;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append('{');
		Iterator iterator = interfaces.keySet().iterator();
		while (iterator.hasNext())
		{
			string str = (string)iterator.next();
			stringBuilder.append(str).append(", ");
		}
		if (potentialClass != null)
		{
			stringBuilder.append('*').append(potentialClass.toString());
		}
		else
		{
			stringBuilder.setLength(stringBuilder.length() - 2);
		}
		stringBuilder.append('}');
		string result2 = stringBuilder.toString();
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/analysis/MultiType;Ljavassist/bytecode/analysis/Type;)Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;")]
	[LineNumberTable(new byte[] { 160, 87, 104, 142 })]
	private Map mergeMultiAndSingle(MultiType P_0, Type P_1)
	{
		Map allMultiInterfaces = getAllMultiInterfaces(P_0);
		Map allInterfaces = getAllInterfaces(P_1.getCtClass(), null);
		Map result = findCommonInterfaces(allMultiInterfaces, allInterfaces);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 114, 103, 99, 108, 137 })]
	private void propogateResolved()
	{
		for (MultiType multiType = mergeSource; multiType != null; multiType = multiType.mergeSource)
		{
			multiType.resolved = resolved;
		}
	}

	[LineNumberTable(new byte[] { 105, 103, 99, 108, 108, 137 })]
	private void propogateState()
	{
		for (MultiType multiType = mergeSource; multiType != null; multiType = multiType.mergeSource)
		{
			multiType.interfaces = interfaces;
			multiType.potentialClass = potentialClass;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/analysis/MultiType;)Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;")]
	[LineNumberTable(new byte[] { 160, 68, 134, 127, 6, 110, 105, 130 })]
	private Map getAllMultiInterfaces(MultiType P_0)
	{
		HashMap hashMap = new HashMap();
		Iterator iterator = P_0.interfaces.values().iterator();
		while (iterator.hasNext())
		{
			CtClass ctClass = (CtClass)iterator.next();
			((Map)hashMap).put((object)ctClass.getName(), (object)ctClass);
			getAllInterfaces(ctClass, hashMap);
		}
		return hashMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/analysis/MultiType;Ljavassist/bytecode/analysis/MultiType;)Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;")]
	[LineNumberTable(new byte[] { 160, 80, 104, 136 })]
	private Map mergeMultiInterfaces(MultiType P_0, MultiType P_1)
	{
		Map allMultiInterfaces = getAllMultiInterfaces(P_0);
		Map allMultiInterfaces2 = getAllMultiInterfaces(P_1);
		Map result = findCommonInterfaces(allMultiInterfaces, allMultiInterfaces2);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 160, 94, 99, 100, 130, 170 })]
	private bool inMergeSource(MultiType P_0)
	{
		while (P_0 != null)
		{
			if (P_0 == this)
			{
				return true;
			}
			P_0 = P_0.mergeSource;
		}
		return false;
	}

	public override Type getComponent()
	{
		return null;
	}

	public override int getSize()
	{
		return 1;
	}

	public override bool isArray()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(113)]
	public override bool isAssignableFrom(Type type)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException("Not implemented");
	}

	public override bool isReference()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 106, 100, 130, 104, 130, 104, 134, 99, 130,
		104, 143, 104, 109, 118, 119, 231, 70, 104, 135,
		104, 144, 105, 105, 135, 98, 201, 159, 1, 115,
		105, 104, 127, 2, 111, 39, 194, 103, 134, 162,
		105, 127, 3, 104, 142, 139, 134
	})]
	public override Type merge(Type type)
	{
		if (this == type)
		{
			return this;
		}
		if (type == Type.___003C_003EUNINIT)
		{
			return this;
		}
		if (type == Type.___003C_003EBOGUS)
		{
			return Type.___003C_003EBOGUS;
		}
		if (type == null)
		{
			return this;
		}
		if (resolved != null)
		{
			Type result = resolved.merge(type);
			_ = null;
			return result;
		}
		if (potentialClass != null)
		{
			Type type2 = potentialClass.merge(type);
			if (!type2.equals(potentialClass) || type2.popChanged())
			{
				potentialClass = ((!Type.___003C_003EOBJECT.equals(type2)) ? type2 : null);
				changed = true;
			}
		}
		Map map;
		if (type is MultiType)
		{
			MultiType multiType = (MultiType)type;
			if (multiType.resolved != null)
			{
				map = mergeMultiAndSingle(this, multiType.resolved);
			}
			else
			{
				map = mergeMultiInterfaces(multiType, this);
				if (!inMergeSource(multiType))
				{
					mergeSource = multiType;
				}
			}
		}
		else
		{
			map = mergeMultiAndSingle(this, type);
		}
		if (map.size() > 1 || (map.size() == 1 && potentialClass != null))
		{
			if (map.size() != interfaces.size())
			{
				changed = true;
			}
			else if (!changed)
			{
				Iterator iterator = map.keySet().iterator();
				while (iterator.hasNext())
				{
					string key = (string)iterator.next();
					if (!interfaces.containsKey(key))
					{
						changed = true;
					}
				}
			}
			interfaces = map;
			propogateState();
			return this;
		}
		if (map.size() == 1)
		{
			resolved = Type.get((CtClass)map.values().iterator().next());
		}
		else if (potentialClass != null)
		{
			resolved = potentialClass;
		}
		else
		{
			resolved = Type.___003C_003EOBJECT;
		}
		propogateResolved();
		return resolved;
	}

	[HideFromJava]
	static MultiType()
	{
		Type.___003Cclinit_003E();
	}
}
