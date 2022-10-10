using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Tela_Urna : Form
    {
        public Tela_Urna()
        {
            InitializeComponent();
            Txb_num1.Enabled = false;
            Txb_num2.Enabled = false;
        }
        Candidato candidato;
        string numero ="";
        Candidato[] vet = new Candidato[4];
        int branco, contador;
        


        
        private void Inserir()
        {
            if (contador < 4)
            {
                candidato = new Candidato();
                candidato.Nome = "Antônio de Oliveira";
                candidato.Turma = "1º ADS";
                candidato.Foto = "Antonio.jpg";
                candidato.Numero = 12;
                vet[contador]= candidato;
                contador++;
               
                //----------------
                
                candidato = new Candidato();
                candidato.Nome = "André Cardoso";
                candidato.Turma = "1º ADS";
                candidato.Foto = "Andre.jpg";
                candidato.Numero = 13;
                vet[contador] = candidato;
                contador++;
                //---------------
                candidato = new Candidato();
                candidato.Nome = "Ana Silva";
                candidato.Turma = "1º ADS";
                candidato.Foto = "Ana.jpg";
                candidato.Numero = 14;
                vet[contador] = candidato;
                contador++;

                candidato = new Candidato();
                candidato.Nome = "Alberto macedo";
                candidato.Turma = "1º ADS";
                candidato.Foto = "Alberto.jpg";
                candidato.Numero = 15;
                vet[contador] = candidato;
                contador++;
            }
        }
        private void Preencher(string n)
        {
            if (numero.Length==0)
            { Txb_num1.Text = n;
                numero = numero + n;
            }
            else
            {
                Txb_num2.Text = n;
              numero = numero + n;
            }
            for (int i = 0; i <4; i++)
            {
                if (int.Parse(numero) == vet[i].Numero)
                {
                    Lbl_cadidato.Text = vet[i].Nome;
                    Lbl_turma.Text =vet[i].Turma;
                    px.Image = Image.FromFile(@"C:\Users\Felipe\Pictures\IMAGENS/" + vet[i].Foto);
                    vet[i].Voto = 1;
                    i = 3;
                }
              
                
                   else
                    {
                        Lbl_cadidato.Text = "VOTO NULO";
                    Lbl_turma.Text = "";
                        lbl_mensagem.Visible = true;
                        btn_confirmar.Enabled = true;
                    }
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Preencher("1");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Preencher("9");

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Preencher("8");

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Preencher("7");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Preencher("6");

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Preencher("5");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Preencher("4");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Preencher("3");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Preencher("2");
        }

        private void Tela_Urna_Load(object sender, EventArgs e)
        {
            Inserir();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Preencher("0");
        }
    }
}
