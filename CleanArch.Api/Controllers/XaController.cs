using CleanArch.Api.Models;
using CleanArch.Application.Interfaces;
using CleanArch.Core.Entities;
using CleanArch.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
namespace CleanArch.Api.Controllers
{
    public class XaController : BaseApiController
    {
        #region ===[ Private Members ]=============================================================
        private readonly IUnitOfWork _unitOfWork;
        #endregion
        #region ===[ Constructor ]=================================================================
        /// <summary>
        /// Initialize XaController by injecting an object type of IUnitOfWork
        /// </summary>
        public XaController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        #endregion
        #region ===[ Public Methods ]==============================================================
        [HttpGet]
        public async Task<ApiResponse<List<Xa>>> GetAll()
        {
            var apiResponse = new ApiResponse<List<Xa>>();
            try
            {
                var data = await _unitOfWork.Xas.GetAllAsync();
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
        [HttpGet("LayTheoIdXa")]
        public async Task<ApiResponse<Xa>> GetById(int id)
        {

            var apiResponse = new ApiResponse<Xa>();
            try
            {
                var data = await _unitOfWork.Xas.GetByIdAsync(id);
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
        //public async Task<ApiResponse<Xa>> XaByHuyenId(int id)
        //{

        //    var apiResponse = new ApiResponse<Xa>();

        //    try
        //    {
        //        var data = await _unitOfWork.Xas.GetByIdAsync(id);
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
        [HttpGet("LayTheoIdHuyen")]
        public async Task<ApiResponse<List<Xa>>> XaByHuyenId(int id)
        {

            var apiResponseList = new ApiResponse<List<Xa>>();

            try
            {
                var data = await _unitOfWork.Xas.LayTheoHuyenIdAsync(id);
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
        public async Task<ApiResponse<string>> Add(Xa Xa)
        {
            var apiResponse = new ApiResponse<string>();
            try
            {
                var data = await _unitOfWork.Xas.AddAsync(Xa);
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
        public async Task<ApiResponse<string>> Update(Xa Xa)
        {
            var apiResponse = new ApiResponse<string>();
            try
            {
                var data = await _unitOfWork.Xas.UpdateAsync(Xa);
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
                var data = await _unitOfWork.Xas.DeleteAsync(id);
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