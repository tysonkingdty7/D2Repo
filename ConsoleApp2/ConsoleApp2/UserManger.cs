﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Uesr
{
  public class UserManger
    {
        private const int V = 1;
        private User[] users;
        public UserManger()
        {
            users = new User[1]
            {
            new User(){Id= , Name="Ahmed"}
            };
        }
        public User[] Get()
        {
            return users;
        }
    }
}
