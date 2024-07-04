using CleanArch.Api.Models;
using CleanArch.Application.Interfaces;
using CleanArch.Core.Entities;
using CleanArch.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
namespace CleanArch.Api.Controllers
{
    public class TinhController : BaseApiController
    {
        #region ===[ Private Members ]=============================================================
        private readonly IUnitOfWork _unitOfWork;
        #endregion
        #region ===[ Constructor ]=================================================================
        /// <summary>
        /// Initialize TinhController by injecting an object type of IUnitOfWork
        /// </summary>
        public TinhController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        #endregion
        #region ===[ Public Methods ]==============================================================
        [HttpGet]
        public async Task<ApiResponse<List<Tinh>>> GetAll()
        {
            var apiResponse = new ApiResponse<List<Tinh>>();
            try
            {
                var data = await _unitOfWork.Tinhs.GetAllAsync();
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

        [HttpGet]
        [Route("get-by-id")]
        [HttpGet("LayTheoIdTinh")]

        public async Task<ApiResponse<Tinh>> GetById(int id)
        {

            var apiResponse = new ApiResponse<Tinh>();
            try
            {
                var data = await _unitOfWork.Tinhs.GetByIdAsync(id);
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

        [HttpGet()]
        [Route("get-by-quocgia")]
        [Route("LayTheoIdQuocGia")]

        public async Task<ApiResponse<List<Tinh>>> GetByQuocGiaIdAsync(int id)
        {
            var apiResponse = new ApiResponse<List<Tinh>>();
            try
            {
                var data = await _unitOfWork.Tinhs.GetByQuocGiaIdAsync(id);
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
        [HttpPost]
        public async Task<ApiResponse<string>> Add(Tinh Tinh)
        {
            var apiResponse = new ApiResponse<string>();
            try
            {
                var data = await _unitOfWork.Tinhs.AddAsync(Tinh);
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
        public async Task<ApiResponse<string>> Update(Tinh Tinh)
        {
            var apiResponse = new ApiResponse<string>();
            try
            {
                var data = await _unitOfWork.Tinhs.UpdateAsync(Tinh);
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
                var data = await _unitOfWork.Tinhs.DeleteAsync(id);
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