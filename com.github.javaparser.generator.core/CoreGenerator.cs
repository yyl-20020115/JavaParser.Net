
using com.github.javaparser.generator.core.node;
using com.github.javaparser.generator.core.other;
using com.github.javaparser.generator.core.visitor;
using com.github.javaparser.utils;

using java.lang;
using java.nio.file;

namespace com.github.javaparser.generator.core;

public class CoreGenerator
{
	
	private static ParserConfiguration parserConfiguration;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public CoreGenerator()
	{
	}

	
	
	
	private void run(SourceRoot P_0, SourceRoot P_1)
	{
		new TypeCastingGenerator(P_0).generate();
		new GenericListVisitorAdapterGenerator(P_0).generate();
		new GenericVisitorAdapterGenerator(P_0).generate();
		new GenericVisitorWithDefaultsGenerator(P_0).generate();
		new EqualsVisitorGenerator(P_0).generate();
		new ObjectIdentityEqualsVisitorGenerator(P_0).generate();
		new NoCommentEqualsVisitorGenerator(P_0).generate();
		new VoidVisitorAdapterGenerator(P_0).generate();
		new VoidVisitorGenerator(P_0).generate();
		new VoidVisitorWithDefaultsGenerator(P_0).generate();
		new GenericVisitorGenerator(P_0).generate();
		new HashCodeVisitorGenerator(P_0).generate();
		new ObjectIdentityHashCodeVisitorGenerator(P_0).generate();
		new NoCommentHashCodeVisitorGenerator(P_0).generate();
		new CloneVisitorGenerator(P_0).generate();
		new ModifierVisitorGenerator(P_0).generate();
		new PropertyGenerator(P_0).generate();
		new RemoveMethodGenerator(P_0).generate();
		new ReplaceMethodGenerator(P_0).generate();
		new CloneGenerator(P_0).generate();
		new GetMetaModelGenerator(P_0).generate();
		new MainConstructorGenerator(P_0).generate();
		new NodeModifierGenerator(P_0).generate();
		new AcceptGenerator(P_0).generate();
		new TokenKindGenerator(P_0, P_1).generate();
		new BndGenerator(P_0).generate();
	}

	
	
	
	public static void main(string[] args)
	{
		if ((nint)args.LongLength != 1)
		{
			
			throw new RuntimeException("Need 1 parameter: the JavaParser source checkout root directory.");
		}
		Log.setAdapter(new Log.StandardOutStandardErrorAdapter());
		Path root = Paths.get(args[0], "..", "javaparser-core", "src", "main", "java");
		SourceRoot.___003Cclinit_003E();
		SourceRoot sourceRoot = new SourceRoot(root, parserConfiguration);
		StaticJavaParser.setConfiguration(parserConfiguration);
		Path root2 = Paths.get(args[0], "..", "javaparser-core", "target", "generated-sources", "javacc");
		SourceRoot.___003Cclinit_003E();
		SourceRoot sourceRoot2 = new SourceRoot(root2, parserConfiguration);
		new CoreGenerator().run(sourceRoot, sourceRoot2);
		sourceRoot.saveAll();
	}

	
	static CoreGenerator()
	{
		parserConfiguration = new ParserConfiguration().setLanguageLevel(ParserConfiguration.LanguageLevel.RAW);
	}
}
