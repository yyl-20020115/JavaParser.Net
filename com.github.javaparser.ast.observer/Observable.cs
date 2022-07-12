

namespace com.github.javaparser.ast.observer;

public interface Observable
{
	
	 void register(AstObserver observer);

	
	 void unregister(AstObserver observer);

	
	 bool isRegistered(AstObserver observer);
}
