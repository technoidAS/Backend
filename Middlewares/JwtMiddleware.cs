<<<<<<< HEAD
﻿using Backend.Services;
namespace Backend.Middlewares
=======
using EmpLeave.Services;
﻿namespace Backend.Middlewares
>>>>>>> f2e50c97362d5b96799aa3b5f87e3b6c2631ab84
{
    public class JwtMiddleware
    {

        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, TokenService tokenService)
        {
            var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();

            if (!string.IsNullOrEmpty(authHeader) && authHeader.StartsWith("Bearer "))
            {
                var token = authHeader.Substring("Bearer ".Length).Trim();
                var userId = tokenService.ValidateToken(token);
                if (userId != null)
                {
                    context.Items["UserId"] = userId;
                }
            }

            await _next(context);
        }
    }
}