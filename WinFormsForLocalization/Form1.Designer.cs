
namespace WinFormsForLocalization
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.checkBoxIsEnabled = new System.Windows.Forms.CheckBox();
            this.groupBoxProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(288, 365);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(109, 47);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Controls.Add(this.checkBoxIsEnabled);
            this.groupBoxProperties.Location = new System.Drawing.Point(436, 28);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Size = new System.Drawing.Size(305, 209);
            this.groupBoxProperties.TabIndex = 1;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Properties";
            // 
            // checkBoxIsEnabled
            // 
            this.checkBoxIsEnabled.AutoSize = true;
            this.checkBoxIsEnabled.Location = new System.Drawing.Point(20, 44);
            this.checkBoxIsEnabled.Name = "checkBoxIsEnabled";
            this.checkBoxIsEnabled.Size = new System.Drawing.Size(99, 24);
            this.checkBoxIsEnabled.TabIndex = 0;
            this.checkBoxIsEnabled.Text = "Is Enabled";
            this.checkBoxIsEnabled.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxProperties);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxProperties.ResumeLayout(false);
            this.groupBoxProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.CheckBox checkBoxIsEnabled;
    }
}

