using EcommAPI.Model;
using EcommAPI.UnitOfWork;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EcommAPI.Service.Category
{
    public class CategoryService: ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService()
        {
            _unitOfWork = new UnitOfWork.UnitOfWork();
        }
        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ResponseModel GetAllCategory()
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var param = new List<SqlParameter>();
                var result = Global.ExecuteStoredProcedure("sp_get_all_category", param, _unitOfWork.GetConnection());
                if (result.Tables.Count>0)
                {
                   List <CategoryModel>categoryList= Global.CommonMethod.ConvertToList<CategoryModel>(result.Tables[0]);
                    response.response = categoryList;
                    response.status = true;
                }
                else
                {
                    response.status = false;
                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ResponseModel AddCategory(CategoryModel category)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                string err_msg = "";
                int err_no = 0;
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter("@categoryName", category.CategoryName));
                param.Add(new SqlParameter("@image", category.ImageUrl));
                param.Add(new SqlParameter("@err_no", SqlDbType.Int, 4, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, err_no));
                param.Add(new SqlParameter("@errMsg", SqlDbType.VarChar, 200, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, err_msg));
                var result = Global.ExecuteStoredProcedure("sp_create_category", param, _unitOfWork.GetConnection());
                err_no = (int)param.Find(x => x.ParameterName == "@err_no")?.Value;
                err_msg = param.Find(x => x.ParameterName == "@errMsg")?.Value.ToString() ?? "";
                
                if (err_no == 0)
                {
                    response.status = true;
                    response.message = err_msg;
                }
                else
                {
                    response.status = false;
                    response.message = err_msg;

                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ResponseModel PlaceOrder(int userId)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                string err_msg = "";
                int err_no = 0;
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter("@userId", userId));
                param.Add(new SqlParameter("@err_no", SqlDbType.Int, 4, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, err_no));
                param.Add(new SqlParameter("@errMsg", SqlDbType.VarChar, 200, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, err_msg));
                var result = Global.ExecuteStoredProcedure("sp_place_order", param, _unitOfWork.GetConnection());
                err_no = (int)param.Find(x => x.ParameterName == "@err_no")?.Value;
                err_msg = param.Find(x => x.ParameterName == "@errMsg")?.Value.ToString() ?? "";
                if (err_no == 0)
                {
                    response.status = true;
                    response.message = err_msg;
                }
                else
                {
                    response.status = false;
                    response.message = err_msg;

                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ResponseModel OrderList(OrderListModel model)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                string err_msg = "";
                int err_no = 0;
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter("@userId", model.UserId));
                param.Add(new SqlParameter("@userType", model.Type));
                var result = Global.ExecuteStoredProcedure("sp_order_list", param, _unitOfWork.GetConnection());
                 
                if (err_no == 0)
                {
                    response.status = true;
                    response.message = err_msg;
                }
                else
                {
                    response.status = false;
                    response.message = err_msg;

                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
