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
  Stack<int[,]> matStack;

  public InterpreterVisitor(){
    mVariableMap = new Hashtable();
    mStack = new Stack<int>();
    matStack = new Stack<int[,]>();
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
  
  public override void VisitAssignmentOperationElement(AssignmentOperationElement element)
  {
      String variable_name = element.getLhs().getText();
      Element rhs = element.getRhs();
      VisitElement(rhs);
      int result = mStack.Pop();
      mVariableMap[variable_name] = result;
  }
  public override void VisitAdditionOperationElement(AdditionOperationElement element)
  {
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
  public override void VisitMatrixName(MatrixName element)
  {
      if (mVariableMap.ContainsKey(element.getText()))
      {
          int[,] element_value = (int[,])mVariableMap[element.getText()];
          matStack.Push(element_value);
      }
      else { }
  }
  public override void VisitMatrixData(MatrixData element)
  {
      String MatrixValues = element.getText();
      int rowsize = 0, colsize = 0;
      for (int i = 1; i < MatrixValues.LastIndexOf(']'); i++)
      {
          if (MatrixValues[i] == ',')
          {   colsize++;      continue; }
          if (MatrixValues[i] == '[')
           continue; 
          if (MatrixValues[i] == ']')
          { rowsize++; continue; }
          int element_value = int.Parse(MatrixValues[i].ToString());
          mStack.Push(element_value);
      }
      colsize = (colsize / rowsize) + 1;
      int[,] mat = new int[rowsize, colsize];
      for (int i = rowsize - 1; i >= 0; i--)
          for (int j = colsize - 1; j >= 0; j--)
          {
              int result = mStack.Pop();
              mat[i, j] = result;
          }
      matStack.Push(mat);
  }

  public override void VisitMatrixAssignmentOperationElement(MatrixAssignmentOperationElement element)
  {
      Element rhs = element.getRhs();
      VisitElement(rhs);
      String mat_name = element.getLhs().getText();       
      int[,] mat_data = matStack.Pop();
      mVariableMap[mat_name] = mat_data;
  }

  public override void VisitMatrixAdditionOperationElement(MatrixAdditionOperationElement element)
  {
      VisitElement(element.getLhs());
      VisitElement(element.getRhs());
      int[,] mat2 = matStack.Pop();
      int[,] mat1 = matStack.Pop();
      int[,] temp = new int[mat2.GetLength(0), mat2.GetLength(1)];
      if (mat1.GetLength(0) == mat2.GetLength(0) && mat1.GetLength(1) == mat2.GetLength(1))
      {
          for (int i = 0; i < mat2.GetLength(0); i++)
              for (int j = 0; j < mat2.GetLength(1); j++)
                  temp[i, j] = mat1[i, j] + mat2[i, j];
      }
      else
          Console.Write("\n\nINVALID SIZE TO ADD \n");
      matStack.Push(temp);
  }
  public override void VisitMatrixMultiplicationOperationElement(MatrixMultiplicationOperationElement element)
  {
      VisitElement(element.getLhs());
      VisitElement(element.getRhs());
      int[,] mat2 = matStack.Pop();
      int[,] mat1 = matStack.Pop();
      int[,] temp = new int[mat1.GetLength(0), mat2.GetLength(1)];
      if (mat1.GetLength(1) == mat2.GetLength(0))
      {
          for (int i = 0; i < mat1.GetLength(0); i++)
              for (int j = 0; j < mat2.GetLength(1); j++)
              {
                  int sum = 0;
                  for (int k = 0; k < mat1.GetLength(1); k++)
                      sum += (mat1[i, k] * mat2[k, j]);
                  temp[i, j] = sum;
              }
      }
      else
          Console.Write("\n\nINVALID SIZE TO MULTIPLY\n");
      matStack.Push(temp);
  }
  public override void VisitPrintMatOperationElement(PrintMatOperationElement element)
  {
      String matname = element.getText();
      int[,] mat = (int[,])mVariableMap[matname];
      for (int i = 0; i < mat.GetLength(0); i++)
      {
          for (int j = 0; j < mat.GetLength(1); j++)
              Console.Write(mat[i, j] + " ");
          Console.WriteLine();
      }
  }
}
