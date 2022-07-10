using System.Runtime.CompilerServices;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javassist;
using javassist.bytecode;

namespace com.github.javaparser.symbolsolver.javassistmodel;

public class JavassistTypeDeclarationAdapter
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon0(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024getAncestors_00240(arg_00241, (ResolvedReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getDeclaredMethods_00241((CtMethod)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		private readonly JavassistTypeDeclarationAdapter arg_00241;

		internal ___003C_003EAnon2(JavassistTypeDeclarationAdapter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavassistMethodDeclaration result = arg_00241.lambda_0024getDeclaredMethods_00242((CtMethod)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		internal ___003C_003EAnon3()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getConstructors_00243((CtConstructor)P_0);
			
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
		private readonly JavassistTypeDeclarationAdapter arg_00241;

		internal ___003C_003EAnon4(JavassistTypeDeclarationAdapter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavassistConstructorDeclaration result = arg_00241.lambda_0024getConstructors_00244((CtConstructor)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon5(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024getDeclaredFields_00245(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Function
	{
		private readonly JavassistTypeDeclarationAdapter arg_00241;

		internal ___003C_003EAnon6(JavassistTypeDeclarationAdapter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavassistTypeParameter result = arg_00241.lambda_0024getTypeParameters_00246((javassist.bytecode.SignatureAttribute.TypeParameter)P_0);
			
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

	
	private sealed class ___003C_003EAnon7 : Function
	{
		private readonly JavassistTypeDeclarationAdapter arg_00241;

		internal ___003C_003EAnon7(JavassistTypeDeclarationAdapter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedReferenceTypeDeclaration result = arg_00241.lambda_0024internalTypes_00247((CtClass)P_0);
			
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

	private CtClass ctClass;

	private TypeSolver typeSolver;

	private ResolvedReferenceTypeDeclaration typeDeclaration;

	
	
	public JavassistTypeDeclarationAdapter(CtClass ctClass, TypeSolver typeSolver, ResolvedReferenceTypeDeclaration typeDeclaration)
	{
		this.ctClass = ctClass;
		this.typeSolver = typeSolver;
		this.typeDeclaration = typeDeclaration;
	}

	
	[IKVM.Attributes.Signature("()Ljava/util/List<Lcom/github/javaparser/resolution/declarations/ResolvedFieldDeclaration;>;")]
	
	public virtual List getDeclaredFields()
	{
		ArrayList arrayList = new ArrayList();
		CtField[] declaredFields = ctClass.getDeclaredFields();
		int num = declaredFields.Length;
		for (int i = 0; i < num; i++)
		{
			CtField ctField = declaredFields[i];
			((List)arrayList).add((object)new JavassistFieldDeclaration(ctField, typeSolver));
		}
		Iterator iterator = typeDeclaration.getAllAncestors().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			resolvedReferenceType.getTypeDeclaration().ifPresent(new ___003C_003EAnon5(arrayList));
		}
		return arrayList;
	}

	
	[IKVM.Attributes.Signature("(Z)Ljava/util/List<Lcom/github/javaparser/resolution/types/ResolvedReferenceType;>;")]
	[LineNumberTable(new byte[]
	{
		159,
		109,
		98,
		166,
		byte.MaxValue,
		9,
		69,
		226,
		60,
		97,
		99,
		167,
		110
	})]
	public virtual List getAncestors(bool acceptIncompleteList)
	{
		ArrayList arrayList = new ArrayList();
		UnsolvedSymbolException ex;
		try
		{
			getSuperClass().ifPresent(new ___003C_003EAnon0(arrayList));
		}
		catch (UnsolvedSymbolException x)
		{
			ex = ByteCodeHelper.MapException<UnsolvedSymbolException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_002d;
		}
		goto IL_003d;
		IL_002d:
		UnsolvedSymbolException ex2 = ex;
		if (!acceptIncompleteList)
		{
			throw ex2;
		}
		goto IL_003d;
		IL_003d:
		((List)arrayList).addAll((Collection)getInterfaces(acceptIncompleteList));
		return arrayList;
	}

	
	[IKVM.Attributes.Signature("()Ljava/util/Set<Lcom/github/javaparser/resolution/declarations/ResolvedReferenceTypeDeclaration;>;")]
	
	public virtual Set internalTypes()
	{
		//Discarded unreachable code: IL_0031
		NotFoundException ex;
		try
		{
			return (Set)Stream.of(ctClass.getNestedClasses()).map(new ___003C_003EAnon7(this)).collect(Collectors.toSet());
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException cause = ex;
		
		throw new UnsupportedOperationException("Please report this issue at https://github.com/javaparser/javaparser/issues/new/choose", cause);
	}

	
	[IKVM.Attributes.Signature("()Ljava/util/Set<Lcom/github/javaparser/resolution/declarations/ResolvedMethodDeclaration;>;")]
	
	public virtual Set getDeclaredMethods()
	{
		return (Set)Arrays.stream(ctClass.getDeclaredMethods()).filter(new ___003C_003EAnon1()).map(new ___003C_003EAnon2(this))
			.collect(Collectors.toSet());
	}

	
	[IKVM.Attributes.Signature("()Ljava/util/Optional<Lcom/github/javaparser/resolution/types/ResolvedReferenceType;>;")]
	[LineNumberTable(new byte[]
	{
		18,
		156,
		139,
		173,
		113,
		63,
		0,
		232,
		70,
		113,
		129,
		49,
		197,
		229,
		59,
		byte.MaxValue,
		0,
		72,
		97
	})]
	public virtual Optional getSuperClass()
	{
		//Discarded unreachable code: IL_00a0
		BadBytecode badBytecode;
		try
		{
			if (String.instancehelper_equals("java.lang.Object", ctClass.getClassFile().getName()))
			{
				return Optional.empty();
			}
			if (ctClass.getGenericSignature() == null)
			{
				ReferenceTypeImpl.___003Cclinit_003E();
				return Optional.of(new ReferenceTypeImpl(typeSolver.solveType(JavassistUtils.internalNameToCanonicalName(ctClass.getClassFile().getSuperclass())), typeSolver));
			}
			javassist.bytecode.SignatureAttribute.ClassSignature classSignature = javassist.bytecode.SignatureAttribute.toClassSignature(ctClass.getGenericSignature());
			return Optional.ofNullable(JavassistUtils.signatureTypeToType(classSignature.getSuperClass(), typeSolver, typeDeclaration).asReferenceType());
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode cause = badBytecode;
		
		throw new RuntimeException(cause);
	}

	
	[IKVM.Attributes.Signature("()Ljava/util/List<Lcom/github/javaparser/resolution/types/ResolvedReferenceType;>;")]
	
	public virtual List getInterfaces()
	{
		List interfaces = getInterfaces(false);
		
		return interfaces;
	}

	
	[IKVM.Attributes.Signature("()Ljava/util/List<Lcom/github/javaparser/resolution/declarations/ResolvedTypeParameterDeclaration;>;")]
	[LineNumberTable(new byte[]
	{
		160, 64, 110, 166, 102, 107, 118, 101, 31, 5,
		161, 97
	})]
	public virtual List getTypeParameters()
	{
		//Discarded unreachable code: IL_0051
		if (null == ctClass.getGenericSignature())
		{
			return Collections.emptyList();
		}
		BadBytecode badBytecode;
		try
		{
			javassist.bytecode.SignatureAttribute.ClassSignature classSignature = javassist.bytecode.SignatureAttribute.toClassSignature(ctClass.getGenericSignature());
			return (List)Arrays.stream(classSignature.getParameters()).map(new ___003C_003EAnon6(this)).collect(Collectors.toList());
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode cause = badBytecode;
		
		throw new RuntimeException(cause);
	}

	
	[IKVM.Attributes.Signature("()Ljava/util/List<Lcom/github/javaparser/resolution/declarations/ResolvedConstructorDeclaration;>;")]
	
	public virtual List getConstructors()
	{
		return (List)Arrays.stream(ctClass.getConstructors()).filter(new ___003C_003EAnon3()).map(new ___003C_003EAnon4(this))
			.collect(Collectors.toList());
	}

	
	[IKVM.Attributes.Signature("()Ljava/util/Optional<Lcom/github/javaparser/resolution/declarations/ResolvedReferenceTypeDeclaration;>;")]
	
	public virtual Optional containerType()
	{
		//Discarded unreachable code: IL_0031
		NotFoundException ex;
		try
		{
			return (ctClass.getDeclaringClass() != null) ? Optional.of(JavassistFactory.toTypeDeclaration(ctClass.getDeclaringClass(), typeSolver)) : Optional.empty();
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException cause = ex;
		
		throw new RuntimeException(cause);
	}

	
	
	public virtual bool isAssignableBy(ResolvedType other)
	{
		if (other.isNull())
		{
			return true;
		}
		if (other is LambdaArgumentTypePlaceholder)
		{
			bool result = typeDeclaration.isFunctionalInterface();
			
			return result;
		}
		ReferenceTypeImpl.___003Cclinit_003E();
		bool result2 = other.isAssignableBy(new ReferenceTypeImpl(typeDeclaration, typeSolver));
		
		return result2;
	}

	
	
	public virtual bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		bool result = isAssignableBy(new ReferenceTypeImpl(other, typeSolver));
		
		return result;
	}

	
	[IKVM.Attributes.Signature("(Z)Ljava/util/List<Lcom/github/javaparser/resolution/types/ResolvedReferenceType;>;")]
	[LineNumberTable(new byte[]
	{
		159,
		117,
		66,
		134,
		109,
		159,
		33,
		116,
		byte.MaxValue,
		10,
		69,
		byte.MaxValue,
		4,
		60,
		98,
		99,
		253,
		58,
		240,
		75,
		114,
		159,
		22,
		byte.MaxValue,
		16,
		69,
		byte.MaxValue,
		1,
		60,
		98,
		99,
		250,
		59,
		235,
		76,
		2,
		98,
		173
	})]
	private List getInterfaces(bool P_0)
	{
		ArrayList arrayList = new ArrayList();
		string[] interfaces;
		int num;
		BadBytecode badBytecode;
		int num2;
		try
		{
			if (ctClass.getGenericSignature() == null)
			{
				interfaces = ctClass.getClassFile().getInterfaces();
				num = interfaces.Length;
				num2 = 0;
				goto IL_004a;
			}
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0043;
		}
		javassist.bytecode.SignatureAttribute.ClassType[] interfaces2;
		int num3;
		BadBytecode badBytecode2;
		try
		{
			javassist.bytecode.SignatureAttribute.ClassSignature classSignature = javassist.bytecode.SignatureAttribute.toClassSignature(ctClass.getGenericSignature());
			interfaces2 = classSignature.getInterfaces();
			num2 = interfaces2.Length;
			num3 = 0;
		}
		catch (BadBytecode x2)
		{
			badBytecode2 = ByteCodeHelper.MapException<BadBytecode>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_011a;
		}
		BadBytecode badBytecode4;
		while (true)
		{
			UnsolvedSymbolException ex;
			BadBytecode badBytecode3;
			try
			{
				if (num3 >= num2)
				{
					return arrayList;
				}
				javassist.bytecode.SignatureAttribute.ClassType classType = interfaces2[num3];
				try
				{
					((List)arrayList).add((object)JavassistUtils.signatureTypeToType(classType, typeSolver, typeDeclaration).asReferenceType());
				}
				catch (UnsolvedSymbolException x3)
				{
					ex = ByteCodeHelper.MapException<UnsolvedSymbolException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_016f;
				}
			}
			catch (BadBytecode x4)
			{
				badBytecode3 = ByteCodeHelper.MapException<BadBytecode>(x4, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0175;
			}
			goto IL_019c;
			IL_0175:
			badBytecode4 = badBytecode3;
			break;
			IL_016f:
			UnsolvedSymbolException ex2 = ex;
			BadBytecode badBytecode5;
			try
			{
				UnsolvedSymbolException ex3 = ex2;
				if (!P_0)
				{
					throw Throwable.___003Cunmap_003E(ex3);
				}
			}
			catch (BadBytecode x5)
			{
				badBytecode5 = ByteCodeHelper.MapException<BadBytecode>(x5, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0198;
			}
			goto IL_019c;
			IL_019c:
			num3++;
			continue;
			IL_0198:
			badBytecode4 = badBytecode5;
			break;
		}
		goto IL_01a9;
		IL_0043:
		badBytecode4 = badBytecode;
		goto IL_01a9;
		IL_01a9:
		BadBytecode cause = badBytecode4;
		
		throw new RuntimeException(cause);
		IL_011a:
		badBytecode4 = badBytecode2;
		goto IL_01a9;
		IL_004a:
		while (true)
		{
			UnsolvedSymbolException ex4;
			BadBytecode badBytecode6;
			try
			{
				if (num2 >= num)
				{
					return arrayList;
				}
				string text = interfaces[num2];
				try
				{
					ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = typeSolver.solveType(JavassistUtils.internalNameToCanonicalName(text));
					ReferenceTypeImpl.___003Cclinit_003E();
					((List)arrayList).add((object)new ReferenceTypeImpl(resolvedReferenceTypeDeclaration, typeSolver));
				}
				catch (UnsolvedSymbolException x6)
				{
					ex4 = ByteCodeHelper.MapException<UnsolvedSymbolException>(x6, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_00a4;
				}
			}
			catch (BadBytecode x7)
			{
				badBytecode6 = ByteCodeHelper.MapException<BadBytecode>(x7, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00aa;
			}
			goto IL_00d7;
			IL_00aa:
			badBytecode4 = badBytecode6;
			break;
			IL_00a4:
			UnsolvedSymbolException ex = ex4;
			BadBytecode badBytecode7;
			try
			{
				UnsolvedSymbolException ex5 = ex;
				if (!P_0)
				{
					throw Throwable.___003Cunmap_003E(ex5);
				}
			}
			catch (BadBytecode x8)
			{
				badBytecode7 = ByteCodeHelper.MapException<BadBytecode>(x8, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00d0;
			}
			goto IL_00d7;
			IL_00d7:
			num2++;
			continue;
			IL_00d0:
			badBytecode4 = badBytecode7;
			break;
		}
		goto IL_01a9;
	}

	
	
	
	private static void lambda_0024getAncestors_00240(List P_0, ResolvedReferenceType P_1)
	{
		P_0.add(P_1);
	}

	
	
	
	private static bool lambda_0024getDeclaredMethods_00241(CtMethod P_0)
	{
		return ((P_0.getMethodInfo().getAccessFlags() & 0x40) == 0 && (P_0.getMethodInfo().getAccessFlags() & 0x1000) == 0) ? true : false;
	}

	
	
	
	private JavassistMethodDeclaration lambda_0024getDeclaredMethods_00242(CtMethod P_0)
	{
		JavassistMethodDeclaration result = new JavassistMethodDeclaration(P_0, typeSolver);
		
		return result;
	}

	
	
	
	private static bool lambda_0024getConstructors_00243(CtConstructor P_0)
	{
		return ((P_0.getMethodInfo().getAccessFlags() & 0x1000) == 0) ? true : false;
	}

	
	
	
	private JavassistConstructorDeclaration lambda_0024getConstructors_00244(CtConstructor P_0)
	{
		JavassistConstructorDeclaration result = new JavassistConstructorDeclaration(P_0, typeSolver);
		
		return result;
	}

	
	
	
	private static void lambda_0024getDeclaredFields_00245(List P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		P_0.addAll(P_1.getAllFields());
	}

	
	
	
	private JavassistTypeParameter lambda_0024getTypeParameters_00246(javassist.bytecode.SignatureAttribute.TypeParameter P_0)
	{
		JavassistTypeParameter result = new JavassistTypeParameter(P_0, JavassistFactory.toTypeDeclaration(ctClass, typeSolver), typeSolver);
		
		return result;
	}

	
	
	
	private ResolvedReferenceTypeDeclaration lambda_0024internalTypes_00247(CtClass P_0)
	{
		ResolvedReferenceTypeDeclaration result = JavassistFactory.toTypeDeclaration(P_0, typeSolver);
		
		return result;
	}
}
