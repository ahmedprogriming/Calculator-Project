using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        string currentInput ;
        double operand1 = 0;
        double operand2 = 0;
        char Oprtor;
        double Result = 0;

        public Form1()
        {
            InitializeComponent();
        }

    private void Numberbutton(object sender, EventArgs e)
        {
           Button btn = (Button)sender;
            currentInput += btn.Text;
            textBox1.Text += btn.Text;
        }
        private void OpretorButton(object sender, EventArgs e)
        {
          Button btn= (Button)sender;
            operand1= double.Parse(currentInput);

            Oprtor =btn.Text[0];

            textBox1.Text += " " + Oprtor + " ";
            currentInput = " ";

        }

        private void EquleEnd(object sender, EventArgs e)
        {
       
            operand2 = double.Parse(currentInput); 
            
            switch (Oprtor)
            {
                case '+':
                    Result = operand1 + operand2;break;
                case '-': Result = operand1 - operand2; break;

                case '*': Result = operand1 * operand2; break;

                case '/': Result = operand2!=0?(float)operand1/operand2:0; break;

                case '%': Result = operand1 % operand2; break;
            }

            currentInput=Result.ToString();
            textBox1.Text=currentInput; 
        }

        private void DeleteNumber(object sender, EventArgs e)
        {
            currentInput = "";
            operand1 = 0;
            operand2 = 0;
            Result = 0;
            Oprtor = '\0';
            textBox1.Text = "";
        }

           
   
      
    }

    


}