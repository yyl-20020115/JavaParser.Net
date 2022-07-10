using IKVM.Attributes;

namespace com.github.javaparser.ast.visitor;

public interface Visitable
{
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual object accept(GenericVisitor v, object arg);

		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual void accept(VoidVisitor v, object arg);
}
