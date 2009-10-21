////////////////////////////////////////////////////////////////////////
// Visitor.cs: declares all the abstract Visit functions that each
//  visitor must implement.  Also includes the VisitElement function
//  which alows visiting of an Element when its type is not known.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public abstract class Visitor {

  public abstract void VisitVariableElement(VariableElement element);
  public abstract void VisitIntegerElement(IntegerElement element);
  public abstract void VisitMatrixName(MatrixName element);
  public abstract void VisitMatrixData(MatrixData element);
  public abstract void VisitAssignmentOperationElement(AssignmentOperationElement element);
  public abstract void VisitMatrixAssignmentOperationElement(MatrixAssignmentOperationElement element);
  public abstract void VisitAdditionOperationElement(AdditionOperationElement element);
  public abstract void VisitMatrixAdditionOperationElement(MatrixAdditionOperationElement element);
  public abstract void VisitPrintOperationElement(PrintOperationElement element);
  public abstract void VisitPrintMatOperationElement(PrintMatOperationElement element);
  public abstract void VisitMultiplicationOperationElement(MultiplicationOperationElement element);
  public abstract void VisitMatrixMultiplicationOperationElement(MatrixMultiplicationOperationElement element);

  public void VisitElement(Element element){
    if(element is IntegerElement){
      IntegerElement int_elem = (IntegerElement) element;
      VisitIntegerElement(int_elem);       
    } else if(element is VariableElement){
      VariableElement var_elem = (VariableElement) element;
      VisitVariableElement(var_elem);
    } else if(element is AdditionOperationElement){
      AdditionOperationElement add_elem = (AdditionOperationElement) element;
      VisitAdditionOperationElement(add_elem);
    }
    else if (element is MatrixAdditionOperationElement)
    {
        MatrixAdditionOperationElement mat_add_elem = (MatrixAdditionOperationElement)element;
        VisitMatrixAdditionOperationElement(mat_add_elem);
    }
    else if (element is AssignmentOperationElement)
    {
        AssignmentOperationElement assign_elem = (AssignmentOperationElement)element;
        VisitAssignmentOperationElement(assign_elem);
    }
    else if (element is MultiplicationOperationElement)
    {
        MultiplicationOperationElement mult_elem = (MultiplicationOperationElement)element;
        VisitMultiplicationOperationElement(mult_elem);
    }
    else if (element is MatrixMultiplicationOperationElement)
    {
        MatrixMultiplicationOperationElement mat_mult_elem = (MatrixMultiplicationOperationElement)element;
        VisitMatrixMultiplicationOperationElement(mat_mult_elem);
    }
    else if (element is MatrixName)
    {
        MatrixName mat_name = (MatrixName)element;
        VisitMatrixName(mat_name);
    }
    else if (element is PrintMatOperationElement)
    {
        PrintMatOperationElement print_mat = (PrintMatOperationElement)element;
        VisitPrintMatOperationElement(print_mat);
    }
    else if (element is MatrixData)
    {
        MatrixData mat_data = (MatrixData)element;
        VisitMatrixData(mat_data);
    }
    else if (element is MatrixAssignmentOperationElement)
    {
        MatrixAssignmentOperationElement assign_mat_elem = (MatrixAssignmentOperationElement)element;
        VisitMatrixAssignmentOperationElement(assign_mat_elem);
    }
  }

  protected Visitor() { }
}
