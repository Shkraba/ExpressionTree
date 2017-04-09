using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ExpressionTree
{
    class ExpressionClass
    {
        public static void RunLambda()
        {
            Func<int, int, int> lambda = (x, y) => (x + y) * 2;
            Console.WriteLine(lambda(2, 3));

            // Generate In run time

            // param x, y
            ParameterExpression xParam = Expression.Parameter(typeof(int), "x");
            ParameterExpression yParam = Expression.Parameter(typeof(int), "y");
           
            // const
            ConstantExpression contant = Expression.Constant(2);

            //+
            Expression sum = Expression.Add(xParam, yParam);
            //*
            Expression mult = Expression.Multiply(sum, contant);
            // Func<int, int, int>
            LambdaExpression lambdaExpression = Expression.Lambda(mult, xParam, yParam);
            var newLambda = (Func<int, int, int>)lambdaExpression.Compile();

            Console.WriteLine(newLambda(2,3));
            Console.ReadKey();
        }
    }
}
