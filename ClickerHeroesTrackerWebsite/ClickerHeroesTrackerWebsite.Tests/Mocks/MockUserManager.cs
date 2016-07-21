﻿// <copyright file="MockUserManager.cs" company="Clicker Heroes Tracker">
// Copyright (c) Clicker Heroes Tracker. All rights reserved.
// </copyright>

namespace ClickerHeroesTrackerWebsite.Tests.Mocks
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using ClickerHeroesTrackerWebsite.Models;
    using Microsoft.AspNetCore.Identity;

    internal sealed class MockUserManager : UserManager<ApplicationUser>
    {
        public MockUserManager()
            : base(new MockUserStore(), null, null, null, null, null, null, null, null)
        {
        }

        private sealed class MockUserStore : IUserStore<ApplicationUser>
        {
            public Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

            public Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public Task<ApplicationUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

            public Task<ApplicationUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

            public Task<string> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

            public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

            public Task<string> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

            public Task SetNormalizedUserNameAsync(ApplicationUser user, string normalizedName, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

            public Task SetUserNameAsync(ApplicationUser user, string userName, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

            public Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
