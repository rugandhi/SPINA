////////////////////////////////////////////////////////////////////////
// MatrixMultiplicationOperationElement.java: holds the data needed for a Matrix Multiplication
//  operation.
// 
// version: 1.0
// description: To perform scalar multiplication operation
// author: Rushabh Ravindra Gandhi (rugandhi@syr.edu)
// language: Visual C#
////////////////////////////////////////////////////////////////////////

public class MatrixMultiplicationOperationElement : Element
{

    Element mLhs;
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatrixMultiplicationOperationElement(this);
    }

    public Element getLhs() { return mLhs; }
    public void setLhs(Element lhs) { mLhs = lhs; }

    public Element getRhs() { return mRhs; }
    public void setRhs(Element rhs) { mRhs = rhs; }
}
