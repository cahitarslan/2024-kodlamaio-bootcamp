namespace Business.Utilities.Consts;

public static class ValidationMessages
{
    public struct Category
    {
        public static string NameNotEmpty { get; } = "Kategori adı boş bırakılamaz";
        public static string NameMinimumLength { get; } = "Kategori adı üç karakterden az olamaz";
        public static string NameMaximumLength { get; } = "Kategori adı elli karakterden fazla olamaz";
    }

    public struct Course
    {
        public static string TitleNotEmpty { get; } = "Kurs başlığı boş bırakılamaz";
        public static string TitleMinimumLength { get; } = "Kurs başlığı beş karakterden az olamaz";
        public static string TitleMaximumLength { get; } = "Kurs başlığı elli karakterden fazla olamaz";
        public static string DescriptionNotEmpty { get; } = "Kurs açıklaması boş bırakılamaz";
        public static string DescriptionMinimumLength { get; } = "Kurs açıklaması on karakterden az olamaz";
        public static string DescriptionMaximumLength { get; } = "Kurs başlığı beş yüz karakterden fazla olamaz";
        public static string InstructorNotEmpty { get; } = "Kursun eğitmeni olmak zorundadır";
        public static string CategoryNotEmpty { get; } = "Kursun kategorisi olmak zorundadır";
    }

    public struct Instructor
    {
        public static string FirstNameNotEmpty { get; } = "Eğitmen ismi boş bırakılamaz";
        public static string FirstNameMinimumLength { get; } = "Eğitmen ismi üç karakterden az olamaz";
        public static string LastNameNotEmpty { get; } = "Eğitmen soyismi boş bırakılamaz";
        public static string LastNameMinimumLength { get; } = "Eğitmen soyismi üç karakterden az olamaz";
        public static string EmailNotEmpty { get; } = "Eğitmen emaili boş bırakılamaz";
        public static string EmailEmailAddress { get; } = "Email adresi doğru formatta değil";
        public static string BioNotEmpty { get; } = "Biyografi alanı boş bırakılamaz";
        public static string BioMaximumLength { get; } = "Biyografi alanı beş yüz karakterden fazla olamaz";
    }
}
