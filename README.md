# Authorization Handler demo

The `HandleRequirementAsync` method of my [CustomRequirementAuthorizationHandler](Models/CustomRequirementAuthorizationHandler.cs) gets called twice. It behaves this way because a global `AuthorizeFilter` was added to the `Filters` collection in the `Startup` class.