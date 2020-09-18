using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

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

            settings.Items.Add("Clear selection after adding.");
            settings.SetItemCheckState(0, CheckState.Checked);

            addList.Items.Add("moderators_exempt");

            listType.CheckOnClick = true;
            checkList.CheckOnClick = true;

            


        }
        public class vars
        {
            public static string type = "";
            public static string prefix = "";
            public static List<string> conditionData = new List<string>();
            public static List<string> actionData = new List<string>();
            public static List<string> modifierData = new List<string>();
            public static List<string> typeData = new List<string>();
        }

        public void compile()
        {

            string types = "";
            foreach(string te in listType.CheckedItems)
            {
                if(types == "")
                {
                    types = te;
                }
                else
                {
                    types = types + "+" + te;
                }
            }
            if(types != "")
            {
                vars.typeData.Add("type: " + types);
            }
            void addPosCondition()
            {
                string addData = "";
                string addModifiers = "";
                string standardData = "";
                string userisData = "";
                foreach (string item in checkList.CheckedItems)
                {
                    if (addData == "")
                    {
                        addData = item;
                    }
                    else
                    {
                        addData = addData + "+" + item;
                    }
                }
                
                if (checkRegex.Checked || checkCase.Checked) 
                {   
                    addModifiers = "(";
                    if (checkRegex.Checked && checkCase.Checked)
                    {
                        addModifiers = addModifiers + "regex, case-sensitive";
                    }
                    else
                    {
                        if (checkRegex.Checked)
                        {
                            addModifiers = addModifiers + "regex";
                        }
                        if (checkCase.Checked)
                        {
                            addModifiers = addModifiers + "case-sensitive";
                        }
                    }
                    addModifiers = addModifiers + ")";
                }
                addData = addData + addModifiers;
                
                if (checkList.CheckedItems.Count > 0)
                {
                    addData = addData + ":";
                }
                addData = addData +" " + boxFind.Text;
                if(addData != "")
                {
                    vars.conditionData.Add(vars.prefix + addData);
                }
                foreach (string standard in standardList.CheckedItems)
                {
                    if(standardData == "")
                    {
                        standardData = standard;
                    }
                }
                if(standardList.CheckedItems.Count > 0)
                {
                    vars.conditionData.Add("standard: " + standardData);
                }
                foreach(string useris in userisList.CheckedItems)
                {
                    if(userisData == "")
                    {
                        vars.conditionData.Add("author:");
                    }
                    userisData = useris;
                    if(vars.prefix == "")
                    {
                        vars.conditionData.Add("    " + useris + ": false");
                    }
                    else
                    {
                        vars.conditionData.Add("    " + useris + ": true");
                    }
                    
                }               
            }
            void addNegCondition()
            {
                vars.prefix = "~";
                addPosCondition();
            }
            void addAction()
            {
                string actionData = "";
                foreach(string action in actionList.CheckedItems)
                {
                    actionData = "action: " + action;
                    vars.actionData.Add(actionData);
                    if (checkReason.Checked)
                    {
                        if(action != "report")
                        {
                            vars.actionData.Add("action_reason: " + boxReason.Text);
                        }
                        else
                        {
                            vars.actionData.Add("report_reason: " + boxReason.Text);
                        }
                    }
                }
                foreach(string action in moreactionList.CheckedItems)
                {
                    vars.actionData.Add(action+": true");
                }
            }
            void addModifier()
            {
                foreach(string modifier in addList.CheckedItems)
                {
                    if(modifier == "moderators_exempt")
                    {
                        vars.modifierData.Add(modifier + ": false");
                    }
                }
            }
            if (vars.type == "addPosCondition")
            {
                addPosCondition();
            }
            if (vars.type == "addNegCondition")
            {
                addNegCondition();
            }
            if (vars.type == "addAction")
            {
                addAction();
            }
            if (vars.type == "addModifier")
            {
                addModifier();
            }
            string t = string.Join("\n", vars.typeData);
            output.Text = output.Text + t;
            string o = string.Join("\n", vars.conditionData);
            output.Text = output.Text + "\n" + o;
            string m = string.Join("\n", vars.modifierData);
            output.Text = output.Text + "\n" + m;
            string a = string.Join("\n", vars.actionData);
            output.Text = output.Text +"\n"+ a;
            resetMemory();
            foreach(string item in settings.CheckedItems)
            {
                if(item == "Clear selection after adding.")
                {
                    clearSelection();
                }
            }

        }

        public void clearSelection()
        {
            checkList.ClearSelected();
            checkList.UncheckAllItems();
            listType.ClearSelected();
            listType.UncheckAllItems();
            actionList.ClearSelected();
            actionList.UncheckAllItems();
            moreactionList.ClearSelected();
            moreactionList.UncheckAllItems();
            standardList.ClearSelected();
            standardList.UncheckAllItems();
            userisList.ClearSelected();
            userisList.UncheckAllItems();
        }

        private void ifButton_Click(object sender, EventArgs e)
        {
            vars.type = "addPosCondition";
            compile();
            
        }

        private void ifNotButton_Click(object sender, EventArgs e)
        {
            vars.type = "addNegCondition";
            compile();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            vars.type = "addAction";
            compile();
        }
        private void modifierButton_Click(object sender, EventArgs e)
        {
            vars.type = "addModifier";
            compile();
        }
        private void resetMemory()
        {
            vars.conditionData.Clear();
            vars.actionData.Clear();
            vars.modifierData.Clear();
            vars.typeData.Clear();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            resetMemory();
        }



        private void contactButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/message/compose?to=/r/mirandaniel");
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MiranDaniel/automod-generator/issues/new");

        }

        private void repoButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MiranDaniel/automod-generator");

        }

        private void clroutButton_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

        private void clrselButton_Click(object sender, EventArgs e)
        {
            clearSelection();
        }



    }
}
public static class AppExtensions
{
    public static void UncheckAllItems(this System.Windows.Forms.CheckedListBox clb)
    {
        while (clb.CheckedIndices.Count > 0)
            clb.SetItemChecked(clb.CheckedIndices[0], false);
    }
}
