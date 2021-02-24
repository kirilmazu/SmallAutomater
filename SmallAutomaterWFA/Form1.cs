using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallAutomaterWFA
{
    public partial class Form1 : Form
    {
        //Dictionary<string, AutomateAction> actions = new Dictionary<string, AutomateAction>();

        

        public Form1()
        {
            InitializeComponent();
            AppData.ActionAdded += new Action(refreshActionSelect);
        }

        private void refreshActionSelect()
        {
            //if (cboxActionSelect.Text == "Create new action" || cboxActionSelect.Text == "") return;
            if (AppData.actions.ContainsKey(cboxActionSelect.Text) && AppData.actions[cboxActionSelect.Text].actions != null && AppData.actions[cboxActionSelect.Text].actions.Count < 1) return;
            cboxActionSelect.Items.Clear();
            if (AppData.actions != null && AppData.actions.Count > 0)
            {
                foreach (string actionName in AppData.actions.Keys)
                {
                    //cboxActionSelect.Items.Add(actionName + " (" + AppData.actions[actionName].actions.Count + " actions)");
                    cboxActionSelect.Items.Add(actionName);
                }
                cboxActionSelect.Items.Add("Create new action");
            }
        }

        private void cboxActionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvAutomateActions.Items.Clear();
            if (cboxActionSelect.Text == "") return;
            
            if (cboxActionSelect.Text == "Create new action")
            {
                btnStartStop.Text = "Add";
                //this.Enabled = false;
                // open create new action form
                (new CreateAction()).Show();

                //this.Enabled = true;
                // get new action

                // select the new action
                
                btnStartStop.Text = "Start";
                refreshActionSelect();
            }
            else if (AppData.actions[cboxActionSelect.Text].actions != null && AppData.actions[cboxActionSelect.Text].actions.Count > 0)
                foreach (SingleAction action in AppData.actions[cboxActionSelect.Text].actions)
                {
                    lvAutomateActions.Items.Add(action.toString());
                }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            foreach (SingleAction action in AppData.actions[cboxActionSelect.Text].actions)
            {
                try
                {
                    action.doAction();
                }catch(Exception ex)
                {
                    if(MessageBox.Show("The action failed, stop the proccess?", "Action failed", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        return;
                    }
                }
            }
        }

        void test()
        {
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("D");
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("DA");
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("Ddgsfg sa gas gr grdfb ds");
        }

        private void test1()
        {
            System.Threading.Thread.Sleep(1000);
            VirtualMouse.Move(10, 20);
            System.Threading.Thread.Sleep(100);
            VirtualMouse.RightClick();
            System.Threading.Thread.Sleep(100);
            VirtualMouse.Move(20, 0);
            VirtualMouse.LeftClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboxActionSelect.Items.Add("Create new action");
        }
    }
}
