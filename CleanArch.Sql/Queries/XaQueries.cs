using System.Diagnostics.CodeAnalysis;
namespace CleanArch.Sql.Queries
{
    [ExcludeFromCodeCoverage]
    public static class XaQueries
    {
        public static string AllXa => "SELECT * FROM [Xa] (NOLOCK)";
        public static string XaById => "SELECT * FROM [Xa] (NOLOCK) WHERE [XaId] = @XaId";

        public static string XaByHuyenId => "SELECT * FROM [Xa] (NOLOCK) WHERE [HuyenId] = @HuyenId";
        public static string AddXa =>
            @"INSERT INTO [Xa] ([TenXa], [Note]) 
				VALUES (@TenXa, @Note)";
            @"INSERT INTO [Xa] ([HuyenId],[TenXa], [Note]) 
				VALUES (@HuyenId,@TenXa, @Note)";

        public static string UpdateXa =>
            @"UPDATE [Xa] 
            SET [TenXa] = @TenXa, 
				[Note] = @Note, 
            SET [HuyenId] =@HuyenId
                [TenXa] = @TenXa, 
				[Note] = @Note 
            WHERE [XaId] = @XaId";

        public static string DeleteXa => "DELETE FROM [Xa] WHERE [XaId] = @XaId";
    }
}