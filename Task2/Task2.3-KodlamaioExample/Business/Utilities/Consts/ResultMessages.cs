namespace Business.Utilities.Consts;

public static class ResultMessages
{
    public struct Success
    {
        #region CategoryMessages
        public static string CategoryAdd { get; } = "Kategori başarıyla eklendi";
        public static string CategoryDelete { get; } = "Kategori başarıyla silindi";
        public static string CategoryUpdate { get; } = "Kategori başarıyla güncellendi";
        public static string CategoryInfoReceive { get; } = "Kategori bilgisi başarıyla alındı";
        public static string CategoriesInfoReceive { get; } = "Kategoriler başarıyla alındı";
        #endregion

        #region InstructorMessages
        public static string InstructorAdd { get; } = "Eğitmen başarıyla eklendi";
        public static string InstructorDelete { get; } = "Eğitmen başarıyla silindi";
        public static string InstructorUpdate { get; } = "Eğitmen başarıyla güncellendi";
        public static string InstructorInfoReceive { get; } = "Eğitmen bilgisi başarıyla alındı";
        public static string InstructorsInfoReceive { get; } = "Eğitmenler başarıyla alındı";
        #endregion

        #region CourseMessages
        public static string CourseAdd { get; } = "Kurs başarıyla eklendi";
        public static string CourseDelete { get; } = "Kurs başarıyla silindi";
        public static string CourseUpdate { get; } = "Kurs başarıyla güncellendi";
        public static string CourseInfoReceive { get; } = "Kurs bilgisi başarıyla alındı";
        public static string CoursesInfoReceive { get; } = "Kurslar başarıyla alındı";
        #endregion
    }

    public struct Error
    {
        #region CategoryMessages
        public static string CategoryAddServer { get; } = "Kategori ekleme işlemi yapılamadı: Sunucu hatası!";
        public static string CategoryDeleteServer { get; } = "Kategori ekleme işlemi yapılamadı: Sunucu hatası!";
        public static string CategoryNotFound { get; } = "Kategori bulunamadı";
        public static string CategoryGetServer { get; } = "Kategori bilgisi alınamadı: Sunucu hatası!";
        public static string CategoriesNotFound { get; } = "Hiçbir kategori bulunamadı";
        public static string CategoryGetAllServer { get; } = "Kategoriler alınamadı: Sunucu hatası!";
        public static string CategoryUpdateServer { get; } = "Kategori güncelleme işlemi yapılamadı: Sunucu hatası!";
        #endregion

        #region InstructorMessages
        public static string InstructorAddServer { get; } = "Eğitmen ekleme işlemi yapılamadı: Sunucu hatası!";
        public static string InstructorDeleteServer { get; } = "Eğitmen ekleme işlemi yapılamadı: Sunucu hatası!";
        public static string InstructorNotFound { get; } = "Eğitmen bulunamadı";
        public static string InstructorGetServer { get; } = "Eğitmen bilgisi alınamadı: Sunucu hatası!";
        public static string InstructorsNotFound { get; } = "Hiçbir eğitmen bulunamadı";
        public static string InstructorGetAllServer { get; } = "Eğitmenler alınamadı: Sunucu hatası!";
        public static string InstructorUpdateServer { get; } = "Eğitmen güncelleme işlemi yapılamadı: Sunucu hatası!";
        #endregion

        #region CourseMessages
        public static string CourseAddServer { get; } = "Kurs ekleme işlemi yapılamadı: Sunucu hatası!";
        public static string CourseDeleteServer { get; } = "Kurs ekleme işlemi yapılamadı: Sunucu hatası!";
        public static string CourseNotFound { get; } = "Kurs bulunamadı";
        public static string CourseGetServer { get; } = "Kurs bilgisi alınamadı: Sunucu hatası!";
        public static string CoursesNotFound { get; } = "Hiçbir kurs bulunamadı";
        public static string CourseGetAllServer { get; } = "Kurslar alınamadı: Sunucu hatası!";
        public static string CourseUpdateServer { get; } = "Kurs güncelleme işlemi yapılamadı: Sunucu hatası!";
        #endregion
    }


}
