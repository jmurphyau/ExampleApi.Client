/*
 * ToDo API
 *
 * An ASP.NET Core Web API for managing ToDo items
 *
 * The version of the OpenAPI document: v3.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;

namespace ExampleApi.Client.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IApiResponse response);
}
