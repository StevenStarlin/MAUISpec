# Plastic Cost Calculator
## Summary
A test-driven application in MAUI that leverages a loosely
coupled architecture, SOLID principles, and dependency injection
that allows for rapid development, updates, and releases
without the bulk and dependency on external systems.

The app comes from friends of mine asking me to 3D print 
parts and items for them, but wanting to pay me what the cost
or more is. I wanted a handy app for my phone that I could 
pull out and plug in a single value (part weight) that would
quickly run the information for me. It's not a heavy app
but shows the principles of TDD in a new way.

Notice as well that the application makes use of fields, 
but not publicly available properties on the class objects.
Instead, I opted to inject in the interests through builder
patterns and single-use constructors.

## Ideological breakdown

This solution is focused on the proper implementation of
"Spec" testing (tall system specification testing) which
is an implementation of TDD that pushes an integration test,
which forces unit tests to be developed for MVP vertical 
slices of the feature/application/function. This encourages
minimalistic code with dependency injection as a paramount
principle.

This basic idea is:
1. Define in the spec the basic intent/system as a real object
2. Build out a single unit test to test the specific action
3. Build the real objects around the test
4. The spec should be broken during new development. If it's not, break it first.
5. If the spec is broken, and there are no broken unit tests, make new/break some unit tests
6. Make the unit tests pass by implementing as shallow/unintelligent code as possible
    6.a. (e.g. If a method is to return a boolean, let it return a hard value of true/false until you need it not to)
7. If a Spec/Unit is passing with dumb code, refine the spec to require a more specific expectation.

This methodology is uncomfortable because it has a lot of "dumb" code
and broken code continually (a lot of red squiggles), but I've found 
it easier after some practice. It's lower maintenance, alllows for 
rapid pivoting, builds in tests inherently, and requires loosely 
coupled development to truly work.

## Build notes
The PlasticCost.csproj is configured to render a NuGet package
upon build. This package is referenced by the PlasticCostCalculatorTests 
xUnit project, and will eventually be delivered to the MAUI UX as a 
loosely-coupled dependency.
