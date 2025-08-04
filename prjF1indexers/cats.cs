using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjF1indexers
{
    public class F1RaceDetails
    {
        int laps, raceWinners;
        string raceName, trackDifficulty;

        public F1RaceDetails(int laps, int raceWinners, string raceName, string trackDifficulty)
        {
            this.laps = laps;
            this.raceWinners = raceWinners;
            this.raceName = raceName;
            this.trackDifficulty = trackDifficulty;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.laps;
                else if (index == 1)
                    return this.raceWinners;
                else if (index == 2)
                    return this.raceName;
                else if (index == 3)
                    return this.trackDifficulty;
                return null;
            }

            set
            {
                if (index == 0)
                    this.laps = (int)value;
                else if (index == 1)
                    this.raceWinners = (int)value;
                else if (index == 2)
                    this.raceName = (string)value;
                else if (index == 3)
                    this.trackDifficulty = (string)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName == "laps")
                    return this.laps;
                else if (attrName == "raceWinners")
                    return this.raceWinners;
                else if (attrName == "name")
                    return this.raceName;
                else if (attrName == "difficulty")
                    return this.trackDifficulty;
                return null;
            }

            set
            {
                if (attrName.ToLower().Equals("laps"))
                    this.laps = (int)value;
                else if (attrName.ToLower().Equals("raceWinners"))
                    this.raceWinners = (int)value;
                else if (attrName.ToLower().Equals("name"))
                    this.raceName = (string)value;
                else if (attrName.ToLower().Equals("difficulty"))
                    this.trackDifficulty = (string)value;
            }
        }
    }
}
