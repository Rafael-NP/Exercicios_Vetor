namespace Vetor_ex
{
    partial class frmex2
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
            btnreset = new Button();
            btnmostrar = new Button();
            btnvoltar = new Button();
            lblB = new Label();
            lblA = new Label();
            lblnum = new Label();
            txtB = new TextBox();
            txtA = new TextBox();
            btnadd = new Button();
            txtnum = new TextBox();
            lbladdnum = new Label();
            txtaddnum = new TextBox();
            SuspendLayout();
            // 
            // btnreset
            // 
            btnreset.Location = new Point(342, 368);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(75, 29);
            btnreset.TabIndex = 19;
            btnreset.Text = "Resetar";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // btnmostrar
            // 
            btnmostrar.Enabled = false;
            btnmostrar.Location = new Point(41, 187);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(145, 29);
            btnmostrar.TabIndex = 18;
            btnmostrar.Text = "Mostrar Listas";
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(446, 368);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 29);
            btnvoltar.TabIndex = 17;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(411, 38);
            lblB.Name = "lblB";
            lblB.Size = new Size(55, 20);
            lblB.TabIndex = 16;
            lblB.Text = "Lista B:";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(280, 38);
            lblA.Name = "lblA";
            lblA.Size = new Size(56, 20);
            lblA.TabIndex = 15;
            lblA.Text = "Lista A:";
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Location = new Point(41, 45);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(0, 20);
            lblnum.TabIndex = 14;
            // 
            // txtB
            // 
            txtB.Location = new Point(391, 68);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.ReadOnly = true;
            txtB.ScrollBars = ScrollBars.Both;
            txtB.Size = new Size(94, 157);
            txtB.TabIndex = 13;
            // 
            // txtA
            // 
            txtA.Location = new Point(259, 68);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.ReadOnly = true;
            txtA.ScrollBars = ScrollBars.Both;
            txtA.Size = new Size(94, 157);
            txtA.TabIndex = 12;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(41, 131);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(145, 29);
            btnadd.TabIndex = 11;
            btnadd.Text = "Adicionar Número";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(41, 80);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(145, 27);
            txtnum.TabIndex = 10;
            // 
            // lbladdnum
            // 
            lbladdnum.AutoSize = true;
            lbladdnum.Location = new Point(41, 347);
            lbladdnum.Name = "lbladdnum";
            lbladdnum.Size = new Size(159, 20);
            lbladdnum.TabIndex = 33;
            lbladdnum.Text = "Números Adicionados:";
            // 
            // txtaddnum
            // 
            txtaddnum.Location = new Point(41, 379);
            txtaddnum.Name = "txtaddnum";
            txtaddnum.ReadOnly = true;
            txtaddnum.Size = new Size(100, 27);
            txtaddnum.TabIndex = 32;
            // 
            // frmex2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 435);
            ControlBox = false;
            Controls.Add(lbladdnum);
            Controls.Add(txtaddnum);
            Controls.Add(btnreset);
            Controls.Add(btnmostrar);
            Controls.Add(btnvoltar);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblnum);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnadd);
            Controls.Add(txtnum);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmex2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Negativo dos 10 Números";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnreset;
        private Button btnmostrar;
        private Button btnvoltar;
        private Label lblB;
        private Label lblA;
        private Label lblnum;
        private TextBox txtB;
        private TextBox txtA;
        private Button btnadd;
        private TextBox txtnum;
        private Label lbladdnum;
        private TextBox txtaddnum;
    }
}