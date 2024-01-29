namespace Controle_de_Estoque
{
    partial class Carregando
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
            Carregando_pgb = new ProgressBar();
            SuspendLayout();
            // 
            // Carregando_pgb
            // 
            Carregando_pgb.Location = new Point(97, 261);
            Carregando_pgb.Name = "Carregando_pgb";
            Carregando_pgb.Size = new Size(564, 23);
            Carregando_pgb.TabIndex = 0;
            // 
            // Carregando
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Carregando_pgb);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Carregando";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carregando";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar Carregando_pgb;
    }
}
