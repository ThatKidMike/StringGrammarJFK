grammar StringGrammar;



@parser::header {#pragma warning disable 3021}
@lexer::header {#pragma warning disable 3021}

/*
 * Parser Rules
 */
prog                       : expression? EOF;
expression                 : op = ( SHIFT_LEFT | SHIFT_RIGHT) NUMBER expression #shift
                           | op = ( LOWER | UPPER ) expression #case
                           | SUBSTRING NUMBER (COMMA NUMBER)? expression #substring
                           | expression op = (CONCANTENATE | DIFFERENCE) expression #con_diff
                           | OBRACKET expression CBRACKET #brackets
                           | STRING #string
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

STRING : '"' ( '\\"' | . )*? '"' ;
WS : [ \r\t\n]+ -> skip ;