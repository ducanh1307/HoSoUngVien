using CleanArch.Api.Models;
using CleanArch.Application.Interfaces;
using CleanArch.Core.Entities;
using CleanArch.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
namespace CleanArch.Api.Controllers
{
    public class HuyenController : BaseApiController
    {
        #region ===[ Private Members ]=============================================================
        private readonly IUnitOfWork _unitOfWork;
        #endregion
        #region ===[ Constructor ]=================================================================
        /// <summary>
        /// Initialize HuyenController by injecting an object type of IUnitOfWork
        /// </summary>
        public HuyenController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        #endregion
        #region ===[ Public Methods ]==============================================================
        [HttpGet]
        public async Task<ApiResponse<List<Huyen>>> GetAll()
        {
            var apiResponse = new ApiResponse<List<Huyen>>();
            try
            {
                var data = await _unitOfWork.Huyens.GetAllAsync();
                apiResponse.Success = true;
                apiResponse.Result = data.ToList();
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }
            return apiResponse;
        }

        [HttpGet("{id}")]
        [HttpGet("LayTheoIdHuyen")]
        public async Task<ApiResponse<Huyen>> GetById(int id)
        {

            var apiResponse = new ApiResponse<Huyen>();
            try
            {
                var data = await _unitOfWork.Huyens.GetByIdAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }
            return apiResponse;
        }

        //[HttpGet("{id}")]
        //public async Task<ApiResponse<Huyen>> HuyenByTinhId(int id)
        //{

        //    var apiResponse = new ApiResponse<Huyen>();

        //    try
        //    {
        //        var data = await _unitOfWork.Huyens.GetByIdAsync(id);
        //        apiResponse.Success = true;
        //        apiResponse.Result = data;
        //    }
        //    catch (SqlException ex)
        //    {
        //        apiResponse.Success = false;
        //        apiResponse.Message = ex.Message;
        //        Logger.Instance.Error("SQL Exception:", ex);
        //    }
        //    catch (Exception ex)
        //    {
        //        apiResponse.Success = false;
        //        apiResponse.Message = ex.Message;
        //        Logger.Instance.Error("Exception:", ex);
        //    }

        //    return apiResponse;
        //}
        [HttpGet("LayTheoIdTinh")]
        public async Task<ApiResponse<List<Huyen>>> HuyenByTinhId(int id)
        {
            var apiResponseList = new ApiResponse<List<Huyen>>();

            try
            {
                var data = await _unitOfWork.Huyens.LayTheoTinhIdAsync(id);
                apiResponseList.Success = true;
                apiResponseList.Result = data.ToList();
            }
            catch (SqlException ex)
            {
                apiResponseList.Success = false;
                apiResponseList.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponseList.Success = false;
                apiResponseList.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponseList;
        }

        [HttpPost]
        public async Task<ApiResponse<string>> Add(Huyen Huyen)
        {
            var apiResponse = new ApiResponse<string>();
            try
            {
                var data = await _unitOfWork.Huyens.AddAsync(Huyen);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }
            return apiResponse;
        }
        [HttpPut]
        public async Task<ApiResponse<string>> Update(Huyen Huyen)
        {
            var apiResponse = new ApiResponse<string>();
            try
            {
                var data = await _unitOfWork.Huyens.UpdateAsync(Huyen);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }
            return apiResponse;
        }
        [HttpDelete]
        public async Task<ApiResponse<string>> Delete(int id)
        {
            var apiResponse = new ApiResponse<string>();
            try
            {
                var data = await _unitOfWork.Huyens.DeleteAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }
            return apiResponse;
        }
        #endregion
    }
}