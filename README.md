# dotnet-test-self

A simple wrapper that passes execution from `dotnet test` to `dotnet run`.

## Usage

This wrapper is useful if you want to gain more control over test process - i.e. do some initialization or cleanup.

1. Add `dotnet-test-self` to project dependencies:

    "dotnet-test-self": "1.0.1"
    
2. Set `testRunner` in project.json to `self`:
	
	"testRunner": "self"
	
3. Reference the desired test runner/framework and start it in your `Main` method.

4. Run `dotnet test` - this will invoke `dotnet run` and start your application. 


