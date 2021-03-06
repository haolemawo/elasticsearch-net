﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.XPack.Security.User.DisableUser
{
	public class DisableUserUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await PUT("/_xpack/security/user/ironman/_disable")
			.Fluent(c => c.DisableUser("ironman"))
			.Request(c => c.DisableUser(new DisableUserRequest("ironman")))
			.FluentAsync(c => c.DisableUserAsync("ironman"))
			.RequestAsync(c => c.DisableUserAsync(new DisableUserRequest("ironman")));
	}
}
