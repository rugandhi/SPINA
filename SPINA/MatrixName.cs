////////////////////////////////////////////////////////////////////////
// MatrixName.cs: holds the name to represent matrix variables 
//  in the Interp language.
// 
// version: 1.0
// description: To assign name to a matrix variable
// author: Rushabh Ravindra Gandhi (rugandhi@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class MatrixName : Element
{

    String mText;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatrixName(this);
    }

    public String getText() { return mText; }
    public void setText(String text) { mText = text; }
}
