namespace GL01
{
    internal class BoxDrawings
    {
        public static string LightHorizontal(int px)
        {
            string lh = "─";
            if (px > 0)
                for (int i = 0; i < px; i++)
                {
                    lh += lh;

                }
            return lh;
        }
    }
}
