namespace ActorsApplication.Pages;

public partial class ViewToViewBinding : ContentPage
{
	public ViewToViewBinding()
	{
		InitializeComponent();
	}
    private void OnColorPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        if (colorPicker.SelectedIndex == -1)
            return;

        string selectedColor = colorPicker.SelectedItem.ToString();

        Color color = selectedColor switch
        {
            "Green" => Colors.Green,
            "Yellow" => Colors.Yellow,
            "Red" => Colors.Red,
            "Orange" => Colors.Orange,
            _ => Colors.Black
        };

        displayLabel.TextColor = color;
        colorPicker.BackgroundColor = color;
    }
}