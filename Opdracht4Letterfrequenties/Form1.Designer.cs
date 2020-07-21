namespace Opdracht4Letterfrequenties
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
            this.components = new System.ComponentModel.Container();
            this.TextBoxPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCountCharacters = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RichTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Location = new System.Drawing.Point(75, 12);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.Size = new System.Drawing.Size(611, 20);
            this.TextBoxPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "path to file";
            // 
            // ButtonCountCharacters
            // 
            this.ButtonCountCharacters.Location = new System.Drawing.Point(692, 12);
            this.ButtonCountCharacters.Name = "ButtonCountCharacters";
            this.ButtonCountCharacters.Size = new System.Drawing.Size(96, 23);
            this.ButtonCountCharacters.TabIndex = 2;
            this.ButtonCountCharacters.Text = "count characters";
            this.ButtonCountCharacters.UseVisualStyleBackColor = true;
            this.ButtonCountCharacters.Click += new System.EventHandler(this.ButtonCountCharacters_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RichTextBoxResult
            // 
            this.RichTextBoxResult.Location = new System.Drawing.Point(16, 44);
            this.RichTextBoxResult.Name = "RichTextBoxResult";
            this.RichTextBoxResult.Size = new System.Drawing.Size(772, 394);
            this.RichTextBoxResult.TabIndex = 5;
            this.RichTextBoxResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTextBoxResult);
            this.Controls.Add(this.ButtonCountCharacters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCountCharacters;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox RichTextBoxResult;
    }
}

