using FluentAssertions;
using PlasticCost;

namespace PlasticCostCalculatorTests
{
    public class PlasticCalculatorSpecTest
    {
        /*
         * This solution is focused on the proper implementation of
         * "Spec" testing (tall system specification testing) which
         * is an implementation of TDD that pushes an integration test,
         * which forces unit tests to be developed for MVP vertical 
         * slices of the feature/application/function. This encourages
         * minimalistic code with dependency injection as a paramount
         * principle.
         * 
         * This basic idea is 
         *  1. Define in the spec the basic intent/system as a real object
         *  2. Build out a single unit test to test the specific action
         *  3. Build the real objects around the test
         *  4. The spec should be broken during new development. If it's not, break it first.
         *  5. If the spec is broken, and there are no broken unit tests, make new/break some unit tests
         *  6. Make the unit tests pass by implementing as shallow/unintelligent code as possible
         *      6.a. (e.g. If a method is to return a boolean, let it return a hard value of true/false until you need it not to)
         *  7. If a Spec/Unit is passing with dumb code, refine the spec to require a more specific expectation.
         *  
         *  This methodology is uncomfortable because it has a lot of "dumb" code
         *  and broken code continually (a lot of red squiggles), but I've found 
         *  it easier after some practice. It's lower maintenance, alllows for 
         *  rapid pivoting, builds in tests inherently, and requires loosely 
         *  coupled development to truly work.
         *  
         *  These notes are to be extracted into the Readme file, but I wanted 
         *  to get them out of my head while I remembered to.
         */

        [Fact]
        public void CalculatePlasticCostSpec()
        {
            // Arrange
            var calculator = new PlasticCostCalculatorBuilder()
                .WithTaxRate(6m)
                .Assemble();

            // Act
            var cost = calculator.Calculate(10m);

            // Assert
            cost.Should().Be(10.6m);
        }
    }
}