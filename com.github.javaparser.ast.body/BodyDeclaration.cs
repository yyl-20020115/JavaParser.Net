using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.body;


public abstract class BodyDeclaration : Node, NodeWithAnnotations
{
		private NodeList annotations;

	
	
	protected internal new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < annotations.size(); i++)
		{
			if (annotations.get(i) == node)
			{
				annotations.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	
	public virtual MethodDeclaration asMethodDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not MethodDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toFieldDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(AnnotationExpr P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	
		
	
	public BodyDeclaration(TokenRange tokenRange, NodeList annotations)
		: base(tokenRange)
	{
		setAnnotations(annotations);
		customInitialization();
	}

	
		
	
	public virtual BodyDeclaration setAnnotations(NodeList annotations)
	{
		Utils.assertNotNull(annotations);
		if (annotations == this.annotations)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EANNOTATIONS, this.annotations, annotations);
		if (this.annotations != null)
		{
			this.annotations.setParentNode(null);
		}
		this.annotations = annotations;
		setAsParentNodeOf(annotations);
		return this;
	}

	
	
	public new virtual BodyDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EbodyDeclarationMetaModel;
	}

	
		
	public new virtual BodyDeclaration clone()
	{
		return (BodyDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	public BodyDeclaration()
		: this(null, new NodeList())
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public BodyDeclaration(NodeList annotations)
		: this(null, annotations)
	{
	}

	
	
	
	protected internal BodyDeclaration(TokenRange range)
		: this(range, new NodeList())
	{
	}

		public virtual NodeList getAnnotations()
	{
		return annotations;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < annotations.size(); i++)
		{
			if (annotations.get(i) == node)
			{
				annotations.set(i, (AnnotationExpr)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public virtual bool isAnnotationDeclaration()
	{
		return false;
	}

	
	
	public virtual AnnotationDeclaration asAnnotationDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not AnnotationDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isAnnotationMemberDeclaration()
	{
		return false;
	}

	
	
	public virtual AnnotationMemberDeclaration asAnnotationMemberDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not AnnotationMemberDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isCallableDeclaration()
	{
		return false;
	}

	
	
	public virtual CallableDeclaration asCallableDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not CallableDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isClassOrInterfaceDeclaration()
	{
		return false;
	}

	
	
	public virtual ClassOrInterfaceDeclaration asClassOrInterfaceDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not ClassOrInterfaceDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isConstructorDeclaration()
	{
		return false;
	}

	
	
	public virtual ConstructorDeclaration asConstructorDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not ConstructorDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isCompactConstructorDeclaration()
	{
		return false;
	}

	
	
	public virtual CompactConstructorDeclaration asCompactConstructorDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not CompactConstructorDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isEnumConstantDeclaration()
	{
		return false;
	}

	
	
	public virtual EnumConstantDeclaration asEnumConstantDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not EnumConstantDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isEnumDeclaration()
	{
		return false;
	}

	
	
	public virtual EnumDeclaration asEnumDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not EnumDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isFieldDeclaration()
	{
		return false;
	}

	
	
	public virtual FieldDeclaration asFieldDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not FieldDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isInitializerDeclaration()
	{
		return false;
	}

	
	
	public virtual InitializerDeclaration asInitializerDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not InitializerDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	public virtual bool isMethodDeclaration()
	{
		return false;
	}

	public virtual bool isTypeDeclaration()
	{
		return false;
	}

	
	
	public virtual TypeDeclaration asTypeDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not TypeDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

		
	public virtual void ifAnnotationDeclaration(Consumer action)
	{
	}

		
	public virtual void ifAnnotationMemberDeclaration(Consumer action)
	{
	}

		
	public virtual void ifCallableDeclaration(Consumer action)
	{
	}

		
	public virtual void ifClassOrInterfaceDeclaration(Consumer action)
	{
	}

		
	public virtual void ifConstructorDeclaration(Consumer action)
	{
	}

		
	public virtual void ifEnumConstantDeclaration(Consumer action)
	{
	}

		
	public virtual void ifEnumDeclaration(Consumer action)
	{
	}

		
	public virtual void ifFieldDeclaration(Consumer action)
	{
	}

		
	public virtual void ifInitializerDeclaration(Consumer action)
	{
	}

		
	public virtual void ifMethodDeclaration(Consumer action)
	{
	}

		
	public virtual void ifTypeDeclaration(Consumer action)
	{
	}

		
	public virtual void ifRecordDeclaration(Consumer action)
	{
	}

		
	public virtual void ifCompactConstructorDeclaration(Consumer action)
	{
	}

	
		
	public virtual Optional toAnnotationDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toAnnotationMemberDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toCallableDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toClassOrInterfaceDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toConstructorDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toEnumConstantDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toEnumDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toInitializerDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toMethodDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toTypeDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	public virtual bool isRecordDeclaration()
	{
		return false;
	}

	
	
	public virtual RecordDeclaration asRecordDeclaration()
	{
		string s = CodeGenerationUtils.f("%s is not RecordDeclaration, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toRecordDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toCompactConstructorDeclaration()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		BodyDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		BodyDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		BodyDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		BodyDeclaration result = setAnnotations(annotations);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual AnnotationExpr getAnnotation(int P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setAnnotation(int P_0, AnnotationExpr P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EsetAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual NormalAnnotationExpr addAndGetAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual NormalAnnotationExpr addAndGetAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addMarkerAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addMarkerAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(string P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(Class P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(string P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(Class P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isAnnotationPresent(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isAnnotationPresent(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getAnnotationByName(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByName(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getAnnotationByClass(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByClass(this, P_0);
	}

	
	static BodyDeclaration()
	{
		Node.___003Cclinit_003E();
	}

	Node NodeWithAnnotations.NodeWithAnnotations_003A_003AsetAnnotations(NodeList P_0)
	{
		return _003Cbridge_003EsetAnnotations(P_0);
	}
}
