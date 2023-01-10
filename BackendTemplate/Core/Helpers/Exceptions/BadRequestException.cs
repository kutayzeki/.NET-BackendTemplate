﻿using System.Net;

namespace BackendTemplate.Core.Helpers.Exceptions
{
    public class BadRequestException : CustomException
    {
        public BadRequestException(string message, List<string>? errors = default)
            : base(message, errors, HttpStatusCode.BadRequest) { }
    }
}
