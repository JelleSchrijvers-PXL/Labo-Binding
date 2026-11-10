using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ActorsApplication.Data
{
    public class Actor : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string lastName = "";
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged();
            }
        }

        private string firstName = "";
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged();
            }
        }

        private string profilePicture = "";
        public string ProfilePicture
        {
            get => profilePicture;
            set
            {
                profilePicture = value;
                OnPropertyChanged();
            }
        }

        private int birthYear = 1950;
        public int BirthYear
        {
            get => birthYear;
            set
            {
                birthYear = value;
                OnPropertyChanged();
            }
        }

        private string shortBio = "";
        public string ShortBio
        {
            get => shortBio;
            set
            {
                shortBio = value;
                OnPropertyChanged();
            }
        }
    }
}