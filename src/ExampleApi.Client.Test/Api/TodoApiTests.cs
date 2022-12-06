/*
 * ToDo API
 *
 * An ASP.NET Core Web API for managing ToDo items
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using ExampleApi.Client.Client;
using ExampleApi.Client.Api;
// uncomment below to import models
//using ExampleApi.Client.Model;

namespace ExampleApi.Client.Test.Api
{
    /// <summary>
    ///  Class for testing TodoApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TodoApiTests : IDisposable
    {
        private TodoApi instance;

        public TodoApiTests()
        {
            instance = new TodoApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TodoApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TodoApi
            //Assert.IsType<TodoApi>(instance);
        }

        /// <summary>
        /// Test ApiTodoGet
        /// </summary>
        [Fact]
        public void ApiTodoGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiTodoGet();
            //Assert.IsType<List<TodoItem>>(response);
        }

        /// <summary>
        /// Test ApiTodoIdDelete
        /// </summary>
        [Fact]
        public void ApiTodoIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //instance.ApiTodoIdDelete(id);
        }

        /// <summary>
        /// Test ApiTodoIdGet
        /// </summary>
        [Fact]
        public void ApiTodoIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.ApiTodoIdGet(id);
            //Assert.IsType<TodoItem>(response);
        }

        /// <summary>
        /// Test ApiTodoPost
        /// </summary>
        [Fact]
        public void ApiTodoPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TodoItem? todoItem = null;
            //instance.ApiTodoPost(todoItem);
        }
    }
}