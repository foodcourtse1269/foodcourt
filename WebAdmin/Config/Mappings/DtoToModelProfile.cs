using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAdmin.Dtos;
using WebAdmin.Models;

namespace WebAdmin.Config.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<CategoryDto, Category>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<EmployeeDto, Employee>();
            CreateMap<FoodDto, Food>();
            CreateMap<OrderDetailDto, OrderDetail>();
            CreateMap<OrderDto, Order>();
            CreateMap<OrderStoreDto, OrderStore>();
            CreateMap<RoleDto, Role>();
            CreateMap<StoreDto, Store>();
            CreateMap<TransactionDto, Transaction>();
            CreateMap<TransactionTypeDto, TransactionType>();
        }
    }
}
