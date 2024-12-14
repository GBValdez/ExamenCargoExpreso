INSERT INTO public."__EFMigrationsHistory" ("MigrationId","ProductVersion") VALUES
	 ('20241213015903_InitialCreate','9.0.0'),
	 ('20241213203412_Create_at','9.0.0');

INSERT INTO public."AspNetRoles" ("Id","userUpdateId","deleteAt","createAt","updateAt","Name","NormalizedName","ConcurrencyStamp","userCreateId") VALUES
	 ('5c4b0bc8-0d07-4b76-b9ef-0d5d80c55dc1',NULL,NULL,NULL,NULL,'Admin','ADMIN',NULL,NULL);

INSERT INTO public."AspNetUsers" ("Id","userUpdateId","deleteAt","createAt","updateAt","UserName","NormalizedUserName","Email","NormalizedEmail","EmailConfirmed","PasswordHash","SecurityStamp","ConcurrencyStamp","PhoneNumber","PhoneNumberConfirmed","TwoFactorEnabled","LockoutEnd","LockoutEnabled","AccessFailedCount","userCreateId") VALUES
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006',NULL,NULL,NULL,NULL,'GBValdez','GBVALDEZ','test@gmail.com','TEST@GMAIL.COM',false,'AQAAAAIAAYagAAAAEMLMSFJCDEKuJPpOrSX6Eyr6w5U/WOiN9LdMFwcLyWju3uEYQHHwp8AFWRGeAQojKg==','WWO4K5L2IWKL7QBKQPYIF62FHKWYBFBA','01ce1064-82f1-4937-963e-c1d12f6de88b',NULL,false,false,NULL,true,0,NULL);




INSERT INTO public."AspNetUserRoles" ("UserId","RoleId") VALUES
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006','5c4b0bc8-0d07-4b76-b9ef-0d5d80c55dc1');


INSERT INTO public.brands ("userUpdateId","deleteAt","createAt","updateAt","name",description,"userCreateId") VALUES
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 15:10:40.483071-06','2024-12-13 13:55:15.809568-06','2024-12-13 15:10:40.514184-06','Apolo','Apolo',NULL),
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 15:13:18.433993-06','2024-12-13 14:40:40.553936-06','2024-12-13 15:13:18.435923-06','EE','EE','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 15:16:11.838556-06','2024-12-13 14:45:19.710844-06','2024-12-13 15:16:11.890039-06','Poyo','Poyo','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 (NULL,NULL,'2024-12-13 15:16:23.508007-06',NULL,'Semilla','Semilla','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 15:26:10.86084-06','2024-12-13 15:25:30.408535-06','2024-12-13 15:26:10.861646-06','Adios','Hola','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 17:02:22.388143-06','2024-12-13 17:02:07.161377-06','2024-12-13 17:02:22.389442-06','qw','hola','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 17:04:34.568197-06','2024-12-13 15:26:24.644442-06','2024-12-13 17:04:34.570237-06','OCO','OCOss','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006',NULL,'2024-12-13 17:01:55.471441-06','2024-12-13 17:31:32.568777-06','qwwqfq','qwf','6a940b19-51da-4d5a-8d2a-4e820ea0b006');

INSERT INTO public.catalogues ("userUpdateId","deleteAt","createAt","updateAt","name",description,"userCreateId") VALUES
	 (NULL,NULL,'2024-12-13 17:02:32.749757-06',NULL,'Hola','Hola','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 (NULL,NULL,'2024-12-13 17:02:42.48305-06',NULL,'Adios','Adios','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 17:11:15.335167-06','2024-12-13 17:04:55.184877-06','2024-12-13 17:11:15.385219-06','Papa','papa','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 17:14:07.464217-06','2024-12-13 17:13:42.465398-06','2024-12-13 17:14:07.4661-06','wdw','wdw','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 (NULL,NULL,'2024-12-13 17:21:43.857891-06',NULL,'ef','ef','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 17:32:02.447682-06','2024-12-13 17:31:43.352397-06','2024-12-13 17:32:02.44875-06','ttttt','ttt','6a940b19-51da-4d5a-8d2a-4e820ea0b006');


INSERT INTO public.products ("name",description,price,"brandId","catalogueId","userUpdateId","deleteAt","createAt","updateAt","userCreateId") VALUES
	 ('Fresa','aa',10.0,4,1,'6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 18:21:42.500768-06','2024-12-13 18:21:23.645287-06','2024-12-13 18:21:42.502547-06','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('Leche','SFQWF',1.0,4,1,NULL,NULL,'2024-12-13 18:23:01.108416-06',NULL,'6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('wdw','wdw',12.0,4,1,NULL,NULL,'2024-12-13 18:27:10.095141-06',NULL,'6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('aMIGO','amIGO',100.0,4,1,NULL,NULL,'2024-12-13 18:43:04.775873-06',NULL,'6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('WW','DEF',23.0,4,1,NULL,NULL,'2024-12-13 18:45:02.276405-06',NULL,'6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('gIRASOL','123',100.0,4,1,'6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 18:48:18.311042-06','2024-12-13 18:45:12.459284-06','2024-12-13 18:48:18.362142-06','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('AA','AA',100.0,7,2,NULL,NULL,'2024-12-13 18:48:30.211798-06',NULL,'6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('wef','efw',12.0,7,5,'6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 18:52:00.692063-06','2024-12-13 18:51:24.25931-06','2024-12-13 18:52:00.694174-06','6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('wqfq','qwfwq',100.0,7,2,NULL,NULL,'2024-12-13 18:55:13.228246-06',NULL,'6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('ola','1wfqw',100.0,4,1,NULL,NULL,'2024-12-13 18:56:04.095689-06',NULL,'6a940b19-51da-4d5a-8d2a-4e820ea0b006');
INSERT INTO public.products ("name",description,price,"brandId","catalogueId","userUpdateId","deleteAt","createAt","updateAt","userCreateId") VALUES
	 ('fff','qwfwqf',100.0,7,5,NULL,NULL,'2024-12-13 18:56:45.420692-06',NULL,'6a940b19-51da-4d5a-8d2a-4e820ea0b006'),
	 ('adio','qwfw',100.0,4,5,'6a940b19-51da-4d5a-8d2a-4e820ea0b006','2024-12-13 18:57:19.791995-06','2024-12-13 18:56:21.993111-06','2024-12-13 18:57:19.792908-06','6a940b19-51da-4d5a-8d2a-4e820ea0b006');
