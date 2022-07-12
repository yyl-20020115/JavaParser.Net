using System;
using System.ComponentModel;

using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.printer;
using com.github.javaparser.printer.configuration;
using com.github.javaparser.utils;

using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.charset;
using java.nio.file;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast;

public class CompilationUnit : Node
{
	
	
	
	
	internal new class _1
	{
		_1()
		{
			throw null;
		}
	}

	public class Storage
	{
		
		private sealed class ___003C_003EAnon0 : Function
		{
			internal ___003C_003EAnon0()
			{
			}

			public object apply(object P_0)
			{
				string nameAsString = ((NodeWithName)(PackageDeclaration)P_0).getNameAsString();
				
				return nameAsString;
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
			internal ___003C_003EAnon1()
			{
			}

			public object apply(object P_0)
			{
				Path result = lambda_0024getSourceRoot_00240((string)P_0);
				
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

		
		private sealed class ___003C_003EAnon2 : Function
		{
			private readonly Storage arg_00241;

			internal ___003C_003EAnon2(Storage P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(object P_0)
			{
				Path result = arg_00241.lambda_0024getSourceRoot_00241((Path)P_0);
				
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

		
		private sealed class ___003C_003EAnon3 : Function
		{
			private readonly Storage arg_00241;

			internal ___003C_003EAnon3(Storage P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(object P_0)
			{
				string result = arg_00241.lambda_0024save_00242((CompilationUnit)P_0);
				
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

		
		private CompilationUnit compilationUnit;

		
		private Path path;

		
		private Charset encoding;

		
		
		
		internal Storage(CompilationUnit P_0, Path P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		
		
		
		internal Storage(CompilationUnit P_0, Path P_1, Charset P_2, _1 P_3)
			: this(P_0, P_1, P_2)
		{
		}

		
		
		public virtual string getFileName()
		{
			string result = path.getFileName().ToString();
			
			return result;
		}

		
		
		
		private Storage(CompilationUnit compilationUnit, Path path, Charset encoding)
		{
			this.compilationUnit = compilationUnit;
			this.path = path.toAbsolutePath();
			this.encoding = encoding;
		}

		
		
		
		private Storage(CompilationUnit compilationUnit, Path path)
			: this(compilationUnit, path, Providers.___003C_003EUTF8)
		{
		}

		
		
		public virtual Path getDirectory()
		{
			Path parent = path.getParent();
			
			return parent;
		}

		
				
		
		public virtual void save(Function makeOutput)
		{
			save(makeOutput, encoding);
		}

		
				
		
		public virtual void save(Function makeOutput, Charset encoding)
		{
			IOException ex;
			try
			{
				Files.createDirectories(path.getParent());
				string @this = (string)makeOutput.apply(getCompilationUnit());
				Files.write(path, java.lang.String.instancehelper_getBytes(@this, encoding));
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			
			throw new RuntimeException(cause);
		}

		public virtual CompilationUnit getCompilationUnit()
		{
			return compilationUnit;
		}

		public virtual Path getPath()
		{
			return path;
		}

		
		
		
		
		private static Path lambda_0024getSourceRoot_00240(string p)
		{
			Path result = Paths.get(CodeGenerationUtils.packageToPath(p));
			
			return result;
		}

		
		
		
		
		private Path lambda_0024getSourceRoot_00241(Path pkg)
		{
			Path result = CodeGenerationUtils.subtractPaths(getDirectory(), pkg);
			
			return result;
		}

		
		
		
		
		private string lambda_0024save_00242(CompilationUnit cu)
		{
			string result = compilationUnit.getPrinter().print(cu);
			
			return result;
		}

		public virtual Charset getEncoding()
		{
			return encoding;
		}

		
		
		public virtual Path getSourceRoot()
		{
			Optional optional = compilationUnit.getPackageDeclaration().map(new ___003C_003EAnon0());
			return (Path)optional.map(new ___003C_003EAnon1()).map(new ___003C_003EAnon2(this)).orElse(getDirectory());
		}

		
		
		public virtual void save()
		{
			save(new ___003C_003EAnon3(this));
		}

		
				
		
		public virtual ParseResult reparse(JavaParser javaParser)
		{
			//Discarded unreachable code: IL_0018
			IOException ex;
			try
			{
				return javaParser.parse(ParseStart.COMPILATION_UNIT, Providers.provider(getPath()));
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			
			throw new RuntimeException(cause);
		}
	}

	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon0(List P_0)
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly ImportDeclaration arg_00241;

		internal ___003C_003EAnon1(ImportDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024addImport_00240(arg_00241, (ImportDeclaration)P_0);
			
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
		private readonly ImportDeclaration arg_00241;

		internal ___003C_003EAnon2(ImportDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024addImport_00241(arg_00241, (ImportDeclaration)P_0);
			
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
		private readonly string arg_00241;

		internal ___003C_003EAnon3(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getClassByName_00242(arg_00241, (TypeDeclaration)P_0);
			
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
			ClassOrInterfaceDeclaration result = lambda_0024getClassByName_00243((TypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon5(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getLocalDeclarationFromClassname_00244(arg_00241, (ClassOrInterfaceDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon6(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getInterfaceByName_00245(arg_00241, (TypeDeclaration)P_0);
			
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
			ClassOrInterfaceDeclaration result = lambda_0024getInterfaceByName_00246((TypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon8 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon8(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getEnumByName_00247(arg_00241, (TypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon9 : Function
	{
		internal ___003C_003EAnon9()
		{
		}

		public object apply(object P_0)
		{
			EnumDeclaration result = lambda_0024getEnumByName_00248((TypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon10 : Function
	{
		internal ___003C_003EAnon10()
		{
		}

		public object apply(object P_0)
		{
			string fileName = ((Storage)P_0).getFileName();
			
			return fileName;
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

	
	private sealed class ___003C_003EAnon11 : Function
	{
		internal ___003C_003EAnon11()
		{
		}

		public object apply(object P_0)
		{
			string result = Utils.removeFileExtension((string)P_0);
			
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

	
	private sealed class ___003C_003EAnon12 : Function
	{
		private readonly CompilationUnit arg_00241;

		internal ___003C_003EAnon12(CompilationUnit P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Optional result = arg_00241.lambda_0024getPrimaryType_002410((string)P_0);
			
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

	
	private sealed class ___003C_003EAnon13 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon13(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getAnnotationDeclarationByName_002411(arg_00241, (TypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon14 : Function
	{
		internal ___003C_003EAnon14()
		{
		}

		public object apply(object P_0)
		{
			AnnotationDeclaration result = lambda_0024getAnnotationDeclarationByName_002412((TypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon15 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon15(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024null_00249(arg_00241, (TypeDeclaration)P_0);
			
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

	private const string JAVA_LANG = "java.lang";

	
	private PackageDeclaration packageDeclaration;

		private NodeList imports;

		private NodeList types;

	
	private ModuleDeclaration module;

	
	private Storage storage;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public virtual Optional getClassByName(string className)
	{
		Optional result = getTypes().stream().filter(new ___003C_003EAnon3(className)).findFirst()
			.map(new ___003C_003EAnon4());
		
		return result;
	}

	
		
	
	public virtual CompilationUnit addImport(Class clazz)
	{
		if (clazz.isArray())
		{
			CompilationUnit result = addImport(clazz.getComponentType());
			
			return result;
		}
		if (ClassUtils.isPrimitiveOrWrapper(clazz) || java.lang.String.instancehelper_equals("java.lang", clazz.getPackage().getName()))
		{
			return this;
		}
		if (clazz.isAnonymousClass() || clazz.isLocalClass())
		{
			string s = new StringBuilder().append(clazz.getName()).append(" is an anonymous or local class therefore it can't be added with addImport").ToString();
			
			throw new IllegalArgumentException(s);
		}
		CompilationUnit result2 = addImport(clazz.getCanonicalName());
		
		return result2;
	}

	
	
	
	public virtual CompilationUnit addImport(string name)
	{
		CompilationUnit result = addImport(name, isStatic: false, isAsterisk: false);
		
		return result;
	}

	
	
	
	public virtual CompilationUnit addImport(string name, bool isStatic, bool isAsterisk)
	{
		if (name == null)
		{
			return this;
		}
		StringBuilder stringBuilder = new StringBuilder("import ");
		if (isStatic)
		{
			stringBuilder.append("static ");
		}
		stringBuilder.append(name);
		if (isAsterisk)
		{
			stringBuilder.append(".*");
		}
		stringBuilder.append(";");
		CompilationUnit result = addImport(StaticJavaParser.parseImport(stringBuilder.ToString()));
		
		return result;
	}

	
		
	
	public virtual Optional getEnumByName(string enumName)
	{
		Optional result = getTypes().stream().filter(new ___003C_003EAnon8(enumName)).findFirst()
			.map(new ___003C_003EAnon9());
		
		return result;
	}

	
		
	
	public virtual Optional getInterfaceByName(string interfaceName)
	{
		Optional result = getTypes().stream().filter(new ___003C_003EAnon6(interfaceName)).findFirst()
			.map(new ___003C_003EAnon7());
		
		return result;
	}

		public virtual NodeList getImports()
	{
		return imports;
	}

	
	
	
	protected internal override Printer getPrinter(PrinterConfiguration config)
	{
		Printer result = getPrinter().setConfiguration(config);
		printer(result);
		return result;
	}

	
	
	protected internal override Printer getPrinter()
	{
		if (!containsData(Node.___003C_003EPRINTER_KEY))
		{
			Printer printer = createDefaultPrinter();
			this.printer(printer);
		}
		return (Printer)getData(Node.___003C_003EPRINTER_KEY);
	}

	
		
	public virtual Optional getPackageDeclaration()
	{
		Optional result = Optional.ofNullable(packageDeclaration);
		
		return result;
	}

	
		
	
	public CompilationUnit(TokenRange tokenRange, PackageDeclaration packageDeclaration, NodeList imports, NodeList types, ModuleDeclaration module)
		: base(tokenRange)
	{
		setPackageDeclaration(packageDeclaration);
		setImports(imports);
		setTypes(types);
		setModule(module);
		customInitialization();
	}

	
	
	
	public virtual CompilationUnit setPackageDeclaration(PackageDeclaration packageDeclaration)
	{
		if (packageDeclaration == this.packageDeclaration)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EPACKAGE_DECLARATION, this.packageDeclaration, packageDeclaration);
		if (this.packageDeclaration != null)
		{
			this.packageDeclaration.setParentNode(null);
		}
		this.packageDeclaration = packageDeclaration;
		setAsParentNodeOf(packageDeclaration);
		return this;
	}

	
		
	
	public virtual CompilationUnit setImports(NodeList imports)
	{
		Utils.assertNotNull(imports);
		if (imports == this.imports)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EIMPORTS, this.imports, imports);
		if (this.imports != null)
		{
			this.imports.setParentNode(null);
		}
		this.imports = imports;
		setAsParentNodeOf(imports);
		return this;
	}

	
		
	
	public virtual CompilationUnit setTypes(NodeList types)
	{
		Utils.assertNotNull(types);
		if (types == this.types)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPES, this.types, types);
		if (this.types != null)
		{
			this.types.setParentNode(null);
		}
		this.types = types;
		setAsParentNodeOf(types);
		return this;
	}

	
	
	
	public virtual CompilationUnit setModule(ModuleDeclaration module)
	{
		if (module == this.module)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EMODULE, this.module, module);
		if (this.module != null)
		{
			this.module.setParentNode(null);
		}
		this.module = module;
		setAsParentNodeOf(module);
		return this;
	}

	
	
	
	public virtual CompilationUnit printer(Printer printer)
	{
		setData(Node.___003C_003EPRINTER_KEY, printer);
		return this;
	}

		public virtual NodeList getTypes()
	{
		return types;
	}

	
	
	
	private bool isImplicitImport(ImportDeclaration importDeclaration)
	{
		Optional importPackageName = getImportPackageName(importDeclaration);
		if (importPackageName.isPresent())
		{
			if (StaticJavaParser.parseName("java.lang").equals(importPackageName.get()))
			{
				return true;
			}
			if (packageDeclaration != null)
			{
				Name name = packageDeclaration.getName();
				bool result = name.equals(importPackageName.get());
				
				return result;
			}
			return false;
		}
		return true;
	}

	
		
	
	private static Optional getImportPackageName(ImportDeclaration importDeclaration)
	{
		Name name;
		if (importDeclaration.isAsterisk())
		{
			Name.___003Cclinit_003E();
			name = new Name(importDeclaration.getName(), "*");
		}
		else
		{
			name = importDeclaration.getName();
		}
		Optional qualifier = name.getQualifier();
		
		return qualifier;
	}

	
	
	
	public virtual CompilationUnit addImport(ImportDeclaration importDeclaration)
	{
		if (importDeclaration.isAsterisk())
		{
			getImports().removeIf(new ___003C_003EAnon1(importDeclaration));
		}
		if (!isImplicitImport(importDeclaration) && getImports().stream().noneMatch(new ___003C_003EAnon2(importDeclaration)))
		{
			getImports().add(importDeclaration);
		}
		return this;
	}

	
	
	
	public virtual ClassOrInterfaceDeclaration addClass(string name, params Modifier.Keyword[] modifiers)
	{
		ClassOrInterfaceDeclaration.___003Cclinit_003E();
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = new ClassOrInterfaceDeclaration(Modifier.createModifierList(modifiers), isInterface: false, name);
		getTypes().add(classOrInterfaceDeclaration);
		return classOrInterfaceDeclaration;
	}

	
	
	
	public virtual ClassOrInterfaceDeclaration addInterface(string name, params Modifier.Keyword[] modifiers)
	{
		ClassOrInterfaceDeclaration.___003Cclinit_003E();
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = new ClassOrInterfaceDeclaration(Modifier.createModifierList(modifiers), isInterface: true, name);
		getTypes().add(classOrInterfaceDeclaration);
		return classOrInterfaceDeclaration;
	}

	
	
	
	public virtual EnumDeclaration addEnum(string name, params Modifier.Keyword[] modifiers)
	{
		EnumDeclaration.___003Cclinit_003E();
		EnumDeclaration enumDeclaration = new EnumDeclaration(Modifier.createModifierList(modifiers), name);
		getTypes().add(enumDeclaration);
		return enumDeclaration;
	}

	
	
	
	public virtual AnnotationDeclaration addAnnotationDeclaration(string name, params Modifier.Keyword[] modifiers)
	{
		AnnotationDeclaration.___003Cclinit_003E();
		AnnotationDeclaration annotationDeclaration = new AnnotationDeclaration(Modifier.createModifierList(modifiers), name);
		getTypes().add(annotationDeclaration);
		return annotationDeclaration;
	}

	
		
	public virtual Optional getStorage()
	{
		Optional result = Optional.ofNullable(storage);
		
		return result;
	}

	
		
	public virtual Optional getPrimaryTypeName()
	{
		Optional result = getStorage().map(new ___003C_003EAnon10()).map(new ___003C_003EAnon11());
		
		return result;
	}

	
	
	public virtual CompilationUnit removeModule()
	{
		CompilationUnit result = setModule((ModuleDeclaration)null);
		
		return result;
	}

	
	
	public virtual CompilationUnit removePackageDeclaration()
	{
		CompilationUnit result = setPackageDeclaration((PackageDeclaration)null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual CompilationUnitMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EcompilationUnitMetaModel;
	}

	
	
	public new virtual CompilationUnit clone()
	{
		return (CompilationUnit)accept(new CloneVisitor(), null);
	}

	
	
	
	
	private static bool lambda_0024addImport_00240(ImportDeclaration importDeclaration, ImportDeclaration im)
	{
		bool result = Objects.equals(getImportPackageName(im).get(), getImportPackageName(importDeclaration).orElse(null));
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024addImport_00241(ImportDeclaration importDeclaration, ImportDeclaration im)
	{
		return (im.equals(importDeclaration) || (im.isAsterisk() && Objects.equals(getImportPackageName(im).get(), getImportPackageName(importDeclaration).orElse(null)))) ? true : false;
	}

	
	
	
	
	private static bool lambda_0024getClassByName_00242(string className, TypeDeclaration type)
	{
		return (java.lang.String.instancehelper_equals(type.getNameAsString(), className) && type is ClassOrInterfaceDeclaration && !((ClassOrInterfaceDeclaration)type).isInterface()) ? true : false;
	}

	
	
	
	private static ClassOrInterfaceDeclaration lambda_0024getClassByName_00243(TypeDeclaration t)
	{
		return (ClassOrInterfaceDeclaration)t;
	}

	
	
	
	
	private static bool lambda_0024getLocalDeclarationFromClassname_00244(string className, ClassOrInterfaceDeclaration cid)
	{
		bool result = java.lang.String.instancehelper_endsWith((string)cid.getFullyQualifiedName().get(), className);
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024getInterfaceByName_00245(string interfaceName, TypeDeclaration type)
	{
		return (java.lang.String.instancehelper_equals(type.getNameAsString(), interfaceName) && type is ClassOrInterfaceDeclaration && ((ClassOrInterfaceDeclaration)type).isInterface()) ? true : false;
	}

	
	
	
	private static ClassOrInterfaceDeclaration lambda_0024getInterfaceByName_00246(TypeDeclaration t)
	{
		return (ClassOrInterfaceDeclaration)t;
	}

	
	
	
	
	private static bool lambda_0024getEnumByName_00247(string enumName, TypeDeclaration type)
	{
		return (java.lang.String.instancehelper_equals(type.getNameAsString(), enumName) && type is EnumDeclaration) ? true : false;
	}

	
	
	
	private static EnumDeclaration lambda_0024getEnumByName_00248(TypeDeclaration t)
	{
		return (EnumDeclaration)t;
	}

	
	
	
	
	private Optional lambda_0024getPrimaryType_002410(string name)
	{
		Optional result = getTypes().stream().filter(new ___003C_003EAnon15(name)).findFirst();
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024getAnnotationDeclarationByName_002411(string annotationName, TypeDeclaration type)
	{
		return (java.lang.String.instancehelper_equals(type.getNameAsString(), annotationName) && type is AnnotationDeclaration) ? true : false;
	}

	
	
	
	private static AnnotationDeclaration lambda_0024getAnnotationDeclarationByName_002412(TypeDeclaration t)
	{
		return (AnnotationDeclaration)t;
	}

	
	
	
	
	private static bool lambda_0024null_00249(string name, TypeDeclaration t)
	{
		bool result = java.lang.String.instancehelper_equals(t.getNameAsString(), name);
		
		return result;
	}

	
	
	public CompilationUnit()
		: this(null, null, new NodeList(), new NodeList(), null)
	{
	}

	
	
	
	public CompilationUnit(string packageDeclaration)
	{
		PackageDeclaration.___003Cclinit_003E();
		this._002Ector(null, new PackageDeclaration(new Name(packageDeclaration)), new NodeList(), new NodeList(), null);
	}

	
		
	
	
	public CompilationUnit(PackageDeclaration packageDeclaration, NodeList imports, NodeList types, ModuleDeclaration module)
		: this(null, packageDeclaration, imports, types, module)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public unsafe virtual List getComments()
	{
		List allContainedComments = getAllContainedComments();
		Optional optional = getComment();
		
		optional.ifPresent(new ___003C_003EAnon0(allContainedComments));
		return allContainedComments;
	}

	
		
	public unsafe virtual List getAllComments()
	{
		List allContainedComments = getAllContainedComments();
		Optional optional = getComment();
		
		optional.ifPresent(new ___003C_003EAnon0(allContainedComments));
		return allContainedComments;
	}

	
	
	
	public virtual ImportDeclaration getImport(int i)
	{
		return (ImportDeclaration)getImports().get(i);
	}

	
		
	
	public virtual TypeDeclaration getType(int i)
	{
		return (TypeDeclaration)getTypes().get(i);
	}

	
	
	
	public virtual CompilationUnit setImport(int i, ImportDeclaration imports)
	{
		getImports().set(i, imports);
		return this;
	}

	
		
	
	public virtual CompilationUnit setType(int i, TypeDeclaration type)
	{
		NodeList nodeList = new NodeList();
		nodeList.addAll(getTypes());
		getTypes().set(i, type);
		notifyPropertyChange(ObservableProperty.___003C_003ETYPES, nodeList, types);
		return this;
	}

	
		
	
	public virtual CompilationUnit addType(TypeDeclaration type)
	{
		NodeList nodeList = new NodeList();
		nodeList.addAll(getTypes());
		getTypes().add(type);
		notifyPropertyChange(ObservableProperty.___003C_003ETYPES, nodeList, types);
		return this;
	}

	
	
	
	public virtual CompilationUnit setPackageDeclaration(string name)
	{
		PackageDeclaration.___003Cclinit_003E();
		setPackageDeclaration(new PackageDeclaration(StaticJavaParser.parseName(name)));
		return this;
	}

	
	
	
	public virtual ClassOrInterfaceDeclaration addClass(string name)
	{
		ClassOrInterfaceDeclaration result = addClass(name, Modifier.Keyword.___003C_003EPUBLIC);
		
		return result;
	}

	
	
	
	public virtual ClassOrInterfaceDeclaration addInterface(string name)
	{
		ClassOrInterfaceDeclaration result = addInterface(name, Modifier.Keyword.___003C_003EPUBLIC);
		
		return result;
	}

	
	
	
	public virtual EnumDeclaration addEnum(string name)
	{
		EnumDeclaration result = addEnum(name, Modifier.Keyword.___003C_003EPUBLIC);
		
		return result;
	}

	
	
	
	public virtual AnnotationDeclaration addAnnotationDeclaration(string name)
	{
		AnnotationDeclaration result = addAnnotationDeclaration(name, Modifier.Keyword.___003C_003EPUBLIC);
		
		return result;
	}

	
		
	
	public virtual List getLocalDeclarationFromClassname(string className)
	{
		return (List)findAll(ClassLiteral<ClassOrInterfaceDeclaration>.Value).stream().filter(new ___003C_003EAnon5(className)).collect(Collectors.toList());
	}

	
		
	public virtual Optional getPrimaryType()
	{
		Optional result = getPrimaryTypeName().flatMap(new ___003C_003EAnon12(this));
		
		return result;
	}

	
		
	
	public virtual Optional getAnnotationDeclarationByName(string annotationName)
	{
		Optional result = getTypes().stream().filter(new ___003C_003EAnon13(annotationName)).findFirst()
			.map(new ___003C_003EAnon14());
		
		return result;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < imports.size(); i++)
		{
			if (imports.get(i) == node)
			{
				imports.remove(i);
				return true;
			}
		}
		if (module != null && node == module)
		{
			removeModule();
			return true;
		}
		if (packageDeclaration != null && node == packageDeclaration)
		{
			removePackageDeclaration();
			return true;
		}
		for (int i = 0; i < types.size(); i++)
		{
			if (types.get(i) == node)
			{
				types.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
		
	public virtual Optional getModule()
	{
		Optional result = Optional.ofNullable(module);
		
		return result;
	}

	
	
	
	public virtual CompilationUnit setStorage(Path path)
	{
		storage = new Storage(this, path, null);
		return this;
	}

	
	
	
	public virtual CompilationUnit setStorage(Path path, Charset charset)
	{
		storage = new Storage(this, path, charset, null);
		return this;
	}

	
	
	
	public virtual ModuleDeclaration setModule(string name)
	{
		ModuleDeclaration.___003Cclinit_003E();
		ModuleDeclaration result = new ModuleDeclaration(StaticJavaParser.parseName(name), isOpen: false);
		setModule(result);
		return result;
	}

	
	
	public virtual void recalculatePositions()
	{
		if (!getTokenRange().isPresent())
		{
			
			throw new IllegalStateException("Can't recalculate positions without tokens.");
		}
		Position position = Position.___003C_003EHOME;
		Iterator iterator = ((TokenRange)getTokenRange().get()).iterator();
		while (iterator.hasNext())
		{
			JavaToken javaToken = (JavaToken)iterator.next();
			int num = ((javaToken.getKind() != JavaToken.Kind.___003C_003EEOF.getKind()) ? (java.lang.String.instancehelper_length(javaToken.getText()) - 1) : 0);
			javaToken.setRange(Range.range(position, position.right(num)));
			position = ((!javaToken.getCategory().isEndOfLine()) ? position.right(num + 1) : position.nextLine());
		}
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < imports.size(); i++)
		{
			if (imports.get(i) == node)
			{
				imports.set(i, (ImportDeclaration)replacementNode);
				return true;
			}
		}
		if (module != null && node == module)
		{
			setModule((ModuleDeclaration)replacementNode);
			return true;
		}
		if (packageDeclaration != null && node == packageDeclaration)
		{
			setPackageDeclaration((PackageDeclaration)replacementNode);
			return true;
		}
		for (int i = 0; i < types.size(); i++)
		{
			if (types.get(i) == node)
			{
				types.set(i, (TypeDeclaration)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		CompilationUnitMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		CompilationUnit result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		CompilationUnit result = clone();
		
		return result;
	}

	
	static CompilationUnit()
	{
		Node.___003Cclinit_003E();
	}
}
