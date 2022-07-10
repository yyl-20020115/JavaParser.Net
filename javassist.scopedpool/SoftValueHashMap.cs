using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.@ref;
using java.util;
using java.util.concurrent;
using java.util.function;

namespace javassist.scopedpool;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map<TK;TV;>;")]
public class SoftValueHashMap : Object, Map
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/ref/SoftReference<TV;>;")]
	internal class SoftValueRef : SoftReference
	{
		[Signature("TK;")]
		public object key;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;Ljava/lang/ref/ReferenceQueue<TV;>;)Ljavassist/scopedpool/SoftValueHashMap$SoftValueRef<TK;TV;>;")]
		[LineNumberTable(new byte[] { 159, 190, 99, 130 })]
		private static SoftValueRef create(object P_0, object P_1, ReferenceQueue P_2)
		{
			if (P_1 == null)
			{
				return null;
			}
			SoftValueRef result = new SoftValueRef(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;Ljava/lang/ref/ReferenceQueue<TV;>;)V")]
		[LineNumberTable(new byte[] { 159, 184, 106, 103 })]
		private SoftValueRef(object P_0, object P_1, ReferenceQueue P_2)
			: base(P_1, P_2)
		{
			key = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(38)]
		internal static SoftValueRef access_0024000(object P_0, object P_1, ReferenceQueue P_2)
		{
			SoftValueRef result = create(P_0, P_1, P_2);
			_ = null;
			return result;
		}
	}

	[Signature("Ljava/util/Map<TK;Ljavassist/scopedpool/SoftValueHashMap$SoftValueRef<TK;TV;>;>;")]
	private Map hash;

	[Signature("Ljava/lang/ref/ReferenceQueue<TV;>;")]
	private ReferenceQueue queue;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 80, 232, 7, 235, 122, 107 })]
	public SoftValueHashMap()
	{
		queue = new ReferenceQueue();
		hash = new ConcurrentHashMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 31, 109, 111, 136, 103, 148, 114, 98 })]
	private void processQueue()
	{
		if (hash.isEmpty())
		{
			return;
		}
		Reference reference;
		while ((reference = queue.poll()) != null)
		{
			if (reference is SoftValueRef)
			{
				SoftValueRef softValueRef = (SoftValueRef)reference;
				if (reference == hash.get(softValueRef.key))
				{
					hash.remove(softValueRef.key);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 58, 232, 29, 235, 100, 110 })]
	public SoftValueHashMap(int initialCapacity, float loadFactor)
	{
		queue = new ReferenceQueue();
		hash = new ConcurrentHashMap(initialCapacity, loadFactor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
	[LineNumberTable(new byte[] { 160, 159, 102, 123, 113 })]
	public virtual void putAll(Map arg0)
	{
		processQueue();
		Iterator iterator = arg0.keySet().iterator();
		while (iterator.hasNext())
		{
			object key = iterator.next();
			put(key, arg0.get(key));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljavassist/scopedpool/SoftValueHashMap$SoftValueRef<TK;TV;>;)TV;")]
	[LineNumberTable(new byte[] { 160, 175, 100, 98 })]
	private object valueOrNull(SoftValueRef P_0)
	{
		if (null == P_0)
		{
			return null;
		}
		object result = P_0.get();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(new byte[] { 160, 103, 102 })]
	public virtual object put(object key, object value)
	{
		processQueue();
		object result = valueOrNull((SoftValueRef)hash.put(key, SoftValueRef.access_0024000(key, value, queue)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 11, 102, 102, 127, 6, 98, 58, 136 })]
	public virtual Set entrySet()
	{
		processQueue();
		HashSet hashSet = new HashSet();
		Iterator iterator = hash.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			((Set)hashSet).add((object)new AbstractMap.SimpleImmutableEntry(entry.getKey(), ((SoftValueRef)entry.getValue()).get()));
		}
		return hashSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 72, 232, 15, 235, 114, 108 })]
	public SoftValueHashMap(int initialCapacity)
	{
		queue = new ReferenceQueue();
		hash = new ConcurrentHashMap(initialCapacity);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 94, 124, 105 })]
	public SoftValueHashMap(Map t)
		: this(Math.max(2 * t.size(), 11), 0.75f)
	{
		putAll(t);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 108, 102 })]
	public virtual int size()
	{
		processQueue();
		int result = hash.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 117, 102 })]
	public virtual bool isEmpty()
	{
		processQueue();
		bool result = hash.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 66, 102 })]
	public virtual bool containsKey(object key)
	{
		processQueue();
		bool result = hash.containsKey(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 160, 82, 102 })]
	public virtual object get(object key)
	{
		processQueue();
		object result = valueOrNull((SoftValueRef)hash.get(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 160, 119, 102 })]
	public virtual object remove(object key)
	{
		processQueue();
		object result = valueOrNull((SoftValueRef)hash.remove(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 128, 102, 109 })]
	public virtual void clear()
	{
		processQueue();
		hash.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 139, 102, 100, 130, 127, 6, 114, 34, 130 })]
	public virtual bool containsValue(object arg0)
	{
		processQueue();
		if (null == arg0)
		{
			return false;
		}
		Iterator iterator = hash.values().iterator();
		while (iterator.hasNext())
		{
			SoftValueRef softValueRef = (SoftValueRef)iterator.next();
			if (null != softValueRef && Object.instancehelper_equals(arg0, softValueRef.get()))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(new byte[] { 160, 152, 102 })]
	public virtual Set keySet()
	{
		processQueue();
		Set result = hash.keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 160, 167, 102, 102, 127, 6, 111 })]
	public virtual Collection values()
	{
		processQueue();
		ArrayList arrayList = new ArrayList();
		Iterator iterator = hash.values().iterator();
		while (iterator.hasNext())
		{
			SoftValueRef softValueRef = (SoftValueRef)iterator.next();
			((List)arrayList).add(softValueRef.get());
		}
		return arrayList;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object putIfAbsent(object P_0, object P_1)
	{
		return Map._003Cdefault_003EputIfAbsent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object getOrDefault(object P_0, object P_1)
	{
		return Map._003Cdefault_003EgetOrDefault(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEach(BiConsumer P_0)
	{
		Map._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void replaceAll(BiFunction P_0)
	{
		Map._003Cdefault_003EreplaceAll(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool remove(object P_0, object P_1)
	{
		return Map._003Cdefault_003Eremove(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool replace(object P_0, object P_1, object P_2)
	{
		return Map._003Cdefault_003Ereplace(this, P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object replace(object P_0, object P_1)
	{
		return Map._003Cdefault_003Ereplace(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object computeIfAbsent(object P_0, Function P_1)
	{
		return Map._003Cdefault_003EcomputeIfAbsent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object computeIfPresent(object P_0, BiFunction P_1)
	{
		return Map._003Cdefault_003EcomputeIfPresent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object compute(object P_0, BiFunction P_1)
	{
		return Map._003Cdefault_003Ecompute(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object merge(object P_0, object P_1, BiFunction P_2)
	{
		return Map._003Cdefault_003Emerge(this, P_0, P_1, P_2);
	}

	bool Map.Map_003A_003Aequals(object P_0)
	{
		return Object.instancehelper_equals(this, P_0);
	}

	int Map.Map_003A_003AhashCode()
	{
		return Object.instancehelper_hashCode(this);
	}
}
