namespace TrainingApp
{
    public class Trainee
    {
        private string _traineeId;
        private string _name;
        public Trainee(string TraineeId,string Name)
        {
            _traineeId = "trainee_"+TraineeId;
            _name = Name;
        }
        public string GetTraineeId()
        {
            return _traineeId;
        }
        public string GetTraineeName()
        {
            return _name;
        }
    }
}
