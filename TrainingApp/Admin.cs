using System.Collections.Generic;

namespace TrainingApp
{
    public class Admin
    {
        private Dictionary<Trainer, List<Trainee>> _listOfTraineesForTrainer = new Dictionary<Trainer, List<Trainee>>();
        private Dictionary<Mentor, List<Trainee>> _listOfTraineesForMentor = new Dictionary<Mentor, List<Trainee>>();
        private Dictionary<Trainee, KeyValuePair<Trainer,Mentor>> _trainerAndMentorForTrainee = new Dictionary<Trainee, KeyValuePair<Trainer, Mentor>>();
        private List<Trainee> _listOfTrainees = new List<Trainee>();
        private List<Mentor> _listOfMentors = new List<Mentor>();
        private List<Trainer> _listOfTrainers = new List<Trainer>();

        public void AssignTraineeToTrainerAndMentor(Trainee trainee,Trainer trainer,Mentor mentor)
        {
            _trainerAndMentorForTrainee.Add(trainee,new KeyValuePair<Trainer, Mentor>(trainer,mentor));
            AddTraineesToList(trainee);
            AddTrainersToList(trainer);
            AddMentorsToList(mentor);
            if (!_listOfTraineesForTrainer.ContainsKey(trainer))
            {
                _listOfTraineesForTrainer[trainer] = new List<Trainee>();
            }
            _listOfTraineesForTrainer[trainer].Add(trainee);
            if (!_listOfTraineesForMentor.ContainsKey(mentor))
            {
                _listOfTraineesForMentor[mentor] = new List<Trainee>();
            }
            _listOfTraineesForMentor[mentor].Add(trainee);
        }
        private void AddTraineesToList(Trainee trainee)
        {
            if (!_listOfTrainees.Contains(trainee))
            {
                _listOfTrainees.Add(trainee);
            }
        }
        private void AddTrainersToList(Trainer trainer)
        {
            if (!_listOfTrainers.Contains(trainer))
            {
                _listOfTrainers.Add(trainer);
            }
        }
        private void AddMentorsToList(Mentor mentor)
        {
            if (!_listOfMentors.Contains(mentor))
            {
                _listOfMentors.Add(mentor);
            }
        }
        public Dictionary<Trainee, KeyValuePair<Trainer, Mentor>> GetTrainees()
        {
            return _trainerAndMentorForTrainee;
        }
        public KeyValuePair<Trainer,Mentor> GetTrainerAndMentorByTrainee(Trainee trainee)
        {
            return _trainerAndMentorForTrainee[trainee];
        }
        public List<Trainee> GetListOfTraineeByMentor(Mentor mentor)
        {
            return _listOfTraineesForMentor[mentor];
        }
        public List<Trainee> GetListOfTraineeByTrainer(Trainer trainer)
        {
            return _listOfTraineesForTrainer[trainer];
        }
        public List<Mentor> GetListOfMentors()
        {
            return _listOfMentors;
        }
        public List<Trainee> GetListOfTrainees()
        {
            return _listOfTrainees;
        }
        public List<Trainer> GetListOfTrainers()
        {
            return _listOfTrainers;
        }
    }
}
