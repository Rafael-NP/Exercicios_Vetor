namespace Vetor_ex
{
    partial class frmmenu
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
            menuStrip1 = new MenuStrip();
            tsmiex = new ToolStripMenuItem();
            tsmiex1 = new ToolStripMenuItem();
            tsmiex2 = new ToolStripMenuItem();
            tsmisair = new ToolStripMenuItem();
            tsmiex3 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiex, tsmisair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(623, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiex
            // 
            tsmiex.DropDownItems.AddRange(new ToolStripItem[] { tsmiex1, tsmiex2, tsmiex3 });
            tsmiex.Name = "tsmiex";
            tsmiex.Size = new Size(86, 24);
            tsmiex.Text = "Exercícios";
            // 
            // tsmiex1
            // 
            tsmiex1.Name = "tsmiex1";
            tsmiex1.Size = new Size(180, 24);
            tsmiex1.Text = "Exercício 1";
            tsmiex1.Click += tsmiex1_Click;
            // 
            // tsmiex2
            // 
            tsmiex2.Name = "tsmiex2";
            tsmiex2.Size = new Size(180, 24);
            tsmiex2.Text = "Exercício 2";
            tsmiex2.Click += tsmiex2_Click;
            // 
            // tsmisair
            // 
            tsmisair.Name = "tsmisair";
            tsmisair.Size = new Size(46, 24);
            tsmisair.Text = "Sair";
            tsmisair.Click += tsmisair_Click;
            // 
            // tsmiex3
            // 
            tsmiex3.Name = "tsmiex3";
            tsmiex3.Size = new Size(180, 24);
            tsmiex3.Text = "Exercício 3";
            tsmiex3.Click += tsmiex3_Click;
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 425);
            ControlBox = false;
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiex;
        private ToolStripMenuItem tsmiex1;
        private ToolStripMenuItem tsmisair;
        private ToolStripMenuItem tsmiex2;
        private ToolStripMenuItem tsmiex3;
    }
}
