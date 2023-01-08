using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Native.Repositories.Infrastructure.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Exceptions
{
    public static class ExceptionMiddlewareExtensions
    {
        //TODO: add logging
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler((appError) =>
            {
                
                appError.Run(async context =>
                {
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                    context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    if (contextFeature != null && contextFeature.Error != null)
                    {
                     
                        var httpStatusCode = GetErrorCode(contextFeature.Error);
                        
                        context.Response.StatusCode = (int) httpStatusCode;

                        await context.Response.WriteAsync(
                            JsonConvert.SerializeObject(
                                new ErrorDetails(
                                    httpStatusCode,
                                    contextFeature.Error.Message
                            )));
                    }
                });
            });
        }

        private static HttpStatusCode GetErrorCode(Exception e) => e switch
        {
            NotFoundException => HttpStatusCode.NotFound,
            _ => HttpStatusCode.InternalServerError
        };
    }
}
