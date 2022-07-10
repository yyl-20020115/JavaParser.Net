using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.comments;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser;

internal class CommentsInserter
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024insertComments_00240((Node)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024insertComments_00241((Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		private readonly Node arg_00241;

		private readonly bool arg_00242;

		internal ___003C_003EAnon2(Node P_0, bool P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024insertComments_00242(arg_00241, arg_00242, (Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		internal ___003C_003EAnon3()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024attributeLineCommentsOnSameLine_00243((Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		internal ___003C_003EAnon4()
		{
		}

		public bool test(object P_0)
		{
			bool result = ((Comment)P_0).isLineComment();
			
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

	
	private sealed class ___003C_003EAnon5 : Consumer
	{
		private readonly CommentsInserter arg_00241;

		private readonly List arg_00242;

		private readonly List arg_00243;

		internal ___003C_003EAnon5(CommentsInserter P_0, List P_1, List P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024attributeLineCommentsOnSameLine_00246(arg_00242, arg_00243, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Predicate
	{
		internal ___003C_003EAnon6()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024null_00244((Node)P_0);
			
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

	
	private sealed class ___003C_003EAnon7 : Consumer
	{
		private readonly CommentsInserter arg_00241;

		private readonly Comment arg_00242;

		private readonly List arg_00243;

		internal ___003C_003EAnon7(CommentsInserter P_0, Comment P_1, List P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_00245(arg_00242, arg_00243, (Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private ParserConfiguration configuration;

	
	private void insertComments(CompilationUnit cu, TreeSet comments)
	{
		if (!comments.isEmpty())
		{
			List childNodes = cu.getChildNodes();
			Comment comment = (Comment)comments.iterator().next();
			if (cu.getPackageDeclaration().isPresent() && (childNodes.isEmpty() || PositionUtils.areInOrder(comment, (Node)cu.getPackageDeclaration().get())))
			{
				cu.setComment(comment);
				comments.remove(comment);
			}
		}
	}

	internal virtual void insertComments(Node node, TreeSet commentsToAttribute)
	{
		if (commentsToAttribute.isEmpty())
		{
			return;
		}
		if (node is CompilationUnit)
		{
			insertComments((CompilationUnit)node, commentsToAttribute);
		}
		List list = (List)node.getChildNodes().stream().filter(new ___003C_003EAnon0())
			.collect(Collectors.toList());
		int num = ((!configuration.isIgnoreAnnotationsWhenAttributingComments()) ? 1 : 0);
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			Node node2 = (Node)iterator.next();
			
			TreeSet treeSet = new TreeSet(Node.NODE_BY_BEGIN_POSITION);
			treeSet.addAll((Collection)commentsToAttribute.stream().filter(new ___003C_003EAnon1()).filter(new ___003C_003EAnon2(node2, (byte)num != 0))
				.collect(Collectors.toList()));
			commentsToAttribute.removeAll(treeSet);
			insertComments(node2, treeSet);
		}
		attributeLineCommentsOnSameLine(commentsToAttribute, list);
		if (!commentsToAttribute.isEmpty() && commentIsOnNextLine(node, (Comment)commentsToAttribute.first()))
		{
			node.setComment((Comment)commentsToAttribute.first());
			commentsToAttribute.remove(commentsToAttribute.first());
		}
		Comment comment = null;
		LinkedList linkedList = new LinkedList();
		LinkedList linkedList2 = new LinkedList();
		((List)linkedList2).addAll((Collection)list);
		commentsToAttribute.removeAll(linkedList);
		((List)linkedList2).addAll((Collection)commentsToAttribute);
		PositionUtils.sortByBeginPosition(linkedList2, configuration.isIgnoreAnnotationsWhenAttributingComments());
		Iterator iterator2 = ((List)linkedList2).iterator();
		while (iterator2.hasNext())
		{
			Node node3 = (Node)iterator2.next();
			if (node3 is Comment)
			{
				comment = (Comment)node3;
				if (!comment.isOrphan())
				{
					comment = null;
				}
			}
			else if (comment != null && !node3.getComment().isPresent() && (!configuration.isDoNotAssignCommentsPrecedingEmptyLines() || !thereAreLinesBetween(comment, node3)))
			{
				node3.setComment(comment);
				((List)linkedList).add((object)comment);
				comment = null;
			}
		}
		commentsToAttribute.removeAll(linkedList);
		iterator2 = commentsToAttribute.iterator();
		while (iterator2.hasNext())
		{
			Comment comment2 = (Comment)iterator2.next();
			if (comment2.isOrphan())
			{
				node.addOrphanComment(comment2);
			}
		}
	}

	
	private void attributeLineCommentsOnSameLine(TreeSet commentsToAttribute, List children)
	{
		LinkedList linkedList = new LinkedList();
		commentsToAttribute.stream().filter(new ___003C_003EAnon3()).filter(new ___003C_003EAnon4())
			.forEach(new ___003C_003EAnon5(this, children, linkedList));
		commentsToAttribute.removeAll(linkedList);
	}

		private bool commentIsOnNextLine(Node a, Comment c)
	{
		if (!c.hasRange() || !a.hasRange())
		{
			return false;
		}
		return ((Range)c.getRange().get()).___003C_003Eend.___003C_003Eline + 1 == ((Range)a.getRange().get()).___003C_003Ebegin.___003C_003Eline;
	}

	
	
	private bool thereAreLinesBetween(Node a, Node b)
	{
		if (!a.hasRange() || !b.hasRange())
		{
			return true;
		}
		if (!PositionUtils.areInOrder(a, b))
		{
			bool result = thereAreLinesBetween(b, a);
			
			return result;
		}
		int __003C_003Eline = ((Position)a.getEnd().get()).___003C_003Eline;
		return ((Position)b.getBegin().get()).___003C_003Eline > __003C_003Eline + 1;
	}

	
	private bool attributeLineCommentToNodeOrChild(Node node, LineComment lineComment)
	{
		if (!node.hasRange() || !lineComment.hasRange())
		{
			return false;
		}
		if (((Position)node.getBegin().get()).___003C_003Eline == ((Position)lineComment.getBegin().get()).___003C_003Eline && !node.getComment().isPresent())
		{
			if (!(node is Comment))
			{
				node.setComment(lineComment);
			}
			return true;
		}
		LinkedList linkedList = new LinkedList();
		((List)linkedList).addAll((Collection)node.getChildNodes());
		PositionUtils.sortByBeginPosition(linkedList);
		Collections.reverse(linkedList);
		Iterator iterator = ((List)linkedList).iterator();
		while (iterator.hasNext())
		{
			Node node2 = (Node)iterator.next();
			if (attributeLineCommentToNodeOrChild(node2, lineComment))
			{
				return true;
			}
		}
		return false;
	}

	
	
	
	private static bool lambda_0024insertComments_00240(Node n)
	{
		return !(n is Modifier);
	}

	private static bool lambda_0024insertComments_00241(Comment comment)
	{
		bool result = comment.hasRange();
		
		return result;
	}

	

	private static bool lambda_0024insertComments_00242(Node child, bool attributeToAnnotation, Comment comment)
	{
		bool result = PositionUtils.nodeContains(child, comment, (!attributeToAnnotation) ? true : false);
		
		return result;
	}

	private static bool lambda_0024attributeLineCommentsOnSameLine_00243(Comment comment)
	{
		bool result = comment.hasRange();
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024attributeLineCommentsOnSameLine_00246(List children, List attributedComments, Comment comment)
	{
		children.stream().filter(new ___003C_003EAnon6()).forEach(new ___003C_003EAnon7(this, comment, attributedComments));
	}
	
	private static bool lambda_0024null_00244(Node child)
	{
		bool result = child.hasRange();
		
		return result;
	}

	
	private void lambda_0024null_00245(Comment comment, List attributedComments, Node child)
	{
		Range range = (Range)comment.getRange().get();
		Range range2 = (Range)child.getRange().get();
		if (range2.___003C_003Eend.___003C_003Eline == range.___003C_003Ebegin.___003C_003Eline && attributeLineCommentToNodeOrChild(child, comment.asLineComment()))
		{
			attributedComments.add(comment);
		}
	}
	
	internal CommentsInserter(ParserConfiguration configuration)
	{
		this.configuration = configuration;
	}
}
