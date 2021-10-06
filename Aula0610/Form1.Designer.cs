
namespace Aula0610
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMensalidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvfunc = new System.Windows.Forms.DataGridView();
            this.aulaCast061021DataSet = new Aula0610.AulaCast061021DataSet();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Aula0610.AulaCast061021DataSetTableAdapters.CursoTableAdapter();
            this.cursoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaCast061021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // txbCurso
            // 
            this.txbCurso.Location = new System.Drawing.Point(151, 22);
            this.txbCurso.Name = "txbCurso";
            this.txbCurso.Size = new System.Drawing.Size(508, 26);
            this.txbCurso.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mensalidade";
            // 
            // txbMensalidade
            // 
            this.txbMensalidade.Location = new System.Drawing.Point(151, 62);
            this.txbMensalidade.Name = "txbMensalidade";
            this.txbMensalidade.Size = new System.Drawing.Size(508, 26);
            this.txbMensalidade.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(151, 108);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(171, 37);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(328, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(505, 108);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 37);
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
            this.cursoIdDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn,
            this.mensalidadeDataGridViewTextBoxColumn});
            this.dgvfunc.DataSource = this.cursoBindingSource;
            this.dgvfunc.Location = new System.Drawing.Point(24, 166);
            this.dgvfunc.Name = "dgvfunc";
            this.dgvfunc.ReadOnly = true;
            this.dgvfunc.RowHeadersWidth = 62;
            this.dgvfunc.RowTemplate.Height = 28;
            this.dgvfunc.Size = new System.Drawing.Size(635, 269);
            this.dgvfunc.TabIndex = 5;
            this.dgvfunc.DoubleClick += new System.EventHandler(this.dgvfunc_DoubleClick);
            // 
            // aulaCast061021DataSet
            // 
            this.aulaCast061021DataSet.DataSetName = "AulaCast061021DataSet";
            this.aulaCast061021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.aulaCast061021DataSet;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // cursoIdDataGridViewTextBoxColumn
            // 
            this.cursoIdDataGridViewTextBoxColumn.DataPropertyName = "Curso_Id";
            this.cursoIdDataGridViewTextBoxColumn.HeaderText = "Curso_Id";
            this.cursoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cursoIdDataGridViewTextBoxColumn.Name = "cursoIdDataGridViewTextBoxColumn";
            this.cursoIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 458);
            this.Controls.Add(this.dgvfunc);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbMensalidade);
            this.Controls.Add(this.txbCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula0610";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaCast061021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMensalidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvfunc;
        private AulaCast061021DataSet aulaCast061021DataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private AulaCast061021DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensalidadeDataGridViewTextBoxColumn;
    }
}

