namespace Library;
using System;
using TwitterUCU;
public class Passenger : Person
{
    

    public Passenger(string firstname, string lastname, string ci, string path)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.CI = ci;

        UploadToTwitter(path);
    }

    public override void UploadToTwitter(string path)
    {
        if (!HasFace(path))
        {
            // si no tiene cara le retorno una imagen por defecto
            path = "avatar.png";

        }


        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter($"Hola soy {this.FirstName} {this.LastName}", path));


    }
}