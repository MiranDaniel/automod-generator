using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace automod_generator
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listType.Items.Add("any");
            listType.Items.Add("submission");
            listType.Items.Add("comment");
            listType.Items.Add("text submission");
            listType.Items.Add("link submission");
            listType.Items.Add("crosspost submission");
            listType.Items.Add("poll submission");
            listType.Items.Add("gallery submission");

            checkList.Items.Add("body");
            checkList.Items.Add("title");
            checkList.Items.Add("domain");
            checkList.Items.Add("url");
            checkList.Items.Add("flair_text");
            checkList.Items.Add("flair_css_class");
            checkList.Items.Add("flair_template_id");
            checkList.Items.Add("crosspost_title");

            actionList.Items.Add("remove");
            actionList.Items.Add("approve");
            actionList.Items.Add("spam");
            actionList.Items.Add("filter");
            actionList.Items.Add("report");

            moreactionList.Items.Add("set_sticky");
            moreactionList.Items.Add("set_nsfw");
            moreactionList.Items.Add("set_spoiler");
            moreactionList.Items.Add("set_locked");
            moreactionList.Items.Add("set_contest_mode");
            moreactionList.Items.Add("set_original_content");

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

            priorityList.Items.Add("priority");

            regexmodifierList.Items.Add("regex");
            regexmodifierList.Items.Add("includes-word");
            regexmodifierList.Items.Add("includes");
            regexmodifierList.Items.Add("starts-with");
            regexmodifierList.Items.Add("ends-with");
            regexmodifierList.Items.Add("full-exact");
            regexmodifierList.Items.Add("full-text");
            regexmodifierList.Items.Add("case-sensitive");

            modmailList.Items.Add("modmail");
            modmailTitleList.Items.Add("modmail_subject");

            karmaageList.Items.Add("comment_karma");
            karmaageList.Items.Add("post_karma");
            karmaageList.Items.Add("combined_karma");
            karmaageList.Items.Add("account_age");

            typeBox.Items.Add("minutes");
            typeBox.Items.Add("hours");
            typeBox.Items.Add("days");
            typeBox.Items.Add("weeks");
            typeBox.Items.Add("months");
            typeBox.Items.Add("years");

            otherList.Items.Add("reports");
            otherList.Items.Add("body_longer_than");
            otherList.Items.Add("body_shorter_than");

            settings.Items.Add("Clear selection after adding.");
            settings.Items.Add("Auto-Compile");
            settings.SetItemCheckState(1, CheckState.Checked);
            settings.SetItemCheckState(0, CheckState.Checked);
            settings.Items.Add("Linux mode");

            addList.Items.Add("moderators_exempt");

            listType.CheckOnClick = true;
            checkList.CheckOnClick = true;
            this.ShowIcon = true;

            



        }
        public class vars
        {
            public static bool debug = false;
            public static string type = "";
            public static string prefix = "";
            public static bool aboutOpen = false;
            public static List<string> conditionData = new List<string>();
            public static List<string> actionData = new List<string>();
            public static List<string> modifierData = new List<string>();
            public static List<string> typeData = new List<string>();
            public static string outputT = "";
            public static string outputO = "";
            public static string outputM = "";
            public static string outputA = "";
        }

        public void compile()
        {

            string types = "";
            foreach (string te in listType.CheckedItems)
            {
                if (types == "")
                {
                    types = te;
                }
                else
                {
                    types = types + "+" + te;
                }
            }
            if (types != "")
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

                foreach (string mod in regexmodifierList.CheckedItems)
                {
                    if (addModifiers == "")
                    {
                        addModifiers = addModifiers + mod;
                    }
                    else
                    {
                        addModifiers = addModifiers + "," + mod;
                    }
                }
                if (addModifiers != "")
                {
                    addData = addData + "(";
                    addModifiers = addModifiers + ")";
                }
                addData = addData + addModifiers;

                if (checkList.CheckedItems.Count > 0)
                {
                    addData = addData + ":";
                }
                if (addData != "")
                {
                    addData = addData + " " + boxFind.Text;
                }
                if (addData != "")
                {
                    debugger.Text = addData;
                    vars.conditionData.Add(vars.prefix + addData);
                }
                foreach (string standard in standardList.CheckedItems)
                {
                    if (standardData == "")
                    {
                        standardData = standard;
                    }
                }
                if (standardList.CheckedItems.Count > 0)
                {
                    vars.conditionData.Add("standard: " + standardData);
                }
                foreach (string useris in userisList.CheckedItems)
                {
                    if (userisData == "")
                    {
                        vars.conditionData.Add("author:");
                    }
                    userisData = useris;
                    if (vars.prefix == "")
                    {
                        vars.conditionData.Add("    " + useris + ": false");
                    }
                    else
                    {
                        vars.conditionData.Add("    " + useris + ": true");
                    }

                }
                foreach (string data in karmaageList.CheckedItems)
                {
                    string typeofData = "";
                    if (userisData == "")
                    {
                        vars.conditionData.Add("author:");
                    }
                    userisData = data;
                    if (data == "comment_karma")
                    {
                        typeofData = commentKarmaBox.Text;
                    }
                    if (data == "post_karma")
                    {
                        typeofData = postKarmaBox.Text;
                    }
                    if (data == "combined_karma")
                    {
                        typeofData = combinedKarmaBox.Text;
                    }
                    if (data == "account_age")
                    {
                        if (typeBox.SelectedItem.ToString() == "")
                        {
                            typeofData = accountageBox.Text + " days";
                        }
                        else
                        {
                            typeofData = accountageBox.Text + " " + typeBox.SelectedItem;
                        }

                    }
                    if (vars.prefix == "")
                    {
                        vars.conditionData.Add("    " + data + ": < " + typeofData);
                    }
                    else
                    {
                        vars.conditionData.Add("    " + data + ": > \'" + typeofData + "\'");
                    }
                }
                foreach (string other in otherList.CheckedItems)
                {
                    string typeofData = "";
                    if (other == "reports")
                    {
                        typeofData = reportsBox.Text;
                    }
                    if (other == "body_longer_than")
                    {
                        typeofData = longerBox.Text;
                    }
                    if (other == "body_shorter_than")
                    {
                        typeofData = shorterBox.Text;
                    }
                    vars.conditionData.Add(other + ": " + typeofData);
                }
            }
            void addNegCondition()
            {
                addPosCondition();
            }
            void addAction()
            {
                string actionData = "";
                foreach (string action in actionList.CheckedItems)
                {
                    actionData = "action: " + action;
                    vars.actionData.Add(actionData);
                    if (checkReason.Checked)
                    {
                        if (action != "report")
                        {
                            vars.actionData.Add("action_reason: " + boxReason.Text);
                        }
                        else
                        {
                            vars.actionData.Add("report_reason: " + boxReason.Text);
                        }
                    }
                }
                foreach (string action in moreactionList.CheckedItems)
                {
                    vars.actionData.Add(action + ": true");
                }
                foreach (string modmail0 in modmailList.CheckedItems)
                {

                    foreach (string modmail1 in modmailTitleList.CheckedItems)
                    {
                        vars.actionData.Add("modmail_subject: " + modtitleBox.Text);
                    }
                    vars.actionData.Add("modmail: " + modBox.Text);
                }

            }
            void addModifier()
            {
                foreach (string modifier in addList.CheckedItems)
                {
                    if (modifier == "moderators_exempt")
                    {
                        vars.modifierData.Add(modifier + ": false");
                    }
                }
                foreach (string check in priorityList.CheckedItems)
                {
                    vars.modifierData.Add(check + ": " + priorityValueBox.Text);
                }
            }
            if (vars.type == "addPosCondition")
            {
                vars.prefix = "";
                addPosCondition();
            }
            if (vars.type == "addNegCondition")
            {
                vars.prefix = "~";
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
            bool ac = false;
            foreach(string item in settings.CheckedItems)
            {
                if(item == "Auto-Compile")
                {
                    ac = true;
                }
            }
            vars.outputT = string.Join("\n", vars.typeData);
            vars.outputO = string.Join("\n", vars.conditionData);
            vars.outputM = string.Join("\n", vars.modifierData);
            vars.outputA = string.Join("\n", vars.actionData);
            if (ac == true)
            {
                
                output.Text = output.Text + vars.outputT;
                
                output.Text = output.Text + "\n" + vars.outputO;
                
                output.Text = output.Text + "\n" + vars.outputM;
                
                output.Text = output.Text + "\n" + vars.outputA;
                resetMemory();
            }
            

            foreach (string item in settings.CheckedItems)
            {
                if (item == "Clear selection after adding.")
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
            addList.ClearSelected();
            addList.UncheckAllItems();
            priorityList.ClearSelected();
            priorityList.UncheckAllItems();
            priorityList.ClearSelected();
            priorityList.UncheckAllItems();
            otherList.ClearSelected();
            otherList.UncheckAllItems();
            karmaageList.ClearSelected();
            karmaageList.UncheckAllItems();
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

        public void debug(string data)
        {
            if (debugger.Text == "")
            {
                debugger.Text = data;
            }
            else
            {
                debugger.Text = debugger.Text + "\n" + data;
            }
        }

        private void contactButton_Click(object sender, EventArgs e)
        {

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

        private void debugButton_Click(object sender, EventArgs e)
        {
            if (vars.debug == false)
            {
                vars.debug = true;
                debug("enabled debug");

                label6.Visible = true;
                debugger.Visible = true;
                resetButton.Visible = true;
            }
            else
            {
                vars.debug = false;
                debug("disabled debug");

                label6.Visible = false;
                debugger.Visible = false;
                resetButton.Visible = false;
            }

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            

            var about = new AboutBox();
            about.Show();
            
            
            
        }

        private void settings_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool liA = false;
            bool acA = true;
            foreach(string item in settings.CheckedItems)
            {
                if(item == "Linux mode")
                {
                    liA = true;
                }
                if(item == "Auto-Compile")
                {
                    acA = false;
                }
            }
            this.MaximizeBox = liA;
            if(liA == true)
            {
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            }
            
            compilerButton.Visible = acA;
        }


        private void checkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = false;
            foreach(string item in checkList.CheckedItems)
            {
                enable = true;
            }
            regexmodifierList.Enabled = enable;
            boxFind.Enabled = enable;
        }

        private void karmaageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool comment_karmaE = false;
            bool post_karmaE = false;
            bool combined_karmaE = false;
            bool account_ageE = false;
            foreach (string item in karmaageList.CheckedItems)
            {
                if(item == "comment_karma")
                {
                    comment_karmaE = true;
                }
                if(item == "post_karma")
                {
                    post_karmaE = true;
                }
                if(item == "combined_karma")
                {
                    combined_karmaE = true;
                }
                if(item == "account_age")
                {
                    account_ageE = true;
                }
            }
            commentKarmaBox.Enabled = comment_karmaE;
            postKarmaBox.Enabled = post_karmaE;
            combinedKarmaBox.Enabled = combined_karmaE;
            accountageBox.Enabled = account_ageE;
            typeBox.Enabled = account_ageE;
        }

        private void otherList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool reportsE = false;
            bool bodylE = false;
            bool bodysE = false;
            foreach(string item in otherList.CheckedItems)
            {
                if(item == "reports")
                {
                    reportsE = true;
                }
                if(item == "body_longer_than")
                {
                    bodylE = true;
                }
                if(item == "body_shorter_than")
                {
                    bodysE = true;
                }
                reportsBox.Enabled = reportsE;
                longerBox.Enabled = bodylE;
                shorterBox.Enabled = bodysE;
            }
        }

        private void priorityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool pE = false;
            foreach(string item in priorityList.CheckedItems)
            {
                if(item == "priority")
                {
                    pE = true;
                }
            }
            priorityValueBox.Enabled = pE;
        }

        private void compilerButton_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + vars.outputT;

            output.Text = output.Text + "\n" + vars.outputO;

            output.Text = output.Text + "\n" + vars.outputM;

            output.Text = output.Text + "\n" + vars.outputA;
        }
    }
}
public static class AppExtensions
{
    public static void UncheckAllItems(this System.Windows.Forms.CheckedListBox clb)
    {
        while (clb.CheckedIndices.Count > 0)
        {
            clb.SetItemChecked(clb.CheckedIndices[0], false);
        }
    }
}
