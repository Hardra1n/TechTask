namespace CoreLayer
{
    internal class Utils
    {
        public static string GetDriverDirectory()
        {
            DirectoryInfo dirInfo = new(Directory.GetCurrentDirectory());
            string resultDirecory = dirInfo.Parent.Parent.Parent.Parent.FullName 
                + "\\CoreLayer\\DriverBinary";
            return resultDirecory;
        }
    }
}
