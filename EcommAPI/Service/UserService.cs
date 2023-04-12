﻿using EcommAPI.Model;
using EcommAPI.UnitOfWork;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EcommAPI.Service
{
    public class UserService:IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService()
        {
            _unitOfWork = new UnitOfWork.UnitOfWork();
        }
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ResponseModel Login(LoginModel model)
        {
            try
            {
                ResponseModel res = new ResponseModel();
                int err_no = 0;
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter("@email", model.Email));
                param.Add(new SqlParameter("@password", model.Password));
                param.Add(new SqlParameter("@errNo", SqlDbType.Int, 4, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, err_no));               
                var result = Global.ExecuteStoredProcedure("sp_login_user", param, _unitOfWork.GetConnection());
               var dbResult = Global.CommonMethod.ConvertToList<LoginResponseModel>(result.Tables[0]).FirstOrDefault();
                if (dbResult!=null)
                {
                    res.status = true;
                    res.response=dbResult;
                }
                else
                {
                    res.status = false;
                    res.message = "Login failed";
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ResponseModel Register(UserModel model)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                string err_msg = "";
                int err_no = 0;
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter("@firstName",model.FullName));
                param.Add(new SqlParameter("@password", model.UserPassword));
                param.Add(new SqlParameter("@email", model.Email));
                param.Add(new SqlParameter("@type", Global.UserType.User));
                param.Add(new SqlParameter("@status", Global.Status.Open));
                param.Add(new SqlParameter("@errNo", SqlDbType.Int, 4, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, err_no));
                param.Add(new SqlParameter("@errMsg", SqlDbType.VarChar, 200, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, err_msg));
                var result = Global.ExecuteStoredProcedure("sp_register_user", param, _unitOfWork.GetConnection());
                err_no = (int)param.Find(x => x.ParameterName == "@errNo")?.Value;
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
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public ResponseModel ViewUser(int userId)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter("@userId", userId));
                var result = Global.ExecuteStoredProcedure("sp_view_user", param, _unitOfWork.GetConnection());
                response.status = true;
                response.response = result.Tables[0];
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ResponseModel UpdateUser(UserModel model)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                string err_msg = "";
                int err_no = 0;
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter("@firstName", model.FullName));
                param.Add(new SqlParameter("@password", model.UserPassword));
                param.Add(new SqlParameter("@email", model.Email));
                param.Add(new SqlParameter("@err_no", SqlDbType.Int, 4, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, err_no));
                param.Add(new SqlParameter("@errMsg", SqlDbType.VarChar, 200, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, err_msg));
                var result = Global.ExecuteStoredProcedure("sp_update_user", param, _unitOfWork.GetConnection());
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
        public ResponseModel GetAllUser()
        {
            try
            {
                ResponseModel res = new ResponseModel();
                int err_no = 0;
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter("@errNo", SqlDbType.Int, 4, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, err_no));
                var result = Global.ExecuteStoredProcedure("sp_get_user_list", param, _unitOfWork.GetConnection());
                err_no = (int)param.Find(x => x.ParameterName == "@errNo")?.Value;
                if (err_no == 0)
                {
                    res.status = true;
                    var userList = Global.CommonMethod.ConvertToList<UserModel>(result.Tables[0]);
                    int slNo = 1;
                    userList.ForEach(x=>x.slNo= slNo++);
                    res.response = userList;

                }
                else
                {
                    res.status = false;
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
