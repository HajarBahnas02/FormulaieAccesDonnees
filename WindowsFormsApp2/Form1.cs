using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{ 
       public partial class Form1 : Form
        {
            string last_click_on = "";
            string Nom;
            string Prenom;

            static string chaine = @"Data Source=(LocalDB)\MSSQLLocalDB ;Initial Catalog=etudiant;Integrated Security=True";
            static SqlConnection cnx = new SqlConnection(chaine);
            static SqlCommand cmd = new SqlCommand();
            static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            public Form1()
            {
                InitializeComponent();
            }
            public void turn_On_Off(Button btn, bool b)
            {
                btn.Enabled = b;
                if (b)
                {
                    btn.BackColor = Color.White;
                

                }
                else
                {
                    btn.BackColor = Color.Gray;
                }
            }

            public bool tableHasRows()
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT nom FROM Etudiant;";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    cnx.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    cnx.Close();
                    return true;
                }
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                turn_On_Off(BtnAjouter, true);
                turn_On_Off(BtnModifier, false);
                turn_On_Off(BtnSupprimer, false);
                turn_On_Off(BtnEnregistrer, false);
                turn_On_Off(BtnAnnuler, false);

                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "select   nom,id  from Etudiant";

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow itemrow = dt.NewRow();
                itemrow[0] = "select name";
                dt.Rows.InsertAt(itemrow, 0);

                Cbx.DataSource = dt;
                Cbx.ValueMember = "id";
                Cbx.DisplayMember = "nom ";

                cnx.Close();

                if (tableHasRows())
                {
                    turn_On_Off(BtnModifier, true);
                    turn_On_Off(BtnSupprimer, true);
                }
            }
            private void BtnAjouter_Click(object sender, EventArgs e)
            {
                last_click_on = "ajouter";
                {
                    Cbx.Enabled = false;
                    Cbx.BackColor = Color.Gray;

                    txtBoxNom.Enabled = true;
                    txtBoxNom.BackColor = Color.White;

                    txtBoxPrenom.Enabled = true;
                    txtBoxPrenom.BackColor = Color.White;

                    turn_On_Off(BtnAjouter, false);
                    turn_On_Off(BtnModifier, false);
                    turn_On_Off(BtnSupprimer, false);
                    turn_On_Off(BtnEnregistrer, true);
                    turn_On_Off(BtnAnnuler, true);
                }
            }
            private void BtnModifier_Click(object sender, EventArgs e)
            {
                last_click_on = "modifier";
                {
                    Cbx.Enabled = false;
                    Cbx.BackColor = Color.Gray;

                    txtBoxNom.Enabled = true;
                    txtBoxNom.BackColor = Color.White;

                    txtBoxPrenom.Enabled = true;
                    txtBoxPrenom.BackColor = Color.White;

                    turn_On_Off(BtnAjouter, false);
                    turn_On_Off(BtnModifier, false);
                    turn_On_Off(BtnSupprimer, false);
                    turn_On_Off(BtnEnregistrer, true);
                    turn_On_Off(BtnAnnuler, true);
                }
            }
            private void BtnSupprimer_Click(object sender, EventArgs e)
            {
                last_click_on = "supprimer";
                {
                    Cbx.Enabled = true;
                    Cbx.BackColor = Color.White;

                    txtBoxNom.Enabled = false;
                    txtBoxNom.BackColor = Color.Gray;

                    txtBoxPrenom.Enabled = false;
                    txtBoxPrenom.BackColor = Color.Gray;

                    turn_On_Off(BtnAjouter, false);
                    turn_On_Off(BtnModifier, false);
                    turn_On_Off(BtnSupprimer, false);
                    turn_On_Off(BtnEnregistrer, true);
                    turn_On_Off(BtnAnnuler, true);
                }
            }
            private void BtnEnregistrer_Click(object sender, EventArgs e)
            {
                if (last_click_on == "ajouter")
                {
                    /*a propos des buttons*/
                    {
                        Cbx.Enabled = true;
                        Cbx.BackColor = Color.White;

                        txtBoxNom.Enabled = false;
                        txtBoxNom.BackColor = Color.Gray;

                        txtBoxPrenom.Enabled = false;
                        txtBoxPrenom.BackColor = Color.Gray;

                        turn_On_Off(BtnAjouter, true);
                        turn_On_Off(BtnModifier, true);
                        turn_On_Off(BtnSupprimer, true);
                        turn_On_Off(BtnEnregistrer, false);
                        turn_On_Off(BtnAnnuler, false);
                    }
                    /*a propos de la requete */
                    {
                        Nom = txtBoxNom.Text;
                        Prenom = txtBoxPrenom.Text;
                        if (Nom == "" || Prenom == "")
                        {
                            Console.WriteLine("invalid nom et prenom");
                            return;
                        }
                        cnx.Open();
                        cmd.Connection = cnx;
                        cmd.CommandText = "insert into Etudiant( prenom,nom ) values('" + Prenom + " ','" + Nom + "')";
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                        txtBoxNom.Text = "";
                        txtBoxPrenom.Text = "";

                        Nom = txtBoxNom.Text;
                        Prenom = txtBoxPrenom.Text;
                    }
                }
                else if (last_click_on == "supprimer")
                {
                    /*a propos des buttons*/
                    {
                        Cbx.Enabled = true;
                        Cbx.BackColor = Color.White;

                        txtBoxNom.Enabled = false;
                        txtBoxNom.BackColor = Color.Gray;

                        txtBoxPrenom.Enabled = false;
                        txtBoxPrenom.BackColor = Color.Gray;

                        turn_On_Off(BtnAjouter, true);
                        turn_On_Off(BtnModifier, false);
                        turn_On_Off(BtnSupprimer, false);
                        turn_On_Off(BtnEnregistrer, false);
                        turn_On_Off(BtnAnnuler, false);
                        if (tableHasRows())
                        {
                            turn_On_Off(BtnModifier, true);
                            turn_On_Off(BtnSupprimer, true);
                        }
                    }
                    /*a propos de la  requete */
                    {
                        cnx.Open();
                        cmd.Connection = cnx;
                        string deleted_id = Cbx.SelectedValue.ToString();
                        Console.WriteLine(deleted_id);
                        cmd.CommandText = "delete from Etudiant where id ='" + deleted_id + "' ";
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                    }
                }
                else if (last_click_on == "modifier")
                {

                    /*a propos des button*/
                    {
                        Cbx.Enabled = true;
                        Cbx.BackColor = Color.White;

                        txtBoxNom.Enabled = false;
                        txtBoxNom.BackColor = Color.Gray;

                        txtBoxPrenom.Enabled = false;
                        txtBoxPrenom.BackColor = Color.Gray;

                        turn_On_Off(BtnAjouter, true);
                        turn_On_Off(BtnModifier, true);
                        turn_On_Off(BtnSupprimer, true);
                        turn_On_Off(BtnEnregistrer, false);
                        turn_On_Off(BtnAnnuler, false);
                    }
                    /*a propos de la  requete */
                    {
                        cnx.Open();
                        cmd.Connection = cnx;
                        string modified_id = Cbx.SelectedValue.ToString();
                        cmd.CommandText = " update Etudiant set nom ='" + txtBoxNom.Text + "', prenom = '" + txtBoxPrenom.Text + "' where id= '" + modified_id + "' ;";
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                    }
                }

                /* affichage de la combobox*/
                {
                    cnx.Open();
                    cmd.Connection = cnx;
                    cmd.CommandText = "select   nom,id  from Etudiant";
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow itemrow = dt.NewRow();
                    itemrow[0] = "select name";
                    dt.Rows.InsertAt(itemrow, 0);

                    Cbx.DataSource = dt;
                    Cbx.DisplayMember = "nom ";
                    Cbx.ValueMember = "id";
                    cnx.Close();
                }
            }
            private void BtnAnnuler_Click(object sender, EventArgs e)
            {
                if (last_click_on == "ajouter")
                {
                    /*a propos des button*/
                    {
                        if (!tableHasRows())
                        {
                            turn_On_Off(BtnModifier, false);
                            turn_On_Off(BtnSupprimer, false);
                        }
                        else
                        {
                            turn_On_Off(BtnModifier, true);
                            turn_On_Off(BtnSupprimer, true);
                        }


                        Cbx.Enabled = true;
                        Cbx.BackColor = Color.White;

                        txtBoxNom.Enabled = false;
                        txtBoxNom.BackColor = Color.Gray;

                        txtBoxPrenom.Enabled = false;
                        txtBoxPrenom.BackColor = Color.Gray;

                        turn_On_Off(BtnAjouter, true);
                        turn_On_Off(BtnEnregistrer, false);
                        turn_On_Off(BtnAnnuler, false);
                    }


                }
                else if (last_click_on == "supprimer")
                {
                    /*a propos des button*/
                    {
                        Cbx.Enabled = true;
                        Cbx.BackColor = Color.White;

                        txtBoxNom.Enabled = false;
                        txtBoxNom.BackColor = Color.Gray;

                        txtBoxPrenom.Enabled = false;
                        txtBoxPrenom.BackColor = Color.Gray;

                        turn_On_Off(BtnAjouter, true);
                        turn_On_Off(BtnModifier, true);
                        turn_On_Off(BtnSupprimer, true);
                        turn_On_Off(BtnEnregistrer, false);
                        turn_On_Off(BtnAnnuler, false);
                    }

                }
                else if (last_click_on == "modifier")
                {
                    /*a propos des button*/
                    {
                        Cbx.Enabled = true;
                        Cbx.BackColor = Color.White;

                        txtBoxNom.Enabled = false;
                        txtBoxNom.BackColor = Color.Gray;

                        txtBoxPrenom.Enabled = false;
                        txtBoxPrenom.BackColor = Color.Gray;

                        turn_On_Off(BtnAjouter, true);
                        turn_On_Off(BtnModifier, true);
                        turn_On_Off(BtnSupprimer, true);
                        turn_On_Off(BtnEnregistrer, false);
                        turn_On_Off(BtnAnnuler, false);
                    }

                }

                /* affichage de combobox*/
                {
                    cnx.Open();
                    cmd.Connection = cnx;
                    cmd.CommandText = "select   nom,id  from Etudiant";
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow itemrow = dt.NewRow();
                    itemrow[0] = "select name";
                    dt.Rows.InsertAt(itemrow, 0);

                    Cbx.DataSource = dt;
                    Cbx.ValueMember = "id";
                    Cbx.DisplayMember = "nom ";
                    cnx.Close();
                }
            }

        }
}
}