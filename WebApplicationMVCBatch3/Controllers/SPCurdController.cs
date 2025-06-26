using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplicationMVCBatch3.Models;

namespace WebApplicationMVCBatch3.Controllers
{
    public class SPCurdController : Controller
    {

        public readonly AppDb _db;

        public SPCurdController(AppDb db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Users> obj;
            string Sql = "exec Sp_getData";
            obj = _db.Users.FromSqlRaw<Users>(Sql).ToList();
            return View(obj);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Users obj)
        {

            string sql = "Exec  Sp_Insert @Name , @Email, @Password , @Dept , @Status , @Role";

            List<SqlParameter> param = new List<SqlParameter>() {
            new SqlParameter{ ParameterName="@Name",Value=obj.Name},
            new SqlParameter{ ParameterName="@Email",Value=obj.Email},
            new SqlParameter{ ParameterName="@Password",Value=obj.Password},
            new SqlParameter{ ParameterName="@Dept",Value=obj.Dept},
            new SqlParameter{ ParameterName="@Status",Value=obj.Status},
            new SqlParameter{ ParameterName="@Role",Value=obj.Role},
            };

            var res = _db.Database.ExecuteSqlRaw(sql, param.ToArray());
            if (res > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Edit(int ID)
        {
            string sql = "Exec  Sp_getDataByID @ID";
            List<SqlParameter> param = new List<SqlParameter>()
            {
            new SqlParameter{ ParameterName="@ID",Value=ID}
            };
            var res = _db.Users.FromSqlRaw(sql, param.ToArray()).AsEnumerable().FirstOrDefault();


            return View(res);
        }


        [HttpPost]
        public IActionResult Edit(Users obj)
        {
            string sql = "Exec  Sp_Update @Name , @Email, @Password , @Dept , @Status , @Role ,@ID";

            List<SqlParameter> param = new List<SqlParameter>() {
            new SqlParameter{ ParameterName="@Name",Value=obj.Name},
            new SqlParameter{ ParameterName="@Email",Value=obj.Email},
            new SqlParameter{ ParameterName="@Password",Value=obj.Password},
            new SqlParameter{ ParameterName="@Dept",Value=obj.Dept},
            new SqlParameter{ ParameterName="@Status",Value=obj.Status},
            new SqlParameter{ ParameterName="@Role",Value=obj.Role},
               new SqlParameter{ ParameterName="@ID",Value=obj.ID},
            };

            var res = _db.Database.ExecuteSqlRaw(sql, param.ToArray());
            if (res > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Delete(int ID)
        {
            string sql = "Exec  Sp_getDataByID @ID";
            List<SqlParameter> param = new List<SqlParameter>()
            {
            new SqlParameter{ ParameterName="@ID",Value=ID}
            };
            var res = _db.Users.FromSqlRaw(sql, param.ToArray()).AsEnumerable().FirstOrDefault();


            return View(res);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int ID)
        {

            string sql = "exec Sp_Delete @ID";
            List<SqlParameter> param = new List<SqlParameter>()
            {
            new SqlParameter{ ParameterName="@ID",Value=ID}
            };
            var res = _db.Database.ExecuteSqlRaw(sql, param.ToArray());
            if (res > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
