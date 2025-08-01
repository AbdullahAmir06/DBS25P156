﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models;

namespace DBS25P156.DAL
{
    public class EditionDAL
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

        public List<int> GetEdition()
        {
            string query = $"SELECT year FROM itec_editions";
            List<object> columnValues = DatabaseHelper.Instance.GetColumn(query);

            List<int> editionYears = columnValues.Select(value => Convert.ToInt32(value)).ToList();

            return editionYears;
        }

        public int GetEditionIdByYear(int year)
        {
            string query = "SELECT itec_id FROM itec_editions WHERE year = @year";
            object result = DatabaseHelper.Instance.GetSingleValue(query, new object[] { year });

            return result != null ? Convert.ToInt32(result) : -1; // Return -1 if not found
        }




    }
}
