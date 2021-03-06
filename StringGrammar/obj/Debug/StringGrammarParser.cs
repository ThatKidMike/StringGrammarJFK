﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\ppmic\Desktop\StringGrammarJFK\StringGrammar\StringGrammar.g4 by ANTLR 4.6.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace StringGrammar {
#pragma warning disable 3021
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.5")]
[System.CLSCompliant(false)]
public partial class StringGrammarParser : Parser {
	public const int
		COMMA=1, OBRACKET=2, CBRACKET=3, CONCANTENATE=4, DIFFERENCE=5, SHIFT_RIGHT=6, 
		SHIFT_LEFT=7, UPPER=8, LOWER=9, SUBSTRING=10, NUMBER=11, DIGIT=12, STRING=13, 
		WS=14;
	public const int
		RULE_prog = 0, RULE_expression = 1;
	public static readonly string[] ruleNames = {
		"prog", "expression"
	};

	private static readonly string[] _LiteralNames = {
		null, "','", "'('", "')'", "'+'", "'-'", "'>'", "'<'", "'^'", "'_'", "'$'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "COMMA", "OBRACKET", "CBRACKET", "CONCANTENATE", "DIFFERENCE", "SHIFT_RIGHT", 
		"SHIFT_LEFT", "UPPER", "LOWER", "SUBSTRING", "NUMBER", "DIGIT", "STRING", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "StringGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public StringGrammarParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(StringGrammarParser.Eof, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
		public override void EnterRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStringGrammarVisitor<TResult> typedVisitor = visitor as IStringGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProg(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 5;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << OBRACKET) | (1L << SHIFT_RIGHT) | (1L << SHIFT_LEFT) | (1L << UPPER) | (1L << LOWER) | (1L << SUBSTRING) | (1L << STRING))) != 0)) {
				{
				State = 4; expression(0);
				}
			}

			State = 7; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ShiftContext : ExpressionContext {
		public IToken op;
		public ITerminalNode NUMBER() { return GetToken(StringGrammarParser.NUMBER, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode SHIFT_LEFT() { return GetToken(StringGrammarParser.SHIFT_LEFT, 0); }
		public ITerminalNode SHIFT_RIGHT() { return GetToken(StringGrammarParser.SHIFT_RIGHT, 0); }
		public ShiftContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.EnterShift(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.ExitShift(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStringGrammarVisitor<TResult> typedVisitor = visitor as IStringGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitShift(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CaseContext : ExpressionContext {
		public IToken op;
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode LOWER() { return GetToken(StringGrammarParser.LOWER, 0); }
		public ITerminalNode UPPER() { return GetToken(StringGrammarParser.UPPER, 0); }
		public CaseContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.EnterCase(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.ExitCase(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStringGrammarVisitor<TResult> typedVisitor = visitor as IStringGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCase(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class SubstringContext : ExpressionContext {
		public ITerminalNode SUBSTRING() { return GetToken(StringGrammarParser.SUBSTRING, 0); }
		public ITerminalNode[] NUMBER() { return GetTokens(StringGrammarParser.NUMBER); }
		public ITerminalNode NUMBER(int i) {
			return GetToken(StringGrammarParser.NUMBER, i);
		}
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode COMMA() { return GetToken(StringGrammarParser.COMMA, 0); }
		public SubstringContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.EnterSubstring(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.ExitSubstring(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStringGrammarVisitor<TResult> typedVisitor = visitor as IStringGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSubstring(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Con_diffContext : ExpressionContext {
		public IToken op;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode CONCANTENATE() { return GetToken(StringGrammarParser.CONCANTENATE, 0); }
		public ITerminalNode DIFFERENCE() { return GetToken(StringGrammarParser.DIFFERENCE, 0); }
		public Con_diffContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.EnterCon_diff(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.ExitCon_diff(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStringGrammarVisitor<TResult> typedVisitor = visitor as IStringGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCon_diff(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BracketsContext : ExpressionContext {
		public ITerminalNode OBRACKET() { return GetToken(StringGrammarParser.OBRACKET, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode CBRACKET() { return GetToken(StringGrammarParser.CBRACKET, 0); }
		public BracketsContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.EnterBrackets(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.ExitBrackets(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStringGrammarVisitor<TResult> typedVisitor = visitor as IStringGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBrackets(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class StringContext : ExpressionContext {
		public ITerminalNode STRING() { return GetToken(StringGrammarParser.STRING, 0); }
		public StringContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.EnterString(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IStringGrammarListener typedListener = listener as IStringGrammarListener;
			if (typedListener != null) typedListener.ExitString(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IStringGrammarVisitor<TResult> typedVisitor = visitor as IStringGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitString(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 27;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case SHIFT_RIGHT:
			case SHIFT_LEFT:
				{
				_localctx = new ShiftContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 10;
				((ShiftContext)_localctx).op = _input.Lt(1);
				_la = _input.La(1);
				if ( !(_la==SHIFT_RIGHT || _la==SHIFT_LEFT) ) {
					((ShiftContext)_localctx).op = _errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 11; Match(NUMBER);
				State = 12; expression(6);
				}
				break;
			case UPPER:
			case LOWER:
				{
				_localctx = new CaseContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 13;
				((CaseContext)_localctx).op = _input.Lt(1);
				_la = _input.La(1);
				if ( !(_la==UPPER || _la==LOWER) ) {
					((CaseContext)_localctx).op = _errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 14; expression(5);
				}
				break;
			case SUBSTRING:
				{
				_localctx = new SubstringContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 15; Match(SUBSTRING);
				State = 16; Match(NUMBER);
				State = 19;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==COMMA) {
					{
					State = 17; Match(COMMA);
					State = 18; Match(NUMBER);
					}
				}

				State = 21; expression(4);
				}
				break;
			case OBRACKET:
				{
				_localctx = new BracketsContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 22; Match(OBRACKET);
				State = 23; expression(0);
				State = 24; Match(CBRACKET);
				}
				break;
			case STRING:
				{
				_localctx = new StringContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 26; Match(STRING);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			_ctx.stop = _input.Lt(-1);
			State = 34;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,3,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new Con_diffContext(new ExpressionContext(_parentctx, _parentState));
					PushNewRecursionContext(_localctx, _startState, RULE_expression);
					State = 29;
					if (!(Precpred(_ctx, 3))) throw new FailedPredicateException(this, "Precpred(_ctx, 3)");
					State = 30;
					((Con_diffContext)_localctx).op = _input.Lt(1);
					_la = _input.La(1);
					if ( !(_la==CONCANTENATE || _la==DIFFERENCE) ) {
						((Con_diffContext)_localctx).op = _errHandler.RecoverInline(this);
					} else {
						if (_input.La(1) == TokenConstants.Eof) {
							matchedEOF = true;
						}

						_errHandler.ReportMatch(this);
						Consume();
					}
					State = 31; expression(4);
					}
					} 
				}
				State = 36;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,3,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 3);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x10(\x4\x2\t\x2"+
		"\x4\x3\t\x3\x3\x2\x5\x2\b\n\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3\x16\n\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x5\x3\x1E\n\x3\x3\x3\x3\x3\x3\x3\a\x3#\n\x3\f\x3\xE\x3"+
		"&\v\x3\x3\x3\x2\x2\x3\x4\x4\x2\x2\x4\x2\x2\x5\x3\x2\b\t\x3\x2\n\v\x3\x2"+
		"\x6\a,\x2\a\x3\x2\x2\x2\x4\x1D\x3\x2\x2\x2\x6\b\x5\x4\x3\x2\a\x6\x3\x2"+
		"\x2\x2\a\b\x3\x2\x2\x2\b\t\x3\x2\x2\x2\t\n\a\x2\x2\x3\n\x3\x3\x2\x2\x2"+
		"\v\f\b\x3\x1\x2\f\r\t\x2\x2\x2\r\xE\a\r\x2\x2\xE\x1E\x5\x4\x3\b\xF\x10"+
		"\t\x3\x2\x2\x10\x1E\x5\x4\x3\a\x11\x12\a\f\x2\x2\x12\x15\a\r\x2\x2\x13"+
		"\x14\a\x3\x2\x2\x14\x16\a\r\x2\x2\x15\x13\x3\x2\x2\x2\x15\x16\x3\x2\x2"+
		"\x2\x16\x17\x3\x2\x2\x2\x17\x1E\x5\x4\x3\x6\x18\x19\a\x4\x2\x2\x19\x1A"+
		"\x5\x4\x3\x2\x1A\x1B\a\x5\x2\x2\x1B\x1E\x3\x2\x2\x2\x1C\x1E\a\xF\x2\x2"+
		"\x1D\v\x3\x2\x2\x2\x1D\xF\x3\x2\x2\x2\x1D\x11\x3\x2\x2\x2\x1D\x18\x3\x2"+
		"\x2\x2\x1D\x1C\x3\x2\x2\x2\x1E$\x3\x2\x2\x2\x1F \f\x5\x2\x2 !\t\x4\x2"+
		"\x2!#\x5\x4\x3\x6\"\x1F\x3\x2\x2\x2#&\x3\x2\x2\x2$\"\x3\x2\x2\x2$%\x3"+
		"\x2\x2\x2%\x5\x3\x2\x2\x2&$\x3\x2\x2\x2\x6\a\x15\x1D$";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace StringGrammar
