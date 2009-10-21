// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-21 01:30:36


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class InterpLexer : Lexer {
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

    // $ANTLR start "T__12"
    public void mT__12() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__12;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:11:7: ( 'print' )
            // Interp.g:11:9: 'print'
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
    // $ANTLR end "T__12"

    // $ANTLR start "T__13"
    public void mT__13() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__13;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:12:7: ( 'mat' )
            // Interp.g:12:9: 'mat'
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
    // $ANTLR end "T__13"

    // $ANTLR start "T__14"
    public void mT__14() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__14;
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
    // $ANTLR end "T__14"

    // $ANTLR start "END_OF_STATEMENT"
    public void mEND_OF_STATEMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END_OF_STATEMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:153:17: ( ';' )
            // Interp.g:153:19: ';'
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
            // Interp.g:154:11: ( '=' )
            // Interp.g:154:13: '='
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
            // Interp.g:155:5: ( '+' )
            // Interp.g:155:7: '+'
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
            // Interp.g:156:5: ( '*' )
            // Interp.g:156:7: '*'
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
            // Interp.g:157:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // Interp.g:157:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// Interp.g:157:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
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
            // Interp.g:158:12: ( ( '0' .. '9' )+ )
            // Interp.g:158:14: ( '0' .. '9' )+
            {
            	// Interp.g:158:14: ( '0' .. '9' )+
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
            			    // Interp.g:158:15: '0' .. '9'
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

    // $ANTLR start "MAT_DATA"
    public void mMAT_DATA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MAT_DATA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:159:9: ( ( '[' ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) ) ']' ) )
            // Interp.g:159:11: ( '[' ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) ) ']' )
            {
            	// Interp.g:159:11: ( '[' ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) ) ']' )
            	// Interp.g:159:13: '[' ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) ) ']'
            	{
            		Match('['); 
            		// Interp.g:159:17: ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) )
            		int alt6 = 3;
            		alt6 = dfa6.Predict(input);
            		switch (alt6) 
            		{
            		    case 1 :
            		        // Interp.g:159:19: ( INT_LITERAL )
            		        {
            		        	// Interp.g:159:19: ( INT_LITERAL )
            		        	// Interp.g:159:20: INT_LITERAL
            		        	{
            		        		mINT_LITERAL(); 

            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // Interp.g:159:35: ( ( INT_LITERAL ',' )+ INT_LITERAL )
            		        {
            		        	// Interp.g:159:35: ( ( INT_LITERAL ',' )+ INT_LITERAL )
            		        	// Interp.g:159:36: ( INT_LITERAL ',' )+ INT_LITERAL
            		        	{
            		        		// Interp.g:159:36: ( INT_LITERAL ',' )+
            		        		int cnt3 = 0;
            		        		do 
            		        		{
            		        		    int alt3 = 2;
            		        		    alt3 = dfa3.Predict(input);
            		        		    switch (alt3) 
            		        			{
            		        				case 1 :
            		        				    // Interp.g:159:37: INT_LITERAL ','
            		        				    {
            		        				    	mINT_LITERAL(); 
            		        				    	Match(','); 

            		        				    }
            		        				    break;

            		        				default:
            		        				    if ( cnt3 >= 1 ) goto loop3;
            		        			            EarlyExitException eee3 =
            		        			                new EarlyExitException(3, input);
            		        			            throw eee3;
            		        		    }
            		        		    cnt3++;
            		        		} while (true);

            		        		loop3:
            		        			;	// Stops C# compiler whining that label 'loop3' has no statements

            		        		mINT_LITERAL(); 

            		        	}


            		        }
            		        break;
            		    case 3 :
            		        // Interp.g:159:70: ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ )
            		        {
            		        	// Interp.g:159:70: ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ )
            		        	// Interp.g:159:71: ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+
            		        	{
            		        		// Interp.g:159:71: ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+
            		        		int cnt5 = 0;
            		        		do 
            		        		{
            		        		    int alt5 = 2;
            		        		    int LA5_0 = input.LA(1);

            		        		    if ( (LA5_0 == '[') )
            		        		    {
            		        		        alt5 = 1;
            		        		    }


            		        		    switch (alt5) 
            		        			{
            		        				case 1 :
            		        				    // Interp.g:159:72: '[' ( INT_LITERAL ',' )+ INT_LITERAL ']'
            		        				    {
            		        				    	Match('['); 
            		        				    	// Interp.g:159:76: ( INT_LITERAL ',' )+
            		        				    	int cnt4 = 0;
            		        				    	do 
            		        				    	{
            		        				    	    int alt4 = 2;
            		        				    	    alt4 = dfa4.Predict(input);
            		        				    	    switch (alt4) 
            		        				    		{
            		        				    			case 1 :
            		        				    			    // Interp.g:159:77: INT_LITERAL ','
            		        				    			    {
            		        				    			    	mINT_LITERAL(); 
            		        				    			    	Match(','); 

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

            		        				    	mINT_LITERAL(); 
            		        				    	Match(']'); 

            		        				    }
            		        				    break;

            		        				default:
            		        				    if ( cnt5 >= 1 ) goto loop5;
            		        			            EarlyExitException eee5 =
            		        			                new EarlyExitException(5, input);
            		        			            throw eee5;
            		        		    }
            		        		    cnt5++;
            		        		} while (true);

            		        		loop5:
            		        			;	// Stops C# compiler whining that label 'loop5' has no statements


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
            // Interp.g:160:12: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // Interp.g:160:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// Interp.g:160:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= '\t' && LA7_0 <= '\n') || LA7_0 == '\r' || LA7_0 == ' ') )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
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
            			    if ( cnt7 >= 1 ) goto loop7;
            		            EarlyExitException eee7 =
            		                new EarlyExitException(7, input);
            		            throw eee7;
            	    }
            	    cnt7++;
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

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
        // Interp.g:1:8: ( T__12 | T__13 | T__14 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULT | VARIABLE | INT_LITERAL | MAT_DATA | WHITESPACE )
        int alt8 = 11;
        alt8 = dfa8.Predict(input);
        switch (alt8) 
        {
            case 1 :
                // Interp.g:1:10: T__12
                {
                	mT__12(); 

                }
                break;
            case 2 :
                // Interp.g:1:16: T__13
                {
                	mT__13(); 

                }
                break;
            case 3 :
                // Interp.g:1:22: T__14
                {
                	mT__14(); 

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
                // Interp.g:1:87: MAT_DATA
                {
                	mMAT_DATA(); 

                }
                break;
            case 11 :
                // Interp.g:1:96: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;

        }

    }


    protected DFA6 dfa6;
    protected DFA3 dfa3;
    protected DFA4 dfa4;
    protected DFA8 dfa8;
	private void InitializeCyclicDFAs()
	{
	    this.dfa6 = new DFA6(this);
	    this.dfa3 = new DFA3(this);
	    this.dfa4 = new DFA4(this);
	    this.dfa8 = new DFA8(this);




	}

    const string DFA6_eotS =
        "\x05\uffff";
    const string DFA6_eofS =
        "\x05\uffff";
    const string DFA6_minS =
        "\x01\x30\x01\x2c\x03\uffff";
    const string DFA6_maxS =
        "\x01\x5b\x01\x5d\x03\uffff";
    const string DFA6_acceptS =
        "\x02\uffff\x01\x03\x01\x01\x01\x02";
    const string DFA6_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x0a\x01\x21\uffff\x01\x02",
            "\x01\x04\x03\uffff\x0a\x01\x23\uffff\x01\x03",
            "",
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
            get { return "159:17: ( ( INT_LITERAL ) | ( ( INT_LITERAL ',' )+ INT_LITERAL ) | ( ( '[' ( INT_LITERAL ',' )+ INT_LITERAL ']' )+ ) )"; }
        }

    }

    const string DFA3_eotS =
        "\x04\uffff";
    const string DFA3_eofS =
        "\x04\uffff";
    const string DFA3_minS =
        "\x01\x30\x01\x2c\x02\uffff";
    const string DFA3_maxS =
        "\x01\x39\x01\x5d\x02\uffff";
    const string DFA3_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA3_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA3_transitionS = {
            "\x0a\x01",
            "\x01\x02\x03\uffff\x0a\x01\x23\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA3_eot = DFA.UnpackEncodedString(DFA3_eotS);
    static readonly short[] DFA3_eof = DFA.UnpackEncodedString(DFA3_eofS);
    static readonly char[] DFA3_min = DFA.UnpackEncodedStringToUnsignedChars(DFA3_minS);
    static readonly char[] DFA3_max = DFA.UnpackEncodedStringToUnsignedChars(DFA3_maxS);
    static readonly short[] DFA3_accept = DFA.UnpackEncodedString(DFA3_acceptS);
    static readonly short[] DFA3_special = DFA.UnpackEncodedString(DFA3_specialS);
    static readonly short[][] DFA3_transition = DFA.UnpackEncodedStringArray(DFA3_transitionS);

    protected class DFA3 : DFA
    {
        public DFA3(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 3;
            this.eot = DFA3_eot;
            this.eof = DFA3_eof;
            this.min = DFA3_min;
            this.max = DFA3_max;
            this.accept = DFA3_accept;
            this.special = DFA3_special;
            this.transition = DFA3_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 159:36: ( INT_LITERAL ',' )+"; }
        }

    }

    const string DFA4_eotS =
        "\x04\uffff";
    const string DFA4_eofS =
        "\x04\uffff";
    const string DFA4_minS =
        "\x01\x30\x01\x2c\x02\uffff";
    const string DFA4_maxS =
        "\x01\x39\x01\x5d\x02\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA4_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x0a\x01",
            "\x01\x02\x03\uffff\x0a\x01\x23\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 159:76: ( INT_LITERAL ',' )+"; }
        }

    }

    const string DFA8_eotS =
        "\x01\uffff\x02\x07\x08\uffff\x03\x07\x01\x10\x01\x07\x01\uffff"+
        "\x01\x13\x02\uffff";
    const string DFA8_eofS =
        "\x14\uffff";
    const string DFA8_minS =
        "\x01\x09\x01\x72\x01\x61\x08\uffff\x01\x69\x01\x74\x01\x6e\x01"+
        "\x41\x01\x74\x01\uffff\x01\x41\x02\uffff";
    const string DFA8_maxS =
        "\x01\x7a\x01\x72\x01\x61\x08\uffff\x01\x69\x01\x74\x01\x6e\x01"+
        "\x7a\x01\x74\x01\uffff\x01\x7a\x02\uffff";
    const string DFA8_acceptS =
        "\x03\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01"+
        "\x0a\x01\x0b\x05\uffff\x01\x02\x01\uffff\x01\x03\x01\x01";
    const string DFA8_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x02\x0a\x02\uffff\x01\x0a\x12\uffff\x01\x0a\x09\uffff\x01"+
            "\x06\x01\x05\x04\uffff\x0a\x08\x01\uffff\x01\x03\x01\uffff\x01"+
            "\x04\x03\uffff\x1a\x07\x01\x09\x05\uffff\x0c\x07\x01\x02\x02"+
            "\x07\x01\x01\x0a\x07",
            "\x01\x0b",
            "\x01\x0c",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0d",
            "\x01\x0e",
            "\x01\x0f",
            "\x1a\x07\x06\uffff\x1a\x07",
            "\x01\x11",
            "",
            "\x1a\x07\x04\uffff\x01\x12\x01\uffff\x1a\x07",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__12 | T__13 | T__14 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULT | VARIABLE | INT_LITERAL | MAT_DATA | WHITESPACE );"; }
        }

    }

 
    
}
