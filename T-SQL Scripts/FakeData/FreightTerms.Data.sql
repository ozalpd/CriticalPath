SET IDENTITY_INSERT [dbo].[FreightTerms] ON 
INSERT [dbo].[FreightTerms] ([Id], [IncotermCode], [Description], [IsPublished]) VALUES
  (1, N'EXW', NULL, 0)
 ,(2, N'FCA', NULL, 0)
 ,(3, N'FAS', NULL, 0)
 ,(4, N'FOB', NULL, 1)
 ,(5, N'CPT', NULL, 0)
 ,(6, N'CFR (CNF)', NULL, 0)
 ,(7, N'CIF', NULL, 1)
 ,(8, N'CIP', NULL, 0)
 ,(9, N'DAT', NULL, 0)
 ,(10, N'DAP', NULL, 0)
 ,(11, N'DDP', NULL, 0)
SET IDENTITY_INSERT [dbo].[FreightTerms] OFF
