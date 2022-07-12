
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.resolution.types.parametrization;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.model.typesystem;

public class ReferenceTypeImpl : ResolvedReferenceType
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly ReferenceTypeImpl arg_00241;

		internal ___003C_003EAnon1(ReferenceTypeImpl P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Boolean result = arg_00241.lambda_0024isAssignableBy_00240((ResolvedReferenceType)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly Set arg_00241;

		internal ___003C_003EAnon2(Set P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024getDeclaredMethods_00241(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon3(List P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024mention_00242(arg_00241, (ResolvedType)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Function
	{
		private readonly ReferenceTypeImpl arg_00241;

		internal ___003C_003EAnon4(ReferenceTypeImpl P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedReferenceType result = arg_00241.lambda_0024getAllAncestors_00243((ResolvedReferenceType)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Predicate
	{
		internal ___003C_003EAnon5()
		{
		}

		public bool test(object P_0)
		{
			bool result = ((ResolvedReferenceType)P_0).isJavaLangObject();
			
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

	
	private sealed class ___003C_003EAnon6 : Function
	{
		private readonly ReferenceTypeImpl arg_00241;

		internal ___003C_003EAnon6(ReferenceTypeImpl P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedReferenceType result = arg_00241.lambda_0024getDirectAncestors_00244((ResolvedReferenceType)P_0);
			
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

	private TypeSolver typeSolver;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	public ReferenceTypeImpl(ResolvedReferenceTypeDeclaration typeDeclaration, TypeSolver typeSolver)
		: base(typeDeclaration)
	{
		this.typeSolver = typeSolver;
	}

	
		
	public ReferenceTypeImpl(ResolvedReferenceTypeDeclaration typeDeclaration, List typeArguments, TypeSolver typeSolver)
		: base(typeDeclaration, typeArguments)
	{
		this.typeSolver = typeSolver;
	}

	
	
	public static ResolvedReferenceType undeterminedParameters(ResolvedReferenceTypeDeclaration typeDeclaration, TypeSolver typeSolver)
	{
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeDeclaration, (List)typeDeclaration.getTypeParameters().stream().map(new ___003C_003EAnon0())
			.collect(Collectors.toList()), typeSolver);
		
		return result;
	}

	
		
	public override List getAllAncestors()
	{
		List allAncestors = typeDeclaration.getAllAncestors();
		allAncestors = (List)allAncestors.stream().map(new ___003C_003EAnon4(this)).collect(Collectors.toList());
		allAncestors.removeIf(new ___003C_003EAnon5());
		ResolvedReferenceTypeDeclaration solvedJavaLangObject = typeSolver.getSolvedJavaLangObject();
		allAncestors.add(create(solvedJavaLangObject));
		return allAncestors;
	}

	
	
	public override bool isAssignableBy(ResolvedType other)
	{
		if (other is NullType)
		{
			return (!isPrimitive()) ? true : false;
		}
		if (!other.isVoid() && isJavaLangObject())
		{
			return true;
		}
		if (other.isPrimitive())
		{
			if (isJavaLangObject())
			{
				return true;
			}
			if (isCorrespondingBoxingType(other.describe()))
			{
				return true;
			}
			SymbolReference symbolReference = typeSolver.tryToSolveType(other.asPrimitive().getBoxTypeQName());
			bool result = ((ResolvedReferenceTypeDeclaration)symbolReference.getCorrespondingDeclaration()).canBeAssignedTo(typeDeclaration);
			
			return result;
		}
		if (other is LambdaArgumentTypePlaceholder)
		{
			bool result2 = FunctionalInterfaceLogic.isFunctionalInterfaceType(this);
			
			return result2;
		}
		if (other is ReferenceTypeImpl)
		{
			ReferenceTypeImpl referenceTypeImpl = (ReferenceTypeImpl)other;
			if (compareConsideringTypeParameters(referenceTypeImpl))
			{
				return true;
			}
			Iterator iterator = referenceTypeImpl.getAllAncestors().iterator();
			while (iterator.hasNext())
			{
				ResolvedReferenceType other2 = (ResolvedReferenceType)iterator.next();
				if (compareConsideringTypeParameters(other2))
				{
					return true;
				}
			}
			return false;
		}
		if (other.isTypeVariable())
		{
			Iterator iterator2 = other.asTypeVariable().asTypeParameter().getBounds()
				.iterator();
			while (iterator2.hasNext())
			{
				ResolvedTypeParameterDeclaration.Bound bound = (ResolvedTypeParameterDeclaration.Bound)iterator2.next();
				if (bound.isExtends() && isAssignableBy(bound.getType()))
				{
					return true;
				}
			}
			return false;
		}
		if (other.isConstraint())
		{
			bool result3 = isAssignableBy(other.asConstraintType().getBound());
			
			return result3;
		}
		if (other.isWildcard())
		{
			if (isJavaLangObject())
			{
				return true;
			}
			if (other.asWildcard().isExtends())
			{
				bool result4 = isAssignableBy(other.asWildcard().getBoundedType());
				
				return result4;
			}
			return false;
		}
		if (other.isUnionType())
		{
			bool result5 = ((Boolean)other.asUnionType().getCommonAncestor().map(new ___003C_003EAnon1(this))
				.orElse(Boolean.valueOf(b: false))).booleanValue();
			
			return result5;
		}
		return false;
	}

	
		
	protected internal override ResolvedReferenceType create(ResolvedReferenceTypeDeclaration typeDeclaration, List typeParametersCorrected)
	{
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeDeclaration, typeParametersCorrected, typeSolver);
		
		return result;
	}

	
	
	protected internal override ResolvedReferenceType create(ResolvedReferenceTypeDeclaration typeDeclaration)
	{
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeDeclaration, typeSolver);
		
		return result;
	}

	
	
	
	private Boolean lambda_0024isAssignableBy_00240(ResolvedReferenceType P_0)
	{
		Boolean result = Boolean.valueOf(isAssignableBy(P_0));
		
		return result;
	}

	
	
	
	private static void lambda_0024getDeclaredMethods_00241(Set P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		Iterator iterator = P_1.getDeclaredMethods().iterator();
		while (iterator.hasNext())
		{
			ResolvedMethodDeclaration declaration = (ResolvedMethodDeclaration)iterator.next();
			MethodUsage e = new MethodUsage(declaration);
			P_0.add(e);
		}
	}

	
	
	
	private static bool lambda_0024mention_00242(List P_0, ResolvedType P_1)
	{
		bool result = P_1.mention(P_0);
		
		return result;
	}

	
	
	
	private ResolvedReferenceType lambda_0024getAllAncestors_00243(ResolvedReferenceType P_0)
	{
		ResolvedReferenceType result = typeParametersMap().replaceAll(P_0).asReferenceType();
		
		return result;
	}

	
	
	
	private ResolvedReferenceType lambda_0024getDirectAncestors_00244(ResolvedReferenceType P_0)
	{
		ResolvedReferenceType result = typeParametersMap().replaceAll(P_0).asReferenceType();
		
		return result;
	}

	
	
	public override ResolvedTypeParameterDeclaration asTypeParameter()
	{
		if (typeDeclaration is JavaParserTypeVariableDeclaration)
		{
			JavaParserTypeVariableDeclaration javaParserTypeVariableDeclaration = (JavaParserTypeVariableDeclaration)typeDeclaration;
			ResolvedTypeParameterDeclaration result = javaParserTypeVariableDeclaration.asTypeParameter();
			
			return result;
		}
		string canonicalName = Object.instancehelper_getClass(typeDeclaration).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
		
	public override Set getDeclaredMethods()
	{
		HashSet hashSet = new HashSet();
		getTypeDeclaration().ifPresent(new ___003C_003EAnon2(hashSet));
		return hashSet;
	}

	
	
	public override ResolvedType toRawType()
	{
		if (isRawType())
		{
			return this;
		}
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeDeclaration, typeSolver);
		
		return result;
	}

	
		
	public override bool mention(List typeParameters)
	{
		bool result = typeParametersValues().stream().anyMatch(new ___003C_003EAnon3(typeParameters));
		
		return result;
	}

	
	
	public override ResolvedType transformTypeParameters(ResolvedTypeTransformer transformer)
	{
		ResolvedReferenceType resolvedReferenceType = this;
		int num = 0;
		Iterator iterator = typeParametersValues().iterator();
		while (iterator.hasNext())
		{
			ResolvedType resolvedType = (ResolvedType)iterator.next();
			ResolvedType resolvedType2 = transformer.transform(resolvedType);
			if (resolvedType2 != resolvedType)
			{
				List list = ((ResolvedType)resolvedReferenceType).asReferenceType().typeParametersValues();
				list.set(num, resolvedType2);
				resolvedReferenceType = create(typeDeclaration, list);
			}
			num++;
		}
		return resolvedReferenceType;
	}

	
		
	public override List getDirectAncestors()
	{
		List ancestors = typeDeclaration.getAncestors();
		ancestors = (List)ancestors.stream().map(new ___003C_003EAnon6(this)).collect(Collectors.toList());
		ancestors.removeIf(new ___003C_003EAnon5());
		if (getTypeDeclaration().isPresent())
		{
			ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)getTypeDeclaration().get();
			if (resolvedReferenceTypeDeclaration.isClass())
			{
				Optional superClass = resolvedReferenceTypeDeclaration.asClass().getSuperClass();
				int num = ((superClass.isPresent() && ((ResolvedReferenceType)superClass.get()).isJavaLangObject()) ? 1 : 0);
				int num2 = (resolvedReferenceTypeDeclaration.asClass().isJavaLangObject() ? 1 : 0);
				if (num != 0 && num2 == 0)
				{
					ancestors.add(create(typeSolver.getSolvedJavaLangObject()));
				}
			}
			else
			{
				ancestors.add(create(typeSolver.getSolvedJavaLangObject()));
			}
		}
		return ancestors;
	}

	
	
	public override ResolvedReferenceType deriveTypeParameters(ResolvedTypeParametersMap typeParametersMap)
	{
		ResolvedReferenceType result = create(typeDeclaration, typeParametersMap);
		
		return result;
	}

	
		
	public override Set getDeclaredFields()
	{
		LinkedHashSet linkedHashSet = new LinkedHashSet();
		if (getTypeDeclaration().isPresent())
		{
			((Set)linkedHashSet).addAll((Collection)((ResolvedReferenceTypeDeclaration)getTypeDeclaration().get()).getDeclaredFields());
		}
		return linkedHashSet;
	}

	
	static ReferenceTypeImpl()
	{
		ResolvedReferenceType.___003Cclinit_003E();
	}
}
