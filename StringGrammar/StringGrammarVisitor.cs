using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;

using static StringGrammar.StringGrammarParser;

namespace StringGrammar {
    class StringGrammarVisitor : StringGrammarBaseVisitor<object> {

        public override object VisitString([NotNull] StringGrammarParser.StringContext context) {

            int string_length = context.STRING().ToString().Length;
            string s = context.STRING().ToString();
            for (int i = 1; i < s.Length - 1; i++)
            {
                if (s[i] == '"')
                {
                    s = s.Substring(0, i - 1) + s.Substring(i);
                }
            }
            return s.Substring(1, s.Length - 2);
        }

        public override object VisitShift([NotNull] ShiftContext context) {

            string result = "...";
            int n = int.Parse(context.NUMBER().ToString());

            switch (context.op.Type) {

                case SHIFT_LEFT:
                    result = sh_left(Visit(context.expression()).ToString(), n);
                    break;

                case SHIFT_RIGHT:
                    result = sh_right(Visit(context.expression()).ToString(), n);
                    break;
            }

            return result;
        }

        public override object VisitCon_diff([NotNull] StringGrammarParser.Con_diffContext context) {

            string result = "...";
            string left = Visit(context.expression(0)).ToString();
            string right = Visit(context.expression(1)).ToString();

            switch (context.op.Type) {

                case CONCANTENATE:  
                    result = left + right;
                    break;

                case DIFFERENCE:
                    result = diff(left, right);
                    break;

            }

            return result;
        }

        public override object VisitCase([NotNull] CaseContext context) {

            string result = "...";

            switch(context.op.Type) {

                case UPPER:
                    result = Visit(context.expression()).ToString().ToUpper();
                    break;

                case LOWER:
                    result = Visit(context.expression()).ToString().ToLower();
                    break;
            }

            return result;

        }

        public override object VisitSubstring([NotNull] SubstringContext context) {

            int n1;
            int n2;

            if (context.NUMBER(1) == null) {

                n1 = 0;
                n2 = int.Parse(context.NUMBER(0).ToString());       
                
            } else {

                n1 = int.Parse(context.NUMBER(0).ToString());
                n2 = int.Parse(context.NUMBER(1).ToString());

            }

            try {

                return Visit(context.expression()).ToString().Substring(n1, n2);

            } catch(Exception e) {
                String ret = Visit(context.expression()).ToString();
                Console.WriteLine("<PROBLEM>\n" + "Nie można wyłuskać podciągu o podanych parametrach z \"" + ret + "\"\n" + "</PROBLEM>\n");
                return ret;

            }

        }

        public override object VisitBrackets([NotNull] BracketsContext context) {

            return Visit(context.expression()).ToString();

        } 


        //shift methods 
        private static string sh_left(string chain, int amount) {
            return (chain.Substring(amount) + chain.Substring(0, amount));
        }
        private static string sh_right(string chain, int amount) {
            return chain.Substring(chain.Length - amount) + chain.Substring(0, chain.Length - amount);
        }

        private static string diff(string left, string right) {
            foreach (char c in right) {
                if (left.Contains(c)) {
                    left = left.Remove(left.IndexOf(c), 1);
                }
            }
            return left;
        }

    }
}
