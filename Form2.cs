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
using itextsharp.pdfa;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Text;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;




namespace project_marsa
{



    
    public partial class Form2 : Form
    {
        public static int d;
        IList<String> l = new List<String>();
        IList<String> l1 = new List<String>();
        IList<String> l2 = new List<String>();
        IList<String> l3 = new List<String>();
        IList<String> l4 = new List<String>();
        IList<String> l5 = new List<String>();
        IList<String> l6 = new List<String>();


        private void bclient()
        { 
        
        
        }
        public Form2()
        {
            InitializeComponent();
            ///  button1.Enabled = false;
         button8.BackColor = Color.FromArgb(165, 16, 50);
            ///      /////// 211; 54; 80  button8.BackColor = Color.FromArgb(211, 54, 80  );
         button41.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel10.Visible = false;

            //  panel8.Visible = false;
            panel9.Visible = false;
            panel5.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel11.Visible = false;
            label45.Text = "Accueil";
           //// tclient();
          ///  tpointage();

            panel3.BringToFront();
            textBox26.Enabled = false;


            ///////////button///////
            textBox20.Enabled = false;
            textBox1.Enabled = false;
            textBox16.Enabled = false;
            textBox28.Enabled = false;
            textBox37.Enabled = false;
            textBox32.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            //  panel2.BringToFront();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //panel4.BringToFront();







        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void tclient()
        {
            button10.Visible = false;
            label2.Text = "Gestion du client";
            button1.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            button7.Visible = false;
            button6.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button6.Location = new Point(-3, 304);


        }
        public void tpointage()
        {
            button10.Visible = false;
            button2.Visible = false;
            label2.Text = "Gestion du pointage";
            button1.Visible = false;
            button3.Visible = false;
            button7.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;

            button4.Location = new Point(-3,180);
            button5.Location = new Point(-3,242);
            button6.Location = new Point(-3,304);


        }
        public void tstocke()
        {
            button10.Visible = false;
            button5.Visible = false;
            button1.Visible = false;
            label2.Text = "Gestion du stock";
            button4.Visible = false;
            button2.Visible = false;
            button7.Visible = true;
            button3.Visible = true;
            button6.Visible = true;

            button7.Location = new Point(-3, 180);
            button3.Location = new Point(-3, 242);
            button6.Location = new Point(-3, 304);
                     
        
        }
        private void button8_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            label45.Text = "Accueil";
            panel3.Visible = true;
            button8.BackColor = Color.FromArgb(165, 16, 50);
            button2.BackColor = Color.FromArgb(211, 54, 80);
            button1.BackColor = Color.FromArgb(211, 54, 80);
            button3.BackColor = Color.FromArgb(211, 54, 80);
            button4.BackColor = Color.FromArgb(211, 54, 80);
            button5.BackColor = Color.FromArgb(211, 54, 80);
            button6.BackColor = Color.FromArgb(211, 54, 80);
            button7.BackColor = Color.FromArgb(211, 54, 80);
           ///// button9.BackColor = Color.FromArgb(211, 54, 80);
            panel3.Visible = true;
            panel3.Visible = true;
            panel3.Visible = true;
            panel4.Visible = false;
            
            panel10.Visible = false;
            ///    panel8.Visible = false;
            ///     panel8.Visible = false;
            panel9.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel11.Visible = false;

            panel3.BringToFront();

        }
        ///////////////////sending
        private void sendemail(string email, string obj,string messages)
        {

            try
            {
                SmtpClient c = new SmtpClient("smtp.gmail.com", 587);
                c.EnableSsl = true;
                c.Timeout = 10000;
                c.DeliveryMethod = SmtpDeliveryMethod.Network;
                c.UseDefaultCredentials = false;
                c.Credentials = new NetworkCredential("marocmarsa20@gmail.com", "marsamaroc@123");
                MailMessage msg = new MailMessage();


                msg.To.Add(email);
                msg.From = new MailAddress("marocmarsa20@gmail.com");
                msg.Subject =obj;
                msg.Body = messages;
                c.Send(msg);


                MessageBox.Show("Email envoyé avec success !");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Email n'est pas valide");

               
            }
        
                   
        
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel3.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel4.Visible = true;
            button1.BackColor = Color.FromArgb(165, 16, 50);
            button2.BackColor = Color.FromArgb(211, 54, 80);
            button8.BackColor = Color.FromArgb(211, 54, 80);
            button3.BackColor = Color.FromArgb(211, 54, 80);
            button4.BackColor = Color.FromArgb(211, 54, 80);
            button5.BackColor = Color.FromArgb(211, 54, 80);
            button6.BackColor = Color.FromArgb(211, 54, 80);
            button7.BackColor = Color.FromArgb(211, 54, 80);
            ///////button9.BackColor = Color.FromArgb(211, 54, 80);
            panel5.Visible = false;
            label45.Text = "Client";
            panel6.Visible = false;
            ID_conteneur.Enabled = false;
            textBox33.Enabled = false;


            panel4.BringToFront();
          ///  panel4.Location = new Point(181, 47);


            show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel5.Visible = true;
            panel10.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel4.Visible = false;
            panel3.Visible = false;
            button2.BackColor = Color.FromArgb(165, 16, 50);
            button8.BackColor = Color.FromArgb(211, 54, 80);
            button1.BackColor = Color.FromArgb(211, 54, 80);
            button3.BackColor = Color.FromArgb(211, 54, 80);
            button4.BackColor = Color.FromArgb(211, 54, 80);
            button5.BackColor = Color.FromArgb(211, 54, 80);
            button6.BackColor = Color.FromArgb(211, 54, 80);
            button7.BackColor = Color.FromArgb(211, 54, 80);
          /////  button9.BackColor = Color.FromArgb(211, 54, 80);
            label45.Text = "Export-Import";
            panel6.Visible = false;
            panel11.Visible = false;
            panel5.BringToFront();
            show_in_out();
        }

        private void button9_Click(object sender, EventArgs e)
        {


            this.Close();
            Form1 f = new Form1();
            f.Show();



        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel9.Visible = false;
            panel6.Visible = true;
            panel4.Visible = false;
            button5.BackColor = Color.FromArgb(165, 16, 50);
            button2.BackColor = Color.FromArgb(211, 54, 80);
            button1.BackColor = Color.FromArgb(211, 54, 80);
            button3.BackColor = Color.FromArgb(211, 54, 80);
            button4.BackColor = Color.FromArgb(211, 54, 80);
            button8.BackColor = Color.FromArgb(211, 54, 80);
            button6.BackColor = Color.FromArgb(211, 54, 80);
            button7.BackColor = Color.FromArgb(211, 54, 80);
            ////////button9.BackColor = Color.FromArgb(211, 54, 80);
            label45.Text = "Pointage";
            panel3.Visible = false;
            panel8.Visible = false;
            panel5.Visible = false;
            panel6.BringToFront();
            show_pointe();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel10.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            label45.Text = "Escale";
            button4.BackColor = Color.FromArgb(165, 16, 50);
            button2.BackColor = Color.FromArgb(211, 54, 80);
            button1.BackColor = Color.FromArgb(211, 54, 80);
            button3.BackColor = Color.FromArgb(211, 54, 80);
            button8.BackColor = Color.FromArgb(211, 54, 80);
            button5.BackColor = Color.FromArgb(211, 54, 80);
            button6.BackColor = Color.FromArgb(211, 54, 80);
            button7.BackColor = Color.FromArgb(211, 54, 80);
            ///button9.BackColor = Color.FromArgb(211, 54, 80);
            panel7.Visible = true;
            panel11.Visible = false;
            panel4.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            show_escale();

            panel7.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel10.Visible = false;
            label45.Text = "Stockage";
            panel9.Visible = false;
            panel8.Visible = true;
            panel11.Visible = false;
            button3.BackColor = Color.FromArgb(165, 16, 50);
            button2.BackColor = Color.FromArgb(211, 54, 80);
            button1.BackColor = Color.FromArgb(211, 54, 80);
            button8.BackColor = Color.FromArgb(211, 54, 80);
            button4.BackColor = Color.FromArgb(211, 54, 80);
            button5.BackColor = Color.FromArgb(211, 54, 80);
            button6.BackColor = Color.FromArgb(211, 54, 80);
            button7.BackColor = Color.FromArgb(211, 54, 80);
            ///button9.BackColor = Color.FromArgb(211, 54, 80);
            panel4.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            show_stocke();

            ///textBox28.Enabled = false;

            panel7.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel10.Visible = false;
            panel8.Visible = false;
            label45.Text = "Conteneur";
            panel9.Visible = true;
            panel7.Visible = false;
            panel4.Visible = false;
            panel3.Visible = false;
            button6.BackColor = Color.FromArgb(165, 16, 50);
            button2.BackColor = Color.FromArgb(211, 54, 80);
            button1.BackColor = Color.FromArgb(211, 54, 80);
            button3.BackColor = Color.FromArgb(211, 54, 80);
            button4.BackColor = Color.FromArgb(211, 54, 80);
            button5.BackColor = Color.FromArgb(211, 54, 80);
            button8.BackColor = Color.FromArgb(211, 54, 80);
            button7.BackColor = Color.FromArgb(211, 54, 80);
            ///button9.BackColor = Color.FromArgb(211, 54, 80);
            panel5.Visible = false;
            panel11.Visible = false;
            radioButton1.Checked = true;

            show_conteneur();


            panel9.BringToFront();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            panel6.Visible = false;
            panel10.Visible = false;
            panel11.Visible = true;
            panel8.Visible = false;
            panel9.Visible = false;
            panel7.Visible = false;
            button7.BackColor = Color.FromArgb(165, 16, 50);
            button2.BackColor = Color.FromArgb(211, 54, 80);
            button1.BackColor = Color.FromArgb(211, 54, 80);
            button3.BackColor = Color.FromArgb(211, 54, 80);
            button4.BackColor = Color.FromArgb(211, 54, 80);
            button5.BackColor = Color.FromArgb(211, 54, 80);
            button6.BackColor = Color.FromArgb(211, 54, 80);
            button8.BackColor = Color.FromArgb(211, 54, 80);
            
            label45.Text = "Terminal";
            panel4.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            show_terminal();

            panel11.BringToFront();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void showIndex(int j)
        {



            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from client ";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();

                d.Fill(t, "client");
                client.DataSource = t.Tables["client"].DefaultView;



            }




            catch (Exception ex)
            {
                MessageBox.Show("Data incorrect !");


            }

            conn.Close();
        }

        private void show()
        {



            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from client ";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();

                d.Fill(t, "client");
                client.DataSource = t.Tables["client"].DefaultView;



            }




            catch (Exception ex)
            {
                MessageBox.Show("Data incorrect !");


            }

            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from client ";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();

                d.Fill(t, "client");
                client.DataSource = t.Tables["client"].DefaultView;



            }




            catch (Exception ex)
            {
                MessageBox.Show("Data incorrect !");


            }

            conn.Close();

        }

        ///   fonction client
        private int max_client()
        {


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select  max(id_client) from client";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                int max = Int32.Parse(t.Rows[0][0].ToString());
                return max + 1;



            }




            catch (Exception ex)
            {
                return 1;

            }

            conn.Close();



        }


        private void button12_Click(object sender, EventArgs e)
        {
           /// String ID = textBox1.Text;
            String nom = textBox2.Text;
            String prenom = textBox4.Text;
            String adresse = textBox3.Text;
            String tel = textBox6.Text;
            String NBC = textBox5.Text;
            String email = textBox8.Text;
            
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "insert into client values (" + max_client().ToString() + ",'" + nom + "','" + prenom + "','" + adresse + "','" + tel + "','" + NBC + "','" + email + "')";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();///

                MessageBox.Show("bien ajouter !");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox8.Text = "";
                show();




            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas ajouter !");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox8.Text = "";
            }

            conn.Close();

        }
        private int ro()
        {



            return 10;


        }
        private void button13_Click(object sender, EventArgs e)
        {
            String ID = textBox1.Text;
            String nom = textBox2.Text;
            String prenom = textBox4.Text;
            String adresse = textBox3.Text;
            String tel = textBox6.Text;
            String NBC = textBox5.Text;
            String email = textBox8.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "update client set nom ='" + nom + "', prenom ='" + prenom + "', adresse ='" + adresse + "', tele='" + tel + "', NCompte_bank ='" + NBC + "', email ='" + email + "'  where id_client=" + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("bien Modifier !");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox8.Text = "";
                show();




            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas Modifier !");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox8.Text = "";
            }

            conn.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            String ID = textBox1.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "delete from client where id_client = " + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("bien supprimer !");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox8.Text = "";
                show();




            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas supprimer !");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox8.Text = "";
            }

            conn.Close();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            String rech = textBox7.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select  *from client where nom like '" + rech + "%' or prenom like'" + rech + "%'";

                conn.Open();


                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();
                d.Fill(t, "client");
                client.DataSource = t.Tables["client"].DefaultView;
                /// string query1 = "select  count(*) from client where nom like '" + rech + "%' or prenom like'" + rech + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                /////////   < FI GI > copyright © 2019 FST settat

                SqlDataReader r = cmd.ExecuteReader();
                l.Clear();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox8.Text = "";

                while (r.Read())
                {

                    l.Add(r[0].ToString());





                }





            }
            catch (Exception es)
            {


            }
            conn.Close();
        }


        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {



        }
        int mov, movx, movy;

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


        private int max_sortie_entree()
        {


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select max(id_so_en)from sortie_entree";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                int max = Int32.Parse(t.Rows[0][0].ToString());
                return max + 1;



            }




            catch (Exception ex)
            {
                return 1;

            }

            conn.Close();



        }
        private void button18_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from sortie_entree";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();
                //  in_out
                d.Fill(t, "in_out");
                in_out.DataSource = t.Tables["in_out"].DefaultView;



            }




            catch (Exception ex)
            {
                MessageBox.Show("Data incorrect !");


            }

            conn.Close();

        }

        private void show_in_out()
        {


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from sortie_entree";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();

                d.Fill(t, "in_out");
                in_out.DataSource = t.Tables["in_out"].DefaultView;



            }




            catch (Exception ex)
            {
                MessageBox.Show("Data incorrect !");


            }

            conn.Close();

        }
        private void button17_Click(object sender, EventArgs e)
        {
           /// String ID = textBox16.Text;
            String Date = dateTimePicker3.Text;
            String Type = comboBox5.Text;
            String id_client = textBox13.Text;
            String id_conteneur = textBox12.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = "insert into sortie_entree values (" + max_sortie_entree().ToString() + ",'" + Date + "','" + Type + "','" + id_client + "','" + id_conteneur + "')";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("Valider !");

                textBox16.Text = "";
                dateTimePicker3.Text = "";
                comboBox5.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";
                string em = toemail(id_conteneur);
                if (em != null)
                {
                    if (Type == "import")
                    {
                        sendemail(em, "Import", "Bonjour \n\nVotre conteneur d'id = " + id_conteneur.ToString() + "   , importation  est bien passé .\nDate d'importation est :  " + Date.ToString() + " ");
                    }
                    else
                    {
                        sendemail(em, "Export", "Bonjour \n\nVotre conteneur d'id = " + id_conteneur.ToString() + "   , exportation  est bien passé .\nDate d'exportation est :  " + Date.ToString() + " ");


                    }
                }
         
                show_in_out();





            }




            catch (Exception ex)
            {
                MessageBox.Show("Non valider !");


                textBox16.Text = "";
                dateTimePicker3.Text = "";
                comboBox5.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";
            }

            conn.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String ID = textBox16.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "delete from sortie_entree where id_so_en = " + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("bien supprimer !");

                textBox16.Text = "";
                dateTimePicker3.Text = "";
                comboBox5.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";

                show_in_out();




            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas supprimer !");


                textBox16.Text = "";
                dateTimePicker3.Text = "";
                comboBox5.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";

                show_in_out();
            }

            conn.Close();
        }

        private void in_out_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            client.ReadOnly = true;
            int i = in_out.CurrentCell.RowIndex;
            String query;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {

                if (textBox9.Text == "")
                {
                    query = "select *from sortie_entree where id_so_en = " + (i + 1).ToString() + " ";


                }
                else
                {
                    string w = l1[i];
                    query = "select *from sortie_entree where id_so_en = " + w + " ";

                }




                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                textBox16.Text = t.Rows[0][0].ToString();

                dateTimePicker3.Text = t.Rows[0][1].ToString();
                comboBox5.Text = t.Rows[0][2].ToString();
                textBox13.Text = t.Rows[0][3].ToString();
                textBox12.Text = t.Rows[0][4].ToString();





            }




            catch (Exception ex)
            {
                ///   MessageBox.Show("Data incorrect !");


            }

            conn.Close();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //// MessageBox.Show(l[0] + "   " + l[1]);

            



        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            String rech = textBox9.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select  *from sortie_entree where id_client in (select  id_client from client where nom like '" + rech + "%' or prenom like'" + rech + "%')";

                conn.Open();


                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();
                d.Fill(t, "in_out");
                in_out.DataSource = t.Tables["in_out"].DefaultView;
                /// string query1 = "select  count(*) from client where nom like '" + rech + "%' or prenom like'" + rech + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                /////////   < FI GI > copyright © 2019 FST settat

                SqlDataReader r = cmd.ExecuteReader();
                l1.Clear();
                textBox16.Text = "";
                dateTimePicker3.Text = "";
                comboBox5.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";


                while (r.Read())
                {
                    l1.Add(r[0].ToString());





                }





            }
            catch (Exception es)
            {


            }
            conn.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(l1[0].ToString());
        }

        private void button16_Click(object sender, EventArgs e)
        {

            String id = textBox16.Text;
            String date = dateTimePicker3.Text;
            String type = comboBox5.Text;
            String id_client = textBox13.Text;
            String id_cont = textBox12.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "update sortie_entree set date_so_en ='" + date + "',type='" + type + "',id_client = '" + id_client + "',id_conteneur = '" + id_cont + "' where id_so_en = " + id + "";

                conn.Open();



                /// string query1 = "select  count(*) from client where nom like '" + rech + "%' or prenom like'" + rech + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                /////////   < FI GI > copyright © 2019 FST settat

                SqlDataReader r = cmd.ExecuteReader();
                MessageBox.Show("Bien modifer !");

                textBox16.Text = "";
                dateTimePicker3.Text = "";
                comboBox5.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";

                show_in_out();





            }
            catch (Exception es)
            {
                MessageBox.Show("N'est pas modifer !");
                textBox16.Text = "";
                dateTimePicker3.Text = "";
                comboBox5.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";


            }
            conn.Close();
        }

        private void show_pointe()
        {


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from pointage ";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();

                d.Fill(t, "pointage");
                pointage.DataSource = t.Tables["pointage"].DefaultView;



            }




            catch (Exception ex)
            {


            }

            conn.Close();


        }


        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
         ///   panel1.Size = new Size(61, 622);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            show_pointe();
        }

        private int max_pointage()
        {


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select  max(id_pointage) from pointage";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
               int max = Int32.Parse(t.Rows[0][0].ToString());
               return max +1 ;



            }




            catch (Exception ex)
            {
                return 1;

            }

            conn.Close();

        
        
        }

        
        private void button24_Click(object sender, EventArgs e)
        {
           /// comboBox4.Enabled=false;

           /// String ID = textBox20.Text;
           /// 
            textBox20.Enabled = false;
            String Date = dateTimePicker1.Text.ToString();
            String Type = comboBox4.Text;
            String id_escale = textBox17.Text;
            String id_conteneur = textBox11.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = "insert into pointage values (" + max_pointage().ToString() + ",'" + Date + "','" + Type + "','" + id_escale + "','" + id_conteneur + "')";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("Valider !");

                textBox20.Text = "";
                dateTimePicker1.Text = "";
                comboBox4.Text = "";
                textBox17.Text = "";
                textBox11.Text = "";
                show_pointe();
                string em = toemail(id_conteneur);
                if (em != null)
                {
                    sendemail(em, "Pointage", "Bonjour \n\nVotre conteneur d'id = " + id_conteneur + "   , pointage  est bien validé  dans l'escale d'id =" + id_escale + "\nDate de pointage est :  " + Date + " ");
                
                }


            }




            catch (Exception ex)
            {
                MessageBox.Show("Non valider !");

                textBox20.Text = "";
                dateTimePicker1.Text = "";
                comboBox4.Text = "";
                textBox17.Text = "";
                textBox11.Text = "";
                show_pointe();

            }

            conn.Close();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            String ID = textBox20.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "delete from pointage where id_pointage = " + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("bien supprimer !");

                textBox20.Text = "";
                dateTimePicker1.Text = "";
                comboBox4.Text = "";
                textBox17.Text = "";
                textBox11.Text = "";

                show_pointe();




            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas supprimer !");


                textBox20.Text = "";
                dateTimePicker1.Text = "";
                comboBox4.Text = "";
                textBox17.Text = "";
                textBox11.Text = "";
                show_pointe();
            }

            conn.Close();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            String ID = textBox20.Text;
            String date = dateTimePicker1.Text.ToString();
            String type = comboBox4.Text;
            String id_escale = textBox17.Text;
            String id_conteneur = textBox11.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "update pointage set date_pointage ='" + date + "', type_pointage ='" + type + "', id_escale =" + id_escale + ", id_conteneur=" + id_conteneur + "  where id_pointage=" + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("bien Modifier !");

                textBox20.Text = "";
                dateTimePicker1.Text = "";
                comboBox4.Text = "";
                textBox17.Text = "";
                textBox11.Text = "";

                show_pointe();





            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas Modifier !");
                textBox20.Text = "";
                dateTimePicker1.Text = "";
                comboBox4.Text = "";
                textBox17.Text = "";
                textBox11.Text = "";

                show_pointe();


            }

            conn.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            String rech = textBox10.Text;
            if (textBox10.Text == "")
            {

                show_pointe();
                textBox20.Text = "";
                dateTimePicker1.Text = "";
                comboBox4.Text = "";
                textBox17.Text = "";
                textBox11.Text = "";
            }

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select  * from pointage where id_conteneur = " + rech + " ";

                conn.Open();


                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();
                d.Fill(t, "pointage");
                pointage.DataSource = t.Tables["pointage"].DefaultView;

                SqlCommand cmd = new SqlCommand(query, conn);
                /////////   < FI GI > copyright © 2019 FST settat

                SqlDataReader r = cmd.ExecuteReader();


                l2.Clear();
                textBox20.Text = "";
                dateTimePicker1.Text = "";
                comboBox4.Text = "";
                textBox17.Text = "";
                textBox11.Text = "";



                while (r.Read())
                {
                    l2.Add(r[0].ToString());





                }





            }
            catch (Exception es)
            {
                textBox20.Text = "";
                dateTimePicker1.Text = "";
                comboBox4.Text = "";
                textBox17.Text = "";
                textBox11.Text = "";


            }
            conn.Close();
        }

        private void pointage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void show_escale()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from escale";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();
                //  in_out
                d.Fill(t, "escale");
                escale.DataSource = t.Tables["escale"].DefaultView;



            }




            catch (Exception ex)
            {



            }

            conn.Close();

        }
        private int max_escale()
        {


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select MAX(id_escale)  from escale";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                int max = Int32.Parse(t.Rows[0][0].ToString());
                return max + 1;



            }




            catch (Exception ex)
            {
                return 1;

            }

            conn.Close();



        }

        private void button26_Click(object sender, EventArgs e)
        {
            show_escale();

        }

        private void button21_Click(object sender, EventArgs e)
        {

            
            String Nom = textBox25.Text;
            String date = dateTimePicker2.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = "insert into escale values (" + max_escale().ToString() + ",'" + Nom + "','" + date + "')";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("Valider !");

                textBox26.Text = "";
                textBox25.Text = "";
                textBox21.Text = "";
                dateTimePicker2.Text = "";
                show_escale();

            }




            catch (Exception ex)
            {
                MessageBox.Show("Non valider !");
                textBox26.Text = "";
                textBox25.Text = "";
                dateTimePicker2.Text = "";
                show_escale();
            }

            conn.Close();

        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            String ID = textBox26.Text;
            String Nom = textBox25.Text;
            String date = dateTimePicker2.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "update escale set Nom_escale ='" + Nom + "', date_escale='" + date + "' where id_escale = " + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("bien Modifier !");

                textBox26.Text = "";
                textBox25.Text = "";
                dateTimePicker2.Text = "";
                textBox21.Text = "";

                show_escale();




            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas Modifier !");
                textBox26.Text = "";
                textBox21.Text = "";
                textBox25.Text = "";
                dateTimePicker2.Text = "";


                show_escale();



            }

            conn.Close();

        }

        private void button27_Click(object sender, EventArgs e)
        {

            String IDe = textBox26.Text;




            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "delete from escale where id_escale = " + IDe + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("bien supprimer !");
                textBox26.Text = "";
                textBox25.Text = "";
                dateTimePicker2.Text = "";
                textBox21.Text = "";

                show_escale();





            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas supprimer !"+ ex.ToString());


                textBox26.Text = "";
                textBox25.Text = "";
                textBox21.Text = "";
                dateTimePicker2.Text = "";


                show_escale();

            }

            conn.Close();

        }
        private void show_stocke()
        {



            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from stocke";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();
                //  in_out
                d.Fill(t, "stocke");
                stocke.DataSource = t.Tables["stocke"].DefaultView;



            }




            catch (Exception ex)
            {



            }

            conn.Close();




        }


        private void button31_Click(object sender, EventArgs e)
        {
            show_stocke();
            ///int j = f_capacite(1);
            int j = f_dim(1);

           /// int j =f_somme_conteneur(1);
         ///   MessageBox.Show(j.ToString());

        }

        private int f_somme_conteneur(int id_ter)
        {

            
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
           
            try
            {
                int somme = 0;
                String query = "select sum(CONVERT(INT, SUBSTRING(dimension, 1, 2) )) as 'somme' from conteneur where id_conteneur in(select id_conteneur from stocke where id_terminal ="+id_ter+")";





                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                somme = Int32.Parse(t.Rows[0][0].ToString());



                return somme;
               





            }




            catch (Exception ex)
            {
                ///   MessageBox.Show("Data incorrect !");
                return 0;

            }

            conn.Close();



         
                          
        }
        private int f_capacite(int id_ter)
        {


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {
                int somme = 0;
                String query = "select  capacite from terminal where id_terminal ="+id_ter+"";





                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                somme = Int32.Parse(t.Rows[0][0].ToString());

                return somme;






            }




            catch (Exception ex)
            {
                ///   MessageBox.Show("Data incorrect !");
                return 0;

            }

            conn.Close();





        }
        private int f_dim(int id_con)
        {


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {
                int dim = 0;
                String query = "select CONVERT(INT, SUBSTRING(dimension, 1, 2) ) as 'capacite' from conteneur where id_conteneur ="+id_con+"";





                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                dim = Int32.Parse(t.Rows[0][0].ToString());

                return dim;






            }




            catch (Exception ex)
            {
                ///   MessageBox.Show("Data incorrect !");
                return 0;

            }

            conn.Close();





        }
        private string toemail(string idconto)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select email from  client where id_client in (select id_client from sortie_entree where id_conteneur = "+idconto+"  )";

                conn.Open();

                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
              
                return t.Rows[0][0].ToString();

            }




            catch (Exception ex)
            {
                /// MessageBox.Show("Data incorrect !");
                return null;


            }

        
                    
        
        }
        private int max_stocke()
        {


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select max(id_stock) from stocke";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                int max = Int32.Parse(t.Rows[0][0].ToString());
                return max + 1;



            }




            catch (Exception ex)
            {
                return 1;

            }

            conn.Close();



        }
        private void button30_Click(object sender, EventArgs e)
        {

            
            String date = date_stocke.Text;
            String position = comboBox6.Text;
            String id_contneur = textBox30.Text;
            String id_terminal = textBox29.Text;
            int id_ter = Int32.Parse(id_terminal) ;
            int id_con = Int32.Parse(id_contneur);
            int  capter = f_capacite(id_ter);
            int som = f_somme_conteneur(id_ter);
            int dim = f_dim(id_con);

            if ((capter - som) > dim)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

                try
                {



                    string query = "insert into stocke values (" + max_stocke().ToString() + ",'" + date + "','" + position + "'," + id_contneur + "," + id_terminal + ")";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    MessageBox.Show("Valider !");
                    textBox28.Text = "";
                    /// textBox27.Text="";
                    comboBox6.Text = "";
                    textBox30.Text = "";
                    textBox29.Text = "";
                    string toem = toemail(id_contneur);
                    if (toem != null)

                    {
                        sendemail(toem, "stockage", "Bonjour \n\nVotre conteneur d'id = " + ID_conteneur + " est bien stockée  dans le terminal d'id =" + id_terminal + "\nDate de stockage est :  " + date + " ");
                    
                    }

                    


                    show_stocke();
                    

                }




                catch (Exception ex)
                {
                    textBox28.Text = "";
                    ///textBox27.Text = "";
                    comboBox6.Text = "";
                    textBox30.Text = "";
                    textBox29.Text = "";
                    MessageBox.Show(" N'est pas Valider !");
                    show_stocke();
                }

                conn.Close();

            }
            else
            {

                MessageBox.Show(" Il n'y a pas de place disponible  !");


            }
            
           

        }

        private void button29_Click(object sender, EventArgs e)
        {
            String ID = textBox28.Text;
            String date = date_stocke.Text;
            String position = comboBox6.Text;
            String id_contneur = textBox30.Text;
            String id_terminal = textBox29.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "update stocke  set date ='" + date + "', position ='" + position + "', id_conteneur =" + id_contneur + ", id_terminal=" + id_terminal + "  where id_stock=" + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("bien Modifier !");

                textBox28.Text = "";
                /// textBox27.Text="";
                comboBox6.Text = "";
                textBox30.Text = "";
                textBox29.Text = "";

                show_stocke();





            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas Modifier !");
                textBox28.Text = "";
                /// textBox27.Text="";
                comboBox6.Text = "";
                textBox30.Text = "";
                textBox29.Text = "";

                show_stocke();


            }

            conn.Close();
        }

        private void date_stocke_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            String ID = textBox28.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "delete from stocke where id_stock = " + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("bien supprimer !");
                textBox28.Text = "";
                /// textBox27.Text="";
                comboBox6.Text = "";
                textBox30.Text = "";
                textBox29.Text = "";

                show_stocke();




            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas supprimer !");

                textBox28.Text = "";
                /// textBox27.Text="";
                comboBox6.Text = "";
                textBox30.Text = "";
                textBox29.Text = "";

                show_stocke();
            }

            conn.Close();

        }

        private void panel8_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            String rech = textBox22.Text;
            /* 
              */
            if (rech == "")
            {
                textBox28.Text = "";
                /// textBox27.Text="";
                comboBox6.Text = "";
                textBox30.Text = "";
                textBox29.Text = "";

                show_stocke();
            }
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from  stocke where id_terminal in (select id_terminal  from terminal where nom like '" + rech + "%' )";

                conn.Open();


                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();
                d.Fill(t, "stocke");
                stocke.DataSource = t.Tables["stocke"].DefaultView;
                /**/
                SqlCommand cmd = new SqlCommand(query, conn);
                /////////   < FI GI > copyright © 2019 FST settat

                SqlDataReader r = cmd.ExecuteReader();


                l3.Clear();
                textBox28.Text = "";
                /// textBox27.Text="";
                comboBox6.Text = "";
                textBox30.Text = "";
                textBox29.Text = "";



                while (r.Read())
                {
                    l3.Add(r[0].ToString());





                }





            }
            catch (Exception es)
            {


            }
            conn.Close();
        }

        private void stocke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            /*stocke.ReadOnly = true;
            int i = stocke.CurrentCell.RowIndex;
            String query;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {

                if (textBox22.Text == "")
                {
                    query = "select *from stocke where id_stock = " + (i + 1).ToString() + " ";


                }
                else
                {
                    string w = l3[i];
                    query = "select *from stocke where id_stock = " + w + " ";

                }




                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                textBox28.Text = t.Rows[0][0].ToString();

                date_stocke.Text = t.Rows[0][1].ToString();
                textBox23.Text = t.Rows[0][2].ToString();
                textBox30.Text = t.Rows[0][3].ToString();
                textBox29.Text = t.Rows[0][4].ToString();





            }




            catch (Exception ex)
            {
                ///   MessageBox.Show("Data incorrect !");


            }

            conn.Close();
        */
        }

        private void textBox22_MouseHover(object sender, EventArgs e)
        {



        }

        private void textBox22_MouseLeave(object sender, EventArgs e)
        {

        }

        private void stocke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stocke.ReadOnly = true;
            int i = stocke.CurrentCell.RowIndex;
            String query;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {

                if (textBox22.Text == "")
                {
                    query = "select *from stocke where id_stock = " + (i + 1).ToString() + " ";


                }
                else
                {
                    string w = l3[i];
                    query = "select *from stocke where id_stock = " + w + " ";

                }




                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                textBox28.Text = t.Rows[0][0].ToString();

                date_stocke.Text = t.Rows[0][1].ToString();
                comboBox6.Text = t.Rows[0][2].ToString();
                textBox30.Text = t.Rows[0][3].ToString();
                textBox29.Text = t.Rows[0][4].ToString();





            }




            catch (Exception ex)
            {
                ///   MessageBox.Show("Data incorrect !");


            }

            conn.Close();
        }
        private int count()
        {
            //////////////////////conteneur///////////
            SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select count(*) from conteneur where id_conteneur in (select id_conteneur from sortie_entree where id_client = " + textBox1.Text + " ) ";

                conn1.Open();

                SqlDataAdapter d = new SqlDataAdapter(query, conn1);
                DataTable t = new DataTable();
                d.Fill(t);
                int c = Int32.Parse(t.Rows[0][0].ToString());
                return c;


              

            }




            catch (Exception ex)
            {
                MessageBox.Show("Data incorrect !");
                return 0;

            }

            conn1.Close();
           
                 
        
        }

        string N, nom, email, adresse, tel, ncb;
        string Nc, dim, type,Ns,date,position,ID_co,ID_ter;
        string id_so, date_so, types, id_cli, idc;
        string id_p, date_p, type_p, id_es, id_cont;

        private void button32_Click(object sender, EventArgs e)
        { 
            ///////////data base////////////

            ///////////client///////////
            string tN= textBox1.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from client where id_client ="+tN+" ";

                conn.Open();
                
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                N = t.Rows[0][0].ToString() ;
                nom = t.Rows[0][1].ToString()+" "+t.Rows[0][2].ToString();
                adresse = t.Rows[0][3].ToString();
                 tel= t.Rows[0][4].ToString();
                ncb = t.Rows[0][5].ToString();
                email = t.Rows[0][6].ToString();

            }




            catch (Exception ex)
            {
               /// MessageBox.Show("Data incorrect !");


            }

            conn.Close();
            //////////////////////conteneur///////////
            if (count() == 1)
            {

                SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {



                    string query = "select *from conteneur where id_conteneur in (select id_conteneur from sortie_entree where id_client = " + tN + " ) ";

                    conn1.Open();

                    SqlDataAdapter d = new SqlDataAdapter(query, conn1);
                    DataTable t = new DataTable();
                    d.Fill(t);
                    Nc = t.Rows[0][0].ToString();
                    dim = t.Rows[0][1].ToString();
                    type = t.Rows[0][2].ToString();


                }




                catch (Exception ex)
                {
                   /// MessageBox.Show("Data incorrect !");


                }

                conn1.Close();

               ////////////////////////////////stocke//////////////////////////

                SqlConnection conn21 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {



                    string query = "select *from stocke where id_conteneur ="+Nc+"";

                    conn1.Open();

                    SqlDataAdapter d = new SqlDataAdapter(query, conn21);
                    DataTable t = new DataTable();
                    d.Fill(t);
                    Ns = t.Rows[0][0].ToString();
                    date = t.Rows[0][1].ToString();
                    position = t.Rows[0][2].ToString();
                    ID_co = t.Rows[0][3].ToString();
                    ID_ter = t.Rows[0][4].ToString();

                }




                catch (Exception ex)
                {
                    /// MessageBox.Show("Data incorrect !");


                }

                conn1.Close();
                ///////////////////////////entre_sortie/////////////////
                SqlConnection conn210 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {



                    string query = "select *from sortie_entree where id_conteneur =" + Nc + "";

                    conn1.Open();

                    SqlDataAdapter d = new SqlDataAdapter(query, conn210);
                    DataTable t = new DataTable();
                    d.Fill(t);
                     
                    id_so = t.Rows[0][0].ToString();
                    date_so = t.Rows[0][1].ToString();
                    types = t.Rows[0][2].ToString();
                    id_cli = t.Rows[0][3].ToString();
                    idc = t.Rows[0][4].ToString();

                }




                catch (Exception ex)
                {
                    /// MessageBox.Show("Data incorrect !");


                }

                conn1.Close();
                //////////////////////////////////pointage///////////////
                SqlConnection conn022 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {



                    string query = "select *from pointage where id_conteneur =" + Nc + "";

                    conn1.Open();

                    SqlDataAdapter d = new SqlDataAdapter(query, conn210);
                    DataTable t = new DataTable();
                    d.Fill(t);
                    

                    id_p = t.Rows[0][0].ToString();
                    date_p = t.Rows[0][1].ToString();
                    type_p= t.Rows[0][2].ToString();
                    id_es = t.Rows[0][3].ToString();
                    id_cont = t.Rows[0][4].ToString();

                }




                catch (Exception ex)
                {
                    /// MessageBox.Show("Data incorrect !");


                }

                conn1.Close();



                /////////////////create pdf/////
                Document s1 = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);


                PdfWriter w = PdfWriter.GetInstance(s1, new FileStream("Rapport.pdf", FileMode.Create));



                s1.Open();
                BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                /// Chunk c1 = new Chunk("A chunk represents an isolated string. ");
                ///Chunk chunk0= new Chunk("");

                ///   Chunk chunk = new Chunk("\n\n\n\nRapport", FontFactory.GetFont("dax-black", 72));
                Paragraph chunk = new Paragraph("Rapport", FontFactory.GetFont("Arial", 30));
                Paragraph chunk1 = new Paragraph("Client", FontFactory.GetFont("Arial", 10));
                chunk.Alignment = Element.ALIGN_CENTER;
                chunk1.Alignment = Element.ALIGN_CENTER;

                Paragraph chunk2 = new Paragraph("\t\t\t\tN°                :     " + N, FontFactory.GetFont("Arial", 9));
                Paragraph chunk3 = new Paragraph("\t\t\t\tNOM       :     " + nom , FontFactory.GetFont("Arial", 9));
                Paragraph chunk4 = new Paragraph("\t\t\t\tADRESSE   :     " + adresse, FontFactory.GetFont("Arial", 9));
                Paragraph chunk5 = new Paragraph("\t\t\t\tTEL             :     " + tel, FontFactory.GetFont("Arial", 9));
                Paragraph chunk6 = new Paragraph("\t\t\t\tNCB            :     " + ncb, FontFactory.GetFont("Arial", 9));
                Paragraph chunk7 = new Paragraph("\t\t\t\tEMAIL         :     " + email, FontFactory.GetFont("Arial", 9));
                ///   chunk.set
                ///  chunk.SetUnderline(0.5f, -1.5f);
                ///  
                //////////////////////////////  Conteneur ////////////////////////////:

                Paragraph chunk12 = new Paragraph("Conteneur", FontFactory.GetFont("Arial", 10));
                chunk.Alignment = Element.ALIGN_CENTER;

                chunk12.Alignment = Element.ALIGN_CENTER;
                Paragraph chunk22 = new Paragraph("\t\t\t\tN°                    :     " + Nc, FontFactory.GetFont("Arial", 9));
                Paragraph chunk32 = new Paragraph("\t\t\t\tDIMENSION    :     " + dim, FontFactory.GetFont("Arial", 9));
                Paragraph chunk42 = new Paragraph("\t\t\t\tTYPE               :     " + type, FontFactory.GetFont("Arial", 9));
                Paragraph chunkLIN0 = new Paragraph("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 20));
                Paragraph chunkLIN = new Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 20));
                Paragraph chunkLIN1 = new Paragraph("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 20));
                Paragraph chunkLIN01 = new Paragraph("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 20));
                string urlimg = "C:\\Users\\pc\\Documents\\Visual Studio 2012\\Projects\\pro_ma\\project_marsa\\Resources\\marsa-maroc-logo-E2DA20F4A6-seeklogo.com.png";
                iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(urlimg);

                ////////////////////////////////////stocke/////////////////////////////////////
                Paragraph sto = new Paragraph("Stockage", FontFactory.GetFont("Arial", 10));

                Paragraph st1 = new Paragraph("\t\t\t\tN°                :     " + Ns, FontFactory.GetFont("Arial", 9));
                Paragraph st2 = new Paragraph("\t\t\t\tDATE       :     " + date, FontFactory.GetFont("Arial", 9));
                Paragraph st3 = new Paragraph("\t\t\t\tPOSITION   :     " + position, FontFactory.GetFont("Arial", 9));
                Paragraph st4 = new Paragraph("\t\t\t\tID_co             :     " + ID_co, FontFactory.GetFont("Arial", 9));
                Paragraph st5 = new Paragraph("\t\t\t\tID_te           :     " + ID_ter, FontFactory.GetFont("Arial", 9));
                ////////////////////////////////////////////////////////:
                Paragraph soe = new Paragraph("Sortie_Entree", FontFactory.GetFont("Arial", 10));
                soe.Alignment = Element.ALIGN_CENTER;

                Paragraph s1t = new Paragraph("\t\t\t\tN°                :     " + id_so, FontFactory.GetFont("Arial", 9));
                Paragraph s2t = new Paragraph("\t\t\t\tDATE       :     " + date_so, FontFactory.GetFont("Arial", 9));
                Paragraph s3t = new Paragraph("\t\t\t\tPOSITION   :     " + types, FontFactory.GetFont("Arial", 9));
                Paragraph s4t = new Paragraph("\t\t\t\tID_client             :     " + id_cli, FontFactory.GetFont("Arial", 9));
                Paragraph s5t = new Paragraph("\t\t\t\tID_cont        :     " + idc, FontFactory.GetFont("Arial", 9));
                ////////////////////////////////////////////////////////:
                Paragraph sp = new Paragraph("Pointage", FontFactory.GetFont("Arial", 10));
                sp.Alignment = Element.ALIGN_CENTER;

                Paragraph sp1 = new Paragraph("\t\t\t\tN°                :     " + id_p, FontFactory.GetFont("Arial", 9));
                Paragraph sp2 = new Paragraph("\t\t\t\tDATE       :     " + date_p, FontFactory.GetFont("Arial", 9));
                Paragraph sp3 = new Paragraph("\t\t\t\tTYPE   :     " + type_p, FontFactory.GetFont("Arial", 9));
                Paragraph sp4 = new Paragraph("\t\t\t\tID_es             :     " + id_es, FontFactory.GetFont("Arial", 9));
                Paragraph sp5 = new Paragraph("\t\t\t\tID_co           :     " + id_cont, FontFactory.GetFont("Arial", 9));
                //////////////////////////:addition///////////////////////:
                sto.Alignment = Element.ALIGN_CENTER;

                png.ScaleToFit(140f, 120f);

                png.SpacingBefore = 10f;
                png.SpacingAfter = 100f;

                //p.Alignment = Element.ALIGN_CENTER;



                png.Alignment = Element.ALIGN_LEFT;
             s1.Add(png);
                //    d.Add(c1);
                ///  d.Add(chunk0);
                s1.Add(chunk);
                s1.Add(chunkLIN);
                s1.Add(chunk1);
                s1.Add(chunkLIN0);
                s1.Add(chunk2);
                s1.Add(chunk3);
                s1.Add(chunk4);
                s1.Add(chunk5);
                s1.Add(chunk6);
                s1.Add(chunk7);
                s1.Add(chunkLIN0);
                s1.Add(chunk12);
                s1.Add(chunkLIN1);
                s1.Add(chunk22);
                s1.Add(chunk32);
                s1.Add(chunk42);
                s1.Add(chunkLIN1);
                s1.Add(sto);
                s1.Add(chunkLIN1);
                s1.Add(st1);

                s1.Add(st2);
                s1.Add(st3);
                s1.Add(st4);
                s1.Add(st5);
                s1.Add(chunkLIN1);
                s1.Add(soe);
                s1.Add(chunkLIN1);
                s1.Add(s1t);
                s1.Add(s2t);
                s1.Add(s3t);
                s1.Add(s4t);
                s1.Add(s5t);
                s1.Add(chunkLIN1);
                s1.Add(sp);
                s1.Add(chunkLIN1);
                s1.Add(sp1);
                s1.Add(sp2);
                s1.Add(sp3);
                s1.Add(sp4);
                s1.Add(sp5);


                //  d.Add(p);
                s1.Close();
                MessageBox.Show("le rapport créé avec succès !");
            }
            else {
                if (textBox33.Enabled == false)
                {
                    MessageBox.Show("il existe plusieurs conteneur pour le client  d'ID : " + textBox1.Text + "");


                }
                


                ID_conteneur.Enabled = true;
                textBox33.Enabled = true;
                string tex = textBox33.Text;



                SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {



                    string query = "select *from conteneur where id_conteneur ="+tex+" ";

                    conn1.Open();

                    SqlDataAdapter d = new SqlDataAdapter(query, conn1);
                    DataTable t = new DataTable();
                    d.Fill(t);
                    Nc = t.Rows[0][0].ToString();
                    dim = t.Rows[0][1].ToString();
                    type = t.Rows[0][2].ToString();


                }




                catch (Exception ex)
                {
                ////    MessageBox.Show("Data incorrect !");


                }

                conn1.Close();

                SqlConnection conn21 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {



                    string query = "select *from stocke where id_conteneur =" + tex + "";

                    conn1.Open();

                    SqlDataAdapter d = new SqlDataAdapter(query, conn21);
                    DataTable t = new DataTable();
                    d.Fill(t);
                    Ns = t.Rows[0][0].ToString();
                    date = t.Rows[0][1].ToString();
                    position = t.Rows[0][2].ToString();
                    ID_co = t.Rows[0][3].ToString();
                    ID_ter = t.Rows[0][4].ToString();

                }




                catch (Exception ex)
                {
                    /// MessageBox.Show("Data incorrect !");


                }

                conn1.Close();
                ///////////////////////////entre_sortie/////////////////
                SqlConnection conn210 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {



                    string query = "select *from sortie_entree where id_conteneur =" + Nc + "";

                    conn1.Open();

                    SqlDataAdapter d = new SqlDataAdapter(query, conn210);
                    DataTable t = new DataTable();
                    d.Fill(t);

                    id_so = t.Rows[0][0].ToString();
                    date_so = t.Rows[0][1].ToString();
                    types = t.Rows[0][2].ToString();
                    id_cli = t.Rows[0][3].ToString();
                    idc = t.Rows[0][4].ToString();

                }




                catch (Exception ex)
                {
                    /// MessageBox.Show("Data incorrect !");


                }

                conn1.Close();
                //////////////////////////////////pointage///////////////
                SqlConnection conn022 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {



                    string query = "select *from pointage where id_conteneur =" + Nc + "";

                    conn1.Open();

                    SqlDataAdapter d = new SqlDataAdapter(query, conn210);
                    DataTable t = new DataTable();
                    d.Fill(t);


                    id_p = t.Rows[0][0].ToString();
                    date_p = t.Rows[0][1].ToString();
                    type_p = t.Rows[0][2].ToString();
                    id_es = t.Rows[0][3].ToString();
                    id_cont = t.Rows[0][4].ToString();

                }




                catch (Exception ex)
                {
                    /// MessageBox.Show("Data incorrect !");


                }

                conn1.Close();



                /////////////////create pdf/////
                Document s1 = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);


                PdfWriter w = PdfWriter.GetInstance(s1, new FileStream("tes11tdd1ss.pdf", FileMode.Create));



                s1.Open();
                BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                /// Chunk c1 = new Chunk("A chunk represents an isolated string. ");
                ///Chunk chunk0= new Chunk("");

                ///   Chunk chunk = new Chunk("\n\n\n\nRapport", FontFactory.GetFont("dax-black", 72));
                Paragraph chunk = new Paragraph("Rapport", FontFactory.GetFont("Arial", 20));
                Paragraph chunk1 = new Paragraph("Client", FontFactory.GetFont("Arial", 10));
                chunk.Alignment = Element.ALIGN_CENTER;
                chunk1.Alignment = Element.ALIGN_CENTER;
                Paragraph chunkLIN = new Paragraph("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 10));
                Paragraph chunk2 = new Paragraph("\t\t\t\tN°               :     " + N, FontFactory.GetFont("Arial", 9));
                Paragraph chunk3 = new Paragraph("\t\t\t\tNOM           :     " + nom, FontFactory.GetFont("Arial", 9));
                Paragraph chunk4 = new Paragraph("\t\t\t\tADRESSE   :     " + adresse, FontFactory.GetFont("Arial", 9));
                Paragraph chunk5 = new Paragraph("\t\t\t\tTEL             :     " + tel, FontFactory.GetFont("Arial", 9));
                Paragraph chunk6 = new Paragraph("\t\t\t\tNCB            :     " + ncb, FontFactory.GetFont("Arial", 9));
                Paragraph chunk7 = new Paragraph("\t\t\t\tEMAIL         :     " + email, FontFactory.GetFont("Arial", 9));
                Paragraph chunkLIN0 = new Paragraph("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 10));
                ///   chunk.set
                ///  chunk.SetUnderline(0.5f, -1.5f);
                ///  
                //////////////////////////////  Conteneur ////////////////////////////:

                Paragraph chunk12 = new Paragraph("   Conteneur", FontFactory.GetFont("Arial", 10));
                chunk.Alignment = Element.ALIGN_CENTER;
                chunk12.Alignment = Element.ALIGN_CENTER;
                Paragraph chunkLIN1 = new Paragraph("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 10));
                Paragraph chunkLIN01 = new Paragraph("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 10));

                Paragraph chunk22 = new Paragraph("\t\t\t\tN°                    :     " + Nc, FontFactory.GetFont("Arial", 9));
                Paragraph chunk32 = new Paragraph("\t\t\t\tDIMENSION    :     " + dim, FontFactory.GetFont("Arial", 9));
                Paragraph chunk42 = new Paragraph("\t\t\t\tTYPE               :     " + type, FontFactory.GetFont("Arial", 9));
                 

                string urlimg = "C:\\Users\\pc\\Documents\\Visual Studio 2012\\Projects\\pro_ma\\project_marsa\\Resources\\marsa-maroc-logo-E2DA20F4A6-seeklogo.com.png";
                iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(urlimg);

                ////////////////////////////////////stocke/////////////////////////////////////
                Paragraph sto = new Paragraph("Stockage", FontFactory.GetFont("Arial", 10));

                Paragraph st1 = new Paragraph("\t\t\t\tN°                :     " + Ns, FontFactory.GetFont("Arial", 9));
                Paragraph st2 = new Paragraph("\t\t\t\tDATE       :     " + date, FontFactory.GetFont("Arial", 9));
                Paragraph st3 = new Paragraph("\t\t\t\tPOSITION   :     " + position, FontFactory.GetFont("Arial", 9));
                Paragraph st4 = new Paragraph("\t\t\t\tID_co             :     " + ID_co, FontFactory.GetFont("Arial", 9));
                Paragraph st5 = new Paragraph("\t\t\t\tID_te           :     " + ID_ter, FontFactory.GetFont("Arial", 9));
                Paragraph soe = new Paragraph("sortie_entree", FontFactory.GetFont("Arial", 10));
                soe.Alignment = Element.ALIGN_CENTER;
                Paragraph s1t = new Paragraph("\t\t\t\tN°                :     " + id_so, FontFactory.GetFont("Arial", 9));
                Paragraph s2t = new Paragraph("\t\t\t\tDATE       :     " + date_so, FontFactory.GetFont("Arial", 9));
                Paragraph s3t = new Paragraph("\t\t\t\tPOSITION   :     " + types, FontFactory.GetFont("Arial", 9));
                Paragraph s4t = new Paragraph("\t\t\t\tID_client             :     " + id_cli, FontFactory.GetFont("Arial", 9));
                Paragraph s5t = new Paragraph("\t\t\t\tID_cont          :     " + ID_co, FontFactory.GetFont("Arial", 9));

                Paragraph sp = new Paragraph("Pointage", FontFactory.GetFont("Arial", 10));
                sp.Alignment = Element.ALIGN_CENTER;

                Paragraph sp1 = new Paragraph("\t\t\t\tN°                :     " + id_p, FontFactory.GetFont("Arial", 9));
                Paragraph sp2 = new Paragraph("\t\t\t\tDATE       :     " + date_p, FontFactory.GetFont("Arial", 9));
                Paragraph sp3 = new Paragraph("\t\t\t\tTYPE   :     " + type_p, FontFactory.GetFont("Arial", 9));
                Paragraph sp4 = new Paragraph("\t\t\t\tID_es             :     " + id_es, FontFactory.GetFont("Arial", 9));
                Paragraph sp5 = new Paragraph("\t\t\t\tID_co           :     " + id_cont, FontFactory.GetFont("Arial", 9));
                //////////////////////////:addition///////////////////////:
                sto.Alignment = Element.ALIGN_CENTER;

                png.ScaleToFit(140f, 120f);

                png.SpacingBefore = 10f;
                png.SpacingAfter = 100f;

                //p.Alignment = Element.ALIGN_CENTER;



                png.Alignment = Element.ALIGN_LEFT;
              s1.Add(png);
                //    d.Add(c1);
                ///  d.Add(chunk0);
                s1.Add(chunk);
                s1.Add(chunkLIN);
                s1.Add(chunk1);
                s1.Add(chunkLIN0);
                s1.Add(chunk2);
                s1.Add(chunk3);
                s1.Add(chunk4);
                s1.Add(chunk5);
                s1.Add(chunk6);
                s1.Add(chunk7);
                s1.Add(chunkLIN0);
                s1.Add(chunk12);
                s1.Add(chunkLIN1);
                s1.Add(chunk22);
                s1.Add(chunk32);
                s1.Add(chunk42);
                s1.Add(chunkLIN1);
                s1.Add(sto);
                s1.Add(chunkLIN1);
                s1.Add(st1);

                s1.Add(st2);
                s1.Add(st3);
                s1.Add(st4);
                s1.Add(st5);
                s1.Add(chunkLIN1);
                s1.Add(soe);
                s1.Add(chunkLIN1);
                s1.Add(s1t);
                s1.Add(s2t);
                s1.Add(s3t);
                s1.Add(s4t);
                s1.Add(s5t);
                s1.Add(chunkLIN1);
                s1.Add(sp);
                s1.Add(chunkLIN1);
                s1.Add(sp1);
                s1.Add(sp2);
                s1.Add(sp3);
                s1.Add(sp4);
                s1.Add(sp5);



                //  d.Add(p);
                s1.Close();
                MessageBox.Show("le rapport créé avec succès !");
            }
         
           
        }

        private void sending()
        {


            }


        private void show_conteneur()
        {



            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from conteneur";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();

                d.Fill(t, "conteneur");
                conteneur.DataSource = t.Tables["conteneur"].DefaultView;



            }




            catch (Exception ex)
            {


            }

            conn.Close();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            show_conteneur();

        }

        private int max_conteneur()
        {


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select max(id_conteneur)  from conteneur";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                int max = Int32.Parse(t.Rows[0][0].ToString());
                return max + 1;



            }




            catch (Exception ex)
            {
                return 1;

            }

            conn.Close();



        }


        private void button36_Click(object sender, EventArgs e)
        {

            String dim = comboBox1.Text.ToString();
            String type = comboBox2.Text.ToString();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = "insert into conteneur values (" + max_conteneur().ToString() + ",'" + dim + "','" + type + "')";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("Valider !");
                textBox37.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                show_conteneur();



            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas valider !");
                textBox37.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                show_conteneur();
            }

            conn.Close();
        }

        private void button35_Click(object sender, EventArgs e)
        {


            String ID = textBox37.Text;
            String dim = comboBox1.Text.ToString();
            String type = comboBox2.Text.ToString();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = "update conteneur set dimension = '" + dim + "' , type ='" + type + "' where id_conteneur =" + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("Bien modifier !");
                textBox37.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                show_conteneur();



            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas Modifier !");
                textBox37.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                show_conteneur();
            }

            conn.Close();

        }

        private void button34_Click(object sender, EventArgs e)
        {

            String ID = textBox37.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = "delete from conteneur  where  id_conteneur =" + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("Bien supprimer !");
                textBox37.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                show_conteneur();



            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est supprimer !");
                textBox37.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                show_conteneur();
            }

            conn.Close();
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                String rech = textBox27.Text;
                /* 
                  */
                if (rech == "")
                {
                    textBox37.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    show_conteneur();
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                    try
                    {



                        string query = "select *from conteneur where  id_conteneur in(select id_conteneur from pointage where id_escale in(select id_escale from escale where id_escale ="+rech+") )";

                        conn.Open();


                        SqlDataAdapter d = new SqlDataAdapter(query, conn);
                        DataSet t = new DataSet();
                        d.Fill(t, "conteneur");
                        conteneur.DataSource = t.Tables["conteneur"].DefaultView;
                        /**/
                        SqlCommand cmd = new SqlCommand(query, conn);
                        /////////   < FI GI > copyright © 2019 FST settat

                        SqlDataReader r = cmd.ExecuteReader();


                        l4.Clear();
                        textBox37.Text = "";
                        comboBox1.Text = "";
                        comboBox2.Text = "";



                        while (r.Read())
                        {
                            l4.Add(r[0].ToString());





                        }





                    }
                    catch (Exception es)
                    {


                    }
                    conn.Close();


                }




            }

            else if (radioButton1.Checked == true)
            {
                String rech = textBox27.Text;
                /* 
                  */
                if (rech == "")
                {
                    textBox37.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    show_conteneur();
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                    try
                    {



                        string query = "select *from conteneur where  id_conteneur in(select id_conteneur from sortie_entree where id_client in(select id_client from client where nom like '" + rech + "%') )";

                        conn.Open();


                        SqlDataAdapter d = new SqlDataAdapter(query, conn);
                        DataSet t = new DataSet();
                        d.Fill(t, "conteneur");
                        conteneur.DataSource = t.Tables["conteneur"].DefaultView;
                        /**/
                        SqlCommand cmd = new SqlCommand(query, conn);
                        /////////   < FI GI > copyright © 2019 FST settat

                        SqlDataReader r = cmd.ExecuteReader();


                        l4.Clear();
                        textBox37.Text = "";
                        comboBox1.Text = "";
                        comboBox2.Text = "";



                        while (r.Read())
                        {
                            l4.Add(r[0].ToString());





                        }





                    }
                    catch (Exception es)
                    {


                    }
                    conn.Close();


                }


            }
            else if (radioButton2.Checked == true)
            {
                String rech = textBox27.Text;
                /* 
                  */
                if (rech == "")
                {
                    textBox37.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    show_conteneur();
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                    try
                    {



                        string query = "select *from conteneur where  id_conteneur in(select id_conteneur from stocke where id_terminal in(select id_terminal from terminal where nom like '" + rech + "%') )";

                        conn.Open();


                        SqlDataAdapter d = new SqlDataAdapter(query, conn);
                        DataSet t = new DataSet();
                        d.Fill(t, "conteneur");
                        conteneur.DataSource = t.Tables["conteneur"].DefaultView;
                        /**/
                        SqlCommand cmd = new SqlCommand(query, conn);
                        /////////   < FI GI > copyright © 2019 FST settat

                        SqlDataReader r = cmd.ExecuteReader();


                        l4.Clear();
                        textBox37.Text = "";
                        comboBox1.Text = "";
                        comboBox2.Text = "";



                        while (r.Read())
                        {
                            l4.Add(r[0].ToString());





                        }





                    }
                    catch (Exception es)
                    {


                    }
                    conn.Close();


                }


            }


        }

        private void conteneur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void conteneur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conteneur.ReadOnly = true;
            int i = conteneur.CurrentCell.RowIndex;
            String query;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {

                if (textBox22.Text == "")
                {
                    query = "select *from conteneur where id_conteneur = " + (i + 1).ToString() + " ";


                }
                else
                {
                    string w = l4[i];
                    query = "select *from conteneur where id_conteneur = " + w + " ";

                }




                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                textBox37.Text = t.Rows[0][0].ToString();

                comboBox1.Text = t.Rows[0][1].ToString();
                comboBox2.Text = t.Rows[0][2].ToString();





            }




            catch (Exception ex)
            {
                ///   MessageBox.Show("Data incorrect !");


            }

            conn.Close();
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void show_terminal()
        {



            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select *from terminal";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();

                d.Fill(t, "terminal");
                terminal.DataSource = t.Tables["terminal"].DefaultView;



            }




            catch (Exception ex)
            {


            }

            conn.Close();

        }

        private void button40_Click(object sender, EventArgs e)
        {
            show_terminal();

        }

        private void button39_Click(object sender, EventArgs e)
        {

            String ID = textBox32.Text;
            String Nom = textBox34.Text;
            String capacite = comboBox3.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = "insert into terminal values (" + ID + ",'" + Nom + "'," + capacite + ")";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("Valider !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas valider !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }
            conn.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {


            String ID = textBox32.Text;



            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = " delete from terminal where id_terminal =" + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("supprimer !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas supprimer !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }
            conn.Close();

        }

        private void button38_Click(object sender, EventArgs e)
        {

            String ID = textBox32.Text;
            String Nom = textBox34.Text;
            String capacite = comboBox3.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = "update  terminal  set   nom ='" + Nom + "', capacite ='" + capacite + "' where id_terminal =" + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("Modifier !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas Modifier !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }
            conn.Close();

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            String rech = textBox31.Text;
            /* 
              */
            if (rech == "")
            {
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {



                    string query = "select *from terminal where  Nom like '" + rech + "%'";

                    conn.Open();


                    SqlDataAdapter d = new SqlDataAdapter(query, conn);
                    DataSet t = new DataSet();
                    d.Fill(t, "terminal");
                    terminal.DataSource = t.Tables["terminal"].DefaultView;
                    /**/
                    SqlCommand cmd = new SqlCommand(query, conn);
                    /////////   < FI GI > copyright © 2019 FST settat

                    SqlDataReader r = cmd.ExecuteReader();


                    l5.Clear();
                    textBox32.Text = "";
                    textBox34.Text = "";
                    comboBox3.Text = "";
                    



                    while (r.Read())
                    {
                        l5.Add(r[0].ToString());





                    }





                }
                catch (Exception es)
                {


                }
                conn.Close();

            }
        }

        private void terminal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void terminal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void client_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            client.ReadOnly = true;

            int i = (client.CurrentCell.RowIndex);

            string query;
            ///  MessageBox.Show(w);
            ///MessageBox.Show(i.ToString());
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {

                if (textBox7.Text == "")
                {
                    query = "select *from client where id_client = " + (i + 1).ToString() + " ";


                }
                else
                {
                    string w = l[i];
                    query = "select *from client where id_client = " + w + " ";

                }




                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                textBox1.Text = t.Rows[0][0].ToString();
                textBox2.Text = t.Rows[0][1].ToString();
                textBox4.Text = t.Rows[0][2].ToString();
                textBox3.Text = t.Rows[0][3].ToString();
                textBox6.Text = t.Rows[0][4].ToString();
                textBox5.Text = t.Rows[0][5].ToString();
                textBox8.Text = t.Rows[0][6].ToString();






            }




            catch (Exception ex)
            {
                ///   MessageBox.Show("Data incorrect !");


            }

            conn.Close();

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void pointage_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            pointage.ReadOnly = true;
            int i = pointage.CurrentCell.RowIndex;
            String query;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {

                if (textBox10.Text == "")
                {
                    query = "select *from pointage where id_pointage = " + (i + 1).ToString() + " ";


                }
                else
                {
                    string w = l2[i];
                    query = "select *from pointage where id_pointage = " + w + " ";

                }




                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                textBox20.Text = t.Rows[0][0].ToString();

                dateTimePicker1.Text = t.Rows[0][1].ToString();
                comboBox4.Text = t.Rows[0][2].ToString();
                textBox17.Text = t.Rows[0][3].ToString();
                textBox11.Text = t.Rows[0][4].ToString();





            }




            catch (Exception ex)
            {
                ///   MessageBox.Show("Data incorrect !");


            }

            conn.Close();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            String rech = textBox21.Text;
            if (textBox21.Text == "")
            {

                show_escale();
                textBox26.Text = "";
                dateTimePicker2.Text = "";
                textBox25.Text = "";
              
            }

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select  * from escale where Nom_escale like  '" + rech + "%' ";

                conn.Open();


                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataSet t = new DataSet();
                d.Fill(t, "escale");
                escale.DataSource = t.Tables["escale"].DefaultView;

                SqlCommand cmd = new SqlCommand(query, conn);
                /////////   < FI GI > copyright © 2019 FST settat

                SqlDataReader r = cmd.ExecuteReader();


                l6.Clear();

               
                textBox26.Text = "";
                dateTimePicker2.Text = "";
                textBox25.Text = "";


                while (r.Read())
                {
                    l6.Add(r[0].ToString());





                }





            }
            catch (Exception es)
            {
                textBox26.Text = "";
                dateTimePicker2.Text = "";
                textBox25.Text = "";


            }
            conn.Close();
        }

        private void escale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            escale.ReadOnly = true;
            int i = escale.CurrentCell.RowIndex;
            String query;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {

                if (textBox21.Text == "")
                {
                    query = "select *from escale where id_escale = " + (i + 1).ToString() + " ";


                }
                else
                {
                    string w = l6[i];
                    query = "select *from escale where id_escale = " + w + " ";

                }




                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                textBox26.Text = t.Rows[0][0].ToString();

                dateTimePicker2.Text = t.Rows[0][2].ToString();
                textBox25.Text = t.Rows[0][1].ToString();
               





            }




            catch (Exception ex)
            {
                ///   MessageBox.Show("Data incorrect !");


            }

            conn.Close();
        }

        private void escale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox31_TextChanged_1(object sender, EventArgs e)
        {

            String rech = textBox31.Text;
            /* 
              */
            if (rech == "")
            {
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {



                    string query = "select *from terminal where  Nom like '" + rech + "%'";

                    conn.Open();


                    SqlDataAdapter d = new SqlDataAdapter(query, conn);
                    DataSet t = new DataSet();
                    d.Fill(t, "terminal");
                    terminal.DataSource = t.Tables["terminal"].DefaultView;
                    /**/
                    SqlCommand cmd = new SqlCommand(query, conn);
                    /////////   < FI GI > copyright © 2019 FST settat

                    SqlDataReader r = cmd.ExecuteReader();


                    l5.Clear();
                    textBox32.Text = "";
                    textBox34.Text = "";
                    comboBox3.Text = "";




                    while (r.Read())
                    {
                        l5.Add(r[0].ToString());





                    }





                }
                catch (Exception es)
                {


                }
                conn.Close();
            }
        }

        private void terminal_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button40_Click_1(object sender, EventArgs e)
        {

        }

        private int max_terminal()
        {


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {



                string query = "select max(id_terminal) from terminal";

                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                int max = Int32.Parse(t.Rows[0][0].ToString());
                return max + 1;



            }




            catch (Exception ex)
            {
                return 1;

            }

            conn.Close();



        }

        private void button39_Click_1(object sender, EventArgs e)
        {

           /// String ID = textBox32.Text;
            String Nom = textBox34.Text;
            String capacite = comboBox3.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = "insert into terminal values (" + max_terminal().ToString() + ",'" + Nom + "'," + capacite + ")";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("Valider !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas valider !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }
            conn.Close();
        }

        private void button38_Click_1(object sender, EventArgs e)
        {

            String ID = textBox32.Text;
            String Nom = textBox34.Text;
            String capacite = comboBox3.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = "update  terminal  set   nom ='" + Nom + "', capacite ='" + capacite + "' where id_terminal =" + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("Modifier !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas Modifier !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }
            conn.Close();

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            String ID = textBox32.Text;



            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");

            try
            {



                string query = " delete from terminal where id_terminal =" + ID + "";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                MessageBox.Show("supprimer !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }




            catch (Exception ex)
            {
                MessageBox.Show("n'est pas supprimer !");
                textBox32.Text = "";
                textBox34.Text = "";
                comboBox3.Text = "";
                show_terminal();



            }
            conn.Close();

        }

        private void terminal_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            terminal.ReadOnly = true;
            int i = terminal.CurrentCell.RowIndex;
            String query;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {

                if (textBox31.Text == "")
                {
                    query = "select *from terminal where id_terminal = " + (i + 1).ToString() + " ";


                }
                else
                {
                    string w = l5[i];
                    query = "select *from terminal where id_terminal = " + w + " ";

                }




                conn.Open();
                SqlDataAdapter d = new SqlDataAdapter(query, conn);
                DataTable t = new DataTable();
                d.Fill(t);
                textBox32.Text = t.Rows[0][0].ToString();

                textBox34.Text = t.Rows[0][1].ToString();
               comboBox3.Text = t.Rows[0][2].ToString();





            }




            catch (Exception ex)
            {
                ///   MessageBox.Show("Data incorrect !");


            }

            conn.Close();

        
    }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            panel1.Size = new Size(61, 622);
            button19.Visible = false;
            button41.Visible = true;
            button41.Location = new Point(0,0);
            panel2.Visible = false;


              


        }

        private void button41_Click(object sender, EventArgs e)
        {

            panel1.Size = new Size(165, 622);
            button41.Visible = false;
            button19.Visible = true;
            panel2.Visible = true;
            button19.Location = new Point(0, 0);
        }

        private void send_Click(object sender, EventArgs e)
        {
            try{
            SmtpClient c = new SmtpClient("smtp.gmail.com",587);
                c.EnableSsl = true;
                c.Timeout = 10000;
                c.DeliveryMethod = SmtpDeliveryMethod.Network;
                c.UseDefaultCredentials = false;
                c.Credentials=new NetworkCredential("etusupa@gmail.com","hicham@widad");
                MailMessage msg=  new MailMessage();
       

                msg.To.Add("grazyhicham@gmail.com");
                msg.From = new MailAddress("etusupa@gmail.com");
                msg.Subject="hhhh";
                msg.Body ="hello hicham";
                c.Send(msg);


             MessageBox.Show("send");
            }catch(Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
}}

