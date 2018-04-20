namespace lab5
{
    partial class NewWordForm
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
            this.newWordBox = new System.Windows.Forms.TextBox();
            this.wordCancelButton = new System.Windows.Forms.Button();
            this.wordOKButton = new System.Windows.Forms.Button();
            this.wordNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wordNameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // newWordBox
            // 
            this.newWordBox.Location = new System.Drawing.Point(97, 41);
            this.newWordBox.Name = "newWordBox";
            this.newWordBox.Size = new System.Drawing.Size(158, 20);
            this.newWordBox.TabIndex = 0;
            this.newWordBox.Validating += new System.ComponentModel.CancelEventHandler(this.newWordBox_Validating);
            // 
            // wordCancelButton
            // 
            this.wordCancelButton.Location = new System.Drawing.Point(44, 96);
            this.wordCancelButton.Name = "wordCancelButton";
            this.wordCancelButton.Size = new System.Drawing.Size(102, 35);
            this.wordCancelButton.TabIndex = 1;
            this.wordCancelButton.Text = "Cancel";
            this.wordCancelButton.UseVisualStyleBackColor = true;
            this.wordCancelButton.Click += new System.EventHandler(this.wordCancelButton_Click);
            // 
            // wordOKButton
            // 
            this.wordOKButton.Location = new System.Drawing.Point(202, 96);
            this.wordOKButton.Name = "wordOKButton";
            this.wordOKButton.Size = new System.Drawing.Size(102, 35);
            this.wordOKButton.TabIndex = 2;
            this.wordOKButton.Text = "OK";
            this.wordOKButton.UseVisualStyleBackColor = true;
            this.wordOKButton.Click += new System.EventHandler(this.wordOKButton_Click);
            // 
            // wordNameErrorProvider
            // 
            this.wordNameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.wordNameErrorProvider.ContainerControl = this;
            // 
            // NewWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 160);
            this.Controls.Add(this.wordOKButton);
            this.Controls.Add(this.wordCancelButton);
            this.Controls.Add(this.newWordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewWordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a new word";
            ((System.ComponentModel.ISupportInitialize)(this.wordNameErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newWordBox;
        private System.Windows.Forms.Button wordCancelButton;
        private System.Windows.Forms.Button wordOKButton;
        private System.Windows.Forms.ErrorProvider wordNameErrorProvider;
    }
}