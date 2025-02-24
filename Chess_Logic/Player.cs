namespace Chess_Logic
{
    public enum Player
    {         //Stores player name and who won the game
        None,                   //Only used for Draw/Stalemate
        White,
        Black
    }

    public static class PlayerExtensions            //Extension Method
    {
        public static Player Opponent(this Player player)
        {
            return player switch                   //Swapping between player classes. Turns Black and White
            {
                Player.White => Player.Black,
                Player.Black => Player.White,
                _ => Player.None,
            };
        }
    }
}
