
//Stored Procedure: UpdateEmployeeSalary

CREATE PROCEDURE UpdateEmployeeSalary
(IN empID INT, IN newSalary INT, OUT oldSalary INT)
BEGIN
    //Retrieve the old salary value
    SELECT salary INTO oldSalary FROM employees WHERE id = empID;
    
    //Update the employee's salary
    UPDATE employees SET salary = newSalary WHERE id = empID;
END



[TestFixture]
public class EmployeeDALTests
{
    private MySqlConnection connection;
    private EmployeeDAL dal;

    [SetUp]
    public void Setup()
    {
        // Setup code to create a connection to the test database
        connection = new MySqlConnection("your_connection_string_here");
        dal = new EmployeeDAL(connection);
    }

    [TearDown]
    public void TearDown()
    {
        // Code to tear down and clean up the test database
        connection.Close();
    }

    [Test]
    public void TestUpdateEmployeeSalary()
    {
        // Arrange
        int empID = 1;
        int newSalary = 50000;
        int oldSalary;

        // Act
        dal.UpdateEmployeeSalary(empID, newSalary, out oldSalary);

        // Assert
        Assert.AreEqual(40000, oldSalary); // Assuming the old salary is 40000
        // 
}
Add additional assertions as needed
    }


