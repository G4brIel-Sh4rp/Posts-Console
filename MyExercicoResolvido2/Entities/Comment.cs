﻿
namespace MyExercicoResolvido2.Entities
{
    class Comment
    {
        public string Text { get; set; }
    
        public Comment()
        {
        }
        public Comment (string text)
        {
            Text = text;
        }
        
        public override string ToString()
        {
            return "\n>>" + Text;
        }
    }
}
