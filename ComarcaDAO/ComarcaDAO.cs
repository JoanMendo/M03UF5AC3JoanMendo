using AC4.Utils;
using Npgsql;

namespace AC4.ComarcaDAO
{
    public class ComarcaDAO : IComarcaDAO
    {
        private readonly string connectionString;

        public ComarcaDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Region GetRegionById(int id)
        {
            Region region = null;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Comarca WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            region = NpgsqlUtils.GetRegion(reader);
                        }
                    }
                }
            }

            return region;
        }


        public List<Region> GetAllRegions()
        {
            List<Region> regions = new List<Region>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Comarca";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Region region = new Region
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Any = Convert.ToInt32(reader["year"]),
                                CodiComarca = Convert.ToInt32(reader["codicomarca"]),
                                NomComarca = reader["comarca"].ToString(),
                                Poblacio = Convert.ToInt32(reader["poblacio"]),
                                DomesticXarxa = Convert.ToInt32(reader["domesticxarxa"]),
                                ActivitatsEconomiques = Convert.ToInt32(reader["activitatseconomiques"]),
                                Total = Convert.ToInt32(reader["total"]),
                                ConsumDomesticCapita = Convert.ToDouble(reader["consumdomesticcapita"])
                            };

                            regions.Add(region);
                        }
                    }
                }
            }

            return regions;
        }

        public void AddRegion(Region region)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Comarca (year, codicomarca, comarca, poblacio, domesticxarxa, activitatseconomiques, total, consumdomesticcapita)
                         VALUES (@Any, @CodiComarca, @Comarca, @Poblacio, @DomesticXarxa, @ActivitatsEconomiques, @Total, @ConsumDomesticCapita)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Any", region.Any);
                    command.Parameters.AddWithValue("@CodiComarca", region.CodiComarca);
                    command.Parameters.AddWithValue("@Comarca", region.NomComarca);
                    command.Parameters.AddWithValue("@Poblacio", region.Poblacio);
                    command.Parameters.AddWithValue("@DomesticXarxa", region.DomesticXarxa);
                    command.Parameters.AddWithValue("@ActivitatsEconomiques", region.ActivitatsEconomiques);
                    command.Parameters.AddWithValue("@Total", region.Total);
                    command.Parameters.AddWithValue("@ConsumDomesticCapita", region.ConsumDomesticCapita);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRegion(Region region)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Comarca
                         SET year = @Any,
                             codicomarca = @CodiComarca,
                             comarca = @Comarca,
                             poblacio = @Poblacio,
                             domesticxarxa = @DomesticXarxa,
                             activitatseconomiques = @ActivitatsEconomiques,
                             total = @Total,
                             consumdomesticcapita = @ConsumDomesticCapita
                         WHERE ID = @ID";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Any", region.Any);
                    command.Parameters.AddWithValue("@CodiComarca", region.CodiComarca);
                    command.Parameters.AddWithValue("@Comarca", region.NomComarca);
                    command.Parameters.AddWithValue("@Poblacio", region.Poblacio);
                    command.Parameters.AddWithValue("@DomesticXarxa", region.DomesticXarxa);
                    command.Parameters.AddWithValue("@ActivitatsEconomiques", region.ActivitatsEconomiques);
                    command.Parameters.AddWithValue("@Total", region.Total);
                    command.Parameters.AddWithValue("@ConsumDomesticCapita", region.ConsumDomesticCapita);
                    command.Parameters.AddWithValue("@Id", region.Id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRegion(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = @"DELETE FROM Comarca WHERE Id = @Id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}