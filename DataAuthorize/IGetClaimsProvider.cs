﻿// Copyright (c) 2018 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

namespace DataAuthorize
{
    public interface IGetClaimsProvider
    {
        string UserId { get; }

        int ShopKey { get; }

        string DistrictManagerId { get;}
    }
}