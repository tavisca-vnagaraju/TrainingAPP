namespace TrainingApp
{
    public class Mentor
    {
        private string _mentorId;
        private string _name;
        public Mentor(string MentorId, string Name)
        {
            _mentorId = "mentor_" + MentorId;
            _name = Name;
        }
        public string GetTrainerId()
        {
            return _mentorId;
        }
        public string GetTrainerName()
        {
            return _name;
        }
    }
}
