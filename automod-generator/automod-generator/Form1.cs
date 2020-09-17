using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automod_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listType.Items.Add("any");
            listType.Items.Add("submission");
            listType.Items.Add("comment");

            checkList.Items.Add("body");
            checkList.Items.Add("title");
            checkList.Items.Add("domain");
            checkList.Items.Add("url");
            checkList.Items.Add("flair_text");

            actionList.Items.Add("remove");
            actionList.Items.Add("approve");
            actionList.Items.Add("spam");
            actionList.Items.Add("filter");
            actionList.Items.Add("report");

            moreactionList.Items.Add("set_sticky");
            moreactionList.Items.Add("set_nsfw");
            moreactionList.Items.Add("set_spoiler");
            moreactionList.Items.Add("set_locked");

            standardList.Items.Add("image hosting sites");
            standardList.Items.Add("direct image links");
            standardList.Items.Add("video hosting sites");
            standardList.Items.Add("streaming sites");
            standardList.Items.Add("crowdfunding sites");
            standardList.Items.Add("meme generator sites");
            standardList.Items.Add("facebook links");
            standardList.Items.Add("amazon affiliate links");

            userisList.Items.Add("is_gold");
            userisList.Items.Add("is_submitter");
            userisList.Items.Add("is_contributor");
            userisList.Items.Add("is_moderator");

            addList.Items.Add("moderators_exempt");

            listType.CheckOnClick = true;
            checkList.CheckOnClick = true;
        }

        public void compile()
        {
            string d = "";
            if (listType.SelectedItem == "submission")
            {
                
                foreach(string ad in checkList.CheckedItems)
                {
                    if (checkList.CheckedItems.Count > 1)
                    {
                        if(d != "")
                        {
                            d = d + "+" + ad;
                        }
                        else
                        {
                            d = d + ad;
                        }
                    }
                    else
                    {
                        d = ad;
                    }
                    
                    
                }
                
                if (checkRegex.Checked == true)
                {
                    if(checkCase.Checked == true)
                    {
                        d = d + "(regex, case-sensitive)";
                    }
                    else
                    {
                        d = d + "(regex)";
                    }
                }
                else
                {
                    if (checkCase.Checked == true)
                    {
                        d = d + "(case-sensitive)";
                    }
                }

                d = d + ":";
                d = d + " " + boxFind.Text;
                d = d + "\n";
                if (addList.SelectedItem == "moderators_exempt")
                {
                    d = d + "moderators_exempt: true";
                }
                d = d + "\n";
                foreach (string ad in actionList.CheckedItems)
                {
                    d = d + "action: " + ad +"\n";
                    if (checkReason.Checked == true)
                    {
                        d = d + "action_reason: " + boxReason.Text + "\n";
                    }
                }
                foreach (string ad in moreactionList.CheckedItems)
                {
                    d = d + ad +": true" + "\n";
                }



                output.Text = d;
            }
        }





        private void listType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < listType.Items.Count; ++ix)
                if (ix != e.Index) listType.SetItemChecked(ix, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compile();
        }
    }
}
