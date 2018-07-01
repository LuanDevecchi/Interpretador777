using System;
using System.Collections.Generic;

namespace RaffaLang.src
{
    public class Interpretador777
    {
        public string code_ = String.Empty;


        public void Execute()
        {
            string[] Codes = code_.Split(new string[] { "BRO;" }, StringSplitOptions.None);
            
            for(int i=0; i < Codes.Length; i ++ )
            {
                if(Codes[i].StartsWith("\r") || Codes[i].StartsWith("\n"))
                {
                    Codes[i] = Codes[i].Replace("\n", String.Empty);
                    Codes[i] = Codes[i].Replace("\r", String.Empty);
                }
                if(Codes[i].StartsWith("TODO MUNDO FALA DE MIM"))
                {
                    Program.Bro_Internal.print(Codes[i].Replace("TODO MUNDO FALA DE MIM ", String.Empty).Replace("\"",String.Empty));
                }
            }

            Console.ReadLine();
        }
    }
}
