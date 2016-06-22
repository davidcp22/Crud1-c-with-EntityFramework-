namespace Crud
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gtSalida = new System.Windows.Forms.DataGridView();
            this.btnRegsitrar = new System.Windows.Forms.Button();
            this.RegType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gtSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // gtSalida
            // 
            this.gtSalida.AllowUserToAddRows = false;
            this.gtSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gtSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegType,
            this.RegStatus});
            this.gtSalida.Location = new System.Drawing.Point(12, 12);
            this.gtSalida.Name = "gtSalida";
            this.gtSalida.Size = new System.Drawing.Size(717, 251);
            this.gtSalida.TabIndex = 0;
            this.gtSalida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gtSalida.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gtSalida_CellEndEdit);
            // 
            // btnRegsitrar
            // 
            this.btnRegsitrar.Location = new System.Drawing.Point(12, 279);
            this.btnRegsitrar.Name = "btnRegsitrar";
            this.btnRegsitrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegsitrar.TabIndex = 1;
            this.btnRegsitrar.Text = "Nuevo";
            this.btnRegsitrar.UseVisualStyleBackColor = true;
            this.btnRegsitrar.Click += new System.EventHandler(this.btnRegsitrar_Click);
            // 
            // RegType
            // 
            this.RegType.HeaderText = "RegType";
            this.RegType.Name = "RegType";
            // 
            // RegStatus
            // 
            this.RegStatus.HeaderText = "RegStatus";
            this.RegStatus.Name = "RegStatus";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(93, 279);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 343);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegsitrar);
            this.Controls.Add(this.gtSalida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gtSalida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gtSalida;
        private System.Windows.Forms.Button btnRegsitrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuardar;
    }
}

