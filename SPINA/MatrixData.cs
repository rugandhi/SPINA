////////////////////////////////////////////////////////////////////////
// MatrixData.cs: holds the data needed to represent a Matrix.
// 
// version: 1.0
// description: Hold the matrix value or data.
// author: Rushabh Ravindra Gandhi (rugandhi@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class MatrixData : Element{

    String mText;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatrixData(this);
    }

    public String getText() { return mText; }
    public void setText(String value) { mText = value; }
}
