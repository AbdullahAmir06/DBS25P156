using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P156
{
    public class ItecEditionFormHandler
    {
        public void AddEdition(int editionYear, string editionTheme, string editionDescription)
        {
            string query = $"INSERT INTO itec_editions (year, theme, description) VALUES ({editionYear}, '{editionTheme}', '{editionDescription}')";
            DatabaseHelper.Instance.ExecuteQuery(query);
        }

        public void DeleteEdition(int editionYear)
        {
            string query = $"DELETE FROM itec_editions WHERE year = {editionYear}";
            DatabaseHelper.Instance.ExecuteQuery(query);
        }

        public bool CheckEdition(int editionYear)
        {
            string query = $"SELECT COUNT(*) FROM itec_editions WHERE year = {editionYear}";

            //Console.WriteLine("Executing Query: " + query);

            int count = Convert.ToInt32(DatabaseHelper.Instance.CheckIfExists(query));

            //MessageBox.Show("Year Checked: " + editionYear + "\nSQL Count: " + count);
            return count > 0;
        }

        public List <int> GetEdition()
        {
            string query = $"SELECT year FROM itec_editions";
            List<object> columnValues =  DatabaseHelper.Instance.GetColumn(query);

            List<int> editionYears = columnValues.Select(value => Convert.ToInt32(value)).ToList();

            return editionYears;
        }
}
}
