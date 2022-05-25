using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numero_do_mes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


            //CARREGAR COMBO BOX MANUALMENTE

            cb_mes.Items.Add(01);
            cb_mes.Items.Add(02);
            cb_mes.Items.Add(03);
            cb_mes.Items.Add(04);
            cb_mes.Items.Add(05);
            cb_mes.Items.Add(06);
            cb_mes.Items.Add(07);
            cb_mes.Items.Add(08);
            cb_mes.Items.Add(09);
            cb_mes.Items.Add(10);
            cb_mes.Items.Add(11);
            cb_mes.Items.Add(12);



        }

        private void cb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {

            int mes = Convert.ToInt32(cb_mes.SelectedItem);

            if (mes == 01)
            {
                lb_result.Text = "Janeiro";

            }
            else if (mes == 02)
            {

                lb_result.Text = "Fevereiro";
            }
            else if (mes == 03)
            {

                lb_result.Text = "Março";
            }
            else if (mes == 04)
            {
                lb_result.Text = "Abril";

            }
            else if (mes == 05)
            {
                lb_result.Text = "Maio";


            }
            else if (mes == 06)
            {


                lb_result.Text = "Junho";

            }
            else if (mes == 07)
            {

                lb_result.Text = "Julho";

            }
            else if (mes == 08)
            {
                lb_result.Text = "Agosto";

            }
            else if (mes == 09)
            {

                lb_result.Text = "Setembro";


            }
            else if (mes == 10)
            {
                lb_result.Text = "Outubro";

            }
            else if(mes == 11)
            {

                lb_result.Text = "Novembro";

            }
            else if (mes == 12)
            {

                lb_result.Text = "Dezembro";


            }
                   
        }
    }
}
