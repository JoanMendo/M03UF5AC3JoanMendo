using Microsoft.Extensions.Configuration;
using Npgsql;



namespace AC4.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"C:\Users\joanm\source\repos\WinFormsApp1\AppSettings\appsettings.json")
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static Region GetRegion(NpgsqlDataReader reader)
        {
            Region r = new Region
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                Any = reader.GetInt32(reader.GetOrdinal("Year")),
                CodiComarca = reader.GetInt32(reader.GetOrdinal("CodiComarca")),
                NomComarca = reader.GetString(reader.GetOrdinal("Comarca")),
                Poblacio = reader.GetInt32(reader.GetOrdinal("Poblacio")),
                DomesticXarxa = reader.GetInt32(reader.GetOrdinal("DomesticXarxa")),
                ActivitatsEconomiques = reader.GetInt32(reader.GetOrdinal("ActivitatsEconomiques")),
                Total = reader.GetInt32(reader.GetOrdinal("Total")),
                ConsumDomesticCapita = reader.GetDouble(reader.GetOrdinal("ConsumDomesticCapita")),
            };
            return r;
        }
    }
}