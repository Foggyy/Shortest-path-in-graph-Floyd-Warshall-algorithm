using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Shortest_path_in_graph_Floyd_Warshall
{
    public partial class Form1 : Form
    {
        double[,] matrix = new double[0, 0];                                    //матрица расстояний
        private int vertex;                                                     //кол-во вершин
        

        /// <summary>
        /// Запуск формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }        

        /// <summary>
        /// Строим стандартную матрицу
        /// </summary>
        private void BuildMatrix()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                vertex = Convert.ToInt32(textBoxInsertVertex.Text);
                matrix = new double [0, 0];
                matrix = new double [vertex, vertex];
                int columns = 0;

                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        matrix[i, j] = 0;                                       //присваиваем всем ячейкам матрицы значение 0                        
                    }
                }

                while (columns < vertex)                                        //добавление столбцов в DataGrid
                {
                    dataGridView1.Columns.Add(columns.ToString(), columns.ToString());
                    columns++;
                }

                dataGridView1.AllowUserToAddRows = false;                       //запрет на добавление строк из DataGrid
                dataGridView1.Rows.Add(vertex);
                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        dataGridView1[i, j].Value = matrix[i, j];
                        dataGridView1[i, i].Style.BackColor = Color.Gray;
                        dataGridView1[i, i].Value = 0;
                        dataGridView1[i, i].ReadOnly = true;
                        dataGridView1.Columns[i].Width = 40;                    //задаем ширину столбца
                        dataGridView1.Rows[i].HeaderCell.Value =
                            i.ToString();                                       //присваиваем заголовок строке                       
                    }
                }

                label4.Visible = true;
                textBoxInsertMoreVertex.Visible = true;
                buttonInsertMoreVertex.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целое число.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Введите число больше 0.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Введите положительное число.");
            }
        }

        /// <summary>
        /// Пересоздание DataGrid после открытия файла
        /// </summary>
        private void DataGridRecreation()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                int columns = 0;
                while (columns < vertex)                                                //добавление столбцов в DataGrid
                {
                    dataGridView1.Columns.Add(columns.ToString(), columns.ToString());
                    columns++;
                }
                dataGridView1.Rows.Add(vertex);
                dataGridView1.AllowUserToAddRows = false;                               //запрет на добавление строк из DataGrid
                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        dataGridView1[i, j].Value = matrix[i, j];
                        dataGridView1[i, i].Style.BackColor = Color.Gray;
                        dataGridView1[i, i].Value = 0;
                        dataGridView1[i, i].ReadOnly = true;
                        dataGridView1.Columns[i].Width = 40;                            //задаем ширину столбца
                        dataGridView1.Rows[i].HeaderCell.Value =
                            i.ToString();                                               //присваиваем заголовок строке                       
                    }
                }
                label4.Visible = true;
                textBoxInsertMoreVertex.Visible = true;
                buttonInsertMoreVertex.Visible = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Файл пуст");
            }
            
        }

        /// <summary>
        /// Построение матрицы кратчайших расстояний
        /// </summary>
        private void BuildShortMatrix()
        {
            try
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();
                double[,] matrix2 = new double[vertex, vertex];                        //матрица для вывода кратчайших расстояний
                int columns = 0;

                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        matrix2[i, j] = matrix[i, j];
                    }
                }
                while (columns < vertex)                                               //добавление столбцов в DataGrid
                {
                    dataGridView2.Columns.Add(columns.ToString(), columns.ToString());
                    columns++;
                }
                dataGridView2.AllowUserToAddRows = false;                             //запрет на добавление строк из DataGrid
                dataGridView2.Rows.Add(vertex);
                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        dataGridView2[i, j].Value = matrix2[i, j];
                        dataGridView2[i, i].Style.BackColor = Color.Gray;
                        dataGridView2[i, i].Value = 0;
                        dataGridView2[i, i].ReadOnly = true;
                        dataGridView2.Columns[i].Width = 40;                          //задаем ширину столбца
                        dataGridView2.Rows[i].HeaderCell.Value = i.ToString();        //присваиваем заголовок строке
                    }
                }

                for (int k = 0; k < vertex; ++k)
                {
                    for (int i = 0; i < vertex; i++)
                    {
                        for (int j = 0; j < vertex; j++)
                        {
                            if (matrix2[i, k] * matrix2[k, j] != 0 && i != j)
                                if (matrix2[i, k] + matrix2[k, j] < matrix2[i, j])
                                {
                                    matrix2[i, j] = matrix2[i, k] + matrix2[k, j];
                                    dataGridView2[i, j].Value = matrix2[i, j];
                                }
                        }
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Создайте матрицу расстояний.");
            }
            
        }

        /// <summary>
        /// Задаем случайные значения
        /// </summary>
        private void RandomValues()
        {
            Random rand = new Random();
            for (int i = 0; i < vertex; i++)
            {
                for (int j=0; j < vertex; j++)
                {
                    matrix[i, j] = rand.Next(0, 100);
                }
            }
            for (int i = 0; i < vertex; i++)
            {
                for (int j = 0; j < vertex; j++)
                {
                    dataGridView1[i, j].Value = matrix[i, j];
                    dataGridView1[i, i].Style.BackColor = Color.Gray;
                    dataGridView1[i, i].Value = 0;
                    dataGridView1[i, i].ReadOnly = true;
                    dataGridView1.Columns[i].Width = 40;                                    //задаем ширину столбца
                    dataGridView1.Rows[i].HeaderCell.Value = i.ToString();                  //присваиваем заголовок строке
                }
            }
        }


        /// <summary>
        /// Кнопка "Построить граф"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildMatrix_Click(object sender, EventArgs e)
        {
            BuildMatrix();            
        }

        /// <summary>
        /// Кнопка "Найти кратчайшие расстояния"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BuildShortMatrix();
        }

        /// <summary>
        /// В матрице расстояний поменялось значение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            try
            {

                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {

                        if (i == e.ColumnIndex && j == e.RowIndex)                          //если цикл дошел до измененной ячейки
                        {
                            matrix[e.ColumnIndex, e.RowIndex] = Convert.ToDouble(dataGridView1[e.ColumnIndex, e.RowIndex].Value);    //присваиваем матрице значение измененной ячейки
                            if (matrix[e.ColumnIndex, e.RowIndex] < 1)
                            {
                                matrix[e.ColumnIndex, e.RowIndex] = 0;
                                dataGridView1[e.ColumnIndex, e.RowIndex].Value = 0;
                            }
                        }                                                                                                                           
                    }
                }

            }
            catch (FormatException)                                                         //если введено не число
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = 0;
                flag = false;
            }
            if (flag)
            {
                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        if (i == e.ColumnIndex && j == e.RowIndex)                                                               //если цикл дошел до измененной ячейки
                        {
                            matrix[e.RowIndex, e.ColumnIndex] = Convert.ToDouble(dataGridView1[e.ColumnIndex, e.RowIndex].Value); //присваиваем параллельной ячейке матрицы значение измененной ячейки   
                            dataGridView1[e.RowIndex, e.ColumnIndex].Value = dataGridView1[e.ColumnIndex, e.RowIndex].Value;     //присваиваем параллельной ячейке таблицы значение измененной ячейки      
                        }
                            
                    }
                }
                
            }
        }

        /// <summary>
        /// Удалить граф
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteGraph_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            matrix = null;
            vertex = 0;
            MessageBox.Show("Граф удален");
        }

        /// <summary>
        /// Добавить еще вершин в матрицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertMoreVertex_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] matrix2 = new double[vertex,vertex];
                int Supvertex = vertex;
                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        matrix2[i, j] = matrix[i, j];
                    }
                }               
                vertex = vertex + Convert.ToInt32(textBoxInsertMoreVertex.Text);

                matrix = new double [vertex, vertex];

                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        if (i < Supvertex && j < Supvertex)
                            matrix[i, j] = matrix2[i, j];
                        else
                            matrix[i, j] = 0;
                    }
                }
                int columns = Supvertex;
                while (columns < vertex)                                                        //добавление столбцов в DataGrid
                {
                    dataGridView1.Columns.Add(columns.ToString(), columns.ToString());
                    columns++;
                }
               
                dataGridView1.Rows.Add(vertex - Supvertex);
                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        dataGridView1[i, j].Value = matrix[i, j];
                        dataGridView1[i, i].Style.BackColor = Color.Gray;
                        dataGridView1[i, i].Value = 0;
                        dataGridView1[i, i].ReadOnly = true;
                        dataGridView1.Columns[i].Width = 40;                                    //задаем ширину столбца
                        dataGridView1.Rows[i].HeaderCell.Value = i.ToString();                  //присваиваем заголовок строке                       
                    }
                }              
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целое число");
            }
            
        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        private void SaveFile()
        {
            if (vertex == 0)
            {
                MessageBox.Show("Массив пуст. Сохранять нечего.");
            }
            else
            {
                string path = Directory.GetCurrentDirectory();
                SaveFileDialog saveFileDialog1 = new SaveFileDialog()
                {
                    AddExtension = true,
                    DefaultExt = "MatrixData",
                    Filter = "Матрица(*.MatrixData)|*MatrixData",
                    FilterIndex = 0,
                    InitialDirectory = path,
                };
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)                                    //показываем диалог открытия (если выбран файл, то)
                {
                    FileStream Stream = new FileStream(saveFileDialog1.FileName, FileMode.Create);      //открываем поток (прямой доступ к файлу, поток байтов)
                    BinaryFormatter bf = new BinaryFormatter();                                         //сериализирует массив в двоичном формате
                    bf.Serialize(Stream, matrix);                                                       //сериализуем массив (сохраняем массив в потоке)
                    bf.Serialize(Stream, vertex);                                                       //сериализуем кол-во вершин (сохраняем кол-во в потоке)          
                    Stream.Close();                                                                     //закрываем поток
                    MessageBox.Show("Объекты сохранены.");
                }
            }
            
        }

        /// <summary>
        /// Открытие файла
        /// </summary>
        private void OpenFile()
        {
            string path = Directory.GetCurrentDirectory();
            openFileDialog1 = new OpenFileDialog()
            {
                AddExtension = true,
                DefaultExt = "MatrixData",
                Filter = "Матрица(*.MatrixData)|*MatrixData",
                FilterIndex = 0,
                RestoreDirectory = false,
                InitialDirectory = path,
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)                                    //показываем диалог открытия (если выбран файл, то)
            {
                FileStream Stream = new FileStream(openFileDialog1.FileName, FileMode.Open);        //открываем поток (прямой доступ к файлу, поток байтов)
                BinaryFormatter bf = new BinaryFormatter();                                         //сериализирует массив в двоичном формате     
                matrix = (double[,])bf.Deserialize(Stream);                                            //десериализуем массив
                vertex = (int) bf.Deserialize(Stream);                                              //десериализуем кол-во вершин
                DataGridRecreation();                                                               //обновляем таблицу
                Stream.Close();                                                                     //закрываем поток
            }
        }

        /// <summary>
        /// Кнопка "Открыть файл"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        /// <summary>
        /// Кнопка "Сохранить файл"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        /// <summary>
        /// Кнопка "Случайные значения"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandomValues_Click(object sender, EventArgs e)
        {
            RandomValues();
        }

        /// <summary>
        /// Визуализация графа
        /// </summary>
        private void CreateGraph()
        {
            if (vertex > 0)
            {
                System.Windows.Forms.Form form = new System.Windows.Forms.Form();
                Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");


                for (int i = 0; i < vertex; i++)                                                                        //циклы для прохода по массиву
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        if (matrix[i, j] > 0)
                        {
                            graph.AddEdge(Convert.ToString(i), Convert.ToString(j)).Attr.Color =                        //добавление ребра и смена цвета
                                Microsoft.Msagl.Drawing.Color.ForestGreen;
                            graph.FindNode(Convert.ToString(i)).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Teal;    //смена цвета вершины
                        }
                    }
                }
                viewer.Graph = graph;                                   //отображение выбранного графа
                form.SuspendLayout();                                   //приостанавливаем логику макета для добавления панели управления
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;      //возвращает границы элемента управления
                form.Controls.Add(viewer);                              //добавляем панель управления
                form.ResumeLayout();                                    //возобновляем логику макета
                form.ShowDialog();                                      //показать форму
            }
            else
            {
                MessageBox.Show("Задайте количество вершин");
            }
           
        }

        /// <summary>
        /// Кнопка "Визуализация графа"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowGraph_Click(object sender, EventArgs e)
        {
            CreateGraph();
        }

        /// <summary>
        /// Кнопка "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AboutProgram Form2 = new AboutProgram();
            Form2.Show();
        }
    }

    


}
