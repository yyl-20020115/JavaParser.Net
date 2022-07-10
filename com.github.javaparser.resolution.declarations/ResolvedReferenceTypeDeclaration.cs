using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedReferenceTypeDeclaration : ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable
{
	private static class ___003C_003EPIM
	{
		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024getField_00244(string name, ResolvedFieldDeclaration f)
		{
			bool result = String.instancehelper_equals(f.getName(), name);
			
			return result;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024getVisibleField_00245(string name, ResolvedFieldDeclaration f)
		{
			bool result = String.instancehelper_equals(f.getName(), name);
			
			return result;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024hasField_00246(string name, ResolvedFieldDeclaration f)
		{
			bool result = String.instancehelper_equals(f.getName(), name);
			
			return result;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024hasVisibleField_00247(string name, ResolvedFieldDeclaration f)
		{
			bool result = String.instancehelper_equals(f.getName(), name);
			
			return result;
		}

		
		
		[NameSig("lambda$getVisibleFields$8", "(Lcom.github.javaparser.resolution.declarations.ResolvedFieldDeclaration;)Z")]
		
		
		
		internal unsafe static bool _003Cpiim_003Elambda_0024getVisibleFields_00248(ResolvedReferenceTypeDeclaration f, ResolvedFieldDeclaration P_1)
		{
			
			return (Object.instancehelper_equals(P_1.declaringType(), f) || P_1.accessSpecifier() != AccessSpecifier.___003C_003EPRIVATE) ? true : false;
		}

		
		
		
		
		internal static bool lambda_0024getAllNonStaticFields_00249(ResolvedFieldDeclaration it)
		{
			return (!it.isStatic()) ? true : false;
		}

		
		
		
		
		internal static bool lambda_0024getAllStaticFields_002410(ResolvedFieldDeclaration it)
		{
			bool result = it.isStatic();
			
			return result;
		}

		
		
		[NameSig("lambda$getDeclaredFields$11", "(Lcom.github.javaparser.resolution.declarations.ResolvedFieldDeclaration;)Z")]
		
		
		
		internal unsafe static bool _003Cpiim_003Elambda_0024getDeclaredFields_002411(ResolvedReferenceTypeDeclaration it, ResolvedFieldDeclaration P_1)
		{
			
			bool result = String.instancehelper_equals(P_1.declaringType().getQualifiedName(), it.getQualifiedName());
			
			return result;
		}

		
		
		
		
		internal static bool lambda_0024hasAnnotation_002412(ResolvedReferenceType it)
		{
			bool result = it.asReferenceType().getTypeDeclaration().isPresent();
			
			return result;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024hasAnnotation_002413(string qualifiedName, ResolvedReferenceType it)
		{
			bool result = ((ResolvedReferenceTypeDeclaration)it.asReferenceType().getTypeDeclaration().get()).hasDirectlyAnnotation(qualifiedName);
			
			return result;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static void lambda_0024null_00242(ResolvedReferenceType queuedAncestor, Deque queuedAncestors, Set ancestors, ResolvedReferenceTypeDeclaration rtd)
		{
			LinkedHashSet.___003Cclinit_003E();
			new LinkedHashSet(queuedAncestor.getDirectAncestors()).stream().forEach(new ___003C_003EAnon12(queuedAncestors, ancestors));
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static void lambda_0024null_00241(Deque queuedAncestors, Set ancestors, ResolvedReferenceType ancestor)
		{
			queuedAncestors.add(ancestor);
			ancestors.add(ancestor);
		}

		
		
		
		[LineNumberTable(new byte[]
		{
			73, 134, 107, 127, 1, 104, 127, 2, 106, 137,
			98, 133
		})]
		internal static List lambda_0024static_00240(ResolvedReferenceTypeDeclaration rrtd)
		{
			ArrayList arrayList = new ArrayList();
			if (!rrtd.isJavaLangObject())
			{
				Iterator iterator = rrtd.getAncestors().iterator();
				while (iterator.hasNext())
				{
					ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
					((List)arrayList).add((object)resolvedReferenceType);
					Iterator iterator2 = resolvedReferenceType.getAllAncestors().iterator();
					while (iterator2.hasNext())
					{
						ResolvedReferenceType resolvedReferenceType2 = (ResolvedReferenceType)iterator2.next();
						if (!((List)arrayList).contains((object)resolvedReferenceType2))
						{
							((List)arrayList).add((object)resolvedReferenceType2);
						}
					}
				}
			}
			return arrayList;
		}

		
		
		
		[LineNumberTable(new byte[]
		{
			93, 134, 136, 108, 104, 104, 108, 115, 229, 71,
			130
		})]
		internal static List lambda_0024static_00243(ResolvedReferenceTypeDeclaration rrtd)
		{
			HashSet hashSet = new HashSet();
			if (!rrtd.isJavaLangObject())
			{
				LinkedList linkedList = new LinkedList(rrtd.getAncestors());
				((Set)hashSet).addAll((Collection)linkedList);
				while (!((Collection)linkedList).isEmpty())
				{
					ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)((Deque)linkedList).removeFirst();
					resolvedReferenceType.getTypeDeclaration().ifPresent(new ___003C_003EAnon11(resolvedReferenceType, linkedList, hashSet));
				}
			}
			ArrayList result = new ArrayList(hashSet);
			
			return result;
		}
	}

	
	public new static class __DefaultMethods
	{
		public unsafe static ResolvedReferenceTypeDeclaration asReferenceType(ResolvedReferenceTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EasReferenceType(P_0);
		}

		public unsafe static List getAncestors(ResolvedReferenceTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetAncestors(P_0);
		}

		public unsafe static List getAllAncestors(ResolvedReferenceTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetAllAncestors(P_0);
		}

		public unsafe static List getAllAncestors(ResolvedReferenceTypeDeclaration P_0, Function P_1)
		{
			
			return _003Cdefault_003EgetAllAncestors(P_0, P_1);
		}

		public unsafe static ResolvedFieldDeclaration getField(ResolvedReferenceTypeDeclaration P_0, string P_1)
		{
			
			return _003Cdefault_003EgetField(P_0, P_1);
		}

		public unsafe static ResolvedFieldDeclaration getVisibleField(ResolvedReferenceTypeDeclaration P_0, string P_1)
		{
			
			return _003Cdefault_003EgetVisibleField(P_0, P_1);
		}

		public unsafe static bool hasField(ResolvedReferenceTypeDeclaration P_0, string P_1)
		{
			
			return _003Cdefault_003EhasField(P_0, P_1);
		}

		public unsafe static bool hasVisibleField(ResolvedReferenceTypeDeclaration P_0, string P_1)
		{
			
			return _003Cdefault_003EhasVisibleField(P_0, P_1);
		}

		public unsafe static List getVisibleFields(ResolvedReferenceTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetVisibleFields(P_0);
		}

		public unsafe static List getAllNonStaticFields(ResolvedReferenceTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetAllNonStaticFields(P_0);
		}

		public unsafe static List getAllStaticFields(ResolvedReferenceTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetAllStaticFields(P_0);
		}

		public unsafe static List getDeclaredFields(ResolvedReferenceTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetDeclaredFields(P_0);
		}

		public unsafe static bool canBeAssignedTo(ResolvedReferenceTypeDeclaration P_0, ResolvedReferenceTypeDeclaration P_1)
		{
			
			return _003Cdefault_003EcanBeAssignedTo(P_0, P_1);
		}

		public unsafe static bool hasAnnotation(ResolvedReferenceTypeDeclaration P_0, string P_1)
		{
			
			return _003Cdefault_003EhasAnnotation(P_0, P_1);
		}

		public unsafe static Optional findTypeParameter(ResolvedReferenceTypeDeclaration P_0, string P_1)
		{
			
			return _003Cdefault_003EfindTypeParameter(P_0, P_1);
		}

		public unsafe static bool isJavaLangObject(ResolvedReferenceTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EisJavaLangObject(P_0);
		}

		public unsafe static bool isJavaLangEnum(ResolvedReferenceTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EisJavaLangEnum(P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getField_00244(arg_00241, (ResolvedFieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon2(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getVisibleField_00245(arg_00241, (ResolvedFieldDeclaration)P_0);
			
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
		private readonly string arg_00241;

		internal ___003C_003EAnon3(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024hasField_00246(arg_00241, (ResolvedFieldDeclaration)P_0);
			
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
		private readonly string arg_00241;

		internal ___003C_003EAnon4(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024hasVisibleField_00247(arg_00241, (ResolvedFieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Predicate
	{
		private readonly ResolvedReferenceTypeDeclaration arg_00241;

		internal ___003C_003EAnon5(ResolvedReferenceTypeDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM._003Cpiim_003Elambda_0024getVisibleFields_00248(arg_00241, (ResolvedFieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Predicate
	{
		internal ___003C_003EAnon6()
		{
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getAllNonStaticFields_00249((ResolvedFieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon7 : Predicate
	{
		internal ___003C_003EAnon7()
		{
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getAllStaticFields_002410((ResolvedFieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon8 : Predicate
	{
		private readonly ResolvedReferenceTypeDeclaration arg_00241;

		internal ___003C_003EAnon8(ResolvedReferenceTypeDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM._003Cpiim_003Elambda_0024getDeclaredFields_002411(arg_00241, (ResolvedFieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon9 : Predicate
	{
		internal ___003C_003EAnon9()
		{
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024hasAnnotation_002412((ResolvedReferenceType)P_0);
			
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

	
	private sealed class ___003C_003EAnon10 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon10(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024hasAnnotation_002413(arg_00241, (ResolvedReferenceType)P_0);
			
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

	
	private sealed class ___003C_003EAnon11 : Consumer
	{
		private readonly ResolvedReferenceType arg_00241;

		private readonly Deque arg_00242;

		private readonly Set arg_00243;

		internal ___003C_003EAnon11(ResolvedReferenceType P_0, Deque P_1, Set P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			___003C_003EPIM.lambda_0024null_00242(arg_00241, arg_00242, arg_00243, (ResolvedReferenceTypeDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon12 : Consumer
	{
		private readonly Deque arg_00241;

		private readonly Set arg_00242;

		internal ___003C_003EAnon12(Deque P_0, Set P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			___003C_003EPIM.lambda_0024null_00241(arg_00241, arg_00242, (ResolvedReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon13 : Function
	{
		internal ___003C_003EAnon13()
		{
		}

		public object apply(object P_0)
		{
			List result = ___003C_003EPIM.lambda_0024static_00240((ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon14 : Function
	{
		internal ___003C_003EAnon14()
		{
		}

		public object apply(object P_0)
		{
			List result = ___003C_003EPIM.lambda_0024static_00243((ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	public static class __Fields
	{
		public static readonly string JAVA_LANG_ENUM;

		public static readonly string JAVA_LANG_OBJECT;

		public static readonly Function depthFirstFunc;

		public static readonly Function breadthFirstFunc;

		static __Fields()
		{
			JAVA_LANG_ENUM = ResolvedReferenceTypeDeclaration.JAVA_LANG_ENUM;
			JAVA_LANG_OBJECT = ResolvedReferenceTypeDeclaration.JAVA_LANG_OBJECT;
			depthFirstFunc = ResolvedReferenceTypeDeclaration.depthFirstFunc;
			breadthFirstFunc = ResolvedReferenceTypeDeclaration.breadthFirstFunc;
		}
	}

	static readonly string JAVA_LANG_ENUM;

	static readonly string JAVA_LANG_OBJECT;

		static readonly Function depthFirstFunc;

		static readonly Function breadthFirstFunc;

	
	
	static void ___003Cclinit_003E()
	{
	}

		
	virtual List getAncestors(bool acceptIncompleteList);

	
		
	virtual List getAllAncestors(Function traverser);

	
	
	
	static List _003Cdefault_003EgetAllAncestors(ResolvedReferenceTypeDeclaration P_0, Function P_1)
	{
		return (List)P_1.apply(P_0);
	}

		virtual List getAllFields();

	
		virtual List getVisibleFields();

	
	
	
	static List _003Cdefault_003EgetVisibleFields(ResolvedReferenceTypeDeclaration P_0)
	{
		return (List)P_0.getAllFields().stream().filter(new ___003C_003EAnon5(P_0))
			.collect(Collectors.toList());
	}

	
	virtual bool isAssignableBy(ResolvedReferenceTypeDeclaration other);

	
	virtual bool hasDirectlyAnnotation(string qualifiedName);

	
		virtual List getAllAncestors();

	
	
	
	static List _003Cdefault_003EgetAllAncestors(ResolvedReferenceTypeDeclaration P_0)
	{
		List allAncestors = P_0.getAllAncestors(depthFirstFunc);
		
		return allAncestors;
	}

	
		
	Optional findTypeParameter(string name);

	
	
	
	static Optional _003Cdefault_003EfindTypeParameter(ResolvedReferenceTypeDeclaration P_0, string P_1)
	{
		Iterator iterator = P_0.getTypeParameters().iterator();
		while (iterator.hasNext())
		{
			ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = (ResolvedTypeParameterDeclaration)iterator.next();
			if (String.instancehelper_equals(resolvedTypeParameterDeclaration.getName(), P_1))
			{
				Optional result = Optional.of(resolvedTypeParameterDeclaration);
				
				return result;
			}
		}
		if (P_0.containerType().isPresent())
		{
			Optional result2 = ((ResolvedReferenceTypeDeclaration)P_0.containerType().get()).findTypeParameter(P_1);
			
			return result2;
		}
		Optional result3 = Optional.empty();
		
		return result3;
	}

	
	virtual bool isJavaLangObject();

	
	
	
	static bool _003Cdefault_003EisJavaLangObject(ResolvedReferenceTypeDeclaration P_0)
	{
		return (P_0.isClass() && !P_0.isAnonymousClass() && P_0.hasName() && String.instancehelper_equals(P_0.getQualifiedName(), JAVA_LANG_OBJECT)) ? true : false;
	}

	
		virtual List getAncestors();

	
	
	
	static List _003Cdefault_003EgetAncestors(ResolvedReferenceTypeDeclaration P_0)
	{
		List ancestors = P_0.getAncestors(acceptIncompleteList: false);
		
		return ancestors;
	}

	
	ResolvedReferenceTypeDeclaration asReferenceType();

	
	static ResolvedReferenceTypeDeclaration _003Cdefault_003EasReferenceType(ResolvedReferenceTypeDeclaration P_0)
	{
		return P_0;
	}

	
	
	virtual ResolvedFieldDeclaration getField(string name);

	
	
	
	static ResolvedFieldDeclaration _003Cdefault_003EgetField(ResolvedReferenceTypeDeclaration P_0, string P_1)
	{
		Optional optional = P_0.getAllFields().stream().filter(new ___003C_003EAnon1(P_1))
			.findFirst();
		if (optional.isPresent())
		{
			return (ResolvedFieldDeclaration)optional.get();
		}
		string name = new StringBuilder().append("Field not found: ").append(P_1).ToString();
		
		throw new UnsolvedSymbolException(name);
	}

	
	
	virtual ResolvedFieldDeclaration getVisibleField(string name);

	
	
	
	static ResolvedFieldDeclaration _003Cdefault_003EgetVisibleField(ResolvedReferenceTypeDeclaration P_0, string P_1)
	{
		Optional optional = P_0.getVisibleFields().stream().filter(new ___003C_003EAnon2(P_1))
			.findFirst();
		if (optional.isPresent())
		{
			return (ResolvedFieldDeclaration)optional.get();
		}
		
		throw new IllegalArgumentException();
	}

	
	
	virtual bool hasField(string name);

	
	
	
	static bool _003Cdefault_003EhasField(ResolvedReferenceTypeDeclaration P_0, string P_1)
	{
		bool result = P_0.getAllFields().stream().anyMatch(new ___003C_003EAnon3(P_1));
		
		return result;
	}

	
	
	virtual bool hasVisibleField(string name);

	
	
	
	static bool _003Cdefault_003EhasVisibleField(ResolvedReferenceTypeDeclaration P_0, string P_1)
	{
		bool result = P_0.getVisibleFields().stream().anyMatch(new ___003C_003EAnon4(P_1));
		
		return result;
	}

	
		virtual List getAllNonStaticFields();

	
	
	
	static List _003Cdefault_003EgetAllNonStaticFields(ResolvedReferenceTypeDeclaration P_0)
	{
		return (List)P_0.getAllFields().stream().filter(new ___003C_003EAnon6())
			.collect(Collectors.toList());
	}

	
		virtual List getAllStaticFields();

	
	
	
	static List _003Cdefault_003EgetAllStaticFields(ResolvedReferenceTypeDeclaration P_0)
	{
		return (List)P_0.getAllFields().stream().filter(new ___003C_003EAnon7())
			.collect(Collectors.toList());
	}

	
		virtual List getDeclaredFields();

	
	
	
	static List _003Cdefault_003EgetDeclaredFields(ResolvedReferenceTypeDeclaration P_0)
	{
		return (List)P_0.getAllFields().stream().filter(new ___003C_003EAnon8(P_0))
			.collect(Collectors.toList());
	}

		virtual Set getDeclaredMethods();

		virtual Set getAllMethods();

	
	virtual bool isAssignableBy(ResolvedType type);

	
	
	virtual bool canBeAssignedTo(ResolvedReferenceTypeDeclaration other);

	
	
	
	static bool _003Cdefault_003EcanBeAssignedTo(ResolvedReferenceTypeDeclaration P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		bool result = P_1.isAssignableBy(P_0);
		
		return result;
	}

	
	
	virtual bool hasAnnotation(string qualifiedName);

	
	
	
	static bool _003Cdefault_003EhasAnnotation(ResolvedReferenceTypeDeclaration P_0, string P_1)
	{
		if (P_0.hasDirectlyAnnotation(P_1))
		{
			return true;
		}
		bool result = P_0.getAllAncestors().stream().filter(new ___003C_003EAnon9())
			.anyMatch(new ___003C_003EAnon10(P_1));
		
		return result;
	}

	virtual bool isFunctionalInterface();

		virtual List getConstructors();

	
	virtual bool isJavaLangEnum();

	
	
	
	static bool _003Cdefault_003EisJavaLangEnum(ResolvedReferenceTypeDeclaration P_0)
	{
		return (P_0.isEnum() && String.instancehelper_equals(P_0.getQualifiedName(), JAVA_LANG_ENUM)) ? true : false;
	}

	
	static ResolvedReferenceTypeDeclaration()
	{
		JAVA_LANG_ENUM = ClassLiteral<Enum>.Value.getCanonicalName();
		JAVA_LANG_OBJECT = ClassLiteral<Object>.Value.getCanonicalName();
		depthFirstFunc = new ___003C_003EAnon13();
		breadthFirstFunc = new ___003C_003EAnon14();
	}
}
