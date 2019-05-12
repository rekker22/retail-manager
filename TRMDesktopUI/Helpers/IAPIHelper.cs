﻿using System.Threading.Tasks;
using TRMDesktopUI.Models;

namespace TRMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AutheticatedUser> AuthenticateAsync(string username, string password);
    }
}