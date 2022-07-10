using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.nio.file;
using java.util;
using java.util.concurrent;

namespace com.github.javaparser.utils;

public class ProjectRoot
{
	
	private Path root;

	
		private Map cache;

	
	private ParserConfiguration parserConfiguration;

	
	
	
	public virtual void addSourceRoot(Path path)
	{
		cache.put(path, new SourceRoot(path).setParserConfiguration(parserConfiguration));
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public ProjectRoot(Path root, ParserConfiguration parserConfiguration)
	{
		cache = new ConcurrentHashMap();
		this.root = root;
		this.parserConfiguration = parserConfiguration;
	}

	
	
	
	public ProjectRoot(Path root)
		: this(root, new ParserConfiguration())
	{
	}

	
		
	
	public virtual Optional getSourceRoot(Path sourceRoot)
	{
		Optional result = Optional.ofNullable(cache.get(sourceRoot));
		
		return result;
	}

	
		
	public virtual List getSourceRoots()
	{
		
		ArrayList result = new ArrayList(cache.values());
		
		return result;
	}

	public virtual Path getRoot()
	{
		return root;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("ProjectRoot at ").append(root).append(" with ")
			.append(Object.instancehelper_toString(cache.values()))
			.ToString();
		
		return result;
	}
}
