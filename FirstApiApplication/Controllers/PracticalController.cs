using System.Collections.Generic;
using System.Web.Http;

namespace FirstApiApplication.Controllers
{
    public class PracticalController : ApiController
    {

        List<int> empsid = new List<int>();

        public List<int> GetAllEmps() {


            for (int i = 0; i < 100; i++)
            {

                empsid.Add(i);
            }

            return empsid;

        }

   

    }
}
