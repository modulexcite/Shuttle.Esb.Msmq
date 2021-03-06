﻿using NUnit.Framework;
using Shuttle.Esb.Tests;

namespace Shuttle.Esb.Msmq.Tests
{
	public class MsmqOutboxTest : OutboxFixture
	{
		[Test]
		[TestCase(false)]
		[TestCase(true)]
		public void Should_be_able_handle_errors(bool isTransactionalEndpoint)
		{
			TestOutboxSending("msmq://./{0}", isTransactionalEndpoint);
		}
	}
}