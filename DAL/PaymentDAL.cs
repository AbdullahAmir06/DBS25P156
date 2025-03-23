using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models;

namespace DBS25P156.DAL
{
    public class PaymentDAL
    {

        public DataTable GetAllPendingRegistrations()
        {
            string query = "select e.registration_id,e.event_id,e.participant_id,l.value,e.fee_amount from event_participants e join lookup l on l.lookup_id = e.payment_status_id join participants p on p.participant_id=e.participant_id where e.payment_status_id =13 and p.itec_id=@SelectedEditionID;";

            return DatabaseHelper.Instance.GetData(query, new object[] {UserSession.SelectedEditionID });
        }

        public bool UpdatePaymentStatus(int regId, int status)
        {
            string query = "UPDATE event_participants  SET payment_status_id =@status where registration_id = @regId";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { status, regId})>0;
        }
    }
}
