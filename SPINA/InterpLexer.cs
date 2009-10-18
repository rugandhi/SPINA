// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-18 15:35:31


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class InterpLexer : Lexer {
    public const int INT_LITERAL = 7;
    public const int T__16 = 16;
    public const int T__15 = 15;
    public const int VARIABLE = 6;
    public const int T__14 = 14;
    public const int MAT_NAME = 8;
    public const int WHITESPACE = 13;
    public const int PLUS = 10;
    public const int ASSIGNMENT = 4;
    public const int MULT = 11;
    public const int EOF = -1;
    public const int MAT_DATA = 9;
    public const int END_OF_STATEMENT = 5;
    public const int MAT_PRINT_NAME = 12;

    // delegates
    // delegators

    public InterpLexer() 
    {
		InitializeCyclicDFAs();
    }
    public InterpLexer(ICharStream input)
		: this(input, null) {
    }
    public InterpLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "Interp.g";} 
    }

    // $ANTLR start "T__14"
    public void mT__14() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__14;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:11:7: ( 'mat' )
            // Interp.g:11:9: 'mat'
            {
            	Match("mat"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__14"

    // $ANTLR start "T__15"
    public void mT__15() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__15;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:12:7: ( 'print' )
            // Interp.g:12:9: 'print'
            {
            	Match("print"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__15"

    // $ANTLR start "T__16"
    public void mT__16() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__16;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:13:7: ( 'print_mat' )
            // Interp.g:13:9: 'print_mat'
            {
            	Match("print_mat"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__16"

    // $ANTLR start "END_OF_STATEMENT"
    public void mEND_OF_STATEMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END_OF_STATEMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:128:17: ( ';' )
            // Interp.g:128:19: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END_OF_STATEMENT"

    // $ANTLR start "ASSIGNMENT"
    public void mASSIGNMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGNMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:129:11: ( '=' )
            // Interp.g:129:13: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGNMENT"

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:130:5: ( '+' )
            // Interp.g:130:7: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLUS"

    // $ANTLR start "MULT"
    public void mMULT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:131:5: ( '*' )
            // Interp.g:131:7: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULT"

    // $ANTLR start "VARIABLE"
    public void mVARIABLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VARIABLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:132:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // Interp.g:132:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// Interp.g:132:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= 'A' && LA1_0 <= 'Z') || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Interp.g:
            			    {
            			    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


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

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VARIABLE"

    // $ANTLR start "INT_LITERAL"
    public void mINT_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:133:12: ( ( '0' .. '9' )+ )
            // Interp.g:133:14: ( '0' .. '9' )+
            {
            	// Interp.g:133:14: ( '0' .. '9' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Interp.g:133:15: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT_LITERAL"

    // $ANTLR start "MAT_NAME"
    public void mMAT_NAME() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MAT_NAME;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:134:9: ( ( VARIABLE ( INT_LITERAL )? ( '[' INT_LITERAL ']' )+ ) )
            // Interp.g:134:11: ( VARIABLE ( INT_LITERAL )? ( '[' INT_LITERAL ']' )+ )
            {
            	// Interp.g:134:11: ( VARIABLE ( INT_LITERAL )? ( '[' INT_LITERAL ']' )+ )
            	// Interp.g:134:12: VARIABLE ( INT_LITERAL )? ( '[' INT_LITERAL ']' )+
            	{
            		mVARIABLE(); 
            		// Interp.g:134:21: ( INT_LITERAL )?
            		int alt3 = 2;
            		int LA3_0 = input.LA(1);

            		if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
            		{
            		    alt3 = 1;
            		}
            		switch (alt3) 
            		{
            		    case 1 :
            		        // Interp.g:134:21: INT_LITERAL
            		        {
            		        	mINT_LITERAL(); 

            		        }
            		        break;

            		}

            		// Interp.g:134:34: ( '[' INT_LITERAL ']' )+
            		int cnt4 = 0;
            		do 
            		{
            		    int alt4 = 2;
            		    int LA4_0 = input.LA(1);

            		    if ( (LA4_0 == '[') )
            		    {
            		        alt4 = 1;
            		    }


            		    switch (alt4) 
            			{
            				case 1 :
            				    // Interp.g:134:35: '[' INT_LITERAL ']'
            				    {
            				    	Match('['); 
            				    	mINT_LITERAL(); 
            				    	Match(']'); 

            				    }
            				    break;

            				default:
            				    if ( cnt4 >= 1 ) goto loop4;
            			            EarlyExitException eee4 =
            			                new EarlyExitException(4, input);
            			            throw eee4;
            		    }
            		    cnt4++;
            		} while (true);

            		loop4:
            			;	// Stops C# compiler whining that label 'loop4' has no statements


            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MAT_NAME"

    // $ANTLR start "MAT_PRINT_NAME"
    public void mMAT_PRINT_NAME() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MAT_PRINT_NAME;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:135:15: ( ( VARIABLE ( INT_LITERAL )? ) )
            // Interp.g:135:17: ( VARIABLE ( INT_LITERAL )? )
            {
            	// Interp.g:135:17: ( VARIABLE ( INT_LITERAL )? )
            	// Interp.g:135:18: VARIABLE ( INT_LITERAL )?
            	{
            		mVARIABLE(); 
            		// Interp.g:135:27: ( INT_LITERAL )?
            		int alt5 = 2;
            		int LA5_0 = input.LA(1);

            		if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
            		{
            		    alt5 = 1;
            		}
            		switch (alt5) 
            		{
            		    case 1 :
            		        // Interp.g:135:27: INT_LITERAL
            		        {
            		        	mINT_LITERAL(); 

            		        }
            		        break;

            		}


            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MAT_PRINT_NAME"

    // $ANTLR start "MAT_DATA"
    public void mMAT_DATA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MAT_DATA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:136:9: ( ( '[' ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) ) ']' ) )
            // Interp.g:136:11: ( '[' ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) ) ']' )
            {
            	// Interp.g:136:11: ( '[' ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) ) ']' )
            	// Interp.g:136:13: '[' ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) ) ']'
            	{
            		Match('['); 
            		// Interp.g:136:17: ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) )
            		int alt9 = 3;
            		alt9 = dfa9.Predict(input);
            		switch (alt9) 
            		{
            		    case 1 :
            		        // Interp.g:136:19: ( INT_LITERAL )
            		        {
            		        	// Interp.g:136:19: ( INT_LITERAL )
            		        	// Interp.g:136:20: INT_LITERAL
            		        	{
            		        		mINT_LITERAL(); 

            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // Interp.g:136:35: ( ( INT_LITERAL ',' )+ INT_LITERAL )
            		        {
            		        	// Interp.g:136:35: ( ( INT_LITERAL ',' )+ INT_LITERAL )
            		        	// Interp.g:136:36: ( INT_LITERAL ',' )+ INT_LITERAL
            		        	{
            		        		// Interp.g:136:36: ( INT_LITERAL ',' )+
            		        		int cnt6 = 0;
            		        		do 
            		        		{
            		        		    int alt6 = 2;
            		        		    alt6 = dfa6.Predict(input);
            		        		    switch (alt6) 
            		        			{
            		        				case 1 :
            		        				    // Interp.g:136:37: INT_LITERAL ','
            		        				    {
            		        				    	mINT_LITERAL(); 
            		        				    	Match(','); 

            		        				    }
            		        				    break;

            		        				default:
            		        				    if ( cnt6 >= 1 ) goto loop6;
            		        			            EarlyExitException eee6 =
            		        			                new EarlyExitException(6, input);
            		        			            throw eee6;
            		        		    }
            		        		    cnt6++;
            		        		} while (true);

            		        		loop6:
            		        			;	// Stops C# compiler whining that label 'loop6' has no statements

            		        		mINT_LITERAL(); 

            		        	}


            		        }
            		        break;
            		    case 3 :
            		        // Interp.g:136:70: ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ )
            		        {
            		        	// Interp.g:136:70: ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ )
            		        	// Interp.g:136:71: ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+
            		        	{
            		        		// Interp.g:136:71: ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+
            		        		int cnt8 = 0;
            		        		do 
            		        		{
            		        		    int alt8 = 2;
            		        		    int LA8_0 = input.LA(1);

            		        		    if ( (LA8_0 == '[') )
            		        		    {
            		        		        alt8 = 1;
            		        		    }


            		        		    switch (alt8) 
            		        			{
            		        				case 1 :
            		        				    // Interp.g:136:72: '[' ( INT_LITERAL ',' )+ INT_LITERAL ']'
            		        				    {
            		        				    	Match('['); 
            		        				    	// Interp.g:136:76: ( INT_LITERAL ',' )+
            		        				    	int cnt7 = 0;
            		        				    	do 
            		        				    	{
            		        				    	    int alt7 = 2;
            		        				    	    alt7 = dfa7.Predict(input);
            		        				    	    switch (alt7) 
            		        				    		{
            		        				    			case 1 :
            		        				    			    // Interp.g:136:77: INT_LITERAL ','
            		        				    			    {
            		        				    			    	mINT_LITERAL(); 
            		        				    			    	Match(','); 

            		        				    			    }
            		        				    			    break;

            		        				    			default:
            		        				    			    if ( cnt7 >= 1 ) goto loop7;
            		        				    		            EarlyExitException eee7 =
            		        				    		                new EarlyExitException(7, input);
            		        				    		            throw eee7;
            		        				    	    }
            		        				    	    cnt7++;
            		        				    	} while (true);

            		        				    	loop7:
            		        				    		;	// Stops C# compiler whining that label 'loop7' has no statements

            		        				    	mINT_LITERAL(); 
            		        				    	Match(']'); 

            		        				    }
            		        				    break;

            		        				default:
            		        				    if ( cnt8 >= 1 ) goto loop8;
            		        			            EarlyExitException eee8 =
            		        			                new EarlyExitException(8, input);
            		        			            throw eee8;
            		        		    }
            		        		    cnt8++;
            		        		} while (true);

            		        		loop8:
            		        			;	// Stops C# compiler whining that label 'loop8' has no statements


            		        	}


            		        }
            		        break;

            		}

            		Match(']'); 

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MAT_DATA"

    // $ANTLR start "WHITESPACE"
    public void mWHITESPACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHITESPACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:137:12: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // Interp.g:137:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// Interp.g:137:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt10 = 0;
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= '\t' && LA10_0 <= '\n') || LA10_0 == '\r' || LA10_0 == ' ') )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // Interp.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt10 >= 1 ) goto loop10;
            		            EarlyExitException eee10 =
            		                new EarlyExitException(10, input);
            		            throw eee10;
            	    }
            	    cnt10++;
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	_channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHITESPACE"

    override public void mTokens() // throws RecognitionException 
    {
        // Interp.g:1:8: ( T__14 | T__15 | T__16 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULT | VARIABLE | INT_LITERAL | MAT_NAME | MAT_PRINT_NAME | MAT_DATA | WHITESPACE )
        int alt11 = 13;
        alt11 = dfa11.Predict(input);
        switch (alt11) 
        {
            case 1 :
                // Interp.g:1:10: T__14
                {
                	mT__14(); 

                }
                break;
            case 2 :
                // Interp.g:1:16: T__15
                {
                	mT__15(); 

                }
                break;
            case 3 :
                // Interp.g:1:22: T__16
                {
                	mT__16(); 

                }
                break;
            case 4 :
                // Interp.g:1:28: END_OF_STATEMENT
                {
                	mEND_OF_STATEMENT(); 

                }
                break;
            case 5 :
                // Interp.g:1:45: ASSIGNMENT
                {
                	mASSIGNMENT(); 

                }
                break;
            case 6 :
                // Interp.g:1:56: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 7 :
                // Interp.g:1:61: MULT
                {
                	mMULT(); 

                }
                break;
            case 8 :
                // Interp.g:1:66: VARIABLE
                {
                	mVARIABLE(); 

                }
                break;
            case 9 :
                // Interp.g:1:75: INT_LITERAL
                {
                	mINT_LITERAL(); 

                }
                break;
            case 10 :
                // Interp.g:1:87: MAT_NAME
                {
                	mMAT_NAME(); 

                }
                break;
            case 11 :
                // Interp.g:1:96: MAT_PRINT_NAME
                {
                	mMAT_PRINT_NAME(); 

                }
                break;
            case 12 :
                // Interp.g:1:111: MAT_DATA
                {
                	mMAT_DATA(); 

                }
                break;
            case 13 :
                // Interp.g:1:120: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;

        }

    }


    protected DFA9 dfa9;
    protected DFA6 dfa6;
    protected DFA7 dfa7;
    protected DFA11 dfa11;
	private void InitializeCyclicDFAs()
	{
	    this.dfa9 = new DFA9(this);
	    this.dfa6 = new DFA6(this);
	    this.dfa7 = new DFA7(this);
	    this.dfa11 = new DFA11(this);




	}

    const string DFA9_eotS =
        "\x05\uffff";
    const string DFA9_eofS =
        "\x05\uffff";
    const string DFA9_minS =
        "\x01\x30\x01\x2c\x03\uffff";
    const string DFA9_maxS =
        "\x01\x5b\x01\x5d\x03\uffff";
    const string DFA9_acceptS =
        "\x02\uffff\x01\x03\x01\x02\x01\x01";
    const string DFA9_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x0a\x01\x21\uffff\x01\x02",
            "\x01\x03\x03\uffff\x0a\x01\x23\uffff\x01\x04",
            "",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "136:17: ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) )"; }
        }

    }

    const string DFA6_eotS =
        "\x04\uffff";
    const string DFA6_eofS =
        "\x04\uffff";
    const string DFA6_minS =
        "\x01\x30\x01\x2c\x02\uffff";
    const string DFA6_maxS =
        "\x01\x39\x01\x5d\x02\uffff";
    const string DFA6_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA6_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x0a\x01",
            "\x01\x03\x03\uffff\x0a\x01\x23\uffff\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 136:36: ( INT_LITERAL ',' )+"; }
        }

    }

    const string DFA7_eotS =
        "\x04\uffff";
    const string DFA7_eofS =
        "\x04\uffff";
    const string DFA7_minS =
        "\x01\x30\x01\x2c\x02\uffff";
    const string DFA7_maxS =
        "\x01\x39\x01\x5d\x02\uffff";
    const string DFA7_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA7_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x0a\x01",
            "\x01\x02\x03\uffff\x0a\x01\x23\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 136:76: ( INT_LITERAL ',' )+"; }
        }

    }

    const string DFA11_eotS =
        "\x01\uffff\x02\x0c\x04\uffff\x01\x0c\x03\uffff\x01\x0c\x01\uffff"+
        "\x01\x11\x01\uffff\x01\x0c\x01\x13\x01\uffff\x01\x0c\x01\uffff\x01"+
        "\x0c\x01\x17\x02\uffff";
    const string DFA11_eofS =
        "\x18\uffff";
    const string DFA11_minS =
        "\x01\x09\x02\x30\x04\uffff\x01\x30\x03\uffff\x01\x30\x01\uffff"+
        "\x01\x30\x01\uffff\x02\x30\x01\uffff\x01\x30\x01\uffff\x02\x30\x02"+
        "\uffff";
    const string DFA11_maxS =
        "\x03\x7a\x04\uffff\x01\x7a\x03\uffff\x01\x7a\x01\uffff\x01\x5b"+
        "\x01\uffff\x02\x7a\x01\uffff\x01\x7a\x01\uffff\x02\x7a\x02\uffff";
    const string DFA11_acceptS =
        "\x03\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x01\uffff\x01\x09\x01"+
        "\x0c\x01\x0d\x01\uffff\x01\x08\x01\uffff\x01\x0a\x02\uffff\x01\x0b"+
        "\x01\uffff\x01\x01\x02\uffff\x01\x03\x01\x02";
    const string DFA11_specialS =
        "\x18\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x02\x0a\x02\uffff\x01\x0a\x12\uffff\x01\x0a\x09\uffff\x01"+
            "\x06\x01\x05\x04\uffff\x0a\x08\x01\uffff\x01\x03\x01\uffff\x01"+
            "\x04\x03\uffff\x1a\x07\x01\x09\x05\uffff\x0c\x07\x01\x01\x02"+
            "\x07\x01\x02\x0a\x07",
            "\x0a\x0d\x07\uffff\x1a\x07\x01\x0e\x05\uffff\x01\x0b\x19\x07",
            "\x0a\x0d\x07\uffff\x1a\x07\x01\x0e\x05\uffff\x11\x07\x01\x0f"+
            "\x08\x07",
            "",
            "",
            "",
            "",
            "\x0a\x0d\x07\uffff\x1a\x07\x01\x0e\x05\uffff\x1a\x07",
            "",
            "",
            "",
            "\x0a\x0d\x07\uffff\x1a\x07\x01\x0e\x05\uffff\x13\x07\x01\x10"+
            "\x06\x07",
            "",
            "\x0a\x0d\x21\uffff\x01\x0e",
            "",
            "\x0a\x0d\x07\uffff\x1a\x07\x01\x0e\x05\uffff\x08\x07\x01\x12"+
            "\x11\x07",
            "\x0a\x0d\x07\uffff\x1a\x07\x01\x0e\x05\uffff\x1a\x07",
            "",
            "\x0a\x0d\x07\uffff\x1a\x07\x01\x0e\x05\uffff\x0d\x07\x01\x14"+
            "\x0c\x07",
            "",
            "\x0a\x0d\x07\uffff\x1a\x07\x01\x0e\x05\uffff\x13\x07\x01\x15"+
            "\x06\x07",
            "\x0a\x0d\x07\uffff\x1a\x07\x01\x0e\x03\uffff\x01\x16\x01\uffff"+
            "\x1a\x07",
            "",
            ""
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__14 | T__15 | T__16 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULT | VARIABLE | INT_LITERAL | MAT_NAME | MAT_PRINT_NAME | MAT_DATA | WHITESPACE );"; }
        }

    }

 
    
}
