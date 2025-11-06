using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Classes
{
    internal class Operações
    {
        double x, y;
    

    public Operações()
        {
            x = 0; y = 0;
        }

        public void setXFromInput(double x)
        {
            this.x = x;
        }

        public void setYFromInput(double y) { 
       this.y = y;
        }

        public double getX() {
            return x;
        }

        public double getY() {
            return y;
        }

        public double soma() {
            double n;
            n = this.x + this.y;
            return n;   
        }


        public string binario(double n)
        {
            int x = (int)n;
           
            if (x == 0)
                return "0";
            string result = "";

            while (x > 0)
            {
                int rest = x % 2;
                result = rest + result;
                x /= 2; 

                
            }
            return result;
        }

        public double mult()
        {
            double n = this.x * this.y;
            return n;
        }

        public double div()
        {
            if (y == 0)
                return 0;
            double n = this.x / this.y;
            return n;
        }

        public double sub() {
            double n = this.x - this.y;
            return n;
        }

        public double porcent() {
            

            return this.x / 100 * this.y;
        }

        public double potenc(double x, double y) {

            return Math.Pow(x, y); 
        }

        public double raiz() {
            return Math.Sqrt(this.x);
        }

        public double aoQuad() {

            return this.x * this.x;  
        }
      
        }
        }
