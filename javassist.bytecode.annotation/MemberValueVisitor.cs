namespace javassist.bytecode.annotation;

public interface MemberValueVisitor
{
	virtual void visitAnnotationMemberValue(AnnotationMemberValue amv);

	virtual void visitArrayMemberValue(ArrayMemberValue amv);

	virtual void visitBooleanMemberValue(BooleanMemberValue bmv);

	virtual void visitByteMemberValue(ByteMemberValue bmv);

	virtual void visitCharMemberValue(CharMemberValue cmv);

	virtual void visitClassMemberValue(ClassMemberValue cmv);

	virtual void visitDoubleMemberValue(DoubleMemberValue dmv);

	virtual void visitEnumMemberValue(EnumMemberValue emv);

	virtual void visitFloatMemberValue(FloatMemberValue fmv);

	virtual void visitIntegerMemberValue(IntegerMemberValue imv);

	virtual void visitLongMemberValue(LongMemberValue lmv);

	virtual void visitShortMemberValue(ShortMemberValue smv);

	virtual void visitStringMemberValue(StringMemberValue smv);
}
