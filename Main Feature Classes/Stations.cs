namespace StarshipRegistryGUI
    {
    public class Stations
        {
        public string stationName;
        public string stationClass;
        public string stationOperator;
        public string location;
        public string galacticQuadrant;
        public string crewCapacity;
        public string maximumOccupant;
        public string docking;
        public string weaponCapability;
        public string defenses;

        public Stations(string spRows)
            {
            string[] stationData = spRows.Split(',');

            this.stationName = stationData[0];
            this.stationClass = stationData[1];
            this.stationOperator = stationData[2];
            this.location = stationData[3];
            this.galacticQuadrant = stationData[4];
            this.crewCapacity = stationData[5];
            this.maximumOccupant = stationData[6];
            this.docking = stationData[7];
            this.weaponCapability = stationData[8];
            this.defenses = stationData[9];
            }

        public override string ToString()
            {
            string station = $"STATION NAME:   {stationName}" + "\n" +
                $"CLASS:   {stationClass}" + "\n" +
                $"STATION OPERATOR:   {stationOperator}" + "\n" +
                $"LOCATION:   {location}" + "\n" +
                $"GALACTIC QUADRANT:   {galacticQuadrant}" + "\n" +
                $"CREW CAPACITY:   {crewCapacity}" + "\n" +
                $"MAXIMUM OCCUPANCY:   {maximumOccupant}" + "\n" +
                $"DOCKING FACILITIES:   {docking}" + "\n" +
                $"PRIMARY WEAPONRY:   {weaponCapability}" + "\n" +
                $"DEFENSES:   {defenses}";
            return station;
            }
        }
    }
