namespace HookCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCallbacks = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHookPrefix = new System.Windows.Forms.TextBox();
            this.buttonMakeHook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonALS = new System.Windows.Forms.RadioButton();
            this.radioButtonChain = new System.Windows.Forms.RadioButton();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCopyResult = new System.Windows.Forms.Button();
            this.radioButtonCallChain = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Callback";
            // 
            // comboBoxCallbacks
            // 
            this.comboBoxCallbacks.FormattingEnabled = true;
            this.comboBoxCallbacks.Location = new System.Drawing.Point(29, 29);
            this.comboBoxCallbacks.Name = "comboBoxCallbacks";
            this.comboBoxCallbacks.Size = new System.Drawing.Size(375, 21);
            this.comboBoxCallbacks.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hook Prefix";
            // 
            // textBoxHookPrefix
            // 
            this.textBoxHookPrefix.Location = new System.Drawing.Point(29, 70);
            this.textBoxHookPrefix.Name = "textBoxHookPrefix";
            this.textBoxHookPrefix.Size = new System.Drawing.Size(375, 20);
            this.textBoxHookPrefix.TabIndex = 3;
            this.textBoxHookPrefix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHookPrefix_KeyPress);
            // 
            // buttonMakeHook
            // 
            this.buttonMakeHook.Location = new System.Drawing.Point(16, 97);
            this.buttonMakeHook.Name = "buttonMakeHook";
            this.buttonMakeHook.Size = new System.Drawing.Size(388, 33);
            this.buttonMakeHook.TabIndex = 4;
            this.buttonMakeHook.Text = "GENERATE";
            this.buttonMakeHook.UseVisualStyleBackColor = true;
            this.buttonMakeHook.Click += new System.EventHandler(this.buttonMakeHook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(59, 135);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonAll.TabIndex = 6;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonALS
            // 
            this.radioButtonALS.AutoSize = true;
            this.radioButtonALS.Location = new System.Drawing.Point(92, 135);
            this.radioButtonALS.Name = "radioButtonALS";
            this.radioButtonALS.Size = new System.Drawing.Size(69, 17);
            this.radioButtonALS.TabIndex = 7;
            this.radioButtonALS.TabStop = true;
            this.radioButtonALS.Text = "Only ALS";
            this.radioButtonALS.UseVisualStyleBackColor = true;
            this.radioButtonALS.CheckedChanged += new System.EventHandler(this.radioButtonALS_CheckedChanged);
            // 
            // radioButtonChain
            // 
            this.radioButtonChain.AutoSize = true;
            this.radioButtonChain.Location = new System.Drawing.Point(158, 135);
            this.radioButtonChain.Name = "radioButtonChain";
            this.radioButtonChain.Size = new System.Drawing.Size(76, 17);
            this.radioButtonChain.TabIndex = 8;
            this.radioButtonChain.TabStop = true;
            this.radioButtonChain.Text = "Only Chain";
            this.radioButtonChain.UseVisualStyleBackColor = true;
            this.radioButtonChain.CheckedChanged += new System.EventHandler(this.radioButtonChain_CheckedChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(19, 158);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(385, 136);
            this.textBoxResult.TabIndex = 9;
            this.textBoxResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxResult_KeyDown);
            // 
            // buttonCopyResult
            // 
            this.buttonCopyResult.Location = new System.Drawing.Point(18, 299);
            this.buttonCopyResult.Name = "buttonCopyResult";
            this.buttonCopyResult.Size = new System.Drawing.Size(387, 34);
            this.buttonCopyResult.TabIndex = 10;
            this.buttonCopyResult.Text = "COPY RESULT";
            this.buttonCopyResult.UseVisualStyleBackColor = true;
            this.buttonCopyResult.Click += new System.EventHandler(this.buttonCopyResult_Click);
            // 
            // radioButtonCallChain
            // 
            this.radioButtonCallChain.AutoSize = true;
            this.radioButtonCallChain.Location = new System.Drawing.Point(231, 135);
            this.radioButtonCallChain.Name = "radioButtonCallChain";
            this.radioButtonCallChain.Size = new System.Drawing.Size(142, 17);
            this.radioButtonCallChain.TabIndex = 11;
            this.radioButtonCallChain.TabStop = true;
            this.radioButtonCallChain.Text = "Only Callback with Chain";
            this.radioButtonCallChain.UseVisualStyleBackColor = true;
            this.radioButtonCallChain.CheckedChanged += new System.EventHandler(this.radioButtonCallChain_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 339);
            this.Controls.Add(this.buttonCopyResult);
            this.Controls.Add(this.radioButtonCallChain);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.radioButtonChain);
            this.Controls.Add(this.radioButtonALS);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMakeHook);
            this.Controls.Add(this.textBoxHookPrefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCallbacks);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hook Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHookPrefix;
        private System.Windows.Forms.Button buttonMakeHook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonALS;
        private System.Windows.Forms.RadioButton radioButtonChain;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBoxCallbacks;
        private System.Windows.Forms.Button buttonCopyResult;
        private System.Windows.Forms.RadioButton radioButtonCallChain;
    }
}

