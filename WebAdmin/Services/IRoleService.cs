using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAdmin.Dtos;
using WebAdmin.Models;
using WebAdmin.Repositories;

namespace WebAdmin.Services
{
    public interface IRoleService
    {
        List<RoleDto> GetAllRoles();
        RoleDto GetById(int id);
        RoleDto AddRole(RoleDto roleDto);
        RoleDto UpdateRole(RoleDto roleDto);
        RoleDto DeleteRole(RoleDto roleDto);
        bool ExistById(int id);
    }

    class RoleService : IRoleService
    {
        private readonly FoodCourtContext _context;
        private readonly RoleRepository _roleRepo;
        private readonly IMapper _mapper;

        public RoleService(RoleRepository roleRepo, FoodCourtContext context, IMapper mapper)
        {
            _roleRepo = roleRepo;
            _context = context;
            _mapper = mapper;
        }

        public RoleDto AddRole(RoleDto roleDto)
        {
            Role role = _mapper.Map<Role>(roleDto);
            _roleRepo.Add(role);
            _context.SaveChanges();
            return _mapper.Map<RoleDto>(role);
        }

        public RoleDto DeleteRole(RoleDto roleDto)
        {
            Role role = _mapper.Map<Role>(roleDto);
            _roleRepo.Delete(role);
            _context.SaveChanges();
            return _mapper.Map<RoleDto>(role);
        }

        public bool ExistById(int id)
        {
            return _roleRepo.ExistById(id);
        }

        public List<RoleDto> GetAllRoles()
        {
            return _roleRepo.GetMany().Select(role => _mapper.Map<RoleDto>(role)).ToList();
        }

        public RoleDto GetById(int id)
        {
            Role role = _roleRepo.GetByID(id);
            return _mapper.Map<RoleDto>(role);
        }

        public RoleDto UpdateRole(RoleDto roleDto)
        {
            Role role = _mapper.Map<Role>(roleDto);
            _roleRepo.Update(role);
            try
            {
                _context.SaveChanges();
                return _mapper.Map<RoleDto>(role);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}
