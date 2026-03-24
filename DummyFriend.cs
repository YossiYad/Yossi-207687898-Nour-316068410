using System;

namespace BasicFacebookFeatures
{
    class DummyFriend
    {
        private readonly string r_Name;
        private readonly int r_InteractionScore;

        public DummyFriend(string i_Name, int i_InteractionScore)
        {
            r_Name = i_Name;
            r_InteractionScore = i_InteractionScore;
        }

        public string Name
        {
            get
            {
                return r_Name;
            }
        }

        public int InteractionScore
        {
            get
            {
                return r_InteractionScore;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} (Score: {1})", r_Name, r_InteractionScore);
        }
    }
}