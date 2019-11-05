using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Requirements.Bindings.SharedState;
using TechTalk.SpecFlow;

namespace Requirements.Bindings
{
	[Binding]
	public class ResultBindings
	{
		private readonly SharedResult _sharedResult;

		public ResultBindings(SharedResult sharedResult)
		{
			_sharedResult = sharedResult;
		}

		[Then(@"the result should be (.*)")]
		public void ThenTheResultShouldBe(double expected)
		{
			Assert.AreEqual(expected, _sharedResult.Result);
		}
	}
}
