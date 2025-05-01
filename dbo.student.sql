CREATE TABLE [dbo].[student] (
    [st_Id]      VARCHAR (10)  NOT NULL,
    [st_name]    VARCHAR (100) NOT NULL,
    [dob]        DATE          NULL,
    [gender]     VARCHAR (10)  NULL,
    [st_address] VARCHAR (255) NULL,
    [contactNo]  VARCHAR (15)  NOT NULL,
    PRIMARY KEY CLUSTERED ([st_Id] ASC)
);

