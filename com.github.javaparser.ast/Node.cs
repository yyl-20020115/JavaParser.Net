using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.printer;
using com.github.javaparser.printer.configuration;
using com.github.javaparser.resolution;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast;


public abstract class Node :  Cloneable.__Interface, HasParentNode, com.github.javaparser.ast.observer.Observable, Visitable, NodeWithRange, NodeWithTokenRange
{
	
		
	internal sealed class _1 : DataKey
	{
		
		
		internal _1()
		{
		}
	}

	
		
	internal sealed class _2 : DataKey
	{
		
		
		internal _2()
		{
		}
	}

	
		
	internal sealed class _3 : DataKey
	{
		
		
		internal _3()
		{
		}
	}

	
		
	internal sealed class _4 : DataKey
	{
		
		
		internal _4()
		{
		}
	}

	
	
	
	
	internal class _5
	{
		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024ObserverRegistrationMode;

		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024TreeTraversal;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(new byte[]
		{
			162,
			188,
			byte.MaxValue,
			160,
			126,
			159,
			82
		})]
		static _5()
		{
			_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024TreeTraversal = new int[(nint)TreeTraversal.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024TreeTraversal[TreeTraversal.___003C_003EBREADTHFIRST.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024TreeTraversal[TreeTraversal.___003C_003EPOSTORDER.ordinal()] = 2;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_005c;
			}
			goto IL_0062;
			IL_005c:
			
			goto IL_0062;
			IL_0062:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024TreeTraversal[TreeTraversal.___003C_003EPREORDER.ordinal()] = 3;
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0085;
			}
			goto IL_008b;
			IL_0085:
			
			goto IL_008b;
			IL_008b:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024TreeTraversal[TreeTraversal.___003C_003EDIRECT_CHILDREN.ordinal()] = 4;
			}
			catch (System.Exception x4)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x4, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00ae;
			}
			goto IL_00b4;
			IL_00ae:
			
			goto IL_00b4;
			IL_00b4:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024TreeTraversal[TreeTraversal.___003C_003EPARENTS.ordinal()] = 5;
			}
			catch (System.Exception x5)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x5, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00d7;
			}
			goto IL_00dd;
			IL_00d7:
			
			goto IL_00dd;
			IL_00dd:
			_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024ObserverRegistrationMode = new int[(nint)ObserverRegistrationMode.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024ObserverRegistrationMode[ObserverRegistrationMode.___003C_003EJUST_THIS_NODE.ordinal()] = 1;
			}
			catch (System.Exception x6)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x6, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0110;
			}
			goto IL_0116;
			IL_0110:
			
			goto IL_0116;
			IL_0116:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024ObserverRegistrationMode[ObserverRegistrationMode.___003C_003ETHIS_NODE_AND_EXISTING_DESCENDANTS.ordinal()] = 2;
			}
			catch (System.Exception x7)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x7, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0139;
			}
			goto IL_013f;
			IL_0139:
			
			goto IL_013f;
			IL_013f:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024ObserverRegistrationMode[ObserverRegistrationMode.___003C_003ESELF_PROPAGATING.ordinal()] = 3;
				return;
			}
			catch (System.Exception x8)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x8, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			
		}

		_5()
		{
			throw null;
		}
	}

		public class BreadthFirstIterator :  Iterator
	{
		
				private Queue queue;

		
		
		
		public BreadthFirstIterator(Node node)
		{
			queue = new LinkedList();
			queue.add(node);
		}

		
		
		public virtual Node next()
		{
			Node node = (Node)queue.remove();
			queue.addAll(node.getChildNodes());
			return node;
		}

		
		
		public virtual bool hasNext()
		{
			return (!queue.isEmpty()) ? true : false;
		}

		
		
		
		
		public virtual object _003Cbridge_003Enext()
		{
			Node result = next();
			
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void remove()
		{
			Iterator._003Cdefault_003Eremove(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}

		object Iterator.Iterator_003A_003Anext()
		{
			return _003Cbridge_003Enext();
		}
	}

		public class DirectChildrenIterator :  Iterator
	{
		
				private Iterator childrenIterator;

		
		
		
		public DirectChildrenIterator(Node node)
		{
			childrenIterator = node.getChildNodes().iterator();
		}

		
		
		public virtual Node next()
		{
			return (Node)childrenIterator.next();
		}

		
		
		public virtual bool hasNext()
		{
			bool result = childrenIterator.hasNext();
			
			return result;
		}

		
		
		
		
		public virtual object _003Cbridge_003Enext()
		{
			Node result = next();
			
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void remove()
		{
			Iterator._003Cdefault_003Eremove(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}

		object Iterator.Iterator_003A_003Anext()
		{
			return _003Cbridge_003Enext();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	public class ObserverRegistrationMode : java.lang.Enum
	{
		[Serializable]
		
		public enum __Enum
		{
			JUST_THIS_NODE,
			THIS_NODE_AND_EXISTING_DESCENDANTS,
			SELF_PROPAGATING
		}

		
		internal static ObserverRegistrationMode ___003C_003EJUST_THIS_NODE;

		
		internal static ObserverRegistrationMode ___003C_003ETHIS_NODE_AND_EXISTING_DESCENDANTS;

		
		internal static ObserverRegistrationMode ___003C_003ESELF_PROPAGATING;

		
		private static ObserverRegistrationMode[] _0024VALUES;

		
		public static ObserverRegistrationMode JUST_THIS_NODE
		{
			
			get
			{
				return ___003C_003EJUST_THIS_NODE;
			}
		}

		
		public static ObserverRegistrationMode THIS_NODE_AND_EXISTING_DESCENDANTS
		{
			
			get
			{
				return ___003C_003ETHIS_NODE_AND_EXISTING_DESCENDANTS;
			}
		}

		
		public static ObserverRegistrationMode SELF_PROPAGATING
		{
			
			get
			{
				return ___003C_003ESELF_PROPAGATING;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		
		public static ObserverRegistrationMode[] values()
		{
			return (ObserverRegistrationMode[])_0024VALUES.Clone();
		}

		
				[MethodParameters(new Modifiers[]
		{
			Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private ObserverRegistrationMode(string _0024enum_0024name, int _0024enum_0024ordinal)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			GC.KeepAlive(this);
		}

		
		
		
		public static ObserverRegistrationMode valueOf(string name)
		{
			return (ObserverRegistrationMode)java.lang.Enum.valueOf(ClassLiteral<ObserverRegistrationMode>.Value, name);
		}

		
		static ObserverRegistrationMode()
		{
			___003C_003EJUST_THIS_NODE = new ObserverRegistrationMode("JUST_THIS_NODE", 0);
			___003C_003ETHIS_NODE_AND_EXISTING_DESCENDANTS = new ObserverRegistrationMode("THIS_NODE_AND_EXISTING_DESCENDANTS", 1);
			___003C_003ESELF_PROPAGATING = new ObserverRegistrationMode("SELF_PROPAGATING", 2);
			_0024VALUES = new ObserverRegistrationMode[3] { ___003C_003EJUST_THIS_NODE, ___003C_003ETHIS_NODE_AND_EXISTING_DESCENDANTS, ___003C_003ESELF_PROPAGATING };
		}
	}

		public class ParentsVisitor :  Iterator
	{
		private Node node;

		
		
		
		public ParentsVisitor(Node node)
		{
			this.node = node;
		}

		
		
		public virtual Node next()
		{
			node = (Node)node.getParentNode().orElse(null);
			return node;
		}

		
		
		public virtual bool hasNext()
		{
			bool result = node.getParentNode().isPresent();
			
			return result;
		}

		
		
		
		
		public virtual object _003Cbridge_003Enext()
		{
			Node result = next();
			
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void remove()
		{
			Iterator._003Cdefault_003Eremove(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}

		object Iterator.Iterator_003A_003Anext()
		{
			return _003Cbridge_003Enext();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	public class Parsedness : java.lang.Enum
	{
		[Serializable]
		
		public enum __Enum
		{
			PARSED,
			UNPARSABLE
		}

		
		internal static Parsedness ___003C_003EPARSED;

		
		internal static Parsedness ___003C_003EUNPARSABLE;

		
		private static Parsedness[] _0024VALUES;

		
		public static Parsedness PARSED
		{
			
			get
			{
				return ___003C_003EPARSED;
			}
		}

		
		public static Parsedness UNPARSABLE
		{
			
			get
			{
				return ___003C_003EUNPARSABLE;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				[MethodParameters(new Modifiers[]
		{
			Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private Parsedness(string _0024enum_0024name, int _0024enum_0024ordinal)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			GC.KeepAlive(this);
		}

		
		
		public static Parsedness[] values()
		{
			return (Parsedness[])_0024VALUES.Clone();
		}

		
		
		
		public static Parsedness valueOf(string name)
		{
			return (Parsedness)java.lang.Enum.valueOf(ClassLiteral<Parsedness>.Value, name);
		}

		
		static Parsedness()
		{
			___003C_003EPARSED = new Parsedness("PARSED", 0);
			___003C_003EUNPARSABLE = new Parsedness("UNPARSABLE", 1);
			_0024VALUES = new Parsedness[2] { ___003C_003EPARSED, ___003C_003EUNPARSABLE };
		}
	}

		public class PostOrderIterator :  Iterator
	{
		
				private Stack nodesStack;

		
				private Stack cursorStack;

		
		private Node root;

		private bool m_hasNext;

		
		
		
		public PostOrderIterator(Node root)
		{
			nodesStack = new Stack();
			cursorStack = new Stack();
			this.m_hasNext = true;
			this.root = root;
			fillStackToLeaf(root);
		}

		
		
		
		private void fillStackToLeaf(Node node)
		{
			while (true)
			{
				List childNodes = node.getChildNodes();
				if (childNodes.isEmpty())
				{
					break;
				}
				nodesStack.push(childNodes);
				cursorStack.push(Integer.valueOf(0));
				node = (Node)childNodes.get(0);
			}
		}

		
		
		private Node nextFromLevel()
		{
			List list = (List)nodesStack.peek();
			int num = ((Integer)cursorStack.pop()).intValue();
			cursorStack.push(Integer.valueOf(num + 1));
			return (Node)list.get(num);
		}

		
		[LineNumberTable(new byte[]
		{
			163, 223, 113, 118, 106, 99, 109, 103, 137, 108,
			108, 119, 104, 137
		})]
		public virtual Node next()
		{
			List list = (List)nodesStack.peek();
			int num = ((Integer)cursorStack.peek()).intValue();
			if (num < list.size())
			{
				Node node = (Node)list.get(num);
				fillStackToLeaf(node);
				Node result = nextFromLevel();
				
				return result;
			}
			nodesStack.pop();
			cursorStack.pop();
			this.m_hasNext = ((!nodesStack.empty()) ? true : false);
			if (this.m_hasNext)
			{
				Node result2 = nextFromLevel();
				
				return result2;
			}
			return root;
		}

		public virtual bool hasNext()
		{
			return this.m_hasNext;
		}

		
		
		
		
		public virtual object _003Cbridge_003Enext()
		{
			Node result = next();
			
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void remove()
		{
			Iterator._003Cdefault_003Eremove(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}

		object Iterator.Iterator_003A_003Anext()
		{
			return _003Cbridge_003Enext();
		}
	}

		public class PreOrderIterator :  Iterator
	{
		
				private Stack stack;

		
		
		
		public PreOrderIterator(Node node)
		{
			stack = new Stack();
			stack.add(node);
		}

		
		
		public virtual Node next()
		{
			Node node = (Node)stack.pop();
			List childNodes = node.getChildNodes();
			for (int i = childNodes.size() - 1; i >= 0; i += -1)
			{
				stack.add(childNodes.get(i));
			}
			return node;
		}

		
		
		public virtual bool hasNext()
		{
			return (!stack.isEmpty()) ? true : false;
		}

		
		
		
		
		public virtual object _003Cbridge_003Enext()
		{
			Node result = next();
			
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void remove()
		{
			Iterator._003Cdefault_003Eremove(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}

		object Iterator.Iterator_003A_003Anext()
		{
			return _003Cbridge_003Enext();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	public class TreeTraversal : java.lang.Enum
	{
		[Serializable]
		
		public enum __Enum
		{
			PREORDER,
			BREADTHFIRST,
			POSTORDER,
			PARENTS,
			DIRECT_CHILDREN
		}

		
		internal static TreeTraversal ___003C_003EPREORDER;

		
		internal static TreeTraversal ___003C_003EBREADTHFIRST;

		
		internal static TreeTraversal ___003C_003EPOSTORDER;

		
		internal static TreeTraversal ___003C_003EPARENTS;

		
		internal static TreeTraversal ___003C_003EDIRECT_CHILDREN;

		
		private static TreeTraversal[] _0024VALUES;

		
		public static TreeTraversal PREORDER
		{
			
			get
			{
				return ___003C_003EPREORDER;
			}
		}

		
		public static TreeTraversal BREADTHFIRST
		{
			
			get
			{
				return ___003C_003EBREADTHFIRST;
			}
		}

		
		public static TreeTraversal POSTORDER
		{
			
			get
			{
				return ___003C_003EPOSTORDER;
			}
		}

		
		public static TreeTraversal PARENTS
		{
			
			get
			{
				return ___003C_003EPARENTS;
			}
		}

		
		public static TreeTraversal DIRECT_CHILDREN
		{
			
			get
			{
				return ___003C_003EDIRECT_CHILDREN;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		
		public static TreeTraversal[] values()
		{
			return (TreeTraversal[])_0024VALUES.Clone();
		}

		
				[MethodParameters(new Modifiers[]
		{
			Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private TreeTraversal(string _0024enum_0024name, int _0024enum_0024ordinal)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			GC.KeepAlive(this);
		}

		
		
		
		public static TreeTraversal valueOf(string name)
		{
			return (TreeTraversal)java.lang.Enum.valueOf(ClassLiteral<TreeTraversal>.Value, name);
		}

		
		static TreeTraversal()
		{
			___003C_003EPREORDER = new TreeTraversal("PREORDER", 0);
			___003C_003EBREADTHFIRST = new TreeTraversal("BREADTHFIRST", 1);
			___003C_003EPOSTORDER = new TreeTraversal("POSTORDER", 2);
			___003C_003EPARENTS = new TreeTraversal("PARENTS", 3);
			___003C_003EDIRECT_CHILDREN = new TreeTraversal("DIRECT_CHILDREN", 4);
			_0024VALUES = new TreeTraversal[5] { ___003C_003EPREORDER, ___003C_003EBREADTHFIRST, ___003C_003EPOSTORDER, ___003C_003EPARENTS, ___003C_003EDIRECT_CHILDREN };
		}
	}

	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Printer result = lambda_0024getPrinter_00241((CompilationUnit)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly PrinterConfiguration arg_00241;

		internal ___003C_003EAnon1(PrinterConfiguration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Printer result = lambda_0024getPrinter_00242(arg_00241, (CompilationUnit)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon2(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.add((Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly Node arg_00241;

		private readonly Node arg_00242;

		internal ___003C_003EAnon3(Node P_0, Node P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024setParentNode_00243(arg_00242, (AstObserver)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon4(Class P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024tryAddImportToParentCompilationUnit_00244(arg_00241, (CompilationUnit)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Consumer
	{
		internal ___003C_003EAnon5()
		{
		}

		public void accept(object P_0)
		{
			((Node)P_0).remove();
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Consumer
	{
		private readonly Node arg_00241;

		private readonly ObservableProperty arg_00242;

		private readonly object arg_00243;

		private readonly object arg_00244;

		internal ___003C_003EAnon6(Node P_0, ObservableProperty P_1, object P_2, object P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024notifyPropertyChange_00245(arg_00242, arg_00243, arg_00244, (AstObserver)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : Consumer
	{
		private readonly AstObserver arg_00241;

		internal ___003C_003EAnon7(AstObserver P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024registerForSubtree_00246(arg_00241, (Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon8 : Function
	{
		internal ___003C_003EAnon8()
		{
		}

		public object apply(object P_0)
		{
			SymbolResolver result = lambda_0024getSymbolResolver_00247((CompilationUnit)P_0);
			
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

	
	private sealed class ___003C_003EAnon9 : Supplier
	{
		internal ___003C_003EAnon9()
		{
		}

		public object get()
		{
			IllegalStateException result = lambda_0024getSymbolResolver_00248();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon10 : Iterable
	{
		private readonly Node arg_00241;

		private readonly TreeTraversal arg_00242;

		internal ___003C_003EAnon10(Node P_0, TreeTraversal P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public Iterator iterator()
		{
			Iterator result = arg_00241.lambda_0024treeIterable_00249(arg_00242);
			
			return result;
		}

		
		public void forEach(Consumer P_0)
		{
			Iterable._003Cdefault_003EforEach(this, P_0);
		}

		
		public Spliterator spliterator()
		{
			return Iterable._003Cdefault_003Espliterator(this);
		}
	}

	
	private sealed class ___003C_003EAnon11 : Consumer
	{
		private readonly Class arg_00241;

		private readonly Consumer arg_00242;

		internal ___003C_003EAnon11(Class P_0, Consumer P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024walk_002410(arg_00241, arg_00242, (Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon12 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon12(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.add((Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon13 : Consumer
	{
		private readonly Class arg_00241;

		private readonly List arg_00242;

		internal ___003C_003EAnon13(Class P_0, List P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024findAll_002411(arg_00241, arg_00242, (Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon14 : Consumer
	{
		private readonly Predicate arg_00241;

		private readonly List arg_00242;

		internal ___003C_003EAnon14(Predicate P_0, List P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024findAll_002412(arg_00241, arg_00242, (Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon15 : Function
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon15(Class P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Optional result = lambda_0024findFirst_002413(arg_00241, (Node)P_0);
			
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

	
	private sealed class ___003C_003EAnon16 : Function
	{
		private readonly Class arg_00241;

		private readonly Predicate arg_00242;

		internal ___003C_003EAnon16(Class P_0, Predicate P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			Optional result = lambda_0024findFirst_002414(arg_00241, arg_00242, (Node)P_0);
			
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

	
	private sealed class ___003C_003EAnon17 : Predicate
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon17(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024isAncestorOf_002415(arg_00241, (Node)P_0);
			
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

	
	private sealed class ___003C_003EAnon18 : Comparator
	{
		internal ___003C_003EAnon18()
		{
		}

		public int compare(object P_0, object P_1)
		{
			int result = lambda_0024static_00240((NodeWithRange)P_0, (NodeWithRange)P_1);
			
			return result;
		}

		
		public Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		
		public bool equals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		
		public Comparator reversed()
		{
			return Comparator._003Cdefault_003Ereversed(this);
		}

		
		public Comparator thenComparing(Function P_0, Comparator P_1)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
		}

		
		public Comparator thenComparing(Function P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		
		public Comparator thenComparingInt(ToIntFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
		}

		
		public Comparator thenComparingLong(ToLongFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
		}

		
		public Comparator thenComparingDouble(ToDoubleFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
		}
	}

		public static Comparator NODE_BY_BEGIN_POSITION;

	private const int LEVELS_TO_EXPLORE = 3;

	internal static PrinterConfiguration ___003C_003EprettyPrinterNoCommentsConfiguration;

	[InternalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/InternalProperty;"
	})]
	private Range range;

	[InternalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/InternalProperty;"
	})]
	private TokenRange tokenRange;

	[InternalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/InternalProperty;"
	})]
	private Node parentNode;

		[InternalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/InternalProperty;"
	})]
	private ArrayList childNodes;

		[InternalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/InternalProperty;"
	})]
	private ArrayList orphanComments;

		[InternalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/InternalProperty;"
	})]
	private IdentityHashMap data;

	[OptionalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/OptionalProperty;"
	})]
	private Comment comment;

		[InternalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/InternalProperty;"
	})]
	private ArrayList observers;

	[InternalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/InternalProperty;"
	})]
	private Parsedness parsed;

	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public const int ABSOLUTE_BEGIN_LINE = -1;

	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public const int ABSOLUTE_END_LINE = -2;

		internal static DataKey ___003C_003ESYMBOL_RESOLVER_KEY;

		internal static DataKey ___003C_003ELINE_SEPARATOR_KEY;

		internal static DataKey ___003C_003EPRINTER_KEY;

		internal static DataKey ___003C_003EPHANTOM_KEY;

	
	protected internal static PrinterConfiguration prettyPrinterNoCommentsConfiguration
	{
		
		get
		{
			return ___003C_003EprettyPrinterNoCommentsConfiguration;
		}
	}

	
	public static DataKey SYMBOL_RESOLVER_KEY
	{
		
		get
		{
			return ___003C_003ESYMBOL_RESOLVER_KEY;
		}
	}

	
	public static DataKey LINE_SEPARATOR_KEY
	{
		
		get
		{
			return ___003C_003ELINE_SEPARATOR_KEY;
		}
	}

	
	protected internal static DataKey PRINTER_KEY
	{
		
		get
		{
			return ___003C_003EPRINTER_KEY;
		}
	}

	
	protected internal static DataKey PHANTOM_KEY
	{
		
		get
		{
			return ___003C_003EPHANTOM_KEY;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
		
	
	public virtual void tryAddImportToParentCompilationUnit(Class clazz)
	{
		findAncestor(new Class[1] { ClassLiteral<CompilationUnit>.Value }).ifPresent(new ___003C_003EAnon4(clazz));
	}

	
	
	
	public virtual bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (comment != null && node == comment)
		{
			removeComment();
			return true;
		}
		return false;
	}

	
		
	public virtual Optional findCompilationUnit()
	{
		Node node = findRootNode();
		if (node is CompilationUnit)
		{
			Optional result = Optional.of((CompilationUnit)node);
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual Optional findFirst(Class nodeType, Predicate predicate)
	{
		Optional result = findFirst(TreeTraversal.___003C_003EPREORDER, new ___003C_003EAnon16(nodeType, predicate));
		
		return result;
	}

	
		
	
	public virtual Optional findFirst(Class nodeType)
	{
		Optional result = findFirst(TreeTraversal.___003C_003EPREORDER, new ___003C_003EAnon15(nodeType));
		
		return result;
	}

	
		
	[LineNumberTable(new byte[]
	{
		162,
		byte.MaxValue,
		102,
		124
	})]
	public unsafe virtual List findAll(Class nodeType)
	{
		ArrayList arrayList = new ArrayList();
		
		walk(nodeType, new ___003C_003EAnon12(arrayList));
		return arrayList;
	}

	
	
	public virtual bool remove()
	{
		if (parentNode == null)
		{
			return false;
		}
		bool result = parentNode.remove(this);
		
		return result;
	}

	
	
	public sealed override string ToString()
	{
		if (containsData(___003C_003ELINE_SEPARATOR_KEY))
		{
			Printer printer = getPrinter();
			LineSeparator lineEndingStyleOrDefault = getLineEndingStyleOrDefault(LineSeparator.___003C_003ESYSTEM);
			PrinterConfiguration configuration = printer.getConfiguration();
			configuration.addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EEND_OF_LINE_CHARACTER, lineEndingStyleOrDefault.asRawString()));
			printer.setConfiguration(configuration);
			string result = printer.print(this);
			
			return result;
		}
		string result2 = getPrinter().print(this);
		
		return result2;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional findAncestor(Predicate P_0, Class[] P_1)
	{
		return HasParentNode._003Cdefault_003EfindAncestor(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasRange()
	{
		return NodeWithRange._003Cdefault_003EhasRange(this);
	}

	
		
	public virtual Optional getRange()
	{
		Optional result = Optional.ofNullable(range);
		
		return result;
	}

	
	
	
	public virtual Node setTokenRange(TokenRange tokenRange)
	{
		this.tokenRange = tokenRange;
		if (tokenRange == null || !tokenRange.getBegin().hasRange() || !tokenRange.getEnd().hasRange())
		{
			range = null;
		}
		else
		{
			range = new Range(((Range)tokenRange.getBegin().getRange().get()).___003C_003Ebegin, ((Range)tokenRange.getEnd().getRange().get()).___003C_003Eend);
		}
		return this;
	}

	
	
	protected internal virtual Printer createDefaultPrinter()
	{
		Printer result = createDefaultPrinter(getDefaultPrinterConfiguration());
		
		return result;
	}

	
	
	
	protected internal virtual Printer createDefaultPrinter(PrinterConfiguration configuration)
	{
		DefaultPrettyPrinter result = new DefaultPrettyPrinter(configuration);
		
		return result;
	}

	
	
	protected internal virtual PrinterConfiguration getDefaultPrinterConfiguration()
	{
		DefaultPrinterConfiguration result = new DefaultPrinterConfiguration();
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void notifyPropertyChange(ObservableProperty property, object oldValue, object newValue)
	{
		observers.forEach(new ___003C_003EAnon6(this, property, oldValue, newValue));
	}

	
	
	
	public virtual Node setComment(Comment comment)
	{
		if (this.comment == comment)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ECOMMENT, this.comment, comment);
		if (this.comment != null)
		{
			this.comment.setCommentedNode(null);
		}
		this.comment = comment;
		if (comment != null)
		{
			this.comment.setCommentedNode(this);
		}
		return this;
	}

	
		
	
	public virtual bool containsData(DataKey key)
	{
		if (data == null)
		{
			return false;
		}
		bool result = data.containsKey(key);
		
		return result;
	}

	
	
	protected internal virtual Printer getPrinter()
	{
		return (Printer)findCompilationUnit().map(new ___003C_003EAnon0()).orElse(createDefaultPrinter());
	}

	
	
	
	public virtual LineSeparator getLineEndingStyleOrDefault(LineSeparator defaultLineSeparator)
	{
		if (getLineEndingStyle().isStandardEol())
		{
			LineSeparator lineEndingStyle = getLineEndingStyle();
			
			return lineEndingStyle;
		}
		return defaultLineSeparator;
	}

	
	
	
	protected internal virtual Printer getPrinter(PrinterConfiguration configuration)
	{
		return (Printer)findCompilationUnit().map(new ___003C_003EAnon1(configuration)).orElse(createDefaultPrinter(configuration));
	}

	
	
	[LineNumberTable(new byte[]
	{
		161, 48, 105, 130, 151, 104, 108, 107, 106, 8,
		230, 69, 134, 135, 104, 146
	})]
	public virtual Node setParentNode(Node newParentNode)
	{
		if (newParentNode == parentNode)
		{
			return this;
		}
		observers.forEach(new ___003C_003EAnon3(this, newParentNode));
		if (parentNode != null)
		{
			ArrayList arrayList = parentNode.childNodes;
			for (int i = 0; i < arrayList.size(); i++)
			{
				if (arrayList.get(i) == this)
				{
					arrayList.remove(i);
				}
			}
			arrayList.trimToSize();
		}
		parentNode = newParentNode;
		if (parentNode != null)
		{
			parentNode.childNodes.add(this);
		}
		return this;
	}

	
		
	public virtual List getChildNodes()
	{
		List result = Collections.unmodifiableList(childNodes);
		
		return result;
	}

	
		
	public virtual Optional getComment()
	{
		Optional result = Optional.ofNullable(comment);
		
		return result;
	}

	
		
	public unsafe virtual List getAllContainedComments()
	{
		LinkedList linkedList = new LinkedList(orphanComments);
		Iterator iterator = getChildNodes().iterator();
		while (iterator.hasNext())
		{
			Node node = (Node)iterator.next();
			Optional optional = node.getComment();
			
			optional.ifPresent(new ___003C_003EAnon2(linkedList));
			((List)linkedList).addAll((Collection)node.getAllContainedComments());
		}
		return linkedList;
	}

	public virtual Node getParentNodeForChildren()
	{
		return this;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional findAncestor(Class[] P_0)
	{
		return HasParentNode._003Cdefault_003EfindAncestor(this, P_0);
	}

	
	
		
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual List getChildNodesByType(Class clazz)
	{
		ArrayList arrayList = new ArrayList();
		Iterator iterator = getChildNodes().iterator();
		while (iterator.hasNext())
		{
			Node node = (Node)iterator.next();
			if (clazz.isInstance(node))
			{
				((List)arrayList).add(clazz.cast(node));
			}
			((List)arrayList).addAll((Collection)node.getChildNodesByType(clazz));
		}
		return arrayList;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (comment != null && node == comment)
		{
			setComment((Comment)replacementNode);
			return true;
		}
		return false;
	}

	
		
	public virtual Optional getParentNode()
	{
		Optional result = Optional.ofNullable(parentNode);
		
		return result;
	}

	
	
	
	public virtual void register(AstObserver observer)
	{
		if (!observers.contains(observer))
		{
			observers.add(observer);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		162, 33, 103, 118, 127, 6, 104, 109, 99, 135,
		98
	})]
	public virtual void registerForSubtree(AstObserver observer)
	{
		register(observer);
		getChildNodes().forEach(new ___003C_003EAnon7(observer));
		Iterator iterator = getMetaModel().getAllPropertyMetaModels().iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			if (propertyMetaModel.isNodeList())
			{
				((NodeList)propertyMetaModel.getValue(this))?.register(observer);
			}
		}
	}

	
	
	public virtual NodeMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EnodeMetaModel;
	}

	
	
	public virtual Node removeComment()
	{
		Node result = setComment(null);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract object accept(GenericVisitor P_0, object P_1);

	
	
	public virtual Node findRootNode()
	{
		Node node = this;
		while (node.getParentNode().isPresent())
		{
			node = (Node)node.getParentNode().get();
		}
		return node;
	}

	
	
	public virtual LineSeparator getLineEndingStyle()
	{
		Node node = this;
		if (node.containsData(___003C_003ELINE_SEPARATOR_KEY))
		{
			return (LineSeparator)node.getData(___003C_003ELINE_SEPARATOR_KEY);
		}
		while (node.getParentNode().isPresent())
		{
			node = (Node)node.getParentNode().get();
			if (node.containsData(___003C_003ELINE_SEPARATOR_KEY))
			{
				return (LineSeparator)node.getData(___003C_003ELINE_SEPARATOR_KEY);
			}
		}
		return LineSeparator.___003C_003ESYSTEM;
	}

	
		
	
	public virtual object getData(DataKey key)
	{
		if (data == null)
		{
			
			throw new IllegalStateException("No data of this type found. Use containsData to check for this first.");
		}
		object obj = data.get(key);
		if (obj == null)
		{
			
			throw new IllegalStateException("No data of this type found. Use containsData to check for this first.");
		}
		return obj;
	}

	
		
	
	private Iterator treeIterator(TreeTraversal traversal)
	{
		switch (_5._0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024TreeTraversal[traversal.ordinal()])
		{
		case 1:
		{
			BreadthFirstIterator result5 = new BreadthFirstIterator(this);
			
			return result5;
		}
		case 2:
		{
			PostOrderIterator result4 = new PostOrderIterator(this);
			
			return result4;
		}
		case 3:
		{
			PreOrderIterator result3 = new PreOrderIterator(this);
			
			return result3;
		}
		case 4:
		{
			DirectChildrenIterator result2 = new DirectChildrenIterator(this);
			
			return result2;
		}
		case 5:
		{
			ParentsVisitor result = new ParentsVisitor(this);
			
			return result;
		}
		default:
			
			throw new IllegalArgumentException("Unknown traversal choice.");
		}
	}

	
		
	
	private Iterable treeIterable(TreeTraversal traversal)
	{
		return new ___003C_003EAnon10(this, traversal);
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void walk(TreeTraversal traversal, Consumer consumer)
	{
		Iterator iterator = treeIterable(traversal).iterator();
		while (iterator.hasNext())
		{
			Node t = (Node)iterator.next();
			consumer.accept(t);
		}
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void walk(Class nodeType, Consumer consumer)
	{
		walk(TreeTraversal.___003C_003EPREORDER, new ___003C_003EAnon11(nodeType, consumer));
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual Optional findFirst(TreeTraversal traversal, Function consumer)
	{
		Iterator iterator = treeIterable(traversal).iterator();
		while (iterator.hasNext())
		{
			Node t = (Node)iterator.next();
			Optional optional = (Optional)consumer.apply(t);
			if (optional.isPresent())
			{
				return optional;
			}
		}
		Optional result = Optional.empty();
		
		return result;
	}

	
	
	
	private bool isPhantom(Node node)
	{
		if (!node.containsData(___003C_003EPHANTOM_KEY))
		{
			int b = (((node.getParentNode().isPresent() && ((Node)node.getParentNode().get()).hasRange() && node.hasRange() && !((Range)((Node)node.getParentNode().get()).getRange().get()).contains((Range)node.getRange().get())) || inPhantomNode(node, 3)) ? 1 : 0);
			node.setData(___003C_003EPHANTOM_KEY, java.lang.Boolean.valueOf((byte)b != 0));
		}
		bool result = ((java.lang.Boolean)node.getData(___003C_003EPHANTOM_KEY)).booleanValue();
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private bool inPhantomNode(Node node, int levels)
	{
		return (node.getParentNode().isPresent() && (isPhantom((Node)node.getParentNode().get()) || inPhantomNode((Node)node.getParentNode().get(), levels - 1))) ? true : false;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void setData(DataKey key, object @object)
	{
		if (data == null)
		{
			data = new IdentityHashMap();
		}
		data.put(key, @object);
	}

	
	
	public new virtual Node clone()
	{
		return (Node)accept(new CloneVisitor(), null);
	}

	
	
	
	public virtual Node setRange(Range range)
	{
		if (this.range == range)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ERANGE, this.range, range);
		this.range = range;
		return this;
	}

	
	
	
	
	private static Printer lambda_0024getPrinter_00241(CompilationUnit c)
	{
		Printer printer = c.getPrinter();
		
		return printer;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static Printer lambda_0024getPrinter_00242(PrinterConfiguration configuration, CompilationUnit c)
	{
		Printer printer = c.getPrinter(configuration);
		
		return printer;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024setParentNode_00243(Node newParentNode, AstObserver o)
	{
		o.parentChange(this, parentNode, newParentNode);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024tryAddImportToParentCompilationUnit_00244(Class clazz, CompilationUnit p)
	{
		p.addImport(clazz);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024notifyPropertyChange_00245(ObservableProperty property, object oldValue, object newValue, AstObserver o)
	{
		o.propertyChange(this, property, oldValue, newValue);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024registerForSubtree_00246(AstObserver observer, Node c)
	{
		c.registerForSubtree(observer);
	}

	
	
	
	
	private static SymbolResolver lambda_0024getSymbolResolver_00247(CompilationUnit cu)
	{
		if (cu.containsData(___003C_003ESYMBOL_RESOLVER_KEY))
		{
			return (SymbolResolver)cu.getData(___003C_003ESYMBOL_RESOLVER_KEY);
		}
		
		throw new IllegalStateException("Symbol resolution not configured: to configure consider setting a SymbolResolver in the ParserConfiguration");
	}

	
	
	
	private static IllegalStateException lambda_0024getSymbolResolver_00248()
	{
		IllegalStateException result = new IllegalStateException("The node is not inserted in a CompilationUnit");
		
		return result;
	}

	
	
	
	
	private Iterator lambda_0024treeIterable_00249(TreeTraversal traversal)
	{
		Iterator result = treeIterator(traversal);
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024walk_002410(Class nodeType, Consumer consumer, Node node)
	{
		if (nodeType.isAssignableFrom(java.lang.Object.instancehelper_getClass(node)))
		{
			consumer.accept(nodeType.cast(node));
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024findAll_002411(Class nodeType, List found, Node node)
	{
		if (nodeType.isAssignableFrom(java.lang.Object.instancehelper_getClass(node)))
		{
			found.add(nodeType.cast(node));
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024findAll_002412(Predicate predicate, List found, Node n)
	{
		if (predicate.test(n))
		{
			found.add(n);
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static Optional lambda_0024findFirst_002413(Class nodeType, Node node)
	{
		if (nodeType.isAssignableFrom(java.lang.Object.instancehelper_getClass(node)))
		{
			Optional result = Optional.of(nodeType.cast(node));
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static Optional lambda_0024findFirst_002414(Class nodeType, Predicate predicate, Node node)
	{
		if (nodeType.isAssignableFrom(java.lang.Object.instancehelper_getClass(node)))
		{
			Node node2 = (Node)nodeType.cast(node);
			if (predicate.test(node2))
			{
				Optional result = Optional.of(node2);
				
				return result;
			}
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	private static bool lambda_0024isAncestorOf_002415(Node descendant, Node n)
	{
		return n == descendant;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static int lambda_0024static_00240(NodeWithRange a, NodeWithRange b)
	{
		if (a.hasRange() && b.hasRange())
		{
			int result = ((Range)a.getRange().get()).___003C_003Ebegin.compareTo(((Range)b.getRange().get()).___003C_003Ebegin);
			
			return result;
		}
		if (a.hasRange() || b.hasRange())
		{
			if (a.hasRange())
			{
				return 1;
			}
			return -1;
		}
		return 0;
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 68, 232, 46, 172, 172, 231, 70, 172, 203,
		104
	})]
	protected internal Node(TokenRange tokenRange)
	{
		childNodes = new ArrayList(0);
		orphanComments = new ArrayList(0);
		data = null;
		observers = new ArrayList(0);
		parsed = Parsedness.___003C_003EPARSED;
		setTokenRange(tokenRange);
	}

	protected internal virtual void customInitialization()
	{
	}

	
		
	public virtual Optional getTokenRange()
	{
		Optional result = Optional.ofNullable(tokenRange);
		
		return result;
	}

	
	
	
	public Node setLineComment(string comment)
	{
		Node result = setComment(new LineComment(comment));
		
		return result;
	}

	
	
	
	public Node setBlockComment(string comment)
	{
		Node result = setComment(new BlockComment(comment));
		
		return result;
	}

	
	
	
	public string toString(PrinterConfiguration configuration)
	{
		string result = getPrinter(configuration).print(this);
		
		return result;
	}

	
	
	public sealed override int GetHashCode()
	{
		int result = HashCodeVisitor.GetHashCode(this);
		
		return result;
	}

	
	
	
	public override bool Equals(object obj)
	{
		if (!(obj is Node))
		{
			return false;
		}
		bool result = EqualsVisitor.equals(this, (Node)obj);
		
		return result;
	}

	
	
	
	public virtual void addOrphanComment(Comment comment)
	{
		orphanComments.add(comment);
		comment.setParentNode(this);
	}

	
	
	
	public virtual bool removeOrphanComment(Comment comment)
	{
		int num = (orphanComments.remove(comment) ? 1 : 0);
		if (num != 0)
		{
			notifyPropertyChange(ObservableProperty.___003C_003ECOMMENT, comment, null);
			comment.setParentNode(null);
			orphanComments.trimToSize();
		}
		return (byte)num != 0;
	}

	
		
	public virtual List getOrphanComments()
	{
		List result = Collections.unmodifiableList(orphanComments);
		
		return result;
	}

	
	
	
	protected internal virtual void setAsParentNodeOf(Node childNode)
	{
		childNode?.setParentNode(getParentNodeForChildren());
	}

	
	
		
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual List getNodesByType(Class clazz)
	{
		List childNodesByType = getChildNodesByType(clazz);
		
		return childNodesByType;
	}

	
		
	public virtual Set getDataKeys()
	{
		if (data == null)
		{
			Set result = Collections.emptySet();
			
			return result;
		}
		Set result2 = data.keySet();
		
		return result2;
	}

	
		
	
	public virtual void removeData(DataKey key)
	{
		if (data != null)
		{
			data.remove(key);
		}
	}

	
	
	
	public virtual bool replace(Node node)
	{
		if (parentNode == null)
		{
			return false;
		}
		bool result = parentNode.replace(this, node);
		
		return result;
	}

	
	
	public virtual void removeForced()
	{
		if (!remove())
		{
			getParentNode().ifPresent(new ___003C_003EAnon5());
		}
	}

	
		
	
	protected internal virtual void setAsParentNodeOf(NodeList list)
	{
		list?.setParentNode(getParentNodeForChildren());
	}

	
	
	
	public virtual void unregister(AstObserver observer)
	{
		observers.remove(observer);
		observers.trimToSize();
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		162, 11, 99, 144, 159, 2, 103, 130, 103, 130,
		108, 130, 159, 6
	})]
	public virtual void register(AstObserver observer, ObserverRegistrationMode mode)
	{
		if (mode == null)
		{
			
			throw new IllegalArgumentException("Mode should be not null");
		}
		switch (_5._0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Node_0024ObserverRegistrationMode[mode.ordinal()])
		{
		case 1:
			register(observer);
			break;
		case 2:
			registerForSubtree(observer);
			break;
		case 3:
			registerForSubtree(PropagatingAstObserver.transformInPropagatingObserver(observer));
			break;
		default:
		{
			string message = new StringBuilder().append("This mode is not supported: ").append(mode).ToString();
			
			throw new UnsupportedOperationException(message);
		}
		}
	}

	
	
	
	public virtual bool isRegistered(AstObserver observer)
	{
		bool result = observers.contains(observer);
		
		return result;
	}

	public virtual Parsedness getParsed()
	{
		return parsed;
	}

	
	public virtual Node setParsed(Parsedness parsed)
	{
		this.parsed = parsed;
		return this;
	}

	
	[LineNumberTable(new byte[]
	{
		162,
		160,
		byte.MaxValue,
		0,
		70,
		234,
		58
	})]
	protected internal virtual SymbolResolver getSymbolResolver()
	{
		return (SymbolResolver)findCompilationUnit().map(new ___003C_003EAnon8()).orElseThrow(new ___003C_003EAnon9());
	}

	
		
	
	public virtual Stream stream(TreeTraversal traversal)
	{
		Stream result = StreamSupport.stream(Spliterators.spliteratorUnknownSize(treeIterator(traversal), 257), parallel: false);
		
		return result;
	}

	
		
	public virtual Stream stream()
	{
		Stream result = StreamSupport.stream(Spliterators.spliteratorUnknownSize(treeIterator(TreeTraversal.___003C_003EPREORDER), 257), parallel: false);
		
		return result;
	}

	
		
	
	public virtual void walk(Consumer consumer)
	{
		walk(TreeTraversal.___003C_003EPREORDER, consumer);
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual List findAll(Class nodeType, TreeTraversal traversal)
	{
		ArrayList arrayList = new ArrayList();
		walk(traversal, new ___003C_003EAnon13(nodeType, arrayList));
		return arrayList;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual List findAll(Class nodeType, Predicate predicate)
	{
		ArrayList arrayList = new ArrayList();
		walk(nodeType, new ___003C_003EAnon14(predicate, arrayList));
		return arrayList;
	}

	
	
	
	public virtual bool isAncestorOf(Node descendant)
	{
		return (this != descendant && findFirst(ClassLiteral<Node>.Value, new ___003C_003EAnon17(descendant)).isPresent()) ? true : false;
	}

	
	
	public virtual bool hasScope()
	{
		return (ClassLiteral<NodeWithOptionalScope>.Value.isAssignableFrom(java.lang.Object.instancehelper_getClass(this)) && ((NodeWithOptionalScope)this).getScope().isPresent()) ? true : false;
	}

	
	
	public virtual bool isPhantom()
	{
		bool result = isPhantom(this);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Eclone()
	{
		Node result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003EsetParentNode(Node newParentNode)
	{
		Node result = setParentNode(newParentNode);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003EsetRange(Range range)
	{
		Node result = setRange(range);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003EsetTokenRange(TokenRange tokenRange)
	{
		Node result = setTokenRange(tokenRange);
		
		return result;
	}

	
	static Node()
	{
		NODE_BY_BEGIN_POSITION = new ___003C_003EAnon18();
		___003C_003EprettyPrinterNoCommentsConfiguration = new DefaultPrinterConfiguration().removeOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_COMMENTS));
		___003C_003ESYMBOL_RESOLVER_KEY = new _1();
		___003C_003ELINE_SEPARATOR_KEY = new _2();
		___003C_003EPRINTER_KEY = new _3();
		___003C_003EPHANTOM_KEY = new _4();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasParentNode()
	{
		return HasParentNode._003Cdefault_003EhasParentNode(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional findAncestor(Class P_0, Predicate P_1)
	{
		return HasParentNode._003Cdefault_003EfindAncestor(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isDescendantOf(Node P_0)
	{
		return HasParentNode._003Cdefault_003EisDescendantOf(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract void accept(VoidVisitor P_0, object P_1);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getBegin()
	{
		return NodeWithRange._003Cdefault_003EgetBegin(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getEnd()
	{
		return NodeWithRange._003Cdefault_003EgetEnd(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool containsWithin(Node P_0)
	{
		return NodeWithRange._003Cdefault_003EcontainsWithin(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool containsWithinRange(Node P_0)
	{
		return NodeWithRange._003Cdefault_003EcontainsWithinRange(this, P_0);
	}

	
	public static implicit operator Cloneable(Node P_0)
	{
		Cloneable result = default(Cloneable);
		result.___003Cref_003E = P_0;
		return result;
	}

	object HasParentNode.HasParentNode_003A_003AsetParentNode(Node P_0)
	{
		return _003Cbridge_003EsetParentNode(P_0);
	}

	object NodeWithRange.NodeWithRange_003A_003AsetRange(Range P_0)
	{
		return _003Cbridge_003EsetRange(P_0);
	}

	object NodeWithTokenRange.NodeWithTokenRange_003A_003AsetTokenRange(TokenRange P_0)
	{
		return _003Cbridge_003EsetTokenRange(P_0);
	}
}
