namespace TrainingApp
{
    public class Trainer
    {
        private string _trainerId;
        private string _name;
        public Trainer(string TrainerId,string Name)
        {
            _trainerId = "trainer_" + TrainerId;
            _name = Name;
        }
        public string GetTrainerId()
        {
            return _trainerId;
        }
        public string GetTrainerName()
        {
            return _name;
        }
    }
}
