
using com.github.javaparser.ast;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types.parametrization;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.resolution.types;


public abstract class ResolvedReferenceType: ResolvedType, ResolvedTypeParametrized, ResolvedTypeParameterValueProvider
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly ResolvedReferenceType arg_00241;

		internal ___003C_003EAnon0(ResolvedReferenceType P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			string result = arg_00241.lambda_0024describe_00240((ResolvedTypeParameterDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getAllInterfacesAncestors_00241((ResolvedReferenceType)P_0);
			
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
		internal ___003C_003EAnon2()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getAllInterfacesAncestors_00242((ResolvedReferenceType)P_0);
			
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
			bool result = lambda_0024getAllClassesAncestors_00243((ResolvedReferenceType)P_0);
			
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
			bool result = lambda_0024getAllClassesAncestors_00244((ResolvedReferenceType)P_0);
			
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
		private readonly ResolvedReferenceType arg_00241;

		internal ___003C_003EAnon5(ResolvedReferenceType P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedType result = arg_00241.lambda_0024typeParametersValues_00245((ResolvedTypeParameterDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon6(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024getAllMethods_00246(arg_00241, (ResolvedReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : Predicate
	{
		internal ___003C_003EAnon7()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getAllFieldsVisibleToInheritors_00247((ResolvedFieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon8 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon8(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024getAllFieldsVisibleToInheritors_00248(arg_00241, (ResolvedReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon9 : Predicate
	{
		internal ___003C_003EAnon9()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getAllMethodsVisibleToInheritors_00249((ResolvedMethodDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon10 : Function
	{
		private readonly ResolvedTypeParametersMap arg_00241;

		internal ___003C_003EAnon10(ResolvedTypeParametersMap P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedType value = arg_00241.getValue((ResolvedTypeParameterDeclaration)P_0);
			
			return value;
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
		internal ___003C_003EAnon11()
		{
		}

		public object apply(object P_0)
		{
			ResolvedType type = ((ResolvedTypeParameterDeclaration.Bound)P_0).getType();
			
			return type;
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

	
	private sealed class ___003C_003EAnon12 : Function
	{
		internal ___003C_003EAnon12()
		{
		}

		public object apply(object P_0)
		{
			ResolvedTypeVariable result = new ResolvedTypeVariable((ResolvedTypeParameterDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon13 : Predicate
	{
		private readonly ResolvedReferenceType arg_00241;

		internal ___003C_003EAnon13(ResolvedReferenceType P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = arg_00241.lambda_0024isUnboxable_002410((ResolvedPrimitiveType)P_0);
			
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

	
	private sealed class ___003C_003EAnon14 : Predicate
	{
		private readonly ResolvedReferenceType arg_00241;

		internal ___003C_003EAnon14(ResolvedReferenceType P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = arg_00241.lambda_0024toUnboxedType_002411((ResolvedPrimitiveType)P_0);
			
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

	
	private sealed class ___003C_003EAnon15 : Predicate
	{
		internal ___003C_003EAnon15()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024erasureOfParamaters_002412((ResolvedType)P_0);
			
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

	
	private sealed class ___003C_003EAnon16 : Function
	{
		internal ___003C_003EAnon16()
		{
		}

		public object apply(object P_0)
		{
			ResolvedType result = lambda_0024erasureOfParamaters_002413((ResolvedType)P_0);
			
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

	
	private sealed class ___003C_003EAnon17 : Predicate
	{
		private readonly ResolvedReferenceType arg_00241;

		internal ___003C_003EAnon17(ResolvedReferenceType P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = arg_00241.lambda_0024erasureOfParamaters_002414((ResolvedType)P_0);
			
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

	protected internal static string JAVA_LANG_ENUM;

	protected internal static string JAVA_LANG_OBJECT;

	protected internal ResolvedReferenceTypeDeclaration typeDeclaration;

	protected internal ResolvedTypeParametersMap typeParametersMap;

	
	
	protected internal static void ___003Cclinit_003E()
	{
	}

	
	
	public virtual string getQualifiedName()
	{
		string qualifiedName = typeDeclaration.getQualifiedName();
		
		return qualifiedName;
	}

	public virtual ResolvedReferenceType asReferenceType()
	{
		return this;
	}

	
		
	public Optional getTypeDeclaration()
	{
		Optional result = Optional.of(typeDeclaration);
		
		return result;
	}

		public abstract List getDirectAncestors();

		public abstract List getAllAncestors();

	
		
	public List getAllInterfacesAncestors()
	{
		return (List)getAllAncestors().stream().filter(new ___003C_003EAnon1()).filter(new ___003C_003EAnon2())
			.collect(Collectors.toList());
	}

	
	public abstract ResolvedType transformTypeParameters(ResolvedTypeTransformer transformer);

	
	
	public virtual bool isUnboxable()
	{
		bool result = Arrays.stream(ResolvedPrimitiveType.values()).anyMatch(new ___003C_003EAnon13(this));
		
		return result;
	}

	
		
	public virtual Optional toUnboxedType()
	{
		Optional result = Arrays.stream(ResolvedPrimitiveType.values()).filter(new ___003C_003EAnon14(this)).findFirst();
		
		return result;
	}

	
		
	
	private static List deriveParams(ResolvedReferenceTypeDeclaration typeDeclaration)
	{
		if (typeDeclaration == null)
		{
			
			throw new IllegalArgumentException("TypeDeclaration is not expected to be null");
		}
		List typeParameters = typeDeclaration.getTypeParameters();
		if (typeParameters == null)
		{
			
			throw new RuntimeException("Type parameters are not expected to be null");
		}
		return (List)typeParameters.stream().map(new ___003C_003EAnon12()).collect(Collectors.toList());
	}

	
		
	
	public ResolvedReferenceType(ResolvedReferenceTypeDeclaration typeDeclaration, List typeArguments)
	{
		if (typeDeclaration == null)
		{
			
			throw new IllegalArgumentException("TypeDeclaration is not expected to be null");
		}
		if (typeDeclaration.isTypeParameter())
		{
			
			throw new IllegalArgumentException("You should use only Classes, Interfaces and enums");
		}
		if (typeArguments.size() > 0 && typeArguments.size() != typeDeclaration.getTypeParameters().size())
		{
			string s = String.format("expected either zero type arguments or has many as defined in the declaration (%d). Found %d", Integer.valueOf(typeDeclaration.getTypeParameters().size()), Integer.valueOf(typeArguments.size()));
			
			throw new IllegalArgumentException(s);
		}
		ResolvedTypeParametersMap.Builder builder = new ResolvedTypeParametersMap.Builder();
		for (int i = 0; i < typeArguments.size(); i++)
		{
			builder.setValue((ResolvedTypeParameterDeclaration)typeDeclaration.getTypeParameters().get(i), (ResolvedType)typeArguments.get(i));
		}
		this.typeParametersMap = builder.build();
		this.typeDeclaration = typeDeclaration;
	}

	
	
	public virtual bool hasName()
	{
		bool result = typeDeclaration.hasName();
		
		return result;
	}

	public virtual ResolvedTypeParametersMap typeParametersMap()
	{
		return this.typeParametersMap;
	}

	
		
	public virtual List typeParametersValues()
	{
		return (!this.typeParametersMap.isEmpty()) ? ((List)typeDeclaration.getTypeParameters().stream().map(new ___003C_003EAnon5(this))
			.collect(Collectors.toList())) : Collections.emptyList();
	}

		
	protected internal abstract ResolvedReferenceType create(ResolvedReferenceTypeDeclaration typeDeclaration, List typeParameters);

	
	
	public virtual bool isRawType()
	{
		if (!typeDeclaration.getTypeParameters().isEmpty())
		{
			if (typeParametersMap().isEmpty())
			{
				return true;
			}
			Iterator iterator = typeParametersMap().getNames().iterator();
			while (iterator.hasNext())
			{
				string text = (string)iterator.next();
				Optional valueBySignature = typeParametersMap().getValueBySignature(text);
				if (!valueBySignature.isPresent() || !((ResolvedType)valueBySignature.get()).isTypeVariable() || !String.instancehelper_equals(((ResolvedType)valueBySignature.get()).asTypeVariable().qualifiedName(), text))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedType useThisTypeParametersOnTheGivenType(ResolvedType P_0)
	{
		return ResolvedTypeParameterValueProvider._003Cdefault_003EuseThisTypeParametersOnTheGivenType(this, P_0);
	}

	
	
	public virtual string getId()
	{
		string id = typeDeclaration.getId();
		
		return id;
	}

		public abstract Set getDeclaredFields();

	
		
	public virtual List getAllMethods()
	{
		if (!getTypeDeclaration().isPresent())
		{
			ArrayList result = new ArrayList();
			
			return result;
		}
		LinkedList linkedList = new LinkedList(((ResolvedReferenceTypeDeclaration)getTypeDeclaration().get()).getDeclaredMethods());
		getDirectAncestors().forEach(new ___003C_003EAnon6(linkedList));
		return linkedList;
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
		ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)o;
		if (!Object.instancehelper_equals(typeDeclaration, resolvedReferenceType.typeDeclaration))
		{
			return false;
		}
		if (!this.typeParametersMap.equals(resolvedReferenceType.typeParametersMap))
		{
			return false;
		}
		return true;
	}

	
	
	
	private bool compareConsideringVariableTypeParameters(ResolvedType referenceType, ResolvedTypeVariable typeVariable)
	{
		List bounds = typeVariable.asTypeVariable().asTypeParameter().getBounds();
		if (bounds.size() == 1)
		{
			ResolvedType type = ((ResolvedTypeParameterDeclaration.Bound)bounds.get(0)).getType();
			bool result = (((!type.isReferenceType() || type.asReferenceType().typeParametersMap.isEmpty()) && 0 == 0) ? type.isAssignableBy(referenceType) : compareConsideringTypeParameters(type.asReferenceType()));
			
			return result;
		}
		return false;
	}

	
	
	
	protected internal virtual bool compareConsideringTypeParameters(ResolvedReferenceType other)
	{
		if (other.equals(this))
		{
			return true;
		}
		if (String.instancehelper_equals(getQualifiedName(), other.getQualifiedName()))
		{
			if (isRawType() || other.isRawType())
			{
				return true;
			}
			List list = typeParametersValues();
			if (list.size() != other.typeParametersValues().size())
			{
				
				throw new IllegalStateException();
			}
			for (int i = 0; i < list.size(); i++)
			{
				ResolvedType resolvedType = (ResolvedType)list.get(i);
				ResolvedType resolvedType2 = (ResolvedType)other.typeParametersValues().get(i);
				if (Object.instancehelper_equals(resolvedType, resolvedType2))
				{
					continue;
				}
				if (resolvedType is ResolvedWildcard)
				{
					ResolvedWildcard resolvedWildcard = (ResolvedWildcard)resolvedType;
					if ((!resolvedWildcard.isSuper() || !resolvedType2.isAssignableBy(resolvedWildcard.getBoundedType())) && (!resolvedWildcard.isExtends() || !resolvedWildcard.getBoundedType().isAssignableBy(resolvedType2)) && resolvedWildcard.isBounded())
					{
						return false;
					}
					continue;
				}
				if (resolvedType is ResolvedTypeVariable && resolvedType2 is ResolvedTypeVariable)
				{
					List list2 = (List)resolvedType.asTypeVariable().asTypeParameter().getBounds()
						.stream()
						.map(new ___003C_003EAnon11())
						.collect(Collectors.toList());
					List list3 = (List)resolvedType2.asTypeVariable().asTypeParameter().getBounds()
						.stream()
						.map(new ___003C_003EAnon11())
						.collect(Collectors.toList());
					return (list2.size() == list3.size() && list3.containsAll(list2)) ? true : false;
				}
				if (!(resolvedType is ResolvedTypeVariable) && resolvedType2 is ResolvedTypeVariable)
				{
					bool result = compareConsideringVariableTypeParameters(resolvedType, (ResolvedTypeVariable)resolvedType2);
					
					return result;
				}
				if (resolvedType is ResolvedTypeVariable && !(resolvedType2 is ResolvedTypeVariable))
				{
					bool result2 = compareConsideringVariableTypeParameters(resolvedType2, (ResolvedTypeVariable)resolvedType);
					
					return result2;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public bool isReferenceType()
	{
		return true;
	}

	
	
	public virtual string describe()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (hasName())
		{
			stringBuilder.append(typeDeclaration.getQualifiedName());
		}
		else
		{
			stringBuilder.append("<anonymous class>");
		}
		if (!typeParametersMap().isEmpty())
		{
			stringBuilder.append("<");
			Iterable elements = (Iterable)typeDeclaration.getTypeParameters().stream().map(new ___003C_003EAnon0(this))
				.collect(Collectors.toList());
			CharSequence delimiter = default(CharSequence);
			object obj = (delimiter.___003Cref_003E = ", ");
			stringBuilder.append(String.join(delimiter, elements));
			stringBuilder.append(">");
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
		
	
	private List erasureOfParamaters(ResolvedTypeParametersMap typeParametersMap)
	{
		ArrayList arrayList = new ArrayList();
		if (!typeParametersMap.isEmpty())
		{
			((List)arrayList).addAll((Collection)typeParametersMap.getTypes().stream().filter(new ___003C_003EAnon15())
				.map(new ___003C_003EAnon16())
				.filter(new ___003C_003EAnon17(this))
				.collect(Collectors.toList()));
		}
		return arrayList;
	}

	
	
	public virtual bool isJavaLangObject()
	{
		return (isReferenceType() && hasName() && String.instancehelper_equals(getQualifiedName(), JAVA_LANG_OBJECT)) ? true : false;
	}

	
	
	
	private bool isJavaObject(ResolvedType rt)
	{
		return (rt.isReferenceType() && rt.asReferenceType().isJavaLangObject()) ? true : false;
	}

	
		
	public virtual List getAllFieldsVisibleToInheritors()
	{
		LinkedList linkedList = new LinkedList((Collection)getDeclaredFields().stream().filter(new ___003C_003EAnon7()).collect(Collectors.toList()));
		getDirectAncestors().forEach(new ___003C_003EAnon8(linkedList));
		return linkedList;
	}

	
	
	
	
	private string lambda_0024describe_00240(ResolvedTypeParameterDeclaration tp)
	{
		string result = typeParametersMap().getValue(tp).describe();
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024getAllInterfacesAncestors_00241(ResolvedReferenceType it)
	{
		bool result = it.getTypeDeclaration().isPresent();
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024getAllInterfacesAncestors_00242(ResolvedReferenceType it)
	{
		bool result = ((ResolvedReferenceTypeDeclaration)it.getTypeDeclaration().get()).isInterface();
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024getAllClassesAncestors_00243(ResolvedReferenceType it)
	{
		bool result = it.getTypeDeclaration().isPresent();
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024getAllClassesAncestors_00244(ResolvedReferenceType it)
	{
		bool result = ((ResolvedReferenceTypeDeclaration)it.getTypeDeclaration().get()).isClass();
		
		return result;
	}

	
	
	
	
	private ResolvedType lambda_0024typeParametersValues_00245(ResolvedTypeParameterDeclaration tp)
	{
		ResolvedType value = this.typeParametersMap.getValue(tp);
		
		return value;
	}

	
	
	
	
	private static void lambda_0024getAllMethods_00246(List allMethods, ResolvedReferenceType a)
	{
		allMethods.addAll(a.getAllMethods());
	}

	
	
	
	
	private static bool lambda_0024getAllFieldsVisibleToInheritors_00247(ResolvedFieldDeclaration f)
	{
		return f.accessSpecifier() != AccessSpecifier.___003C_003EPRIVATE;
	}

	
	
	
	
	private static void lambda_0024getAllFieldsVisibleToInheritors_00248(List res, ResolvedReferenceType a)
	{
		res.addAll(a.getAllFieldsVisibleToInheritors());
	}

	
	
	
	
	private static bool lambda_0024getAllMethodsVisibleToInheritors_00249(ResolvedMethodDeclaration m)
	{
		return m.accessSpecifier() != AccessSpecifier.___003C_003EPRIVATE;
	}

	
	
	
	
	private bool lambda_0024isUnboxable_002410(ResolvedPrimitiveType pt)
	{
		bool result = String.instancehelper_equals(getQualifiedName(), pt.getBoxTypeQName());
		
		return result;
	}

	
	
	
	
	private bool lambda_0024toUnboxedType_002411(ResolvedPrimitiveType pt)
	{
		bool result = String.instancehelper_equals(asReferenceType().getQualifiedName(), pt.getBoxTypeQName());
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024erasureOfParamaters_002412(ResolvedType type)
	{
		return (!type.isReferenceType()) ? true : false;
	}

	
	
	
	
	private static ResolvedType lambda_0024erasureOfParamaters_002413(ResolvedType type)
	{
		ResolvedType result = type.erasure();
		
		return result;
	}

	
	
	
	
	private bool lambda_0024erasureOfParamaters_002414(ResolvedType erasedType)
	{
		return (!isJavaObject(erasedType)) ? true : false;
	}

	
	
	
	public ResolvedReferenceType(ResolvedReferenceTypeDeclaration typeDeclaration)
		: this(typeDeclaration, deriveParams(typeDeclaration))
	{
	}

	
	
	public override int GetHashCode()
	{
		int num = Object.instancehelper_hashCode(typeDeclaration);
		return 31 * num + this.typeParametersMap.GetHashCode();
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("ReferenceType{").append(getQualifiedName()).append(", typeParametersMap=")
			.append(this.typeParametersMap)
			.append('}')
			.ToString();
		
		return result;
	}

	
		
	
	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration tpToReplace, ResolvedType replaced, Map inferredTypes)
	{
		if (replaced == null)
		{
			
			throw new IllegalArgumentException();
		}
		ResolvedReferenceType resolvedReferenceType = this;
		int num = 0;
		Iterator iterator = typeParametersValues().iterator();
		while (iterator.hasNext())
		{
			ResolvedType resolvedType = (ResolvedType)iterator.next();
			ResolvedType element = resolvedType.replaceTypeVariables(tpToReplace, replaced, inferredTypes);
			if (resolvedType.isTypeVariable() && String.instancehelper_equals(resolvedType.asTypeVariable().describe(), tpToReplace.getName()))
			{
				inferredTypes.put(resolvedType.asTypeParameter(), replaced);
			}
			List list = resolvedReferenceType.asReferenceType().typeParametersValues();
			list.set(num, element);
			resolvedReferenceType = create(typeDeclaration, list);
			num++;
		}
		List list2 = resolvedReferenceType.typeParametersValues();
		if (list2.contains(tpToReplace))
		{
			int index = list2.indexOf(tpToReplace);
			list2.set(index, replaced);
			if (resolvedReferenceType.getTypeDeclaration().isPresent())
			{
				ResolvedReferenceType result = create((ResolvedReferenceTypeDeclaration)resolvedReferenceType.getTypeDeclaration().get(), list2);
				
				return result;
			}
		}
		return resolvedReferenceType;
	}

	
	public abstract bool isAssignableBy(ResolvedType other);

	
		
	public List getAllClassesAncestors()
	{
		return (List)getAllAncestors().stream().filter(new ___003C_003EAnon3()).filter(new ___003C_003EAnon4())
			.collect(Collectors.toList());
	}

	
		
	
	public virtual Optional getGenericParameterByName(string name)
	{
		Iterator iterator = typeDeclaration.getTypeParameters().iterator();
		while (iterator.hasNext())
		{
			ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = (ResolvedTypeParameterDeclaration)iterator.next();
			if (String.instancehelper_equals(resolvedTypeParameterDeclaration.getName(), name))
			{
				Optional result = Optional.of(typeParametersMap().getValue(resolvedTypeParameterDeclaration));
				
				return result;
			}
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
		
	public virtual List getTypeParametersMap()
	{
		ArrayList arrayList = new ArrayList();
		if (!isRawType())
		{
			for (int i = 0; i < typeDeclaration.getTypeParameters().size(); i++)
			{
				((List)arrayList).add((object)new Pair(typeDeclaration.getTypeParameters().get(i), typeParametersValues().get(i)));
			}
		}
		return arrayList;
	}

	
		
	
	public virtual Optional getFieldType(string name)
	{
		if (!typeDeclaration.hasField(name))
		{
			Optional result = Optional.empty();
			
			return result;
		}
		ResolvedType type = typeDeclaration.getField(name).getType();
		type = useThisTypeParametersOnTheGivenType(type);
		Optional result2 = Optional.of(type);
		
		return result2;
	}

		public abstract Set getDeclaredMethods();

	
		
	
	public virtual Optional typeParamValue(ResolvedTypeParameterDeclaration typeParameterDeclaration)
	{
		if (typeParameterDeclaration.declaredOnMethod())
		{
			
			throw new IllegalArgumentException();
		}
		if (!getTypeDeclaration().isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		string id = ((ResolvedReferenceTypeDeclaration)getTypeDeclaration().get()).getId();
		if (String.instancehelper_equals(id, typeParameterDeclaration.getContainerId()))
		{
			Optional result2 = Optional.of(typeParametersMap().getValue(typeParameterDeclaration));
			
			return result2;
		}
		Iterator iterator = getAllAncestors().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			if (String.instancehelper_equals(resolvedReferenceType.getId(), typeParameterDeclaration.getContainerId()))
			{
				Optional result3 = Optional.of(resolvedReferenceType.typeParametersMap().getValue(typeParameterDeclaration));
				
				return result3;
			}
		}
		Optional result4 = Optional.empty();
		
		return result4;
	}

	public abstract ResolvedType toRawType();

	
		
	public virtual List getAllMethodsVisibleToInheritors()
	{
		return (List)getAllMethods().stream().filter(new ___003C_003EAnon9()).collect(Collectors.toList());
	}

	
	
	
	protected internal unsafe virtual ResolvedReferenceType create(ResolvedReferenceTypeDeclaration typeDeclaration, ResolvedTypeParametersMap typeParametersMap)
	{
		Stream stream = typeDeclaration.getTypeParameters().stream();
		
		ResolvedReferenceType result = create(typeDeclaration, (List)stream.map(new ___003C_003EAnon10(typeParametersMap)).collect(Collectors.toList()));
		
		return result;
	}

	
	protected internal abstract ResolvedReferenceType create(ResolvedReferenceTypeDeclaration typeDeclaration);

	
	
	
	protected internal virtual bool isCorrespondingBoxingType(string typeName)
	{
		ResolvedPrimitiveType resolvedPrimitiveType = (ResolvedPrimitiveType)ResolvedPrimitiveType.byName(typeName);
		bool result = String.instancehelper_equals(getQualifiedName(), resolvedPrimitiveType.getBoxTypeQName());
		
		return result;
	}

	
	public abstract ResolvedReferenceType deriveTypeParameters(ResolvedTypeParametersMap typeParametersMap);

	
	
	public virtual bool isJavaLangEnum()
	{
		return (isReferenceType() && hasName() && String.instancehelper_equals(getQualifiedName(), JAVA_LANG_ENUM)) ? true : false;
	}

	
	
	
	public virtual bool isUnboxableTo(ResolvedPrimitiveType primitiveType)
	{
		bool result = String.instancehelper_equals(primitiveType.getBoxTypeQName(), asReferenceType().describe());
		
		return result;
	}

	
	
	public virtual ResolvedType erasure()
	{
		if (!typeDeclaration.isGeneric())
		{
			return this;
		}
		ResolvedReferenceType result = create(typeDeclaration, erasureOfParamaters(this.typeParametersMap));
		
		return result;
	}

	
	static ResolvedReferenceType()
	{
		JAVA_LANG_ENUM = ClassLiteral<Enum>.Value.getCanonicalName();
		JAVA_LANG_OBJECT = ClassLiteral<Object>.Value.getCanonicalName();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isArray()
	{
		return ResolvedType._003Cdefault_003EisArray(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual int arrayLevel()
	{
		return ResolvedType._003Cdefault_003EarrayLevel(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isPrimitive()
	{
		return ResolvedType._003Cdefault_003EisPrimitive(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isNull()
	{
		return ResolvedType._003Cdefault_003EisNull(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isUnionType()
	{
		return ResolvedType._003Cdefault_003EisUnionType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isReference()
	{
		return ResolvedType._003Cdefault_003EisReference(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isConstraint()
	{
		return ResolvedType._003Cdefault_003EisConstraint(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isVoid()
	{
		return ResolvedType._003Cdefault_003EisVoid(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isTypeVariable()
	{
		return ResolvedType._003Cdefault_003EisTypeVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isWildcard()
	{
		return ResolvedType._003Cdefault_003EisWildcard(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isInferenceVariable()
	{
		return ResolvedType._003Cdefault_003EisInferenceVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedArrayType asArrayType()
	{
		return ResolvedType._003Cdefault_003EasArrayType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedTypeParameterDeclaration asTypeParameter()
	{
		return ResolvedType._003Cdefault_003EasTypeParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedTypeVariable asTypeVariable()
	{
		return ResolvedType._003Cdefault_003EasTypeVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedPrimitiveType asPrimitive()
	{
		return ResolvedType._003Cdefault_003EasPrimitive(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedWildcard asWildcard()
	{
		return ResolvedType._003Cdefault_003EasWildcard(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedLambdaConstraintType asConstraintType()
	{
		return ResolvedType._003Cdefault_003EasConstraintType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedUnionType asUnionType()
	{
		return ResolvedType._003Cdefault_003EasUnionType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration P_0, ResolvedType P_1)
	{
		return ResolvedType._003Cdefault_003EreplaceTypeVariables(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool mention(List P_0)
	{
		return ResolvedType._003Cdefault_003Emention(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isNumericType()
	{
		return ResolvedType._003Cdefault_003EisNumericType(this);
	}
}
