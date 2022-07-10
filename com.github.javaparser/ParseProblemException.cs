using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser;

[Serializable]
public class ParseProblemException : RuntimeException
{
	
		private List problems;

	
		
	
	private static string createMessage(List problems)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Iterator iterator = problems.iterator();
		while (iterator.hasNext())
		{
			Problem problem = (Problem)iterator.next();
			stringBuilder.append(problem.ToString()).append(Utils.___003C_003ESYSTEM_EOL);
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
		
	
	public ParseProblemException(List problems)
		: base(createMessage((List)Utils.assertNotNull(problems)))
	{
		this.problems = problems;
	}

	
	
	
	public ParseProblemException(System.Exception throwable)
	{
		Problem.___003Cclinit_003E();
		this._002Ector(Collections.singletonList(new Problem(Throwable.instancehelper_getMessage(throwable), null, throwable)));
	}

		public virtual List getProblems()
	{
		return problems;
	}

	
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ParseProblemException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
