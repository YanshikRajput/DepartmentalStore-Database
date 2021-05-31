using AutoMapper;
using DepartmentalStoreApi.Entities;
using DepartmentalStoreApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreApi.Data
{
    public class StaffProfile : Profile
    {
        public StaffProfile()
        {
            this.CreateMap<Staff, StaffModel>();
        }
    }
}
