using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> Tasks = new List<string>();

        private void RefreshDataGridView()
        {
            //Remove all previous tasks from dataGridView
            dataGridView1.Rows.Clear();

            //Adding tasks to dataGridView
            for (int i = 0; i < Tasks.Count; i++)
            {
                dataGridView1.Rows.Add(Tasks[i]);
            }
        }

        private void btn_SubmitTask_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
            {
                MessageBox.Show("Nu poti crea un task cu mai putin de 4 caractere!");
                return;
            }

            //Keep the current textBox value in a variable named "task"
            string task = textBox1.Text;


            //Add that variable to the list
            Tasks.Add(task);


            //Empty the txtBox value
            textBox1.Clear();

            RefreshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tasks.Count < 1)
            {
                MessageBox.Show("Task-uri insuficiente!", "Eroare!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                return;
            }

            Tasks.RemoveAt(Tasks.Count - 1);
            MessageBox.Show("Ultimul task adaugat a fost sters cu succes.", "Succes!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            RefreshDataGridView();
        }

    }
}
