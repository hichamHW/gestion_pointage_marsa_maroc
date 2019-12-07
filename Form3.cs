using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_marsa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            panel4.Visible = false;
            panel3.Visible = true;
            panel3.BringToFront();
            button8.BackColor = Color.FromArgb(165, 16, 50);
            button1.BackColor = Color.FromArgb(220, 44, 84);
            button2.BackColor = Color.FromArgb(220, 44, 84);
     ///       button2.Enabled = false;
        ///    button1.Enabled = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
            panel3.Visible = true;
            label8.Text = "Changer mot de passe";
            ///label8
            button8.BackColor = Color.FromArgb(165, 16, 50);
            button1.BackColor = Color.FromArgb(220, 44, 84);
            button2.BackColor = Color.FromArgb(220, 44,84);
            panel3.BringToFront();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel5.Visible = false;
            panel4.Visible = true;
            label8.Text = "Ajouter un utilisateur";
            button1.BackColor = Color.FromArgb(165, 16, 50);
            button8.BackColor = Color.FromArgb(220, 44, 84);
            button2.BackColor = Color.FromArgb(220, 44, 84);
            panel4.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String pass = textBox6.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {


                if ( pass == "") 
                {

                    MessageBox.Show("Entre mot de passe!");
                }
                else
                {
                    string query = "select *from login  where password = '" + pass + "' ";
                    string query1 = "delete from login where type <> 'admin'";
                    conn.Open();
                    SqlDataAdapter d = new SqlDataAdapter(query, conn);
                    DataTable t = new DataTable();
                    d.Fill(t);
                    conn.Close();
                    if (t.Rows[0][3].ToString() == "admin     ")
                    {
                        

                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query1, conn);
                        SqlDataReader rd;
                        rd = cmd.ExecuteReader();

                        MessageBox.Show("Bien réinstaller ! ");
                        conn.Close();


                    }
                    //////////////////////

                    









                }
            }
            catch (Exception ex)
            {

               
                        MessageBox.Show("password is incorrect ! ");


            }



            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            button2.BackColor = Color.FromArgb(165, 16, 50);
            button1.BackColor = Color.FromArgb(220, 44, 84);
            button8.BackColor = Color.FromArgb(220, 44, 84);
            panel3.Visible = false;
            panel5.Visible = true;
            label8.Text = "Réinitialiser";
            panel5.BringToFront();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f = new Form2();
            f.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            String ID = textBox7.Text;
            
            String user = textBox5.Text;
            String pass = textBox4.Text;
            String type = comboBox1.Text.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {
              

                if (user == "" || pass == "" || ID == "" || type == "")
                {

                    MessageBox.Show("Entre les informations !");
                }
                else 
                {

                    string query = "insert into login values ( '"+ID+"'  , '" + user + "', '" + pass + "','"+type+"')";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();

                    MessageBox.Show("Bien ajouter ! ");
                    textBox7.Text = "";
                    textBox5.Text = "";
                   /// textBox6.Text = "";
                    textBox4.Text = "";
                    comboBox1.Text = "";










                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);

            }
           


            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            String npass = textBox3.Text;
            String pass= textBox1.Text;
            String repass = textBox2.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {


                if (pass=="" ||repass == "" || npass == "" ||(pass != repass) )
                {

                    MessageBox.Show("please entre password !");
                }
                else
                {

                    string query = "update login set password = '"+npass+"'  where password ='"+pass+"' ";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();

                    MessageBox.Show("Bien Modifier ! ");










                }
            }
            catch (Exception ex)
            {


                MessageBox.Show("ne");

            }



            conn.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int mov;
        int movx;
        int movy;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                Point p = PointToScreen(e.Location);


                Location = new Point(p.X - this.movx, p.Y - this.movy);



            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
