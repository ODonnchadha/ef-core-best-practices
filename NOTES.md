## EF Core 6: Best Practices

- OVERVIEW:
  - The best patterns for data-centric solutions.
  - Prerequisites: .NET 6, C# 10, & EF Core.

- STRUCTURING YOUR PROJECT FOR CLEANLINESS & TESTABILITY:
  - EF Core 6. .NET 6. Visual Studio 2022. C# 10. Docker Desktop 4.3.2.
  - Seperation of concerns:
    - Security. Entity Relationships. Validation. Schema Evolution. Authentication. Authorization.
    - Representation. Paging. Sorting. Filtering. Aggregation. Logging. Governance. Representation.
  - [Clean Architecture Template](https://github.com/ardalis/cleanarchitecture):
    - API:
    - Infrastructure:
    - Domain:
    - Shared Kernel:
  - Remove storage concerns away from the domain model.
    - Repository Pattern:
      - Illusion of an in-memory collection of objects.
      - A specification is an object that describes a set of criteria.
      - Specification pattern. Encapsulates a LINQ expression. Do not polute the domain code.
      - Data storage should never leak into the domain layer.
      - DBSet provides the illusion of a collection of entities ready to use.
      - Specification: LINQ. Repository: DbSet<>. Database Interface: Query Provider.
  
  - DOMAIN: Use the generic DbContextOptions. Keep entity configuration(s) isolated.
  - INFRASTRUCTURE: Keep DB configuration seperate from application domain. Keep migrations seperate from model.

- DESIGNING SECURITY INTO YOUR APPLICATION & PROCESS:
