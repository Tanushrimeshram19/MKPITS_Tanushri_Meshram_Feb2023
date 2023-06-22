/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ItemId]
      ,[Itemdesc]
      ,[BalQty]
      ,[createon]
  FROM [DrivenIt.Db].[dbo].[ItemMaster]

  insert into ItemMaster values(1,'tv',6,'23/2/2021')