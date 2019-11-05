﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Requirements.Bindings.SharedState;
using TechTalk.SpecFlow;

namespace Requirements.Bindings
{
	[Binding]
	public class OperatorBindings
	{
		private readonly SharedResult _sharedResult;

		public OperatorBindings(SharedResult sharedResult)
		{
			_sharedResult = sharedResult;
		}

		[When(@"adding (.*) and (.*)")]
		public void WhenAddingAnd(double p0, double p1)
		{
			_sharedResult.Result = Calculator().Add(p0, p1);
		}

		[When(@"subtracting (.*) from (.*)")]
		public void WhenSubtractingFrom(double p0, double p1)
		{
			_sharedResult.Result = Calculator().Subtract(p0, from: p1);
		}

		private SimpleCalculator Calculator() => new SimpleCalculator();

	}
}