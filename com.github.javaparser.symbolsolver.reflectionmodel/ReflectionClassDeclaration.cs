using System;

using com.github.javaparser.ast;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.javaparsermodel.contexts;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.reflectionmodel.comparators;
using com.github.javaparser.symbolsolver.resolution;

using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionClassDeclaration : AbstractClassDeclaration, MethodUsageResolutionCapability
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly bool arg_00241;

		internal ___003C_003EAnon0(bool P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveMethod_00240(arg_00241, (Method)P_0);
			
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

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon2(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveMethod_00241(arg_00241, (Method)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		internal ___003C_003EAnon3()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveMethod_00242((Method)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		internal ___003C_003EAnon4()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveMethod_00243((Method)P_0);
			
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
		internal ___003C_003EAnon5()
		{
		}

		public object apply(object P_0)
		{
			Optional typeDeclaration = ((ResolvedReferenceType)P_0).getTypeDeclaration();
			
			return typeDeclaration;
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

	
	private sealed class ___003C_003EAnon6 : Consumer
	{
		private readonly string arg_00241;

		private readonly List arg_00242;

		private readonly bool arg_00243;

		private readonly List arg_00244;

		internal ___003C_003EAnon6(string P_0, List P_1, bool P_2, List P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public void accept(object P_0)
		{
			lambda_0024solveMethod_00244(arg_00241, arg_00242, arg_00243, arg_00244, (ResolvedReferenceTypeDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : Consumer
	{
		private readonly string arg_00241;

		private readonly List arg_00242;

		private readonly bool arg_00243;

		private readonly List arg_00244;

		internal ___003C_003EAnon7(string P_0, List P_1, bool P_2, List P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public void accept(object P_0)
		{
			lambda_0024solveMethod_00245(arg_00241, arg_00242, arg_00243, arg_00244, (ResolvedReferenceTypeDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon8 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon8(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveMethodAsUsage_00246(arg_00241, (Method)P_0);
			
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

	
	private sealed class ___003C_003EAnon9 : Consumer
	{
		private readonly string arg_00241;

		private readonly List arg_00242;

		private readonly Context arg_00243;

		private readonly List arg_00244;

		private readonly List arg_00245;

		internal ___003C_003EAnon9(string P_0, List P_1, Context P_2, List P_3, List P_4)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
			arg_00245 = P_4;
		}

		public void accept(object P_0)
		{
			lambda_0024solveMethodAsUsage_00248(arg_00241, arg_00242, arg_00243, arg_00244, arg_00245, (ResolvedReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon10 : Function
	{
		private readonly ResolvedReferenceType arg_00241;

		internal ___003C_003EAnon10(ResolvedReferenceType P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Optional result = lambda_0024solveMethodAsUsage_00249(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon11 : Function
	{
		private readonly string arg_00241;

		private readonly List arg_00242;

		private readonly Context arg_00243;

		private readonly List arg_00244;

		internal ___003C_003EAnon11(string P_0, List P_1, Context P_2, List P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public object apply(object P_0)
		{
			Optional result = lambda_0024solveMethodAsUsage_002410(arg_00241, arg_00242, arg_00243, arg_00244, (ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon12 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon12(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.add((MethodUsage)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon13 : Function
	{
		private readonly ReflectionClassDeclaration arg_00241;

		internal ___003C_003EAnon13(ReflectionClassDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedReferenceTypeDeclaration result = arg_00241.lambda_0024internalTypes_002411((Class)P_0);
			
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

	
	private sealed class ___003C_003EAnon14 : Consumer
	{
		private readonly string arg_00241;

		private readonly List arg_00242;

		private readonly Context arg_00243;

		private readonly List arg_00244;

		private readonly List arg_00245;

		internal ___003C_003EAnon14(string P_0, List P_1, Context P_2, List P_3, List P_4)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
			arg_00245 = P_4;
		}

		public void accept(object P_0)
		{
			lambda_0024null_00247(arg_00241, arg_00242, arg_00243, arg_00244, arg_00245, (ResolvedReferenceTypeDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

		private Class clazz;

	private TypeSolver typeSolver;

	private ReflectionClassAdapter reflectionClassAdapter;

	
	private static CallerID ___003CcallerID_003E;

	
		
	public ReflectionClassDeclaration(Class clazz, TypeSolver typeSolver)
	{
		if (clazz == null)
		{
			
			throw new IllegalArgumentException("Class should not be null");
		}
		if (clazz.isInterface())
		{
			
			throw new IllegalArgumentException("Class should not be an interface");
		}
		if (clazz.isPrimitive())
		{
			
			throw new IllegalArgumentException("Class should not represent a primitive class");
		}
		if (clazz.isArray())
		{
			
			throw new IllegalArgumentException("Class should not be an array");
		}
		if (clazz.isEnum())
		{
			
			throw new IllegalArgumentException("Class should not be an enum");
		}
		this.clazz = clazz;
		this.typeSolver = typeSolver;
		reflectionClassAdapter = new ReflectionClassAdapter(clazz, typeSolver, this);
	}

	
	
	public override string getPackageName()
	{
		if (clazz.getPackage() != null)
		{
			string name = clazz.getPackage().getName();
			
			return name;
		}
		return null;
	}

	
		
	public override Optional getSuperClass()
	{
		if (!reflectionClassAdapter.getSuperClass().isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Optional result2 = Optional.of(reflectionClassAdapter.getSuperClass().get());
		
		return result2;
	}

	
		
	public override List getInterfaces()
	{
		List interfaces = reflectionClassAdapter.getInterfaces();
		
		return interfaces;
	}

	
		
	public override List getTypeParameters()
	{
		List typeParameters = reflectionClassAdapter.getTypeParameters();
		
		return typeParameters;
	}

	
	
	public override string getQualifiedName()
	{
		string canonicalName = clazz.getCanonicalName();
		
		return canonicalName;
	}

	
	
	public override bool canBeAssignedTo(ResolvedReferenceTypeDeclaration other)
	{
		if (other is LambdaArgumentTypePlaceholder)
		{
			bool result = isFunctionalInterface();
			
			return result;
		}
		if (java.lang.String.instancehelper_equals(other.getQualifiedName(), getQualifiedName()))
		{
			return true;
		}
		if (clazz.getSuperclass() != null && new ReflectionClassDeclaration(clazz.getSuperclass(), typeSolver).canBeAssignedTo(other))
		{
			return true;
		}
		Class[] interfaces = clazz.getInterfaces();
		int num = interfaces.Length;
		for (int i = 0; i < num; i++)
		{
			Class @class = interfaces[i];
			if (new ReflectionInterfaceDeclaration(@class, typeSolver).canBeAssignedTo(other))
			{
				return true;
			}
		}
		return false;
	}

	
	
	public override bool isAssignableBy(ResolvedType type)
	{
		bool result = reflectionClassAdapter.isAssignableBy(type);
		
		return result;
	}

	
	
	
	private static bool lambda_0024solveMethod_00240(bool P_0, Method P_1)
	{
		return (!P_0 || (P_0 && java.lang.reflect.Modifier.isStatic(P_1.getModifiers()))) ? true : false;
	}

	
	
	
	private static bool lambda_0024solveMethod_00241(string P_0, Method P_1)
	{
		bool result = java.lang.String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024solveMethod_00242(Method P_0)
	{
		return (!P_0.isBridge()) ? true : false;
	}

	
	
	
	private static bool lambda_0024solveMethod_00243(Method P_0)
	{
		return (!P_0.isSynthetic()) ? true : false;
	}

	
	
	
	private static void lambda_0024solveMethod_00244(string P_0, List P_1, bool P_2, List P_3, ResolvedReferenceTypeDeclaration P_4)
	{
		SymbolReference symbolReference = MethodResolutionLogic.solveMethodInType(P_4, P_0, P_1, P_2);
		if (symbolReference.isSolved())
		{
			P_3.add(symbolReference.getCorrespondingDeclaration());
		}
	}

	
	
	
	private static void lambda_0024solveMethod_00245(string P_0, List P_1, bool P_2, List P_3, ResolvedReferenceTypeDeclaration P_4)
	{
		SymbolReference symbolReference = MethodResolutionLogic.solveMethodInType(P_4, P_0, P_1, P_2);
		if (symbolReference.isSolved())
		{
			P_3.add(symbolReference.getCorrespondingDeclaration());
		}
	}

	
	
	
	private static bool lambda_0024solveMethodAsUsage_00246(string P_0, Method P_1)
	{
		bool result = java.lang.String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static void lambda_0024solveMethodAsUsage_00248(string P_0, List P_1, Context P_2, List P_3, List P_4, ResolvedReferenceType P_5)
	{
		P_5.getTypeDeclaration().ifPresent(new ___003C_003EAnon14(P_0, P_1, P_2, P_3, P_4));
	}

	
	
	
	private static Optional lambda_0024solveMethodAsUsage_00249(ResolvedReferenceType P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		Optional typeDeclaration = P_0.getTypeDeclaration();
		
		return typeDeclaration;
	}

	
	
	
	private static Optional lambda_0024solveMethodAsUsage_002410(string P_0, List P_1, Context P_2, List P_3, ResolvedReferenceTypeDeclaration P_4)
	{
		Optional result = ContextHelper.solveMethodAsUsage(P_4, P_0, P_1, P_2, P_3);
		
		return result;
	}

	
	
	
	private ResolvedReferenceTypeDeclaration lambda_0024internalTypes_002411(Class P_0)
	{
		ResolvedReferenceTypeDeclaration result = ReflectionFactory.typeDeclarationFor(P_0, typeSolver);
		
		return result;
	}

	
	
	
	private unsafe static void lambda_0024null_00247(string P_0, List P_1, Context P_2, List P_3, List P_4, ResolvedReferenceTypeDeclaration P_5)
	{
		Optional optional = ContextHelper.solveMethodAsUsage(P_5, P_0, P_1, P_2, P_3);
		
		optional.ifPresent(new ___003C_003EAnon12(P_4));
	}

	
		
	public override Set getDeclaredMethods()
	{
		Set declaredMethods = reflectionClassAdapter.getDeclaredMethods();
		
		return declaredMethods;
	}

	
		
	public override List getAncestors(bool acceptIncompleteList)
	{
		List ancestors = reflectionClassAdapter.getAncestors();
		
		return ancestors;
	}

	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || ((object)this).GetType() != o.GetType())
		{
			return false;
		}
		ReflectionClassDeclaration reflectionClassDeclaration = (ReflectionClassDeclaration)o;
		if (!java.lang.String.instancehelper_equals(clazz.getCanonicalName(), reflectionClassDeclaration.clazz.getCanonicalName()))
		{
			return false;
		}
		return true;
	}

	
	
	public override int GetHashCode()
	{
		int result = java.lang.Object.instancehelper_hashCode(clazz);
		
		return result;
	}

	
	
	public override string getClassName()
	{
		string canonicalName = clazz.getCanonicalName();
		if (canonicalName != null && getPackageName() != null)
		{
			string result = java.lang.String.instancehelper_substring(canonicalName, java.lang.String.instancehelper_length(getPackageName()) + 1, java.lang.String.instancehelper_length(canonicalName));
			
			return result;
		}
		return null;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		Predicate predicate = new ___003C_003EAnon0(staticOnly);
		ArrayList arrayList = new ArrayList();
		List list = (List)Arrays.stream(clazz.getDeclaredMethods(ReflectionClassDeclaration.___003CGetCallerID_003E())).filter(new ___003C_003EAnon2(name)).filter(predicate)
			.filter(new ___003C_003EAnon3())
			.filter(new ___003C_003EAnon4())
			.sorted(new MethodComparator())
			.collect(Collectors.toList());
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			Method method = (Method)iterator.next();
			ReflectionMethodDeclaration reflectionMethodDeclaration = new ReflectionMethodDeclaration(method, typeSolver);
			((List)arrayList).add((object)reflectionMethodDeclaration);
			if (argumentsTypes.isEmpty() && ((ResolvedMethodLikeDeclaration)reflectionMethodDeclaration).getNumberOfParams() == 0)
			{
				SymbolReference result = SymbolReference.solved(reflectionMethodDeclaration);
				
				return result;
			}
		}
		getSuperClass().flatMap(new ___003C_003EAnon5()).ifPresent(new ___003C_003EAnon6(name, argumentsTypes, staticOnly, arrayList));
		iterator = getInterfaces().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			resolvedReferenceType.getTypeDeclaration().ifPresent(new ___003C_003EAnon7(name, argumentsTypes, staticOnly, arrayList));
		}
		if (((List)arrayList).isEmpty())
		{
			SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedMethodDeclaration>.Value);
			
			return result2;
		}
		SymbolReference result3 = MethodResolutionLogic.findMostApplicable(arrayList, name, argumentsTypes, typeSolver);
		
		return result3;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("ReflectionClassDeclaration{clazz=").append(getId()).append('}')
			.ToString();
		
		return result;
	}

	
	
	public virtual ResolvedType getUsage(Node node)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(this, typeSolver);
		
		return result;
	}

	
		
	public unsafe virtual Optional solveMethodAsUsage(string name, List argumentsTypes, Context invokationContext, List typeParameterValues)
	{
		ArrayList arrayList = new ArrayList();
		List list = (List)Arrays.stream(clazz.getDeclaredMethods(ReflectionClassDeclaration.___003CGetCallerID_003E())).filter(new ___003C_003EAnon8(name)).sorted(new MethodComparator())
			.collect(Collectors.toList());
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			Method method = (Method)iterator.next();
			if (!method.isBridge() && !method.isSynthetic())
			{
				ReflectionMethodDeclaration declaration = new ReflectionMethodDeclaration(method, typeSolver);
				MethodUsage methodUsage = new MethodUsage(declaration);
				for (int i = 0; i < getTypeParameters().size() && i < typeParameterValues.size(); i++)
				{
					ResolvedTypeParameterDeclaration typeParameter = (ResolvedTypeParameterDeclaration)getTypeParameters().get(i);
					ResolvedType type = (ResolvedType)typeParameterValues.get(i);
					methodUsage = methodUsage.replaceTypeParameter(typeParameter, type);
				}
				((List)arrayList).add((object)methodUsage);
				if (argumentsTypes.isEmpty() && methodUsage.getNoParams() == 0)
				{
					Optional result = Optional.of(methodUsage);
					
					return result;
				}
			}
		}
		getSuperClass().ifPresent(new ___003C_003EAnon9(name, argumentsTypes, invokationContext, typeParameterValues, arrayList));
		iterator = getInterfaces().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			Optional optional = resolvedReferenceType.getTypeDeclaration().flatMap(new ___003C_003EAnon10(resolvedReferenceType)).flatMap(new ___003C_003EAnon11(name, argumentsTypes, invokationContext, typeParameterValues));
			
			optional.ifPresent(new ___003C_003EAnon12(arrayList));
		}
		return MethodResolutionLogic.findMostApplicableUsage(arrayList, name, argumentsTypes, typeSolver);
	}

	public override bool isTypeParameter()
	{
		return false;
	}

	
	
	public override ResolvedFieldDeclaration getField(string name)
	{
		ResolvedFieldDeclaration field = reflectionClassAdapter.getField(name);
		
		return field;
	}

	
		
	public override List getAllFields()
	{
		List allFields = reflectionClassAdapter.getAllFields();
		
		return allFields;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual SymbolReference solveSymbol(string name, TypeSolver typeSolver)
	{
		Field[] fields = clazz.getFields(ReflectionClassDeclaration.___003CGetCallerID_003E());
		int num = fields.Length;
		for (int i = 0; i < num; i++)
		{
			Field field = fields[i];
			if (java.lang.String.instancehelper_equals(field.getName(), name))
			{
				SymbolReference result = SymbolReference.solved(new ReflectionFieldDeclaration(field, typeSolver));
				
				return result;
			}
		}
		SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
		
		return result2;
	}

	
	
	public override bool hasDirectlyAnnotation(string canonicalName)
	{
		bool result = reflectionClassAdapter.hasDirectlyAnnotation(canonicalName);
		
		return result;
	}

	
	
	public override bool hasField(string name)
	{
		bool result = reflectionClassAdapter.hasField(name);
		
		return result;
	}

	
	
	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		bool result = isAssignableBy(new ReferenceTypeImpl(other, typeSolver));
		
		return result;
	}

	
	
	public override string getName()
	{
		string simpleName = clazz.getSimpleName();
		
		return simpleName;
	}

	public override bool isField()
	{
		return false;
	}

	public override bool isParameter()
	{
		return false;
	}

	public override bool isType()
	{
		return true;
	}

	
	
	public override bool isClass()
	{
		return (!clazz.isInterface()) ? true : false;
	}

	
	
	public override bool isInterface()
	{
		bool result = clazz.isInterface();
		
		return result;
	}

	
	
	public override AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = ReflectionFactory.modifiersToAccessLevel(clazz.getModifiers());
		
		return result;
	}

	
		
	public override List getConstructors()
	{
		List constructors = reflectionClassAdapter.getConstructors();
		
		return constructors;
	}

	
		
	public override Optional containerType()
	{
		Optional result = reflectionClassAdapter.containerType();
		
		return result;
	}

	
		
	public override Set internalTypes()
	{
		return (Set)Arrays.stream(clazz.getDeclaredClasses(ReflectionClassDeclaration.___003CGetCallerID_003E())).map(new ___003C_003EAnon13(this)).collect(Collectors.toSet());
	}

	
		
	public override Optional toAst()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
	
	protected internal override ResolvedReferenceType @object()
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeSolver.getSolvedJavaLangObject(), typeSolver);
		
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
