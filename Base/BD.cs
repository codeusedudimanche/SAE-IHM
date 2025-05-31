using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;


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



    }

}
