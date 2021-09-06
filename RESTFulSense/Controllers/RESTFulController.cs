﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Models;

namespace RESTFulSense.Controllers
{
    public class RESTFulController : ControllerBase, IRESTFulController
    {
        [NonAction]
        public CreatedObjectResult Created(object value) =>
            new CreatedObjectResult(value);

        [NonAction]
        public BadGatewayObjectResult BadGateway(object value) =>
            new BadGatewayObjectResult(value);

        [NonAction]
        public ExpectationFailedObjectResult ExpectationFailed(object value) =>
            new ExpectationFailedObjectResult(value);

        [NonAction]
        public FailedDependencyObjectResult FailedDependency(object value) =>
            new FailedDependencyObjectResult(value);

        [NonAction]
        public GatewayTimeoutObjectResult GatewayTimeout(object value) =>
            new GatewayTimeoutObjectResult(value);

        [NonAction]
        public GoneObjectResult Gone(object value) =>
            new GoneObjectResult(value);

        [NonAction]
        public HttpVersionNotSupportedObjectResult HttpVersionNotSupported(object value) =>
            new HttpVersionNotSupportedObjectResult(value);

        [NonAction]
        public InsufficientStorageObjectResult InsufficientStorage(object value) =>
            new InsufficientStorageObjectResult(value);

        [NonAction]
        public InternalServerErrorObjectResult InternalServerError(object value) =>
            new InternalServerErrorObjectResult(value);

        [NonAction]
        public LengthRequiredObjectResult LengthRequired(object value) =>
            new LengthRequiredObjectResult(value);

        [NonAction]
        public LockedObjectResult Locked(object value) =>
            new LockedObjectResult(value);

        [NonAction]
        public LoopDetectedObjectResult LoopDetected(object value) =>
            new LoopDetectedObjectResult(value);

        [NonAction]
        public MethodNotAllowedObjectResult MethodNotAllowed(object value) =>
            new MethodNotAllowedObjectResult(value);

        [NonAction]
        public MisdirectedRequestObjectResult MisdirectedRequest(object value) =>
            new MisdirectedRequestObjectResult(value);

        [NonAction]
        public NetworkAuthenticationRequiredObjectResult NetworkAuthenticationRequired(object value) =>
            new NetworkAuthenticationRequiredObjectResult(value);

        [NonAction]
        public NotAcceptableObjectResult NotAcceptable(object value) =>
            new NotAcceptableObjectResult(value);

        [NonAction]
        public NotExtendedObjectResult NotExtended(object value) =>
            new NotExtendedObjectResult(value);

        [NonAction]
        public NotImplementedObjectResult NotImplemented(object value) =>
            new NotImplementedObjectResult(value);

        [NonAction]
        public PaymentRequiredObjectResult PaymentRequired(object value) =>
            new PaymentRequiredObjectResult(value);

        [NonAction]
        public PreconditionFailedObjectResult PreconditionFailed(object value) =>
            new PreconditionFailedObjectResult(value);

        [NonAction]
        public PreconditionRequiredObjectResult PreconditionRequired(object value) =>
            new PreconditionRequiredObjectResult(value);

        [NonAction]
        public ProxyAuthenticationRequiredObjectResult ProxyAuthenticationRequired(object value) =>
            new ProxyAuthenticationRequiredObjectResult(value);

        [NonAction]
        public RequestedRangeNotSatisfiableObjectResult RequestedRangeNotSatisfiable(object value) =>
            new RequestedRangeNotSatisfiableObjectResult(value);

        [NonAction]
        public RequestEntityTooLargeObjectResult RequestEntityTooLarge(object value) =>
            new RequestEntityTooLargeObjectResult(value);

        [NonAction]
        public RequestHeaderFieldsTooLargeObjectResult RequestHeaderFieldsTooLarge(object value) =>
            new RequestHeaderFieldsTooLargeObjectResult(value);

        [NonAction]
        public RequestTimeoutObjectResult RequestTimeout(object value) =>
            new RequestTimeoutObjectResult(value);

        [NonAction]
        public RequestUriTooLongObjectResult RequestUriTooLong(object value) =>
            new RequestUriTooLongObjectResult(value);

        [NonAction]
        public ServiceUnavailableObjectResult ServiceUnavailable(object value) =>
            new ServiceUnavailableObjectResult(value);

        [NonAction]
        public TooManyRequestsObjectResult TooManyRequests(object value) =>
            new TooManyRequestsObjectResult(value);

        [NonAction]
        public UnavailableForLegalReasonsObjectResult UnavailableForLegalReasons(object value) =>
            new UnavailableForLegalReasonsObjectResult(value);

        [NonAction]
        public UnsupportedMediaTypeObjectResult UnsupportedMediaTypeObjectResult(object value) =>
            new UnsupportedMediaTypeObjectResult(value);

        [NonAction]
        public UpgradeRequiredObjectResult UpgradeRequired(object value) =>
            new UpgradeRequiredObjectResult(value);

        [NonAction]
        public VariantAlsoNegotiatesObjectResult VariantAlsoNegotiates(object value) =>
            new VariantAlsoNegotiatesObjectResult(value);

        public BadRequestObjectResult BadRequest(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new BadRequestObjectResult(problemDetail);
        }

        public UnauthorizedObjectResult Unauthorized(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status401Unauthorized,
                Type = "https://tools.ietf.org/html/rfc7235#section-3.1",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new UnauthorizedObjectResult(problemDetail);
        }

        public PaymentRequiredObjectResult PaymentRequired(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status402PaymentRequired,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.2",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new PaymentRequiredObjectResult(problemDetail);
        }

        public ForbiddenObjectResult Forbidden(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status403Forbidden,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.3",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new ForbiddenObjectResult(problemDetail);
        }

        public NotFoundObjectResult NotFound(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status404NotFound,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.4",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new NotFoundObjectResult(problemDetail);
        }

        public MethodNotAllowedObjectResult MethodNotAllowed(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status405MethodNotAllowed,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.5",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new MethodNotAllowedObjectResult(problemDetail);
        }

        public NotAcceptableObjectResult NotAcceptable(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status406NotAcceptable,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.6",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new NotAcceptableObjectResult(problemDetail);
        }

        public ProxyAuthenticationRequiredObjectResult ProxyAuthenticationRequired(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status407ProxyAuthenticationRequired,
                Type = "https://tools.ietf.org/html/rfc7235#section-3.2",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new ProxyAuthenticationRequiredObjectResult(problemDetail);
        }

        public RequestTimeoutObjectResult RequestTimeout(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status408RequestTimeout,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.7",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new RequestTimeoutObjectResult(problemDetail);
        }

        public ConflictObjectResult Conflict(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status409Conflict,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.8",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new ConflictObjectResult(problemDetail);
        }

        public GoneObjectResult Gone(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status410Gone,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.9",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new GoneObjectResult(problemDetail);
        }

        public LengthRequiredObjectResult LengthRequired(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status411LengthRequired,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.10",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new LengthRequiredObjectResult(problemDetail);
        }

        public PreconditionFailedObjectResult PreconditionFailed(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status412PreconditionFailed,
                Type = "https://tools.ietf.org/html/rfc7232#section-4.2",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new PreconditionFailedObjectResult(problemDetail);
        }

        public RequestEntityTooLargeObjectResult RequestEntityTooLarge(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status413RequestEntityTooLarge,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.11",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new RequestEntityTooLargeObjectResult(problemDetail);
        }

        public RequestUriTooLongObjectResult RequestUriTooLong(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status414RequestUriTooLong,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.12",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new RequestUriTooLongObjectResult(problemDetail);
        }

        public UnsupportedMediaTypeObjectResult UnsupportedMediaType(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status415UnsupportedMediaType,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.13",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new UnsupportedMediaTypeObjectResult(problemDetail);
        }

        public RequestedRangeNotSatisfiableObjectResult RequestedRangeNotSatisfiable(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status416RequestedRangeNotSatisfiable,
                Type = "https://tools.ietf.org/html/rfc7233#section-4.4",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new RequestedRangeNotSatisfiableObjectResult(problemDetail);
        }

        public ExpectationFailedObjectResult ExpectationFailed(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status417ExpectationFailed,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.14",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new ExpectationFailedObjectResult(problemDetail);
        }

        public MisdirectedRequestObjectResult MisdirectedRequest(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status421MisdirectedRequest,
                Type = "https://tools.ietf.org/html/rfc7540#section-9.1.2",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new MisdirectedRequestObjectResult(problemDetail);
        }

        public UnprocessableEntityObjectResult UnprocessableEntity(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status422UnprocessableEntity,
                Type = "https://tools.ietf.org/html/rfc4918#section-11.2",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new UnprocessableEntityObjectResult(problemDetail);
        }

        public LockedObjectResult Locked(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status423Locked,
                Type = "https://tools.ietf.org/html/rfc4918#section-11.3",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new LockedObjectResult(problemDetail);
        }

        public FailedDependencyObjectResult FailedDependency(Exception exception)
        {
            var problemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status424FailedDependency,
                Type = "https://tools.ietf.org/html/rfc4918#section-11.4",
                Title = exception.Message
            };

            MapExceptionDataToProblemDetail(exception, problemDetail);

            return new FailedDependencyObjectResult(problemDetail);
        }

        private static void MapExceptionDataToProblemDetail(
            Exception exception,
            ValidationProblemDetails problemDetail)
        {
            foreach (DictionaryEntry error in exception.Data)
            {
                problemDetail.Errors.Add(
                    key: error.Key.ToString(),
                    value: ((List<string>)error.Value)?.ToArray());
            }
        }
    }
}