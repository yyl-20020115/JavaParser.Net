using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.resolution;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;

public class JavaParserTypeAdapter
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly JavaParserTypeAdapter arg_00241;

		internal ___003C_003EAnon0(JavaParserTypeAdapter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedReferenceTypeDeclaration result = arg_00241.lambda_0024containerType_00240((Node)P_0);
			
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

		private Node wrappedNode;

	private TypeSolver typeSolver;

	
		
	public JavaParserTypeAdapter(Node wrappedNode, TypeSolver typeSolver)
	{
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
	}

	
		
	public virtual Set internalTypes()
	{
		Set set = Collections.newSetFromMap(new IdentityHashMap());
		Iterator iterator = ((NodeWithMembers)wrappedNode).getMembers().iterator();
		while (iterator.hasNext())
		{
			BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator.next();
			if (bodyDeclaration is TypeDeclaration)
			{
				set.add(JavaParserFacade.get(typeSolver).getTypeDeclaration((TypeDeclaration)bodyDeclaration));
			}
		}
		return set;
	}

	
		[LineNumberTable(new byte[]
	{
		123, 102, 117, 127, 14, 104, 103, 127, 5, 116,
		130, 133
	})]
	public virtual List getFieldsForDeclaredVariables()
	{
		ArrayList arrayList = new ArrayList();
		if (((NodeWithMembers)wrappedNode).getMembers() != null)
		{
			Iterator iterator = ((NodeWithMembers)wrappedNode).getMembers().iterator();
			while (iterator.hasNext())
			{
				BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator.next();
				if (bodyDeclaration is FieldDeclaration)
				{
					FieldDeclaration fieldDeclaration = (FieldDeclaration)bodyDeclaration;
					Iterator iterator2 = fieldDeclaration.getVariables().iterator();
					while (iterator2.hasNext())
					{
						VariableDeclarator variableDeclarator = (VariableDeclarator)iterator2.next();
						((List)arrayList).add((object)new JavaParserFieldDeclaration(variableDeclarator, typeSolver));
					}
				}
			}
		}
		return arrayList;
	}

	
	
	public virtual string getPackageName()
	{
		string packageName = AstResolutionUtils.getPackageName(wrappedNode);
		
		return packageName;
	}

	
	
	public virtual string getClassName()
	{
		string className = AstResolutionUtils.getClassName("", wrappedNode);
		
		return className;
	}

	
	
	public virtual string getQualifiedName()
	{
		string text = AstResolutionUtils.containerName((Node)wrappedNode.getParentNode().orElse(null));
		if (java.lang.String.instancehelper_isEmpty(text))
		{
			string id = ((NodeWithSimpleName)wrappedNode).getName().getId();
			
			return id;
		}
		string result = new StringBuilder().append(text).append(".").append(((NodeWithSimpleName)wrappedNode).getName().getId())
			.ToString();
		
		return result;
	}

	
	
	public virtual bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		List allAncestors = other.getAllAncestors();
		ReferenceTypeImpl.___003Cclinit_003E();
		allAncestors.add(new ReferenceTypeImpl(other, typeSolver));
		Iterator iterator = allAncestors.iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			if (java.lang.String.instancehelper_equals(resolvedReferenceType.getQualifiedName(), getQualifiedName()))
			{
				return true;
			}
		}
		return false;
	}

	
	
	public virtual bool isAssignableBy(ResolvedType type)
	{
		if (type.isNull())
		{
			return true;
		}
		if (type.isReferenceType())
		{
			ResolvedReferenceTypeDeclaration other = typeSolver.solveType(type.describe());
			bool result = isAssignableBy(other);
			
			return result;
		}
		
		throw new UnsupportedOperationException();
	}

	
	
		[LineNumberTable(new byte[]
	{
		68, 109, 113, 123, 115, 148, 194, 127, 15, 108,
		105, 127, 3, 119, 105, 110, 154, 154, 105, 127,
		0, 105, 154, 139, 127, 0, 105, 110, 159, 8,
		159, 8, 105, 127, 24, 105, 154, 203, 101
	})]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual SymbolReference solveType(string name)
	{
		if (wrappedNode is NodeWithTypeParameters)
		{
			NodeList typeParameters = ((NodeWithTypeParameters)wrappedNode).getTypeParameters();
			Iterator iterator = typeParameters.iterator();
			while (iterator.hasNext())
			{
				TypeParameter typeParameter = (TypeParameter)iterator.next();
				if (java.lang.String.instancehelper_equals(typeParameter.getName().getId(), name))
				{
					SymbolReference result = SymbolReference.solved(new JavaParserTypeVariableDeclaration(typeParameter, typeSolver));
					
					return result;
				}
			}
		}
		Iterator iterator2 = ((NodeWithMembers)wrappedNode).getMembers().iterator();
		while (iterator2.hasNext())
		{
			BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator2.next();
			if (!(bodyDeclaration is TypeDeclaration))
			{
				continue;
			}
			TypeDeclaration typeDeclaration = (TypeDeclaration)bodyDeclaration;
			string text = new StringBuilder().append(typeDeclaration.getName()).append(".").ToString();
			if (java.lang.String.instancehelper_equals(typeDeclaration.getName().getId(), name))
			{
				if (typeDeclaration is ClassOrInterfaceDeclaration)
				{
					if (((ClassOrInterfaceDeclaration)typeDeclaration).isInterface())
					{
						SymbolReference result2 = SymbolReference.solved(new JavaParserInterfaceDeclaration((ClassOrInterfaceDeclaration)typeDeclaration, typeSolver));
						
						return result2;
					}
					SymbolReference result3 = SymbolReference.solved(new JavaParserClassDeclaration((ClassOrInterfaceDeclaration)typeDeclaration, typeSolver));
					
					return result3;
				}
				if (typeDeclaration is EnumDeclaration)
				{
					JavaParserEnumDeclaration.___003Cclinit_003E();
					SymbolReference result4 = SymbolReference.solved(new JavaParserEnumDeclaration((EnumDeclaration)typeDeclaration, typeSolver));
					
					return result4;
				}
				if (typeDeclaration is AnnotationDeclaration)
				{
					SymbolReference result5 = SymbolReference.solved(new JavaParserAnnotationDeclaration((AnnotationDeclaration)typeDeclaration, typeSolver));
					
					return result5;
				}
				
				throw new UnsupportedOperationException();
			}
			if (!java.lang.String.instancehelper_startsWith(name, text) || java.lang.String.instancehelper_length(name) <= java.lang.String.instancehelper_length(text))
			{
				continue;
			}
			if (typeDeclaration is ClassOrInterfaceDeclaration)
			{
				if (((ClassOrInterfaceDeclaration)typeDeclaration).isInterface())
				{
					SymbolReference result6 = new JavaParserInterfaceDeclaration((ClassOrInterfaceDeclaration)typeDeclaration, typeSolver).solveType(java.lang.String.instancehelper_substring(name, java.lang.String.instancehelper_length(text)));
					
					return result6;
				}
				SymbolReference result7 = new JavaParserClassDeclaration((ClassOrInterfaceDeclaration)typeDeclaration, typeSolver).solveType(java.lang.String.instancehelper_substring(name, java.lang.String.instancehelper_length(text)));
				
				return result7;
			}
			if (typeDeclaration is EnumDeclaration)
			{
				SymbolSolver symbolSolver = new SymbolSolver(typeSolver);
				JavaParserEnumDeclaration.___003Cclinit_003E();
				SymbolReference result8 = symbolSolver.solveTypeInType(new JavaParserEnumDeclaration((EnumDeclaration)typeDeclaration, typeSolver), java.lang.String.instancehelper_substring(name, java.lang.String.instancehelper_length(text)));
				
				return result8;
			}
			if (typeDeclaration is AnnotationDeclaration)
			{
				SymbolReference result9 = SymbolReference.solved(new JavaParserAnnotationDeclaration((AnnotationDeclaration)typeDeclaration, typeSolver));
				
				return result9;
			}
			
			throw new UnsupportedOperationException();
		}
		SymbolReference result10 = SymbolReference.unsolved(ClassLiteral<ResolvedTypeDeclaration>.Value);
		
		return result10;
	}

	
		
	public virtual Optional containerType()
	{
		Optional result = wrappedNode.getParentNode().map(new ___003C_003EAnon0(this));
		
		return result;
	}

	
	
	
	private ResolvedReferenceTypeDeclaration lambda_0024containerType_00240(Node P_0)
	{
		ResolvedReferenceTypeDeclaration result = JavaParserFactory.toTypeDeclaration(P_0, typeSolver);
		
		return result;
	}
}
