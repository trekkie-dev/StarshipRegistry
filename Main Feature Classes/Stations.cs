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
        public string status;

        public Stations(string stationName, string stationClass, string stationOperator, string location, string galacticQuadrant, string crewCapacity, string maximumOccupant, string docking, string weaponCapability, string defenses, string active)
            {
            this.stationName = stationName;
            this.stationClass = stationClass;
            this.stationOperator = stationOperator;
            this.location = location;
            this.galacticQuadrant = galacticQuadrant;
            this.crewCapacity = crewCapacity;
            this.maximumOccupant = maximumOccupant;
            this.docking = docking;
            this.weaponCapability = weaponCapability;
            this.defenses = defenses;
            this.status = active;
            }
        }

    }

