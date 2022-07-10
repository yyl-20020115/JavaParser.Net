using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
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

public class JavassistMethodLikeDeclarationAdapter
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly JavassistMethodLikeDeclarationAdapter arg_00241;

		internal ___003C_003EAnon0(JavassistMethodLikeDeclarationAdapter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavassistTypeParameter result = arg_00241.lambda_0024getTypeParameters_00240((javassist.bytecode.SignatureAttribute.TypeParameter)P_0);
			
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

	private CtBehavior ctBehavior;

	private TypeSolver typeSolver;

	private ResolvedMethodLikeDeclaration declaration;

	private javassist.bytecode.SignatureAttribute.MethodSignature methodSignature;

	
	[LineNumberTable(new byte[]
	{
		159, 189, 104, 103, 103, 167, 103, 99, 135, 190,
		2, 97, 140
	})]
	public JavassistMethodLikeDeclarationAdapter(CtBehavior ctBehavior, TypeSolver typeSolver, ResolvedMethodLikeDeclaration declaration)
	{
		this.ctBehavior = ctBehavior;
		this.typeSolver = typeSolver;
		this.declaration = declaration;
		BadBytecode badBytecode;
		try
		{
			string text = ctBehavior.getGenericSignature();
			if (text == null)
			{
				text = ctBehavior.getSignature();
			}
			methodSignature = javassist.bytecode.SignatureAttribute.toMethodSignature(text);
			return;
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode cause = badBytecode;
		
		throw new RuntimeException(cause);
	}

	
	
	public virtual int getNumberOfParams()
	{
		return methodSignature.getParameterTypes().Length;
	}

	
	
	public virtual ResolvedParameterDeclaration getParam(int i)
	{
		int variadic = 0;
		if ((ctBehavior.getModifiers() & 0x80) > 0)
		{
			variadic = ((i == (nint)methodSignature.getParameterTypes().LongLength - 1) ? 1 : 0);
		}
		Optional optional = JavassistUtils.extractParameterName(ctBehavior, i);
		ResolvedType type = JavassistUtils.signatureTypeToType(methodSignature.getParameterTypes()[i], typeSolver, declaration);
		JavassistParameterDeclaration result = new JavassistParameterDeclaration(type, typeSolver, (byte)variadic != 0, (string)optional.orElse(null));
		
		return result;
	}

	
	[IKVM.Attributes.Signature("()Ljava/util/List<Lcom/github/javaparser/resolution/declarations/ResolvedTypeParameterDeclaration;>;")]
	
	public virtual List getTypeParameters()
	{
		if (ctBehavior.getGenericSignature() == null)
		{
			ArrayList result = new ArrayList();
			
			return result;
		}
		return (List)Arrays.stream(methodSignature.getTypeParameters()).map(new ___003C_003EAnon0(this)).collect(Collectors.toList());
	}

	
	
	public virtual int getNumberOfSpecifiedExceptions()
	{
		ExceptionsAttribute exceptionsAttribute = ctBehavior.getMethodInfo().getExceptionsAttribute();
		if (exceptionsAttribute == null)
		{
			return 0;
		}
		string[] exceptions = exceptionsAttribute.getExceptions();
		return (int)((exceptions != null) ? exceptions.LongLength : 0);
	}

	
	[LineNumberTable(new byte[]
	{
		48, 100, 191, 5, 113, 99, 191, 5, 103, 104,
		110, 52, 208, 111
	})]
	public virtual ResolvedType getSpecifiedException(int index)
	{
		if (index < 0)
		{
			string s = String.format("index < 0: %d", Integer.valueOf(index));
			
			throw new IllegalArgumentException(s);
		}
		ExceptionsAttribute exceptionsAttribute = ctBehavior.getMethodInfo().getExceptionsAttribute();
		if (exceptionsAttribute == null)
		{
			string s2 = String.format("No exception with index %d. Number of exceptions: 0", Integer.valueOf(index));
			
			throw new IllegalArgumentException(s2);
		}
		string[] exceptions = exceptionsAttribute.getExceptions();
		if (exceptions == null || index >= (nint)exceptions.LongLength)
		{
			string s3 = String.format("No exception with index %d. Number of exceptions: %d", Integer.valueOf(index), Integer.valueOf(getNumberOfSpecifiedExceptions()));
			
			throw new IllegalArgumentException(s3);
		}
		ResolvedReferenceTypeDeclaration typeDeclaration = typeSolver.solveType(exceptions[index]);
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeDeclaration, Collections.emptyList(), typeSolver);
		
		return result;
	}

	
	
	public virtual ResolvedType getReturnType()
	{
		ResolvedType result = JavassistUtils.signatureTypeToType(methodSignature.getReturnType(), typeSolver, declaration);
		
		return result;
	}

	
	
	
	private JavassistTypeParameter lambda_0024getTypeParameters_00240(javassist.bytecode.SignatureAttribute.TypeParameter P_0)
	{
		JavassistTypeParameter result = new JavassistTypeParameter(P_0, declaration, typeSolver);
		
		return result;
	}
}
