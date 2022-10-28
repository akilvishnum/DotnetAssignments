// See https://aka.ms/new-console-template for more information
interface GovtRules
{
    public double EmployeePF(double basicSalary);
    public string LeaveDetails();
    public double gratuityAmount(float serviceCompleted, double basicSalary);
}

class Tcs : GovtRules
{
    public string Name
    {
        get; set;
    }
    public int EmpId
    {
        get; set;
    }
    public double BasicSalary
    {
        get; set;
    }
    public string Department
    {
        get; set;
    }
    public string Designation
    {
        get; set;
    }
    public Tcs(string name, int id, double bSalary, string dept, string designation)
    {
        Name = name;
        EmpId = id;
        BasicSalary = bSalary;
        Department = dept;
        Designation = designation;
    }
    public double EmployeePF(double basicSalary)
    {
        double providentFund = 0.12 * basicSalary;
        double employerContributionFund = 0.833 * basicSalary;
        return providentFund + employerContributionFund;
    }
    public string LeaveDetails()
    {
        return "1 day of Casual leave per month. \n 10 days of Previlage Leave per year. \n 12 days of sick leave per year.";
    }
    public double gratuityAmount(float serviceCompleted, double basicSalary)
    {
        return 0;
    }
}
    class WellsFargo: GovtRules
{
    public string Name
    {
        get; set;
    }
    public int EmpId
    {
        get; set;
    }
    public double BasicSalary
    {
        get; set;
    }
    public string Department
    {
        get; set;
    }
    public string Designation
    {
        get; set;
    }
    public WellsFargo(string name, int id, double bSalary, string dept, string designation)
    {
        Name = name;
        EmpId = id;
        BasicSalary = bSalary;
        Department = dept;  
        Designation = designation;
    }
    public double EmployeePF(double basicSalary)
    {
        double providentFund = 0.12 * basicSalary;
        double employerContributionFund = 0.12 * basicSalary;
        return providentFund + employerContributionFund;
    }
   public string LeaveDetails()
    {
        return "1 day of Casual leave per month. \n 10 days of Previlage Leave per year. \n 12 days of sick leave per year.";
    }
    public double gratuityAmount(float serviceCompleted, double basicSalary)
    {
        return 0;
    }

    
        public static void Main(String[] args)
    {
        WellsFargo wf = new WellsFargo("Akil", 2092304, 400000, "technology infrasture", "Program Associate");
        Console.WriteLine("Employeer Details....");
        Console.WriteLine("Name is " + wf.Name);
        Console.WriteLine("Employee Id is " + wf.EmpId);
        Console.WriteLine("Department is " + wf.Department);
        Console.WriteLine("Designation is " + wf.Designation);
        Console.WriteLine("Employer Provident Fund for a year is  " + wf.EmployeePF(wf.BasicSalary));
        Console.WriteLine("Employer Leave Details is " + wf.LeaveDetails());
        Console.WriteLine("Employer Gratuity Amount for a year is  " + wf.gratuityAmount(5, wf.BasicSalary));

    }
}
