using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using java.util;
using javax.annotation;

namespace com.google.common.reflect;

[Signature("<T:Ljava/lang/Object;R:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/reflect/AnnotatedElement;Ljava/lang/reflect/Member;")]
[ConstantPool(new object[]
{
	(byte)168,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.lang.reflect.AnnotatedElement", "java.lang.reflect.Member" })]
public abstract class Invokable : java.lang.Object, AnnotatedElement, Member
{
	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/reflect/Invokable<TT;TT;>;")]
	[ConstantPool(new object[]
	{
		(byte)68,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class ConstructorInvokable : Invokable
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/lang/reflect/Constructor<*>;")]
		internal Constructor constructor;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/Constructor<*>;)V")]
		[LineNumberTable(new byte[] { 161, 55, 105, 103 })]
		internal ConstructorInvokable(Constructor P_0)
			: base(P_0)
		{
			constructor = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 150, 108, 141, 130, 108, 131, 242, 72, 110,
			48
		})]
		private bool mayNeedHiddenThis()
		{
			Class declaringClass = constructor.getDeclaringClass();
			if (declaringClass.getEnclosingConstructor(ConstructorInvokable.___003CGetCallerID_003E()) != null)
			{
				return true;
			}
			Method enclosingMethod = declaringClass.getEnclosingMethod(ConstructorInvokable.___003CGetCallerID_003E());
			if (enclosingMethod != null)
			{
				return (!Modifier.isStatic(enclosingMethod.getModifiers())) ? true : false;
			}
			return (declaringClass.getEnclosingClass(ConstructorInvokable.___003CGetCallerID_003E()) != null && !Modifier.isStatic(declaringClass.getModifiers())) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.reflect.InvocationTargetException", "java.lang.IllegalAccessException" })]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 1, 1, 0, 0, 0, 68, 0,
			0
		})]
		[LineNumberTable(new byte[] { 161, 63, 127, 8, 97 })]
		internal sealed override object invokeInternal([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, object[] P_1)
		{
			//Discarded unreachable code: IL_0013
			InstantiationException ex;
			try
			{
				return constructor.newInstance(P_1, ConstructorInvokable.___003CGetCallerID_003E());
			}
			catch (InstantiationException x)
			{
				ex = ByteCodeHelper.MapException<InstantiationException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			InstantiationException cause = ex;
			string text = java.lang.String.valueOf(constructor);
			int num = 8 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string message = new StringBuilder(num).append(text).append(" failed.").toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message, cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 75, 103, 103, 101, 138 })]
		internal override java.lang.reflect.Type getGenericReturnType()
		{
			Class declaringClass = getDeclaringClass();
			TypeVariable[] typeParameters = declaringClass.getTypeParameters();
			if ((nint)typeParameters.LongLength > 0)
			{
				ParameterizedType result = Types.newParameterizedType(declaringClass, typeParameters);
				_ = null;
				return result;
			}
			return declaringClass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 86, 108, 109, 108, 106, 145, 175 })]
		internal override java.lang.reflect.Type[] getGenericParameterTypes()
		{
			java.lang.reflect.Type[] genericParameterTypes = constructor.getGenericParameterTypes();
			if ((nint)genericParameterTypes.LongLength > 0 && mayNeedHiddenThis())
			{
				Class[] parameterTypes = constructor.getParameterTypes();
				if ((nint)genericParameterTypes.LongLength == (nint)parameterTypes.LongLength && parameterTypes[0] == getDeclaringClass().getEnclosingClass(ConstructorInvokable.___003CGetCallerID_003E()))
				{
					return (java.lang.reflect.Type[])Arrays.copyOfRange(genericParameterTypes, 1, genericParameterTypes.Length);
				}
			}
			return genericParameterTypes;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(470)]
		internal override AnnotatedType[] getAnnotatedParameterTypes()
		{
			AnnotatedType[] annotatedParameterTypes = constructor.getAnnotatedParameterTypes();
			_ = null;
			return annotatedParameterTypes;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(475)]
		public override AnnotatedType getAnnotatedReturnType()
		{
			AnnotatedType annotatedReturnType = constructor.getAnnotatedReturnType();
			_ = null;
			return annotatedReturnType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(480)]
		internal override java.lang.reflect.Type[] getGenericExceptionTypes()
		{
			java.lang.reflect.Type[] genericExceptionTypes = constructor.getGenericExceptionTypes();
			_ = null;
			return genericExceptionTypes;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(485)]
		internal sealed override Annotation[][] getParameterAnnotations()
		{
			Annotation[][] parameterAnnotations = constructor.getParameterAnnotations();
			_ = null;
			return parameterAnnotations;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()[Ljava/lang/reflect/TypeVariable<*>;")]
		[LineNumberTable(new byte[] { 161, 129, 108, 108, 139, 107, 140 })]
		public sealed override TypeVariable[] getTypeParameters()
		{
			TypeVariable[] typeParameters = getDeclaringClass().getTypeParameters();
			TypeVariable[] typeParameters2 = constructor.getTypeParameters();
			TypeVariable[] array = new TypeVariable[(nint)typeParameters.LongLength + (nint)typeParameters2.LongLength];
			ByteCodeHelper.arraycopy(typeParameters, 0, array, 0, typeParameters.Length);
			ByteCodeHelper.arraycopy(typeParameters2, 0, array, typeParameters.Length, typeParameters2.Length);
			return array;
		}

		public sealed override bool isOverridable()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(516)]
		public sealed override bool isVarArgs()
		{
			bool result = constructor.isVarArgs();
			_ = null;
			return result;
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

	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/reflect/Invokable<TT;Ljava/lang/Object;>;")]
	[ConstantPool(new object[]
	{
		(byte)45,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class MethodInvokable : Invokable
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final)]
		internal Method method;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 246, 105, 103 })]
		internal MethodInvokable(Method P_0)
			: base(P_0)
		{
			method = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.reflect.InvocationTargetException", "java.lang.IllegalAccessException" })]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 1, 1, 0, 0, 0, 45, 0,
			0
		})]
		[LineNumberTable(368)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal sealed override object invokeInternal([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, object[] P_1)
		{
			object result = method.invoke(P_0, P_1, MethodInvokable.___003CGetCallerID_003E());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(373)]
		internal override java.lang.reflect.Type getGenericReturnType()
		{
			java.lang.reflect.Type genericReturnType = method.getGenericReturnType();
			_ = null;
			return genericReturnType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(378)]
		internal override java.lang.reflect.Type[] getGenericParameterTypes()
		{
			java.lang.reflect.Type[] genericParameterTypes = method.getGenericParameterTypes();
			_ = null;
			return genericParameterTypes;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(383)]
		internal override AnnotatedType[] getAnnotatedParameterTypes()
		{
			AnnotatedType[] annotatedParameterTypes = method.getAnnotatedParameterTypes();
			_ = null;
			return annotatedParameterTypes;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(388)]
		public override AnnotatedType getAnnotatedReturnType()
		{
			AnnotatedType annotatedReturnType = method.getAnnotatedReturnType();
			_ = null;
			return annotatedReturnType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(393)]
		internal override java.lang.reflect.Type[] getGenericExceptionTypes()
		{
			java.lang.reflect.Type[] genericExceptionTypes = method.getGenericExceptionTypes();
			_ = null;
			return genericExceptionTypes;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(398)]
		internal sealed override Annotation[][] getParameterAnnotations()
		{
			Annotation[][] parameterAnnotations = method.getParameterAnnotations();
			_ = null;
			return parameterAnnotations;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()[Ljava/lang/reflect/TypeVariable<*>;")]
		[LineNumberTable(403)]
		public sealed override TypeVariable[] getTypeParameters()
		{
			TypeVariable[] typeParameters = method.getTypeParameters();
			_ = null;
			return typeParameters;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 38, 105, 104, 104, 245, 61 })]
		public sealed override bool isOverridable()
		{
			return (!isFinal() && !isPrivate() && !isStatic() && !Modifier.isFinal(getDeclaringClass().getModifiers())) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(416)]
		public sealed override bool isVarArgs()
		{
			bool result = method.isVarArgs();
			_ = null;
			return result;
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

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private AccessibleObject accessibleObject;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Member member;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(145)]
	public int getModifiers()
	{
		int modifiers = member.getModifiers();
		_ = null;
		return modifiers;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(170)]
	public bool isPrivate()
	{
		bool result = Modifier.isPrivate(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(155)]
	public bool isPublic()
	{
		bool result = Modifier.isPublic(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(160)]
	public bool isProtected()
	{
		bool result = Modifier.isProtected(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/reflect/TypeToken<TT;>;")]
	[LineNumberTable(335)]
	public virtual TypeToken getOwnerType()
	{
		TypeToken result = TypeToken.of(getDeclaringClass());
		_ = null;
		return result;
	}

	[Throws(new string[] { "java.lang.reflect.InvocationTargetException", "java.lang.IllegalAccessException" })]
	[Modifiers(Modifiers.Abstract)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 168, 0,
		0
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual object invokeInternal([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, object[] P_1)
	{
		throw new AbstractMethodError("com.google.common.reflect.Invokable.invokeInternal(Ljava.lang.Object;[Ljava.lang.Object;)Ljava.lang.Object;");
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual java.lang.reflect.Type getGenericReturnType()
	{
		throw new AbstractMethodError("com.google.common.reflect.Invokable.getGenericReturnType()Ljava.lang.reflect.Type;");
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual java.lang.reflect.Type[] getGenericParameterTypes()
	{
		throw new AbstractMethodError("com.google.common.reflect.Invokable.getGenericParameterTypes()[Ljava.lang.reflect.Type;");
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual Annotation[][] getParameterAnnotations()
	{
		throw new AbstractMethodError("com.google.common.reflect.Invokable.getParameterAnnotations()[[Ljava.lang.annotation.Annotation;");
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual AnnotatedType[] getAnnotatedParameterTypes()
	{
		throw new AbstractMethodError("com.google.common.reflect.Invokable.getAnnotatedParameterTypes()[Ljava.lang.reflect.AnnotatedType;");
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual java.lang.reflect.Type[] getGenericExceptionTypes()
	{
		throw new AbstractMethodError("com.google.common.reflect.Invokable.getGenericExceptionTypes()[Ljava.lang.reflect.Type;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R1:TR;>(Lcom/google/common/reflect/TypeToken<TR1;>;)Lcom/google/common/reflect/Invokable<TT;TR1;>;")]
	[LineNumberTable(new byte[] { 160, 202, 113, 97, 191, 70, 98 })]
	public Invokable returning(TypeToken returnType)
	{
		if (!returnType.isSupertypeOf(getReturnType()))
		{
			string text = java.lang.String.valueOf(getReturnType());
			string text2 = java.lang.String.valueOf(returnType);
			int num = 35 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string s = new StringBuilder(num).append("Invokable is known to return ").append(text).append(", not ")
				.append(text2)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/reflect/TypeToken<+TR;>;")]
	[LineNumberTable(268)]
	public TypeToken getReturnType()
	{
		TypeToken result = TypeToken.of(getGenericReturnType());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/lang/Class<-TT;>;")]
	[LineNumberTable(328)]
	public Class getDeclaringClass()
	{
		Class declaringClass = member.getDeclaringClass();
		_ = null;
		return declaringClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<M:Ljava/lang/reflect/AccessibleObject;:Ljava/lang/reflect/Member;>(TM;)V")]
	[LineNumberTable(new byte[] { 22, 104, 103, 103, 108 })]
	internal Invokable(AccessibleObject P_0)
	{
		Preconditions.checkNotNull(P_0);
		accessibleObject = P_0;
		member = (Member)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/reflect/Method;)Lcom/google/common/reflect/Invokable<*Ljava/lang/Object;>;")]
	[LineNumberTable(80)]
	public static Invokable from(Method method)
	{
		MethodInvokable result = new MethodInvokable(method);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/reflect/Constructor<TT;>;)Lcom/google/common/reflect/Invokable<TT;TT;>;")]
	[LineNumberTable(85)]
	public static Invokable from(Constructor constructor)
	{
		ConstructorInvokable result = new ConstructorInvokable(constructor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
	[LineNumberTable(90)]
	public bool isAnnotationPresent(Class annotationClass)
	{
		bool result = accessibleObject.isAnnotationPresent(annotationClass);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<A::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TA;>;)TA;")]
	[LineNumberTable(96)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public Annotation getAnnotation(Class annotationClass)
	{
		Annotation annotation = accessibleObject.getAnnotation(annotationClass);
		_ = null;
		return annotation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(101)]
	public Annotation[] getAnnotations()
	{
		Annotation[] annotations = accessibleObject.getAnnotations();
		_ = null;
		return annotations;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(106)]
	public Annotation[] getDeclaredAnnotations()
	{
		Annotation[] declaredAnnotations = accessibleObject.getDeclaredAnnotations();
		_ = null;
		return declaredAnnotations;
	}

	[Signature("()[Ljava/lang/reflect/TypeVariable<*>;")]
	public abstract TypeVariable[] getTypeParameters();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 113, 130, 110 })]
	public void setAccessible(bool flag)
	{
		accessibleObject.setAccessible(flag);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 76, 108, 122, 97 })]
	public bool trySetAccessible()
	{
		//Discarded unreachable code: IL_000f
		try
		{
			accessibleObject.setAccessible(flag: true);
			return true;
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<RuntimeException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(135)]
	public bool isAccessible()
	{
		bool result = accessibleObject.isAccessible();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(140)]
	public string getName()
	{
		string name = member.getName();
		_ = null;
		return name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(150)]
	public bool isSynthetic()
	{
		bool result = member.isSynthetic();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(165)]
	public bool isPackagePrivate()
	{
		return (!isPrivate() && !isPublic() && !isProtected()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(175)]
	public bool isStatic()
	{
		bool result = Modifier.isStatic(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(186)]
	public bool isFinal()
	{
		bool result = Modifier.isFinal(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(191)]
	public bool isAbstract()
	{
		bool result = Modifier.isAbstract(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(196)]
	public bool isNative()
	{
		bool result = Modifier.isNative(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(201)]
	public bool isSynchronized()
	{
		bool result = Modifier.isSynchronized(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(206)]
	internal bool isVolatile()
	{
		bool result = Modifier.isVolatile(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(211)]
	internal bool isTransient()
	{
		bool result = Modifier.isTransient(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 102, 104, 103, 159, 12 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		if (obj is Invokable)
		{
			Invokable invokable = (Invokable)obj;
			return (getOwnerType().equals(invokable.getOwnerType()) && java.lang.Object.instancehelper_equals(member, invokable.member)) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(225)]
	public override int hashCode()
	{
		int result = java.lang.Object.instancehelper_hashCode(member);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(230)]
	public override string toString()
	{
		string result = java.lang.Object.instancehelper_toString(member);
		_ = null;
		return result;
	}

	public abstract bool isOverridable();

	public abstract bool isVarArgs();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.reflect.InvocationTargetException", "java.lang.IllegalAccessException" })]
	[Signature("(TT;[Ljava/lang/Object;)TR;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 168, 0,
		0
	})]
	[LineNumberTable(261)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public object invoke([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object receiver, params object[] args)
	{
		object result = invokeInternal(receiver, (object[])Preconditions.checkNotNull(args));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<Lcom/google/common/reflect/Parameter;>;")]
	[LineNumberTable(new byte[]
	{
		160, 163, 103, 103, 103, 102, 105, 136, 18, 38,
		232, 69
	})]
	public ImmutableList getParameters()
	{
		java.lang.reflect.Type[] genericParameterTypes = getGenericParameterTypes();
		Annotation[][] parameterAnnotations = getParameterAnnotations();
		AnnotatedType[] annotatedParameterTypes = getAnnotatedParameterTypes();
		ImmutableList.Builder builder = ImmutableList.builder();
		for (int i = 0; i < (nint)genericParameterTypes.LongLength; i++)
		{
			builder.add(new Parameter(this, i, TypeToken.of(genericParameterTypes[i]), parameterAnnotations[i], annotatedParameterTypes[i]));
		}
		ImmutableList result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<Lcom/google/common/reflect/TypeToken<+Ljava/lang/Throwable;>;>;")]
	[LineNumberTable(new byte[] { 160, 177, 102, 181, 98, 103, 233, 59, 230, 71 })]
	public ImmutableList getExceptionTypes()
	{
		ImmutableList.Builder builder = ImmutableList.builder();
		java.lang.reflect.Type[] genericExceptionTypes = getGenericExceptionTypes();
		int num = genericExceptionTypes.Length;
		for (int i = 0; i < num; i++)
		{
			java.lang.reflect.Type type = genericExceptionTypes[i];
			TypeToken element = TypeToken.of(type);
			builder.add(element);
		}
		ImmutableList result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R1:TR;>(Ljava/lang/Class<TR1;>;)Lcom/google/common/reflect/Invokable<TT;TR1;>;")]
	[LineNumberTable(311)]
	public Invokable returning(Class returnType)
	{
		Invokable result = returning(TypeToken.of(returnType));
		_ = null;
		return result;
	}

	public abstract AnnotatedType getAnnotatedReturnType();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Annotation[] getDeclaredAnnotationsByType(Class P_0)
	{
		return AnnotatedElement._003Cdefault_003EgetDeclaredAnnotationsByType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Annotation[] getAnnotationsByType(Class P_0)
	{
		return AnnotatedElement._003Cdefault_003EgetAnnotationsByType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Annotation getDeclaredAnnotation(Class P_0)
	{
		return AnnotatedElement._003Cdefault_003EgetDeclaredAnnotation(this, P_0);
	}
}
