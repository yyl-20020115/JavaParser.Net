using System;



using com.github.javaparser.resolution.types;

using java.lang;

namespace com.github.javaparser.symbolsolver.logic;


public class ConfilictingGenericTypesException : RuntimeException
{
	
	
	public ConfilictingGenericTypesException(ResolvedType formalType, ResolvedType actualType)
		: base(java.lang.String.format("No matching between %s (formal) and %s (actual)", formalType, actualType))
	{
	}

	
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ConfilictingGenericTypesException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
