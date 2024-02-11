namespace BotDeskTop;

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
        btn_start = new Button();
        btn_stop = new Button();
        btn_add_text = new Button();
        btn_map = new Button();
        lv_itens = new ListView();
        etapa = new ColumnHeader();
        tipo = new ColumnHeader();
        valor = new ColumnHeader();
        lb_x = new Label();
        lb_y = new Label();
        SuspendLayout();
        // 
        // btn_start
        // 
        btn_start.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btn_start.Location = new Point(21, 24);
        btn_start.Name = "btn_start";
        btn_start.Size = new Size(113, 38);
        btn_start.TabIndex = 3;
        btn_start.Text = "Iniciar";
        btn_start.UseVisualStyleBackColor = true;
        // 
        // btn_stop
        // 
        btn_stop.Location = new Point(21, 156);
        btn_stop.Name = "btn_stop";
        btn_stop.Size = new Size(113, 38);
        btn_stop.TabIndex = 4;
        btn_stop.Text = "Parar";
        btn_stop.UseVisualStyleBackColor = true;
        // 
        // btn_add_text
        // 
        btn_add_text.Location = new Point(21, 112);
        btn_add_text.Name = "btn_add_text";
        btn_add_text.Size = new Size(113, 38);
        btn_add_text.TabIndex = 5;
        btn_add_text.Text = "Adiciona Texto";
        btn_add_text.UseVisualStyleBackColor = true;
        // 
        // btn_map
        // 
        btn_map.Location = new Point(21, 68);
        btn_map.Name = "btn_map";
        btn_map.Size = new Size(113, 38);
        btn_map.TabIndex = 6;
        btn_map.Text = "Mapear";
        btn_map.UseVisualStyleBackColor = true;
        // 
        // lv_itens
        // 
        lv_itens.Columns.AddRange(new ColumnHeader[] { etapa, tipo, valor });
        lv_itens.Location = new Point(180, 24);
        lv_itens.Name = "lv_itens";
        lv_itens.Size = new Size(353, 170);
        lv_itens.TabIndex = 7;
        lv_itens.UseCompatibleStateImageBehavior = false;
        lv_itens.View = View.Details;
        // 
        // etapa
        // 
        etapa.Text = "Etapa";
        etapa.Width = 100;
        // 
        // tipo
        // 
        tipo.Text = "Tipo";
        tipo.Width = 120;
        // 
        // valor
        // 
        valor.Text = "Valor";
        valor.Width = 120;
        // 
        // lb_x
        // 
        lb_x.AutoSize = true;
        lb_x.Location = new Point(539, 24);
        lb_x.Name = "lb_x";
        lb_x.Size = new Size(17, 15);
        lb_x.TabIndex = 8;
        lb_x.Text = "X:";
        // 
        // lb_y
        // 
        lb_y.AutoSize = true;
        lb_y.Location = new Point(539, 47);
        lb_y.Name = "lb_y";
        lb_y.Size = new Size(17, 15);
        lb_y.TabIndex = 9;
        lb_y.Text = "Y:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(642, 240);
        Controls.Add(lb_y);
        Controls.Add(lb_x);
        Controls.Add(lv_itens);
        Controls.Add(btn_map);
        Controls.Add(btn_add_text);
        Controls.Add(btn_stop);
        Controls.Add(btn_start);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn_start;
    private Button btn_stop;
    private Button btn_add_text;
    private Button btn_map;
    private ListView lv_itens;
    private ColumnHeader etapa;
    private ColumnHeader tipo;
    private ColumnHeader valor;
    private Label lb_x;
    private Label lb_y;
}
