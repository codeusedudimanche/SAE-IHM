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

        public static ListeArret DeleteArret(int idArret)
        {
            string requeteSQL_1 = "DELETE FROM Arret WHERE `N°Arret` = @idArret";
            MySqlCommand cmd_1 = new MySqlCommand(requeteSQL_1, conn);
            cmd_1.Parameters.AddWithValue("@idArret", idArret);
            string requetSQL_2 = "DELETE FROM Ordre WHERE `N°Arret` = @idArret";
            MySqlCommand cmd_2 = new MySqlCommand(requetSQL_2, conn);
            cmd_2.Parameters.AddWithValue("@idArret", idArret);
            try
            {
                cmd_2.ExecuteNonQuery();
                cmd_1.ExecuteNonQuery();
                MessageBox.Show("Arret supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de l'arret : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd_2.Dispose();
                cmd_1.Dispose();
            }
            return GetArret();
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
        public static ListeArret GetArretDuneLigne(int idLigne)
        {
            string requeteSQL = "SELECT a.* FROM Arret a, Ordre o " +
                                "WHERE a.`N°Arret` = o.`N°Arret` " +
                                "AND o.`N°Ligne` = @nLigne " +
                                "ORDER BY o.Ordre";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@nLigne", idLigne);
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

        public static ListeHoraire GetHorairesPourArret(int nArret)
        {
            ListeHoraire listeHoraireWrapper = new ListeHoraire();
            string requeteSQL = "SELECT Horaire, Jour_Semaine, `N°Ligne`, `N°Arret` FROM Horaire " +
                                "WHERE `N°Arret` = @nArret " +
                                "ORDER BY `N°Ligne`, Jour_Semaine, Horaire";

            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@nArret", nArret);

            MySqlDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TimeSpan heure = reader.GetTimeSpan(0);
                    int jourSemaine = reader.GetInt32(1);
                    int nLigne = reader.GetInt32(2);
                    int nArretRecupere = reader.GetInt32(3);
                    listeHoraireWrapper.AjoutHoraire(heure, jourSemaine, nLigne, nArretRecupere);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des horaires pour l'arrêt {nArret} : {ex.Message}", "Erreur BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader?.Close();
                reader?.Dispose();
                cmd.Dispose();
            }
            return listeHoraireWrapper;
        }

        public static bool DeleteHoraire(Horaire horaire)
        {
            string requeteSQL = "DELETE FROM Horaire WHERE `N°Ligne` = @nLigne AND `N°Arret` = @nArret AND Jour_Semaine = @jourSemaine AND Horaire = @heure";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@nLigne", horaire.NLigne);
            cmd.Parameters.AddWithValue("@nArret", horaire.NArret);
            cmd.Parameters.AddWithValue("@jourSemaine", horaire.JourSemaine);
            cmd.Parameters.AddWithValue("@heure", horaire.Heure);
            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Horaire supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Aucun horaire trouvé à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de l'horaire : {ex.Message}", "Erreur BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cmd.Dispose();
            }
        }

        public static bool UpdateLigne(int idLigne, int newIdLigne, string NomLigne, string Destination)
        {
            string requeteSQL = "";
            MySqlCommand cmd;
            if (idLigne != newIdLigne)
            {

                // Vérifier si le nouvel ID de ligne existe déjà
                string checkSQL = "SELECT COUNT(*) FROM Ligne WHERE `N°Ligne` = @newIdLigne";
                MySqlCommand checkCmd = new MySqlCommand(checkSQL, conn);
                checkCmd.Parameters.AddWithValue("@newIdLigne", newIdLigne);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                checkCmd.Dispose();
                if (count > 0)
                {
                    MessageBox.Show("Le nouvel ID de ligne existe déjà. Veuillez choisir un autre ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    requeteSQL = "UPDATE Ligne SET `N°Ligne` = @newIdLigne WHERE `N°Ligne` = @id";
                    cmd = new MySqlCommand(requeteSQL, conn);
                    cmd.Parameters.AddWithValue("@newIdLigne", newIdLigne);
                    cmd.Parameters.AddWithValue("@id", idLigne);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la modification de l'ID de la ligne : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    finally
                    {
                        cmd.Dispose();
                    }
                }
            }
            requeteSQL = "UPDATE Ligne SET NomLigne = @nom, Destination = @destination WHERE `N°Ligne` = @id";
            cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@id", newIdLigne);
            cmd.Parameters.AddWithValue("@nom", NomLigne);
            cmd.Parameters.AddWithValue("@destination", Destination);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("La ligne a été modifiée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification de la ligne : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cmd.Dispose();
            }
        }
        public static bool SupprimerArretDuneLigne(int idLigne, int idArret)
        {
            string requeteSQL = "UPDATE Ordre SET Ordre = Ordre - 1 " +
                         "WHERE `N°Ligne` = @idLigne AND Ordre > (SELECT Ordre FROM Ordre WHERE `N°Arret` = @idArret AND `N°Ligne` = @idLigne)";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@idLigne", idLigne);
            cmd.Parameters.AddWithValue("@idArret", idArret);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour des ordres : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cmd.Dispose();
            }
            requeteSQL = "DELETE FROM Ordre WHERE `N°Ligne` = @idLigne AND `N°Arret` = @idArret";
            cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@idLigne", idLigne);
            cmd.Parameters.AddWithValue("@idArret", idArret);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de la suppression de l'arrêt de la ligne : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cmd.Dispose();
            }

            requeteSQL = "DELETE FROM Horaire WHERE `N°Ligne` = @idLigne AND `N°Arret` = @idArret";
            cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@idLigne", idLigne);
            cmd.Parameters.AddWithValue("@idArret", idArret);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression des horaires : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool UpdateDistance(int idLigne, int idArretA, int? idArretB)
        {
            //On verifie si c'est le dernier arret ou pas
            if (idArretB is null)
            {
                return false;
            }
            string RequeteSQL = "SELECT count(*) FROM Distance WHERE `N°ArretA` = @idArrB AND `N°Ligne` = @idL";
            MySqlCommand cmd = new MySqlCommand(RequeteSQL, conn);
            cmd.Parameters.AddWithValue("@idArrB", idArretB);
            cmd.Parameters.AddWithValue("@idL", idLigne);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            if (count == 1)
            {
                RequeteSQL = "UPDATE Distance SET Distance_Km = Distance_Km +   (SELECT Distance_Km FROM Distance WHERE `N°Ligne` = @idL AND `N°ArretA` " +
                    "= @NArretA AND `N°ArretB` = @NArretB) WHERE `N°Ligne` = @idL AND `N°ArretB` = NArretA";
                cmd = new MySqlCommand(RequeteSQL, conn);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la mise à jour de la distance : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    cmd.Dispose();
                }
                RequeteSQL = "DELETE FROM Distance WHERE `N°Ligne` = @idL AND `N°ArretA` = @NArretA AND `N°ArretB` = @NArretB";
                cmd = new MySqlCommand(RequeteSQL, conn);
                cmd.Parameters.AddWithValue("@idL", idLigne);
                cmd.Parameters.AddWithValue("@NArretA", idArretA);
                cmd.Parameters.AddWithValue("@NArretB", idArretB);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression de la distance : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    cmd.Dispose();
                }
                RequeteSQL = "UPDATE Distance SET `N°ArretB` = @NArretB WHERE `N°Ligne` = @idL AND `N°ArretB` = @NArretA";
                cmd = new MySqlCommand(RequeteSQL, conn);
                cmd.Parameters.AddWithValue("@NArretB", idArretB);
                cmd.Parameters.AddWithValue("@idL", idLigne);
                cmd.Parameters.AddWithValue("@NArretA", idArretA);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la mise à jour de l'arrêt B : {ex}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    cmd.Dispose();
                }
                return true;
            }
            return false;


        }

        public static (List<Horaire>, List<int>) GetHoraireLigneArret(int idLigne, int idArret)
        {
            string requeteSQL = "SELECT Horaire, Jour_Semaine FROM Horaire " +
                                "WHERE `N°Ligne` = @idLigne AND `N°Arret` = @idArret " +
                                "ORDER BY Jour_Semaine, Horaire";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.Parameters.AddWithValue("@idLigne", idLigne);

            cmd.Parameters.AddWithValue("@idArret", idArret);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Horaire> horaires = new List<Horaire>();
            List<int> joursSemaine = new List<int>();
            while (reader.Read())
            {
                TimeSpan heure = reader.GetTimeSpan(0);
                int jourSemaine = reader.GetInt32(1);
                horaires.Add(new Horaire(heure, jourSemaine, idLigne, idArret));            
                joursSemaine.Add(jourSemaine);
            }
            reader.Close();
            cmd.Dispose();
            if (horaires.Count > 0)
            {
                return (horaires, joursSemaine);
            }
            else
            {
                
                return (new List<Horaire>(), new List<int>());
            }
        }
    }
}
