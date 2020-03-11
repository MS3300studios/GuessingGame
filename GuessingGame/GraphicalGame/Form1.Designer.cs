namespace GraphicalGame
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
            this.ButtonNewGame = new System.Windows.Forms.Button();
            this.groupBoxRandomizing = new System.Windows.Forms.GroupBox();
            this.textBoxScopeTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonRandomize = new System.Windows.Forms.Button();
            this.textBoxScopeFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelCommunicate1 = new System.Windows.Forms.Label();
            this.groupBoxProposal = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAnwser = new System.Windows.Forms.Label();
            this.groupBoxRandomizing.SuspendLayout();
            this.groupBoxProposal.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonNewGame
            // 
            this.ButtonNewGame.Location = new System.Drawing.Point(12, 12);
            this.ButtonNewGame.Name = "ButtonNewGame";
            this.ButtonNewGame.Size = new System.Drawing.Size(79, 24);
            this.ButtonNewGame.TabIndex = 0;
            this.ButtonNewGame.Text = "New Game";
            this.ButtonNewGame.UseVisualStyleBackColor = true;
            this.ButtonNewGame.Click += new System.EventHandler(this.ButtonNewGame_Click);
            // 
            // groupBoxRandomizing
            // 
            this.groupBoxRandomizing.Controls.Add(this.textBoxScopeTo);
            this.groupBoxRandomizing.Controls.Add(this.label2);
            this.groupBoxRandomizing.Controls.Add(this.ButtonRandomize);
            this.groupBoxRandomizing.Controls.Add(this.textBoxScopeFrom);
            this.groupBoxRandomizing.Controls.Add(this.label1);
            this.groupBoxRandomizing.Location = new System.Drawing.Point(12, 57);
            this.groupBoxRandomizing.Name = "groupBoxRandomizing";
            this.groupBoxRandomizing.Size = new System.Drawing.Size(286, 151);
            this.groupBoxRandomizing.TabIndex = 1;
            this.groupBoxRandomizing.TabStop = false;
            this.groupBoxRandomizing.Text = "Randomize";
            this.groupBoxRandomizing.Visible = false;
            // 
            // textBoxScopeTo
            // 
            this.textBoxScopeTo.Location = new System.Drawing.Point(99, 74);
            this.textBoxScopeTo.Name = "textBoxScopeTo";
            this.textBoxScopeTo.Size = new System.Drawing.Size(138, 20);
            this.textBoxScopeTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scope to";
            // 
            // ButtonRandomize
            // 
            this.ButtonRandomize.Location = new System.Drawing.Point(182, 116);
            this.ButtonRandomize.Name = "ButtonRandomize";
            this.ButtonRandomize.Size = new System.Drawing.Size(75, 23);
            this.ButtonRandomize.TabIndex = 2;
            this.ButtonRandomize.Text = "Randomize";
            this.ButtonRandomize.UseVisualStyleBackColor = true;
            this.ButtonRandomize.Click += new System.EventHandler(this.ButtonRandomize_Click);
            // 
            // textBoxScopeFrom
            // 
            this.textBoxScopeFrom.Location = new System.Drawing.Point(99, 32);
            this.textBoxScopeFrom.Name = "textBoxScopeFrom";
            this.textBoxScopeFrom.Size = new System.Drawing.Size(138, 20);
            this.textBoxScopeFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scope from";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(223, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Visible = false;
            // 
            // labelCommunicate1
            // 
            this.labelCommunicate1.AutoSize = true;
            this.labelCommunicate1.Location = new System.Drawing.Point(22, 237);
            this.labelCommunicate1.Name = "labelCommunicate1";
            this.labelCommunicate1.Size = new System.Drawing.Size(0, 13);
            this.labelCommunicate1.TabIndex = 3;
            this.labelCommunicate1.Visible = false;
            // 
            // groupBoxProposal
            // 
            this.groupBoxProposal.Controls.Add(this.labelAnwser);
            this.groupBoxProposal.Controls.Add(this.button1);
            this.groupBoxProposal.Controls.Add(this.textBox1);
            this.groupBoxProposal.Location = new System.Drawing.Point(28, 237);
            this.groupBoxProposal.Name = "groupBoxProposal";
            this.groupBoxProposal.Size = new System.Drawing.Size(251, 95);
            this.groupBoxProposal.TabIndex = 4;
            this.groupBoxProposal.TabStop = false;
            this.groupBoxProposal.Text = "Proposal";
            this.groupBoxProposal.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelAnwser
            // 
            this.labelAnwser.AutoSize = true;
            this.labelAnwser.Location = new System.Drawing.Point(118, 20);
            this.labelAnwser.Name = "labelAnwser";
            this.labelAnwser.Size = new System.Drawing.Size(35, 13);
            this.labelAnwser.TabIndex = 2;
            this.labelAnwser.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.groupBoxProposal);
            this.Controls.Add(this.labelCommunicate1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.groupBoxRandomizing);
            this.Controls.Add(this.ButtonNewGame);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.groupBoxRandomizing.ResumeLayout(false);
            this.groupBoxRandomizing.PerformLayout();
            this.groupBoxProposal.ResumeLayout(false);
            this.groupBoxProposal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonNewGame;
        private System.Windows.Forms.GroupBox groupBoxRandomizing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxScopeTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonRandomize;
        private System.Windows.Forms.TextBox textBoxScopeFrom;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelCommunicate1;
        private System.Windows.Forms.GroupBox groupBoxProposal;
        private System.Windows.Forms.Label labelAnwser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

