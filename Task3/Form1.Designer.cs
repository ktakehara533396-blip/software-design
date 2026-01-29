namespace Task3
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
            this.txtFibonacciSeqInput = new System.Windows.Forms.TextBox();
            this.btnFibonacciSeq = new System.Windows.Forms.Button();
            this.lblFibonacciSeqResult = new System.Windows.Forms.Label();
            this.btnRecursivePower = new System.Windows.Forms.Button();
            this.txtRecursivePowInput = new System.Windows.Forms.TextBox();
            this.lblRecursivePower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFibonacciSeqInput
            // 
            this.txtFibonacciSeqInput.AcceptsReturn = true;
            this.txtFibonacciSeqInput.Location = new System.Drawing.Point(128, 76);
            this.txtFibonacciSeqInput.Name = "txtFibonacciSeqInput";
            this.txtFibonacciSeqInput.Size = new System.Drawing.Size(167, 22);
            this.txtFibonacciSeqInput.TabIndex = 0;
            // 
            // btnFibonacciSeq
            // 
            this.btnFibonacciSeq.Location = new System.Drawing.Point(167, 155);
            this.btnFibonacciSeq.Name = "btnFibonacciSeq";
            this.btnFibonacciSeq.Size = new System.Drawing.Size(75, 23);
            this.btnFibonacciSeq.TabIndex = 1;
            this.btnFibonacciSeq.Text = "Enter";
            this.btnFibonacciSeq.UseVisualStyleBackColor = true;
            this.btnFibonacciSeq.Click += new System.EventHandler(this.btnFibonacciSeq_Click);
            // 
            // lblFibonacciSeqResult
            // 
            this.lblFibonacciSeqResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFibonacciSeqResult.AutoSize = true;
            this.lblFibonacciSeqResult.Location = new System.Drawing.Point(95, 120);
            this.lblFibonacciSeqResult.Name = "lblFibonacciSeqResult";
            this.lblFibonacciSeqResult.Size = new System.Drawing.Size(48, 16);
            this.lblFibonacciSeqResult.TabIndex = 2;
            this.lblFibonacciSeqResult.Text = "Result:";
            // 
            // btnRecursivePower
            // 
            this.btnRecursivePower.Location = new System.Drawing.Point(167, 370);
            this.btnRecursivePower.Name = "btnRecursivePower";
            this.btnRecursivePower.Size = new System.Drawing.Size(75, 23);
            this.btnRecursivePower.TabIndex = 3;
            this.btnRecursivePower.Text = "Enter";
            this.btnRecursivePower.UseVisualStyleBackColor = true;
            this.btnRecursivePower.Click += new System.EventHandler(this.btnRecursivePower_Click);
            // 
            // txtRecursivePowInput
            // 
            this.txtRecursivePowInput.Location = new System.Drawing.Point(128, 285);
            this.txtRecursivePowInput.Name = "txtRecursivePowInput";
            this.txtRecursivePowInput.Size = new System.Drawing.Size(167, 22);
            this.txtRecursivePowInput.TabIndex = 4;
            // 
            // lblRecursivePower
            // 
            this.lblRecursivePower.AutoSize = true;
            this.lblRecursivePower.Location = new System.Drawing.Point(95, 334);
            this.lblRecursivePower.Name = "lblRecursivePower";
            this.lblRecursivePower.Size = new System.Drawing.Size(45, 16);
            this.lblRecursivePower.TabIndex = 5;
            this.lblRecursivePower.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 452);
            this.Controls.Add(this.lblRecursivePower);
            this.Controls.Add(this.txtRecursivePowInput);
            this.Controls.Add(this.btnRecursivePower);
            this.Controls.Add(this.lblFibonacciSeqResult);
            this.Controls.Add(this.btnFibonacciSeq);
            this.Controls.Add(this.txtFibonacciSeqInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFibonacciSeqInput;
        private System.Windows.Forms.Button btnFibonacciSeq;
        private System.Windows.Forms.Label lblFibonacciSeqResult;
        private System.Windows.Forms.Button btnRecursivePower;
        private System.Windows.Forms.TextBox txtRecursivePowInput;
        private System.Windows.Forms.Label lblRecursivePower;
    }
}

