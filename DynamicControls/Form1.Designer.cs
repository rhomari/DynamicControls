
namespace DynamicControls
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
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTEXT = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.cbxCOLOR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(211, 16);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(573, 410);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.AutoScroll = true;
            this.ButtonsPanel.Location = new System.Drawing.Point(9, 16);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(189, 409);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add new shortcut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTEXT
            // 
            this.txtTEXT.Location = new System.Drawing.Point(458, 449);
            this.txtTEXT.Name = "txtTEXT";
            this.txtTEXT.Size = new System.Drawing.Size(177, 23);
            this.txtTEXT.TabIndex = 100;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(458, 478);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(177, 23);
            this.txtURL.TabIndex = 101;
            // 
            // cbxCOLOR
            // 
            this.cbxCOLOR.FormattingEnabled = true;
            this.cbxCOLOR.Location = new System.Drawing.Point(458, 508);
            this.cbxCOLOR.Name = "cbxCOLOR";
            this.cbxCOLOR.Size = new System.Drawing.Size(177, 23);
            this.cbxCOLOR.TabIndex = 103;
            this.cbxCOLOR.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Text :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Link :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCOLOR);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtTEXT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.webView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTEXT;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ComboBox cbxCOLOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

