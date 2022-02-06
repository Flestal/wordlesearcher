using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordlesearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_NoUse_Click(object sender, EventArgs e)
        {
            lb_NoUse.Items.Add(tb_letter1.Text.Trim());
            tb_letter1.Text = "";
        }

        private void btn_Molu_Click(object sender, EventArgs e)
        {
            lb_letterMolu.Items.Add(tb_letter1.Text.Trim());
            tb_letter1.Text = "";
        }

        private void btn_bf_Click(object sender, EventArgs e)
        {
            //아는거 위치 지정
            string aru = "-----";
            StringBuilder sb = new StringBuilder(aru);
            if (tb_letter_order_1.Text != "")
            {
                //aru[0]=tb_letter_order_1.Text;
                sb.Replace('-',Convert.ToChar(tb_letter_order_1.Text),0,1);
            }
            if (tb_letter_order_2.Text != "")
            {
                //aru[1] = tb_letter_order_2.Text;
                sb.Replace('-', Convert.ToChar(tb_letter_order_2.Text), 1, 1);
            }
            if (tb_letter_order_3.Text != "")
            {
                //aru[2] = tb_letter_order_3.Text;
                sb.Replace('-', Convert.ToChar(tb_letter_order_3.Text), 2, 1);
            }
            if (tb_letter_order_4.Text != "")
            {
                //aru[3] = tb_letter_order_4.Text;
                sb.Replace('-', Convert.ToChar(tb_letter_order_4.Text), 3, 1);
            }
            if (tb_letter_order_5.Text != "")
            {
                //aru[4] = tb_letter_order_5.Text;
                sb.Replace('-', Convert.ToChar(tb_letter_order_5.Text), 4, 1);
            }
            aru= sb.ToString();
            List<char> letterlist=new List<char>();
            List<char> moluList=new List<char>();
            for(int i = 'a'; i <= 'z'; i++)
            {
                letterlist.Add(Convert.ToChar(i));
            }
            foreach (string s in lb_NoUse.Items)
            {
                char c = Convert.ToChar(s);
                if (letterlist.Contains(c))
                {
                    letterlist.RemoveAt(letterlist.IndexOf(c));
                }
            }
            foreach (string s in lb_letterMolu.Items)
            {
                char c = Convert.ToChar(s);
                moluList.Add(c);
            }
            /*for (int i = 0; i < aru.Length; i++)
            {
                if (aru[i] != "none")
                {
                    char c = Convert.ToChar(aru[i]);
                    if (letterlist.Contains(c))
                    {
                        letterlist.RemoveAt(letterlist.IndexOf(c));
                    }
                }
            }*/
            List<string> words=new List<string>();
            string word1, word2, word3, word4, word5;
            bool flag;
            foreach(char c1 in letterlist)
            {
                word1 = "";
                word1 += c1;
                foreach(char c2 in letterlist)
                {
                    word2 = word1+c2;
                    foreach (char c3 in letterlist)
                    {
                        word3 = word2 + c3;
                        foreach (char c4 in letterlist)
                        {
                            word4 = word3 + c4;
                            foreach (char c5 in letterlist)
                            {
                                word5 = word4 + c5;
                                flag = true;
                                for (int i = 0; i < aru.Length; i++)
                                {
                                    if (aru[i] != '-')//아!루 가 있는 상황에서는
                                    {
                                        char c = Convert.ToChar(aru[i]);
                                        if (word5[i]!=c)//아!루 위치별로 체크해서
                                        {
                                            flag = false;//아!루 위치 글자가 같은게 아니면 안넘김
                                        }
                                    }
                                }
                                foreach (char c in moluList)//몰?루 리스트의 모든 글자가 포함이 되어 있는지 체크
                                {
                                    if (!word5.Contains(c))
                                    {
                                        flag = false;//하나라도 없으면 안넘김
                                    }
                                }
                                if (flag)
                                {
                                    words.Add(word5);
                                }
                            }
                        }
                    }
                }
            }
            lb_bf.Items.Clear();
            foreach(string word in words)
            {
                lb_bf.Items.Add(word);
            }
        }

        private void btn_clearNouse_Click(object sender, EventArgs e)
        {
            lb_NoUse.Items.Clear();
        }

        private void btn_clearMolu_Click(object sender, EventArgs e)
        {
            lb_letterMolu.Items.Clear();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            NetSpell.SpellChecker.Dictionary.WordDictionary oDict = new NetSpell.SpellChecker.Dictionary.WordDictionary();
            oDict.DictionaryFile = "en-US.dic";
            oDict.Initialize();
            NetSpell.SpellChecker.Spelling oSpell = new NetSpell.SpellChecker.Spelling();
            oSpell.Dictionary = oDict;
            lb_filter.Items.Clear();
            foreach(string s in lb_bf.Items)
            {
                if (oSpell.TestWord(s))
                {
                    lb_filter.Items.Add(s);
                }
            }
        }
    }
}
