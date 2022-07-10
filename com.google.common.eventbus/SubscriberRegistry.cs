using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.cache;
using com.google.common.collect;
using com.google.common.primitives;
using com.google.common.reflect;
using com.google.common.util.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.eventbus;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/eventbus/ElementTypesAreNonnullByDefault;"
})]
internal sealed class SubscriberRegistry : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/cache/CacheLoader<Ljava/lang/Class<*>;Lcom/google/common/collect/ImmutableList<Ljava/lang/reflect/Method;>;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _1 : CacheLoader
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(Ljava/lang/Class<*>;)Lcom/google/common/collect/ImmutableList<Ljava/lang/reflect/Method;>;")]
		[LineNumberTable(157)]
		public virtual ImmutableList load(Class P_0)
		{
			ImmutableList result = access_0024000(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(154)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(154)]
		public override object load(object P_0)
		{
			ImmutableList result = load((Class)P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/cache/CacheLoader<Ljava/lang/Class<*>;Lcom/google/common/collect/ImmutableSet<Ljava/lang/Class<*>;>;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _2 : CacheLoader
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(223)]
		internal _2()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Class<*>;)Lcom/google/common/collect/ImmutableSet<Ljava/lang/Class<*>;>;")]
		[LineNumberTable(new byte[] { 160, 114, 97, 47 })]
		public virtual ImmutableSet load(Class P_0)
		{
			ImmutableSet result = ImmutableSet.copyOf(TypeToken.of(P_0).getTypes().rawTypes());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(223)]
		public override object load(object P_0)
		{
			ImmutableSet result = load((Class)P_0);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class MethodIdentifier : Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string name;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/List<Ljava/lang/Class<*>;>;")]
		private List parameterTypes;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 137, 104, 108, 113 })]
		internal MethodIdentifier(Method P_0)
		{
			name = P_0.getName();
			parameterTypes = Arrays.asList(P_0.getParameterTypes());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(258)]
		public override int hashCode()
		{
			int result = com.google.common.@base.Objects.hashCode(name, parameterTypes);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 149, 104, 103, 159, 12 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is MethodIdentifier)
			{
				MethodIdentifier methodIdentifier = (MethodIdentifier)P_0;
				return (String.instancehelper_equals(name, methodIdentifier.name) && parameterTypes.equals(methodIdentifier.parameterTypes)) ? true : false;
			}
			return false;
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/concurrent/ConcurrentMap<Ljava/lang/Class<*>;Ljava/util/concurrent/CopyOnWriteArraySet<Lcom/google/common/eventbus/Subscriber;>;>;")]
	private ConcurrentMap subscribers;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private EventBus bus;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/cache/LoadingCache<Ljava/lang/Class<*>;Lcom/google/common/collect/ImmutableList<Ljava/lang/reflect/Method;>;>;")]
	private static LoadingCache subscriberMethodsCache;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/cache/LoadingCache<Ljava/lang/Class<*>;Lcom/google/common/collect/ImmutableSet<Ljava/lang/Class<*>;>;>;")]
	private static LoadingCache flattenHierarchyCache;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 21, 232, 58, 97, 234, 70, 113 })]
	internal SubscriberRegistry(EventBus P_0)
	{
		subscribers = Maps.newConcurrentMap();
		bus = (EventBus)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		27, 136, 127, 9, 108, 141, 147, 100, 103, 105,
		184, 106, 101
	})]
	internal virtual void register(object P_0)
	{
		Multimap multimap = findAllSubscribers(P_0);
		Iterator iterator = multimap.asMap().entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			Class key = (Class)entry.getKey();
			Collection c = (Collection)entry.getValue();
			CopyOnWriteArraySet copyOnWriteArraySet = (CopyOnWriteArraySet)subscribers.get(key);
			if (copyOnWriteArraySet == null)
			{
				CopyOnWriteArraySet copyOnWriteArraySet2 = new CopyOnWriteArraySet();
				copyOnWriteArraySet = (CopyOnWriteArraySet)MoreObjects.firstNonNull((CopyOnWriteArraySet)subscribers.putIfAbsent(key, copyOnWriteArraySet2), copyOnWriteArraySet2);
			}
			copyOnWriteArraySet.addAll(c);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		47,
		136,
		127,
		9,
		108,
		141,
		115,
		239,
		69,
		byte.MaxValue,
		48,
		70,
		101
	})]
	internal virtual void unregister(object P_0)
	{
		Multimap multimap = findAllSubscribers(P_0);
		Iterator iterator = multimap.asMap().entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			Class key = (Class)entry.getKey();
			Collection c = (Collection)entry.getValue();
			CopyOnWriteArraySet copyOnWriteArraySet = (CopyOnWriteArraySet)subscribers.get(key);
			if (copyOnWriteArraySet == null || !copyOnWriteArraySet.removeAll(c))
			{
				string text = String.valueOf(P_0);
				int num = 65 + String.instancehelper_length(String.valueOf(text));
				num = num;
				string s = new StringBuilder(num).append("missing event subscriber for an annotated method. Is ").append(text).append(" registered?")
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException(s);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Ljava/util/Iterator<Lcom/google/common/eventbus/Subscriber;>;")]
	[LineNumberTable(new byte[] { 78, 140, 97, 139, 123, 115, 132, 142, 130 })]
	internal virtual Iterator getSubscribers(object P_0)
	{
		ImmutableSet immutableSet = flattenHierarchy(Object.instancehelper_getClass(P_0));
		ArrayList arrayList = Lists.newArrayListWithCapacity(immutableSet.size());
		UnmodifiableIterator unmodifiableIterator = immutableSet.iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Class key = (Class)((Iterator)unmodifiableIterator).next();
			CopyOnWriteArraySet copyOnWriteArraySet = (CopyOnWriteArraySet)subscribers.get(key);
			if (copyOnWriteArraySet != null)
			{
				((List)arrayList).add((object)copyOnWriteArraySet.iterator());
			}
		}
		Iterator result = Iterators.concat(((List)arrayList).iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(57)]
	internal static ImmutableList access_0024000(Class P_0)
	{
		ImmutableList annotatedMethodsNotCached = getAnnotatedMethodsNotCached(P_0);
		_ = null;
		return annotatedMethodsNotCached;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Lcom/google/common/collect/ImmutableList<Ljava/lang/reflect/Method;>;")]
	[LineNumberTable(new byte[]
	{
		160, 71, 113, 102, 126, 127, 6, 157, 105, 245,
		71, 100, 246, 69, 105, 234, 57, 229, 73, 105,
		106, 235, 42, 235, 90, 101
	})]
	private static ImmutableList getAnnotatedMethodsNotCached(Class P_0)
	{
		Set set = TypeToken.of(P_0).getTypes().rawTypes();
		HashMap hashMap = Maps.newHashMap();
		Iterator iterator = set.iterator();
		while (iterator.hasNext())
		{
			Class @class = (Class)iterator.next();
			Method[] declaredMethods = @class.getDeclaredMethods(SubscriberRegistry.___003CGetCallerID_003E());
			int num = declaredMethods.Length;
			for (int i = 0; i < num; i++)
			{
				Method method = declaredMethods[i];
				if (method.isAnnotationPresent(ClassLiteral<Subscribe>.Value) && !method.isSynthetic())
				{
					Class[] parameterTypes = method.getParameterTypes();
					Preconditions.checkArgument((nint)parameterTypes.LongLength == 1, "Method %s has @Subscribe annotation but has %s parameters. Subscriber methods must have exactly 1 parameter.", method, parameterTypes.Length);
					Preconditions.checkArgument((!parameterTypes[0].isPrimitive()) ? true : false, "@Subscribe method %s's parameter is %s. Subscriber methods cannot accept primitives. Consider changing the parameter to %s.", method, parameterTypes[0].getName(), Primitives.wrap(parameterTypes[0]).getSimpleName());
					MethodIdentifier key = new MethodIdentifier(method);
					if (!((Map)hashMap).containsKey((object)key))
					{
						((Map)hashMap).put((object)key, (object)method);
					}
				}
			}
		}
		ImmutableList result = ImmutableList.copyOf(((Map)hashMap).values());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Lcom/google/common/collect/Multimap<Ljava/lang/Class<*>;Lcom/google/common/eventbus/Subscriber;>;")]
	[LineNumberTable(new byte[] { 115, 102, 103, 127, 1, 104, 102, 118, 98 })]
	private Multimap findAllSubscribers(object P_0)
	{
		HashMultimap hashMultimap = HashMultimap.create();
		Class @class = Object.instancehelper_getClass(P_0);
		UnmodifiableIterator unmodifiableIterator = getAnnotatedMethods(@class).iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Method method = (Method)((Iterator)unmodifiableIterator).next();
			Class[] parameterTypes = method.getParameterTypes();
			Class obj = parameterTypes[0];
			((Multimap)hashMultimap).put((object)obj, (object)Subscriber.create(bus, P_0, method));
		}
		return hashMultimap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Lcom/google/common/collect/ImmutableSet<Ljava/lang/Class<*>;>;")]
	[LineNumberTable(new byte[] { 160, 126, 127, 7, 97 })]
	internal static ImmutableSet flattenHierarchy(Class P_0)
	{
		//Discarded unreachable code: IL_0012
		UncheckedExecutionException ex;
		try
		{
			return (ImmutableSet)flattenHierarchyCache.getUnchecked(P_0);
		}
		catch (UncheckedExecutionException x)
		{
			ex = ByteCodeHelper.MapException<UncheckedExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		UncheckedExecutionException @this = ex;
		throw Throwable.___003Cunmap_003E(Throwables.propagate(Throwable.instancehelper_getCause(@this)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Lcom/google/common/collect/ImmutableList<Ljava/lang/reflect/Method;>;")]
	[LineNumberTable(new byte[] { 127, 127, 7, 97, 107 })]
	private static ImmutableList getAnnotatedMethods(Class P_0)
	{
		//Discarded unreachable code: IL_0012
		UncheckedExecutionException ex;
		try
		{
			return (ImmutableList)subscriberMethodsCache.getUnchecked(P_0);
		}
		catch (UncheckedExecutionException x)
		{
			ex = ByteCodeHelper.MapException<UncheckedExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		UncheckedExecutionException ex2 = ex;
		Throwables.throwIfUnchecked(Throwable.instancehelper_getCause(ex2));
		throw Throwable.___003Cunmap_003E(ex2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Ljava/util/Set<Lcom/google/common/eventbus/Subscriber;>;")]
	[LineNumberTable(120)]
	internal virtual Set getSubscribersForTesting(Class P_0)
	{
		return (Set)MoreObjects.firstNonNull((AbstractCollection)subscribers.get(P_0), ImmutableSet.of());
	}

	[LineNumberTable(new byte[] { 101, 101, 106, 234, 160, 67, 101, 106, 234, 61 })]
	static SubscriberRegistry()
	{
		subscriberMethodsCache = CacheBuilder.newBuilder().weakKeys().build(new _1());
		flattenHierarchyCache = CacheBuilder.newBuilder().weakKeys().build(new _2());
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
