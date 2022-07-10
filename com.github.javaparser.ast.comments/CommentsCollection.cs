using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.comments;

public class CommentsCollection
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getLineComments_00240((Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			LineComment result = lambda_0024getLineComments_00241((Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Supplier
	{
		internal ___003C_003EAnon2()
		{
		}

		public object get()
		{
			TreeSet result = lambda_0024getLineComments_00242();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		internal ___003C_003EAnon3()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getBlockComments_00243((Comment)P_0);
			
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
		internal ___003C_003EAnon4()
		{
		}

		public object apply(object P_0)
		{
			BlockComment result = lambda_0024getBlockComments_00244((Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Supplier
	{
		internal ___003C_003EAnon5()
		{
		}

		public object get()
		{
			TreeSet result = lambda_0024getBlockComments_00245();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon6 : Predicate
	{
		internal ___003C_003EAnon6()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getJavadocComments_00246((Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon7 : Function
	{
		internal ___003C_003EAnon7()
		{
		}

		public object apply(object P_0)
		{
			JavadocComment result = lambda_0024getJavadocComments_00247((Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon8 : Supplier
	{
		internal ___003C_003EAnon8()
		{
		}

		public object get()
		{
			TreeSet result = lambda_0024getJavadocComments_00248();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon9 : Predicate
	{
		private readonly CommentsCollection arg_00241;

		internal ___003C_003EAnon9(CommentsCollection P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024minus_00249(arg_00241, (Comment)P_0);
			
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

	
		private TreeSet comments;

		public virtual TreeSet getComments()
	{
		return comments;
	}

	
	
	public CommentsCollection()
	{
		
		comments = new TreeSet(Node.NODE_BY_BEGIN_POSITION);
	}

	
		
	
	public CommentsCollection(Collection commentsToCopy)
	{
		
		comments = new TreeSet(Node.NODE_BY_BEGIN_POSITION);
		comments.addAll(commentsToCopy);
	}

	
	
	[LineNumberTable(new byte[]
	{
		22, 104, 130, 113, 127, 4, 104, 130, 177, 159,
		35, 104, 130, 101
	})]
	public virtual bool contains(Comment comment)
	{
		if (!comment.hasRange())
		{
			return false;
		}
		Range range = (Range)comment.getRange().get();
		Iterator iterator = getComments().iterator();
		while (iterator.hasNext())
		{
			Comment comment2 = (Comment)iterator.next();
			if (!comment2.hasRange())
			{
				return false;
			}
			Range range2 = (Range)comment2.getRange().get();
			if (range2.___003C_003Ebegin.equals(range.___003C_003Ebegin) && range2.___003C_003Eend.___003C_003Eline == range.___003C_003Eend.___003C_003Eline && Math.abs(range2.___003C_003Eend.___003C_003Ecolumn - range.___003C_003Eend.___003C_003Ecolumn) < 2)
			{
				return true;
			}
		}
		return false;
	}

	
	
	
	private static bool lambda_0024getLineComments_00240(Comment comment)
	{
		return comment is LineComment;
	}

	
	
	
	private static LineComment lambda_0024getLineComments_00241(Comment comment)
	{
		return (LineComment)comment;
	}

	
	
	
	private static TreeSet lambda_0024getLineComments_00242()
	{
		
		TreeSet result = new TreeSet(Node.NODE_BY_BEGIN_POSITION);
		
		return result;
	}

	
	
	
	private static bool lambda_0024getBlockComments_00243(Comment comment)
	{
		return comment is BlockComment;
	}

	
	
	
	private static BlockComment lambda_0024getBlockComments_00244(Comment comment)
	{
		return (BlockComment)comment;
	}

	
	
	
	private static TreeSet lambda_0024getBlockComments_00245()
	{
		
		TreeSet result = new TreeSet(Node.NODE_BY_BEGIN_POSITION);
		
		return result;
	}

	
	
	
	private static bool lambda_0024getJavadocComments_00246(Comment comment)
	{
		return comment is JavadocComment;
	}

	
	
	
	private static JavadocComment lambda_0024getJavadocComments_00247(Comment comment)
	{
		return (JavadocComment)comment;
	}

	
	
	
	private static TreeSet lambda_0024getJavadocComments_00248()
	{
		
		TreeSet result = new TreeSet(Node.NODE_BY_BEGIN_POSITION);
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static bool lambda_0024minus_00249(CommentsCollection other, Comment comment)
	{
		return (!other.contains(comment)) ? true : false;
	}

	
		
	public virtual Set getLineComments()
	{
		return (Set)comments.stream().filter(new ___003C_003EAnon0()).map(new ___003C_003EAnon1())
			.collect(Collectors.toCollection(new ___003C_003EAnon2()));
	}

	
		
	public virtual Set getBlockComments()
	{
		return (Set)comments.stream().filter(new ___003C_003EAnon3()).map(new ___003C_003EAnon4())
			.collect(Collectors.toCollection(new ___003C_003EAnon5()));
	}

	
		
	public virtual Set getJavadocComments()
	{
		return (Set)comments.stream().filter(new ___003C_003EAnon6()).map(new ___003C_003EAnon7())
			.collect(Collectors.toCollection(new ___003C_003EAnon8()));
	}

	
	
	
	public virtual void addComment(Comment comment)
	{
		comments.add(comment);
	}

	
	
	public virtual int size()
	{
		int result = comments.size();
		
		return result;
	}

	
	
	
	public virtual CommentsCollection minus(CommentsCollection other)
	{
		CommentsCollection commentsCollection = new CommentsCollection();
		commentsCollection.comments.addAll((Collection)comments.stream().filter(new ___003C_003EAnon9(other)).collect(Collectors.toList()));
		return commentsCollection;
	}

	
	
	public virtual CommentsCollection copy()
	{
		CommentsCollection result = new CommentsCollection(comments);
		
		return result;
	}
}
