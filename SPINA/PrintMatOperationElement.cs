////////////////////////////////////////////////////////////////////////
// PrintMatOperationElement.cs: hold the matrix data needed to implement the
//  'print' function in the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Rushabh Ravindra Gandhi  (rugandhi@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

using System;
public class PrintMatOperationElement : Element
{
    //Element mChildElement;

    //public Element getChildElement() { return mChildElement; }
    //public void setChildElement(Element value) { mChildElement = value; }

    String mText;

    public String getText() { return mText; }
    public void setText(String text) { mText = text; }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitPrintMatOperationElement(this);
    }
}
