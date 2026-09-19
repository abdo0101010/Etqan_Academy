using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
namespace Mediator.CQRS.Application
{
    public static class ApplicationRegistrations
    {
        public static void AddApplicationRegistrations(this IServiceCollection app)
        {
            app.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationRegistrations).Assembly));
            //app.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPipeline<,>));
            app.AddValidatorsFromAssembly(typeof(ApplicationRegistrations).Assembly);

        }
    }
}
