namespace WebBrowserProxy
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
            this.btnProxyDegistir = new System.Windows.Forms.Button();
            this.btnProxySıfırla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProxyDegistir
            // 
            this.btnProxyDegistir.Location = new System.Drawing.Point(12, 19);
            this.btnProxyDegistir.Name = "btnProxyDegistir";
            this.btnProxyDegistir.Size = new System.Drawing.Size(166, 23);
            this.btnProxyDegistir.TabIndex = 0;
            this.btnProxyDegistir.Text = "Proxy Değiştir";
            this.btnProxyDegistir.UseVisualStyleBackColor = true;
            this.btnProxyDegistir.Click += new System.EventHandler(this.btnProxyDegistir_Click);
            // 
            // btnProxySıfırla
            // 
            this.btnProxySıfırla.Location = new System.Drawing.Point(184, 19);
            this.btnProxySıfırla.Name = "btnProxySıfırla";
            this.btnProxySıfırla.Size = new System.Drawing.Size(187, 23);
            this.btnProxySıfırla.TabIndex = 1;
            this.btnProxySıfırla.Text = "Proxy Sıfırla";
            this.btnProxySıfırla.UseVisualStyleBackColor = true;
            this.btnProxySıfırla.Click += new System.EventHandler(this.btnProxySıfırla_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProxyDegistir);
            this.panel1.Controls.Add(this.btnProxySıfırla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 56);
            this.panel1.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 56);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(488, 378);
            this.webBrowser1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 434);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proxy Kullanımı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProxyDegistir;
        private System.Windows.Forms.Button btnProxySıfırla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;

    }
}

