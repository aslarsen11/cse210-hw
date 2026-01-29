using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // a list of Video objects
        List<Video> videos = new List<Video>();

        Console.WriteLine("");
        Console.WriteLine("       View Video & Comment Data");

        // Creates 4 Video objects.
        Video vid1 = new Video();
        Video vid2 = new Video();
        Video vid3 = new Video();
        Video vid4 = new Video();

        vid1._title = "How Avengers Infinity War Should Have Ended - Animated Parody";
        vid1._author = "How It Should Have Ended";
        vid1._length = 663;

        //Put each Video in the Video list
        videos.Add(vid1);

        // 3 instances of the Comment class for the vid1 object
        Comment comment1a = new Comment();
        Comment comment1b = new Comment();
        Comment comment1c = new Comment();

        // Setting the values for the 4 Comment objects
        comment1a._name = "Blizzic";
        comment1a._commentText = "Siri didn't know how to get to Wakanda";
        comment1b._name = "riverfreakingsong";
        comment1b._commentText = "I just noticed Spider-man has a soda bc he's too young to drink, I appreciate the small details";
        comment1c._name = "Sphemus";
        comment1c._commentText = "Imagine how powerful this Thor would be with BOTH Stormbreaker & the complete Infinity Gauntlet.";
        
        // Add each Video's comments to the Comment list
        vid1._comments.Add(comment1a);
        vid1._comments.Add(comment1b);
        vid1._comments.Add(comment1c);

        vid2._title = "She-Hulk Pitch Meeting";
        vid2._author = "Pitch Meeting";
        vid2._length = 389;

        //Put each Video in the Video list
        videos.Add(vid2);

        // 4 instances of the Comment class for the vid2 object
        Comment comment2a = new Comment();
        Comment comment2b = new Comment();
        Comment comment2c = new Comment();
        Comment comment2d = new Comment();

        comment2a._name = "supdude69";
        comment2a._commentText = "SUPER EASY, BARLEY AN INCONVENIENCE";
        comment2b._name = "DutchDread";
        comment2b._commentText = "Ryan George trying to walk that 'can I criticize She-hulk?' tightrope is TIGHT";
        comment2c._name = "ichosedebateoveranger1520";
        comment2c._commentText = "She hulk writers making the line 'you dont have to deal with what i do' as they forget the line 'i tried to kill myself a lot, but every time i put the gun in my mouth, the other guy spits it out'";
        comment2d._name = "gangstaboogie718";
        comment2d._commentText = "'Give me something, please' is the best way to describe what watching this show was like.";

        // Add each Video comments to the Comment list
        vid2._comments.Add(comment2a);
        vid2._comments.Add(comment2b);
        vid2._comments.Add(comment2c);
        vid2._comments.Add(comment2d);

        vid3._title = "Star Wars: The Rise of Skywalker - Movie Review";
        vid3._author = "Jeremy Jahns";
        vid3._length = 562;

        //Put each Video in the Video list
        videos.Add(vid3);

        // 3 instances of the Comment class for the vid3 object
        Comment comment3a = new Comment();
        Comment comment3b = new Comment();
        Comment comment3c = new Comment();

        comment3a._name = "themanleyman5430";
        comment3a._commentText = "They did it. Disney broke Jeremy, the most optimistic reviewer I have ever watched";
        comment3b._name = "ShreeNation";
        comment3b._commentText = "I dont know what Jeremy is talking about. I loved this movie for Kylo Ren especially when he starts arguing with Scarlett Johansson about their marriage.";
        comment3c._name = "MrMoon360";
        comment3c._commentText = "'There's a difference between bold and desperate.' - Jeremy Jahns 2019";

        // Add each Video comments to the Comment list
        vid3._comments.Add(comment3a);
        vid3._comments.Add(comment3b);
        vid3._comments.Add(comment3c);

        vid4._title = "I Built a Theme Park of Perpetual Torment in Planet Coaster";
        vid4._author = "Let's Game It Out";
        vid4._length = 965;

        //Put each Video in the Video list
        videos.Add(vid4);

        // 4 instances of the Comment class for the vid4 object
        Comment comment4a = new Comment();
        Comment comment4b = new Comment();
        Comment comment4c = new Comment();
        Comment comment4d = new Comment();

        comment4a._name = "_coffeebean_";
        comment4a._commentText = "You know what makes this even better? The fact that most of these NPCs are actually modeled after real people who supported this game and, as a reward, were given the chance to be in this game. Only to have their virtual selves getting tortured by Josh, lol";
        comment4b._name = "konooleh";
        comment4b._commentText = "Typical Josh: How high can you go? How many of these can you add? Moment later: Human shotgun scoring people into the basket";
        comment4c._name = "eduardoBR1991";
        comment4c._commentText = "I love how the planet franchise allows Josh's hellish creativity to be unleashed";
        comment4d._name = "Ps35176";
        comment4d._commentText = "Whenever Josh says 'Oh no' you can hear the wicked grin and I love that.";

        // Add each Video comments to the Comment list
        vid4._comments.Add(comment4a);
        vid4._comments.Add(comment4b);
        vid4._comments.Add(comment4c);
        vid4._comments.Add(comment4d);

        // Iterates through the list of Video objects
        foreach(Video v in videos)
        {
            // Calls the Display method in the Video.cs file 
            v.Display();
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }

        Console.WriteLine("");
    }
}