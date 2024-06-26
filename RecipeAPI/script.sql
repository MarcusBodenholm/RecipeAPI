USE [RecipeDB]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (1, N'Svensk husmanskost')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (2, N'Franskt')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (3, N'Italienskt')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (4, N'Kinesiskt')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (6, N'Test')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Username], [Password], [Email]) VALUES (1, N'Shedcape', N'hi', N'shed@cape.com')
INSERT [dbo].[Users] ([Id], [Username], [Password], [Email]) VALUES (2, N'Adam', N'hi', N'adam@adam.com')
INSERT [dbo].[Users] ([Id], [Username], [Password], [Email]) VALUES (3, N'metro', N'hi', N'metro@metro.com')
INSERT [dbo].[Users] ([Id], [Username], [Password], [Email]) VALUES (4, N'Test', N'hi', N'Test@test.com')
INSERT [dbo].[Users] ([Id], [Username], [Password], [Email]) VALUES (6, N'Admin', N'hi', N'cool@newemail.com')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Recipes] ON 

INSERT [dbo].[Recipes] ([Id], [Title], [Description], [CreatedById], [CategoryId], [Ingredients]) VALUES (1, N'Knäckebröd', N'Prima knäckebröd', 1, 1, N'Införskaffa knäckebröd')
INSERT [dbo].[Recipes] ([Id], [Title], [Description], [CreatedById], [CategoryId], [Ingredients]) VALUES (2, N'Cake', N'Delicious cake', 1, 1, N'One delicious cake.')
INSERT [dbo].[Recipes] ([Id], [Title], [Description], [CreatedById], [CategoryId], [Ingredients]) VALUES (6, N'Wifey', N'Wofe', 1, 1, N'1 wife, fresh')
INSERT [dbo].[Recipes] ([Id], [Title], [Description], [CreatedById], [CategoryId], [Ingredients]) VALUES (7, N'Påskpizza', N'En påskpizza', 6, 2, N'1 styck påsk, 1 styck pizza')
INSERT [dbo].[Recipes] ([Id], [Title], [Description], [CreatedById], [CategoryId], [Ingredients]) VALUES (8, N'Kyckling benedict', N'En Kyckling benedict', 6, 1, N'1 styck kyckling, 1 styck benedict')
INSERT [dbo].[Recipes] ([Id], [Title], [Description], [CreatedById], [CategoryId], [Ingredients]) VALUES (9, N'Grön sparrissoppa med ägg', N'Krämig grön sparrissoppa som går snabbt att laga. Perfekt när matlagningen behöver gå snabbt. Servera med kokta ägg och rädisor', 6, 3, N'10 dl grönsaksbuljong, 250 g grön sparris, 1 dl vetemjöl, 2 dl grädde, 1 knippe persilja, 1 tsk salt, 1 krm peppar')
INSERT [dbo].[Recipes] ([Id], [Title], [Description], [CreatedById], [CategoryId], [Ingredients]) VALUES (10, N'Matjessill med brynt smör och ägg', N'Brynt smör förhöjer smaken på matjessill. Servera med ägghalvor, färskpotatis, sallad och en ostsmörgås så har du en hel måltid', 4, 4, N'4 ägg, 400 g hela matjessillfiléer, 2 burkar, 800 g färskpotatis, 75 g smör, 1 hackad rödlök, 1 knippe hackad dill')
INSERT [dbo].[Recipes] ([Id], [Title], [Description], [CreatedById], [CategoryId], [Ingredients]) VALUES (11, N'Världens godaste frasvåfflor', N'Nygräddade frasvåfflor är bland det godaste som finns! Med vårt enkla recept och våra goda serveringstips kan du inte misslyckas', 3, 1, N'75 g smör, 4 dl vetemjöl, ½ tsk salt, ½ tsk bakpulver, 2½ dl mjölk, 2½ dl vatten, gärna kolsyrat')
INSERT [dbo].[Recipes] ([Id], [Title], [Description], [CreatedById], [CategoryId], [Ingredients]) VALUES (12, N'Laxpaté med räksås', N'Supergod laxpaté som funkar både som ensamrätt med varm räksås eller som en del av en buffé. Servera antingen varm eller kall', 2, 3, N'800 g färsk laxfilé, 4 ägg, 1 dl hackad dill, 2 tsk tomatpuré, 2 tsk salt, 1 krm cayennepeppar, 4 dl mellangrädde 27%')
INSERT [dbo].[Recipes] ([Id], [Title], [Description], [CreatedById], [CategoryId], [Ingredients]) VALUES (13, N'Trillingnöt med vit choklad', N'Trillingnöten är en älskad klassiker från Aladdin-lådan. Gör dina egna – superenkelt! Smält choklad, blanda i nötter och låt stelna', 1, 4, N'150 g hasselnötter, 200 g mjölkchoklad, 50 g mörk choklad')
SET IDENTITY_INSERT [dbo].[Recipes] OFF
GO
SET IDENTITY_INSERT [dbo].[Ratings] ON 

INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (5, 5, 6, 11)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (6, 5, 6, 10)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (7, 5, 6, 12)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (8, 4, 6, 10)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (9, 4, 6, 13)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (10, 3, 6, 13)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (11, 3, 4, 9)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (12, 2, 4, 9)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (13, 2, 4, 8)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (14, 5, 4, 8)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (15, 4, 4, 7)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (16, 4, 3, 7)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (17, 5, 3, 7)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (18, 5, 3, 9)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (19, 5, 2, 9)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (20, 5, 1, 9)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (21, 5, 4, 9)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (22, 1, 2, 10)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (23, 1, 2, 10)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (24, 1, 1, 10)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (25, 1, 1, 10)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (26, 5, 3, 10)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (27, 5, 4, 11)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (28, 4, 1, 11)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (29, 4, 2, 11)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (30, 5, 6, 11)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (31, 1, 6, 12)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (32, 1, 4, 12)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (33, 5, 3, 12)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (34, 5, 1, 12)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (35, 3, 2, 13)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (36, 3, 2, 13)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (37, 4, 3, 13)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (38, 1, 6, 13)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (39, 4, 4, 13)
INSERT [dbo].[Ratings] ([Id], [Value], [UserId], [RecipeId]) VALUES (40, 4, 4, 13)
SET IDENTITY_INSERT [dbo].[Ratings] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240320114225_initial', N'8.0.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240320114633_updated-recipes', N'8.0.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240320115720_updated-user', N'8.0.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240320130640_updated-lists', N'8.0.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240322110201_AdjustedCategory', N'8.0.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240322130116_AdjustedCascade', N'8.0.3')
GO
