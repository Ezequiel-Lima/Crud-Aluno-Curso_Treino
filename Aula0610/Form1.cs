using Aula0610.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula0610
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        ConexaoBD db = new ConexaoBD();
        Curso curso = new Curso();
        Instrutor instrutor = new Instrutor();
        int idInstrutor = 0;
        int idCurso = 0;

        public void SetDataInGridView()
        {
           dgvfunc.DataSource = db.Cursoes.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aulaCast061021DataSet1.Instrutor' table. You can move, or remove it, as needed.
            this.instrutorTableAdapter.Fill(this.aulaCast061021DataSet1.Instrutor);
            // TODO: This line of code loads data into the 'aulaCast061021DataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.aulaCast061021DataSet.Curso);
            SetDataInGridView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            curso.Curso1 = txbCurso.Text.Trim();
            curso.Mensalidade = Convert.ToInt32(txbMensalidade.Text.Trim());
         
            if (idCurso > 0)
            {
                //inserir o using System.Data.Entity por causa do EntityState
                db.Entry(curso).State = EntityState.Modified;
            }
            else
            {
                db.Cursoes.Add(curso);
            }

            db.SaveChanges();
            SetDataInGridView();

            MessageBox.Show("Registro Salvo");
        }

        private void dgvfunc_DoubleClick(object sender, EventArgs e)
        {
            if (dgvfunc.CurrentCell.RowIndex != -1)
            {
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

        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            instrutor.Instrutor1 = txbProfessor.Text.Trim();

            if (idInstrutor > 0)
                //inserir o using System.Data.Entity por causa do EntityState
                db.Entry(instrutor).State = EntityState.Modified;
            else
            {
                db.Instrutors.Add(instrutor);
            }

            db.SaveChanges();

            MessageBox.Show("Registro Salvo");
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer apagar este Registro ?", "Apagar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                db.Instrutors.Remove(instrutor);
                db.SaveChanges();

                LimparDados();
                MessageBox.Show("Registro Apagado");
            }
        }

        private void Cancelar2_Click(object sender, EventArgs e)
        {
            txbProfessor.Text = string.Empty;
            btnDelete2.Enabled = false;
            idInstrutor = 0;
        }

        private void dgvfunc2_DoubleClick(object sender, EventArgs e)
        {
            if (dgvfunc2.CurrentCell.RowIndex != -1)
            {
                txbProfessor.Text = "";
                idInstrutor = Convert.ToInt32(dgvfunc2.CurrentRow.Cells[0].Value);
                instrutor = db.Instrutors.Where(x => x.Instrutor_Id == idInstrutor).FirstOrDefault();
                txbProfessor.Text = instrutor.Instrutor1;   
            }
            btnDelete2.Enabled = true;
        }

    }
}
