using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfrator
{
    class Options
    {
        bool keyword_white;
        bool keyword_capital_letters;

        bool message_white;
        bool message_capital_letters;

        String cryptogram_replace;
        public void update(bool keyword_white, bool keyword_capital_letters, bool message_white, bool message_capital_letters,String cryptogram_replace)
        {
            this.keyword_white = keyword_white;
            this.keyword_capital_letters = keyword_capital_letters;
            this.message_white = message_white;
            this.message_capital_letters = message_capital_letters;
            this.cryptogram_replace = cryptogram_replace;
        }

        public bool get_keyword_white()
        {
            return keyword_white;
        }
        public bool get_keyword_capital_letters()
        {
            return keyword_capital_letters;
        }
        public bool get_message_white()
        {
            return message_white;
        }
        public bool get_message_capital_letters()
        {
            return message_capital_letters;
        }
        public String get_cryptogram_replace()
        {
            return cryptogram_replace;
        }
    }
}
