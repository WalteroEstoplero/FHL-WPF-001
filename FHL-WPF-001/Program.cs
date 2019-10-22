using System;
using System.Windows.Media;
using System.Windows;
using System.Windows.Input;

public class CMeinFenster: Window
{
	public CMeinFenster()
	{
        // Voreinstellungen

        // Titel des Fensters
        this.Title = "Inhalt des Fensters";

        // Schriftart und Größe
        this.FontFamily = new FontFamily("Verdana");
        this.FontWeight = FontWeights.ExtraBold;
        this.FontSize = 20;

/*
        // Inhalt mit den obigen Voreinstellungen ausgeben
        this.Content = "Das ist mein Inhalt";

        // Fenstergröße dem Text anpassen
        this.SizeToContent = System.Windows.SizeToContent.WidthAndHeight;
*/

        // Ein StackPanel
        System.Windows.Controls.StackPanel container = new System.Windows.Controls.StackPanel();
        for (int i = 1;i<= 10; i++)
        {
            System.Windows.Controls.Button knopf = new System.Windows.Controls.Button();
            knopf.Content = "Inhalt " + i;
            container.Children.Add(knopf);
        }
        this.Content = container;
    }

    protected override void OnMouseDown(MouseButtonEventArgs e)
    {
        base.OnMouseDown(e);
        this.Content = "Dieser Inhalt wurde durch das Ereignis Maus-Down hervorgerufen";
        this.SizeToContent = System.Windows.SizeToContent.WidthAndHeight;
    }
}

class CMeineApp : Application
{
    [STAThread]
    public static void Main()
    {
        CMeineApp app = new CMeineApp();
        app.Run();

    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        CMeinFenster einFenster = new CMeinFenster();
        einFenster.Show();
    }

}
