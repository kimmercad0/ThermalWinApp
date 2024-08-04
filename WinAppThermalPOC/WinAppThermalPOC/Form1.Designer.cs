namespace WinAppThermalPOC
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
            CelciusTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            farenheitTxt = new TextBox();
            CelciusTrackBar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)CelciusTrackBar).BeginInit();
            SuspendLayout();
            // 
            // CelciusTxt
            // 
            CelciusTxt.Location = new Point(155, 79);
            CelciusTxt.Name = "CelciusTxt";
            CelciusTxt.Size = new Size(100, 23);
            CelciusTxt.TabIndex = 0;
            CelciusTxt.TextChanged += CelciusTxt_TextChanged;
            CelciusTxt.KeyPress += CelciusTxt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 61);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Celcius: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 61);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Farenheit:";
            // 
            // farenheitTxt
            // 
            farenheitTxt.Location = new Point(571, 79);
            farenheitTxt.Name = "farenheitTxt";
            farenheitTxt.Size = new Size(100, 23);
            farenheitTxt.TabIndex = 2;
            farenheitTxt.TextChanged += farenheitTxt_TextChanged;
            farenheitTxt.KeyPress += farenheitTxt_KeyPress;
            // 
            // CelciusTrackBar
            // 
            CelciusTrackBar.Location = new Point(394, 12);
            CelciusTrackBar.Maximum = 200;
            CelciusTrackBar.Minimum = -30;
            CelciusTrackBar.Name = "CelciusTrackBar";
            CelciusTrackBar.Orientation = Orientation.Vertical;
            CelciusTrackBar.Size = new Size(45, 507);
            CelciusTrackBar.TabIndex = 4;
            CelciusTrackBar.Scroll += CelciusTrackBar_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 554);
            Controls.Add(CelciusTrackBar);
            Controls.Add(label2);
            Controls.Add(farenheitTxt);
            Controls.Add(label1);
            Controls.Add(CelciusTxt);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CelciusTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CelciusTxt;
        private Label label1;
        private Label label2;
        private TextBox farenheitTxt;
        private TrackBar CelciusTrackBar;
    }
}
