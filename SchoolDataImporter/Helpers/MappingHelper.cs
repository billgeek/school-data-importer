namespace SchoolDataImporter.Helpers
{
    public static class MappingHelper
    {
        public static string GetGradeClassCombination(string grade, string learnerClass)
        {
            var result = string.Empty;

            if (!string.IsNullOrEmpty(grade))
            {
                result = $"Gr. {grade}";
            }

            result += string.IsNullOrWhiteSpace(result) ? "" : " / ";
            result += learnerClass;

            return result;
        }
    }
}
