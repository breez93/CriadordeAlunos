using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno NovoAluno = new Aluno();
            Calendario NovoAno = new Calendario();
          

            RBCaracteristicas.AppendText("-----Programa de Inserção de Alunos-----" +
                "  --------------- Nome do aluno " +  
                "  --------------- Idade do aluno  :  ");
            
           
        
        }

       
    }
}
