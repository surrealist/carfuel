﻿using CarFuel.Models;
using CarFuel.Services.Bases;
using System;
using CarFuel.DataAccess.Bases;
using System.Linq;

namespace CarFuel.Services {
  public class UserService : ServiceBase<User>, IUserService {

    private User _currentUser;

    public UserService(IRepository<User> baseRepo)
      : base(baseRepo) {
      //
    }

    public User CurrentUser {
      get { return _currentUser; }
      set { _currentUser = value; }
    }

    public override User Find(params object[] keys) {
      var key1 = (Guid)keys[0];
      return Query(x => x.UserId == key1).SingleOrDefault();
    }
  }
}
