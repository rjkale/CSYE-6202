namespace BoxingWeights
{
    public class BoxingWeightClassifier
{
	public string ClassifyBoxingWeight(int weightInPounds)
{
            int weight = weightInPounds;

            if (weight < 105)
            {
                return "Strawweight";
            }

            else if (105 < weight && weight <= 108)
            {
                return "Junior Flyweight";
            }

            else if (108 < weight && weight <= 112)
            {
                return "Flyweight";
            }

            else if (112 < weight && weight <= 115)
            {
                return "Junior Bantamweight";
            }

            else if (115 < weight && weight <= 118)
            {
                return "Bantamweight";
            }

            else if (118 < weight && weight <= 122)
            {
                return "Junior Featherweight";
            }

            else if (122 < weight && weight <= 126)
            {
                return "Featherweight";
            }

            else if (126 < weight && weight <= 130)
            {
                return "Junior Lightweight";
            }

            else if (130 < weight && weight <= 135)
            {
                return "Lightweight";
            }

            else if (135 < weight && weight <= 140)
            {
                return "Junior Welterweight";
            }

            else if (140 < weight && weight <= 147)
            {
                return "Welterweight";
            }

            else if (147 < weight && weight <= 154)
            {
                return "Junior Middleweight";
            }

            else if (154 < weight && weight <= 160)
            {
                return "Middleweight ";
            }

            else if (160 < weight && weight <= 168)
            {
                return "Super Middleweight";
            }

            else if (168 < weight && weight <= 175)
            {
                return "Light Heavyweight";
            }

            else if (175 < weight && weight <= 200)
            {
                return "Cruiserweight";
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
