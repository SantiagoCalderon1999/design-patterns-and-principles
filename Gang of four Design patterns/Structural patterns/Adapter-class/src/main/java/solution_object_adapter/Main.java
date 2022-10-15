package solution_object_adapter;



public class Main {

	public static void main(String[] args) {
		/** Using Object Adapter **/
		Employee employee = new Employee();
		populateEmployeeData(employee);
		EmployeeObjectAdapter adapter = new EmployeeObjectAdapter(employee);
		BusinessCardDesigner designer = new BusinessCardDesigner();
		String card = designer.designCard(adapter); // It expects a customer but EmployeeClassAdapter implements that interface
		System.out.println(card);
	}

	private static void populateEmployeeData(Employee employee) {
		employee.setFullName("Elliot Alderson");
		employee.setJobTitle("Security Engineer");
		employee.setOfficeLocation("Allsafe Cybersecurity, New York City, New York");
	}
}
