using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Threading.Tasks;
using Menu.ViewModels;
using Newtonsoft.Json;

namespace Menu.Middlweares
{
    public class AuthVerify
    {
        private readonly RequestDelegate _next;

        public AuthVerify(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            
            if(!context.User.Identity.IsAuthenticated)
            {
                var ret =  new ResultViewModel{
                    Success = false,
                    Message = "Usuário não autenticado"
                };
                var json = JsonConvert.SerializeObject(ret);;
                context.Response.StatusCode = 401;
                context.Response.ContentType = @"application/json";
                await context.Response.WriteAsync(json);
                return;
            }else{

            // Call the next delegate/middleware in the pipeline
            await _next(context);
            }
        }


      
        
    }
}