using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace RaffaLang.src
{
    public class Interpretador777
    {
        public string code_ = String.Empty;
        int ignore = 0x0;
        int onfor = 0x0;
        int savei = 0;

        public void Execute()
        {
            string[] Codes = code_.Split(new string[] { "BRO;" }, StringSplitOptions.None);

            for (int i = 0; i < Codes.Length; i++)
            {
                if (Codes[i].StartsWith("\r") || Codes[i].StartsWith("\n"))
                {
                    Codes[i] = Codes[i].Replace("\n", String.Empty);
                    Codes[i] = Codes[i].Replace("\r", String.Empty);
                }
                if (ignore == 0x0)
                {
                    if (Codes[i].StartsWith("TODO MUNDO FALA DE MIM"))
                    {
                        char[] listCharPrint = Codes[i].ToCharArray();
                        if (listCharPrint[23] == '"')
                        {
                            Program.Bro_Internal.print(Codes[i].Replace("TODO MUNDO FALA DE MIM ", String.Empty).Replace("\"", String.Empty));
                        }
                        else
                        {
                            string[] varFind = Codes[i].Split(' ');
                            string memory = Codes[i].Replace("TODO MUNDO FALA DE MIM ", String.Empty).Replace("&", String.Empty);
                            memory = memory.Replace(" ", String.Empty);
                            switch (Program.Bro_Internal.VariaveisTipo[memory])
                            {
                                case "FERNVNDXCLOTHING":
                                    Program.Bro_Internal.print(Program.Bro_Internal.VariaveisInteirasBro[memory].ToString());
                                    break;
                                case "LEAN":
                                    Program.Bro_Internal.print(Program.Bro_Internal.VariaveisStringsBro[memory].ToString());
                                    break;
                            }
                        }
                    }
                    else if (Codes[i].StartsWith("VARIAVEL"))
                    {
                        string[] format = Codes[i].Split(' ');
                        if (format.Length >= 7)
                        {
                            if (format[4] == "=")
                            {
                                switch (format[3])
                                {
                                    //int
                                    case "FERNVNDXCLOTHING":
                                        Program.Bro_Internal.VariaveisInteirasBro.Add(format[1], int.Parse(format[5]));
                                        Program.Bro_Internal.VariaveisTipo.Add(format[1], "FERNVNDXCLOTHING");
                                        break;
                                    //string
                                    case "LEAN":
                                        string melhorqregex = Codes[i].Replace($"VARIAVEL {format[1]} = LEAN = ", String.Empty).Replace("\"", String.Empty);
                                        Program.Bro_Internal.VariaveisStringsBro.Add(format[1], melhorqregex);
                                        Program.Bro_Internal.VariaveisTipo.Add(format[1], "LEAN");
                                        break;
                                }
                            }
                        }

                        else
                        {
                            switch (format[3])
                            {
                                //int
                                case "FERNVNDXCLOTHING":
                                    Program.Bro_Internal.VariaveisInteirasBro.Add(format[1], 0);
                                    Program.Bro_Internal.VariaveisTipo.Add(format[1], "FERNVNDXCLOTHING");
                                    break;
                                //string
                                case "LEAN":
                                    Program.Bro_Internal.VariaveisStringsBro.Add(format[1], String.Empty);
                                    Program.Bro_Internal.VariaveisTipo.Add(format[1], "LEAN");
                                    break;
                            }
                        }
                    }
                    else if (Codes[i].StartsWith("MAIS CASH NA MINHA CONTA"))
                    {
                        string[] format = Codes[i].Split(' ');
                        string memory = Codes[i].Replace("MAIS CASH NA MINHA CONTA ", String.Empty).Replace("&", String.Empty);
                        memory = memory.Replace(" ", String.Empty);
                        switch (Program.Bro_Internal.VariaveisTipo[memory])
                        {
                            case "FERNVNDXCLOTHING":
                                int a = Program.Bro_Internal.VariaveisInteirasBro[memory];
                                a++;
                                Program.Bro_Internal.VariaveisInteirasBro[memory] = a;
                                break;
                        }
                    }
                    else if (Codes[i].StartsWith("PAGA OQ SE ME DEVE"))
                    {
                        string[] format = Codes[i].Split(' ');
                        string memory = Codes[i].Replace("PAGA OQ SE ME DEVE ", String.Empty).Replace("&", String.Empty);
                        memory = memory.Replace(" ", String.Empty);
                        switch (Program.Bro_Internal.VariaveisTipo[memory])
                        {
                            case "FERNVNDXCLOTHING":
                                int a = Program.Bro_Internal.VariaveisInteirasBro[memory];
                                a--;
                                Program.Bro_Internal.VariaveisInteirasBro[memory] = a;
                                break;
                        }
                    }
                    else if (Codes[i].StartsWith("MINHA CASA"))
                    {
                        Program.Bro_Internal.MinhaCasaBroID = i;
                    }
                    else if (Codes[i].StartsWith("MEU MANO VOLTA PRA SUA CASA SE NAO VOU ATIRAR NA SUA CARA E VOU RIR"))
                    {
                        i = Program.Bro_Internal.MinhaCasaBroID;
                    }
                    else if (Codes[i].StartsWith("SETA"))
                    {
                        string[] format = Codes[i].Split(' ');
                        switch (Program.Bro_Internal.VariaveisTipo[format[1]])
                        {
                            case "FERNVNDXCLOTHING":
                                Program.Bro_Internal.VariaveisInteirasBro[format[1]] = int.Parse(format[3]);
                                break;
                            case "LEAN":
                                Program.Bro_Internal.VariaveisStringsBro[format[1]] = format[3];
                                break;
                        }
                    }
                    else if (Codes[i].StartsWith("EU TENHO MACONHA AGR SOMA AE"))
                    {
                        string[] format = Codes[i].Split(' ');
                        string memory = format[6].Replace("&", String.Empty);
                        memory = memory.Replace(" ", String.Empty);
                        switch (Program.Bro_Internal.VariaveisTipo[memory])
                        {
                            case "FERNVNDXCLOTHING":
                                if (format[7].StartsWith("&"))
                                {
                                    string memory_ = format[7].Replace("&", String.Empty);
                                    switch (Program.Bro_Internal.VariaveisTipo[memory_])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            Program.Bro_Internal.VariaveisInteirasBro[memory] += Program.Bro_Internal.VariaveisInteirasBro[memory_];
                                            break;
                                    }
                                }
                                else
                                {
                                    Program.Bro_Internal.VariaveisInteirasBro[memory] += int.Parse(format[7]);
                                }
                                break;
                        }
                    }
                    else if (Codes[i].StartsWith("EU TENHO MACONHA AGR RETIRA AE"))
                    {
                        string[] format = Codes[i].Split(' ');
                        string memory = format[6].Replace("&", String.Empty);
                        memory = memory.Replace(" ", String.Empty);
                        switch (Program.Bro_Internal.VariaveisTipo[memory])
                        {
                            case "FERNVNDXCLOTHING":
                                if (format[7].StartsWith("&"))
                                {
                                    string memory_ = format[7].Replace("&", String.Empty);
                                    switch (Program.Bro_Internal.VariaveisTipo[memory_])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            Program.Bro_Internal.VariaveisInteirasBro[memory] -= Program.Bro_Internal.VariaveisInteirasBro[memory_];
                                            break;
                                    }
                                }
                                else
                                {
                                    Program.Bro_Internal.VariaveisInteirasBro[memory] -= int.Parse(format[7]);
                                }
                                break;
                        }
                    }
                    else if (Codes[i].StartsWith("ESPERA AI HATER"))
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                    }
                    else if (Codes[i].StartsWith("PEGA OS DADOS ANTES Q EU DOU UM TIRO NA SUA VO"))
                    {
                        string[] format = Codes[i].Split(' ');
                        string memory = format[12].Replace("&", String.Empty);
                        memory = memory.Replace(" ", String.Empty);
                        switch (Program.Bro_Internal.VariaveisTipo[memory])
                        {
                            case "FERNVNDXCLOTHING":
                                int result = int.Parse(Console.ReadLine());
                                Program.Bro_Internal.VariaveisInteirasBro[memory] = result;
                                break;
                            case "LEAN":
                                Program.Bro_Internal.VariaveisStringsBro[memory] = Console.ReadLine();
                                break;
                        }
                    }
                    else if (Codes[i].StartsWith("SE"))
                    {
                        string[] format = Codes[i].Split(' ');
                        string memory = format[1].Replace("&", String.Empty);
                        string type = format[2];
                        bool retorno = false;
                        if (format[3].StartsWith("&"))
                        {
                            string memory_ = format[3].Replace("&", String.Empty);
                            int value = 0;
                            string valueStr = String.Empty;
                            switch (Program.Bro_Internal.VariaveisTipo[memory_])
                            {
                                case "FERNVNDXCLOTHING":
                                    value = Program.Bro_Internal.VariaveisInteirasBro[memory_];
                                    break;
                                case "LEAN":
                                    valueStr = Program.Bro_Internal.VariaveisStringsBro[memory_];
                                    break;
                            }
                            switch (type)
                            {
                                case ">":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] > value)
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;
                                case "<":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] < value)
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;
                                case ">=":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] >= value)
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;
                                case "<=":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] <= value)
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;
                                case "==":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] == value)
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                        case "LEAN":
                                            string a = valueStr.Replace("\"", String.Empty).Replace("\\", String.Empty).Replace(" ", String.Empty);
                                            if (Program.Bro_Internal.VariaveisStringsBro[memory].Replace(" ", String.Empty) == a)
                                            {
                                                Console.WriteLine("oi");
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;
                                case "!=":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":

                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] != value)
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                        case "LEAN":
                                            string a = valueStr.Replace("\"", String.Empty).Replace("\\", String.Empty).Replace(" ", String.Empty);
                                            if (Program.Bro_Internal.VariaveisStringsBro[memory].Replace(" ", String.Empty) != a)
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;

                            }
                        }
                        else
                        {
                            switch (type)
                            {
                                case ">":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] > int.Parse(format[3]))
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;
                                case "<":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] < int.Parse(format[3]))
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;
                                case ">=":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] >= int.Parse(format[3]))
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;
                                case "<=":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] <= int.Parse(format[3]))
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;
                                case "==":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":
                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] == int.Parse(format[3]))
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                        case "LEAN":
                                            string a = format[3].Replace("\"", String.Empty).Replace("\\", String.Empty).Replace(" ", String.Empty);
                                            if (Program.Bro_Internal.VariaveisStringsBro[memory].Replace(" ", String.Empty) == a)
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;
                                case "!=":
                                    switch (Program.Bro_Internal.VariaveisTipo[memory])
                                    {
                                        case "FERNVNDXCLOTHING":

                                            if (Program.Bro_Internal.VariaveisInteirasBro[memory] != int.Parse(format[3]))
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                        case "LEAN":
                                            string a = format[3].Replace("\"", String.Empty).Replace("\\", String.Empty).Replace(" ", String.Empty);
                                            if (Program.Bro_Internal.VariaveisStringsBro[memory].Replace(" ", String.Empty) != a)
                                            {
                                                retorno = true;
                                            }
                                            else { retorno = false; ignore = 0x1; }
                                            break;
                                    }
                                    break;
                            }
                        }
                    }
                    else if (Codes[i].StartsWith("ENQUANTO EU TENHO MACONHA"))
                    {
                        string[] format = Codes[i].Split(' ');
                        string memory = format[4].Replace("&", String.Empty);
                        Program.Bro_Internal.forMemory = int.Parse(format[5]);
                        Program.Bro_Internal.forTemp = memory;
                        onfor = 0x1;
                        switch (Program.Bro_Internal.VariaveisTipo[memory])
                        {
                            case "FERNVNDXCLOTHING":
                                if (onfor == 0x1)
                                {
                                    savei = i;
                                }

                                if (Program.Bro_Internal.forMemory > 0)
                                {
                                    ignore = 0x0;
                                }
                                else
                                {
                                    onfor = 0x0;
                                    ignore = 0x1;
                                }


                                break;

                        }
                    }
                    if (Codes[i].StartsWith("FIM"))
                    {
                        if (onfor == 0x1)
                        {

                            if (Program.Bro_Internal.forMemory > 0)
                            {
                                Program.Bro_Internal.forMemory -= 1;
                                Program.Bro_Internal.VariaveisInteirasBro[Program.Bro_Internal.forTemp]++;
                                i = savei;
                            }
                            else
                            {
                                onfor = 0x0;
                            }
                        }
                        if (ignore == 0x1)
                        {
                            ignore = 0x0;
                        }
                    }
                }
                else
                {
                    if (Codes[i].StartsWith("FIM"))
                    {
                        ignore = 0x0;
                    }
                }

            }

            Console.ReadLine();
        }
    }
}
