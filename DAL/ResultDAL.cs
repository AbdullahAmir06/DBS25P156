using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models;

namespace DBS25P156.DAL
{
    public class ResultDAL
    {

        public DataTable GetResultData()
        {
            string query = "SELECT result_id,itec_events.event_id,participant_id,team_id,score,remarks from event_results join itec_events on itec_events.event_id=event_results.event_id where itec_events.itec_id=@SelectedEditionID";

            return DatabaseHelper.Instance.GetData(query,new object[] {UserSession.SelectedEditionID});
        }

        public bool UpdateData(int result_id, string position, double score, string remarks)
        {
            int positionId = GetPositionId(position);

            string query = "Update event_results SET position = @positionId, score =@score,remarks =@remarks where result_id = @result_id";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { positionId, score, remarks, result_id }) > 0;
        }

        public int GetPositionId(string position)
        {
            string cat = "EventPositions";
            string query = "Select lookup_id from lookup where value =@position and category=@cat";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { position, cat }));
        }
    }
}
