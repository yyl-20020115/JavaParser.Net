

namespace com.github.javaparser.ast.visitor;

public interface Visitable
{
		
	virtual object accept(GenericVisitor v, object arg);

		
	virtual void accept(VoidVisitor v, object arg);
}
