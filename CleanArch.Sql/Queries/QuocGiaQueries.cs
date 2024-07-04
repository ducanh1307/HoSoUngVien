using System.Diagnostics.CodeAnalysis;
namespace CleanArch.Sql.Queries
{
    [ExcludeFromCodeCoverage]
    public static class QuocGiaQueries
    {
        public static string AllQuocGia => "SELECT * FROM [QuocGia] (NOLOCK)";
        public static string QuocGiaById => "SELECT * FROM [QuocGia] (NOLOCK) WHERE [QuocGiaId] = @QuocGiaId";
        public static string AddQuocGia =>
            @"INSERT INTO [QuocGia] ([TenQuocGia], [Note]) 
				VALUES (@TenquocGia, @Note)";
        public static string UpdateQuocGia =>
            @"UPDATE [QuocGia] 
            SET [TenQuocGia] = @TenQuocGia, 
				[Note] = @Note, 
				[Note] = @Note 
            WHERE [QuocGiaId] = @QuocGiaId";

        public static string DeleteQuocGia => "DELETE FROM [QuocGia] WHERE [QuocGiaId] = @QuocGiaId";
    }
}