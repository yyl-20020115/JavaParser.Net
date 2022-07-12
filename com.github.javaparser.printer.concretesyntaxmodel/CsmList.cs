
using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;

using java.lang;
using java.util;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmList: CsmElement
{
	
	private ObservableProperty property;

	
	private CsmElement separatorPost;

	
	private CsmElement separatorPre;

	
	private CsmElement preceeding;

	
	private CsmElement following;

	
	
	
	public CsmList(ObservableProperty property)
		: this(property, new CsmNone(), new CsmNone(), new CsmNone(), new CsmNone())
	{
	}

	
	
	
	public CsmList(ObservableProperty property, CsmElement separatorPre, CsmElement separatorPost, CsmElement preceeding, CsmElement following)
	{
		this.property = property;
		this.separatorPre = separatorPre;
		this.separatorPost = separatorPost;
		this.preceeding = preceeding;
		this.following = following;
	}

	public virtual ObservableProperty getProperty()
	{
		return property;
	}

	public virtual CsmElement getSeparatorPost()
	{
		return separatorPost;
	}

	public virtual CsmElement getSeparatorPre()
	{
		return separatorPre;
	}

	public virtual CsmElement getPreceeding()
	{
		return preceeding;
	}

	public virtual CsmElement getFollowing()
	{
		return following;
	}

	
	
	
	public CsmList(ObservableProperty property, CsmElement separator)
		: this(property, new CsmNone(), separator, new CsmNone(), new CsmNone())
	{
	}

	
	
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		if (property.isAboutNodes())
		{
			NodeList valueAsMultipleReference = property.getValueAsMultipleReference(node);
			if (valueAsMultipleReference == null)
			{
				return;
			}
			if (!valueAsMultipleReference.isEmpty() && preceeding != null)
			{
				preceeding.prettyPrint(node, printer);
			}
			for (int i = 0; i < valueAsMultipleReference.size(); i++)
			{
				if (separatorPre != null && i != 0)
				{
					separatorPre.prettyPrint(node, printer);
				}
				ConcreteSyntaxModel.genericPrettyPrint(valueAsMultipleReference.get(i), printer);
				if (separatorPost != null && i != valueAsMultipleReference.size() - 1)
				{
					separatorPost.prettyPrint(node, printer);
				}
			}
			if (!valueAsMultipleReference.isEmpty() && following != null)
			{
				following.prettyPrint(node, printer);
			}
			return;
		}
		Collection valueAsCollection = property.getValueAsCollection(node);
		if (valueAsCollection == null)
		{
			return;
		}
		if (!valueAsCollection.isEmpty() && preceeding != null)
		{
			preceeding.prettyPrint(node, printer);
		}
		Iterator iterator = valueAsCollection.iterator();
		while (iterator.hasNext())
		{
			if (separatorPre != null && iterator.hasNext())
			{
				separatorPre.prettyPrint(node, printer);
			}
			printer.print(PrintingHelper.printToString(iterator.next()));
			if (separatorPost != null && iterator.hasNext())
			{
				separatorPost.prettyPrint(node, printer);
			}
		}
		if (!valueAsCollection.isEmpty() && following != null)
		{
			following.prettyPrint(node, printer);
		}
	}

	
	
	public override string ToString()
	{
		string result = String.format("%s(property:%s)", Object.instancehelper_getClass(this).getSimpleName(), getProperty());
		
		return result;
	}
}
