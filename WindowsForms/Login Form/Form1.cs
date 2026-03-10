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
using System.Diagnostics;
namespace Login_Form
{
    public partial class Form1 : Form
    {
        bool isLogin = true;
        readonly string connectionString = "Server=MUNEESPC;Database=MuneesDB;User ID=Munees;Password=Munees@123;Trusted_Connection=True;";
        SqlConnection connection;
        public Form1()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                Debug.WriteLine("Connection successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
        }

        void changeMode()
        {
            if (isLogin)
            {
                title.Text = "Register";
                submit.Text = "Register";
                info.Text = "Already have an account?";
            }
            else
            {
                title.Text = "Login";
                submit.Text = "Login";
                info.Text = "Don't have an account?";
            }
            isLogin = !isLogin;
        }
        private void label10_Click(object sender, EventArgs e)
        {
            changeMode();
        }
        void HandleLogin()
        {
            connection.Open();
            string selectQuery = "SELECT * FROM Users WHERE Email = @email";
            
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@email", email.Text);

            SqlDataReader reader = selectCommand.ExecuteReader();
            
            if(reader.Read())
            {
                if (reader["Pass"].ToString() == pass.Text && reader["UName"].ToString() == user.Text)
                {
                    MessageBox.Show("Login successful");
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }   
            else
            {
                MessageBox.Show("User not found");
            }
            connection.Close();
        }

        void  HandleRegister()
        {
            string insertQuery = "INSERT INTO Users (UName, Email, Pass) VALUES (@uname, @email, @pass)";
            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.Parameters.AddWithValue("@Uname", user.Text);
            insertCommand.Parameters.AddWithValue("@Email", email.Text);
            insertCommand.Parameters.AddWithValue("@Pass", pass.Text);
            connection.Open();
            insertCommand.ExecuteNonQuery();
            MessageBox.Show("Registration successful");
            connection.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if(isLogin)
                {
                    HandleLogin();
                }
                else
                {
                    HandleRegister();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
