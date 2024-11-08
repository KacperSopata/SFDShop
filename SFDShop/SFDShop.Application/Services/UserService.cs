﻿using SFDShop.Application.Interfaces;
using SFDShop.Application.ViewModel.AdminPanel.Users;
using SFDShop.Application.ViewModel.Item;
using SFDShop.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFDShop.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repository)
        {
            _repo= repository;
        }

        public ListUserVm GetUserVm()
        {
           ListUserVm list = new ListUserVm();
            list.Users = new List<UserVm>();
            var users = _repo.GetUsers();
            foreach (var user in users)
            {
                UserVm uservm = new UserVm();
                uservm.Id = user.Id;
                uservm.Email = user.Email;
                list.Users.Add(uservm);
            }
            return list;
            
        }

        public ListUserVm GetAdmins()
        {
            ListUserVm list = new ListUserVm();
            list.Users = new List<UserVm>();
            var admins = _repo.GetAdmins();
            foreach (var user in admins)
            {
                UserVm uservm = new UserVm();
                uservm.Id = user.Id;
                uservm.Email = user.Email;
                uservm.Role = "Admin";
                list.Users.Add(uservm);
            }
            return list;
        }

        public void restrictPermissions(string id)
        {
            if(id != null)
            {
                _repo.restrictPermissions(id);
            }
        }

        public void addPermissions(string Email)
        {
            if(Email != null)
            {
                _repo.addPermissions(Email);
            }
        }

        public void deleteUserFromDB(string id)
        {
            if (id != null)
            {
                _repo.deleteUser(id);
            }
        }

    }
}
