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

            string to = "lescotoscar2@gmail.com";
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
            string requeteSQL = $"SELECT count(*) FROM User WHERE email='{mail}' AND motDePasse='{mdp}'";
            MySqlCommand cmd = new MySqlCommand(requeteSQL, conn);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            bool valide = false;
            while (reader.Read())
            {
                if (reader.GetInt32(0) == 1)
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

    }

}
