using System;
using TrainingApp;
using Xunit;

namespace TrainingAppTestCases
{
    public class TrainingAppTestCases
    {
        [Fact]
        public void TestGetListOfTraineeByMentor()
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

            Assert.Equal(vamsi,admin.GetListOfTraineeByMentor(singh)[0]);
        }
    }
}
