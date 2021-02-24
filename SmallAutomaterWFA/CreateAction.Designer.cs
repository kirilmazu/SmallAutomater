
namespace SmallAutomaterWFA
{
    partial class CreateAction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvFlow = new System.Windows.Forms.ListView();
            this.lblFlow = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtActionName = new System.Windows.Forms.TextBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.cboxAction = new System.Windows.Forms.ComboBox();
            this.lblCurrentCursoreXY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblMouseBotton = new System.Windows.Forms.Label();
            this.cboxMouseButton = new System.Windows.Forms.ComboBox();
            this.lblKeyToType = new System.Windows.Forms.Label();
            this.txtTextToType = new System.Windows.Forms.TextBox();
            this.cboxKeyToType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWaitTime = new System.Windows.Forms.Label();
            this.txtWaitTime = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvFlow
            // 
            this.lvFlow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvFlow.HideSelection = false;
            this.lvFlow.Location = new System.Drawing.Point(12, 34);
            this.lvFlow.Name = "lvFlow";
            this.lvFlow.Size = new System.Drawing.Size(330, 404);
            this.lvFlow.TabIndex = 0;
            this.lvFlow.UseCompatibleStateImageBehavior = false;
            this.lvFlow.View = System.Windows.Forms.View.List;
            // 
            // lblFlow
            // 
            this.lblFlow.AutoSize = true;
            this.lblFlow.Location = new System.Drawing.Point(13, 11);
            this.lblFlow.Name = "lblFlow";
            this.lblFlow.Size = new System.Drawing.Size(36, 17);
            this.lblFlow.TabIndex = 1;
            this.lblFlow.Text = "Flow";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(366, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Action name:";
            // 
            // txtActionName
            // 
            this.txtActionName.Location = new System.Drawing.Point(462, 13);
            this.txtActionName.Name = "txtActionName";
            this.txtActionName.Size = new System.Drawing.Size(186, 22);
            this.txtActionName.TabIndex = 3;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(366, 54);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(51, 17);
            this.lblAction.TabIndex = 4;
            this.lblAction.Text = "Action:";
            // 
            // cboxAction
            // 
            this.cboxAction.FormattingEnabled = true;
            this.cboxAction.Location = new System.Drawing.Point(462, 51);
            this.cboxAction.Name = "cboxAction";
            this.cboxAction.Size = new System.Drawing.Size(121, 24);
            this.cboxAction.TabIndex = 5;
            this.cboxAction.SelectedIndexChanged += new System.EventHandler(this.cboxAction_SelectedIndexChanged);
            // 
            // lblCurrentCursoreXY
            // 
            this.lblCurrentCursoreXY.AutoSize = true;
            this.lblCurrentCursoreXY.Location = new System.Drawing.Point(366, 90);
            this.lblCurrentCursoreXY.Name = "lblCurrentCursoreXY";
            this.lblCurrentCursoreXY.Size = new System.Drawing.Size(102, 17);
            this.lblCurrentCursoreXY.TabIndex = 6;
            this.lblCurrentCursoreXY.Text = "Current X:x Y:y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(366, 125);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 17);
            this.lblX.TabIndex = 7;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(468, 125);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 17);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(393, 122);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(59, 22);
            this.txtX.TabIndex = 9;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(495, 122);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(59, 22);
            this.txtY.TabIndex = 10;
            // 
            // lblMouseBotton
            // 
            this.lblMouseBotton.AutoSize = true;
            this.lblMouseBotton.Location = new System.Drawing.Point(366, 155);
            this.lblMouseBotton.Name = "lblMouseBotton";
            this.lblMouseBotton.Size = new System.Drawing.Size(98, 17);
            this.lblMouseBotton.TabIndex = 11;
            this.lblMouseBotton.Text = "Mouse botton:";
            // 
            // cboxMouseButton
            // 
            this.cboxMouseButton.FormattingEnabled = true;
            this.cboxMouseButton.Location = new System.Drawing.Point(495, 152);
            this.cboxMouseButton.Name = "cboxMouseButton";
            this.cboxMouseButton.Size = new System.Drawing.Size(121, 24);
            this.cboxMouseButton.TabIndex = 12;
            // 
            // lblKeyToType
            // 
            this.lblKeyToType.AutoSize = true;
            this.lblKeyToType.Location = new System.Drawing.Point(369, 232);
            this.lblKeyToType.Name = "lblKeyToType";
            this.lblKeyToType.Size = new System.Drawing.Size(83, 17);
            this.lblKeyToType.TabIndex = 13;
            this.lblKeyToType.Text = "Key to type:";
            // 
            // txtTextToType
            // 
            this.txtTextToType.Location = new System.Drawing.Point(372, 259);
            this.txtTextToType.Multiline = true;
            this.txtTextToType.Name = "txtTextToType";
            this.txtTextToType.Size = new System.Drawing.Size(276, 179);
            this.txtTextToType.TabIndex = 14;
            // 
            // cboxKeyToType
            // 
            this.cboxKeyToType.FormattingEnabled = true;
            this.cboxKeyToType.Location = new System.Drawing.Point(462, 229);
            this.cboxKeyToType.Name = "cboxKeyToType";
            this.cboxKeyToType.Size = new System.Drawing.Size(121, 24);
            this.cboxKeyToType.TabIndex = 15;
            this.cboxKeyToType.SelectedIndexChanged += new System.EventHandler(this.cboxKeyToType_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(674, 414);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save flow as action";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWaitTime
            // 
            this.lblWaitTime.AutoSize = true;
            this.lblWaitTime.Location = new System.Drawing.Point(366, 188);
            this.lblWaitTime.Name = "lblWaitTime";
            this.lblWaitTime.Size = new System.Drawing.Size(135, 17);
            this.lblWaitTime.TabIndex = 18;
            this.lblWaitTime.Text = "Wait time(1000=1s):";
            // 
            // txtWaitTime
            // 
            this.txtWaitTime.Location = new System.Drawing.Point(495, 185);
            this.txtWaitTime.Name = "txtWaitTime";
            this.txtWaitTime.Size = new System.Drawing.Size(100, 22);
            this.txtWaitTime.TabIndex = 19;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 500;
            // 
            // CreateAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWaitTime);
            this.Controls.Add(this.lblWaitTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboxKeyToType);
            this.Controls.Add(this.txtTextToType);
            this.Controls.Add(this.lblKeyToType);
            this.Controls.Add(this.cboxMouseButton);
            this.Controls.Add(this.lblMouseBotton);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblCurrentCursoreXY);
            this.Controls.Add(this.cboxAction);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.txtActionName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFlow);
            this.Controls.Add(this.lvFlow);
            this.Name = "CreateAction";
            this.Text = "CreateAction";
            this.Load += new System.EventHandler(this.CreateAction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFlow;
        private System.Windows.Forms.Label lblFlow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtActionName;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ComboBox cboxAction;
        private System.Windows.Forms.Label lblCurrentCursoreXY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblMouseBotton;
        private System.Windows.Forms.ComboBox cboxMouseButton;
        private System.Windows.Forms.Label lblKeyToType;
        private System.Windows.Forms.TextBox txtTextToType;
        private System.Windows.Forms.ComboBox cboxKeyToType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWaitTime;
        private System.Windows.Forms.TextBox txtWaitTime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}