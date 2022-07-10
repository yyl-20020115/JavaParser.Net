using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public class ClassFilePrinter : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 186, 97, 142, 127, 28, 52, 133, 124, 63,
		5, 165, 103, 104, 107, 105, 103, 63, 3, 166,
		166, 102, 103, 127, 3, 105, 127, 4, 118, 15,
		165, 111, 133, 102, 104, 127, 4, 105, 127, 4,
		118, 15, 165, 111, 102, 133, 102, 112
	})]
	public static void print(ClassFile cf, PrintWriter @out)
	{
		int mod = AccessFlag.toModifier(cf.getAccessFlags() & -33);
		@out.println(new StringBuilder().append("major: ").append(cf.major).append(", minor: ")
			.append(cf.minor)
			.append(" modifiers: ")
			.append(Integer.toHexString(cf.getAccessFlags()))
			.toString());
		@out.println(new StringBuilder().append(Modifier.toString(mod)).append(" class ").append(cf.getName())
			.append(" extends ")
			.append(cf.getSuperclass())
			.toString());
		string[] interfaces = cf.getInterfaces();
		if (interfaces != null && (nint)interfaces.LongLength > 0)
		{
			@out.print("    implements ");
			@out.print(interfaces[0]);
			for (int i = 1; i < (nint)interfaces.LongLength; i++)
			{
				@out.print(new StringBuilder().append(", ").append(interfaces[i]).toString());
			}
			@out.println();
		}
		@out.println();
		List fields = cf.getFields();
		Iterator iterator = fields.iterator();
		while (iterator.hasNext())
		{
			FieldInfo fieldInfo = (FieldInfo)iterator.next();
			int accessFlags = fieldInfo.getAccessFlags();
			@out.println(new StringBuilder().append(Modifier.toString(AccessFlag.toModifier(accessFlags))).append(" ").append(fieldInfo.getName())
				.append("\t")
				.append(fieldInfo.getDescriptor())
				.toString());
			printAttributes(fieldInfo.getAttributes(), @out, 'f');
		}
		@out.println();
		List methods = cf.getMethods();
		Iterator iterator2 = methods.iterator();
		while (iterator2.hasNext())
		{
			MethodInfo methodInfo = (MethodInfo)iterator2.next();
			int accessFlags2 = methodInfo.getAccessFlags();
			@out.println(new StringBuilder().append(Modifier.toString(AccessFlag.toModifier(accessFlags2))).append(" ").append(methodInfo.getName())
				.append("\t")
				.append(methodInfo.getDescriptor())
				.toString());
			printAttributes(methodInfo.getAttributes(), @out, 'm');
			@out.println();
		}
		@out.println();
		printAttributes(cf.getAttributes(), @out, 'c');
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;Ljava/io/PrintWriter;C)V")]
	[LineNumberTable(new byte[]
	{
		159, 120, 66, 99, 129, 126, 107, 103, 127, 7,
		52, 133, 127, 7, 117, 30, 197, 107, 109, 107,
		101, 104, 159, 11, 104, 159, 11, 104, 107, 108,
		144, 104, 107, 108, 144, 107, 104, 105, 191, 2,
		101, 112, 101, 144, 142, 223, 13, 2, 97, 139,
		130, 127, 7, 118, 20, 165, 101
	})]
	internal static void printAttributes(List P_0, PrintWriter P_1, char P_2)
	{
		if (P_0 == null)
		{
			return;
		}
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			AttributeInfo attributeInfo = (AttributeInfo)iterator.next();
			if (attributeInfo is CodeAttribute)
			{
				CodeAttribute codeAttribute = (CodeAttribute)attributeInfo;
				P_1.println(new StringBuilder().append("attribute: ").append(attributeInfo.getName()).append(": ")
					.append(Object.instancehelper_getClass(attributeInfo).getName())
					.toString());
				P_1.println(new StringBuilder().append("max stack ").append(codeAttribute.getMaxStack()).append(", max locals ")
					.append(codeAttribute.getMaxLocals())
					.append(", ")
					.append(codeAttribute.getExceptionTable().size())
					.append(" catch blocks")
					.toString());
				P_1.println("<code attribute begin>");
				printAttributes(codeAttribute.getAttributes(), P_1, P_2);
				P_1.println("<code attribute end>");
			}
			else if (attributeInfo is AnnotationsAttribute)
			{
				P_1.println(new StringBuilder().append("annnotation: ").append(Object.instancehelper_toString(attributeInfo)).toString());
			}
			else if (attributeInfo is ParameterAnnotationsAttribute)
			{
				P_1.println(new StringBuilder().append("parameter annnotations: ").append(Object.instancehelper_toString(attributeInfo)).toString());
			}
			else if (attributeInfo is StackMapTable)
			{
				P_1.println("<stack map table begin>");
				StackMapTable.Printer.print((StackMapTable)attributeInfo, P_1);
				P_1.println("<stack map table end>");
			}
			else if (attributeInfo is StackMap)
			{
				P_1.println("<stack map begin>");
				((StackMap)attributeInfo).print(P_1);
				P_1.println("<stack map end>");
			}
			else if (attributeInfo is SignatureAttribute)
			{
				SignatureAttribute signatureAttribute = (SignatureAttribute)attributeInfo;
				string signature = signatureAttribute.getSignature();
				P_1.println(new StringBuilder().append("signature: ").append(signature).toString());
				try
				{
					string str = P_2 switch
					{
						'c' => SignatureAttribute.toClassSignature(signature).toString(), 
						'm' => SignatureAttribute.toMethodSignature(signature).toString(), 
						_ => Object.instancehelper_toString(SignatureAttribute.toFieldSignature(signature)), 
					};
					P_1.println(new StringBuilder().append("           ").append(str).toString());
				}
				catch (BadBytecode)
				{
					goto IL_025b;
				}
			}
			else
			{
				P_1.println(new StringBuilder().append("attribute: ").append(attributeInfo.getName()).append(" (")
					.append(attributeInfo.get().Length)
					.append(" byte): ")
					.append(Object.instancehelper_getClass(attributeInfo).getName())
					.toString());
			}
			continue;
			IL_025b:
			_ = null;
			P_1.println("           syntax error");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(29)]
	public ClassFilePrinter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 176, 115 })]
	public static void print(ClassFile cf)
	{
		print(cf, new PrintWriter(java.lang.System.@out, autoFlush: true));
	}
}
