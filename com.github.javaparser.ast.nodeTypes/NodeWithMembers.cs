using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.nodeTypes;


public class NodeWithMembers : NodeWithSimpleName
{
	private static class ___003C_003EPIM
	{
		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024getMethodsByName_00240(string name, MethodDeclaration m)
		{
			bool result = String.instancehelper_equals(m.getNameAsString(), name);
			
			return result;
		}

		
		
		
		internal static bool lambda_0024getMethods_00241(BodyDeclaration m)
		{
			return m is MethodDeclaration;
		}

		
		
		
		internal static MethodDeclaration lambda_0024getMethods_00242(BodyDeclaration m)
		{
			return (MethodDeclaration)m;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024getMethodsByParameterTypes_00243(string[] paramTypes, MethodDeclaration m)
		{
			bool result = m.hasParametersOfType(paramTypes);
			
			return result;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024getMethodsBySignature_00244(string[] paramTypes, MethodDeclaration m)
		{
			bool result = m.hasParametersOfType(paramTypes);
			
			return result;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024getMethodsByParameterTypes_00245(Class[] paramTypes, MethodDeclaration m)
		{
			bool result = m.hasParametersOfType(paramTypes);
			
			return result;
		}

		
		
		
		internal static bool lambda_0024getConstructors_00246(BodyDeclaration m)
		{
			return m is ConstructorDeclaration;
		}

		
		
		
		internal static ConstructorDeclaration lambda_0024getConstructors_00247(BodyDeclaration m)
		{
			return (ConstructorDeclaration)m;
		}

		
		
		
		internal static bool lambda_0024getDefaultConstructor_00248(BodyDeclaration m)
		{
			return m is ConstructorDeclaration;
		}

		
		
		
		internal static ConstructorDeclaration lambda_0024getDefaultConstructor_00249(BodyDeclaration m)
		{
			return (ConstructorDeclaration)m;
		}

		
		
		
		
		internal static bool lambda_0024getDefaultConstructor_002410(ConstructorDeclaration cd)
		{
			bool result = cd.getParameters().isEmpty();
			
			return result;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024getConstructorByParameterTypes_002411(string[] paramTypes, ConstructorDeclaration m)
		{
			bool result = m.hasParametersOfType(paramTypes);
			
			return result;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024getConstructorByParameterTypes_002412(Class[] paramTypes, ConstructorDeclaration m)
		{
			bool result = m.hasParametersOfType(paramTypes);
			
			return result;
		}

		
		
		
		internal static bool lambda_0024getFieldByName_002413(BodyDeclaration m)
		{
			return m is FieldDeclaration;
		}

		
		
		
		internal static FieldDeclaration lambda_0024getFieldByName_002414(BodyDeclaration f)
		{
			return (FieldDeclaration)f;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024getFieldByName_002416(string name, FieldDeclaration f)
		{
			bool result = f.getVariables().stream().anyMatch(new ___003C_003EAnon19(name));
			
			return result;
		}

		
		
		
		internal static bool lambda_0024getFields_002417(BodyDeclaration m)
		{
			return m is FieldDeclaration;
		}

		
		
		
		internal static FieldDeclaration lambda_0024getFields_002418(BodyDeclaration m)
		{
			return (FieldDeclaration)m;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024null_002415(string name, VariableDeclarator var)
		{
			bool result = String.instancehelper_equals(var.getNameAsString(), name);
			
			return result;
		}
	}

	
	public new static class __DefaultMethods
	{
		public unsafe static BodyDeclaration getMember(NodeWithMembers P_0, int P_1)
		{
			
			return _003Cdefault_003EgetMember(P_0, P_1);
		}

		public unsafe static Node setMember(NodeWithMembers P_0, int P_1, BodyDeclaration P_2)
		{
			
			return _003Cdefault_003EsetMember(P_0, P_1, P_2);
		}

		public unsafe static Node addMember(NodeWithMembers P_0, BodyDeclaration P_1)
		{
			
			return _003Cdefault_003EaddMember(P_0, P_1);
		}

		public unsafe static FieldDeclaration addField(NodeWithMembers P_0, Class P_1, string P_2, Modifier.Keyword[] P_3)
		{
			
			return _003Cdefault_003EaddField(P_0, P_1, P_2, P_3);
		}

		public unsafe static FieldDeclaration addField(NodeWithMembers P_0, string P_1, string P_2, Modifier.Keyword[] P_3)
		{
			
			return _003Cdefault_003EaddField(P_0, P_1, P_2, P_3);
		}

		public unsafe static FieldDeclaration addField(NodeWithMembers P_0, Type P_1, string P_2, Modifier.Keyword[] P_3)
		{
			
			return _003Cdefault_003EaddField(P_0, P_1, P_2, P_3);
		}

		public unsafe static FieldDeclaration addFieldWithInitializer(NodeWithMembers P_0, Class P_1, string P_2, Expression P_3, Modifier.Keyword[] P_4)
		{
			
			return _003Cdefault_003EaddFieldWithInitializer(P_0, P_1, P_2, P_3, P_4);
		}

		public unsafe static FieldDeclaration addFieldWithInitializer(NodeWithMembers P_0, string P_1, string P_2, Expression P_3, Modifier.Keyword[] P_4)
		{
			
			return _003Cdefault_003EaddFieldWithInitializer(P_0, P_1, P_2, P_3, P_4);
		}

		public unsafe static FieldDeclaration addFieldWithInitializer(NodeWithMembers P_0, Type P_1, string P_2, Expression P_3, Modifier.Keyword[] P_4)
		{
			
			return _003Cdefault_003EaddFieldWithInitializer(P_0, P_1, P_2, P_3, P_4);
		}

		public unsafe static FieldDeclaration addPrivateField(NodeWithMembers P_0, Class P_1, string P_2)
		{
			
			return _003Cdefault_003EaddPrivateField(P_0, P_1, P_2);
		}

		public unsafe static FieldDeclaration addPrivateField(NodeWithMembers P_0, string P_1, string P_2)
		{
			
			return _003Cdefault_003EaddPrivateField(P_0, P_1, P_2);
		}

		public unsafe static FieldDeclaration addPrivateField(NodeWithMembers P_0, Type P_1, string P_2)
		{
			
			return _003Cdefault_003EaddPrivateField(P_0, P_1, P_2);
		}

		public unsafe static FieldDeclaration addPublicField(NodeWithMembers P_0, Class P_1, string P_2)
		{
			
			return _003Cdefault_003EaddPublicField(P_0, P_1, P_2);
		}

		public unsafe static FieldDeclaration addPublicField(NodeWithMembers P_0, string P_1, string P_2)
		{
			
			return _003Cdefault_003EaddPublicField(P_0, P_1, P_2);
		}

		public unsafe static FieldDeclaration addPublicField(NodeWithMembers P_0, Type P_1, string P_2)
		{
			
			return _003Cdefault_003EaddPublicField(P_0, P_1, P_2);
		}

		public unsafe static FieldDeclaration addProtectedField(NodeWithMembers P_0, Class P_1, string P_2)
		{
			
			return _003Cdefault_003EaddProtectedField(P_0, P_1, P_2);
		}

		public unsafe static FieldDeclaration addProtectedField(NodeWithMembers P_0, string P_1, string P_2)
		{
			
			return _003Cdefault_003EaddProtectedField(P_0, P_1, P_2);
		}

		public unsafe static FieldDeclaration addProtectedField(NodeWithMembers P_0, Type P_1, string P_2)
		{
			
			return _003Cdefault_003EaddProtectedField(P_0, P_1, P_2);
		}

		public unsafe static MethodDeclaration addMethod(NodeWithMembers P_0, string P_1, Modifier.Keyword[] P_2)
		{
			
			return _003Cdefault_003EaddMethod(P_0, P_1, P_2);
		}

		public unsafe static ConstructorDeclaration addConstructor(NodeWithMembers P_0, Modifier.Keyword[] P_1)
		{
			
			return _003Cdefault_003EaddConstructor(P_0, P_1);
		}

		public unsafe static BlockStmt addInitializer(NodeWithMembers P_0)
		{
			
			return _003Cdefault_003EaddInitializer(P_0);
		}

		public unsafe static BlockStmt addStaticInitializer(NodeWithMembers P_0)
		{
			
			return _003Cdefault_003EaddStaticInitializer(P_0);
		}

		public unsafe static List getMethodsByName(NodeWithMembers P_0, string P_1)
		{
			
			return _003Cdefault_003EgetMethodsByName(P_0, P_1);
		}

		public unsafe static List getMethods(NodeWithMembers P_0)
		{
			
			return _003Cdefault_003EgetMethods(P_0);
		}

		public unsafe static List getMethodsByParameterTypes(NodeWithMembers P_0, string[] P_1)
		{
			
			return _003Cdefault_003EgetMethodsByParameterTypes(P_0, P_1);
		}

		public unsafe static List getMethodsBySignature(NodeWithMembers P_0, string P_1, string[] P_2)
		{
			
			return _003Cdefault_003EgetMethodsBySignature(P_0, P_1, P_2);
		}

		public unsafe static List getMethodsByParameterTypes(NodeWithMembers P_0, Class[] P_1)
		{
			
			return _003Cdefault_003EgetMethodsByParameterTypes(P_0, P_1);
		}

		public unsafe static List getConstructors(NodeWithMembers P_0)
		{
			
			return _003Cdefault_003EgetConstructors(P_0);
		}

		public unsafe static Optional getDefaultConstructor(NodeWithMembers P_0)
		{
			
			return _003Cdefault_003EgetDefaultConstructor(P_0);
		}

		public unsafe static Optional getConstructorByParameterTypes(NodeWithMembers P_0, string[] P_1)
		{
			
			return _003Cdefault_003EgetConstructorByParameterTypes(P_0, P_1);
		}

		public unsafe static Optional getConstructorByParameterTypes(NodeWithMembers P_0, Class[] P_1)
		{
			
			return _003Cdefault_003EgetConstructorByParameterTypes(P_0, P_1);
		}

		public unsafe static Optional getFieldByName(NodeWithMembers P_0, string P_1)
		{
			
			return _003Cdefault_003EgetFieldByName(P_0, P_1);
		}

		public unsafe static List getFields(NodeWithMembers P_0)
		{
			
			return _003Cdefault_003EgetFields(P_0);
		}

		public unsafe static bool isEmpty(NodeWithMembers P_0)
		{
			
			return _003Cdefault_003EisEmpty(P_0);
		}
	}

	
	private class ___003C_003EAnon1 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getMethodsByName_00240(arg_00241, (MethodDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon2 : Predicate
	{
		internal ___003C_003EAnon2()
		{
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getMethods_00241((BodyDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			MethodDeclaration result = ___003C_003EPIM.lambda_0024getMethods_00242((BodyDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon4 : Predicate
	{
		private readonly string[] arg_00241;

		internal ___003C_003EAnon4(string[] P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getMethodsByParameterTypes_00243(arg_00241, (MethodDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon5 : Predicate
	{
		private readonly string[] arg_00241;

		internal ___003C_003EAnon5(string[] P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getMethodsBySignature_00244(arg_00241, (MethodDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon6 : Predicate
	{
		private readonly Class[] arg_00241;

		internal ___003C_003EAnon6(Class[] P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getMethodsByParameterTypes_00245(arg_00241, (MethodDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon7 : Predicate
	{
		internal ___003C_003EAnon7()
		{
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getConstructors_00246((BodyDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon8 : Function
	{
		internal ___003C_003EAnon8()
		{
		}

		public object apply(object P_0)
		{
			ConstructorDeclaration result = ___003C_003EPIM.lambda_0024getConstructors_00247((BodyDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon9 : Predicate
	{
		internal ___003C_003EAnon9()
		{
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getDefaultConstructor_00248((BodyDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon10 : Function
	{
		internal ___003C_003EAnon10()
		{
		}

		public object apply(object P_0)
		{
			ConstructorDeclaration result = ___003C_003EPIM.lambda_0024getDefaultConstructor_00249((BodyDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon11 : Predicate
	{
		internal ___003C_003EAnon11()
		{
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getDefaultConstructor_002410((ConstructorDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon12 : Predicate
	{
		private readonly string[] arg_00241;

		internal ___003C_003EAnon12(string[] P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getConstructorByParameterTypes_002411(arg_00241, (ConstructorDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon13 : Predicate
	{
		private readonly Class[] arg_00241;

		internal ___003C_003EAnon13(Class[] P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getConstructorByParameterTypes_002412(arg_00241, (ConstructorDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon14 : Predicate
	{
		internal ___003C_003EAnon14()
		{
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getFieldByName_002413((BodyDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon15 : Function
	{
		internal ___003C_003EAnon15()
		{
		}

		public object apply(object P_0)
		{
			FieldDeclaration result = ___003C_003EPIM.lambda_0024getFieldByName_002414((BodyDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon16 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon16(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getFieldByName_002416(arg_00241, (FieldDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon17 : Predicate
	{
		internal ___003C_003EAnon17()
		{
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getFields_002417((BodyDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon18 : Function
	{
		internal ___003C_003EAnon18()
		{
		}

		public object apply(object P_0)
		{
			FieldDeclaration result = ___003C_003EPIM.lambda_0024getFields_002418((BodyDeclaration)P_0);
			
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

	
	private class ___003C_003EAnon19 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon19(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024null_002415(arg_00241, (VariableDeclarator)P_0);
			
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

	
		virtual List getMethods();

	
	
	
	static List _003Cdefault_003EgetMethods(NodeWithMembers P_0)
	{
		List result = Collections.unmodifiableList((List)P_0.getMembers().stream().filter(new ___003C_003EAnon2())
			.map(new ___003C_003EAnon3())
			.collect(Collectors.toList()));
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual MethodDeclaration addMethod(string methodName, params Modifier.Keyword[] modifiers);

	
	
	
	static MethodDeclaration _003Cdefault_003EaddMethod(NodeWithMembers P_0, string P_1, Modifier.Keyword[] P_2)
	{
		MethodDeclaration methodDeclaration = new MethodDeclaration();
		methodDeclaration.setName(P_1);
		methodDeclaration.setType(new VoidType());
		methodDeclaration.setModifiers(Modifier.createModifierList(P_2));
		P_0.getMembers().add(methodDeclaration);
		return methodDeclaration;
	}

		virtual NodeList getMembers();

		
	virtual void tryAddImportToParentCompilationUnit(Class clazz);

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addField(string type, string name, params Modifier.Keyword[] modifiers);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddField(NodeWithMembers P_0, string P_1, string P_2, Modifier.Keyword[] P_3)
	{
		FieldDeclaration result = P_0.addField(StaticJavaParser.parseType(P_1), P_2, P_3);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addField(Type type, string name, params Modifier.Keyword[] modifiers);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddField(NodeWithMembers P_0, Type P_1, string P_2, Modifier.Keyword[] P_3)
	{
		FieldDeclaration fieldDeclaration = new FieldDeclaration();
		VariableDeclarator node = new VariableDeclarator(P_1, P_2);
		fieldDeclaration.getVariables().add(node);
		fieldDeclaration.setModifiers(Modifier.createModifierList(P_3));
		P_0.getMembers().add(fieldDeclaration);
		return fieldDeclaration;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addFieldWithInitializer(string type, string name, Expression initializer, params Modifier.Keyword[] modifiers);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddFieldWithInitializer(NodeWithMembers P_0, string P_1, string P_2, Expression P_3, Modifier.Keyword[] P_4)
	{
		FieldDeclaration result = P_0.addFieldWithInitializer(StaticJavaParser.parseType(P_1), P_2, P_3, P_4);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addFieldWithInitializer(Type type, string name, Expression initializer, params Modifier.Keyword[] modifiers);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddFieldWithInitializer(NodeWithMembers P_0, Type P_1, string P_2, Expression P_3, Modifier.Keyword[] P_4)
	{
		FieldDeclaration fieldDeclaration = P_0.addField(P_1, P_2, P_4);
		((VariableDeclarator)fieldDeclaration.getVariables().iterator().next()).setInitializer(P_3);
		return fieldDeclaration;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addField(Class typeClass, string name, params Modifier.Keyword[] modifiers);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddField(NodeWithMembers P_0, Class P_1, string P_2, Modifier.Keyword[] P_3)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		FieldDeclaration result = P_0.addField(P_1.getSimpleName(), P_2, P_3);
		
		return result;
	}

	
		
	virtual List getMethodsByName(string name);

	
	
	
	static List _003Cdefault_003EgetMethodsByName(NodeWithMembers P_0, string P_1)
	{
		List result = Collections.unmodifiableList((List)P_0.getMethods().stream().filter(new ___003C_003EAnon1(P_1))
			.collect(Collectors.toList()));
		
		return result;
	}

	
		virtual List getConstructors();

	
	
	
	static List _003Cdefault_003EgetConstructors(NodeWithMembers P_0)
	{
		List result = Collections.unmodifiableList((List)P_0.getMembers().stream().filter(new ___003C_003EAnon7())
			.map(new ___003C_003EAnon8())
			.collect(Collectors.toList()));
		
		return result;
	}

	
		
	virtual BodyDeclaration getMember(int i);

	
	
	
	static BodyDeclaration _003Cdefault_003EgetMember(NodeWithMembers P_0, int P_1)
	{
		return (BodyDeclaration)P_0.getMembers().get(P_1);
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual Node setMember(int i, BodyDeclaration member);

	
	
	
	static Node _003Cdefault_003EsetMember(NodeWithMembers P_0, int P_1, BodyDeclaration P_2)
	{
		P_0.getMembers().set(P_1, P_2);
		return (Node)P_0;
	}

	
		
	virtual Node addMember(BodyDeclaration member);

	
	
	
	static Node _003Cdefault_003EaddMember(NodeWithMembers P_0, BodyDeclaration P_1)
	{
		P_0.getMembers().add(P_1);
		return (Node)P_0;
	}

		
	virtual Node setMembers(NodeList members);

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addFieldWithInitializer(Class typeClass, string name, Expression initializer, params Modifier.Keyword[] modifiers);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddFieldWithInitializer(NodeWithMembers P_0, Class P_1, string P_2, Expression P_3, Modifier.Keyword[] P_4)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		FieldDeclaration result = P_0.addFieldWithInitializer(P_1.getSimpleName(), P_2, P_3, P_4);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addPrivateField(Class typeClass, string name);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddPrivateField(NodeWithMembers P_0, Class P_1, string P_2)
	{
		FieldDeclaration result = P_0.addField(P_1, P_2, Modifier.Keyword.___003C_003EPRIVATE);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addPrivateField(string type, string name);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddPrivateField(NodeWithMembers P_0, string P_1, string P_2)
	{
		FieldDeclaration result = P_0.addField(P_1, P_2, Modifier.Keyword.___003C_003EPRIVATE);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addPrivateField(Type type, string name);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddPrivateField(NodeWithMembers P_0, Type P_1, string P_2)
	{
		FieldDeclaration result = P_0.addField(P_1, P_2, Modifier.Keyword.___003C_003EPRIVATE);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addPublicField(Class typeClass, string name);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddPublicField(NodeWithMembers P_0, Class P_1, string P_2)
	{
		FieldDeclaration result = P_0.addField(P_1, P_2, Modifier.Keyword.___003C_003EPUBLIC);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addPublicField(string type, string name);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddPublicField(NodeWithMembers P_0, string P_1, string P_2)
	{
		FieldDeclaration result = P_0.addField(P_1, P_2, Modifier.Keyword.___003C_003EPUBLIC);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addPublicField(Type type, string name);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddPublicField(NodeWithMembers P_0, Type P_1, string P_2)
	{
		FieldDeclaration result = P_0.addField(P_1, P_2, Modifier.Keyword.___003C_003EPUBLIC);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addProtectedField(Class typeClass, string name);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddProtectedField(NodeWithMembers P_0, Class P_1, string P_2)
	{
		FieldDeclaration result = P_0.addField(P_1, P_2, Modifier.Keyword.___003C_003EPROTECTED);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addProtectedField(string type, string name);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddProtectedField(NodeWithMembers P_0, string P_1, string P_2)
	{
		FieldDeclaration result = P_0.addField(P_1, P_2, Modifier.Keyword.___003C_003EPROTECTED);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual FieldDeclaration addProtectedField(Type type, string name);

	
	
	
	static FieldDeclaration _003Cdefault_003EaddProtectedField(NodeWithMembers P_0, Type P_1, string P_2)
	{
		FieldDeclaration result = P_0.addField(P_1, P_2, Modifier.Keyword.___003C_003EPROTECTED);
		
		return result;
	}

	
	
	virtual ConstructorDeclaration addConstructor(params Modifier.Keyword[] modifiers);

	
	
	
	static ConstructorDeclaration _003Cdefault_003EaddConstructor(NodeWithMembers P_0, Modifier.Keyword[] P_1)
	{
		ConstructorDeclaration constructorDeclaration = new ConstructorDeclaration();
		constructorDeclaration.setModifiers(Modifier.createModifierList(P_1));
		constructorDeclaration.setName(P_0.getName());
		P_0.getMembers().add(constructorDeclaration);
		return constructorDeclaration;
	}

	
	virtual BlockStmt addInitializer();

	
	
	
	static BlockStmt _003Cdefault_003EaddInitializer(NodeWithMembers P_0)
	{
		BlockStmt blockStmt = new BlockStmt();
		InitializerDeclaration node = new InitializerDeclaration(isStatic: false, blockStmt);
		P_0.getMembers().add(node);
		return blockStmt;
	}

	
	virtual BlockStmt addStaticInitializer();

	
	
	
	static BlockStmt _003Cdefault_003EaddStaticInitializer(NodeWithMembers P_0)
	{
		BlockStmt blockStmt = new BlockStmt();
		InitializerDeclaration node = new InitializerDeclaration(isStatic: true, blockStmt);
		P_0.getMembers().add(node);
		return blockStmt;
	}

	
		
	virtual List getMethodsByParameterTypes(params string[] paramTypes);

	
	
	
	static List _003Cdefault_003EgetMethodsByParameterTypes(NodeWithMembers P_0, string[] P_1)
	{
		List result = Collections.unmodifiableList((List)P_0.getMethods().stream().filter(new ___003C_003EAnon4(P_1))
			.collect(Collectors.toList()));
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual List getMethodsBySignature(string name, params string[] paramTypes);

	
	
	
	static List _003Cdefault_003EgetMethodsBySignature(NodeWithMembers P_0, string P_1, string[] P_2)
	{
		List result = Collections.unmodifiableList((List)P_0.getMethodsByName(P_1).stream().filter(new ___003C_003EAnon5(P_2))
			.collect(Collectors.toList()));
		
		return result;
	}

	
		
	virtual List getMethodsByParameterTypes(params Class[] paramTypes);

	
	
	
	static List _003Cdefault_003EgetMethodsByParameterTypes(NodeWithMembers P_0, Class[] P_1)
	{
		List result = Collections.unmodifiableList((List)P_0.getMethods().stream().filter(new ___003C_003EAnon6(P_1))
			.collect(Collectors.toList()));
		
		return result;
	}

	
		virtual Optional getDefaultConstructor();

	
	
	
	static Optional _003Cdefault_003EgetDefaultConstructor(NodeWithMembers P_0)
	{
		Optional result = P_0.getMembers().stream().filter(new ___003C_003EAnon9())
			.map(new ___003C_003EAnon10())
			.filter(new ___003C_003EAnon11())
			.findFirst();
		
		return result;
	}

	
		
	virtual Optional getConstructorByParameterTypes(params string[] paramTypes);

	
	
	
	static Optional _003Cdefault_003EgetConstructorByParameterTypes(NodeWithMembers P_0, string[] P_1)
	{
		Optional result = P_0.getConstructors().stream().filter(new ___003C_003EAnon12(P_1))
			.findFirst();
		
		return result;
	}

	
		
	virtual Optional getConstructorByParameterTypes(params Class[] paramTypes);

	
	
	
	static Optional _003Cdefault_003EgetConstructorByParameterTypes(NodeWithMembers P_0, Class[] P_1)
	{
		Optional result = P_0.getConstructors().stream().filter(new ___003C_003EAnon13(P_1))
			.findFirst();
		
		return result;
	}

	
		
	virtual Optional getFieldByName(string name);

	
	
	
	static Optional _003Cdefault_003EgetFieldByName(NodeWithMembers P_0, string P_1)
	{
		Optional result = P_0.getMembers().stream().filter(new ___003C_003EAnon14())
			.map(new ___003C_003EAnon15())
			.filter(new ___003C_003EAnon16(P_1))
			.findFirst();
		
		return result;
	}

	
		virtual List getFields();

	
	
	
	static List _003Cdefault_003EgetFields(NodeWithMembers P_0)
	{
		List result = Collections.unmodifiableList((List)P_0.getMembers().stream().filter(new ___003C_003EAnon17())
			.map(new ___003C_003EAnon18())
			.collect(Collectors.toList()));
		
		return result;
	}

	
	virtual bool isEmpty();

	
	
	
	static bool _003Cdefault_003EisEmpty(NodeWithMembers P_0)
	{
		bool result = P_0.getMembers().isEmpty();
		
		return result;
	}
}
