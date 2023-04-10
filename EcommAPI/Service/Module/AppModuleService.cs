using EcommAPI.Model;
using EcommAPI.UnitOfWork;
using Microsoft.Data.SqlClient;

namespace EcommAPI.Service.Module
{
    public class AppModuleService: IAppModuleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AppModuleService()
        {
            _unitOfWork = new UnitOfWork.UnitOfWork();
        }
        public AppModuleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ResponseModel GetAllModule()
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var param = new List<SqlParameter>();
                var result = Global.ExecuteStoredProcedure("sp_get_module", param, _unitOfWork.GetConnection());
                if (result.Tables.Count > 0)
                {
                    List<AppModule> appModules = Global.CommonMethod.ConvertToList<AppModule>(result.Tables[0]);
                    
                    var subModules = Global.CommonMethod.ConvertToList<SubModule>(result.Tables[1]);
                    foreach(var m in appModules)
                    {
                        m.subModules= subModules.FindAll(x=>x.module_id==m.module_id);
                    }
                    response.response = appModules;
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

    }
}
