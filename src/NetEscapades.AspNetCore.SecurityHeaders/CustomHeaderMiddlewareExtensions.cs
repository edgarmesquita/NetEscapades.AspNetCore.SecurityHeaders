﻿using System;
using NetEscapades.AspNetCore.SecurityHeaders;
using NetEscapades.AspNetCore.SecurityHeaders.Infrastructure;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// The <see cref="IApplicationBuilder"/> extensions for adding Security headers middleware support.
    /// </summary>
    public static class CustomHeadersMiddlewareExtensions
    {
        /// <summary>
        /// Adds middleware to your web application pipeline to automatically add security headers to requests
        /// </summary>
        /// <param name="app">The IApplicationBuilder passed to your Configure method</param>
        /// <param name="policyName">The policy name of a configured policy.</param>
        /// <returns>The original app parameter</returns>
        public static IApplicationBuilder UseCustomHeadersMiddleware(this IApplicationBuilder app, string policyName)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            return app.UseMiddleware<CustomHeadersMiddleware>(policyName);
        }

        /// <summary>
        /// Adds middleware to your web application pipeline to automatically add security headers to requests
        /// </summary>
        /// <param name="app">The IApplicationBuilder passed to your Configure method.</param>
        /// <param name="policies">A configured policy collection.</param>
        /// <returns>The original app parameter</returns>
        public static IApplicationBuilder UseCustomHeadersMiddleware(this IApplicationBuilder app, HeaderPolicyCollection policies)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            if (policies == null)
            {
                throw new ArgumentNullException(nameof(policies));
            }

            return app.UseMiddleware<CustomHeadersMiddleware>(policies);
        }
    }
}