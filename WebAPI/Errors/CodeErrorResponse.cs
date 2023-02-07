using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Errors
{
    public class CodeErrorResponse
    {
        public CodeErrorResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageEstatusCode(statusCode);
        }

        private string GetDefaultMessageEstatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "El request tiene errores",
                401 => "No tienes autorizacion a este recurso",
                404 => "No se encontró el item buscado",
                500 => "Se producieron errores en el servidor",
                _ => null
            };
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

    }
}
