namespace Ejercicio6Formularios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chBOrdenar = new System.Windows.Forms.CheckBox();
            this.chBMostrarColumnas = new System.Windows.Forms.CheckBox();
            this.txaArticulo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTrasladarIzq = new System.Windows.Forms.Button();
            this.btnSeleccionarElemento = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnTrasladarDer = new System.Windows.Forms.Button();
            this.btnAgregarDer = new System.Windows.Forms.Button();
            this.gbTipoSeleccion = new System.Windows.Forms.GroupBox();
            this.chblFrutas = new System.Windows.Forms.CheckedListBox();
            this.lbArticulosTraspasados = new System.Windows.Forms.ListBox();
            this.lbArticulos = new System.Windows.Forms.ListBox();
            this.rbtnSimple = new System.Windows.Forms.RadioButton();
            this.rbtnMultiple = new System.Windows.Forms.RadioButton();
            this.rbtnExtendido = new System.Windows.Forms.RadioButton();
            this.gbTipoSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Articulos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Articulos traspasados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frutas:";
            // 
            // chBOrdenar
            // 
            this.chBOrdenar.AutoSize = true;
            this.chBOrdenar.Location = new System.Drawing.Point(49, 246);
            this.chBOrdenar.Name = "chBOrdenar";
            this.chBOrdenar.Size = new System.Drawing.Size(83, 21);
            this.chBOrdenar.TabIndex = 3;
            this.chBOrdenar.Text = "Ordenar";
            this.chBOrdenar.UseVisualStyleBackColor = true;
            this.chBOrdenar.CheckedChanged += new System.EventHandler(this.chBOrdenar_CheckedChanged);
            // 
            // chBMostrarColumnas
            // 
            this.chBMostrarColumnas.AutoSize = true;
            this.chBMostrarColumnas.Location = new System.Drawing.Point(49, 273);
            this.chBMostrarColumnas.Name = "chBMostrarColumnas";
            this.chBMostrarColumnas.Size = new System.Drawing.Size(162, 21);
            this.chBMostrarColumnas.TabIndex = 4;
            this.chBMostrarColumnas.Text = "Mostrar en columnas";
            this.chBMostrarColumnas.UseVisualStyleBackColor = true;
            this.chBMostrarColumnas.CheckedChanged += new System.EventHandler(this.chBMostrarColumnas_CheckedChanged);
            // 
            // txaArticulo
            // 
            this.txaArticulo.Location = new System.Drawing.Point(52, 354);
            this.txaArticulo.Name = "txaArticulo";
            this.txaArticulo.Size = new System.Drawing.Size(192, 22);
            this.txaArticulo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(49, 309);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(169, 309);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTrasladarIzq
            // 
            this.btnTrasladarIzq.Location = new System.Drawing.Point(281, 268);
            this.btnTrasladarIzq.Name = "btnTrasladarIzq";
            this.btnTrasladarIzq.Size = new System.Drawing.Size(166, 44);
            this.btnTrasladarIzq.TabIndex = 8;
            this.btnTrasladarIzq.Text = "TRASPASAR>>>>>";
            this.btnTrasladarIzq.UseVisualStyleBackColor = true;
            this.btnTrasladarIzq.Click += new System.EventHandler(this.btnTrasladarIzq_Click);
            // 
            // btnSeleccionarElemento
            // 
            this.btnSeleccionarElemento.Location = new System.Drawing.Point(281, 325);
            this.btnSeleccionarElemento.Name = "btnSeleccionarElemento";
            this.btnSeleccionarElemento.Size = new System.Drawing.Size(166, 72);
            this.btnSeleccionarElemento.TabIndex = 9;
            this.btnSeleccionarElemento.Text = "Seleccionar elemento de la posicion indicada...";
            this.btnSeleccionarElemento.UseVisualStyleBackColor = true;
            this.btnSeleccionarElemento.Click += new System.EventHandler(this.btnSeleccionarElemento_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(500, 268);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 44);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnTrasladarDer
            // 
            this.btnTrasladarDer.Location = new System.Drawing.Point(690, 268);
            this.btnTrasladarDer.Name = "btnTrasladarDer";
            this.btnTrasladarDer.Size = new System.Drawing.Size(133, 44);
            this.btnTrasladarDer.TabIndex = 11;
            this.btnTrasladarDer.Text = "<<<TRASPASAR";
            this.btnTrasladarDer.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDer
            // 
            this.btnAgregarDer.Location = new System.Drawing.Point(690, 325);
            this.btnAgregarDer.Name = "btnAgregarDer";
            this.btnAgregarDer.Size = new System.Drawing.Size(133, 39);
            this.btnAgregarDer.TabIndex = 12;
            this.btnAgregarDer.Text = "AGREGAR";
            this.btnAgregarDer.UseVisualStyleBackColor = true;
            // 
            // gbTipoSeleccion
            // 
            this.gbTipoSeleccion.BackColor = System.Drawing.Color.Snow;
            this.gbTipoSeleccion.Controls.Add(this.rbtnExtendido);
            this.gbTipoSeleccion.Controls.Add(this.rbtnMultiple);
            this.gbTipoSeleccion.Controls.Add(this.rbtnSimple);
            this.gbTipoSeleccion.Location = new System.Drawing.Point(281, 93);
            this.gbTipoSeleccion.Name = "gbTipoSeleccion";
            this.gbTipoSeleccion.Size = new System.Drawing.Size(166, 149);
            this.gbTipoSeleccion.TabIndex = 13;
            this.gbTipoSeleccion.TabStop = false;
            this.gbTipoSeleccion.Text = "Tipo de seleccion";
            // 
            // chblFrutas
            // 
            this.chblFrutas.CheckOnClick = true;
            this.chblFrutas.FormattingEnabled = true;
            this.chblFrutas.Items.AddRange(new object[] {
            "Manzana",
            "Platano",
            "Pera",
            "Tomate",
            "Sandia",
            "Naranja",
            "Melon"});
            this.chblFrutas.Location = new System.Drawing.Point(690, 93);
            this.chblFrutas.Name = "chblFrutas";
            this.chblFrutas.Size = new System.Drawing.Size(120, 157);
            this.chblFrutas.TabIndex = 14;
            // 
            // lbArticulosTraspasados
            // 
            this.lbArticulosTraspasados.FormattingEnabled = true;
            this.lbArticulosTraspasados.ItemHeight = 16;
            this.lbArticulosTraspasados.Location = new System.Drawing.Point(500, 98);
            this.lbArticulosTraspasados.Name = "lbArticulosTraspasados";
            this.lbArticulosTraspasados.Size = new System.Drawing.Size(120, 148);
            this.lbArticulosTraspasados.TabIndex = 15;
            // 
            // lbArticulos
            // 
            this.lbArticulos.FormattingEnabled = true;
            this.lbArticulos.ItemHeight = 16;
            this.lbArticulos.Items.AddRange(new object[] {
            "Mesa",
            "Coche",
            "Libro",
            "Maceta",
            "Silla",
            "Estanteria",
            "Lampara",
            "Rotuladores",
            "Estuches",
            "Boligrafo"});
            this.lbArticulos.Location = new System.Drawing.Point(35, 94);
            this.lbArticulos.Name = "lbArticulos";
            this.lbArticulos.Size = new System.Drawing.Size(240, 148);
            this.lbArticulos.TabIndex = 16;
            // 
            // rbtnSimple
            // 
            this.rbtnSimple.AutoSize = true;
            this.rbtnSimple.Location = new System.Drawing.Point(18, 32);
            this.rbtnSimple.Name = "rbtnSimple";
            this.rbtnSimple.Size = new System.Drawing.Size(71, 21);
            this.rbtnSimple.TabIndex = 0;
            this.rbtnSimple.TabStop = true;
            this.rbtnSimple.Text = "Simple";
            this.rbtnSimple.UseVisualStyleBackColor = true;
            this.rbtnSimple.CheckedChanged += new System.EventHandler(this.rbtnSimple_CheckedChanged);
            // 
            // rbtnMultiple
            // 
            this.rbtnMultiple.AutoSize = true;
            this.rbtnMultiple.Location = new System.Drawing.Point(18, 68);
            this.rbtnMultiple.Name = "rbtnMultiple";
            this.rbtnMultiple.Size = new System.Drawing.Size(77, 21);
            this.rbtnMultiple.TabIndex = 1;
            this.rbtnMultiple.TabStop = true;
            this.rbtnMultiple.Text = "Multiple";
            this.rbtnMultiple.UseVisualStyleBackColor = true;
            // 
            // rbtnExtendido
            // 
            this.rbtnExtendido.AutoSize = true;
            this.rbtnExtendido.Location = new System.Drawing.Point(18, 107);
            this.rbtnExtendido.Name = "rbtnExtendido";
            this.rbtnExtendido.Size = new System.Drawing.Size(91, 21);
            this.rbtnExtendido.TabIndex = 2;
            this.rbtnExtendido.TabStop = true;
            this.rbtnExtendido.Text = "Extendido";
            this.rbtnExtendido.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(854, 420);
            this.Controls.Add(this.lbArticulos);
            this.Controls.Add(this.lbArticulosTraspasados);
            this.Controls.Add(this.chblFrutas);
            this.Controls.Add(this.gbTipoSeleccion);
            this.Controls.Add(this.btnAgregarDer);
            this.Controls.Add(this.btnTrasladarDer);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSeleccionarElemento);
            this.Controls.Add(this.btnTrasladarIzq);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txaArticulo);
            this.Controls.Add(this.chBMostrarColumnas);
            this.Controls.Add(this.chBOrdenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTipoSeleccion.ResumeLayout(false);
            this.gbTipoSeleccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chBOrdenar;
        private System.Windows.Forms.CheckBox chBMostrarColumnas;
        private System.Windows.Forms.TextBox txaArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTrasladarIzq;
        private System.Windows.Forms.Button btnSeleccionarElemento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnTrasladarDer;
        private System.Windows.Forms.Button btnAgregarDer;
        private System.Windows.Forms.GroupBox gbTipoSeleccion;
        private System.Windows.Forms.CheckedListBox chblFrutas;
        private System.Windows.Forms.ListBox lbArticulosTraspasados;
        private System.Windows.Forms.ListBox lbArticulos;
        private System.Windows.Forms.RadioButton rbtnExtendido;
        private System.Windows.Forms.RadioButton rbtnMultiple;
        private System.Windows.Forms.RadioButton rbtnSimple;
    }
}

