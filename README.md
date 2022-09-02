# Steps to reproduce

- open the solution in Rider (I tested with 2022.2.2)
- run/debug both WebApplications at once
- make a change to `Shared.Class1`, for example rename `Prop1` to `NewName`

HotReload fails with message: 

```
Changes made in project 'WebApplication2' require restarting the application: Could not found output assembly for mvid: 18dc2bc6-f5cf-4a4b-ba67-e92a5e375e62
```

