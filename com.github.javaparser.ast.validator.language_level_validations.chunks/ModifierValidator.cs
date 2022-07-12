using System.ComponentModel;

using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.validator.language_level_validations.chunks;

public class ModifierValidator : VisitorValidator
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly ModifierValidator arg_00241;

		private readonly ProblemReporter arg_00242;

		internal ___003C_003EAnon0(ModifierValidator P_0, ProblemReporter P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00240(arg_00242, (Parameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly ModifierValidator arg_00241;

		private readonly ProblemReporter arg_00242;

		internal ___003C_003EAnon1(ModifierValidator P_0, ProblemReporter P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00241(arg_00242, (Parameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly ModifierValidator arg_00241;

		private readonly ProblemReporter arg_00242;

		internal ___003C_003EAnon2(ModifierValidator P_0, ProblemReporter P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00242(arg_00242, (Parameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private Modifier.Keyword[] interfaceWithNothingSpecial;

	
	private Modifier.Keyword[] interfaceWithStaticAndDefault;

	
	private Modifier.Keyword[] interfaceWithStaticAndDefaultAndPrivate;

	
	private bool hasStrictfp;

	
	private bool hasDefaultAndStaticInterfaceMethods;

	
	private bool hasPrivateInterfaceMethods;

	
		
	
	private void validateInterfaceModifiers(TypeDeclaration n, ProblemReporter reporter)
	{
		if (n.isTopLevelType())
		{
			validateModifiers(n, reporter, Modifier.Keyword.___003C_003EPUBLIC, Modifier.Keyword.___003C_003EABSTRACT, Modifier.Keyword.___003C_003ESTRICTFP);
		}
		else if (n.isNestedType())
		{
			validateModifiers(n, reporter, Modifier.Keyword.___003C_003EPUBLIC, Modifier.Keyword.___003C_003EPROTECTED, Modifier.Keyword.___003C_003EPRIVATE, Modifier.Keyword.___003C_003EABSTRACT, Modifier.Keyword.___003C_003ESTATIC, Modifier.Keyword.___003C_003ESTRICTFP);
		}
	}

	
	
	
	private void validateClassModifiers(ClassOrInterfaceDeclaration n, ProblemReporter reporter)
	{
		if (n.isTopLevelType())
		{
			validateModifiers(n, reporter, Modifier.Keyword.___003C_003EPUBLIC, Modifier.Keyword.___003C_003EABSTRACT, Modifier.Keyword.___003C_003EFINAL, Modifier.Keyword.___003C_003ESTRICTFP);
		}
		else if (n.isNestedType())
		{
			validateModifiers(n, reporter, Modifier.Keyword.___003C_003EPUBLIC, Modifier.Keyword.___003C_003EPROTECTED, Modifier.Keyword.___003C_003EPRIVATE, Modifier.Keyword.___003C_003EABSTRACT, Modifier.Keyword.___003C_003ESTATIC, Modifier.Keyword.___003C_003EFINAL, Modifier.Keyword.___003C_003ESTRICTFP);
		}
		else if (n.isLocalClassDeclaration())
		{
			validateModifiers(n, reporter, Modifier.Keyword.___003C_003EABSTRACT, Modifier.Keyword.___003C_003EFINAL, Modifier.Keyword.___003C_003ESTRICTFP);
		}
	}

	
		
	
	private void validateModifiers(NodeWithModifiers n, ProblemReporter reporter, params Modifier.Keyword[] allowedModifiers)
	{
		validateAtMostOneOf(n, reporter, Modifier.Keyword.___003C_003EPUBLIC, Modifier.Keyword.___003C_003EPROTECTED, Modifier.Keyword.___003C_003EPRIVATE);
		validateAtMostOneOf(n, reporter, Modifier.Keyword.___003C_003EFINAL, Modifier.Keyword.___003C_003EABSTRACT);
		if (hasStrictfp)
		{
			validateAtMostOneOf(n, reporter, Modifier.Keyword.___003C_003ENATIVE, Modifier.Keyword.___003C_003ESTRICTFP);
		}
		else
		{
			allowedModifiers = removeModifierFromArray(Modifier.Keyword.___003C_003ESTRICTFP, allowedModifiers);
		}
		Iterator iterator = n.getModifiers().iterator();
		while (iterator.hasNext())
		{
			Modifier modifier = (Modifier)iterator.next();
			if (!arrayContains(allowedModifiers, modifier.getKeyword()))
			{
				reporter.report((NodeWithTokenRange)n, "'%s' is not allowed here.", modifier.getKeyword().asString());
			}
		}
	}

	
		
	
	private void validateAtMostOneOf(NodeWithModifiers t, ProblemReporter reporter, params Modifier.Keyword[] modifiers)
	{
		ArrayList arrayList = new ArrayList();
		int num = modifiers.Length;
		for (int i = 0; i < num; i++)
		{
			Modifier.Keyword keyword = modifiers[i];
			if (t.hasModifier(keyword))
			{
				((List)arrayList).add((object)keyword);
			}
		}
		if (((List)arrayList).size() > 1)
		{
			SeparatedItemStringBuilder separatedItemStringBuilder = new SeparatedItemStringBuilder("Can have only one of '", "', '", "'.");
			Iterator iterator = ((List)arrayList).iterator();
			CharSequence format = default(CharSequence);
			while (iterator.hasNext())
			{
				Modifier.Keyword keyword2 = (Modifier.Keyword)iterator.next();
				string __003Cref_003E = keyword2.asString();
				object[] args = new object[0];
				object obj = (format.___003Cref_003E = __003Cref_003E);
				separatedItemStringBuilder.append(format, args);
			}
			reporter.report((NodeWithTokenRange)t, separatedItemStringBuilder.ToString());
		}
	}

	
	
	
	private Modifier.Keyword[] removeModifierFromArray(Modifier.Keyword m, Modifier.Keyword[] allowedModifiers)
	{
		
		ArrayList arrayList = new ArrayList(Arrays.asList(allowedModifiers));
		((List)arrayList).remove((object)m);
		allowedModifiers = (Modifier.Keyword[])((List)arrayList).toArray((object[])new Modifier.Keyword[0]);
		return allowedModifiers;
	}

	
	
	private bool arrayContains(object[] items, object searchItem)
	{
		int num = items.Length;
		for (int i = 0; i < num; i++)
		{
			object obj = items[i];
			if (obj == searchItem)
			{
				return true;
			}
		}
		return false;
	}

	
	
	
	public virtual void visit(ModuleRequiresDirective n, ProblemReporter reporter)
	{
		validateModifiers(n, reporter, Modifier.Keyword.___003C_003ETRANSITIVE, Modifier.Keyword.___003C_003ESTATIC);
		base.visit(n, reporter);
	}

	
	
	
	public virtual void visit(LambdaExpr n, ProblemReporter reporter)
	{
		n.getParameters().forEach(new ___003C_003EAnon2(this, reporter));
		base.visit(n, reporter);
	}

	
	
	
	public virtual void visit(VariableDeclarationExpr n, ProblemReporter reporter)
	{
		validateModifiers(n, reporter, Modifier.Keyword.___003C_003EFINAL);
		base.visit(n, reporter);
	}

	
	
	
	public virtual void visit(MethodDeclaration n, ProblemReporter reporter)
	{
		if (n.isAbstract())
		{
			SeparatedItemStringBuilder separatedItemStringBuilder = new SeparatedItemStringBuilder("Cannot be 'abstract' and also '", "', '", "'.");
			Iterator iterator = Arrays.asList(Modifier.Keyword.___003C_003EPRIVATE, Modifier.Keyword.___003C_003ESTATIC, Modifier.Keyword.___003C_003EFINAL, Modifier.Keyword.___003C_003ENATIVE, Modifier.Keyword.___003C_003ESTRICTFP, Modifier.Keyword.___003C_003ESYNCHRONIZED).iterator();
			CharSequence format = default(CharSequence);
			while (iterator.hasNext())
			{
				Modifier.Keyword keyword = (Modifier.Keyword)iterator.next();
				if (n.hasModifier(keyword))
				{
					string __003Cref_003E = keyword.asString();
					object[] args = new object[0];
					object obj = (format.___003Cref_003E = __003Cref_003E);
					separatedItemStringBuilder.append(format, args);
				}
			}
			if (separatedItemStringBuilder.hasItems())
			{
				reporter.report(n, separatedItemStringBuilder.ToString());
			}
		}
		if (n.getParentNode().isPresent() && n.getParentNode().get() is ClassOrInterfaceDeclaration)
		{
			if (((ClassOrInterfaceDeclaration)n.getParentNode().get()).isInterface())
			{
				if (hasDefaultAndStaticInterfaceMethods)
				{
					if (hasPrivateInterfaceMethods)
					{
						validateModifiers(n, reporter, interfaceWithStaticAndDefaultAndPrivate);
					}
					else
					{
						validateModifiers(n, reporter, interfaceWithStaticAndDefault);
					}
				}
				else
				{
					validateModifiers(n, reporter, interfaceWithNothingSpecial);
				}
			}
			else
			{
				validateModifiers(n, reporter, Modifier.Keyword.___003C_003EPUBLIC, Modifier.Keyword.___003C_003EPROTECTED, Modifier.Keyword.___003C_003EPRIVATE, Modifier.Keyword.___003C_003EABSTRACT, Modifier.Keyword.___003C_003ESTATIC, Modifier.Keyword.___003C_003EFINAL, Modifier.Keyword.___003C_003ESYNCHRONIZED, Modifier.Keyword.___003C_003ENATIVE, Modifier.Keyword.___003C_003ESTRICTFP);
			}
		}
		n.getParameters().forEach(new ___003C_003EAnon1(this, reporter));
		base.visit(n, reporter);
	}

	
	
	
	public virtual void visit(FieldDeclaration n, ProblemReporter reporter)
	{
		validateModifiers(n, reporter, Modifier.Keyword.___003C_003EPUBLIC, Modifier.Keyword.___003C_003EPROTECTED, Modifier.Keyword.___003C_003EPRIVATE, Modifier.Keyword.___003C_003ESTATIC, Modifier.Keyword.___003C_003EFINAL, Modifier.Keyword.___003C_003ETRANSIENT, Modifier.Keyword.___003C_003EVOLATILE);
		base.visit(n, reporter);
	}

	
	
	
	public virtual void visit(EnumDeclaration n, ProblemReporter reporter)
	{
		if (n.isTopLevelType())
		{
			validateModifiers(n, reporter, Modifier.Keyword.___003C_003EPUBLIC, Modifier.Keyword.___003C_003ESTRICTFP);
		}
		else if (n.isNestedType())
		{
			validateModifiers(n, reporter, Modifier.Keyword.___003C_003EPUBLIC, Modifier.Keyword.___003C_003EPROTECTED, Modifier.Keyword.___003C_003EPRIVATE, Modifier.Keyword.___003C_003ESTATIC, Modifier.Keyword.___003C_003ESTRICTFP);
		}
		base.visit(n, reporter);
	}

	
	
	
	public virtual void visit(ConstructorDeclaration n, ProblemReporter reporter)
	{
		validateModifiers(n, reporter, Modifier.Keyword.___003C_003EPUBLIC, Modifier.Keyword.___003C_003EPROTECTED, Modifier.Keyword.___003C_003EPRIVATE);
		n.getParameters().forEach(new ___003C_003EAnon0(this, reporter));
		base.visit(n, reporter);
	}

	
	
	
	public virtual void visit(ClassOrInterfaceDeclaration n, ProblemReporter reporter)
	{
		if (n.isInterface())
		{
			validateInterfaceModifiers(n, reporter);
		}
		else
		{
			validateClassModifiers(n, reporter);
		}
		base.visit(n, reporter);
	}

	
	
	
	public virtual void visit(CatchClause n, ProblemReporter reporter)
	{
		validateModifiers(n.getParameter(), reporter, Modifier.Keyword.___003C_003EFINAL);
		base.visit(n, reporter);
	}

	
	
	
	public virtual void visit(AnnotationMemberDeclaration n, ProblemReporter reporter)
	{
		validateModifiers(n, reporter, Modifier.Keyword.___003C_003EPUBLIC, Modifier.Keyword.___003C_003EABSTRACT);
		base.visit(n, reporter);
	}

	
	
	
	public virtual void visit(AnnotationDeclaration n, ProblemReporter reporter)
	{
		validateInterfaceModifiers(n, reporter);
		base.visit(n, reporter);
	}

	
	
	
	
	private void lambda_0024visit_00240(ProblemReporter reporter, Parameter p)
	{
		validateModifiers(p, reporter, Modifier.Keyword.___003C_003EFINAL);
	}

	
	
	
	
	private void lambda_0024visit_00241(ProblemReporter reporter, Parameter p)
	{
		validateModifiers(p, reporter, Modifier.Keyword.___003C_003EFINAL);
	}

	
	
	
	
	private void lambda_0024visit_00242(ProblemReporter reporter, Parameter p)
	{
		validateModifiers(p, reporter, Modifier.Keyword.___003C_003EFINAL);
	}

	
	
	
	public ModifierValidator(bool hasStrictfp, bool hasDefaultAndStaticInterfaceMethods, bool hasPrivateInterfaceMethods)
	{
		interfaceWithNothingSpecial = new Modifier.Keyword[7]
		{
			Modifier.Keyword.___003C_003EPUBLIC,
			Modifier.Keyword.___003C_003EPROTECTED,
			Modifier.Keyword.___003C_003EABSTRACT,
			Modifier.Keyword.___003C_003EFINAL,
			Modifier.Keyword.___003C_003ESYNCHRONIZED,
			Modifier.Keyword.___003C_003ENATIVE,
			Modifier.Keyword.___003C_003ESTRICTFP
		};
		interfaceWithStaticAndDefault = new Modifier.Keyword[9]
		{
			Modifier.Keyword.___003C_003EPUBLIC,
			Modifier.Keyword.___003C_003EPROTECTED,
			Modifier.Keyword.___003C_003EABSTRACT,
			Modifier.Keyword.___003C_003ESTATIC,
			Modifier.Keyword.___003C_003EFINAL,
			Modifier.Keyword.___003C_003ESYNCHRONIZED,
			Modifier.Keyword.___003C_003ENATIVE,
			Modifier.Keyword.___003C_003ESTRICTFP,
			Modifier.Keyword.___003C_003EDEFAULT
		};
		interfaceWithStaticAndDefaultAndPrivate = new Modifier.Keyword[10]
		{
			Modifier.Keyword.___003C_003EPUBLIC,
			Modifier.Keyword.___003C_003EPROTECTED,
			Modifier.Keyword.___003C_003EPRIVATE,
			Modifier.Keyword.___003C_003EABSTRACT,
			Modifier.Keyword.___003C_003ESTATIC,
			Modifier.Keyword.___003C_003EFINAL,
			Modifier.Keyword.___003C_003ESYNCHRONIZED,
			Modifier.Keyword.___003C_003ENATIVE,
			Modifier.Keyword.___003C_003ESTRICTFP,
			Modifier.Keyword.___003C_003EDEFAULT
		};
		this.hasStrictfp = hasStrictfp;
		this.hasDefaultAndStaticInterfaceMethods = hasDefaultAndStaticInterfaceMethods;
		this.hasPrivateInterfaceMethods = hasPrivateInterfaceMethods;
	}

	
	
	
	
	
	public override void visit(ModuleRequiresDirective n, object reporter)
	{
		visit(n, (ProblemReporter)reporter);
	}

	
	
	
	
	
	public override void visit(LambdaExpr n, object reporter)
	{
		visit(n, (ProblemReporter)reporter);
	}

	
	
	
	
	
	public override void visit(VariableDeclarationExpr n, object reporter)
	{
		visit(n, (ProblemReporter)reporter);
	}

	
	
	
	
	
	public override void visit(MethodDeclaration n, object reporter)
	{
		visit(n, (ProblemReporter)reporter);
	}

	
	
	
	
	
	public override void visit(FieldDeclaration n, object reporter)
	{
		visit(n, (ProblemReporter)reporter);
	}

	
	
	
	
	
	public override void visit(EnumDeclaration n, object reporter)
	{
		visit(n, (ProblemReporter)reporter);
	}

	
	
	
	
	
	public override void visit(ConstructorDeclaration n, object reporter)
	{
		visit(n, (ProblemReporter)reporter);
	}

	
	
	
	
	
	public override void visit(ClassOrInterfaceDeclaration n, object reporter)
	{
		visit(n, (ProblemReporter)reporter);
	}

	
	
	
	
	
	public override void visit(CatchClause n, object reporter)
	{
		visit(n, (ProblemReporter)reporter);
	}

	
	
	
	
	
	public override void visit(AnnotationMemberDeclaration n, object reporter)
	{
		visit(n, (ProblemReporter)reporter);
	}

	
	
	
	
	
	public override void visit(AnnotationDeclaration n, object reporter)
	{
		visit(n, (ProblemReporter)reporter);
	}
}
