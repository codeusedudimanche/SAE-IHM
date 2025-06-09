using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Tls;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace Base
{
    public static class BD
    {
        private static MySqlConnection conn;
        public static bool Connexion()
        {

            string serveur = "10.1.139.236";
            string login = "f3";
            string mdp = "mdp";
            string bd = "basef3";
            string chaineConnexion = $"Server={serveur} ;Database={bd};Uid={login};Pwd={mdp}";
            try
            {
                conn = new MySqlConnection(chaineConnexion);
                conn.Open();
                MessageBox.Show("Connexion réussie !");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex}");
                return false;
            }
        }

        public static bool Deconnexion()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    conn.Close();
                    conn.Dispose();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        public static void MotDePasseOubliee()
        {
            var rand = new Random();

            //Nombre aléatoire entre 100 000 et 999 999
            int nombre = rand.Next() % 900000 + 100000;

            string to = "lescotoscar@gmail.com";
            string from = "contactmytulsa@gmail.com\r\n";
            string subject = "Reinitialisation du Mot de passe";
            string body = $"Voici votre code de verification pour reinitialiser votre mot de passe : {nombre}";

            MailMessage message = new MailMessage(from, to, subject, body);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(from, "vdci owez zzzq imso\r\n");


            try
            {
                client.Send(message);
                MessageBox.Show("Message envoyé !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex}");
            }
        }

        public static bool VerificationConnexion(string mail, string mdp)
        {
            string requeteSQL = $"SELECT count(*) FROM User WHERE email='{mail}' " +
                $"AND motDePasse='{mdp}' OR pseudo ='{mail}' AND  motDePasse='{mdp}'";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            bool valide = false;
            while (reader.Read())
            {
                if (reader.GetInt32(0) > 0)
                {
                    valide = true;
                }
                else
                {
                    valide = false;
                }
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();

            if (valide)
            {
                return true;
            }
            return false;
        }
        public static bool AjoutArret(int idArret, string nomArret, double latitude, double longitude)
        {
            string requeteSQL = "INSERT INTO Arret(`N°Arret`, NomArret, LongitudeArret, LatitudeArret) " +
                        "VALUES (@idArret, @nomArret, @longitude, @latitude)";

            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@idArret", idArret);
            cmd.Parameters.AddWithValue("@nomArret", nomArret);
            cmd.Parameters.AddWithValue("@longitude", longitude);
            cmd.Parameters.AddWithValue("@latitude", latitude);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de l'arrêt : {ex}");
                return false;
            }
            finally
            {
                cmd.Dispose();
            }


        }

        public static ListeArret GetArret()
        {
            string requeteSQL = "SELECT * FROM Arret";
            ListeArret L = new ListeArret();
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idArret = reader.GetInt32(0);
                string nomArret = reader.GetString(1);
                double longitudeArret = reader.GetDouble(2);
                double latitudeArret = reader.GetDouble(3);
                L.AjoutArret(idArret, nomArret, longitudeArret, latitudeArret);
            }
            reader.Close();
            cmd.Dispose();
            return L;
        }
        public static bool AjoutOrdre(int nLigne, int nArret, int ordre)
        {
            string requeteSQL = "INSERT INTO Ordre(`N°Ligne`, `N°Arret`, Ordre) " +
                        "VALUES (@nLigne, @nArret, @ordre)";

            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@nLigne", nLigne);
            cmd.Parameters.AddWithValue("@nArret", nArret);
            cmd.Parameters.AddWithValue("@ordre", ordre);
            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
        }
        public static bool AjoutLigne(int id, string nom, string destination, List<Arret> listeArret)
        {
            string requeteSQL = "INSERT INTO Ligne(`N°Ligne`, NomLigne, Destination) " +
                        "VALUES (@idLigne, @NomLigne, @Destination)";

            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@idLigne", id);
            cmd.Parameters.AddWithValue("@NomLigne", nom);
            cmd.Parameters.AddWithValue("@Destination", destination);
            bool AjoutLigneValide = false;
            try
            {
                cmd.ExecuteNonQuery();
                AjoutLigneValide = true;
                for (int i = 0; i < listeArret.Count; i++)
                {
                    int nArret = listeArret[i].Id;
                    int ordre = i + 1;

                    BD.AjoutOrdre(id, nArret, ordre);
                }

                return true;
            }
            catch (Exception ex)
            {
                if (!AjoutLigneValide)
                    MessageBox.Show($"Erreur lors de l'ajout de la ligne : {ex}");
                return false;
            }
            finally
            {
                cmd.Dispose();
            }
        }


        public static ListeLigne GetLigne()
        {
            string requeteSQL = "SELECT * FROM Ligne";
            ListeLigne L = new ListeLigne();
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idLigne = reader.GetInt32(0);
                string nomLigne = reader.GetString(1);
                string destinationLigne = reader.GetString(2);
                L.AjoutLigne(idLigne, nomLigne, destinationLigne);
            }
            reader.Close();
            cmd.Dispose();
            return L;
        }

        public static ListeLigne DeleteLigne(int idLigne)
        {
            string requeteSQL_1 = "DELETE FROM Ligne WHERE `N°Ligne` = @idLigne";
            MySqlCommand cmd_1 = new MySqlCommand(requeteSQL_1, conn);
            cmd_1.Parameters.AddWithValue("@idLigne", idLigne);
            string requetSQL_2 = "DELETE FROM Ordre WHERE `N°Ligne` = @idLigne";
            MySqlCommand cmd_2 = new MySqlCommand(requetSQL_2, conn);
            cmd_2.Parameters.AddWithValue("@idLigne", idLigne);
            try
            {
                cmd_2.ExecuteNonQuery();
                cmd_1.ExecuteNonQuery();
                MessageBox.Show("Ligne supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de la ligne : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd_2.Dispose();
                cmd_1.Dispose();
            }
            return GetLigne();
        }
        public static ListeArret listeArretDeLigne(Ligne ligne)
        {
            string requeteSQL = "SELECT a.* FROM Arret a,Ordre o  " +
                                "WHERE a.`N°Arret` = o.`N°Arret` " +
                                "AND o.`N°Ligne` = @nLigne " +
                                "ORDER BY o.Ordre";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@nLigne", ligne.NLigne);
            ListeArret listeArret = new ListeArret();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idArret = reader.GetInt32(0);
                string nomArret = reader.GetString(1);
                double longitudeArret = reader.GetDouble(2);
                double latitudeArret = reader.GetDouble(3);
                listeArret.AjoutArret(idArret, nomArret, longitudeArret, latitudeArret);
            }
            reader.Close();
            cmd.Dispose();
            return listeArret;
        }

        public static bool AjoutHorraire(int jourSemaine, int Nligne, int NArret, string time)
        {
            bool result = false;
            string requeteSQL = "INSERT INTO Horaire(`Jour_Semaine`, `N°Ligne`, `N°Arret`, Horaire) " +
                        "VALUES (@jourSemaine, @nLigne, @nArret, @time)";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@jourSemaine", jourSemaine);
            cmd.Parameters.AddWithValue("@nLigne", Nligne);
            cmd.Parameters.AddWithValue("@nArret", NArret);
            cmd.Parameters.AddWithValue("@time", time);
            try
            {
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de l'horaire : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                result = false;
            }
            finally
            {
                cmd.Dispose();
            }
            return result;
        }

        public static Arret InfoArret(int idArret)
        {
            string requeteSQL = " SELECT * FROM Arret WHERE `N°Arret` = @nArret";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@nArret", idArret);
            MySqlDataReader reader = cmd.ExecuteReader();
            Arret arret = null;
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nom = reader.GetString(1);
                double longitude = reader.GetDouble(2);
                double latitude = reader.GetDouble(3);
                arret = new Arret(id, nom, longitude, latitude);


            }
            else
            {
                MessageBox.Show("Aucun arrêt trouvé avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
            cmd.Dispose();
            return arret;
        }
        public static ListeLigne GetListeLigneArret(int idArret)
        {
            string requeteSQL = "SELECT Ligne.* FROM Ordre, Ligne WHERE `N°Arret` = @idArret AND Ordre.N°Ligne = Ligne.N°Ligne";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@idArret", idArret);
            MySqlDataReader reader = cmd.ExecuteReader();
            ListeLigne listeLigne = new ListeLigne();
            while (reader.Read())
            {
                int idLigne = reader.GetInt32(0);
                string nomLigne = reader.GetString(1);
                string destinationLigne = reader.GetString(2);
                listeLigne.AjoutLigne(idLigne, nomLigne, destinationLigne);
            }
            reader.Close();
            cmd.Dispose();
            return listeLigne;
        }

        public static void SupprimerLigneDunArret(int idArret, int idLigne)
        {
            string requeteSQL = "DELETE FROM Ordre WHERE `N°Arret` = @idArret AND `N°Ligne` = @idLigne";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@idArret", idArret);
            cmd.Parameters.AddWithValue("@idLigne", idLigne);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            requeteSQL = "DELETE FROM Horaire WHERE `N°Arret` = @idArret AND `N°Ligne` = @idLigne";
            cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@idArret", idArret);
            cmd.Parameters.AddWithValue("@idLigne", idLigne);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            requeteSQL = "UPDATE Ordre SET Ordre = Ordre - 1 " +
                         "WHERE `N°Ligne` = @idLigne AND Ordre > (SELECT Ordre FROM Ordre WHERE `N°Arret` = @idArret AND `N°Ligne` = @idLigne)";
            cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@idLigne", idLigne);
            cmd.Parameters.AddWithValue("@idArret", idArret);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            
            MessageBox.Show("Ligne supprimée de l'arrêt avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool ModifArret(int id, string nom, double longi, double lat)
        {
            string requeteSQL = "UPDATE Arret SET NomArret = @nom, LongitudeArret = @long, LatitudeArret = @lat WHERE `N°Arret` = @id";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@long", longi);
            cmd.Parameters.AddWithValue("@lat", lat);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'arrêt a été modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification de l'arrêt : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cmd.Dispose();
            }

        }
    }
}
