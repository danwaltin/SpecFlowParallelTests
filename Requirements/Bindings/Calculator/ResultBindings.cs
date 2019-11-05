using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Requirements.Bindings.SharedState;
using TechTalk.SpecFlow;

namespace Requirements.Bindings.Calculator
{
	[Binding]
	public class ResultBindings
	{
		private const double Epsilon = 0.00001;

		private readonly SharedResult _sharedResult;

		public ResultBindings(SharedResult sharedResult)
		{
			_sharedResult = sharedResult;
		}

		[Then(@"the result should be (.*)")]
		public void ThenTheResultShouldBe(double expected)
		{
			var delta = Math.Abs(expected - _sharedResult.Result);
			Assert.IsTrue(delta < Epsilon, $"Expected {expected}, but got {_sharedResult.Result}");
		}
	}
}
