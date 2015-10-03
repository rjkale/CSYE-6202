namespace BoxingWeights
{
    public class BoxingWeightClassifier
{
	public string ClassifyBoxingWeight(int weightInPounds)
{
            int weight = weightInPounds;

            if (0 <= weight && weight <= 105)
            {
                return "Strawweight and Heavyweight";
            }

            else if (105 < weight && weight <= 108)
            {
                return "JuniorFlyweight and Heavyweight";
            }

            else if (108 < weight && weight <= 112)
            {
                return "Flyweight and Heavyweight";
            } 

            else if (112 < weight && weight <= 115)
            {
                return "Bantamweight and Heavyweight";
            } 

            else if (115 < weight && weight <= 118)
            {
                return "Bantamweight and Heavyweight";
            }

            else if (118 < weight && weight <= 122)
            {
                return "JuniorFeatherweight and Heavyweight";
            }

            else if (122 < weight && weight <= 126)
            {
                return "Featherweight and Heavyweight";
            }

            else if (126 < weight && weight <= 130)
            {
                return "JuniorLightweight and Heavyweight";
            }

            else if (130 < weight && weight <= 135)
            {
                return "Lightweight and Heavyweight";
            }

            else if (135 < weight && weight <= 140)
            {
                return "JuniorWelterweight and Heavyweight";
            }

            else if (140 < weight && weight <= 147)
            {
                return "Welterweight and Heavyweight";
            }

            else if (147 < weight && weight <= 154)
            {
                return "JuniorMiddleweight and Heavyweight";
            }

            else if (154 < weight && weight <= 160)
            {
                return "Middleweight and Heavyweight";
            }

            else if (160 < weight && weight <= 168)
            {
                return "SuperMiddleweight and Heavyweight";
            }

            else if (168 < weight && weight <= 175)
            {
                return "LightHeavyweight and Heavyweight";
            }

            else if (175 < weight && weight <= 200)
            {
                return "Cruiserweight and Heavyweight";
            }

            else if (200 < weight)
            {
                return "Heavyweight";
            }


            string result = weight.ToString();
	return result;
	}
  }
}
