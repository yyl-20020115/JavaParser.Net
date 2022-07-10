using IKVM.Attributes;

namespace com.github.javaparser;

public interface CharStream
{
	
	 char readChar();

	 int getBeginColumn();

	 int getBeginLine();

	 int getEndColumn();

	 int getEndLine();

	
	 void backup(int amount);

	
	 char beginToken();

	 string getImage();

	
	 char[] getSuffix(int len);

	 void done();

	 int getTabSize();

	
	 void setTabSize(int i);

	 bool isTrackLineColumn();

	
	 void setTrackLineColumn(bool trackLineColumn);
}
