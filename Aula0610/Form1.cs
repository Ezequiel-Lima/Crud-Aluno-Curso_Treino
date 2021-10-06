using Aula0610.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula0610
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConexaoBD db = new ConexaoBD();
        Curso curso = new Curso();
        int idCurso = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aulaCast061021DataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.aulaCast061021DataSet.Curso);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            curso.Curso1 = txbCurso.Text.Trim();
            curso.Mensalidade = Convert.ToInt32(txbMensalidade.Text.Trim());
         
            if (idCurso > 0)
                //inserir o using System.Data.Entity por causa do EntityState
                db.Entry(curso).State = EntityState.Modified;
            else
            {
                db.Cursoes.Add(curso);
            }

            db.SaveChanges();
            
            MessageBox.Show("Registro Salvo");
        }

        private void dgvfunc_DoubleClick(object sender, EventArgs e)
        {
            if (dgvfunc.CurrentCell.RowIndex != -1)
            {
                txbCurso.Text = "";
                txbMensalidade.Text = "";
                idCurso = Convert.ToInt32(dgvfunc.CurrentRow.Cells[0].Value);
                curso = db.Cursoes.Where(x => x.Curso_Id == idCurso).FirstOrDefault();
                txbCurso.Text = curso.Curso1;
                txbMensalidade.Text = curso.Mensalidade.ToString(); //Assim pq é Float  
            }
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer apagar este Registro ?", "Apagar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                db.Cursoes.Remove(curso);
                db.SaveChanges();

                LimparDados();
                MessageBox.Show("Registro Apagado");
            }
        }

        public void LimparDados()
        {
            txbCurso.Text = txbMensalidade.Text = string.Empty;
            btnDelete.Enabled = false;
            idCurso = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

    }
}
