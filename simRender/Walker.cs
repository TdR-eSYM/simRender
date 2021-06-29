using System;

namespace simRender
{
    public class Walker
    {
        public float x, y;
        private Random random = new Random();

        public Walker()
        {
            x = random.Next(0, Constants.WIDTH);
            y = random.Next(0, Constants.HEIGHT);
        }

        public void Step()
        {
            float speed = 2;

            double r = random.NextDouble();
            if (r < 0.25)
            {
                x += speed;
            }
            else if (r < 0.5)
            {
                x -= speed;
            }
            else if (r < 0.75)
            {
                y += speed;
            }
            else
            {
                y -= speed;
            }

            if (x < 0) x = 0;
            if (x > Constants.WIDTH) x = Constants.WIDTH;
            if (y < 0) y = 0;
            if (y > Constants.HEIGHT) y = Constants.HEIGHT;
        }
    }

}