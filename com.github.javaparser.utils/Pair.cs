using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.utils;

public class Pair
{
		internal object ___003C_003Ea;

		internal object ___003C_003Eb;

	
	public object a
	{
		
		get
		{
			return ___003C_003Ea;
		}
		
		private set
		{
			___003C_003Ea = value;
		}
	}

	
	public object b
	{
		
		get
		{
			return ___003C_003Eb;
		}
		
		private set
		{
			___003C_003Eb = value;
		}
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public Pair(object a, object b)
	{
		___003C_003Ea = a;
		___003C_003Eb = b;
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
		Pair pair = (Pair)o;
		if (!Objects.equals(___003C_003Ea, pair.___003C_003Ea))
		{
			return false;
		}
		if (!Objects.equals(___003C_003Eb, pair.___003C_003Eb))
		{
			return false;
		}
		return true;
	}

	
	
	public override int GetHashCode()
	{
		int num = ((___003C_003Ea != null) ? Object.instancehelper_hashCode(___003C_003Ea) : 0);
		return 31 * num + ((___003C_003Eb != null) ? Object.instancehelper_hashCode(___003C_003Eb) : 0);
	}

	
	
	public override string ToString()
	{
		string result = CodeGenerationUtils.f("<%s, %s>", ___003C_003Ea, ___003C_003Eb);
		
		return result;
	}
}
