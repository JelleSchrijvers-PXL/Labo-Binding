using ActorsApplication.Data;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ActorsApplication.Pages;

public partial class ActorsPage : ContentPage
{
    public ActorsPage()
	{
		InitializeComponent();

        ActorsCollectionView.ItemsSource = InMemoryActors.GetActors();
    }

    private async void AddActorClicked(object sender, EventArgs e)
    {
        string lastName = await DisplayPromptAsync("Lastname", "");
        string firstName = await DisplayPromptAsync("Firstname", "");
        string bio = "n/a";
        
        // Add the actor to the list
    }
}