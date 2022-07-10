using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.@ref;
using java.lang.reflect;
using java.util;
using java.util.concurrent;
using java.util.function;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)100,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal sealed class FuturesGetChecked : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/lang/reflect/Constructor<*>;Ljava/lang/Boolean;>;")]
	[EnclosingMethod(null, null, null)]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/Constructor<*>;)Ljava/lang/Boolean;")]
		[LineNumberTable(260)]
		public virtual java.lang.Boolean apply(Constructor P_0)
		{
			java.lang.Boolean result = java.lang.Boolean.valueOf(Arrays.asList(P_0.getParameterTypes()).contains(ClassLiteral<java.lang.String>.Value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(257)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(257)]
		public virtual object apply(object P_0)
		{
			java.lang.Boolean result = apply((Constructor)P_0);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}

		bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}
	}

	internal interface GetCheckedTypeValidator
	{
		[Signature("(Ljava/lang/Class<+Ljava/lang/Exception;>;)V")]
		virtual void validateClass(Class P_0);
	}

	internal class GetCheckedTypeValidatorHolder : java.lang.Object
	{
		[Serializable]
		[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		[Signature("Ljava/lang/Enum<Lcom/google/common/util/concurrent/FuturesGetChecked$GetCheckedTypeValidatorHolder$ClassValueValidator;>;Lcom/google/common/util/concurrent/FuturesGetChecked$GetCheckedTypeValidator;")]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[Implements(new string[] { "com.google.common.util.concurrent.FuturesGetChecked$GetCheckedTypeValidator" })]
		internal sealed class ClassValueValidator : java.lang.Enum, GetCheckedTypeValidator
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Ljava/lang/ClassValue<Ljava/lang/Boolean;>;")]
			[EnclosingMethod(null, null, null)]
			internal class _1 : ClassValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[SpecialName]
				public new static void ___003Cclinit_003E()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(Ljava/lang/Class<*>;)Ljava/lang/Boolean;")]
				[LineNumberTable(new byte[] { 85, 112 })]
				protected internal new virtual java.lang.Boolean computeValue(Class P_0)
				{
					checkExceptionClassValidity(P_0.asSubclass(ClassLiteral<java.lang.Exception>.Value));
					java.lang.Boolean result = java.lang.Boolean.valueOf(b: true);
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(132)]
				internal _1()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(132)]
				protected internal override object computeValue(Class P_0)
				{
					java.lang.Boolean result = computeValue(P_0);
					_ = null;
					return result;
				}

				[HideFromJava]
				static _1()
				{
					ClassValue.___003Cclinit_003E();
				}
			}

			[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
			public static ClassValueValidator INSTANCE;

			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
			[Signature("Ljava/lang/ClassValue<Ljava/lang/Boolean;>;")]
			private static ClassValue isValidClass;

			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
			private static ClassValueValidator[] _0024VALUES;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()V")]
			[LineNumberTable(124)]
			private ClassValueValidator(string P_0, int P_1)
				: base(P_0, P_1)
			{
				GC.KeepAlive(this);
			}

			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(123)]
			private static ClassValueValidator[] _0024values()
			{
				return new ClassValueValidator[1] { INSTANCE };
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(123)]
			public static ClassValueValidator[] values()
			{
				return (ClassValueValidator[])_0024VALUES.Clone();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(123)]
			public static ClassValueValidator valueOf(string P_0)
			{
				return (ClassValueValidator)java.lang.Enum.valueOf(ClassLiteral<ClassValueValidator>.Value, P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/lang/Class<+Ljava/lang/Exception;>;)V")]
			[LineNumberTable(new byte[] { 92, 108 })]
			public virtual void validateClass(Class P_0)
			{
				isValidClass.get(P_0);
			}

			[LineNumberTable(new byte[] { 75, 16, 234, 72 })]
			static ClassValueValidator()
			{
				INSTANCE = new ClassValueValidator("INSTANCE", 0);
				_0024VALUES = _0024values();
				isValidClass = new _1();
			}
		}

		[Serializable]
		[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		[Signature("Ljava/lang/Enum<Lcom/google/common/util/concurrent/FuturesGetChecked$GetCheckedTypeValidatorHolder$WeakSetValidator;>;Lcom/google/common/util/concurrent/FuturesGetChecked$GetCheckedTypeValidator;")]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[Implements(new string[] { "com.google.common.util.concurrent.FuturesGetChecked$GetCheckedTypeValidator" })]
		internal sealed class WeakSetValidator : java.lang.Enum, GetCheckedTypeValidator
		{
			[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
			public static WeakSetValidator INSTANCE;

			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
			[Signature("Ljava/util/Set<Ljava/lang/ref/WeakReference<Ljava/lang/Class<+Ljava/lang/Exception;>;>;>;")]
			private static Set validClasses;

			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
			private static WeakSetValidator[] _0024VALUES;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()V")]
			[LineNumberTable(146)]
			private WeakSetValidator(string P_0, int P_1)
				: base(P_0, P_1)
			{
				GC.KeepAlive(this);
			}

			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(146)]
			private static WeakSetValidator[] _0024values()
			{
				return new WeakSetValidator[1] { INSTANCE };
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(146)]
			public static WeakSetValidator[] values()
			{
				return (WeakSetValidator[])_0024VALUES.Clone();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(146)]
			public static WeakSetValidator valueOf(string P_0)
			{
				return (WeakSetValidator)java.lang.Enum.valueOf(ClassLiteral<WeakSetValidator>.Value, P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/lang/Class<+Ljava/lang/Exception;>;)V")]
			[LineNumberTable(new byte[]
			{
				112, 127, 0, 110, 161, 98, 230, 75, 113, 170,
				113
			})]
			public virtual void validateClass(Class P_0)
			{
				Iterator iterator = validClasses.iterator();
				while (iterator.hasNext())
				{
					java.lang.@ref.WeakReference weakReference = (java.lang.@ref.WeakReference)iterator.next();
					if (java.lang.Object.instancehelper_equals(P_0, weakReference.get()))
					{
						return;
					}
				}
				checkExceptionClassValidity(P_0);
				if (validClasses.size() > 1000)
				{
					validClasses.clear();
				}
				validClasses.add(new java.lang.@ref.WeakReference(P_0));
			}

			[LineNumberTable(new byte[] { 97, 48, 234, 75 })]
			static WeakSetValidator()
			{
				INSTANCE = new WeakSetValidator("INSTANCE", 0);
				_0024VALUES = _0024values();
				validClasses = new CopyOnWriteArraySet();
			}
		}

		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static string CLASS_VALUE_VALIDATOR_NAME;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static GetCheckedTypeValidator BEST_VALIDATOR;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 79, 101, 117, 127, 8, 97 })]
		internal static GetCheckedTypeValidator getBestValidator()
		{
			//Discarded unreachable code: IL_002e
			try
			{
				Class @class = Class.forName(CLASS_VALUE_VALIDATOR_NAME, GetCheckedTypeValidatorHolder.___003CGetCallerID_003E()).asSubclass(ClassLiteral<java.lang.Enum>.Value);
				return (GetCheckedTypeValidator)((java.lang.Enum[])@class.getEnumConstants())[0];
			}
			catch (System.Exception x)
			{
				ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
			}
			_ = null;
			return weakSetValidator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(117)]
		internal GetCheckedTypeValidatorHolder()
		{
		}

		[LineNumberTable(new byte[] { 68, 101, 153 })]
		static GetCheckedTypeValidatorHolder()
		{
			CLASS_VALUE_VALIDATOR_NAME = java.lang.String.instancehelper_concat(java.lang.String.valueOf(ClassLiteral<GetCheckedTypeValidatorHolder>.Value.getName()), "$ClassValueValidator");
			BEST_VALIDATOR = getBestValidator();
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

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Ordering<Ljava/lang/reflect/Constructor<*>;>;")]
	private static Ordering WITH_STRING_PARAM_FIRST;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Exception;>(Ljava/util/concurrent/Future<TV;>;Ljava/lang/Class<TX;>;)TV;^TX;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 100, 0, 0 })]
	[LineNumberTable(49)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	internal static object getChecked(Future P_0, Class P_1)
	{
		object @checked = getChecked(bestGetCheckedTypeValidator(), P_0, P_1);
		_ = null;
		return @checked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Exception;>(Ljava/util/concurrent/Future<TV;>;Ljava/lang/Class<TX;>;JLjava/util/concurrent/TimeUnit;)TV;^TX;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 100, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		26, 139, 127, 23, 98, 106, 110, 98, 110, 98,
		109
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	internal static object getChecked(Future P_0, Class P_1, long P_2, TimeUnit P_3)
	{
		//Discarded unreachable code: IL_0015
		bestGetCheckedTypeValidator().validateClass(P_1);
		InterruptedException ex;
		java.util.concurrent.TimeoutException ex2;
		ExecutionException ex3;
		try
		{
			try
			{
				try
				{
					return P_0.get(P_2, P_3);
				}
				catch (InterruptedException x)
				{
					ex = ByteCodeHelper.MapException<InterruptedException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (java.util.concurrent.TimeoutException x2)
			{
				ex2 = ByteCodeHelper.MapException<java.util.concurrent.TimeoutException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_003a;
			}
		}
		catch (ExecutionException x3)
		{
			ex3 = ByteCodeHelper.MapException<ExecutionException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_003d;
		}
		InterruptedException ex4 = ex;
		Thread.currentThread().interrupt();
		throw Throwable.___003Cunmap_003E(newWithCause(P_1, ex4));
		IL_003d:
		ExecutionException @this = ex3;
		wrapAndThrowExceptionOrError(Throwable.instancehelper_getCause(@this), P_1);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError();
		IL_003a:
		java.util.concurrent.TimeoutException ex5 = ex2;
		throw Throwable.___003Cunmap_003E(newWithCause(P_1, ex5));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(96)]
	private static GetCheckedTypeValidator bestGetCheckedTypeValidator()
	{
		return GetCheckedTypeValidatorHolder.BEST_VALIDATOR;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Exception;>(Lcom/google/common/util/concurrent/FuturesGetChecked$GetCheckedTypeValidator;Ljava/util/concurrent/Future<TV;>;Ljava/lang/Class<TX;>;)TV;^TX;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 100, 0, 0 })]
	[LineNumberTable(new byte[] { 8, 135, 127, 9, 97, 106, 109, 98, 109 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	internal static object getChecked(GetCheckedTypeValidator P_0, Future P_1, Class P_2)
	{
		//Discarded unreachable code: IL_000f
		P_0.validateClass(P_2);
		InterruptedException ex;
		ExecutionException ex2;
		try
		{
			try
			{
				return P_1.get();
			}
			catch (InterruptedException x)
			{
				ex = ByteCodeHelper.MapException<InterruptedException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (ExecutionException x2)
		{
			ex2 = ByteCodeHelper.MapException<ExecutionException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_002b;
		}
		InterruptedException ex3 = ex;
		Thread.currentThread().interrupt();
		throw Throwable.___003Cunmap_003E(newWithCause(P_2, ex3));
		IL_002b:
		ExecutionException @this = ex2;
		wrapAndThrowExceptionOrError(Throwable.instancehelper_getCause(@this), P_2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Exception;>(Ljava/lang/Class<TX;>;Ljava/lang/Throwable;)TX;")]
	[LineNumberTable(new byte[]
	{
		160, 118, 113, 127, 1, 109, 99, 104, 136, 130,
		98
	})]
	private static java.lang.Exception newWithCause(Class P_0, System.Exception P_1)
	{
		List list = Arrays.asList(P_0.getConstructors(FuturesGetChecked.___003CGetCallerID_003E()));
		Iterator iterator = preferringStrings(list).iterator();
		while (iterator.hasNext())
		{
			Constructor constructor = (Constructor)iterator.next();
			java.lang.Exception ex = (java.lang.Exception)newFromConstructor(constructor, P_1);
			if (ex != null)
			{
				if (Throwable.instancehelper_getCause(ex) == null)
				{
					Throwable.instancehelper_initCause(ex, P_1);
				}
				return ex;
			}
		}
		string text = java.lang.String.valueOf(P_0);
		int num = 82 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string message = new StringBuilder(num).append("No appropriate constructor for exception of type ").append(text).append(" in response to chained exception")
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(message, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("<X:Ljava/lang/Exception;>(Ljava/lang/Throwable;Ljava/lang/Class<TX;>;)V^TX;")]
	[LineNumberTable(new byte[] { 160, 91, 104, 145, 104, 140 })]
	private static void wrapAndThrowExceptionOrError(System.Exception P_0, Class P_1)
	{
		if (P_0 is Error)
		{
			Error cause = (Error)P_0;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ExecutionError(cause);
		}
		if (P_0 is RuntimeException)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UncheckedExecutionException(P_0);
		}
		throw Throwable.___003Cunmap_003E(newWithCause(P_1, P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Exception;>(Ljava/util/List<Ljava/lang/reflect/Constructor<TX;>;>;)Ljava/util/List<Ljava/lang/reflect/Constructor<TX;>;>;")]
	[LineNumberTable(251)]
	private static List preferringStrings(List P_0)
	{
		List result = WITH_STRING_PARAM_FIRST.sortedCopy(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Object;>(Ljava/lang/reflect/Constructor<TX;>;Ljava/lang/Throwable;)TX;")]
	[LineNumberTable(new byte[]
	{
		160, 153, 103, 104, 103, 100, 109, 107, 109, 134,
		226, 57, 230, 75, 127, 14, 193
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static object newFromConstructor(Constructor P_0, System.Exception P_1)
	{
		//Discarded unreachable code: IL_005b
		Class[] parameterTypes = P_0.getParameterTypes();
		object[] array = new object[(nint)parameterTypes.LongLength];
		for (int i = 0; i < (nint)parameterTypes.LongLength; i++)
		{
			Class @this = parameterTypes[i];
			if (java.lang.Object.instancehelper_equals(@this, ClassLiteral<java.lang.String>.Value))
			{
				array[i] = Throwable.instancehelper_toString(P_1);
				continue;
			}
			if (java.lang.Object.instancehelper_equals(@this, ClassLiteral<Throwable>.Value))
			{
				array[i] = P_1;
				continue;
			}
			return null;
		}
		try
		{
			try
			{
				try
				{
					try
					{
						return P_0.newInstance(array, FuturesGetChecked.___003CGetCallerID_003E());
					}
					catch (IllegalArgumentException)
					{
					}
				}
				catch (InstantiationException)
				{
					goto IL_0070;
				}
			}
			catch (IllegalAccessException)
			{
				goto IL_0073;
			}
		}
		catch (InvocationTargetException)
		{
			goto IL_0076;
		}
		object obj = null;
		goto IL_007a;
		IL_0073:
		obj = null;
		goto IL_007a;
		IL_007a:
		return null;
		IL_0076:
		obj = null;
		goto IL_007a;
		IL_0070:
		obj = null;
		goto IL_007a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<+Ljava/lang/Exception;>;)Z")]
	[LineNumberTable(291)]
	internal static bool isCheckedException(Class P_0)
	{
		return (!ClassLiteral<RuntimeException>.Value.isAssignableFrom(P_0)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<+Ljava/lang/Exception;>;)Z")]
	[LineNumberTable(new byte[] { 160, 108, 108, 122, 97 })]
	private static bool hasConstructorUsableByGetChecked(Class P_0)
	{
		//Discarded unreachable code: IL_000f
		try
		{
			newWithCause(P_0, new java.lang.Exception());
			return true;
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(101)]
	internal static GetCheckedTypeValidator weakSetValidator()
	{
		return GetCheckedTypeValidatorHolder.WeakSetValidator.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(107)]
	internal static GetCheckedTypeValidator classValueValidator()
	{
		return GetCheckedTypeValidatorHolder.ClassValueValidator.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<+Ljava/lang/Exception;>;)V")]
	[LineNumberTable(new byte[] { 160, 182, 97, 43, 197, 97, 43, 231, 69 })]
	internal static void checkExceptionClassValidity(Class P_0)
	{
		Preconditions.checkArgument(isCheckedException(P_0), "Futures.getChecked exception type (%s) must not be a RuntimeException", P_0);
		Preconditions.checkArgument(hasConstructorUsableByGetChecked(P_0), "Futures.getChecked exception type (%s) must be an accessible class with an accessible constructor whose parameters (if any) must be of type String and/or Throwable", P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(307)]
	private FuturesGetChecked()
	{
	}

	[LineNumberTable(new byte[] { 160, 141, 106, 229, 71, 234, 55 })]
	static FuturesGetChecked()
	{
		WITH_STRING_PARAM_FIRST = Ordering.natural().onResultOf(new _1()).reverse();
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
