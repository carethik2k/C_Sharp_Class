namespace Solution_1
{
    class Bike
    {
        public string DisplayBikeInfo { get; private set; } 

        public Bike()
        {
            DisplayBikeInfo = "Hi. I am a bike. I can take one or two members. ";
        }

        public string GetBikeInfo()
        {
            return DisplayBikeInfo;
        }

    }
}