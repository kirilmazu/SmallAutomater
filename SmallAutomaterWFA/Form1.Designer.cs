
namespace SmallAutomaterWFA
{
    partial class Form1
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
            this.cboxActionSelect = new System.Windows.Forms.ComboBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lvAutomateActions = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cboxActionSelect
            // 
            this.cboxActionSelect.FormattingEnabled = true;
            this.cboxActionSelect.Location = new System.Drawing.Point(13, 13);
            this.cboxActionSelect.Name = "cboxActionSelect";
            this.cboxActionSelect.Size = new System.Drawing.Size(357, 24);
            this.cboxActionSelect.TabIndex = 0;
            this.cboxActionSelect.SelectedIndexChanged += new System.EventHandler(this.cboxActionSelect_SelectedIndexChanged);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(377, 13);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lvAutomateActions
            // 
            this.lvAutomateActions.HideSelection = false;
            this.lvAutomateActions.Location = new System.Drawing.Point(13, 53);
            this.lvAutomateActions.Name = "lvAutomateActions";
            this.lvAutomateActions.Size = new System.Drawing.Size(357, 385);
            this.lvAutomateActions.TabIndex = 2;
            this.lvAutomateActions.UseCompatibleStateImageBehavior = false;
            this.lvAutomateActions.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.lvAutomateActions);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.cboxActionSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxActionSelect;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.ListView lvAutomateActions;
    }
}

