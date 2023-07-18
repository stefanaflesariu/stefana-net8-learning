using Classwork;

/*Patient patient = new Patient("John Doe", 35, "Male");

patient.AddProblem("Cold");
patient.AddProblem("Arm fracture");
patient.AddProblem("Nut allergy");

patient.DisplayMedicalHistory();

//DisplayMedicalHistory output:

// Medical history of patient John Doe:
// - Cold
// - Arm fracture
// - Nut allergy

*/
ConstructionProject project = new ConstructionProject("Office Building", new DateTime(2023-08-01), new DateTime(2024-01-31), "ABC Construction", 500000.0f);

project.AddTask("Excavation", 10);
project.AddTask("Foundation", 20);
project.AddTask("Structural Framing", 30);
project.AddTask("Plumbing", 15);

Console.WriteLine(project.GetProjectDuration());  // Output: 75
Console.WriteLine(project.GetTotalCost());  // Output: 30000.0

List<string> tasks = project.GetTaskList();
foreach (string task in tasks)
{
    Console.WriteLine(task);
}

//Output:
// Excavation
// Foundation
// Structural Framing
// Plumbing