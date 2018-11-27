grammar StringGrammar;
/*
 * Parser Rules
 */
prog                       : expression? EOF;
expression                  : (
                                  SHIFT_LEFT '[' NUMBER ']'
                                | SHIFT_RIGHT '[' NUMBER ']'
                                | UPPER
                                | LOWER
                                | SUBSTRING '[' NUMBER (COMMA NUMBER)? ']'
                              ) expression
                           | expression (CONCANTENATE | DIFFERENCE) expression
                           | OBRACKET expression CBRACKET
                           | STRING
                           ;

/*
 * Lexer Rules
 */

COMMA               : ',';
OBRACKET            : '(';
CBRACKET            : ')';
CONCANTENATE        : '+';
DIFFERENCE          : '-';
SHIFT_RIGHT         : '>';
SHIFT_LEFT          : '<';
UPPER               : '^';
LOWER               : '_';
SUBSTRING           : '$';

NUMBER              : [1-9] (DIGIT)* | [0];
DIGIT               : [0-9];

STRING : '"' (~('"' | '\\' | '\r' | '\n') | '\\' ('"' | '\\'))* '"';
STRING2 : '"' ( '\\"' | . )*? '"' ;
WS : [ \r\t\n]+ -> skip ;