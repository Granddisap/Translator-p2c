using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace cnvrt
{
    public class Lexical
    {
        private enum define
	    {
            AND=1,
            ASM,
            ARRAY,
            BEGIN,
            CASE,
            CONST,
            CONSTRUCTOR,
            DESTRUCTOR,
            DIV,
            DO,
            DOWNTO,
            ELSE,
            END,
            EXPORT,
            FILE,
            FOR,
            FUNCTION,
            GOTO,
            IF,
            IMPLEMENTATION,
            IN,
            INHERITED,
            INLINE,
            INTERFACE,
            LABEL,
            LIBRARY,
            MOD,
            NIL,
            NOT,
            OBJECT,
            OF,
            OR,
            PACKED,
            PROCEDURE,
            PROGRAM,
            RECORD,
            REPEAT,
            SET,
            SHL,
            SHR,
            STRING,
            THEN,
            TO,
            TYPE,
            UNIT,
            UNTIL,
            USES,
            VAR,
            WHILE,
            WITH,
            XOR,
            INTEGER,
            LONGINT,
            REAL,
            CHAR,
            STEP,
            READ,
            WRITE,
            OTHERWISE,
            IDENTIFIER,
            CHARACTER,
            PLUS,
            MINUS,
            MUL,
            DIVIZARE,
            ASSIGN,
            EQUAL,
            NOTEQUAL,
            MAIMICSAUEGAL,
            MAIMARESAUEGAL,
            PARL,
            PARR,
            ACOLL,
            ACOLR,
            PARDL,
            PARDR,
            PUNCT,
            VIRGULA,
            PUNCTSIVIRGULA,
            DOUAOUNCTE,
            DOMENIU,
            MAIMIC,
            MAIMARE,
            SIRCARACTERE,
            NRINTEGER,
            NRREAL,
            AT,
            POINTER,
            DOLLAR,
            COMENTARIU,
            GHILIMELE,
            GHILIMELESIMPLE,
            EXCLAM,
            DIEZ,
            PROCENT,
            SI,
            INTREBARE,
            BACKSLASH,
            SAU,
            NUMEPROGRAM
        };
        private string[] lista;
        private int count = 0;
        public int contor = 0;
        private int position = 0;
        private Hashtable tabel_expresii = new Hashtable();
        private Hashtable tabel_atomi = new Hashtable();
        /// <summary>
        /// конструктор класса AnalyzerL
        /// </summary>
        /// <param name="lista">ListView объект</param>
        public Lexical(string[] lista)
        {
            this.lista = lista;
            tabel_expresii.Add("and",1);
            tabel_expresii.Add("asm",2);
            tabel_expresii.Add("array", 3);
            tabel_expresii.Add("begin",4);
            tabel_expresii.Add("case", 5);
            tabel_expresii.Add("const", 6);
            tabel_expresii.Add("constructor",7);
            tabel_expresii.Add("destructor",8);
            tabel_expresii.Add("div",9);
            tabel_expresii.Add("do",10);
            tabel_expresii.Add("downto", 11);
            tabel_expresii.Add("else",12);
            tabel_expresii.Add("end",13);
            tabel_expresii.Add("export",14);
            tabel_expresii.Add("file",15);
            tabel_expresii.Add("for",16);
            tabel_expresii.Add("function",17);
            tabel_expresii.Add("goto", 18);
            tabel_expresii.Add("if",19);
            tabel_expresii.Add("implementation", 20);
            tabel_expresii.Add("in", 21);
            tabel_expresii.Add("inherited",22);
            tabel_expresii.Add("inline",23);
            tabel_expresii.Add("interface", 24);
            tabel_expresii.Add("label", 25);
            tabel_expresii.Add("library", 26);
            tabel_expresii.Add("mod", 27);
            tabel_expresii.Add("nil", 28);
            tabel_expresii.Add("not",29);
            tabel_expresii.Add("object", 30);
            tabel_expresii.Add("of", 31);
            tabel_expresii.Add("or", 32);
            tabel_expresii.Add("packed", 33);
            tabel_expresii.Add("procedure",34);
            tabel_expresii.Add("program", 35);
            tabel_expresii.Add("record", 36);
            tabel_expresii.Add("repeat", 37);
            tabel_expresii.Add("set", 38);
            tabel_expresii.Add("shl", 39);
            tabel_expresii.Add("shr", 40);
            tabel_expresii.Add("string", 41);
            tabel_expresii.Add("then", 42);
            tabel_expresii.Add("to", 43);
            tabel_expresii.Add("type", 44);
            tabel_expresii.Add("unit", 45);
            tabel_expresii.Add("until", 46);
            tabel_expresii.Add("uses", 47);
            tabel_expresii.Add("var", 48);
            tabel_expresii.Add("while", 49);
            tabel_expresii.Add("with", 50);
            tabel_expresii.Add("xor", 51);
            tabel_expresii.Add("integer", 52);
            tabel_expresii.Add("longint", 53);
            tabel_expresii.Add("real", 54);
            tabel_expresii.Add("char", 55);
            tabel_expresii.Add("step", 56);
            tabel_expresii.Add("read",57);
            tabel_expresii.Add("write",58);
            tabel_expresii.Add("otherwise", 59);
        }
        string atom = "";
        bool tip_nr_real = false;
        string stare = "nimic";
        string tip_sir = "identificator";
        /// <summary>
        /// в зависимости от определения атомов в коде Паскаля
        /// </summary>
        public void Analizare()
        {
            for (int i = 0; i < lista.Length; i++)
            {
                string linie = lista[i];
                linie = linie.ToLower();
                string[] atom_i = linie.Split(' ');
                for (int j = 0; j < atom_i.Length; j++)
                {
                    atom_i[j] = atom_i[j].Replace(" ", "");
                    atom_i[j] = atom_i[j].Replace("\t", "");
                    atom_i[j] = atom_i[j].Replace("\n", "");
                    atom_i[j] = atom_i[j].Replace("\r", "");

                    if (atom_i[j].Length > 0)
                    {
                        stare = Identificator.idntf(atom_i[j][0]);
                        for (int t = 0; t < atom_i[j].Length; t++)
                        {
                            if (stare.CompareTo("caracter") != 0)
                            {
                                if (Identificator.idntf(atom_i[j][t]).CompareTo(stare) == 0)
                                {
                                    if (stare.CompareTo("alfabetic") == 0)
                                    {
                                        atom += atom_i[j][t];
                                    }
                                    else
                                    {
                                        atom += atom_i[j][t];
                                        if (atom_i[j].Length > t + 1)
                                        {
                                            if (atom_i[j][t + 1] == '.')
                                            {
                                                if (atom_i[j].Length > t + 2)
                                                {
                                                    if (atom_i[j][t + 2] == '.')
                                                    {
                                                        Atom atom_curent = new Atom((int)define.NRINTEGER, atom, i);
                                                        tabel_atomi.Add(count, atom_curent);
                                                        count++;
                                                        stare = Identificator.idntf(atom_i[j][t]);
                                                        atom = "";
                                                    }
                                                    else
                                                    {
                                                        t++;
                                                        atom += atom_i[j][t];
                                                        tip_nr_real = true;
                                                        if (atom_i[j].Length > t + 1)
                                                        {
                                                            if (atom_i[j][t + 1] == 'E' || atom_i[j][t + 1] == 'e')
                                                            {
                                                                t++;
                                                                atom += 'E';
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    t++;
                                                    atom += atom_i[j][t];
                                                    tip_nr_real = true;
                                                    if (atom_i[j].Length > t + 1)
                                                    {
                                                        if (atom_i[j][t + 1] == 'E' || atom_i[j][t + 1] == 'e')
                                                        {
                                                            t++;
                                                            atom += 'E';
                                                        }
                                                    }
                                                }
                                            }
                                            if (atom_i[j].Length > t + 1)
                                            {
                                                if (atom_i[j][t + 1] == 'E' || atom_i[j][t + 1] == 'e')
                                                {
                                                    t++;
                                                    atom += 'E';
                                                    tip_nr_real = true;
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {

                                    if (tabel_expresii.ContainsKey(atom) == true && tip_sir.CompareTo("identificator") == 0)
                                    {
                                        Atom atom_curent = new Atom((int)tabel_expresii[atom], atom, i);
                                        tabel_atomi.Add(count, atom_curent);
                                        stare = Identificator.idntf(atom_i[j][t]);
                                        count++;
                                        atom = "";
                                        t--;
                                    }
                                    else if (stare.CompareTo("alfabetic") == 0)
                                    {
                                        Atom atom_curent = new Atom(0, null, 0);
                                        if (tip_sir.CompareTo("identificator") == 0)
                                        {
                                            atom_curent = new Atom((int)define.IDENTIFIER, atom, i);
                                        }
                                        else if (tip_sir.CompareTo("comentariu") == 0)
                                        {
                                            atom_curent = new Atom((int)define.COMENTARIU, atom, i);
                                        }
                                        else if (tip_sir.CompareTo("caracter") == 0)
                                        {
                                            atom_curent = new Atom((int)define.CHARACTER, atom, i);
                                        }
                                        else if (tip_sir.CompareTo("string") == 0)
                                        {
                                            atom_curent = new Atom((int)define.SIRCARACTERE, atom, i);
                                        }

                                        if (atom_curent.valoare.Length > 0)
                                        {
                                            tabel_atomi.Add(count, atom_curent);
                                              count++;
                                        }
                                        stare = Identificator.idntf(atom_i[j][t]);
                                        atom = "";
                                        t--;
                                    }
                                    else if (stare.CompareTo("numar") == 0)
                                    {
                                        Atom atom_curent = new Atom(0, null, 0);
                                        if (tip_nr_real == true)
                                        {
                                            atom_curent = new Atom((int)define.NRREAL, atom, i);
                                            tip_nr_real = false;
                                        }
                                        else
                                        {
                                            atom_curent = new Atom((int)define.NRINTEGER, atom, i);
                                        }
                                        if (atom_curent.valoare.Length > 0)
                                        {
                                            tabel_atomi.Add(count, atom_curent);
                                            count++;
                                        }
                                        stare = Identificator.idntf(atom_i[j][t]);
                                        atom = "";
                                        t--;
                                    }
                                }
                            }
                            else
                            {
                                t = AnalizareCaractere(j, t, i, atom_i);
                            }
                        }
                        if (stare.CompareTo("alfabetic") == 0)
                        {   
                            if (tabel_expresii.ContainsKey(atom) == true && tip_sir.CompareTo("identificator") == 0)
                            {
                                Atom atom_curent = new Atom((int)tabel_expresii[atom], atom, i);
                                if (atom_curent.valoare.Length > 0)
                                {
                                    tabel_atomi.Add(count, atom_curent);
                                    count++;
                                }
                                atom = "";
                            }
                            else
                            {
                                Atom atom_curent = new Atom(0, null, 0);
                                if (tip_sir.CompareTo("identificator") == 0)
                                {
                                    atom_curent = new Atom((int)define.IDENTIFIER, atom, i);
                                }
                                else if (tip_sir.CompareTo("comentariu") == 0)
                                {
                                    atom_curent = new Atom((int)define.COMENTARIU, atom, i);
                                }
                                else if (tip_sir.CompareTo("caracter") == 0)
                                {
                                    atom_curent = new Atom((int)define.CHARACTER, atom, i);
                                }
                                else if (tip_sir.CompareTo("string") == 0)
                                {
                                    atom_curent = new Atom((int)define.SIRCARACTERE, atom, i);
                                }
                                if (atom_curent.valoare.Length > 0)
                                {
                                    tabel_atomi.Add(count, atom_curent);
                                    count++;
                                }
                                atom = "";
                            }
                        }
                        else if (stare.CompareTo("numar") == 0 && atom.CompareTo("") != 0)
                        {
                            Atom atom_curent = new Atom(0, null, 0);
                            if (tip_nr_real == true)
                            {
                                atom_curent = new Atom((int)define.NRREAL, atom, i);
                                tip_nr_real = false;
                            }
                            else
                            {
                                atom_curent = new Atom((int)define.NRINTEGER, atom, i);
                            }
                            if (atom_curent.valoare.Length > 0)
                            {
                                tabel_atomi.Add(count, atom_curent);
                                count++;
                            }
                            atom = "";
                        }
                        else if (stare.CompareTo("caracter") == 0 && atom.CompareTo(".") == 0)
                        {
                            Atom atom_curent = new Atom((int)define.PUNCT, atom, i);
                            if (atom_curent.valoare.Length > 0)
                            {
                                tabel_atomi.Add(count, atom_curent);
                                count++;
                            }
                            atom = "";
                        }
                    }
                }
            }                
            tabel_atomi.Add(count, new Atom((int)define.END, "sfarsit", lista.Length+1));
            contor = tabel_atomi.Count;
        }
        /// <summary>
        /// функция идентификации персонажа
        /// </summary>
        /// <param name="j">номер слова</param>
        /// <param name="t">номер символа в слове</param>
        /// <param name="i">номер строки</param>
        /// <param name="atom_i">ряд символов</param>
        /// <returns></returns>
        private int AnalizareCaractere(int j, int t,int i, string[] atom_i)
        {
            if (atom_i[j][t] == '{')
            {
                tip_sir = "comentariu";
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.ACOLL, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";

            }
            else if (atom_i[j][t] == '}')
            {
                tip_sir = "identificator";
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.ACOLR, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";

            }
            else if (atom_i[j][t] == ':')
            {
                atom += atom_i[j][t];
                if (atom_i[j].Length > t + 1)
                {
                    if (atom_i[j][t + 1] == '=')
                    {
                        atom += atom_i[j][t + 1];
                        Atom atom_curent = new Atom((int)define.ASSIGN, atom,i);
                        tabel_atomi.Add(count, atom_curent);
                        count++;
                        if (atom_i[j].Length > t + 1)
                        {
                            stare = Identificator.idntf(atom_i[j][t + 2]);
                        }
                        atom = "";
                        t++;
                    }
                    else
                    {
                        Atom atom_curent = new Atom((int)define.DOUAOUNCTE, atom,i);
                        tabel_atomi.Add(count, atom_curent);
                        count++;
                        if (atom_i[j].Length > t + 1)
                        {
                            stare = Identificator.idntf(atom_i[j][t + 1]);
                        }
                        atom = "";
                    }
                }
                else
                {
                    Atom atom_curent = new Atom((int)define.DOUAOUNCTE, atom, i);
                    tabel_atomi.Add(count, atom_curent);
                    count++;
                    if (atom_i[j].Length > t + 1)
                    {
                        stare = Identificator.idntf(atom_i[j][t + 1]);
                    }
                    atom = "";
                }
            }
            else if (atom_i[j][t] == ';')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.PUNCTSIVIRGULA, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";

            }
            else if (atom_i[j][t] == '.')
            {
                atom += atom_i[j][t];
                if (atom_i[j].Length > t + 1)
                {
                    if (atom_i[j][t + 1] == '.')
                    {
                        atom += atom_i[j][t + 1];
                        Atom atom_curent = new Atom((int)define.DOMENIU, atom,i);
                        tabel_atomi.Add(count, atom_curent);
                        count++;
                        if (atom_i[j].Length > t + 1)
                        {
                            stare = Identificator.idntf(atom_i[j][t + 2]);
                        }
                        atom = "";
                        t++;
                        return t;
                    }
                }
                else
                {
                    Atom atom_curent = new Atom((int)define.PUNCT, atom,i);
                    tabel_atomi.Add(count, atom_curent);
                    count++;
                    if (atom_i[j].Length > t + 1)
                    {
                        stare = Identificator.idntf(atom_i[j][t + 1]);
                    }
                    atom = "";
                }
            }
            else if (atom_i[j][t] == '(')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.PARL, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";

            }
            else if (atom_i[j][t] == ')')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.PARR, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '\'')
            {
                if (tip_sir.CompareTo("caracter") != 0)
                {
                    tip_sir = "caracter";
                }
                else
                {
                    tip_sir = "identificator";
                }
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.GHILIMELESIMPLE, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '\"')
            {
                if (tip_sir.CompareTo("string") != 0)
                {
                    tip_sir = "string";
                }
                else
                {
                    tip_sir = "identificator";
                }
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.GHILIMELE, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '=')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.EQUAL, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '>')
            {
                atom += atom_i[j][t];
                if (atom_i[j].Length > t + 1)
                {
                    if (atom_i[j][t + 1] == '=')
                    {
                        atom += atom_i[j][t + 1];
                        Atom atom_curent = new Atom((int)define.MAIMARESAUEGAL, atom,i);
                        tabel_atomi.Add(count, atom_curent);
                        count++;
                        if (atom_i[j].Length > t + 1)
                        {
                            stare = Identificator.idntf(atom_i[j][t + 2]);
                        }
                        atom = "";
                        t++;
                    }
                    else
                    {
                        Atom atom_curent = new Atom((int)define.MAIMARE, atom,i);
                        tabel_atomi.Add(count, atom_curent);
                        count++;
                        if (atom_i[j].Length > t + 1)
                        {
                            stare = Identificator.idntf(atom_i[j][t + 1]);
                        }
                        atom = "";
                    }
                }
                else
                {
                    Atom atom_curent = new Atom((int)define.MAIMARE, atom, i);
                    tabel_atomi.Add(count, atom_curent);
                    count++;
                    if (atom_i[j].Length > t + 1)
                    {
                        stare = Identificator.idntf(atom_i[j][t + 1]);
                    }
                    atom = "";
                }
            }
            else if (atom_i[j][t] == '<')
            {
                atom += atom_i[j][t];
                if (atom_i[j].Length > t + 1)
                {
                    if (atom_i[j][t + 1] == '=')
                    {
                        atom += atom_i[j][t + 1];
                        Atom atom_curent = new Atom((int)define.MAIMICSAUEGAL, atom,i);
                        tabel_atomi.Add(count, atom_curent);
                        count++;
                        if (atom_i[j].Length > t + 1)
                        {
                            stare = Identificator.idntf(atom_i[j][t + 2]);
                        }
                        atom = "";
                        t++;
                    }
                    else
                    {
                        Atom atom_curent = new Atom((int)define.MAIMIC, atom,i);
                        tabel_atomi.Add(count, atom_curent);
                        count++;
                        if (atom_i[j].Length > t + 1)
                        {
                            stare = Identificator.idntf(atom_i[j][t + 1]);
                        }
                        atom = "";
                    }
                }
                else
                {
                    Atom atom_curent = new Atom((int)define.MAIMIC, atom, i);
                    tabel_atomi.Add(count, atom_curent);
                    count++;
                    if (atom_i[j].Length > t + 1)
                    {
                        stare = Identificator.idntf(atom_i[j][t + 1]);
                    }
                    atom = "";
                }
            }
            else if (atom_i[j][t] == '+')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.PLUS, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '-')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.MINUS, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '/')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.DIVIZARE, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '*')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.MUL, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '[')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.PARDL, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == ']')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.PARDR, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '@')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.AT, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '^')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.POINTER, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == ',')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.VIRGULA, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '$')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.DOLLAR, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '!')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.EXCLAM, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '#')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.DIEZ, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '%')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.PROCENT, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '?')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.INTREBARE, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '\\')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.BACKSLASH, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (atom_i[j][t] == '|')
            {
                atom += atom_i[j][t];
                Atom atom_curent = new Atom((int)define.SAU, atom,i);
                tabel_atomi.Add(count, atom_curent);
                count++;
                if (atom_i[j].Length > t + 1)
                {
                    stare = Identificator.idntf(atom_i[j][t + 1]);
                }
                atom = "";
            }
            else if (((int)atom_i[j][t]) < 32 || ((int)atom_i[j][t]) > 125)
            {
                t++;
            }
            return t;
        }
        /// <summary>
        /// функция поиска следующего атома в списке атомов
        /// </summary>
        /// <returns>возвращенный атом</returns>
        public Atom UrmatorAtom()
        {
            if (position <= count)
            {
                Atom ret = (Atom)tabel_atomi[position];
                position++;
                return ret;
            }
            else
            {
                return null;
            }
        }
    }
}
