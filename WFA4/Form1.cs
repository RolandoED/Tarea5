using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WFA4
{
    public partial class Form1 : Form
    {
     
        //Asignaciones de Tarea
        //**1 - Agregar **modificar              hecho
        //**2 - Eliminar por cedula              hecho
        //**3 - Busqueda por cedula              hecho
        //**    - Buscar muestra en los textbox  hecho
        //**4 - fecha nacimiento                 hecho
        private static string _FieldsToSelect = " cedula as 'Cédula', nombre as 'Nombre', apellido as 'Apellido', ubicacion as 'Ubicación', telefono as 'Teléfono', fechanacimiento as 'Fecha Nac' ";
        private void ShowMessage(string s)
        {
            MessageBox.Show(s, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void reloadGridView() {
            string sqlquery;
            string conexion = "Data Source=(local); " +
                "Initial Catalog=bd_empresa;" +
                "Integrated Security=True;";
            //'User ID=UserName;Password=Password;
            DataTable dt = new DataTable();
            sqlquery = "select " + _FieldsToSelect + " from empleado";
            SqlConnection sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlquery, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlquery;
            string conexion = "Data Source=(local); " +
                "Initial Catalog=bd_empresa;" +
                "Integrated Security=True;"; 
            //'User ID=UserName;Password=Password;
            DataTable dt = new DataTable();
            sqlquery = "select " + _FieldsToSelect + " from empleado";
            SqlConnection sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlquery, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            string conexion = "Data Source=(local);" +
                "Initial Catalog=bd_empresa;" +
                "Integrated Security=True;";
            string sqlquery;
            //'User ID=UserName;Password=Password;
            SqlConnection sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            
            DataTable dt = new DataTable();
           
            sqlquery = "insert into empleado (" +
                "cedula," +
                "nombre," +
                "apellido," +
                "ubicacion," +
                "telefono," +
                "fechanacimiento" +
                ") values (" +
                "'" + textBox1.Text + "'," +
                "'" + textBox2.Text + "'," +
                "'" + textBox3.Text + "'," +
                "'" + textBox4.Text + "'," +
                "'" + textBox5.Text + "'," +
                "'" + textBox6.Text + "')";
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sqlquery;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            sqlquery = "select cedula as 'Cédula', nombre as 'Nombre', apellido as 'Apellido', ubicacion as 'Ubicación', telefono as 'Teléfono', fechanacimiento as 'Fecha Nac' from empleado";
            sqlconn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlquery, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    ShowMessage("Ya existe un Empleado con el ID "+textBox1.Text);
                }
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Data);
                Console.WriteLine(ex.Message);

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //TextBox1.Text = DataGridView1(0, DataGridView1.CurrentRow.Index).Value
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DELETE FROM Customers
            //WHERE CustomerName='Alfreds Futterkiste' AND ContactName='Maria Anders';
            try
            {
                if (!textBox1.Text.Equals(""))
                {
                    string conexion =
                    "Data Source=(local);" +
                    "Initial Catalog=bd_empresa;" +
                    "Integrated Security=True;";
                    string sqlquery;
                    //'User ID=UserName;Password=Password;
                    SqlConnection sqlconn = new SqlConnection(conexion);
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand();
                    DataTable dt = new DataTable();
                    sqlquery =
                    "DELETE FROM EMPLEADO WHERE " +
                    "cedula = " + textBox1.Text + ";";

                    sqlcomm.Connection = sqlconn;
                    sqlcomm.CommandText = sqlquery;
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                    sqlquery = "select " + _FieldsToSelect + " from empleado";
                    sqlconn.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter(sqlquery, sqlconn);
                    sqlda.Fill(dt);
                    sqlconn.Close();
                    dataGridView1.DataSource = dt;
                }
            }
            catch (System.Exception exc)
            {
                Console.WriteLine(exc.GetType());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "Data Source=(local);" +
                "Initial Catalog=bd_empresa;" +
                "Integrated Security=True;";
                string sqlquery;
                //'User ID=UserName;Password=Password;
                SqlConnection sqlconn = new SqlConnection(conexion);
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand();
                DataTable dt = new DataTable();

                sqlquery =
                "UPDATE empleado " +
                "SET nombre = '" + textBox2.Text + "', " +
                "apellido = '" + textBox3.Text + "', " +
                "ubicacion = '" + textBox4.Text + "', " +
                "telefono = '" + textBox5.Text + "', " +
                "fechanacimiento = '" + textBox6.Text + "' " +
                "WHERE cedula =  '" + textBox1.Text + "' ;";

                sqlcomm.Connection = sqlconn;
                sqlcomm.CommandText = sqlquery;
                sqlcomm.CommandType = CommandType.Text;
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
                sqlquery = "select "+_FieldsToSelect+" from empleado";
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter(sqlquery, sqlconn);
                sqlda.Fill(dt);
                sqlconn.Close();
                dataGridView1.DataSource = dt;
            }
            catch (System.Exception exc)
            {
                Console.WriteLine(exc.GetType());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //Si el textbox no esta vacio
                if (!textBox1.Text.Equals(""))
                {
                    string conexion = "Data Source=(local);" +
                        "Initial Catalog=bd_empresa;" +
                        "Integrated Security=True;";
                    string sqlquery;
                    //'User ID=UserName;Password=Password;
                    SqlConnection sqlconn = new SqlConnection(conexion);
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand();
                    DataTable dt = new DataTable();
                    sqlquery = "select cedula as 'Cédula', nombre as 'Nombre', apellido as 'Apellido'," +
                    " ubicacion as 'Ubicación', telefono as 'Teléfono', fechanacimiento as 'Fecha Nac' " +
                    "from empleado where cedula = " + textBox1.Text;
                    SqlDataAdapter sqlda = new SqlDataAdapter(sqlquery, sqlconn);
                    sqlda.Fill(dt);
                    sqlconn.Close();
                    dataGridView1.DataSource = dt;
                    //pasarlo a los texbox
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        dataGridView1.Rows[0].Selected = true;
                        //TextBox1.Text = DataGridView1(0, DataGridView1.CurrentRow.Index).Value
                        textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    }
                }
                else
                    this.ActiveControl = textBox1;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    ShowMessage("Ya existe un Empleado con el ID " + textBox1.Text);
                }
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Data);
                Console.WriteLine(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reloadGridView();
        }
    }
}
