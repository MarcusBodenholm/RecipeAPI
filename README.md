# RecipeAPI
## Description
RecipeAPI is a simple ASP.NET Core Web API providing CRUD functionality for users, recipes, and ratings. It allows users to register, add recipes, and rate other users' recipes.
This was the first assignment of the course Programming with ASP.Net 1 at Nackademin. 

## Technologies
ASP.NET Core
Entity Framework
Swagger
MSSQL

## API Endpoints

**GET /api/user/id** - Gets the user with that id
**GET /api/user** - Gets all users
**POST /api/user** - Creates user
**PUT /api/user** - Updates user
**DELETE /api/user** - Deletes user
**POST /api/login** - Logs the user in

**GET /api/recipe/id** - Gets the recipe with the id
**GET /api/recipe** - Gets all recipies
**GET /api/recipe/user/{userid}/recipes** - Gets all recipes for the user with that id
**POST /api/recipe** - Creates a recipe
**PUT /api/recipe** - Updates a recipe
**DELETE /api/recipe/id** - Deletes a recipe
**GET /api/recipe/search** - Gets all recipes that matches the search term. 

**GET /api/rating/id** - Gets the rating with the id
**GET /api/rating/{recipeid}/ratings** - Gets all ratings for the recipe with that id
**POST /api/rating** - Creates a rating
**PUT /api/rating** - Updates a rating
**DELETE /api/rating/id** - Deletes a rating

**GET /api/category/id** - Gets the category with the id
**GET /api/category** - Gets all categories
**POST /api/category** - Creates a category
**PUT /api/category** - Updates a category
**DELETE /api/category/id** - Deletes a category

## Documentation
Swagger documentation is available at /swagger endpoint once the application is running.

