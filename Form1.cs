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

        public void toCalculate(string operacao) { 


        }
    }
}