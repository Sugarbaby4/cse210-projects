using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("5 YEARS (in 20 minutes) Inspiring Renovation of an abandoned French CASTLE into DREAM HOME","How To Renovate A Chateau",1293);
        v1.AddComment(new Comment("angelajune6211", "I think we should all just take a moment to realize and appreciate how Anna painted an entire chateau with one hand.. props to you and well done 👏"));
        v1.AddComment(new Comment("jollenmeek658", "Your transformation of the Chateau is elegant, light, and airy. It is easy to see you gave it so much thought and care."));
        v1.AddComment(new Comment("jrgnc1", "Wow the people who take on these chateaus are a special breed.  The time, labor and $$$ it takes is unfathomable. Kudos to all of you."));
        videos.Add(v1);

        Video v2 = new Video("Cooking *ASMR* TikTok compilation", "Lily's food idea", 663);
        v2.AddComment(new Comment("friends_fan08", "THE FAUCET BY THE STOVE IS GENUIS"));
        v2.AddComment(new Comment("AvaWilliams-c3q", "I can almost smell it through the screen!"));
        v2.AddComment(new Comment("angel_ovo55", "that mac n cheese made me feel sick"));
        videos.Add(v2);

        Video v3 = new Video("Customizing a Dollhouse", "Moriah Elizabeth", 967);
        v3.AddComment(new Comment("cxmet6965", "You could make each room a colour in the rainbow as there are six rooms. Then you will be able to include more characters and the top of the dollhouse could be rainbow."));
        v3.AddComment(new Comment("BelleOfTheBrawl1", "They need a kitchen with mini versions of all the cakes youve made so far in your Bake With Me videos! 🧁🎂🍰✨"));
        v3.AddComment(new Comment("JaydeCronkhite", "“My name is…..block?” “Block!” Randon kiss got me dying😂"));
        videos.Add(v3);

        foreach (Video vid in videos)
        {
            vid.DisplayVideoInfo();
        }
    }
}