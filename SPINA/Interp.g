////////////////////////////////////////////////////////////////////////
// Interp.g: creates a parser for the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: antlr 3.0.1 parser generator - grammer input
////////////////////////////////////////////////////////////////////////

grammar Interp;

options {
  language = 'CSharp';
  output=AST;
} 

@parser::header {
using System.Collections.Generic;
}

@lexer::header {
using System.Collections.Generic;
}

/*
 * Parser Rules
 */
program returns [List<Element> ret]
@init {
  retval.ret = new List<Element>();
}
  : (expr {retval.ret.Add($expr.ret); } )+;

expr returns [Element ret]
  : assignment {retval.ret = $assignment.ret;}
  | mat_assignment {retval.ret = $mat_assignment.ret;}
  | print { retval.ret = $print.ret; }
  | mat_print{retval.ret = $mat_print.ret; };

assignment returns [AssignmentOperationElement ret]
@init {
  retval.ret = new AssignmentOperationElement();
}
  : variable {retval.ret.setLhs($variable.ret); }
    ASSIGNMENT 
    (var_or_int_literal {retval.ret.setRhs($var_or_int_literal.ret); } 
    | addition {retval.ret.setRhs($addition.ret); } 
    | multiplication {retval.ret.setRhs($multiplication.ret);}	
  
    ) END_OF_STATEMENT;

var_or_int_literal returns [Element ret]
  :  (variable { retval.ret = $variable.ret; } 
  |   int_literal {retval.ret = $int_literal.ret; } );

variable returns [VariableElement ret]
@init {
  retval.ret = new VariableElement();
}
  : VARIABLE { retval.ret.setText($VARIABLE.text); };
   

int_literal returns [IntegerElement ret]
@init {
  retval.ret = new IntegerElement();
}
  : INT_LITERAL { retval.ret.setText($INT_LITERAL.text); };

mat_assignment returns [MatrixAssignmentOperationElement ret]
@init {
  retval.ret = new MatrixAssignmentOperationElement();
}
  : mat_name {retval.ret.setLhs($mat_name.ret); }
    ASSIGNMENT 
    mat_var {retval.ret.setRhs($mat_var.ret);};

mat_var returns [Element ret]
  :   (mat_name { retval.ret = $mat_name.ret; } 
  |   mat_data {retval.ret = $mat_data.ret; } );

mat_name returns [MatrixName ret]
@init {
  retval.ret = new MatrixName();
}
  : 'mat' MAT_NAME { retval.ret.setText ($MAT_NAME.text);};

mat_data returns [MatrixData ret]
@init {
  retval.ret = new MatrixData();
}
  : MAT_DATA { retval.ret.setText ($MAT_DATA.text);};

addition returns [AdditionOperationElement ret]
@init {
  retval.ret = new AdditionOperationElement();
}
  : el1=var_or_int_literal { retval.ret.setLhs($el1.ret); } 
    PLUS 
    el2=var_or_int_literal { retval.ret.setRhs($el2.ret); };

multiplication returns [MultiplicationOperationElement ret]
@init {
  retval.ret = new MultiplicationOperationElement();
}
  : el1=var_or_int_literal { retval.ret.setLhs($el1.ret); } 
    MULT 
    el2=var_or_int_literal { retval.ret.setRhs($el2.ret); };


print returns [PrintOperationElement ret]
@init {
  retval.ret = new PrintOperationElement();
}
  : 'print' var_or_int_literal {retval.ret.setChildElement($var_or_int_literal.ret); }END_OF_STATEMENT; 

mat_print returns [PrintMatOperationElement ret]
@init {
  retval.ret = new PrintMatOperationElement();
}
  : 'print_mat' VARIABLE { retval.ret.setText($VARIABLE.text);};


/*
 * Lexer Rules
 */

END_OF_STATEMENT: ';';
ASSIGNMENT: '=';
PLUS: '+';
MULT: '*';
VARIABLE: ('a'..'z' | 'A'..'Z' )+;
INT_LITERAL: ('0'..'9')+;
MAT_NAME: (VARIABLE INT_LITERAL? ('[' INT_LITERAL ']')+ );
MAT_PRINT_NAME: (VARIABLE INT_LITERAL?);
MAT_DATA: ( '[' ( (INT_LITERAL) | ((INT_LITERAL ',')+ INT_LITERAL) | (('[' (INT_LITERAL ',')+ INT_LITERAL ']')+ ) ) ']');
WHITESPACE : (' ' | '\t' | '\n' | '\r' )+ {$channel = HIDDEN; } ;

