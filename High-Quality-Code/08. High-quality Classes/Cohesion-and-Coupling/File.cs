namespace CohesionAndCoupling
{
    public static class File
    {
        public static string GetExtension(string fileName)
        {
            int indexOfLastDot = Utility.DotIndex(fileName);
            if (indexOfLastDot == -1)
            {
                return "";
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetName(string fileName)
        {
            int indexOfLastDot = Utility.DotIndex(fileName);
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
