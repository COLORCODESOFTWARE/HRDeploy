namespace MyCompany.Handlers
{
    
    
    public partial class BlobFactoryConfig : BlobFactory
    {
        
        public static void Initialize()
        {
            // register blob handlers
            RegisterHandler("EmployeesPhoto", "\"dbo\".\"Employees\"", "\"Photo\"", new string[] {
                        "\"EmployeeID\""}, "Employees Photo", "Employees", "Photo");
        }
    }
}
