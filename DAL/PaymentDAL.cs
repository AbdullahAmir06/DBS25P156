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
            string query = "select e.registration_id,e.event_id,e.participant_id,l.value,e.fee_amount from event_participants e join lookup l on l.lookup_id = e.payment_status_id where e.payment_status_id =13";

            return DatabaseHelper.Instance.GetData(query, new object[] { });
        }
    }
}
