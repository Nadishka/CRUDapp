using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.DataAccess;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class EmployeeApiController : ApiController
    {
        public IHttpActionResult Get()
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            List<EmployeeModel> employees = employeeDAO.GetAllEmployees();

            return Json(employees);
        }
        public IHttpActionResult Get(int id)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            EmployeeModel employee = employeeDAO.GetEmployee(id);

            return Json(employee);
        }

        [Route("api/EmployeeApi/Other")]
        [HttpGet]
        public IHttpActionResult Other()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("1", "11");
            map.Add("2", "22");
            map.Add("3", "33");
            map.Add("4", "44");
            map.Add("5", "55");
            return Json(map);
        }
    }
}
