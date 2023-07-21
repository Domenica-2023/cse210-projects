class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment();
        comment1._commentAuthor = "PrincessMimi";
        comment1._commentText = "This video is trash";

        Comment comment2 = new Comment();
        comment2._commentAuthor = "AnnaBanana";
        comment2._commentText = "I'm unfollowing";

        Comment comment3 = new Comment();
        comment3._commentAuthor = "QueenLunaAnn";
        comment3._commentText = "I wanna see more";

        Comment comment4 = new Comment();
        comment4._commentAuthor = "RileyJay";
        comment4._commentText = "When is the next video?";

        Comment comment5 = new Comment();
        comment5._commentAuthor = "Valerie;
        comment5._commentText = "Why aren't there more people watching this?";

        Comment comment6 = new Comment();
        comment6._commentAuthor = "SmellyGabriele";
        comment6._commentText = "Why do people hate this kind of stuff?";

        Video myVideo = new Video();

        myVideo._videoTitle = "ASMR";
        myVideo._videoAuthor = "GinaBina";
        myVideo._lengthInSeconds = 90

        myVideo._comments.Add(comment1); 
        myVideo._comments.Add(comment2); 
        myVideo._comments.Add(comment3);

        myVideo.Display();

        Video myOtherVideo = new Video();

        myOtherVideo._videoTitle = "DYI";
        myOtherVideo._videoAuthor = "HomerSimpson";
        myOtherVideo._lengthInSeconds = 120

        myOtherVideo._comments.Add(comment4); 
        myOtherVideo._comments.Add(comment5); 
        myOtherVideo._comments.Add(comment6);

        myOtherVideo.Display();
    }
}