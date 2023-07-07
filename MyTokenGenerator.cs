using System;
using MySqlConnector;
namespace RestAPI {
    public class MyTokenGenerator {
        
        private Random random = new Random();
        private readonly char[] charset = "ABCDEFGHIJKLMOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!#$%&=?+-*_.".ToCharArray();
        private readonly MySqlConnection db_conn = new MySqlConnection("Server=127.0.0.1;User ID=accessapi;Password=kwefbwibcakebvuyevbiubqury38");

        MySqlCommand command;
        public string Token {get; set;}

        public string GenerateToken() {
            db_conn.Open();
            string result = "";
            for (int i = 0; i < 255; i++) {
                result += charset[random.Next(0, charset.Length)];
            }
            command = new MySqlCommand($"select token from proyecto.tokens where token='{result}'", db_conn);
            var reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows) result = GenerateToken();
            Token = result;
            db_conn.Close();
            return result;
        }

    }
}