using System;

namespace simRender
{
    public class Walker
    {
        public float x, y;
        public float state;
        public float size;
        private Random random = new Random();

        public Walker(int size, int state)
        {
            x = random.Next(0, Constants.WIDTH);
            y = random.Next(0, Constants.HEIGHT);
            this.state = state;
            this.size = size;
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

        public void Infect(int walkNum, Walker[] walkers, float chance)
        {
            if (state == AgentStates.INFECTED)
            {
                for (int i = 0; i < walkNum; i++)
                {
                    Walker other = walkers[i];
                    if (this != other)
                    {
                        if (other.state != AgentStates.DEAD && other.state != AgentStates.RECOVERED)
                        {
                            if (x + size / 2 > other.x - other.size / 2 && x - size / 2 < other.x + other.size / 2)
                            {
                                if (y + size / 2 > other.y - other.size / 2 && y - size / 2 < other.y + other.size / 2)
                                {
                                    if (random.NextDouble() < chance)
                                    {
                                        walkers[i].state = AgentStates.INFECTED;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}