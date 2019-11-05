using Calculator;
using Requirements.Bindings.SharedState;
using TechTalk.SpecFlow;

namespace Requirements.Bindings.Calculator
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
			_sharedResult.Result = Calculator().Subtract(p0, p1);
		}

		[When(@"multiplying (.*) and (.*)")]
		public void WhenMultiplyingAnd(double p0, double p1)
		{
			_sharedResult.Result = Calculator().Multiply(p0, p1);
		}

		[When(@"dividing (.*) with (.*)")]
		public void WhenDividingWith(double p0, double p1)
		{
			_sharedResult.Result = Calculator().Divide(p0, p1);
		}

		[When(@"calculating sin for (.*) degrees")]
		public void WhenCalculatingSinForDegrees(double p0)
		{
			_sharedResult.Result = Calculator().Sin(p0);
		}

		[When(@"calculating cos for (.*) degrees")]
		public void WhenCalculatingCosForDegrees(double p0)
		{
			_sharedResult.Result = Calculator().Cos(p0);
		}


		private SimpleCalculator Calculator() => new SimpleCalculator();
	}
}
