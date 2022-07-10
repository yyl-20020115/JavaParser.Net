using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;

namespace javassist.bytecode.annotation;

public class TypeAnnotationsWriter : AnnotationsWriter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 165, 106 })]
	public TypeAnnotationsWriter(OutputStream os, ConstPool cp)
		: base(os, cp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 185, 108, 110 })]
	public virtual void typeParameterTarget(int targetType, int typeParameterIndex)
	{
		output.write(targetType);
		output.write(typeParameterIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 4, 109, 105 })]
	public virtual void supertypeTarget(int supertypeIndex)
	{
		output.write(16);
		write16bit(supertypeIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 15, 108, 108, 110 })]
	public virtual void typeParameterBoundTarget(int targetType, int typeParameterIndex, int boundIndex)
	{
		output.write(targetType);
		output.write(typeParameterIndex);
		output.write(boundIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 25, 110 })]
	public virtual void emptyTarget(int targetType)
	{
		output.write(targetType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 35, 109, 110 })]
	public virtual void formalParameterTarget(int formalParameterIndex)
	{
		output.write(22);
		output.write(formalParameterIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 46, 109, 105 })]
	public virtual void throwsTarget(int throwsTypeIndex)
	{
		output.write(23);
		write16bit(throwsTypeIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 59, 108, 105 })]
	public virtual void localVarTarget(int targetType, int tableLength)
	{
		output.write(targetType);
		write16bit(tableLength);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 70, 103, 103, 105 })]
	public virtual void localVarTargetTable(int startPc, int length, int index)
	{
		write16bit(startPc);
		write16bit(length);
		write16bit(index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 82, 109, 105 })]
	public virtual void catchTarget(int exceptionTableIndex)
	{
		output.write(66);
		write16bit(exceptionTableIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 93, 108, 105 })]
	public virtual void offsetTarget(int targetType, int offset)
	{
		output.write(targetType);
		write16bit(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 104, 108, 103, 110 })]
	public virtual void typeArgumentTarget(int targetType, int offset, int type_argument_index)
	{
		output.write(targetType);
		write16bit(offset);
		output.write(type_argument_index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 113, 110 })]
	public virtual void typePath(int pathLength)
	{
		output.write(pathLength);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 122, 108, 110 })]
	public virtual void typePathPath(int typePathKind, int typeArgumentIndex)
	{
		output.write(typePathKind);
		output.write(typeArgumentIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 175, 105 })]
	public override void numAnnotations(int num)
	{
		base.numAnnotations(num);
	}
}
