grammar Aut;

AUT : '[Aut]' ;

NUMBERED : '#' [0-9] + ;

COMMA : ',' ;

INTEGER : [0-9] + ;

LBRACE : '{' ;
RBRACE : '}' ;

LSQUARE : '[' ;
RSQUARE : ']' ;

DQUOTESTRING : '"' .*? '"' ;
SQUOTESTRING : '\'' .*? '\'' ;

EQUALS : '=' ;

SEMICOLON : ';' ;

COLON : ':' ;
RIGHTANGLE : '>' ;
PERIOD : '.' ;

// There are some corrupted portions of files that I need to be able to ignore for the moment.
LINE_COMMENT : '--' .*? '\r'? '\n' -> skip ;

// Block Types
fragment BLOCK_TYPE 
    : 'AI'
    | 'ALARM'
    | 'AND'
    | 'AO'
    | 'COMENT'
    | 'CURVE'
    | 'DATE'
    | 'DELAY'
    | 'DELB'
    | 'DELI'
    | 'DELR'
    | 'DI'
    | 'DO'
    | 'ENTH'
    | 'ERR'
    | 'FILT'
    | 'HFAI'
    | 'HFAO'
    | 'HFB'
    | 'HFDI'
    | 'HFDO'
    | 'HOUR'
    | 'HYST'
    | 'LIMIT'
    | 'MAX'
    | 'MIN'
    | 'NOT'
    | 'Op!='
    | 'Op*'
    | 'Op+'
    | 'Op:?'
    | 'Op?:'
    | 'OpB'
    | 'Op-n'
    | 'OpR'
    | 'OpRB'
    | 'OpRR'
    | 'OPT'
    | 'OR'
    | 'OSC'
    | 'PIDP'
    | 'PRCNT'
    | 'PULSE'
    | 'PVB'
    | 'PVI'
    | 'PVR'
    | 'RAMP'
    | 'RT'
    | 'SR'
    | 'TRIG'
    | 'TSCH'
    | 'WDAY'
    | 'XPB'
    | 'XPI'
    | 'XPR'
    ;

BLOCK_DATA : BLOCK_TYPE .*? '\r'? '\n' ;

WS : [ \t\r\n]+ -> skip ;

file 
    : AUT 
    NUMBERED COMMA INTEGER COMMA INTEGER 
    LBRACE INTEGER COMMA INTEGER
    page
    COLON INTEGER 
    RBRACE
    ;

page : block_list+ connection+ blankConnection*;

block_list 
    : block # NormalBlock
    | LBRACE page RBRACE # NestedBlock
    ;

stringList : SQUOTESTRING (COMMA SQUOTESTRING)* ;

block 
    : NUMBERED DQUOTESTRING 
        LSQUARE INTEGER COMMA INTEGER COMMA INTEGER COMMA INTEGER RSQUARE 
        stringList
        EQUALS BLOCK_DATA
        ;


connection
    : RIGHTANGLE INTEGER COLON INTEGER EQUALS 
     LBRACE 
     connection_line
     RBRACE ;

blankConnection 
    : RIGHTANGLE INTEGER EQUALS INTEGER COMMA INTEGER COMMA 'N' LBRACE connection_line RBRACE ;

xy_pair : INTEGER COMMA INTEGER PERIOD? ;

connection_line : (LBRACE (xy_pair (SEMICOLON xy_pair)*  connection_line*) RBRACE)+ ;
