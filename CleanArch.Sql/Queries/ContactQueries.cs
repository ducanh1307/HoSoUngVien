﻿using System.Diagnostics.CodeAnalysis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Input;

namespace CleanArch.Sql.Queries
{
    [ExcludeFromCodeCoverage]
	public static class ContactQueries
	{
		public static string AllContact => "SELECT * FROM [Contact] (NOLOCK)";

		public static string ContactById => "SELECT * FROM [Contact] (NOLOCK) WHERE [ContactId] = @ContactId";

		public static string AddContact =>
			@"INSERT INTO [Contact] ([FirstName], [LastName], [Email], [PhoneNumber]) 
				VALUES (@FirstName, @LastName, @Email, @PhoneNumber)";

		public static string UpdateContact =>
			@"UPDATE [Contact] 
            SET [FirstName] = @FirstName, 
				[LastName] = @LastName, 
				[Email] = @Email, 
				[PhoneNumber] = @PhoneNumber
            WHERE [ContactId] = @ContactId";

		public static string DeleteContact => "DELETE FROM [Contact] WHERE [ContactId] = @ContactId";
	}
}
 22 changes: 22 additions & 0 deletions22  
CleanArch.Sql/Scripts/Contact.sql
Original file line number	Diff line number	Diff line change
@@ -0,0 +1,22 @@
USE [YourDBName]
GO

/****** Object:  Table [dbo].[Contact] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contact](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](200) NULL,
[LastName] [nvarchar](200) NULL,
	[Email] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](100) NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO﻿using System.Diagnostics.CodeAnalysis;

namespace CleanArch.Sql.Queries
{
    [ExcludeFromCodeCoverage]
	public static class ContactQueries
	{
		public static string AllContact => "SELECT * FROM [Contact] (NOLOCK)";

		public static string ContactById => "SELECT * FROM [Contact] (NOLOCK) WHERE [ContactId] = @ContactId";

		public static string AddContact =>
			@"INSERT INTO [Contact] ([FirstName], [LastName], [Email], [PhoneNumber]) 
				VALUES (@FirstName, @LastName, @Email, @PhoneNumber)";

		public static string UpdateContact =>
			@"UPDATE [Contact] 
            SET [FirstName] = @FirstName, 
				[LastName] = @LastName, 
				[Email] = @Email, 
				[PhoneNumber] = @PhoneNumber
            WHERE [ContactId] = @ContactId";

		public static string DeleteContact => "DELETE FROM [Contact] WHERE [ContactId] = @ContactId";
	}
}
 22 changes: 22 additions & 0 deletions22  
CleanArch.Sql/Scripts/Contact.sql
Original file line number	Diff line number	Diff line change
@@ -0,0 +1,22 @@
USE [YourDBName]
GO

/****** Object:  Table [dbo].[Contact] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contact](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](200) NULL,
[LastName] [nvarchar](200) NULL,
	[Email] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](100) NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO