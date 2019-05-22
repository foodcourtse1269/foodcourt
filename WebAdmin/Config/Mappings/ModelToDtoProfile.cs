using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAdmin.Dtos;
using WebAdmin.Models;

namespace WebAdmin.Config.Mappings
{
    public class ModelToDtoProfile : Profile
    {
        public ModelToDtoProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Food, FoodDto>();
            CreateMap<OrderDetail, OrderDetailDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<OrderStore, OrderStoreDto>();
            CreateMap<Role, RoleDto>();
            CreateMap<Store, StoreDto>();
            CreateMap<Transaction, TransactionDto>();
            CreateMap<TransactionType, TransactionTypeDto>();
        }
    }
}
