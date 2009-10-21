// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-21 01:30:35


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public class InterpParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ASSIGNMENT", 
		"END_OF_STATEMENT", 
		"VARIABLE", 
		"INT_LITERAL", 
		"PLUS", 
		"MULT", 
		"MAT_DATA", 
		"WHITESPACE", 
		"'print'", 
		"'mat'", 
		"'print_mat'"
    };

    public const int INT_LITERAL = 7;
    public const int VARIABLE = 6;
    public const int T__12 = 12;
    public const int T__14 = 14;
    public const int T__13 = 13;
    public const int WHITESPACE = 11;
    public const int PLUS = 8;
    public const int ASSIGNMENT = 4;
    public const int MULT = 9;
    public const int EOF = -1;
    public const int MAT_DATA = 10;
    public const int END_OF_STATEMENT = 5;

    // delegates
    // delegators



        public InterpParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public InterpParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
       }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return InterpParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Interp.g"; }
    }


    public class program_return : ParserRuleReturnScope
    {
        public List<Element> ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // Interp.g:29:1: program returns [List<Element> ret] : ( expr )+ ;
    public InterpParser.program_return program() // throws RecognitionException [1]
    {   
        InterpParser.program_return retval = new InterpParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // Interp.g:33:3: ( ( expr )+ )
            // Interp.g:33:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:33:5: ( expr )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == VARIABLE || (LA1_0 >= 12 && LA1_0 <= 14)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Interp.g:33:6: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_program74);
            			    	expr1 = expr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr1.Tree);
            			    	retval.ret.Add(((expr1 != null) ? expr1.ret : null)); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class expr_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr"
    // Interp.g:35:1: expr returns [Element ret] : ( assignment | mat_assignment | print | mat_print );
    public InterpParser.expr_return expr() // throws RecognitionException [1]
    {   
        InterpParser.expr_return retval = new InterpParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.assignment_return assignment2 = null;

        InterpParser.mat_assignment_return mat_assignment3 = null;

        InterpParser.print_return print4 = null;

        InterpParser.mat_print_return mat_print5 = null;



        try 
    	{
            // Interp.g:36:3: ( assignment | mat_assignment | print | mat_print )
            int alt2 = 4;
            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            	{
                alt2 = 1;
                }
                break;
            case 13:
            	{
                alt2 = 2;
                }
                break;
            case 12:
            	{
                alt2 = 3;
                }
                break;
            case 14:
            	{
                alt2 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // Interp.g:36:5: assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expr93);
                    	assignment2 = assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, assignment2.Tree);
                    	retval.ret = ((assignment2 != null) ? assignment2.ret : null);

                    }
                    break;
                case 2 :
                    // Interp.g:37:5: mat_assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mat_assignment_in_expr101);
                    	mat_assignment3 = mat_assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mat_assignment3.Tree);
                    	retval.ret = ((mat_assignment3 != null) ? mat_assignment3.ret : null);

                    }
                    break;
                case 3 :
                    // Interp.g:38:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr109);
                    	print4 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print4.Tree);
                    	 retval.ret = ((print4 != null) ? print4.ret : null); 

                    }
                    break;
                case 4 :
                    // Interp.g:39:5: mat_print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mat_print_in_expr117);
                    	mat_print5 = mat_print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mat_print5.Tree);
                    	retval.ret = ((mat_print5 != null) ? mat_print5.ret : null); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class assignment_return : ParserRuleReturnScope
    {
        public AssignmentOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignment"
    // Interp.g:41:1: assignment returns [AssignmentOperationElement ret] : variable ASSIGNMENT ( var_or_int_literal | addition | multiplication ) END_OF_STATEMENT ;
    public InterpParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        InterpParser.assignment_return retval = new InterpParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT7 = null;
        IToken END_OF_STATEMENT11 = null;
        InterpParser.variable_return variable6 = null;

        InterpParser.var_or_int_literal_return var_or_int_literal8 = null;

        InterpParser.addition_return addition9 = null;

        InterpParser.multiplication_return multiplication10 = null;


        object ASSIGNMENT7_tree=null;
        object END_OF_STATEMENT11_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // Interp.g:45:3: ( variable ASSIGNMENT ( var_or_int_literal | addition | multiplication ) END_OF_STATEMENT )
            // Interp.g:45:5: variable ASSIGNMENT ( var_or_int_literal | addition | multiplication ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_assignment137);
            	variable6 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable6.Tree);
            	retval.ret.setLhs(((variable6 != null) ? variable6.ret : null)); 
            	ASSIGNMENT7=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment145); 
            		ASSIGNMENT7_tree = (object)adaptor.Create(ASSIGNMENT7);
            		adaptor.AddChild(root_0, ASSIGNMENT7_tree);

            	// Interp.g:47:5: ( var_or_int_literal | addition | multiplication )
            	int alt3 = 3;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == VARIABLE) )
            	{
            	    switch ( input.LA(2) ) 
            	    {
            	    case END_OF_STATEMENT:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    case PLUS:
            	    	{
            	        alt3 = 2;
            	        }
            	        break;
            	    case MULT:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d3s1 =
            	    	        new NoViableAltException("", 3, 1, input);

            	    	    throw nvae_d3s1;
            	    }

            	}
            	else if ( (LA3_0 == INT_LITERAL) )
            	{
            	    switch ( input.LA(2) ) 
            	    {
            	    case MULT:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;
            	    case END_OF_STATEMENT:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    case PLUS:
            	    	{
            	        alt3 = 2;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d3s2 =
            	    	        new NoViableAltException("", 3, 2, input);

            	    	    throw nvae_d3s2;
            	    }

            	}
            	else 
            	{
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // Interp.g:47:6: var_or_int_literal
            	        {
            	        	PushFollow(FOLLOW_var_or_int_literal_in_assignment153);
            	        	var_or_int_literal8 = var_or_int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_or_int_literal8.Tree);
            	        	retval.ret.setRhs(((var_or_int_literal8 != null) ? var_or_int_literal8.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:48:7: addition
            	        {
            	        	PushFollow(FOLLOW_addition_in_assignment164);
            	        	addition9 = addition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, addition9.Tree);
            	        	retval.ret.setRhs(((addition9 != null) ? addition9.ret : null)); 

            	        }
            	        break;
            	    case 3 :
            	        // Interp.g:49:7: multiplication
            	        {
            	        	PushFollow(FOLLOW_multiplication_in_assignment175);
            	        	multiplication10 = multiplication();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, multiplication10.Tree);
            	        	retval.ret.setRhs(((multiplication10 != null) ? multiplication10.ret : null));

            	        }
            	        break;

            	}

            	END_OF_STATEMENT11=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment189); 
            		END_OF_STATEMENT11_tree = (object)adaptor.Create(END_OF_STATEMENT11);
            		adaptor.AddChild(root_0, END_OF_STATEMENT11_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class var_or_int_literal_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "var_or_int_literal"
    // Interp.g:53:1: var_or_int_literal returns [Element ret] : ( variable | int_literal ) ;
    public InterpParser.var_or_int_literal_return var_or_int_literal() // throws RecognitionException [1]
    {   
        InterpParser.var_or_int_literal_return retval = new InterpParser.var_or_int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.variable_return variable12 = null;

        InterpParser.int_literal_return int_literal13 = null;



        try 
    	{
            // Interp.g:54:3: ( ( variable | int_literal ) )
            // Interp.g:54:6: ( variable | int_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:54:6: ( variable | int_literal )
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == VARIABLE) )
            	{
            	    alt4 = 1;
            	}
            	else if ( (LA4_0 == INT_LITERAL) )
            	{
            	    alt4 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Interp.g:54:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_or_int_literal205);
            	        	variable12 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable12.Tree);
            	        	 retval.ret = ((variable12 != null) ? variable12.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:55:7: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_or_int_literal216);
            	        	int_literal13 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal13.Tree);
            	        	retval.ret = ((int_literal13 != null) ? int_literal13.ret : null); 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "var_or_int_literal"

    public class variable_return : ParserRuleReturnScope
    {
        public VariableElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variable"
    // Interp.g:57:1: variable returns [VariableElement ret] : VARIABLE ;
    public InterpParser.variable_return variable() // throws RecognitionException [1]
    {   
        InterpParser.variable_return retval = new InterpParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE14 = null;

        object VARIABLE14_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // Interp.g:61:3: ( VARIABLE )
            // Interp.g:61:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE14=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable239); 
            		VARIABLE14_tree = (object)adaptor.Create(VARIABLE14);
            		adaptor.AddChild(root_0, VARIABLE14_tree);

            	 retval.ret.setText(((VARIABLE14 != null) ? VARIABLE14.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variable"

    public class int_literal_return : ParserRuleReturnScope
    {
        public IntegerElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "int_literal"
    // Interp.g:63:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public InterpParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        InterpParser.int_literal_return retval = new InterpParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL15 = null;

        object INT_LITERAL15_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // Interp.g:67:3: ( INT_LITERAL )
            // Interp.g:67:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL15=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal263); 
            		INT_LITERAL15_tree = (object)adaptor.Create(INT_LITERAL15);
            		adaptor.AddChild(root_0, INT_LITERAL15_tree);

            	 retval.ret.setText(((INT_LITERAL15 != null) ? INT_LITERAL15.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "int_literal"

    public class addition_return : ParserRuleReturnScope
    {
        public AdditionOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "addition"
    // Interp.g:69:1: addition returns [AdditionOperationElement ret] : el1= var_or_int_literal PLUS el2= var_or_int_literal ;
    public InterpParser.addition_return addition() // throws RecognitionException [1]
    {   
        InterpParser.addition_return retval = new InterpParser.addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS16 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object PLUS16_tree=null;


          retval.ret = new AdditionOperationElement();

        try 
    	{
            // Interp.g:73:3: (el1= var_or_int_literal PLUS el2= var_or_int_literal )
            // Interp.g:73:5: el1= var_or_int_literal PLUS el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_addition286);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	PLUS16=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition295); 
            		PLUS16_tree = (object)adaptor.Create(PLUS16);
            		adaptor.AddChild(root_0, PLUS16_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_addition304);
            	el2 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	 retval.ret.setRhs(((el2 != null) ? el2.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "addition"

    public class multiplication_return : ParserRuleReturnScope
    {
        public MultiplicationOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiplication"
    // Interp.g:77:1: multiplication returns [MultiplicationOperationElement ret] : el1= var_or_int_literal MULT el2= var_or_int_literal ;
    public InterpParser.multiplication_return multiplication() // throws RecognitionException [1]
    {   
        InterpParser.multiplication_return retval = new InterpParser.multiplication_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULT17 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object MULT17_tree=null;


          retval.ret = new MultiplicationOperationElement();

        try 
    	{
            // Interp.g:81:3: (el1= var_or_int_literal MULT el2= var_or_int_literal )
            // Interp.g:81:5: el1= var_or_int_literal MULT el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_multiplication327);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	MULT17=(IToken)Match(input,MULT,FOLLOW_MULT_in_multiplication336); 
            		MULT17_tree = (object)adaptor.Create(MULT17);
            		adaptor.AddChild(root_0, MULT17_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_multiplication345);
            	el2 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	 retval.ret.setRhs(((el2 != null) ? el2.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplication"

    public class print_return : ParserRuleReturnScope
    {
        public PrintOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "print"
    // Interp.g:85:1: print returns [PrintOperationElement ret] : 'print' var_or_int_literal END_OF_STATEMENT ;
    public InterpParser.print_return print() // throws RecognitionException [1]
    {   
        InterpParser.print_return retval = new InterpParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal18 = null;
        IToken END_OF_STATEMENT20 = null;
        InterpParser.var_or_int_literal_return var_or_int_literal19 = null;


        object string_literal18_tree=null;
        object END_OF_STATEMENT20_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // Interp.g:89:3: ( 'print' var_or_int_literal END_OF_STATEMENT )
            // Interp.g:89:5: 'print' var_or_int_literal END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal18=(IToken)Match(input,12,FOLLOW_12_in_print366); 
            		string_literal18_tree = (object)adaptor.Create(string_literal18);
            		adaptor.AddChild(root_0, string_literal18_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_print368);
            	var_or_int_literal19 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_or_int_literal19.Tree);
            	retval.ret.setChildElement(((var_or_int_literal19 != null) ? var_or_int_literal19.ret : null)); 
            	END_OF_STATEMENT20=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print371); 
            		END_OF_STATEMENT20_tree = (object)adaptor.Create(END_OF_STATEMENT20);
            		adaptor.AddChild(root_0, END_OF_STATEMENT20_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "print"

    public class mat_assignment_return : ParserRuleReturnScope
    {
        public MatrixAssignmentOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mat_assignment"
    // Interp.g:95:1: mat_assignment returns [MatrixAssignmentOperationElement ret] : mat_name ASSIGNMENT ( mat_var | mat_addition | mat_multiplication ) END_OF_STATEMENT ;
    public InterpParser.mat_assignment_return mat_assignment() // throws RecognitionException [1]
    {   
        InterpParser.mat_assignment_return retval = new InterpParser.mat_assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT22 = null;
        IToken END_OF_STATEMENT26 = null;
        InterpParser.mat_name_return mat_name21 = null;

        InterpParser.mat_var_return mat_var23 = null;

        InterpParser.mat_addition_return mat_addition24 = null;

        InterpParser.mat_multiplication_return mat_multiplication25 = null;


        object ASSIGNMENT22_tree=null;
        object END_OF_STATEMENT26_tree=null;


          retval.ret = new MatrixAssignmentOperationElement();

        try 
    	{
            // Interp.g:99:3: ( mat_name ASSIGNMENT ( mat_var | mat_addition | mat_multiplication ) END_OF_STATEMENT )
            // Interp.g:99:5: mat_name ASSIGNMENT ( mat_var | mat_addition | mat_multiplication ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mat_name_in_mat_assignment395);
            	mat_name21 = mat_name();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, mat_name21.Tree);
            	retval.ret.setLhs(((mat_name21 != null) ? mat_name21.ret : null)); 
            	ASSIGNMENT22=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_mat_assignment403); 
            		ASSIGNMENT22_tree = (object)adaptor.Create(ASSIGNMENT22);
            		adaptor.AddChild(root_0, ASSIGNMENT22_tree);

            	// Interp.g:101:5: ( mat_var | mat_addition | mat_multiplication )
            	int alt5 = 3;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == 13) )
            	{
            	    int LA5_1 = input.LA(2);

            	    if ( (LA5_1 == VARIABLE) )
            	    {
            	        switch ( input.LA(3) ) 
            	        {
            	        case END_OF_STATEMENT:
            	        	{
            	            alt5 = 1;
            	            }
            	            break;
            	        case MULT:
            	        	{
            	            alt5 = 3;
            	            }
            	            break;
            	        case PLUS:
            	        	{
            	            alt5 = 2;
            	            }
            	            break;
            	        	default:
            	        	    NoViableAltException nvae_d5s3 =
            	        	        new NoViableAltException("", 5, 3, input);

            	        	    throw nvae_d5s3;
            	        }

            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d5s1 =
            	            new NoViableAltException("", 5, 1, input);

            	        throw nvae_d5s1;
            	    }
            	}
            	else if ( (LA5_0 == MAT_DATA) )
            	{
            	    alt5 = 1;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    throw nvae_d5s0;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // Interp.g:101:6: mat_var
            	        {
            	        	PushFollow(FOLLOW_mat_var_in_mat_assignment411);
            	        	mat_var23 = mat_var();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, mat_var23.Tree);
            	        	retval.ret.setRhs(((mat_var23 != null) ? mat_var23.ret : null));

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:102:7: mat_addition
            	        {
            	        	PushFollow(FOLLOW_mat_addition_in_mat_assignment421);
            	        	mat_addition24 = mat_addition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, mat_addition24.Tree);
            	        	retval.ret.setRhs(((mat_addition24 != null) ? mat_addition24.ret : null)); 

            	        }
            	        break;
            	    case 3 :
            	        // Interp.g:103:7: mat_multiplication
            	        {
            	        	PushFollow(FOLLOW_mat_multiplication_in_mat_assignment432);
            	        	mat_multiplication25 = mat_multiplication();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, mat_multiplication25.Tree);
            	        	retval.ret.setRhs(((mat_multiplication25 != null) ? mat_multiplication25.ret : null)); 

            	        }
            	        break;

            	}

            	END_OF_STATEMENT26=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_mat_assignment443); 
            		END_OF_STATEMENT26_tree = (object)adaptor.Create(END_OF_STATEMENT26);
            		adaptor.AddChild(root_0, END_OF_STATEMENT26_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "mat_assignment"

    public class mat_var_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mat_var"
    // Interp.g:107:1: mat_var returns [Element ret] : ( mat_name | mat_data ) ;
    public InterpParser.mat_var_return mat_var() // throws RecognitionException [1]
    {   
        InterpParser.mat_var_return retval = new InterpParser.mat_var_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.mat_name_return mat_name27 = null;

        InterpParser.mat_data_return mat_data28 = null;



        try 
    	{
            // Interp.g:108:3: ( ( mat_name | mat_data ) )
            // Interp.g:108:7: ( mat_name | mat_data )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:108:7: ( mat_name | mat_data )
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == 13) )
            	{
            	    alt6 = 1;
            	}
            	else if ( (LA6_0 == MAT_DATA) )
            	{
            	    alt6 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // Interp.g:108:8: mat_name
            	        {
            	        	PushFollow(FOLLOW_mat_name_in_mat_var461);
            	        	mat_name27 = mat_name();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, mat_name27.Tree);
            	        	 retval.ret = ((mat_name27 != null) ? mat_name27.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:109:7: mat_data
            	        {
            	        	PushFollow(FOLLOW_mat_data_in_mat_var472);
            	        	mat_data28 = mat_data();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, mat_data28.Tree);
            	        	retval.ret = ((mat_data28 != null) ? mat_data28.ret : null); 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "mat_var"

    public class mat_name_return : ParserRuleReturnScope
    {
        public MatrixName ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mat_name"
    // Interp.g:111:1: mat_name returns [MatrixName ret] : 'mat' VARIABLE ;
    public InterpParser.mat_name_return mat_name() // throws RecognitionException [1]
    {   
        InterpParser.mat_name_return retval = new InterpParser.mat_name_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal29 = null;
        IToken VARIABLE30 = null;

        object string_literal29_tree=null;
        object VARIABLE30_tree=null;


          retval.ret = new MatrixName();

        try 
    	{
            // Interp.g:115:3: ( 'mat' VARIABLE )
            // Interp.g:115:5: 'mat' VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal29=(IToken)Match(input,13,FOLLOW_13_in_mat_name495); 
            		string_literal29_tree = (object)adaptor.Create(string_literal29);
            		adaptor.AddChild(root_0, string_literal29_tree);

            	VARIABLE30=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_mat_name497); 
            		VARIABLE30_tree = (object)adaptor.Create(VARIABLE30);
            		adaptor.AddChild(root_0, VARIABLE30_tree);

            	 retval.ret.setText (((VARIABLE30 != null) ? VARIABLE30.Text : null));

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "mat_name"

    public class mat_data_return : ParserRuleReturnScope
    {
        public MatrixData ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mat_data"
    // Interp.g:117:1: mat_data returns [MatrixData ret] : MAT_DATA ;
    public InterpParser.mat_data_return mat_data() // throws RecognitionException [1]
    {   
        InterpParser.mat_data_return retval = new InterpParser.mat_data_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MAT_DATA31 = null;

        object MAT_DATA31_tree=null;


          retval.ret = new MatrixData();

        try 
    	{
            // Interp.g:121:3: ( MAT_DATA )
            // Interp.g:121:5: MAT_DATA
            {
            	root_0 = (object)adaptor.GetNilNode();

            	MAT_DATA31=(IToken)Match(input,MAT_DATA,FOLLOW_MAT_DATA_in_mat_data518); 
            		MAT_DATA31_tree = (object)adaptor.Create(MAT_DATA31);
            		adaptor.AddChild(root_0, MAT_DATA31_tree);

            	 retval.ret.setText (((MAT_DATA31 != null) ? MAT_DATA31.Text : null));

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "mat_data"

    public class mat_addition_return : ParserRuleReturnScope
    {
        public MatrixAdditionOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mat_addition"
    // Interp.g:123:1: mat_addition returns [MatrixAdditionOperationElement ret] : el1= mat_name PLUS el2= mat_name ;
    public InterpParser.mat_addition_return mat_addition() // throws RecognitionException [1]
    {   
        InterpParser.mat_addition_return retval = new InterpParser.mat_addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS32 = null;
        InterpParser.mat_name_return el1 = null;

        InterpParser.mat_name_return el2 = null;


        object PLUS32_tree=null;


          retval.ret = new MatrixAdditionOperationElement();

        try 
    	{
            // Interp.g:127:3: (el1= mat_name PLUS el2= mat_name )
            // Interp.g:127:5: el1= mat_name PLUS el2= mat_name
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mat_name_in_mat_addition541);
            	el1 = mat_name();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	PLUS32=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_mat_addition550); 
            		PLUS32_tree = (object)adaptor.Create(PLUS32);
            		adaptor.AddChild(root_0, PLUS32_tree);

            	PushFollow(FOLLOW_mat_name_in_mat_addition559);
            	el2 = mat_name();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	 retval.ret.setRhs(((el2 != null) ? el2.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "mat_addition"

    public class mat_multiplication_return : ParserRuleReturnScope
    {
        public MatrixMultiplicationOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mat_multiplication"
    // Interp.g:131:1: mat_multiplication returns [MatrixMultiplicationOperationElement ret] : el1= mat_name MULT el2= mat_name ;
    public InterpParser.mat_multiplication_return mat_multiplication() // throws RecognitionException [1]
    {   
        InterpParser.mat_multiplication_return retval = new InterpParser.mat_multiplication_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULT33 = null;
        InterpParser.mat_name_return el1 = null;

        InterpParser.mat_name_return el2 = null;


        object MULT33_tree=null;


          retval.ret = new MatrixMultiplicationOperationElement();

        try 
    	{
            // Interp.g:135:3: (el1= mat_name MULT el2= mat_name )
            // Interp.g:135:5: el1= mat_name MULT el2= mat_name
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mat_name_in_mat_multiplication582);
            	el1 = mat_name();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	MULT33=(IToken)Match(input,MULT,FOLLOW_MULT_in_mat_multiplication591); 
            		MULT33_tree = (object)adaptor.Create(MULT33);
            		adaptor.AddChild(root_0, MULT33_tree);

            	PushFollow(FOLLOW_mat_name_in_mat_multiplication600);
            	el2 = mat_name();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	 retval.ret.setRhs(((el2 != null) ? el2.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "mat_multiplication"

    public class mat_print_return : ParserRuleReturnScope
    {
        public PrintMatOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mat_print"
    // Interp.g:139:1: mat_print returns [PrintMatOperationElement ret] : 'print_mat' VARIABLE ;
    public InterpParser.mat_print_return mat_print() // throws RecognitionException [1]
    {   
        InterpParser.mat_print_return retval = new InterpParser.mat_print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal34 = null;
        IToken VARIABLE35 = null;

        object string_literal34_tree=null;
        object VARIABLE35_tree=null;


          retval.ret = new PrintMatOperationElement();

        try 
    	{
            // Interp.g:143:3: ( 'print_mat' VARIABLE )
            // Interp.g:143:5: 'print_mat' VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal34=(IToken)Match(input,14,FOLLOW_14_in_mat_print621); 
            		string_literal34_tree = (object)adaptor.Create(string_literal34);
            		adaptor.AddChild(root_0, string_literal34_tree);

            	VARIABLE35=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_mat_print623); 
            		VARIABLE35_tree = (object)adaptor.Create(VARIABLE35);
            		adaptor.AddChild(root_0, VARIABLE35_tree);

            	 retval.ret.setText(((VARIABLE35 != null) ? VARIABLE35.Text : null));

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "mat_print"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_expr_in_program74 = new BitSet(new ulong[]{0x0000000000007042UL});
    public static readonly BitSet FOLLOW_assignment_in_expr93 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mat_assignment_in_expr101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mat_print_in_expr117 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment137 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment145 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_assignment153 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_addition_in_assignment164 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_multiplication_in_assignment175 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment189 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_or_int_literal205 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_or_int_literal216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal263 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition286 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition295 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition304 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_multiplication327 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_MULT_in_multiplication336 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_multiplication345 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_print366 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_print368 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mat_name_in_mat_assignment395 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_mat_assignment403 = new BitSet(new ulong[]{0x0000000000002400UL});
    public static readonly BitSet FOLLOW_mat_var_in_mat_assignment411 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_mat_addition_in_mat_assignment421 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_mat_multiplication_in_mat_assignment432 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_mat_assignment443 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mat_name_in_mat_var461 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mat_data_in_mat_var472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_mat_name495 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_mat_name497 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MAT_DATA_in_mat_data518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mat_name_in_mat_addition541 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_PLUS_in_mat_addition550 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_mat_name_in_mat_addition559 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mat_name_in_mat_multiplication582 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_MULT_in_mat_multiplication591 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_mat_name_in_mat_multiplication600 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_14_in_mat_print621 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_mat_print623 = new BitSet(new ulong[]{0x0000000000000002UL});

}
