
namespace Aula0610
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.txbCurso = new System.Windows.Forms.TextBox();
            this.txbMensalidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvfunc = new System.Windows.Forms.DataGridView();
            this.Curso_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulaCast061021DataSet = new Aula0610.AulaCast061021DataSet();
            this.cursoTableAdapter = new Aula0610.AulaCast061021DataSetTableAdapters.CursoTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbProfessor = new System.Windows.Forms.TextBox();
            this.btnSalvar2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.Cancelar2 = new System.Windows.Forms.Button();
            this.dgvfunc2 = new System.Windows.Forms.DataGridView();
            this.instrutorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulaCast061021DataSet1 = new Aula0610.AulaCast061021DataSet1();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.instrutorTableAdapter = new Aula0610.AulaCast061021DataSet1TableAdapters.InstrutorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaCast061021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaCast061021DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCurso
            // 
            this.txbCurso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txbCurso.Location = new System.Drawing.Point(90, 22);
            this.txbCurso.Name = "txbCurso";
            this.txbCurso.Size = new System.Drawing.Size(569, 26);
            this.txbCurso.TabIndex = 0;
            this.txbCurso.Tag = "";
            this.txbCurso.Text = "Curso";
            // 
            // txbMensalidade
            // 
            this.txbMensalidade.ForeColor = System.Drawing.Color.OliveDrab;
            this.txbMensalidade.Location = new System.Drawing.Point(90, 62);
            this.txbMensalidade.Name = "txbMensalidade";
            this.txbMensalidade.Size = new System.Drawing.Size(569, 26);
            this.txbMensalidade.TabIndex = 1;
            this.txbMensalidade.Text = "Mensalidade";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(24, 106);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(211, 37);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(241, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(458, 106);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(201, 37);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvfunc
            // 
            this.dgvfunc.AllowUserToAddRows = false;
            this.dgvfunc.AllowUserToDeleteRows = false;
            this.dgvfunc.AutoGenerateColumns = false;
            this.dgvfunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Curso_Id,
            this.cursoDataGridViewTextBoxColumn,
            this.mensalidadeDataGridViewTextBoxColumn});
            this.dgvfunc.DataSource = this.cursoBindingSource;
            this.dgvfunc.Location = new System.Drawing.Point(24, 161);
            this.dgvfunc.Name = "dgvfunc";
            this.dgvfunc.ReadOnly = true;
            this.dgvfunc.RowHeadersWidth = 62;
            this.dgvfunc.RowTemplate.Height = 28;
            this.dgvfunc.Size = new System.Drawing.Size(635, 291);
            this.dgvfunc.TabIndex = 5;
            this.dgvfunc.DoubleClick += new System.EventHandler(this.dgvfunc_DoubleClick);
            // 
            // Curso_Id
            // 
            this.Curso_Id.DataPropertyName = "Curso_Id";
            this.Curso_Id.HeaderText = "Curso_Id";
            this.Curso_Id.MinimumWidth = 8;
            this.Curso_Id.Name = "Curso_Id";
            this.Curso_Id.ReadOnly = true;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            this.cursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mensalidadeDataGridViewTextBoxColumn
            // 
            this.mensalidadeDataGridViewTextBoxColumn.DataPropertyName = "Mensalidade";
            this.mensalidadeDataGridViewTextBoxColumn.HeaderText = "Mensalidade";
            this.mensalidadeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mensalidadeDataGridViewTextBoxColumn.Name = "mensalidadeDataGridViewTextBoxColumn";
            this.mensalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.aulaCast061021DataSet;
            // 
            // aulaCast061021DataSet
            // 
            this.aulaCast061021DataSet.DataSetName = "AulaCast061021DataSet";
            this.aulaCast061021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // txbProfessor
            // 
            this.txbProfessor.ForeColor = System.Drawing.Color.OliveDrab;
            this.txbProfessor.Location = new System.Drawing.Point(90, 480);
            this.txbProfessor.Name = "txbProfessor";
            this.txbProfessor.Size = new System.Drawing.Size(569, 26);
            this.txbProfessor.TabIndex = 1;
            this.txbProfessor.Text = "Professor";
            // 
            // btnSalvar2
            // 
            this.btnSalvar2.Location = new System.Drawing.Point(24, 524);
            this.btnSalvar2.Name = "btnSalvar2";
            this.btnSalvar2.Size = new System.Drawing.Size(211, 37);
            this.btnSalvar2.TabIndex = 2;
            this.btnSalvar2.Text = "Salvar";
            this.btnSalvar2.UseVisualStyleBackColor = true;
            this.btnSalvar2.Click += new System.EventHandler(this.btnSalvar2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Enabled = false;
            this.btnDelete2.Location = new System.Drawing.Point(241, 524);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(211, 37);
            this.btnDelete2.TabIndex = 3;
            this.btnDelete2.Text = "Delete";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // Cancelar2
            // 
            this.Cancelar2.Location = new System.Drawing.Point(458, 524);
            this.Cancelar2.Name = "Cancelar2";
            this.Cancelar2.Size = new System.Drawing.Size(201, 37);
            this.Cancelar2.TabIndex = 4;
            this.Cancelar2.Text = "Cancelar";
            this.Cancelar2.UseVisualStyleBackColor = true;
            this.Cancelar2.Click += new System.EventHandler(this.Cancelar2_Click);
            // 
            // dgvfunc2
            // 
            this.dgvfunc2.AllowUserToAddRows = false;
            this.dgvfunc2.AllowUserToDeleteRows = false;
            this.dgvfunc2.AutoGenerateColumns = false;
            this.dgvfunc2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfunc2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfunc2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instrutorIdDataGridViewTextBoxColumn,
            this.instrutorDataGridViewTextBoxColumn});
            this.dgvfunc2.DataSource = this.instrutorBindingSource;
            this.dgvfunc2.Location = new System.Drawing.Point(24, 579);
            this.dgvfunc2.Name = "dgvfunc2";
            this.dgvfunc2.ReadOnly = true;
            this.dgvfunc2.RowHeadersWidth = 62;
            this.dgvfunc2.RowTemplate.Height = 28;
            this.dgvfunc2.Size = new System.Drawing.Size(635, 291);
            this.dgvfunc2.TabIndex = 5;
            this.dgvfunc2.DoubleClick += new System.EventHandler(this.dgvfunc2_DoubleClick);
            // 
            // instrutorIdDataGridViewTextBoxColumn
            // 
            this.instrutorIdDataGridViewTextBoxColumn.DataPropertyName = "Instrutor_Id";
            this.instrutorIdDataGridViewTextBoxColumn.HeaderText = "Instrutor_Id";
            this.instrutorIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.instrutorIdDataGridViewTextBoxColumn.Name = "instrutorIdDataGridViewTextBoxColumn";
            this.instrutorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // instrutorDataGridViewTextBoxColumn
            // 
            this.instrutorDataGridViewTextBoxColumn.DataPropertyName = "Instrutor";
            this.instrutorDataGridViewTextBoxColumn.HeaderText = "Instrutor";
            this.instrutorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.instrutorDataGridViewTextBoxColumn.Name = "instrutorDataGridViewTextBoxColumn";
            this.instrutorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // instrutorBindingSource
            // 
            this.instrutorBindingSource.DataMember = "Instrutor";
            this.instrutorBindingSource.DataSource = this.aulaCast061021DataSet1;
            // 
            // aulaCast061021DataSet1
            // 
            this.aulaCast061021DataSet1.DataSetName = "AulaCast061021DataSet1";
            this.aulaCast061021DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(27, 475);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // instrutorTableAdapter
            // 
            this.instrutorTableAdapter.ClearBeforeFill = true;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 893);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvfunc2);
            this.Controls.Add(this.Cancelar2);
            this.Controls.Add(this.dgvfunc);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txbProfessor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbMensalidade);
            this.Controls.Add(this.txbCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula0610";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaCast061021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaCast061021DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbCurso;
        private System.Windows.Forms.TextBox txbMensalidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvfunc;
        private AulaCast061021DataSet aulaCast061021DataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private AulaCast061021DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txbProfessor;
        private System.Windows.Forms.Button btnSalvar2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button Cancelar2;
        private System.Windows.Forms.DataGridView dgvfunc2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private AulaCast061021DataSet1 aulaCast061021DataSet1;
        private System.Windows.Forms.BindingSource instrutorBindingSource;
        private AulaCast061021DataSet1TableAdapters.InstrutorTableAdapter instrutorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrutorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrutorDataGridViewTextBoxColumn;
    }
}

