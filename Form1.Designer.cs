namespace Exemplo
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
            inputTextX = new TextBox();
            labelTitle = new Label();
            labelOutput = new Label();
            inputTextY = new TextBox();
            labelX = new Label();
            labelY = new Label();
            btnSoma = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnPorcent = new Button();
            btnDiv = new Button();
            btnAoQuad = new Button();
            btnBinario = new Button();
            btnRaiz = new Button();
            btnPotenc = new Button();
            textEmocional = new Label();
            label1 = new Label();
            labelResult = new Label();
            btnDarkMode = new Button();
            btnLightMode = new Button();
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.Location = new Point(16, 77);
            inputTextX.Name = "inputTextX";
            inputTextX.PlaceholderText = "0";
            inputTextX.Size = new Size(191, 31);
            inputTextX.TabIndex = 1;
            inputTextX.TextChanged += inputTextX_TextChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(12, 9);
            labelTitle.MaximumSize = new Size(300, 65);
            labelTitle.MinimumSize = new Size(300, 65);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "CALCULADORADORA 😎";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.Black;
            labelOutput.ForeColor = Color.White;
            labelOutput.ImageAlign = ContentAlignment.TopCenter;
            labelOutput.Location = new Point(388, 15);
            labelOutput.MaximumSize = new Size(400, 415);
            labelOutput.MinimumSize = new Size(400, 415);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(10);
            labelOutput.Size = new Size(400, 415);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "...";
            labelOutput.Visible = false;
            labelOutput.Click += labelOutput_Click;
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(16, 132);
            inputTextY.Name = "inputTextY";
            inputTextY.PlaceholderText = "0";
            inputTextY.Size = new Size(191, 31);
            inputTextY.TabIndex = 2;
            inputTextY.TextChanged += inputTextY_TextChanged;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.ForeColor = SystemColors.ButtonHighlight;
            labelX.Location = new Point(213, 80);
            labelX.Name = "labelX";
            labelX.Size = new Size(23, 25);
            labelX.TabIndex = 5;
            labelX.Text = "X";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.ForeColor = SystemColors.ButtonHighlight;
            labelY.Location = new Point(214, 135);
            labelY.Name = "labelY";
            labelY.Size = new Size(22, 25);
            labelY.TabIndex = 6;
            labelY.Text = "Y";
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(16, 250);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(112, 34);
            btnSoma.TabIndex = 7;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(134, 250);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(112, 34);
            btnSub.TabIndex = 8;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(255, 250);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(112, 34);
            btnMult.TabIndex = 9;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnPorcent
            // 
            btnPorcent.Location = new Point(16, 330);
            btnPorcent.Name = "btnPorcent";
            btnPorcent.Size = new Size(112, 34);
            btnPorcent.TabIndex = 10;
            btnPorcent.Text = "%";
            btnPorcent.UseVisualStyleBackColor = true;
            btnPorcent.Click += btnPorcent_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(16, 290);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(112, 34);
            btnDiv.TabIndex = 11;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnAoQuad
            // 
            btnAoQuad.Location = new Point(134, 290);
            btnAoQuad.Name = "btnAoQuad";
            btnAoQuad.Size = new Size(112, 34);
            btnAoQuad.TabIndex = 12;
            btnAoQuad.Text = "x²";
            btnAoQuad.UseVisualStyleBackColor = true;
            btnAoQuad.Click += btnAoQuad_Click;
            // 
            // btnBinario
            // 
            btnBinario.Location = new Point(134, 331);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(112, 34);
            btnBinario.TabIndex = 13;
            btnBinario.Text = "010101";
            btnBinario.UseVisualStyleBackColor = true;
            btnBinario.Click += btnBinario_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Location = new Point(255, 290);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(112, 34);
            btnRaiz.TabIndex = 14;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnPotenc
            // 
            btnPotenc.Location = new Point(255, 330);
            btnPotenc.Name = "btnPotenc";
            btnPotenc.Size = new Size(112, 34);
            btnPotenc.TabIndex = 15;
            btnPotenc.Text = "xʸ";
            btnPotenc.UseVisualStyleBackColor = true;
            btnPotenc.Click += btnPotenc_Click;
            // 
            // textEmocional
            // 
            textEmocional.AutoSize = true;
            textEmocional.BackColor = Color.Transparent;
            textEmocional.Font = new Font("Baskerville Old Face", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textEmocional.ForeColor = SystemColors.ButtonHighlight;
            textEmocional.Location = new Point(1, 409);
            textEmocional.Name = "textEmocional";
            textEmocional.Size = new Size(390, 21);
            textEmocional.TabIndex = 16;
            textEmocional.Text = "🔥 SOMANDO IDÉIAS, DIVIDINDO ERROS 🔥";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Image = Properties.Resources.Einstein__cartoon;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(388, 141);
            label1.MaximumSize = new Size(400, 300);
            label1.MinimumSize = new Size(400, 300);
            label1.Name = "label1";
            label1.Size = new Size(400, 300);
            label1.TabIndex = 17;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResult.ForeColor = SystemColors.ButtonHighlight;
            labelResult.Location = new Point(388, 64);
            labelResult.MaximumSize = new Size(400, 70);
            labelResult.MinimumSize = new Size(400, 70);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(400, 70);
            labelResult.TabIndex = 18;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            labelResult.Click += labelResult_Click;
            // 
            // btnDarkMode
            // 
            btnDarkMode.Location = new Point(16, 169);
            btnDarkMode.Name = "btnDarkMode";
            btnDarkMode.Size = new Size(112, 34);
            btnDarkMode.TabIndex = 19;
            btnDarkMode.Text = "Dark Mode";
            btnDarkMode.UseVisualStyleBackColor = true;
            btnDarkMode.Click += btnDarkMode_Click;
            // 
            // btnLightMode
            // 
            btnLightMode.Location = new Point(134, 169);
            btnLightMode.Name = "btnLightMode";
            btnLightMode.Size = new Size(112, 34);
            btnLightMode.TabIndex = 20;
            btnLightMode.Text = "Light Mode";
            btnLightMode.UseVisualStyleBackColor = true;
            btnLightMode.Click += btnLightMode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLightMode);
            Controls.Add(btnDarkMode);
            Controls.Add(labelResult);
            Controls.Add(label1);
            Controls.Add(textEmocional);
            Controls.Add(btnPotenc);
            Controls.Add(btnRaiz);
            Controls.Add(btnBinario);
            Controls.Add(btnAoQuad);
            Controls.Add(btnDiv);
            Controls.Add(btnPorcent);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Controls.Add(inputTextY);
            Controls.Add(labelOutput);
            Controls.Add(labelTitle);
            Controls.Add(inputTextX);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextX;
        private Label labelTitle;
        private Label labelOutput;
        private TextBox inputTextY;
        private Label labelX;
        private Label labelY;
        private Button btnSoma;
        private Button btnSub;
        private Button btnMult;
        private Button btnPorcent;
        private Button btnDiv;
        private Button btnAoQuad;
        private Button btnBinario;
        private Button btnRaiz;
        private Button btnPotenc;
        private Label textEmocional;
        private Label label1;
        private Label labelResult;
        private Button btnDarkMode;
        private Button btnLightMode;
    }
}
