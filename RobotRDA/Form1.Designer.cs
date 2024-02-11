namespace RobotRDA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabs = new System.Windows.Forms.TabControl();
            this.btn_facebook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_quotes = new System.Windows.Forms.Button();
            this.btn_dolar = new System.Windows.Forms.Button();
            this.btn_euro = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Location = new System.Drawing.Point(2, 82);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(968, 482);
            this.tabs.TabIndex = 0;
            // 
            // btn_facebook
            // 
            this.btn_facebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_facebook.BackgroundImage")));
            this.btn_facebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facebook.ForeColor = System.Drawing.Color.White;
            this.btn_facebook.Location = new System.Drawing.Point(12, 22);
            this.btn_facebook.Name = "btn_facebook";
            this.btn_facebook.Size = new System.Drawing.Size(117, 40);
            this.btn_facebook.TabIndex = 1;
            this.btn_facebook.Text = "Facebook";
            this.btn_facebook.UseVisualStyleBackColor = true;
            this.btn_facebook.Click += new System.EventHandler(this.btn_facebook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_euro);
            this.groupBox1.Controls.Add(this.btn_dolar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(289, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cotações";
            // 
            // btn_quotes
            // 
            this.btn_quotes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_quotes.BackgroundImage")));
            this.btn_quotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quotes.ForeColor = System.Drawing.Color.White;
            this.btn_quotes.Location = new System.Drawing.Point(151, 22);
            this.btn_quotes.Name = "btn_quotes";
            this.btn_quotes.Size = new System.Drawing.Size(117, 40);
            this.btn_quotes.TabIndex = 5;
            this.btn_quotes.Text = "Quotes";
            this.btn_quotes.UseVisualStyleBackColor = true;
            this.btn_quotes.Click += new System.EventHandler(this.btn_quotes_Click);
            // 
            // btn_dolar
            // 
            this.btn_dolar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dolar.BackgroundImage")));
            this.btn_dolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dolar.ForeColor = System.Drawing.Color.Black;
            this.btn_dolar.Location = new System.Drawing.Point(14, 21);
            this.btn_dolar.Name = "btn_dolar";
            this.btn_dolar.Size = new System.Drawing.Size(117, 40);
            this.btn_dolar.TabIndex = 6;
            this.btn_dolar.Text = "Dolar";
            this.btn_dolar.UseVisualStyleBackColor = true;
            this.btn_dolar.Click += new System.EventHandler(this.btn_dolar_Click);
            // 
            // btn_euro
            // 
            this.btn_euro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_euro.BackgroundImage")));
            this.btn_euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_euro.ForeColor = System.Drawing.Color.Black;
            this.btn_euro.Location = new System.Drawing.Point(147, 21);
            this.btn_euro.Name = "btn_euro";
            this.btn_euro.Size = new System.Drawing.Size(117, 40);
            this.btn_euro.TabIndex = 7;
            this.btn_euro.Text = "Euro";
            this.btn_euro.UseVisualStyleBackColor = true;
            this.btn_euro.Click += new System.EventHandler(this.btn_euro_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(843, 22);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(117, 40);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Fechar Tab";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(972, 566);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_quotes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_facebook);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "RDA";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Button btn_facebook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_quotes;
        private System.Windows.Forms.Button btn_euro;
        private System.Windows.Forms.Button btn_dolar;
        private System.Windows.Forms.Button btn_close;
    }
}

