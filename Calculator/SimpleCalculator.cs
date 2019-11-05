using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SimpleCalculator
    {
	    public double Add(double op1, double op2)
	    {
		    return op1 + op2;
	    }

	    public double Subtract(double op1, double op2)
	    {
		    return op2 - op1;
	    }

	    public double Multiply(double op1, double op2)
	    {
		    return op1 * op2;
	    }

	    public double Divide(double op1, double op2)
	    {
			return op1 / op2;
	    }
    }
}
