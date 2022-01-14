namespace ObservableObjectConverter
{
    partial class MainForm
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
            this.propRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.observableRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.setterComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // propRichTxtBox
            // 
            this.propRichTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propRichTxtBox.Location = new System.Drawing.Point(8, 31);
            this.propRichTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.propRichTxtBox.Name = "propRichTxtBox";
            this.propRichTxtBox.Size = new System.Drawing.Size(320, 422);
            this.propRichTxtBox.TabIndex = 0;
            this.propRichTxtBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Properties:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Observable Objects:";
            // 
            // observableRichTxtBox
            // 
            this.observableRichTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.observableRichTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.observableRichTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.observableRichTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.observableRichTxtBox.Location = new System.Drawing.Point(456, 32);
            this.observableRichTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.observableRichTxtBox.Name = "observableRichTxtBox";
            this.observableRichTxtBox.ReadOnly = true;
            this.observableRichTxtBox.Size = new System.Drawing.Size(320, 422);
            this.observableRichTxtBox.TabIndex = 2;
            this.observableRichTxtBox.Text = "";
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConvert.Location = new System.Drawing.Point(336, 203);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 50);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // setterComboBox
            // 
            this.setterComboBox.FormattingEnabled = true;
            this.setterComboBox.Location = new System.Drawing.Point(335, 172);
            this.setterComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.setterComboBox.Name = "setterComboBox";
            this.setterComboBox.Size = new System.Drawing.Size(113, 23);
            this.setterComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Setter Modifier:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setterComboBox);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.observableRichTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propRichTxtBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Observable Object Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox propRichTxtBox;
        private Label label1;
        private Label label2;
        private RichTextBox observableRichTxtBox;
        private Button btnConvert;
        private ComboBox setterComboBox;
        private Label label3;
    }
}