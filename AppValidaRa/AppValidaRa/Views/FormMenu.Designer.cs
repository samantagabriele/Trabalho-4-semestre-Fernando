namespace AppValidaRa
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            lblTitulo = new Label();
            lblDescricao = new Label();
            txtRa = new TextBox();
            btnValidar = new Button();
            lblResposta = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(155, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(231, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = " Validador de RA";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(207, 86);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(140, 25);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Digite seu RA :";
            // 
            // txtRa
            // 
            txtRa.BackColor = SystemColors.InactiveBorder;
            txtRa.CharacterCasing = CharacterCasing.Upper;
            txtRa.Location = new Point(212, 138);
            txtRa.MaxLength = 7;
            txtRa.Name = "txtRa";
            txtRa.Size = new Size(135, 26);
            txtRa.TabIndex = 2;
            // 
            // btnValidar
            // 
            btnValidar.BackColor = SystemColors.Window;
            btnValidar.FlatAppearance.BorderColor = Color.Black;
            btnValidar.FlatStyle = FlatStyle.Popup;
            btnValidar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidar.ImageAlign = ContentAlignment.MiddleRight;
            btnValidar.Location = new Point(230, 196);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(91, 31);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResposta.Location = new Point(207, 297);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(82, 21);
            lblResposta.TabIndex = 4;
            lblResposta.Text = "Resposta:";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(569, 361);
            Controls.Add(lblResposta);
            Controls.Add(btnValidar);
            Controls.Add(txtRa);
            Controls.Add(lblDescricao);
            Controls.Add(lblTitulo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validação de Matrícula ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDescricao;
        private TextBox txtRa;
        private Button btnValidar;
        private Label lblResposta;
    }
}
