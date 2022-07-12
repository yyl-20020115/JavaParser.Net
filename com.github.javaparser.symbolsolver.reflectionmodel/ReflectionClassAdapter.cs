
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;

using ikvm.@internal;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.reflectionmodel;

internal class ReflectionClassAdapter
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly ReflectionClassAdapter arg_00241;

		internal ___003C_003EAnon0(ReflectionClassAdapter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedType result = arg_00241.lambda_0024getSuperClass_00240((Type)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly ReflectionClassAdapter arg_00241;

		internal ___003C_003EAnon1(ReflectionClassAdapter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedType result = arg_00241.lambda_0024getInterfaces_00241((Type)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly ArrayList arg_00241;

		internal ___003C_003EAnon3(ArrayList P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024getAllFields_00242(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		internal ___003C_003EAnon4()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getDeclaredMethods_00243((Method)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Function
	{
		private readonly ReflectionClassAdapter arg_00241;

		internal ___003C_003EAnon5(ReflectionClassAdapter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ReflectionMethodDeclaration result = arg_00241.lambda_0024getDeclaredMethods_00244((Method)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Predicate
	{
		internal ___003C_003EAnon6()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getConstructors_00245((Constructor)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : Function
	{
		private readonly ReflectionClassAdapter arg_00241;

		internal ___003C_003EAnon7(ReflectionClassAdapter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ReflectionConstructorDeclaration result = arg_00241.lambda_0024getConstructors_00246((Constructor)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

		private Class clazz;

	private TypeSolver typeSolver;

	private ResolvedReferenceTypeDeclaration typeDeclaration;

	
	private static CallerID ___003CcallerID_003E;

	
		
	public ReflectionClassAdapter(Class P_0, TypeSolver P_1, ResolvedReferenceTypeDeclaration P_2)
	{
		clazz = P_0;
		typeSolver = P_1;
		typeDeclaration = P_2;
	}

	
	
	public virtual bool hasDirectlyAnnotation(string P_0)
	{
		Annotation[] declaredAnnotations = clazz.getDeclaredAnnotations();
		int num = declaredAnnotations.Length;
		for (int i = 0; i < num; i++)
		{
			Annotation annotation = declaredAnnotations[i];
			if (String.instancehelper_equals(annotation.annotationType().getCanonicalName(), P_0))
			{
				return true;
			}
		}
		return false;
	}

	
		
	public virtual List getAllFields()
	{
		ArrayList arrayList = new ArrayList();
		Field[] declaredFields = clazz.getDeclaredFields(ReflectionClassAdapter.___003CGetCallerID_003E());
		int num = declaredFields.Length;
		for (int i = 0; i < num; i++)
		{
			Field field = declaredFields[i];
			arrayList.add(new ReflectionFieldDeclaration(field, typeSolver));
		}
		Iterator iterator = typeDeclaration.getAllAncestors().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			resolvedReferenceType.getTypeDeclaration().ifPresent(new ___003C_003EAnon3(arrayList));
		}
		return arrayList;
	}

	
		
	public virtual List getAncestors()
	{
		LinkedList linkedList = new LinkedList();
		if (getSuperClass().isPresent())
		{
			ReferenceTypeImpl e = (ReferenceTypeImpl)getSuperClass().get();
			((List)linkedList).add((object)e);
		}
		else
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl e = new ReferenceTypeImpl(new ReflectionClassDeclaration(ClassLiteral<Object>.Value, typeSolver), typeSolver);
			((List)linkedList).add((object)e);
		}
		((List)linkedList).addAll((Collection)getInterfaces());
		for (int i = 0; i < ((List)linkedList).size(); i++)
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)((List)linkedList).get(i);
			if (resolvedReferenceType.hasName() && resolvedReferenceType.isJavaLangObject())
			{
				((List)linkedList).remove(i);
				i += -1;
			}
		}
		return linkedList;
	}

	
		
	public virtual Optional getSuperClass()
	{
		if (clazz.getGenericSuperclass() == null)
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Type genericSuperclass = clazz.getGenericSuperclass();
		if (genericSuperclass is ParameterizedType)
		{
			ParameterizedType parameterizedType = (ParameterizedType)genericSuperclass;
			List typeArguments = (List)Arrays.stream(parameterizedType.getActualTypeArguments()).map(new ___003C_003EAnon0(this)).collect(Collectors.toList());
			ReferenceTypeImpl.___003Cclinit_003E();
			Optional result2 = Optional.of(new ReferenceTypeImpl(new ReflectionClassDeclaration(clazz.getSuperclass(), typeSolver), typeArguments, typeSolver));
			
			return result2;
		}
		ReferenceTypeImpl.___003Cclinit_003E();
		Optional result3 = Optional.of(new ReferenceTypeImpl(new ReflectionClassDeclaration(clazz.getSuperclass(), typeSolver), typeSolver));
		
		return result3;
	}

	
		
	public virtual List getInterfaces()
	{
		ArrayList arrayList = new ArrayList();
		Type[] genericInterfaces = clazz.getGenericInterfaces();
		int num = genericInterfaces.Length;
		for (int i = 0; i < num; i++)
		{
			Type type = genericInterfaces[i];
			if (type is ParameterizedType)
			{
				ParameterizedType parameterizedType = (ParameterizedType)type;
				List typeArguments = (List)Arrays.stream(parameterizedType.getActualTypeArguments()).map(new ___003C_003EAnon1(this)).collect(Collectors.toList());
				ReferenceTypeImpl.___003Cclinit_003E();
				((List)arrayList).add((object)new ReferenceTypeImpl(new ReflectionInterfaceDeclaration((Class)((ParameterizedType)type).getRawType(), typeSolver), typeArguments, typeSolver));
			}
			else
			{
				ReferenceTypeImpl.___003Cclinit_003E();
				((List)arrayList).add((object)new ReferenceTypeImpl(new ReflectionInterfaceDeclaration((Class)type, typeSolver), typeSolver));
			}
		}
		return arrayList;
	}

	
	
	
	private bool isFunctionalInterface()
	{
		bool result = FunctionalInterfaceLogic.getFunctionalMethod(typeDeclaration).isPresent();
		
		return result;
	}

	
	
	
	private ResolvedType lambda_0024getSuperClass_00240(Type P_0)
	{
		ResolvedType result = ReflectionFactory.typeUsageFor(P_0, typeSolver);
		
		return result;
	}

	
	
	
	private ResolvedType lambda_0024getInterfaces_00241(Type P_0)
	{
		ResolvedType result = ReflectionFactory.typeUsageFor(P_0, typeSolver);
		
		return result;
	}

	
	
	
	private static void lambda_0024getAllFields_00242(ArrayList P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		P_0.addAll(P_1.getAllFields());
	}

	
	
	
	private static bool lambda_0024getDeclaredMethods_00243(Method P_0)
	{
		return (!P_0.isSynthetic() && !P_0.isBridge()) ? true : false;
	}

	
	
	
	private ReflectionMethodDeclaration lambda_0024getDeclaredMethods_00244(Method P_0)
	{
		ReflectionMethodDeclaration result = new ReflectionMethodDeclaration(P_0, typeSolver);
		
		return result;
	}

	
	
	
	private static bool lambda_0024getConstructors_00245(Constructor P_0)
	{
		return (!P_0.isSynthetic()) ? true : false;
	}

	
	
	
	private ReflectionConstructorDeclaration lambda_0024getConstructors_00246(Constructor P_0)
	{
		ReflectionConstructorDeclaration result = new ReflectionConstructorDeclaration(P_0, typeSolver);
		
		return result;
	}

	
	
	public virtual ResolvedFieldDeclaration getField(string P_0)
	{
		Field[] declaredFields = clazz.getDeclaredFields(ReflectionClassAdapter.___003CGetCallerID_003E());
		int num = declaredFields.Length;
		for (int i = 0; i < num; i++)
		{
			Field field = declaredFields[i];
			if (String.instancehelper_equals(field.getName(), P_0))
			{
				ReflectionFieldDeclaration result = new ReflectionFieldDeclaration(field, typeSolver);
				
				return result;
			}
		}
		Iterator iterator = typeDeclaration.getAllAncestors().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			if (resolvedReferenceType.getTypeDeclaration().isPresent())
			{
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)resolvedReferenceType.getTypeDeclaration().get();
				if (resolvedReferenceTypeDeclaration.hasField(P_0))
				{
					ReflectionFieldDeclaration reflectionFieldDeclaration = (ReflectionFieldDeclaration)resolvedReferenceTypeDeclaration.getField(P_0);
					ResolvedFieldDeclaration result2 = reflectionFieldDeclaration.replaceType((ResolvedType)resolvedReferenceType.getFieldType(P_0).get());
					
					return result2;
				}
			}
		}
		string context = new StringBuilder().append("Field in ").append(this).ToString();
		
		throw new UnsolvedSymbolException(P_0, context);
	}

	
	
	public virtual bool hasField(string P_0)
	{
		Field[] declaredFields = clazz.getDeclaredFields(ReflectionClassAdapter.___003CGetCallerID_003E());
		int num = declaredFields.Length;
		for (int i = 0; i < num; i++)
		{
			Field field = declaredFields[i];
			if (String.instancehelper_equals(field.getName(), P_0))
			{
				return true;
			}
		}
		Iterator iterator = typeDeclaration.getAllAncestors().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			if (resolvedReferenceType.getTypeDeclaration().isPresent() && ((ResolvedReferenceTypeDeclaration)resolvedReferenceType.getTypeDeclaration().get()).hasField(P_0))
			{
				return true;
			}
		}
		return false;
	}

	
		
	public virtual Set getDeclaredMethods()
	{
		return (Set)Arrays.stream(clazz.getDeclaredMethods(ReflectionClassAdapter.___003CGetCallerID_003E())).filter(new ___003C_003EAnon4()).map(new ___003C_003EAnon5(this))
			.collect(Collectors.toSet());
	}

	
		
	public virtual List getTypeParameters()
	{
		ArrayList arrayList = new ArrayList();
		TypeVariable[] typeParameters = clazz.getTypeParameters();
		int num = typeParameters.Length;
		for (int i = 0; i < num; i++)
		{
			TypeVariable typeVariable = typeParameters[i];
			((List)arrayList).add((object)new ReflectionTypeParameter(typeVariable, declaredOnClass: true, typeSolver));
		}
		return arrayList;
	}

	
	
	public virtual bool isAssignableBy(ResolvedType P_0)
	{
		if (P_0 is NullType)
		{
			return true;
		}
		if (P_0 is LambdaArgumentTypePlaceholder)
		{
			bool result = isFunctionalInterface();
			
			return result;
		}
		if (P_0.isArray())
		{
			return false;
		}
		if (P_0.isPrimitive())
		{
			return false;
		}
		if (String.instancehelper_equals(P_0.describe(), typeDeclaration.getQualifiedName()))
		{
			return true;
		}
		if (P_0 is ReferenceTypeImpl)
		{
			ReferenceTypeImpl referenceTypeImpl = (ReferenceTypeImpl)P_0;
			if (referenceTypeImpl.getTypeDeclaration().isPresent())
			{
				bool result2 = ((ResolvedReferenceTypeDeclaration)referenceTypeImpl.getTypeDeclaration().get()).canBeAssignedTo(typeDeclaration);
				
				return result2;
			}
		}
		return false;
	}

	
		
	public virtual List getConstructors()
	{
		return (List)Arrays.stream(clazz.getDeclaredConstructors(ReflectionClassAdapter.___003CGetCallerID_003E())).filter(new ___003C_003EAnon6()).map(new ___003C_003EAnon7(this))
			.collect(Collectors.toList());
	}

	
		
	public virtual Optional containerType()
	{
		Class declaringClass = clazz.getDeclaringClass(ReflectionClassAdapter.___003CGetCallerID_003E());
		Optional result = ((declaringClass != null) ? Optional.of(ReflectionFactory.typeDeclarationFor(declaringClass, typeSolver)) : Optional.empty());
		
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
