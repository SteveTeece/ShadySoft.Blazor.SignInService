﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShadySoft.Blazor.SignInService.Dtos
{
    internal class RefreshSignInDto
    {
        public string UserName { get; set; }
        public DateTime ExpirationUtc { get; set; }
    }
}
