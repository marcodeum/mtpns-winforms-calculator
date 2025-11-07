using Exemplo.Classes;
using System.Security.Cryptography.X509Certificates;

namespace Exemplo
{
    public partial class Form1 : Form
    {
        Operações op;
        public Form1()
        {
            InitializeComponent();
            op = new Operações();

        }
        public void setInputs()
        {
            op.setXFromInput(double.Parse(inputTextX.Text));

            op.setYFromInput(double.Parse(inputTextY.Text));
        }

        public void setInputX()
        {
            op.setXFromInput(double.Parse(inputTextX.Text));
        }


        private void Form1_Load(object sender, EventArgs e)
        { }


        public void printResult(double x, double y, string operacao, double result)
        {
            string formatosaida = x + operacao + y + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = formatosaida;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();
        }

        public void printResultAoQuad(double x, string operacao, double result)
        {
            string format = x + operacao + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = format;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();

        }

        public void printResultRaiz(double x, string operacao, double result)
        {
            string format = operacao + x + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = format;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();
        }

        public void printResultBinario(double x, string operacao, string result)
        {
            result = op.binario(x);
            string format = x + operacao + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = format;
            labelResult.Visible = true;
            labelResult.Text = result;
        }

        public void printResultPorcent(double x, double y, string operacao, double result)
        {
            string format = x + operacao + y + " = ";
            labelOutput.Visible = true;
            labelOutput.Text = format;
            labelResult.Visible = true;
            labelResult.Text = result.ToString();

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            setInputs();
            printResult(op.getX(), op.getY(), " + ", op.soma());

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            setInputs();
            printResult(op.getX(), op.getY(), " - ", op.sub());

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            setInputs();
            printResult(op.getX(), op.getY(), " * ", op.mult());
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            setInputs();
            printResult(op.getX(), op.getY(), " / ", op.div());
        }

        private void btnAoQuad_Click(object sender, EventArgs e)
        {
            setInputX();
            printResultAoQuad(op.getX(), " ² ", op.aoQuad());
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            setInputX();
            printResultRaiz(op.getX(), "√", op.raiz());
        }

        private void inputTextX_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputTextY_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnPorcent_Click(object sender, EventArgs e)
        {

            setInputs();
            printResultPorcent(op.getX(), op.getY(), "% de ", op.porcent());
        }

        private void btnPotenc_Click(object sender, EventArgs e)
        {
            setInputs();
            printResult(op.getX(), op.getY(), " ^ ", op.potenc(op.getX(), op.getY()));
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            setInputX();
            printResultBinario(op.getX(), " em binário", op.binario(op.getX()));

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        public void toCalculate(string operacao)
        {


        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            labelOutput.BackColor = Color.Black; labelOutput.ForeColor = Color.White;
            labelResult.BackColor = Color.Black; labelResult.ForeColor = Color.White;
            labelTitle.BackColor = Color.Black; labelTitle.ForeColor = Color.White;
            labelX.BackColor = Color.Black; labelX.ForeColor = Color.White;
            labelY.BackColor = Color.Black; labelY.ForeColor = Color.White;
            btnAoQuad.BackColor = Color.Black; btnAoQuad.ForeColor = Color.White;
            btnBinario.BackColor = Color.Black; btnBinario.ForeColor = Color.White;
            btnDiv.BackColor = Color.Black; btnDiv.ForeColor = Color.White;
            btnDarkMode.BackColor = Color.Black; btnDarkMode.ForeColor = Color.White;
            btnLightMode.BackColor = Color.Black; btnLightMode.ForeColor = Color.White;
            btnMult.BackColor = Color.Black; btnMult.ForeColor = Color.White;
            btnPorcent.BackColor = Color.Black; btnPorcent.ForeColor = Color.White;
            btnPotenc.BackColor = Color.Black; btnPotenc.ForeColor = Color.White;
            btnRaiz.BackColor = Color.Black; btnRaiz.ForeColor = Color.White;
            btnSoma.BackColor = Color.Black; btnSoma.ForeColor = Color.White;
            btnSub.BackColor = Color.Black; btnSub.ForeColor = Color.White;
            textEmocional.BackColor = Color.Black; textEmocional.ForeColor = Color.White;
            label1.BackColor = Color.Black; label1.ForeColor = Color.White;
            inputTextX.BackColor = Color.Black; inputTextX.ForeColor = Color.White;
            inputTextY.BackColor = Color.Black; inputTextY.ForeColor = Color.White;
            this.BackColor = Color.Black; this.ForeColor = Color.White;


        }

        private void btnLightMode_Click(object sender, EventArgs e)
        {
            labelOutput.BackColor = Color.White; labelOutput.ForeColor = Color.Black;
            labelResult.BackColor = Color.White; labelResult.ForeColor = Color.Black;
            labelTitle.BackColor = Color.White; labelTitle.ForeColor = Color.Black;
            labelX.BackColor = Color.White; labelX.ForeColor = Color.Black;
            labelY.BackColor = Color.White; labelY.ForeColor = Color.Black;
            btnAoQuad.BackColor = Color.White; btnAoQuad.ForeColor = Color.Black;
            btnBinario.BackColor = Color.White; btnBinario.ForeColor = Color.Black;
            btnDiv.BackColor = Color.White; btnDiv.ForeColor = Color.Black;
            btnDarkMode.BackColor = Color.White; btnDarkMode.ForeColor = Color.Black;
            btnLightMode.BackColor = Color.White; btnLightMode.ForeColor = Color.Black;
            btnMult.BackColor = Color.White; btnMult.ForeColor = Color.Black;
            btnPorcent.BackColor = Color.White; btnPorcent.ForeColor = Color.Black;
            btnPotenc.BackColor = Color.White; btnPotenc.ForeColor = Color.Black;
            btnRaiz.BackColor = Color.White; btnRaiz.ForeColor = Color.Black;
            btnSoma.BackColor = Color.White; btnSoma.ForeColor = Color.Black;
            btnSub.BackColor = Color.White; btnSub.ForeColor = Color.Black;
            textEmocional.BackColor = Color.White; textEmocional.ForeColor = Color.Black;
            label1.BackColor = Color.White; label1.ForeColor = Color.Black;
            inputTextX.BackColor = Color.White; inputTextX.ForeColor = Color.Black;
            inputTextY.BackColor = Color.White; inputTextY.ForeColor = Color.Black;
            this.BackColor = Color.White; this.ForeColor = Color.Black;
            
        }
    }
}