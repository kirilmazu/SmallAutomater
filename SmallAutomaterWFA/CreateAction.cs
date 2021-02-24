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
    public partial class CreateAction : Form
    {
        private AutomateAction automateAction = new AutomateAction("tempName");
        Timer timer = new Timer();

        public CreateAction()
        {
            InitializeComponent();
            //initial the timer to move the mouse every 1 minute
            timer.Interval = 500;  //0.5 sec intervals
            timer.Tick += new EventHandler(updateLocation);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check if all enabled filds is not empty
            if(txtTextToType.Enabled && txtTextToType.Text == "")
            {
                MessageBox.Show("Required fild is empty", "Format alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtX.Enabled && txtX.Text.Trim() == "")
            {
                MessageBox.Show("Required fild is empty", "Format alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtY.Enabled && txtY.Text.Trim() == "")
            {
                MessageBox.Show("Required fild is empty", "Format alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboxKeyToType.Enabled && cboxKeyToType.Text.Trim() == "")
            {
                MessageBox.Show("Required fild is empty", "Format alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboxMouseButton.Enabled && cboxMouseButton.Text.Trim() == "")
            {
                MessageBox.Show("Required fild is empty", "Format alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //generate the new action
            //get parand
            string paramsString = "";
            if (txtX.Enabled)
            {
                int x;
                int y;
                try
                {
                    x = Convert.ToInt32(txtX.Text);
                    y = Convert.ToInt32(txtY.Text);
                }catch(Exception ex)
                {
                    MessageBox.Show("X and Y filds must be numbers", "Format alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                paramsString = x + ":" + y;
            }
            else if (txtWaitTime.Enabled)
            {
                int time;
                try
                {
                    time = Convert.ToInt32(txtWaitTime.Text);
                }catch(Exception ex)
                {
                    MessageBox.Show("Wait time fild must be numbers", "Format alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paramsString = time + "";
            }
            else if (cboxMouseButton.Enabled)
            {
                paramsString = cboxMouseButton.Text;
            }
            else if (cboxKeyToType.Enabled)
            {
                if (txtTextToType.Enabled) paramsString = txtTextToType.Text;
                else paramsString = "{" + cboxKeyToType.Text + "}";
            }

            SingleAction.names item = (SingleAction.names)Enum.Parse(typeof(SingleAction.names), cboxAction.Text, true);
            SingleAction action = new SingleAction(item, paramsString);

            //add single action to automation action
            automateAction.actions.AddLast(action);

            //refresh flow
            lvFlow.Items.Add(action.toString());

            //reload filds
            initFilds();
        }

        private void updateLocation(object sender, EventArgs e)
        {
            lblCurrentCursoreXY.Text = "Current X:" + Cursor.Position.X.ToString() + " Y:" + Cursor.Position.Y.ToString();
        }

        private void initFilds()
        {
            txtX.Enabled = false;
            txtX.Text = "";
            txtY.Enabled = false;
            txtY.Text = "";
            txtTextToType.Enabled = false;
            txtTextToType.Text = "";
            cboxMouseButton.Enabled = false;
            cboxMouseButton.Text = "";
            cboxKeyToType.Enabled = false;
            cboxKeyToType.Text = "";
            txtWaitTime.Enabled = false;
            txtWaitTime.Text = "";
        }

        private void CreateAction_Load(object sender, EventArgs e)
        {
            //disable default filds
            initFilds();

            //load actions
            foreach(var item in Enum.GetValues(typeof(SingleAction.names)))
            {
                cboxAction.Items.Add(item);
            }

            //load mouse butems
            foreach (var item in Enum.GetValues(typeof(VirtualMouse.mouse_button)))
            {
                cboxMouseButton.Items.Add(item);
            }

            //load keyboard keys
            foreach (var item in Enum.GetValues(typeof(AppData.keyboardKeys)))
            {
                cboxKeyToType.Items.Add(item);
            }
        }

        private void cboxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable relevant boxes based on the action name
            SingleAction.names item = (SingleAction.names)Enum.Parse(typeof(SingleAction.names), cboxAction.Text, true);
            switch (item)
            {
                case SingleAction.names.click:
                    cboxMouseButton.Enabled = true;
                    cboxKeyToType.Enabled = false;
                    txtX.Enabled = false;
                    txtY.Enabled = false;
                    txtWaitTime.Enabled = false;
                    timer.Enabled = false;
                    break;

                case SingleAction.names.moveMouseToXY:
                case SingleAction.names.dragToXY:
                    timer.Enabled = true;
                    txtX.Enabled = true;
                    txtY.Enabled = true;
                    cboxKeyToType.Enabled = false;
                    cboxMouseButton.Enabled = false;
                    txtWaitTime.Enabled = false;
                    break;

                case SingleAction.names.KeyboardInput:
                    cboxKeyToType.Enabled = true;
                    cboxMouseButton.Enabled = false;
                    txtX.Enabled = false;
                    txtY.Enabled = false;
                    txtWaitTime.Enabled = false;
                    timer.Enabled = false;
                    break;

                case SingleAction.names.wait:
                    txtWaitTime.Enabled = true;
                    cboxKeyToType.Enabled = false;
                    cboxMouseButton.Enabled = false;
                    txtX.Enabled = false;
                    txtY.Enabled = false;
                    timer.Enabled = false;
                    break;

            }
        }

        private void cboxKeyToType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxKeyToType.Text == "Text") txtTextToType.Enabled = true;
            else txtTextToType.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check action name (if it empty and if it exists)
            if (txtActionName.Text.Trim() == "")
            {
                MessageBox.Show("The action name is empty.", "Format alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AppData.actions.ContainsKey(txtActionName.Text))
            {
                MessageBox.Show("The action with same name exist please ente other name", "Name alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //save new flow
            automateAction.Name = txtActionName.Text;
            //AppData.actions.Add(automateAction.Name, automateAction);
            AppData.AddAction(automateAction);
            this.Close();
        }
    }
}


// sendkeys
// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?redirectedfrom=MSDN&view=net-5.0#System_Windows_Forms_SendKeys_Send_System_String_
