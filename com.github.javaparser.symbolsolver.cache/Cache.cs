using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.symbolsolver.cache;

public interface Cache
{
		 void put(object obj1, object obj2);

		 Optional get(object obj);

		 void remove(object obj);

	 void removeAll();

		 bool contains(object obj);

	 long size();

	 bool isEmpty();
}
