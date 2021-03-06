using System;

namespace TrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee vamsi = new Trainee("01", "Vamsi");
            Trainee naveen = new Trainee("02", "Naveen");
            Trainee venkat = new Trainee("03", "venkat");
            Trainee chaitanya = new Trainee("04", "chaitanya");
            Trainer pankaj = new Trainer("01", "Pankaj");
            Mentor singh = new Mentor("01", "Singh");
            Mentor ravindra = new Mentor("02", "ravindra");
            Admin admin = new Admin();
            admin.AssignTraineeToTrainerAndMentor(vamsi, pankaj, singh);
            admin.AssignTraineeToTrainerAndMentor(naveen, pankaj, ravindra);
            admin.AssignTraineeToTrainerAndMentor(chaitanya, pankaj, ravindra);
            admin.AssignTraineeToTrainerAndMentor(venkat, pankaj, singh);
            var helo = admin.GetListOfTraineeByMentor(singh);
            Console.WriteLine(helo.Count);
            Console.ReadKey();
        }
    }
    public class Assignment
    {
        string Title { get; set; }
        string Description { get; set; }
    }
}
