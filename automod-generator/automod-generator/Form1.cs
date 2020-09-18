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

        public void compile(string type)
        {
            void addPosCondition()
            {

            }
            void addNegCondition()
            {

            }
            void addAction()
            {

            }

            if(type == "addPosCondition")
            {
                addPosCondition();
            }
            if (type == "addNegCondition")
            {
                addNegCondition();
            }
            if (type == "addAction")
            {
                addAction();
            }
        }

        private void ifButton_Click(object sender, EventArgs e)
        {
            compile("addPosCondition");
        }

        private void ifNotButton_Click(object sender, EventArgs e)
        {
            compile("addNegCondition");
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            compile("addAction");
        }
    }
}
