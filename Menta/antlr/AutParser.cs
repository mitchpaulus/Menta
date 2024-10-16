//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./Aut.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class AutParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, AUT=2, NUMBERED=3, COMMA=4, INTEGER=5, LBRACE=6, RBRACE=7, LSQUARE=8, 
		RSQUARE=9, DQUOTESTRING=10, SQUOTESTRING=11, EQUALS=12, SEMICOLON=13, 
		COLON=14, RIGHTANGLE=15, PERIOD=16, LINE_COMMENT=17, BLOCK_DATA=18, WS=19;
	public const int
		RULE_file = 0, RULE_page = 1, RULE_block_list = 2, RULE_stringList = 3, 
		RULE_block = 4, RULE_connection = 5, RULE_blankConnection = 6, RULE_xy_pair = 7, 
		RULE_connection_line = 8;
	public static readonly string[] ruleNames = {
		"file", "page", "block_list", "stringList", "block", "connection", "blankConnection", 
		"xy_pair", "connection_line"
	};

	private static readonly string[] _LiteralNames = {
		null, "'N'", "'[Aut]'", null, "','", null, "'{'", "'}'", "'['", "']'", 
		null, null, "'='", "';'", "':'", "'>'", "'.'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, "AUT", "NUMBERED", "COMMA", "INTEGER", "LBRACE", "RBRACE", 
		"LSQUARE", "RSQUARE", "DQUOTESTRING", "SQUOTESTRING", "EQUALS", "SEMICOLON", 
		"COLON", "RIGHTANGLE", "PERIOD", "LINE_COMMENT", "BLOCK_DATA", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Aut.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static AutParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public AutParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public AutParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class FileContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AUT() { return GetToken(AutParser.AUT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMBERED() { return GetToken(AutParser.NUMBERED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(AutParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(AutParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INTEGER() { return GetTokens(AutParser.INTEGER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER(int i) {
			return GetToken(AutParser.INTEGER, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(AutParser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PageContext page() {
			return GetRuleContext<PageContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(AutParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(AutParser.RBRACE, 0); }
		public FileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_file; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.EnterFile(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.ExitFile(this);
		}
	}

	[RuleVersion(0)]
	public FileContext file() {
		FileContext _localctx = new FileContext(Context, State);
		EnterRule(_localctx, 0, RULE_file);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 18;
			Match(AUT);
			State = 19;
			Match(NUMBERED);
			State = 20;
			Match(COMMA);
			State = 21;
			Match(INTEGER);
			State = 22;
			Match(COMMA);
			State = 23;
			Match(INTEGER);
			State = 24;
			Match(LBRACE);
			State = 25;
			Match(INTEGER);
			State = 26;
			Match(COMMA);
			State = 27;
			Match(INTEGER);
			State = 28;
			page();
			State = 29;
			Match(COLON);
			State = 30;
			Match(INTEGER);
			State = 31;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PageContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Block_listContext[] block_list() {
			return GetRuleContexts<Block_listContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Block_listContext block_list(int i) {
			return GetRuleContext<Block_listContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConnectionContext[] connection() {
			return GetRuleContexts<ConnectionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConnectionContext connection(int i) {
			return GetRuleContext<ConnectionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BlankConnectionContext[] blankConnection() {
			return GetRuleContexts<BlankConnectionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public BlankConnectionContext blankConnection(int i) {
			return GetRuleContext<BlankConnectionContext>(i);
		}
		public PageContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_page; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.EnterPage(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.ExitPage(this);
		}
	}

	[RuleVersion(0)]
	public PageContext page() {
		PageContext _localctx = new PageContext(Context, State);
		EnterRule(_localctx, 2, RULE_page);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 34;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 33;
				block_list();
				}
				}
				State = 36;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==NUMBERED || _la==LBRACE );
			State = 39;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 38;
					connection();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 41;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			State = 46;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==RIGHTANGLE) {
				{
				{
				State = 43;
				blankConnection();
				}
				}
				State = 48;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Block_listContext : ParserRuleContext {
		public Block_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block_list; } }
	 
		public Block_listContext() { }
		public virtual void CopyFrom(Block_listContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class NormalBlockContext : Block_listContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public NormalBlockContext(Block_listContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.EnterNormalBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.ExitNormalBlock(this);
		}
	}
	public partial class NestedBlockContext : Block_listContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(AutParser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PageContext page() {
			return GetRuleContext<PageContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(AutParser.RBRACE, 0); }
		public NestedBlockContext(Block_listContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.EnterNestedBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.ExitNestedBlock(this);
		}
	}

	[RuleVersion(0)]
	public Block_listContext block_list() {
		Block_listContext _localctx = new Block_listContext(Context, State);
		EnterRule(_localctx, 4, RULE_block_list);
		try {
			State = 54;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NUMBERED:
				_localctx = new NormalBlockContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 49;
				block();
				}
				break;
			case LBRACE:
				_localctx = new NestedBlockContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 50;
				Match(LBRACE);
				State = 51;
				page();
				State = 52;
				Match(RBRACE);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StringListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SQUOTESTRING() { return GetTokens(AutParser.SQUOTESTRING); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SQUOTESTRING(int i) {
			return GetToken(AutParser.SQUOTESTRING, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(AutParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(AutParser.COMMA, i);
		}
		public StringListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stringList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.EnterStringList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.ExitStringList(this);
		}
	}

	[RuleVersion(0)]
	public StringListContext stringList() {
		StringListContext _localctx = new StringListContext(Context, State);
		EnterRule(_localctx, 6, RULE_stringList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 56;
			Match(SQUOTESTRING);
			State = 61;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 57;
				Match(COMMA);
				State = 58;
				Match(SQUOTESTRING);
				}
				}
				State = 63;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlockContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMBERED() { return GetToken(AutParser.NUMBERED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DQUOTESTRING() { return GetToken(AutParser.DQUOTESTRING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LSQUARE() { return GetToken(AutParser.LSQUARE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INTEGER() { return GetTokens(AutParser.INTEGER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER(int i) {
			return GetToken(AutParser.INTEGER, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(AutParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(AutParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RSQUARE() { return GetToken(AutParser.RSQUARE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StringListContext stringList() {
			return GetRuleContext<StringListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQUALS() { return GetToken(AutParser.EQUALS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BLOCK_DATA() { return GetToken(AutParser.BLOCK_DATA, 0); }
		public BlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.EnterBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.ExitBlock(this);
		}
	}

	[RuleVersion(0)]
	public BlockContext block() {
		BlockContext _localctx = new BlockContext(Context, State);
		EnterRule(_localctx, 8, RULE_block);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 64;
			Match(NUMBERED);
			State = 65;
			Match(DQUOTESTRING);
			State = 66;
			Match(LSQUARE);
			State = 67;
			Match(INTEGER);
			State = 68;
			Match(COMMA);
			State = 69;
			Match(INTEGER);
			State = 70;
			Match(COMMA);
			State = 71;
			Match(INTEGER);
			State = 72;
			Match(COMMA);
			State = 73;
			Match(INTEGER);
			State = 74;
			Match(RSQUARE);
			State = 75;
			stringList();
			State = 76;
			Match(EQUALS);
			State = 77;
			Match(BLOCK_DATA);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConnectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RIGHTANGLE() { return GetToken(AutParser.RIGHTANGLE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INTEGER() { return GetTokens(AutParser.INTEGER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER(int i) {
			return GetToken(AutParser.INTEGER, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(AutParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQUALS() { return GetToken(AutParser.EQUALS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(AutParser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Connection_lineContext connection_line() {
			return GetRuleContext<Connection_lineContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(AutParser.RBRACE, 0); }
		public ConnectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_connection; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.EnterConnection(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.ExitConnection(this);
		}
	}

	[RuleVersion(0)]
	public ConnectionContext connection() {
		ConnectionContext _localctx = new ConnectionContext(Context, State);
		EnterRule(_localctx, 10, RULE_connection);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 79;
			Match(RIGHTANGLE);
			State = 80;
			Match(INTEGER);
			State = 81;
			Match(COLON);
			State = 82;
			Match(INTEGER);
			State = 83;
			Match(EQUALS);
			State = 84;
			Match(LBRACE);
			State = 85;
			connection_line();
			State = 86;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlankConnectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RIGHTANGLE() { return GetToken(AutParser.RIGHTANGLE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INTEGER() { return GetTokens(AutParser.INTEGER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER(int i) {
			return GetToken(AutParser.INTEGER, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQUALS() { return GetToken(AutParser.EQUALS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(AutParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(AutParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(AutParser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Connection_lineContext connection_line() {
			return GetRuleContext<Connection_lineContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(AutParser.RBRACE, 0); }
		public BlankConnectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_blankConnection; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.EnterBlankConnection(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.ExitBlankConnection(this);
		}
	}

	[RuleVersion(0)]
	public BlankConnectionContext blankConnection() {
		BlankConnectionContext _localctx = new BlankConnectionContext(Context, State);
		EnterRule(_localctx, 12, RULE_blankConnection);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 88;
			Match(RIGHTANGLE);
			State = 89;
			Match(INTEGER);
			State = 90;
			Match(EQUALS);
			State = 91;
			Match(INTEGER);
			State = 92;
			Match(COMMA);
			State = 93;
			Match(INTEGER);
			State = 94;
			Match(COMMA);
			State = 95;
			Match(T__0);
			State = 96;
			Match(LBRACE);
			State = 97;
			connection_line();
			State = 98;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Xy_pairContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INTEGER() { return GetTokens(AutParser.INTEGER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER(int i) {
			return GetToken(AutParser.INTEGER, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(AutParser.COMMA, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERIOD() { return GetToken(AutParser.PERIOD, 0); }
		public Xy_pairContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_xy_pair; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.EnterXy_pair(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.ExitXy_pair(this);
		}
	}

	[RuleVersion(0)]
	public Xy_pairContext xy_pair() {
		Xy_pairContext _localctx = new Xy_pairContext(Context, State);
		EnterRule(_localctx, 14, RULE_xy_pair);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 100;
			Match(INTEGER);
			State = 101;
			Match(COMMA);
			State = 102;
			Match(INTEGER);
			State = 104;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==PERIOD) {
				{
				State = 103;
				Match(PERIOD);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Connection_lineContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACE() { return GetTokens(AutParser.LBRACE); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE(int i) {
			return GetToken(AutParser.LBRACE, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACE() { return GetTokens(AutParser.RBRACE); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE(int i) {
			return GetToken(AutParser.RBRACE, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Xy_pairContext[] xy_pair() {
			return GetRuleContexts<Xy_pairContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Xy_pairContext xy_pair(int i) {
			return GetRuleContext<Xy_pairContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEMICOLON() { return GetTokens(AutParser.SEMICOLON); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON(int i) {
			return GetToken(AutParser.SEMICOLON, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Connection_lineContext[] connection_line() {
			return GetRuleContexts<Connection_lineContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Connection_lineContext connection_line(int i) {
			return GetRuleContext<Connection_lineContext>(i);
		}
		public Connection_lineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_connection_line; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.EnterConnection_line(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutListener typedListener = listener as IAutListener;
			if (typedListener != null) typedListener.ExitConnection_line(this);
		}
	}

	[RuleVersion(0)]
	public Connection_lineContext connection_line() {
		Connection_lineContext _localctx = new Connection_lineContext(Context, State);
		EnterRule(_localctx, 16, RULE_connection_line);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 123;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 106;
					Match(LBRACE);
					{
					State = 107;
					xy_pair();
					State = 112;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==SEMICOLON) {
						{
						{
						State = 108;
						Match(SEMICOLON);
						State = 109;
						xy_pair();
						}
						}
						State = 114;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					State = 118;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==LBRACE) {
						{
						{
						State = 115;
						connection_line();
						}
						}
						State = 120;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
					State = 121;
					Match(RBRACE);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 125;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,8,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,19,128,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,
		0,1,1,4,1,35,8,1,11,1,12,1,36,1,1,4,1,40,8,1,11,1,12,1,41,1,1,5,1,45,8,
		1,10,1,12,1,48,9,1,1,2,1,2,1,2,1,2,1,2,3,2,55,8,2,1,3,1,3,1,3,5,3,60,8,
		3,10,3,12,3,63,9,3,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,
		1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,6,1,
		6,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,3,7,105,8,7,1,8,1,8,1,8,1,8,5,8,
		111,8,8,10,8,12,8,114,9,8,1,8,5,8,117,8,8,10,8,12,8,120,9,8,1,8,1,8,4,
		8,124,8,8,11,8,12,8,125,1,8,0,0,9,0,2,4,6,8,10,12,14,16,0,0,127,0,18,1,
		0,0,0,2,34,1,0,0,0,4,54,1,0,0,0,6,56,1,0,0,0,8,64,1,0,0,0,10,79,1,0,0,
		0,12,88,1,0,0,0,14,100,1,0,0,0,16,123,1,0,0,0,18,19,5,2,0,0,19,20,5,3,
		0,0,20,21,5,4,0,0,21,22,5,5,0,0,22,23,5,4,0,0,23,24,5,5,0,0,24,25,5,6,
		0,0,25,26,5,5,0,0,26,27,5,4,0,0,27,28,5,5,0,0,28,29,3,2,1,0,29,30,5,14,
		0,0,30,31,5,5,0,0,31,32,5,7,0,0,32,1,1,0,0,0,33,35,3,4,2,0,34,33,1,0,0,
		0,35,36,1,0,0,0,36,34,1,0,0,0,36,37,1,0,0,0,37,39,1,0,0,0,38,40,3,10,5,
		0,39,38,1,0,0,0,40,41,1,0,0,0,41,39,1,0,0,0,41,42,1,0,0,0,42,46,1,0,0,
		0,43,45,3,12,6,0,44,43,1,0,0,0,45,48,1,0,0,0,46,44,1,0,0,0,46,47,1,0,0,
		0,47,3,1,0,0,0,48,46,1,0,0,0,49,55,3,8,4,0,50,51,5,6,0,0,51,52,3,2,1,0,
		52,53,5,7,0,0,53,55,1,0,0,0,54,49,1,0,0,0,54,50,1,0,0,0,55,5,1,0,0,0,56,
		61,5,11,0,0,57,58,5,4,0,0,58,60,5,11,0,0,59,57,1,0,0,0,60,63,1,0,0,0,61,
		59,1,0,0,0,61,62,1,0,0,0,62,7,1,0,0,0,63,61,1,0,0,0,64,65,5,3,0,0,65,66,
		5,10,0,0,66,67,5,8,0,0,67,68,5,5,0,0,68,69,5,4,0,0,69,70,5,5,0,0,70,71,
		5,4,0,0,71,72,5,5,0,0,72,73,5,4,0,0,73,74,5,5,0,0,74,75,5,9,0,0,75,76,
		3,6,3,0,76,77,5,12,0,0,77,78,5,18,0,0,78,9,1,0,0,0,79,80,5,15,0,0,80,81,
		5,5,0,0,81,82,5,14,0,0,82,83,5,5,0,0,83,84,5,12,0,0,84,85,5,6,0,0,85,86,
		3,16,8,0,86,87,5,7,0,0,87,11,1,0,0,0,88,89,5,15,0,0,89,90,5,5,0,0,90,91,
		5,12,0,0,91,92,5,5,0,0,92,93,5,4,0,0,93,94,5,5,0,0,94,95,5,4,0,0,95,96,
		5,1,0,0,96,97,5,6,0,0,97,98,3,16,8,0,98,99,5,7,0,0,99,13,1,0,0,0,100,101,
		5,5,0,0,101,102,5,4,0,0,102,104,5,5,0,0,103,105,5,16,0,0,104,103,1,0,0,
		0,104,105,1,0,0,0,105,15,1,0,0,0,106,107,5,6,0,0,107,112,3,14,7,0,108,
		109,5,13,0,0,109,111,3,14,7,0,110,108,1,0,0,0,111,114,1,0,0,0,112,110,
		1,0,0,0,112,113,1,0,0,0,113,118,1,0,0,0,114,112,1,0,0,0,115,117,3,16,8,
		0,116,115,1,0,0,0,117,120,1,0,0,0,118,116,1,0,0,0,118,119,1,0,0,0,119,
		121,1,0,0,0,120,118,1,0,0,0,121,122,5,7,0,0,122,124,1,0,0,0,123,106,1,
		0,0,0,124,125,1,0,0,0,125,123,1,0,0,0,125,126,1,0,0,0,126,17,1,0,0,0,9,
		36,41,46,54,61,104,112,118,125
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
