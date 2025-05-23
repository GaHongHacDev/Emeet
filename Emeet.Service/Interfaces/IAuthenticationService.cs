﻿using Emeet.Service.DTOs.Requests.Authentication;
using Emeet.Service.DTOs.Responses.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emeet.Service.Interfaces
{
    public interface IAuthenticationService
    {
        public Task<LoginResponse> LoginPassword(LoginPasswordRequest request);
        public Task<RefreshTokenResponse> RefreshToken(RefreshTokenRequest refreshTokenRequest);
        public Task<bool> Logout(LogoutRequest logoutRequest);
        public Task<LoginResponse> FetchUser(string accessToken);
        public Task<bool> RegisterUser(RegisterRequest request);
        public Task<LoginResponse> LoginGoogle(LoginGoogleRequest checkLoginGoogle);
    }
}
