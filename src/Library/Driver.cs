namespace Library;
using System;
using TwitterUCU;
public abstract class Driver : Person
{
    public string Bio { get; set; }
    public virtual Vehicle Vehicle { get; set; }
  

    public override void UploadToTwitter(string path)
    {

        if (!IsSmilling(path))
        {
            // si no esta sonriendo le retorno una imagen por defecto para que suba algo
            path = "avatar.png";
        }

        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter($"Hola soy {this.FirstName} {this.LastName}, mi bio es {this.Bio}", path));


    }
}