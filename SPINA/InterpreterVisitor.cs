////////////////////////////////////////////////////////////////////////
// InterpreterVisitor.cs: Implements a vistor that interprets the 
//  syntax tree.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections;

public class InterpreterVisitor : Visitor {

  Hashtable mVariableMap;
  Stack<int> mStack;

  public InterpreterVisitor(){
    mVariableMap = new Hashtable();
    mStack = new Stack<int>();
  }

  public override void VisitVariableElement(VariableElement element){
    if(mVariableMap.ContainsKey(element.getText())){
      int element_value = (int) mVariableMap[element.getText()];
      mStack.Push(element_value);
    } else {
      //lets assume that the syntax has been checked for this example because I don't like the exception
      //propegation that will happen if I throw here
      //throw new Exception("Variable " + element.getText() + " not defined.");
    }
  }
  public override void VisitIntegerElement(IntegerElement element){
    int element_value = int.Parse(element.getText());
    mStack.Push(element_value);
  }
  public override void VisitMatrixName(MatrixName element)
  {
      if (mVariableMap.ContainsKey(element.getText()))
      {
          int element_value = (int)mVariableMap[element.getText()];
          mStack.Push(element_value);
      }
      else{ }
  }
  public override void VisitMatrixData(MatrixData element)
  {
      String MatrixValues = element.getText();
      for (int i = 1; i<MatrixValues.LastIndexOf(']'); i++)
      {
          if (MatrixValues[i] == ',' | MatrixValues[i] == '[' | MatrixValues[i] == ']')
              continue;
          int element_value = int.Parse(MatrixValues[i].ToString());
          mStack.Push(element_value);
      }    
  }
  public override void VisitAssignmentOperationElement(AssignmentOperationElement element){
    String variable_name = element.getLhs().getText();
    Element rhs = element.getRhs();
    VisitElement(rhs); 
    int result = mStack.Pop();    
    mVariableMap[variable_name] = result;
  }
  public override void VisitMatrixAssignmentOperationElement(MatrixAssignmentOperationElement element)
  {
      String mat_fullname = element.getLhs().getText();
      String mat_name = mat_fullname.Substring(0,mat_fullname.IndexOf("["));
      String row_sizeText = mat_fullname.Substring(mat_fullname.IndexOf("[")+1, mat_fullname.IndexOf("]")-mat_fullname.IndexOf("[")-1);
      String col_sizeText = mat_fullname.Substring(mat_fullname.LastIndexOf("[")+1, mat_fullname.LastIndexOf("]")- mat_fullname.LastIndexOf("[")-1);
      int row_size = int.Parse(row_sizeText);
      int col_size = int.Parse(col_sizeText);
      int[,] mat= new int[row_size,col_size];

      Element rhs = element.getRhs();
      String S = rhs.ToString();
      VisitElement(rhs);             
      for(int i=row_size-1;i>=0;i--)
          for (int j = col_size-1; j >=0 ; j--)
          {
              int result = mStack.Pop();
              mat[i, j] = result;
          }  
      mVariableMap[mat_name] = mat;
  }
  public override void VisitAdditionOperationElement(AdditionOperationElement element){
    VisitElement(element.getLhs());
    VisitElement(element.getRhs());
    int rhs = mStack.Pop();
    int lhs = mStack.Pop();
    int result = rhs + lhs;
    mStack.Push(result);    
  }
  public override void VisitMultiplicationOperationElement(MultiplicationOperationElement element)
  {
      VisitElement(element.getLhs());
      VisitElement(element.getRhs());
      int rhs = mStack.Pop();
      int lhs = mStack.Pop();
      int result = rhs * lhs;
      mStack.Push(result);
  }
  public override void VisitPrintOperationElement(PrintOperationElement element){
    VisitElement(element.getChildElement());
    int result = mStack.Pop();
    Console.WriteLine(result.ToString());
  }
  public override void VisitPrintMatOperationElement(PrintMatOperationElement element)
  {
      String matname = element.getText();
      int[,] mat = (int[,])mVariableMap[matname];
      for (int i = 0; i < mat.GetLength(0); i++)
      {
          for (int j = 0; j < mat.GetLength(1); j++)
              Console.Write(mat[i,j] + " ");
          Console.WriteLine();
      }
  }
}
