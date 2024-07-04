using System.Diagnostics.CodeAnalysis;
namespace CleanArch.Sql.Queries
{
    [ExcludeFromCodeCoverage]
    public static class HuyenQueries
    {
        public static string AllHuyen => "SELECT * FROM [Huyen] (NOLOCK)";
        public static string HuyenById => "SELECT * FROM [Huyen] (NOLOCK) WHERE [HuyenId] = @HuyenId";

        public static string HuyenByTinhId => "SELECT * FROM [Huyen] (NOLOCK) WHERE [TinhId] = @TinhId";
        public static string AddHuyen =>
            @"INSERT INTO [Huyen] ([TenHuyen], [Note]) 
				VALUES (@TenHuyen, @Note)";
            @"INSERT INTO [Huyen] ([TinhId],[TenHuyen], [Note]) 
				VALUES (@TinhId,@TenHuyen, @Note)";

        public static string UpdateHuyen =>
            @"UPDATE [Huyen] 
            SET [TenHuyen] = @TenHuyen, 
				[Note] = @Note, 
            SET [TinhId] =@TinhId,
                [TenHuyen] = @TenHuyen, 
				[Note] = @Note 
            WHERE [HuyenId] = @HuyenId";

        public static string DeleteHuyen => "DELETE FROM [Huyen] WHERE [HuyenId] = @HuyenId";
    }
}