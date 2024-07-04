using System.Diagnostics.CodeAnalysis;
namespace CleanArch.Sql.Queries
{
    [ExcludeFromCodeCoverage]
    public static class TinhQueries
    {
        public static string AllTinh => "SELECT * FROM [Tinh] (NOLOCK)";
        public static string TinhById => "SELECT * FROM [Tinh] (NOLOCK) WHERE [TinhId] = @TinhId";

        public static string TinhByQuocGiaId => "SELECT * FROM [Tinh] (NOLOCK) WHERE [QuocGiaId] = @QuocGiaId";
        public static string AddTinh =>
            @"INSERT INTO [Tinh] ([TenTinh], [Note]) 
				VALUES (@TenTinh, @Note)";
            @"INSERT INTO [Tinh] ([QuocGiaId],[TenTinh], [Note]) 
				VALUES (@QuocGiaId,@TenTinh, @Note)";

        public static string UpdateTinh =>
            @"UPDATE [Tinh] 
            SET [TenTinh] = @TenTinh, 
				[Note] = @Note, 
            SET [QuocGiaId] = @QuocGiaId,
                [TenTinh] = @TenTinh, 
				[Note] = @Note 
            WHERE [TinhId] = @TinhId";

        public static string DeleteTinh => "DELETE FROM [Tinh] WHERE [TinhId] = @TinhId";
    }
}