# TODO-List

Implementation of simple TODO list using DDD approach.

This is a very simple concept of a To Do list, a Rest API which will store events that must be accomplished, informations include
start and end (timestamp), title and description of task, priority for the task.

Feel free to fix or improve this project.


## Layers

Divided on 4 layers, application, domain, service and infrastructure.

### Application

A Rest API to serve expose the resources, only contains the CRUD operations.

### Domain

A layer which will contain the core of the system and fundamentals definitions about the business as the entities and view models definitions and interfaces definitions. This layer does not depends upon other layers.

### Service

A layer which exposes internally the functionalities to others layers as Application or Infrastructure.

### Infrastructure

A layer which implements peripheric functionalities as data access, access to others APIs, mappers, etc. Here the repository implementation is made.


## Tasks

- [x] Creation of layers in projects
- [x] Definition of Service and Repository interfaces
- [x] Implementation of Repository interface
- [x] Implementation of Service interface
- [x] Implementation of Application layer
- [ ] Implementation and utilization of mappers by service
- [ ] Creation of entities unit tests
- [ ] Creation of controllers unit tests
