using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAdmin.Dtos;
using WebAdmin.Models;
using WebAdmin.Services;

namespace WebAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        // GET: api/Roles
        [HttpGet]
        public ActionResult<IEnumerable<RoleDto>> GetAllRoles()
        {
            return _roleService.GetAllRoles();
        }

        // GET: api/Roles/5
        [HttpGet("{id}")]
        public ActionResult<RoleDto> GetRoleById(int id)
        {
            RoleDto roleDto = _roleService.GetById(id);

            if (roleDto == null)
            {
                return NotFound();
            }

            return roleDto;
        }

        [HttpPost]
        public ActionResult<RoleDto> AddRole(RoleDto roleDto)
        {
            RoleDto createdRole = _roleService.AddRole(roleDto);
            return CreatedAtAction(nameof(GetRoleById), new { id = createdRole.Id }, createdRole);
        }

        // PUT: api/Roles
        [HttpPut]
        public ActionResult<RoleDto> UpdateRole(RoleDto roleDto)
        {
            if (_roleService.GetById(roleDto.Id) == null)
            {
                return NotFound();
            }
            return _roleService.UpdateRole(roleDto);
        }

        //Delete: api/Roles/5
        [HttpDelete("{id}")]
        public ActionResult<RoleDto> DeleteRole(int id)
        {
            RoleDto deleteRole = _roleService.GetById(id);
            if (_roleService.GetById(id) == null)
            {
                return NotFound();
            }
            return _roleService.DeleteRole(deleteRole);
        }
    }
}