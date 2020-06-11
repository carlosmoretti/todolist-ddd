using AutoMapper;
using Domain.Model;
using Domain.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mapping
{
    public static class RegisterMapping
    {
        public static void Register(ref IServiceCollection service)
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Todo, TodoViewModel>()
                    .ReverseMap();
            });

            IMapper mapper = config.CreateMapper();
            service.AddSingleton(mapper);
        }
    }
}
