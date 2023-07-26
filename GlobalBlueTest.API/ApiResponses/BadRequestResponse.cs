﻿using System.Net;

namespace GlobalBlueTest.API.ApiResponses
{
    public class BadRequestResponse : BaseApiResponse
    {
        public bool IsError { get; }
        public BadRequestResponse(string message, object response) : base(System.Net.HttpStatusCode.BadRequest, message, response)
        {
            IsError = true;
        }        
    }
}
