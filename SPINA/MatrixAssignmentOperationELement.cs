////////////////////////////////////////////////////////////////////////
// MatrixAssignmentOperationElement.cs: holds the data needed for a matrix 
//  assignment operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Rushabh Ravindra Gandhi (rugandhi@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public class MatrixAssignmentOperationElement : Element
{

    MatrixName mLhs;
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatrixAssignmentOperationElement(this);
    }

    public MatrixName getLhs() { return mLhs; }
    public void setLhs(MatrixName lhs) { mLhs = lhs; }

    public Element getRhs() { return mRhs; }
    public void setRhs(Element rhs) { mRhs = rhs; }
}
