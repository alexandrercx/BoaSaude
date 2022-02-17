﻿using Application.ViewModel.Request;
using AutoMapper;
using Domain.Models;

namespace Application.AutoMapper
{
    public class ViewModelToDomainMapping : Profile
    {
        public ViewModelToDomainMapping()
        {
            CreateMap<PostAssociadoViewModel, Associado>();
        }
    }
}
