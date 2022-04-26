IF NOT (EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_NAME = 'Employees'))
BEGIN
    CREATE TABLE [dbo].[Employees](
		[CompanyId] [int] NOT NULL,
		[CreatedOn] [datetime] NOT NULL,
		[DeletedOn] [datetime] NULL,
		[Email] [varchar](256) NULL,
		[Fax] [varchar](30) NULL,
		[Name] [varchar](256) NULL,
		[Lastlogin] [datetime] NULL,
		[Password] [varchar](32) NOT NULL,
		[PortalId] [int] NOT NULL,
		[RoleId] [int] NOT NULL,
		[StatusId] [int] NOT NULL,
		[Telephone] [varchar](30) NULL,
		[UpdatedOn] [datetime] NULL,
		[Username] [varchar](32) NOT NULL,
	 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
	(
		[CompanyId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
END
GO


