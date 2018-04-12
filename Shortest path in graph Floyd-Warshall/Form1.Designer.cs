namespace Shortest_path_in_graph_Floyd_Warshall
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInsertVertex = new System.Windows.Forms.TextBox();
            this.buttonBuildMatrix = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDeleteGraph = new System.Windows.Forms.Button();
            this.textBoxInsertMoreVertex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInsertMoreVertex = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonRandomValues = new System.Windows.Forms.Button();
            this.buttonShowGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 55;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(410, 385);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 55;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(389, 267);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кратчайший путь в графе (Алгоритм Флойда-Уоршелла)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Матрица расстояний";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кол-во вершин графа:";
            // 
            // textBoxInsertVertex
            // 
            this.textBoxInsertVertex.Location = new System.Drawing.Point(12, 80);
            this.textBoxInsertVertex.Name = "textBoxInsertVertex";
            this.textBoxInsertVertex.Size = new System.Drawing.Size(155, 22);
            this.textBoxInsertVertex.TabIndex = 5;
            // 
            // buttonBuildMatrix
            // 
            this.buttonBuildMatrix.Location = new System.Drawing.Point(12, 108);
            this.buttonBuildMatrix.Name = "buttonBuildMatrix";
            this.buttonBuildMatrix.Size = new System.Drawing.Size(155, 56);
            this.buttonBuildMatrix.TabIndex = 6;
            this.buttonBuildMatrix.Text = "Построить граф";
            this.buttonBuildMatrix.UseVisualStyleBackColor = true;
            this.buttonBuildMatrix.Click += new System.EventHandler(this.buttonBuildMatrix_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(59, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 106);
            this.button1.TabIndex = 9;
            this.button1.Text = "Найти кратчайший путь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeleteGraph
            // 
            this.buttonDeleteGraph.Location = new System.Drawing.Point(12, 185);
            this.buttonDeleteGraph.Name = "buttonDeleteGraph";
            this.buttonDeleteGraph.Size = new System.Drawing.Size(155, 56);
            this.buttonDeleteGraph.TabIndex = 10;
            this.buttonDeleteGraph.Text = "Удалить граф";
            this.buttonDeleteGraph.UseVisualStyleBackColor = true;
            this.buttonDeleteGraph.Click += new System.EventHandler(this.buttonDeleteGraph_Click);
            // 
            // textBoxInsertMoreVertex
            // 
            this.textBoxInsertMoreVertex.Location = new System.Drawing.Point(197, 80);
            this.textBoxInsertMoreVertex.Name = "textBoxInsertMoreVertex";
            this.textBoxInsertMoreVertex.Size = new System.Drawing.Size(155, 22);
            this.textBoxInsertMoreVertex.TabIndex = 11;
            this.textBoxInsertMoreVertex.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Добавить доп. вершины";
            this.label4.Visible = false;
            // 
            // buttonInsertMoreVertex
            // 
            this.buttonInsertMoreVertex.Location = new System.Drawing.Point(197, 108);
            this.buttonInsertMoreVertex.Name = "buttonInsertMoreVertex";
            this.buttonInsertMoreVertex.Size = new System.Drawing.Size(155, 56);
            this.buttonInsertMoreVertex.TabIndex = 15;
            this.buttonInsertMoreVertex.Text = "Добавить вершины";
            this.buttonInsertMoreVertex.UseVisualStyleBackColor = true;
            this.buttonInsertMoreVertex.Visible = false;
            this.buttonInsertMoreVertex.Click += new System.EventHandler(this.buttonInsertMoreVertex_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(834, 27);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 24);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(108, 24);
            this.toolStripButton1.Text = "О программе";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonRandomValues
            // 
            this.buttonRandomValues.Location = new System.Drawing.Point(59, 274);
            this.buttonRandomValues.Name = "buttonRandomValues";
            this.buttonRandomValues.Size = new System.Drawing.Size(266, 64);
            this.buttonRandomValues.TabIndex = 17;
            this.buttonRandomValues.Text = "Случайные значения";
            this.buttonRandomValues.UseVisualStyleBackColor = true;
            this.buttonRandomValues.Click += new System.EventHandler(this.buttonRandomValues_Click);
            // 
            // buttonShowGraph
            // 
            this.buttonShowGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowGraph.Location = new System.Drawing.Point(59, 473);
            this.buttonShowGraph.Name = "buttonShowGraph";
            this.buttonShowGraph.Size = new System.Drawing.Size(266, 161);
            this.buttonShowGraph.TabIndex = 18;
            this.buttonShowGraph.Text = "Визуализация графа";
            this.buttonShowGraph.UseVisualStyleBackColor = true;
            this.buttonShowGraph.Click += new System.EventHandler(this.buttonShowGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 665);
            this.Controls.Add(this.buttonShowGraph);
            this.Controls.Add(this.buttonRandomValues);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonInsertMoreVertex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxInsertMoreVertex);
            this.Controls.Add(this.buttonDeleteGraph);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBuildMatrix);
            this.Controls.Add(this.textBoxInsertVertex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Finding shortest path in graph Floyd-Warshall algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInsertVertex;
        private System.Windows.Forms.Button buttonBuildMatrix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDeleteGraph;
        private System.Windows.Forms.TextBox textBoxInsertMoreVertex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonInsertMoreVertex;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRandomValues;
        private System.Windows.Forms.Button buttonShowGraph;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

