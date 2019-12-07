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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text="";
            label4.Text="";

            Form2 f = new Form2();

            // f.tclient();
            //f.tpointage();
            // f.tstocke();

            f.Show();

            this.Visible = false;
            
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {


            



          
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
           

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void label4_MouseHover_1(object sender, EventArgs e)
        {
            

        }

        private void label4_MouseLeave_1(object sender, EventArgs e)
        {
            

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
            //timer1.Start();


        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkOrange;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;

        }

        private void button1_ForeColorChanged(object sender, EventArgs e)
        {

        }
       
        
        private void button2_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
            try
            {
                if (user == "" || pass == "")
                {
                    label4.Text="";
                    label3.Text = "s'il vous plaît entrer les données !";
                   /// MessageBox.Show("please entre user and password !");
                }
                else
                {

                    string query = "select *from login  where [user] ='" + user + "' and password = '" + pass + "' ";

                    conn.Open();
                    SqlDataAdapter d = new SqlDataAdapter(query, conn);
                    DataTable t = new DataTable();
                    d.Fill(t);
                    
                    /// MessageBox.Show(t.Rows[0][3].ToString());

                    if (t.Rows[0][3].ToString() == "admin     ")
                    {
                        Form2 f = new Form2();

                      // f.tclient();
                       //f.tpointage();
                     // f.tstocke();

                        f.Show();
                      
                        this.Visible = false;


                    }
                    else if (t.Rows[0][3].ToString() == "pointage  ")
                    { 
                    
                    
                        Form2 f = new Form2();


                        f.tpointage();


                          f.Show();
                        this.Visible = false;





                    }
                    else if (t.Rows[0][3].ToString() == "client    ")
                    {



                        Form2 f = new Form2();


                        f.tclient();


                        f.Show();
                        this.Visible = false;

                    }
                    else if (t.Rows[0][3].ToString() == "stockage  ")
                    {
                    
                    
                    
                    
                        Form2 f = new Form2();


                        f.tstocke();


                          f.Show();
                        this.Visible = false;

                    }


                }



            }
            catch (Exception ex)
            {
                label3.Text="";
                label4.Text = "Les données sont incorrectes!";
                //MessageBox.Show("Data incorrect !");
            
            
            }
           
            conn.Close();

        }
        int mov;
        int movx;
        int movy;


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //mov = 1;
            //movx = e.X;
            //movy = e.Y;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (mov == 1)
            //{

              ///  this.SetDesktopLocation( movx,  movy);


           /// }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ///mov = 0;

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                Point p = PointToScreen(e.Location);


                Location = new Point(p.X - this.movx, p.Y - this.movy);



              }

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if(e.KeyChar == 13)
            {


                String user = textBox1.Text;
                String pass = textBox2.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {
                    if (user == "" || pass == "")
                    {
                        label4.Text = "";
                        label3.Text = "s'il vous plaît entrer les données !";
                        /// MessageBox.Show("please entre user and password !");
                    }
                    else
                    {

                        string query = "select *from login  where [user] ='" + user + "' and password = '" + pass + "' ";

                        conn.Open();
                        SqlDataAdapter d = new SqlDataAdapter(query, conn);
                        DataTable t = new DataTable();
                        d.Fill(t);

                        /// MessageBox.Show(t.Rows[0][3].ToString());

                        if (t.Rows[0][3].ToString() == "admin     ")
                        {
                            Form2 f = new Form2();

                            // f.tclient();
                            //f.tpointage();
                            // f.tstocke();

                            f.Show();

                            this.Visible = false;


                        }
                        else if (t.Rows[0][3].ToString() == "pointage  ")
                        {


                            Form2 f = new Form2();


                            f.tpointage();


                            f.Show();
                            this.Visible = false;





                        }
                        else if (t.Rows[0][3].ToString() == "client    ")
                        {



                            Form2 f = new Form2();


                            f.tclient();


                            f.Show();
                            this.Visible = false;

                        }
                        else if (t.Rows[0][3].ToString() == "stockage  ")
                        {




                            Form2 f = new Form2();


                            f.tstocke();


                            f.Show();
                            this.Visible = false;

                        }


                    }



                }
                catch (Exception ex)
                {
                    label3.Text = "";
                    label4.Text = "Les données sont incorrectes!";
                    //MessageBox.Show("Data incorrect !");


                }

                conn.Close();
              
                                   
            }*/


            }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                String user = textBox1.Text;
                String pass = textBox2.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\marsa_project.mdf;Integrated Security=True");
                try
                {
                    if (user == "" || pass == "")
                    {
                        label4.Text = "";
                        label3.Text = "please entre user and password !";
                        /// MessageBox.Show("please entre user and password !");
                    }
                    else
                    {

                        string query = "select *from login  where [user] ='" + user + "' and password = '" + pass + "' ";

                        conn.Open();
                        SqlDataAdapter d = new SqlDataAdapter(query, conn);
                        DataTable t = new DataTable();
                        d.Fill(t);

                        /// MessageBox.Show(t.Rows[0][3].ToString());

                        if (t.Rows[0][3].ToString() == "admin     ")
                        {
                            Form2 f = new Form2();
                            f.Show();
                            this.Visible = false;

                        }



                    }



                }
                catch (Exception ex)
                {
                    label3.Text = "";
                    label4.Text = "Data incorrect !";
                    //MessageBox.Show("Data incorrect !");


                }

                conn.Close();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {

                Opacity = Opacity - 0.3;
            }
            else
            {

                timer1.Stop();
                Application.Exit();


            }
        }
          
        }
    }

