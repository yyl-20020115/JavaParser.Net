using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.concurrent.atomic;
using javax.annotation;

namespace com.google.common.reflect;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
public sealed class TypeResolver : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "populateTypeMappings", "(Ljava.util.Map;Ljava.lang.reflect.Type;Ljava.lang.reflect.Type;)V")]
	internal class _1 : TypeVisitor
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Map val_0024mappings;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal java.lang.reflect.Type val_0024to;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(128)]
		internal _1(Map P_0, java.lang.reflect.Type P_1)
		{
			val_0024mappings = P_0;
			val_0024to = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/TypeVariable<*>;)V")]
		[LineNumberTable(new byte[] { 81, 120 })]
		internal override void visitTypeVariable(TypeVariable P_0)
		{
			val_0024mappings.put(new TypeVariableKey(P_0), val_0024to);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			86,
			109,
			129,
			108,
			103,
			103,
			103,
			104,
			byte.MaxValue,
			3,
			70,
			105,
			51,
			168,
			105,
			52,
			168
		})]
		internal override void visitWildcardType(WildcardType P_0)
		{
			if (val_0024to is WildcardType)
			{
				WildcardType wildcardType = (WildcardType)val_0024to;
				java.lang.reflect.Type[] upperBounds = P_0.getUpperBounds();
				java.lang.reflect.Type[] upperBounds2 = wildcardType.getUpperBounds();
				java.lang.reflect.Type[] lowerBounds = P_0.getLowerBounds();
				java.lang.reflect.Type[] lowerBounds2 = wildcardType.getLowerBounds();
				Preconditions.checkArgument(((nint)upperBounds.LongLength == (nint)upperBounds2.LongLength && (nint)lowerBounds.LongLength == (nint)lowerBounds2.LongLength) ? true : false, "Incompatible type: %s vs. %s", P_0, val_0024to);
				for (int i = 0; i < (nint)upperBounds.LongLength; i++)
				{
					access_0024000(val_0024mappings, upperBounds[i], upperBounds2[i]);
				}
				for (int i = 0; i < (nint)lowerBounds.LongLength; i++)
				{
					access_0024000(val_0024mappings, lowerBounds[i], lowerBounds2[i]);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			110, 109, 129, 118, 105, 103, 103, 43, 165, 97,
			60, 229, 69, 103, 103, 242, 69, 103, 49, 166
		})]
		internal override void visitParameterizedType(ParameterizedType P_0)
		{
			if (!(val_0024to is WildcardType))
			{
				ParameterizedType parameterizedType = (ParameterizedType)access_0024100(ClassLiteral<ParameterizedType>.Value, val_0024to);
				if (P_0.getOwnerType() != null && parameterizedType.getOwnerType() != null)
				{
					access_0024000(val_0024mappings, P_0.getOwnerType(), parameterizedType.getOwnerType());
				}
				Preconditions.checkArgument(java.lang.Object.instancehelper_equals(P_0.getRawType(), parameterizedType.getRawType()), "Inconsistent raw type: %s vs. %s", P_0, val_0024to);
				java.lang.reflect.Type[] actualTypeArguments = P_0.getActualTypeArguments();
				java.lang.reflect.Type[] actualTypeArguments2 = parameterizedType.getActualTypeArguments();
				Preconditions.checkArgument((nint)actualTypeArguments.LongLength == (nint)actualTypeArguments2.LongLength, "%s not compatible with %s", P_0, parameterizedType);
				for (int i = 0; i < (nint)actualTypeArguments.LongLength; i++)
				{
					access_0024000(val_0024mappings, actualTypeArguments[i], actualTypeArguments2[i]);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 74, 109, 129, 108, 119, 116 })]
		internal override void visitGenericArrayType(GenericArrayType P_0)
		{
			if (!(val_0024to is WildcardType))
			{
				java.lang.reflect.Type componentType = Types.getComponentType(val_0024to);
				Preconditions.checkArgument(componentType != null, "%s is not an array type.", val_0024to);
				access_0024000(val_0024mappings, P_0.getGenericComponentType(), componentType);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Class<*>;)V")]
		[LineNumberTable(new byte[] { 160, 84, 109, 225, 69 })]
		internal override void visitClass(Class P_0)
		{
			if (val_0024to is WildcardType)
			{
				return;
			}
			string text = java.lang.String.valueOf(P_0);
			string text2 = java.lang.String.valueOf(val_0024to);
			int num = 25 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string s = new StringBuilder(num).append("No type mapping from ").append(text).append(" to ")
				.append(text2)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class TypeMappingIntrospector : TypeVisitor
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Map<Lcom/google/common/reflect/TypeResolver$TypeVariableKey;Ljava/lang/reflect/Type;>;")]
		private Map mappings;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/Type;)Lcom/google/common/collect/ImmutableMap<Lcom/google/common/reflect/TypeResolver$TypeVariableKey;Ljava/lang/reflect/Type;>;")]
		[LineNumberTable(new byte[] { 161, 10, 103, 102, 112 })]
		internal static ImmutableMap getTypeMappings(java.lang.reflect.Type P_0)
		{
			Preconditions.checkNotNull(P_0);
			TypeMappingIntrospector typeMappingIntrospector = new TypeMappingIntrospector();
			typeMappingIntrospector.visit(P_0);
			ImmutableMap result = ImmutableMap.copyOf(typeMappingIntrospector.mappings);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 1, 136 })]
		private TypeMappingIntrospector()
		{
			mappings = Maps.newHashMap();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 46, 238, 70, 161, 101, 233, 69, 126, 225,
			57, 249, 74, 110
		})]
		private void map(TypeVariableKey P_0, java.lang.reflect.Type P_1)
		{
			if (mappings.containsKey(P_0))
			{
				return;
			}
			for (java.lang.reflect.Type type = P_1; type != null; type = (java.lang.reflect.Type)mappings.get(TypeVariableKey.forLookup(type)))
			{
				if (P_0.equalsType(type))
				{
					for (java.lang.reflect.Type type2 = P_1; type2 != null; type2 = (java.lang.reflect.Type)mappings.remove(TypeVariableKey.forLookup(type2)))
					{
					}
					return;
				}
			}
			mappings.put(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Class<*>;)V")]
		[LineNumberTable(new byte[] { 161, 18, 117, 110 })]
		internal override void visitClass(Class P_0)
		{
			visit(P_0.getGenericSuperclass());
			visit(P_0.getGenericInterfaces());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 24, 108, 103, 103, 107, 103, 49, 166, 112,
			119
		})]
		internal override void visitParameterizedType(ParameterizedType P_0)
		{
			Class @class = (Class)P_0.getRawType();
			TypeVariable[] typeParameters = @class.getTypeParameters();
			java.lang.reflect.Type[] actualTypeArguments = P_0.getActualTypeArguments();
			Preconditions.checkState((nint)typeParameters.LongLength == (nint)actualTypeArguments.LongLength);
			for (int i = 0; i < (nint)typeParameters.LongLength; i++)
			{
				map(new TypeVariableKey(typeParameters[i]), actualTypeArguments[i]);
			}
			visit(@class);
			visit(P_0.getOwnerType());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/TypeVariable<*>;)V")]
		[LineNumberTable(new byte[] { 161, 37, 110 })]
		internal override void visitTypeVariable(TypeVariable P_0)
		{
			visit(P_0.getBounds());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 42, 110 })]
		internal override void visitWildcardType(WildcardType P_0)
		{
			visit(P_0.getUpperBounds());
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class TypeTable : java.lang.Object
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, "resolve", "(Ljava.lang.reflect.TypeVariable;)Ljava.lang.reflect.Type;")]
		internal class _1 : TypeTable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TypeVariable val_0024var;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TypeTable val_0024unguarded;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(303)]
			internal _1(TypeTable P_0, TypeVariable P_1, TypeTable P_2)
			{
				val_0024var = P_1;
				val_0024unguarded = P_2;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/lang/reflect/TypeVariable<*>;Lcom/google/common/reflect/TypeResolver$TypeTable;)Ljava/lang/reflect/Type;")]
			[LineNumberTable(new byte[] { 160, 192, 120, 130 })]
			public override java.lang.reflect.Type resolveInternal(TypeVariable P_0, TypeTable P_1)
			{
				if (java.lang.Object.instancehelper_equals(P_0.getGenericDeclaration(), val_0024var.getGenericDeclaration()))
				{
					return P_0;
				}
				java.lang.reflect.Type result = val_0024unguarded.resolveInternal(P_0, P_1);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMap<Lcom/google/common/reflect/TypeResolver$TypeVariableKey;Ljava/lang/reflect/Type;>;")]
		private ImmutableMap map;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 165, 104, 107 })]
		internal TypeTable()
		{
			map = ImmutableMap.of();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<Lcom/google/common/reflect/TypeResolver$TypeVariableKey;+Ljava/lang/reflect/Type;>;)Lcom/google/common/reflect/TypeResolver$TypeTable;")]
		[LineNumberTable(new byte[]
		{
			160, 175, 102, 109, 127, 1, 108, 109, 121, 106,
			98
		})]
		internal TypeTable where(Map P_0)
		{
			ImmutableMap.Builder builder = ImmutableMap.builder();
			builder.putAll(map);
			Iterator iterator = P_0.entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				TypeVariableKey typeVariableKey = (TypeVariableKey)entry.getKey();
				java.lang.reflect.Type type = (java.lang.reflect.Type)entry.getValue();
				Preconditions.checkArgument((!typeVariableKey.equalsType(type)) ? true : false, "Type variable %s bound to itself", typeVariableKey);
				builder.put(typeVariableKey, type);
			}
			TypeTable result = new TypeTable(builder.buildOrThrow());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/TypeVariable<*>;)Ljava/lang/reflect/Type;")]
		[LineNumberTable(new byte[] { 160, 187, 98, 233, 74 })]
		internal java.lang.reflect.Type resolve(TypeVariable P_0)
		{
			_1  = new _1(this, P_0, this);
			java.lang.reflect.Type result = resolveInternal(P_0, );
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap<Lcom/google/common/reflect/TypeResolver$TypeVariableKey;Ljava/lang/reflect/Type;>;)V")]
		[LineNumberTable(new byte[] { 160, 169, 104, 103 })]
		private TypeTable(ImmutableMap P_0)
		{
			map = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/TypeVariable<*>;Lcom/google/common/reflect/TypeResolver$TypeTable;)Ljava/lang/reflect/Type;")]
		[LineNumberTable(new byte[]
		{
			160, 210, 119, 99, 103, 100, 130, 238, 93, 105,
			103, 130, 97, 44, 200
		})]
		internal virtual java.lang.reflect.Type resolveInternal(TypeVariable P_0, TypeTable P_1)
		{
			java.lang.reflect.Type type = (java.lang.reflect.Type)map.get(new TypeVariableKey(P_0));
			if (type == null)
			{
				java.lang.reflect.Type[] bounds = P_0.getBounds();
				if (bounds.Length == 0)
				{
					return P_0;
				}
				java.lang.reflect.Type[] array = access_0024300(new TypeResolver(P_1, null), bounds);
				if (Types.NativeTypeVariableEquals.NATIVE_TYPE_VARIABLE_ONLY && Arrays.equals(bounds, array))
				{
					return P_0;
				}
				TypeVariable result = Types.newArtificialTypeVariable(P_0.getGenericDeclaration(), P_0.getName(), array);
				_ = null;
				return result;
			}
			java.lang.reflect.Type result2 = new TypeResolver(P_1, null).resolveType(type);
			_ = null;
			return result2;
		}
	}

	internal sealed class TypeVariableKey : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/reflect/TypeVariable<*>;")]
		private TypeVariable var;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/TypeVariable<*>;)V")]
		[LineNumberTable(new byte[] { 161, 184, 104, 113 })]
		internal TypeVariableKey(TypeVariable P_0)
		{
			var = (TypeVariable)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 223, 104, 143 })]
		internal virtual bool equalsType(java.lang.reflect.Type P_0)
		{
			if (P_0 is TypeVariable)
			{
				bool result = equalsTypeVariable((TypeVariable)P_0);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 211, 104, 142 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal static TypeVariableKey forLookup(java.lang.reflect.Type P_0)
		{
			if (P_0 is TypeVariable)
			{
				TypeVariableKey result = new TypeVariableKey((TypeVariable)P_0);
				_ = null;
				return result;
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/TypeVariable<*>;)Z")]
		[LineNumberTable(new byte[] { 161, 231, 126, 54 })]
		private bool equalsTypeVariable(TypeVariable P_0)
		{
			return (java.lang.Object.instancehelper_equals(var.getGenericDeclaration(), P_0.getGenericDeclaration()) && java.lang.String.instancehelper_equals(var.getName(), P_0.getName())) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(560)]
		public override int hashCode()
		{
			int result = com.google.common.@base.Objects.hashCode(var.getGenericDeclaration(), var.getName());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 195, 104, 103, 143 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is TypeVariableKey)
			{
				TypeVariableKey typeVariableKey = (TypeVariableKey)P_0;
				bool result = equalsTypeVariable(typeVariableKey.var);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(575)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(var);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class WildcardCapturer : java.lang.Object
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, "forTypeVariable", "(Ljava.lang.reflect.TypeVariable;)Lcom.google.common.reflect.TypeResolver$WildcardCapturer;")]
		internal class _1 : WildcardCapturer
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TypeVariable val_0024typeParam;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(506)]
			internal _1(WildcardCapturer P_0, AtomicInteger P_1, TypeVariable P_2)
			{
				val_0024typeParam = P_2;
				base._002Ector(P_1, null);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("([Ljava/lang/reflect/Type;)Ljava/lang/reflect/TypeVariable<*>;")]
			[LineNumberTable(new byte[] { 161, 139, 241, 71, 119, 105, 140 })]
			internal override TypeVariable captureAsTypeVariable(java.lang.reflect.Type[] P_0)
			{
				LinkedHashSet.___003Cclinit_003E();
				LinkedHashSet linkedHashSet = new LinkedHashSet(Arrays.asList(P_0));
				((Set)linkedHashSet).addAll((Collection)Arrays.asList(val_0024typeParam.getBounds()));
				if (((Set)linkedHashSet).size() > 1)
				{
					((Set)linkedHashSet).remove((object)ClassLiteral<java.lang.Object>.Value);
				}
				TypeVariable result = base.captureAsTypeVariable((java.lang.reflect.Type[])((Set)linkedHashSet).toArray((object[])new java.lang.reflect.Type[0]));
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				WildcardCapturer.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static WildcardCapturer INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private AtomicInteger id;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 91, 103, 104, 130, 104, 130, 104, 103, 97,
			48, 168, 107, 103, 108, 103, 104, 106, 57, 168,
			97, 51, 232, 69, 104, 104, 105, 101, 176, 162
		})]
		internal java.lang.reflect.Type capture(java.lang.reflect.Type P_0)
		{
			Preconditions.checkNotNull(P_0);
			if (P_0 is Class)
			{
				return P_0;
			}
			if (P_0 is TypeVariable)
			{
				return P_0;
			}
			if (P_0 is GenericArrayType)
			{
				GenericArrayType genericArrayType = (GenericArrayType)P_0;
				java.lang.reflect.Type result = Types.newArrayType(notForTypeVariable().capture(genericArrayType.getGenericComponentType()));
				_ = null;
				return result;
			}
			if (P_0 is ParameterizedType)
			{
				ParameterizedType parameterizedType = (ParameterizedType)P_0;
				Class @class = (Class)parameterizedType.getRawType();
				TypeVariable[] typeParameters = @class.getTypeParameters();
				java.lang.reflect.Type[] actualTypeArguments = parameterizedType.getActualTypeArguments();
				for (int i = 0; i < (nint)actualTypeArguments.LongLength; i++)
				{
					actualTypeArguments[i] = forTypeVariable(typeParameters[i]).capture(actualTypeArguments[i]);
				}
				ParameterizedType result2 = Types.newParameterizedTypeWithOwner(notForTypeVariable().captureNullable(parameterizedType.getOwnerType()), @class, actualTypeArguments);
				_ = null;
				return result2;
			}
			if (P_0 is WildcardType)
			{
				WildcardType wildcardType = (WildcardType)P_0;
				java.lang.reflect.Type[] lowerBounds = wildcardType.getLowerBounds();
				if (lowerBounds.Length == 0)
				{
					TypeVariable result3 = captureAsTypeVariable(wildcardType.getUpperBounds());
					_ = null;
					return result3;
				}
				return P_0;
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("must have been one of the known types");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 86, 104, 103 })]
		private WildcardCapturer(AtomicInteger P_0)
		{
			id = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(526)]
		private WildcardCapturer notForTypeVariable()
		{
			WildcardCapturer result = new WildcardCapturer(id);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/TypeVariable<*>;)Lcom/google/common/reflect/TypeResolver$WildcardCapturer;")]
		[LineNumberTable(506)]
		private WildcardCapturer forTypeVariable(TypeVariable P_0)
		{
			_1.___003Cclinit_003E();
			_1 result = new _1(this, id, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 161, 99, 130 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private java.lang.reflect.Type captureNullable([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] java.lang.reflect.Type P_0)
		{
			if (P_0 == null)
			{
				return null;
			}
			java.lang.reflect.Type result = capture(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([Ljava/lang/reflect/Type;)Ljava/lang/reflect/TypeVariable<*>;")]
		[LineNumberTable(new byte[] { 161, 130, 102, 127, 50 })]
		internal virtual TypeVariable captureAsTypeVariable(java.lang.reflect.Type[] P_0)
		{
			int i = id.incrementAndGet();
			string text = Joiner.on('&').join(P_0);
			int num = 33 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string text2 = new StringBuilder(num).append("capture#").append(i).append("-of ? extends ")
				.append(text)
				.toString();
			TypeVariable result = Types.newArtificialTypeVariable(ClassLiteral<WildcardCapturer>.Value, text2, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 83, 109 })]
		private WildcardCapturer()
			: this(new AtomicInteger())
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(446)]
		internal WildcardCapturer(AtomicInteger P_0, TypeResolver._1 P_1)
			: this(P_0)
		{
		}

		[LineNumberTable(448)]
		static WildcardCapturer()
		{
			INSTANCE = new WildcardCapturer();
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private TypeTable typeTable;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(54)]
	internal static void access_0024000(Map P_0, java.lang.reflect.Type P_1, java.lang.reflect.Type P_2)
	{
		populateTypeMappings(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(54)]
	internal static object access_0024100(Class P_0, object P_1)
	{
		object result = expectArgument(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 123, 104, 103, 44, 166 })]
	private java.lang.reflect.Type[] resolveTypes(java.lang.reflect.Type[] P_0)
	{
		java.lang.reflect.Type[] array = new java.lang.reflect.Type[(nint)P_0.LongLength];
		for (int i = 0; i < (nint)P_0.LongLength; i++)
		{
			array[i] = resolveType(P_0[i]);
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 12, 104, 103 })]
	private TypeResolver(TypeTable P_0)
	{
		typeTable = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;Ljava/lang/Object;)TT;")]
	[LineNumberTable(new byte[] { 160, 155, 127, 1, 97 })]
	private static object expectArgument(Class P_0, object P_1)
	{
		//Discarded unreachable code: IL_0009
		try
		{
			return P_0.cast(P_1);
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
		string text = java.lang.String.valueOf(P_1);
		string simpleName = P_0.getSimpleName();
		int num = 10 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(simpleName));
		num = num;
		string s = new StringBuilder(num).append(text).append(" is not a ").append(simpleName)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Lcom/google/common/reflect/TypeResolver$TypeVariableKey;Ljava/lang/reflect/Type;>;Ljava/lang/reflect/Type;Ljava/lang/reflect/Type;)V")]
	[LineNumberTable(new byte[] { 75, 105, 129, 241, 160, 78, 103 })]
	private static void populateTypeMappings(Map P_0, java.lang.reflect.Type P_1, java.lang.reflect.Type P_2)
	{
		if (!java.lang.Object.instancehelper_equals(P_1, P_2))
		{
			new _1(P_0, P_2).visit(P_1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 8, 104, 107 })]
	public TypeResolver()
	{
		typeTable = new TypeTable();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Lcom/google/common/reflect/TypeResolver$TypeVariableKey;+Ljava/lang/reflect/Type;>;)Lcom/google/common/reflect/TypeResolver;")]
	[LineNumberTable(120)]
	internal virtual TypeResolver where(Map P_0)
	{
		TypeResolver result = new TypeResolver(typeTable.where(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 143, 103, 110, 141, 103, 105 })]
	private ParameterizedType resolveParameterizedType(ParameterizedType P_0)
	{
		java.lang.reflect.Type ownerType = P_0.getOwnerType();
		java.lang.reflect.Type type = ((ownerType != null) ? resolveType(ownerType) : null);
		java.lang.reflect.Type type2 = resolveType(P_0.getRawType());
		java.lang.reflect.Type[] actualTypeArguments = P_0.getActualTypeArguments();
		java.lang.reflect.Type[] array = resolveTypes(actualTypeArguments);
		ParameterizedType result = Types.newParameterizedTypeWithOwner(type, (Class)type2, array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 137, 103, 104 })]
	private java.lang.reflect.Type resolveGenericArrayType(GenericArrayType P_0)
	{
		java.lang.reflect.Type genericComponentType = P_0.getGenericComponentType();
		java.lang.reflect.Type type = resolveType(genericComponentType);
		java.lang.reflect.Type result = Types.newArrayType(type);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 131, 103, 103 })]
	private WildcardType resolveWildcardType(WildcardType P_0)
	{
		java.lang.reflect.Type[] lowerBounds = P_0.getLowerBounds();
		java.lang.reflect.Type[] upperBounds = P_0.getUpperBounds();
		Types.WildcardTypeImpl result = new Types.WildcardTypeImpl(resolveTypes(lowerBounds), resolveTypes(upperBounds));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 100, 103, 104, 116, 104, 111, 104, 111, 104,
		175
	})]
	public virtual java.lang.reflect.Type resolveType(java.lang.reflect.Type type)
	{
		Preconditions.checkNotNull(type);
		if (type is TypeVariable)
		{
			java.lang.reflect.Type result = typeTable.resolve((TypeVariable)type);
			_ = null;
			return result;
		}
		if (type is ParameterizedType)
		{
			ParameterizedType result2 = resolveParameterizedType((ParameterizedType)type);
			_ = null;
			return result2;
		}
		if (type is GenericArrayType)
		{
			java.lang.reflect.Type result3 = resolveGenericArrayType((GenericArrayType)type);
			_ = null;
			return result3;
		}
		if (type is WildcardType)
		{
			WildcardType result4 = resolveWildcardType((WildcardType)type);
			_ = null;
			return result4;
		}
		return type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	internal static TypeResolver covariantly(java.lang.reflect.Type P_0)
	{
		TypeResolver result = new TypeResolver().where(TypeMappingIntrospector.getTypeMappings(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 39, 108 })]
	internal static TypeResolver invariantly(java.lang.reflect.Type P_0)
	{
		java.lang.reflect.Type type = WildcardCapturer.INSTANCE.capture(P_0);
		TypeResolver result = new TypeResolver().where(TypeMappingIntrospector.getTypeMappings(type));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 63, 102, 124 })]
	public virtual TypeResolver where(java.lang.reflect.Type formal, java.lang.reflect.Type actual)
	{
		HashMap hashMap = Maps.newHashMap();
		populateTypeMappings(hashMap, (java.lang.reflect.Type)Preconditions.checkNotNull(formal), (java.lang.reflect.Type)Preconditions.checkNotNull(actual));
		TypeResolver result = where(hashMap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 116, 103, 44, 166 })]
	internal virtual java.lang.reflect.Type[] resolveTypesInPlace(java.lang.reflect.Type[] P_0)
	{
		for (int i = 0; i < (nint)P_0.LongLength; i++)
		{
			P_0[i] = resolveType(P_0[i]);
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(54)]
	internal TypeResolver(TypeTable P_0, _1 P_1)
		: this(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(54)]
	internal static java.lang.reflect.Type[] access_0024300(TypeResolver P_0, java.lang.reflect.Type[] P_1)
	{
		java.lang.reflect.Type[] result = P_0.resolveTypes(P_1);
		_ = null;
		return result;
	}
}
