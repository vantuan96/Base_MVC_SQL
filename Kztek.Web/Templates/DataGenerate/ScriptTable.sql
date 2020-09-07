IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Student')
BEGIN
	CREATE TABLE [dbo].[Student](
	[Id] [nvarchar](128) NOT NULL,
	[Fullname] [nvarchar](250) NULL,
	[Email] [varchar](250) NULL,
	[Phone] [varchar](250) NULL,
	[IsDelete] bit not NULL default(0),
	[Active] bit not NULL default(0),
	[Birthday] [DATETIME] null,
	[Gender] [varchar] (10) NULL,
	[ImagePath] [varchar] (250) NULL,
	[UserAvatar] [varchar](250) NULL,
 CONSTRAINT [PK_dbo.Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END