namespace NequiDos
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            DueñoText = new Label();
            DueñoBox = new TextBox();
            InteresText = new Label();
            InteresBox = new NumericUpDown();
            CantidadBox = new NumericUpDown();
            CantidadText = new Label();
            CrearCuentaButton = new Button();
            DepositarButton = new Button();
            RetirarButton = new Button();
            CuentasData = new DataGridView();
            BlancoBox = new PictureBox();
            LogoNequi = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)InteresBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CantidadBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CuentasData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BlancoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoNequi).BeginInit();
            SuspendLayout();
            // 
            // DueñoText
            // 
            DueñoText.AutoSize = true;
            DueñoText.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DueñoText.Location = new Point(79, 151);
            DueñoText.Name = "DueñoText";
            DueñoText.Size = new Size(71, 18);
            DueñoText.TabIndex = 0;
            DueñoText.Text = "Dueño:";
            // 
            // DueñoBox
            // 
            DueñoBox.Font = new Font("Verdana", 12F);
            DueñoBox.Location = new Point(156, 142);
            DueñoBox.Name = "DueñoBox";
            DueñoBox.Size = new Size(120, 27);
            DueñoBox.TabIndex = 2;
            // 
            // InteresText
            // 
            InteresText.AutoSize = true;
            InteresText.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InteresText.Location = new Point(28, 207);
            InteresText.Name = "InteresText";
            InteresText.Size = new Size(122, 18);
            InteresText.TabIndex = 3;
            InteresText.Text = "Interés (%):";
            // 
            // InteresBox
            // 
            InteresBox.Font = new Font("Verdana", 12F);
            InteresBox.Location = new Point(156, 198);
            InteresBox.Name = "InteresBox";
            InteresBox.Size = new Size(120, 27);
            InteresBox.TabIndex = 4;
            // 
            // CantidadBox
            // 
            CantidadBox.Font = new Font("Verdana", 12F);
            CantidadBox.Location = new Point(156, 375);
            CantidadBox.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            CantidadBox.Name = "CantidadBox";
            CantidadBox.Size = new Size(120, 27);
            CantidadBox.TabIndex = 5;
            // 
            // CantidadText
            // 
            CantidadText.AutoSize = true;
            CantidadText.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CantidadText.Location = new Point(62, 384);
            CantidadText.Name = "CantidadText";
            CantidadText.Size = new Size(92, 18);
            CantidadText.TabIndex = 6;
            CantidadText.Text = "Cantidad:";
            // 
            // CrearCuentaButton
            // 
            CrearCuentaButton.Font = new Font("Verdana", 12F);
            CrearCuentaButton.Location = new Point(156, 246);
            CrearCuentaButton.Name = "CrearCuentaButton";
            CrearCuentaButton.Size = new Size(120, 45);
            CrearCuentaButton.TabIndex = 7;
            CrearCuentaButton.Text = "Crear Cuenta";
            CrearCuentaButton.UseVisualStyleBackColor = true;
            CrearCuentaButton.Click += CrearCuentaButton_Click;
            // 
            // DepositarButton
            // 
            DepositarButton.Font = new Font("Verdana", 12F);
            DepositarButton.Location = new Point(344, 333);
            DepositarButton.Name = "DepositarButton";
            DepositarButton.Size = new Size(166, 39);
            DepositarButton.TabIndex = 8;
            DepositarButton.Text = "Depositar";
            DepositarButton.UseVisualStyleBackColor = true;
            DepositarButton.Click += DepositarButton_Click;
            // 
            // RetirarButton
            // 
            RetirarButton.Font = new Font("Verdana", 12F);
            RetirarButton.Location = new Point(563, 333);
            RetirarButton.Name = "RetirarButton";
            RetirarButton.Size = new Size(166, 39);
            RetirarButton.TabIndex = 9;
            RetirarButton.Text = "Retirar";
            RetirarButton.UseVisualStyleBackColor = true;
            RetirarButton.Click += RetirarButton_Click;
            // 
            // CuentasData
            // 
            CuentasData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CuentasData.Location = new Point(320, 122);
            CuentasData.Name = "CuentasData";
            CuentasData.Size = new Size(437, 187);
            CuentasData.TabIndex = 10;
            // 
            // BlancoBox
            // 
            BlancoBox.BackColor = SystemColors.Window;
            BlancoBox.Location = new Point(-5, -10);
            BlancoBox.Name = "BlancoBox";
            BlancoBox.Size = new Size(806, 110);
            BlancoBox.TabIndex = 12;
            BlancoBox.TabStop = false;
            // 
            // LogoNequi
            // 
            LogoNequi.BackColor = SystemColors.Window;
            LogoNequi.Image = (Image)resources.GetObject("LogoNequi.Image");
            LogoNequi.Location = new Point(22, -1);
            LogoNequi.Name = "LogoNequi";
            LogoNequi.Size = new Size(309, 101);
            LogoNequi.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoNequi.TabIndex = 13;
            LogoNequi.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 450);
            Controls.Add(LogoNequi);
            Controls.Add(CuentasData);
            Controls.Add(RetirarButton);
            Controls.Add(DepositarButton);
            Controls.Add(CrearCuentaButton);
            Controls.Add(CantidadText);
            Controls.Add(CantidadBox);
            Controls.Add(InteresBox);
            Controls.Add(InteresText);
            Controls.Add(DueñoBox);
            Controls.Add(DueñoText);
            Controls.Add(BlancoBox);
            Name = "FormPrincipal";
            Text = "Nequi Dos";
            ((System.ComponentModel.ISupportInitialize)InteresBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CantidadBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CuentasData).EndInit();
            ((System.ComponentModel.ISupportInitialize)BlancoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoNequi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DueñoText;
        private TextBox DueñoBox;
        private Label InteresText;
        private NumericUpDown InteresBox;
        private NumericUpDown CantidadBox;
        private Label CantidadText;
        private Button CrearCuentaButton;
        private Button DepositarButton;
        private Button RetirarButton;
        private DataGridView CuentasData;
        private PictureBox BlancoBox;
        private PictureBox LogoNequi;
    }
}
